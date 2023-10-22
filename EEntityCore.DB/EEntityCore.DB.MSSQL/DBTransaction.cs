using EEntityCore.DB.MSSQL.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEntityCore.DB.MSSQL
{
    /// <summary>
    /// This connection will be closed after usage
    /// </summary>
    public partial class DBTransaction:IDisposable
    {

        private SqlConnection DBTransactionConn = null;
        private readonly SqlCommand DBTransactionCommand = null;

        public string TransactionName { get; }
        /// <summary>
        /// Store Queries Executed Against Time taken in millisecs
        /// </summary>
        public List<QueryTimeReport> Queries { get; private set; }

        private readonly SqlTransaction CommandTransactionPointer = null;
        private bool disposedValue;
        private readonly IQueryTracer _queryTracer;
        private readonly bool _traceQuery;
        private bool finalizedTransaction;

        /// <summary>
        /// Indicate a transaction that requires commit has been run
        /// </summary>
        private bool touched;

        public DBTransaction(SqlConnection Connection, IQueryTracer tracer = null, bool traceQuery = false)
        {
            finalizedTransaction = false;
            disposedValue = false;

            _queryTracer = tracer;
            _traceQuery = traceQuery;

            this.Queries = new List<QueryTimeReport>();

            this.DBTransactionConn = Connection;

            this.DBTransactionCommand = DBTransactionConn.CreateCommand();
            // Start a local transaction.
            // Maximum Identifier length | Transaction Name is 32 characters
            this.TransactionName = "TRANS: " + DateTime.Now.ToString() + new Random().Next(99).ToString();
            this.CommandTransactionPointer = DBTransactionConn.BeginTransaction(this.TransactionName);

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            DBTransactionCommand.Connection = DBTransactionConn;
            DBTransactionCommand.Transaction = CommandTransactionPointer;

        }


       



        /// <summary>
        /// UPDATE, INSERT, and DELETE. Returns numbers of rows affected. -1 if unsuccessful or different statement
        /// Auto Rollback
        /// </summary>
        /// <param name="pSQL"></param>
        /// <returns>boolean</returns>
        public int ExecuteTransactionQuery(string pSQL)
        {
            if (this.finalizedTransaction || this.disposedValue) throw new InvalidOperationException("Transaction is not in a good state!");

            // begin timing
            QueryExecutionTimer timer = null;
            bool isSucceeded = true;
            try
            {
                touched = true;

                DBTransactionCommand.CommandType = CommandType.Text;
                DBTransactionCommand.CommandTimeout = 0;  // no time out here
                DBTransactionCommand.CommandText = pSQL;

                using (timer = new(pSQL))
                {
                    return this.DBTransactionCommand.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                this.RollBackDBTransaction();
                isSucceeded = false;

                Exceptions.DuplicateRowException.DetectAndThrow(ex);
                Exceptions.DeleteForeignKeyException.DetectAndThrow(ex);
                Exceptions.TooLargeNumericValue.DetectAndThrow(ex);
                Exceptions.UpdateForeignKeyException.DetectAndThrow(ex, SQL: pSQL);
                Exceptions.DataTruncateException.DetectAndThrow(ex, SQL: pSQL);

                throw;
            }
            finally
            {
                // end timing
                // record timing
                Queries.Add(new(sql: pSQL, succeeded: isSucceeded, elapsedMilliseconds:timer.ElapsedMilliseconds));
            }
        }



        /// <summary>
        /// UPDATE, INSERT, and DELETE. Returns numbers of rows affected. -1 if unsuccessful or different statement
        /// AUTO ROLLBACK
        /// </summary>
        /// <param name="pSQL"></param>
        /// <returns>boolean</returns>
        public object ExecuteScalarTransactionQuery(string pSQL)
        {
            if (this.finalizedTransaction || this.disposedValue) throw new InvalidOperationException("Transaction is not in a good state!");

            // begin timing
            QueryExecutionTimer timer = null;
            bool isSucceeded = true;

            try
            {
                touched = true;

                this.DBTransactionCommand.CommandText = pSQL;

                using (timer = new(pSQL))
                {
                    return this.DBTransactionCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                this.RollBackDBTransaction();
                isSucceeded = false;
                Exceptions.DuplicateRowException.DetectAndThrow(ex);
                Exceptions.DeleteForeignKeyException.DetectAndThrow(ex);
                Exceptions.TooLargeNumericValue.DetectAndThrow(ex);
                Exceptions.UpdateForeignKeyException.DetectAndThrow(ex);

                throw;
            }
            finally
            {
                // end timing
                // record timing
                Queries.Add(new(sql: pSQL, succeeded: isSucceeded, elapsedMilliseconds: timer.ElapsedMilliseconds));
            }
        }

        public DataSet Fetch(string SQL)
        {
            if (this.finalizedTransaction || this.disposedValue) throw new InvalidOperationException("Transaction is not in a good state!");

            // begin timing
            QueryExecutionTimer timer = null;
            bool isSucceeded = true;

            try
            {
                using (timer = new(SQL))
                {
                    DataSet srs = new();
                    DBTransactionCommand.CommandText = SQL;

                    var da = new SqlDataAdapter(DBTransactionCommand);
                    da.Fill(srs);

                    return srs;
                }
            }
            catch (Exception)
            {
                this.RollBackDBTransaction();
                isSucceeded = false;
                throw;
            }
            finally
            {
                // end timing
                // record timing
                Queries.Add(new(sql: SQL, succeeded: isSucceeded, elapsedMilliseconds: timer.ElapsedMilliseconds));
            }
        }


        /// <summary>
        /// Commit DB Transaction Query
        /// </summary>
        public void CommitDBTransaction()
        {
            if (this.finalizedTransaction || this.disposedValue || !this.touched ) return;

            // Attempt to commit the transaction.
            this.CommandTransactionPointer.Commit();
            this.finalizedTransaction = true;
        }

        /// <summary>
        /// If there is a logic error, then force rollback
        /// </summary>
        public void ForceRollBackOnLogic()
        {
            if (this.finalizedTransaction || this.disposedValue || !this.touched) return;
            this.RollBackDBTransaction();
        }

        /// <summary>
        /// Rollback
        /// </summary>
        private void RollBackDBTransaction()
        {
            if (this.finalizedTransaction || this.disposedValue) return;

            // Attempt to commit the transaction.
            this.CommandTransactionPointer.Rollback();
            this.finalizedTransaction = true;

        }

        /// <summary>
        /// This will call the commit automatically if you have not called it
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    if (!this.finalizedTransaction) this.CommitDBTransaction();

                    if( _traceQuery && _queryTracer != null )
                        _queryTracer.TraceSqlQuery(Queries.ToArray());

                    this.DBTransactionConn.Dispose();
                    this.DBTransactionConn = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~DBTransaction()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
