using System;
using System.Collections.Generic;
using System.Linq;

namespace EEntityCore.DB.MSSQL.Exceptions
{
    /// <summary>
    /// Indicates the foreign key record doesn't exist
    /// </summary>
    public class UpdateForeignKeyException : Exception, ISerializableException
    {
        public string ViolatedConstraint { get; private set; }
        public string ViolatedTable { get; private set; }

        public UpdateForeignKeyException(
            String pViolatedConstraint,
            String pViolatedTable,
            Exception exception = null) :base(message: "There is a wrong reference record!",
            innerException: exception)
        {
            this.ViolatedConstraint = pViolatedConstraint;
            this.ViolatedTable = pViolatedTable;
        }

        public static void DetectAndThrow(Exception exception)
        {
            UpdateForeignKeyException d = Detect(exception);
            if (d != null) throw d;
        }

        public static void DetectAndThrow(Exception exception, string SQL)
        {
            UpdateForeignKeyException d = Detect(exception);
            if (d != null)
            {
                d.Data.Add("SQL", SQL);
                d.Data.Add("ViolatedTable", d.ViolatedTable);
                d.Data.Add("ViolatedConstraint", d.ViolatedConstraint);
                throw new QueryException<UpdateForeignKeyException>(d);
            }
        }

        public static UpdateForeignKeyException Detect(Exception exception)
        {
            string s = exception.Message;
            if (s.IndexOf("conflicted with the FOREIGN KEY") <0) return null;

            string sVoilatedConstraint = DuplicateRowException.ExtractString(s, key1: "constraint \"", key2: "\""
                );

            string sViolatedTable = DuplicateRowException.ExtractString(s, key1: "table \"", key2: "\""
                );


            return new UpdateForeignKeyException(pViolatedConstraint: sVoilatedConstraint,
                pViolatedTable: sViolatedTable, exception: exception
                );

        }

        public dynamic ToDynamicClass() => Data;
    }
}