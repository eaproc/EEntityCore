using System;

namespace EEntityCore.DB.MSSQL.Exceptions
{
    /// <summary>
    /// Indicates one of the string / binary column being updated has value larger than the expected size in database
    /// </summary>
    public class DataTruncateException : Exception, ISerializableException
    {

        public DataTruncateException(string SQL, Exception exception = null) :base(message: "The record has values larger than the expected size in database!",innerException: exception)
        {
            Data.Add("SQL", SQL);
        }

        public static void DetectAndThrow(Exception exception, string SQL)
        {
            DataTruncateException d = Detect(exception, SQL);
            if (d != null) throw new QueryException<DataTruncateException>(d); ;
        }

        public static DataTruncateException Detect(Exception exception, string SQL)
        {
            string s = exception.Message;
            if (s.IndexOf("would be truncated") <0) return null;

            return new (SQL, exception: exception);
        }

        public dynamic ToDynamicClass() => Data;
    }
}