using System;
using CODERiT.Logger.Standard.VB.Exceptions;

namespace EEntityCore.DB.Exceptions
{
    public class SQLCodeException : EException
    {

        #region Constructors


        public SQLCodeException(Exception ex) : this(ex.Message, ex)
        {
        }

        public SQLCodeException(string SQLCode, Exception ex)
        {
            Load(SQLCode, new string[] { "Check SQL Query Syntax." }, new string[] { ex.Message, ex.StackTrace });
        }

        #endregion




    }
}