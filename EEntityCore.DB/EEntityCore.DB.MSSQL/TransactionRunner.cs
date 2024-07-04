using System;

namespace EEntityCore.DB.MSSQL
{
    // LEARN DEALING WITH TRANSACTION RUNNER
    // ------------------------------------
    //int ClassID, TermID;

    // AllowDispose to false, immediateDisposal can't work since AllowDispose is false.

    ////var runner = CreateTransactionRunner(false);
    //// TEapPRTermTopic topic = TEapPRTermTopic.GetRowWhereIDUsingSQL(ID, runner);
    ////    ClassID = topic.ClassID;
    ////    TermID = topic.TermID;
    ////    TEapPRTermTopic.DeleteItemRow(runner, pID: ID);

    ////runner.ForceDispose();

    // AllowDispose = true, immediateDisposal = false. This is perfect when using "using" command
    // as it will auto dispose once you are totally done

    //using (var runner = CreateTransactionRunner(true, immediateDisposal: false)) {
    //    TEapPRTermTopic topic = TEapPRTermTopic.GetRowWhereIDUsingSQL(ID, runner);
    //    ClassID = topic.ClassID;
    //    TermID = topic.TermID;
    //    TEapPRTermTopic.DeleteItemRow(runner, pID: ID);
    //}


    // Also, you can use this 2 approaches when using the keyword "using"

    //using (var runner = CreateTransactionRunner(true, immediateDisposal: false))
    //{
    //    // This is only best if immediateDisposal is true and allowDispose is true
    //    runner.Run((trans) => trans.ExecuteTransactionQuery(string.Format("delete from academic.StudentCBTExam where EvaluationCBTExamID={0}", ID)));
    //    runner.Run((trans) => trans.ExecuteTransactionQuery(string.Format("delete from  academic.EvaluationCBTExam where ID={0}", ID)));

    //    OR THIS because in our case, Run doesn't do anything different since immediateDisposal is false.

    //    runner.Transaction.ExecuteTransactionQuery(string.Format("delete from academic.StudentCBTExam where EvaluationCBTExamID={0}", ID));
    //    runner.Transaction.ExecuteTransactionQuery(string.Format("delete from  academic.EvaluationCBTExam where ID={0}", ID));
    //

    public class TransactionRunner : IDisposable
    {
        private bool AllowDispose { get; }

        public bool ImmediateDisposal { get; }

        /// <summary>
        /// You can directly use this property if you are running in transaction lock.
        /// </summary>
        public DBTransaction Transaction { get; private set; }

        /// <summary>
        /// UPDATE, INSERT, and DELETE. Returns numbers of rows affected. -1 if unsuccessful or different statement
        /// Auto Rollback
        /// </summary>
        /// <param name="pSQL"></param>
        /// <returns>boolean</returns>
        public int ExecuteTransactionQuery(string pSQL)
        {
            return Transaction.ExecuteTransactionQuery(pSQL);
        }

        /// <summary>
        /// Commit DB Transaction Query
        /// </summary>
        public void CommitDBTransaction()
        {
            Transaction.CommitDBTransaction();
        }

        /// <summary>
        /// Note the usage of allow dispose here
        /// </summary>
        /// <param name="trans"></param>
        /// <param name="allowDispose">If true, Dispose method will work fine on Garbage Collection and on normal call else you will need to call ForceDispose()</param>
        /// <param name="immediateDisposal">If true and allowDispose is true, it will dispose immediately on the first call of Run</param>
        public TransactionRunner(DBTransaction trans, bool allowDispose = true, bool immediateDisposal = true)
        {
            Transaction = trans;
            AllowDispose = allowDispose;
            ImmediateDisposal = immediateDisposal;
        }

        /// <summary>
        /// NB: This will call dispose immediately if allowed on constructor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        public T Run<T>(Func<DBTransaction, T> action)
        {
            var r = action(this.Transaction);

            // Dispose immediately if no need to hold for long
            if (AllowDispose && this.ImmediateDisposal) this.Dispose();

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
