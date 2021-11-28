using System;
using CODERiT.Logger.Standard.VB.Exceptions;

namespace EEntityCore.DB.MSSQL.Exceptions
{


    // REM Encrypt connection string

    public class SQLServerConnectionException : EException
    {

        #region Constructors

        public SQLServerConnectionException(string pValConnectionString) : this("INVALID CONNECTION", pValConnectionString)
        {
        }

        public SQLServerConnectionException(Exception ex, string pValConnectionString) : this(ex.Message, pValConnectionString, ex)
        {
        }

        public SQLServerConnectionException(string Title, string pValConnectionString, Exception ex)
        {
            Load(Title, new string[] { "Check to see that the connection parameters are correct", "Check to see if this pc can ping the server ip.", "CONNECTION STRING: " + pValConnectionString }, new string[] { ex.Message, ex.StackTrace });
        }

        public SQLServerConnectionException(string Title, string pValConnectionString) : this(Title, pValConnectionString, new Exception(Title))
        {
        }




        #endregion



    }
}