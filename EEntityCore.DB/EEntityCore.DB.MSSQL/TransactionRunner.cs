using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEntityCore.DB.MSSQL
{
    public class TransactionRunner : IDisposable
    {
        private bool AllowDispose;
        public DBTransaction Transaction { get; private set; }

        public TransactionRunner(DBTransaction trans, bool allowDispose = true)
        {
            Transaction = trans;
            AllowDispose = allowDispose;
        }

        /// <summary>
        /// NB: This will call dispose immediately if allowed
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        public T Run<T>(Func<DBTransaction, T> action)
        {
            var r = action(this.Transaction);

            // Dispose immediately if no need to hold for long
            if (AllowDispose) this.Dispose();

            return r;
        }

        //public static T InvokeRun<T>(Func<DBTransaction, T> action, DBTransaction trans = null)
        //{
        //    using var r = new TransactionRunner(trans);
        //    return r.Run(action);
        //}

        /// <summary>
        /// This will allow you to dispose regardless of allow dispose value
        /// </summary>
        public void ForceDispose()
        {
            if (Transaction != null)
            {
                Transaction.Dispose();
                Transaction = null;
            }
        }

        /// <summary>
        /// If allow dispose is not allowed this will never run
        /// </summary>
        public void Dispose()
        {
            if (AllowDispose)
            {
                this.ForceDispose();
            }
        }
    }
}
