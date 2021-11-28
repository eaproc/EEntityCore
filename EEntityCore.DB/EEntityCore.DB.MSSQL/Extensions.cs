using EEntityCore.DB.Exceptions;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEntityCore.DB.MSSQL
{
    public static class Extensions
    {
        /// <summary>
        /// Get RS using Specific DB. Throws Exception.
        /// Returns DataSet or throws Exception
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// <remarks></remarks>
        public static string GetScopeIdentity(this SqlConnection Connection)
        {
            try
            {
                var sqlCommand = new SqlCommand();
                using (sqlCommand)
                {
                    sqlCommand.Connection = Connection;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandTimeout = 0;  // no time out here

                    return sqlCommand.GetScopeIdentity();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get RS using Specific DB. Throws Exception.
        /// Returns DataSet or throws Exception
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// <remarks></remarks>
        public static string GetScopeIdentity(this SqlCommand sqlCommand)
        {
            try
            {
                sqlCommand.CommandText = "SELECT SCOPE_IDENTITY()";
                return Conversions.ToString(sqlCommand.ExecuteScalar());
            }
            catch (Exception)
            {
                throw;
            }
        }  
        
        /// <summary>
        /// Get RS using Specific DB. Throws Exception.
        /// Returns DataSet or throws Exception
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// <remarks></remarks>
        public static string GetScopeIdentity(this DBTransaction transaction)
        {
            return Conversions.ToString(transaction.ExecuteScalarTransactionQuery("SELECT SCOPE_IDENTITY()"));
        }


        /// <summary>
        /// Specify database to use
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool DbExec(this SqlConnection Connection, string SQL)
        {
            try
            {
                var sqlCommand = new SqlCommand();
                using (sqlCommand)
                {
                    sqlCommand.Connection = Connection;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandTimeout = 0;  // no time out here
                    sqlCommand.CommandText = SQL;
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                var ex2 = new SQLCodeException(SQL, ex);
                throw ex2;
            }

            return true;
        }

    }
}
