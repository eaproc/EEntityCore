using System;
using ELibrary.Standard.VB.Modules;
using ELibrary.Standard.VB.Objects;
using ELibrary.Standard.VB.Types;

namespace EEntityCore.DB.MSSQL.Schemas
{

    /// <summary>
    /// The purpose of this class is to differentiate when you are passing in null parameter or nothing(that is ignoring the parameter)
    /// </summary>
    /// <remarks>On Comparison you can't ignore a param. it is treated as null</remarks>
    public class DataColumnParameter 
    {

        public DataColumnParameter(DataColumnDefinition pColumn, object pValue)
        {
            Value = pValue;
            this.ColumnDefinition = pColumn;
        }

        public const string SQL_NULL_VALUE = "NULL";


        // date will be read in this order only
        // yyyy-MM-dd
        public const string DATE_FORMAT = "yyyy-MM-dd";
        /// <summary>
        /// Time will be read in this order. Hours:Mins 24Hr
        /// </summary>
        public const string TIME_FORMAT = "HH:mm:ss";

        public const string DATETIME_FORMAT = DATE_FORMAT + " " + TIME_FORMAT;

        public DataColumnDefinition ColumnDefinition { private set; get; }

        /// <summary>
        /// </summary>
        private readonly object Value;

        /// <summary>
        /// Calling this means value is not NULL
        /// </summary>
        /// <returns></returns>
        private object GetSQLQuotedValue()
        {
            switch (this.ColumnDefinition.AllowedType)
            {
                case DataColumnDefinition.AllowedDataTypes.Bool:
                    {
                        return ((bool)Value) ? 1 : 0;
                    }

                case DataColumnDefinition.AllowedDataTypes.Blob:
                    {
                        throw new Exception("You can not pass Blob values as inline SQL. ColumnName: " + this.ColumnDefinition.ColumnName);
                    }

                case DataColumnDefinition.AllowedDataTypes.DateTime:
                    {
                        return string.Format(@"'{0}'", ((DateTime)Value).ToString(DATETIME_FORMAT));
                    }

                case DataColumnDefinition.AllowedDataTypes.Decimal:
                    {
                        // REM Format to English Culture, Since Database Saves in English
                        // REM Use Culture to reformat it
                        return EDouble.ValueOf(Value).ToString(new System.Globalization.CultureInfo(1033));   // USA
                    }

                case DataColumnDefinition.AllowedDataTypes.Int:
                    {
                        return Convert.ChangeType( Value, typeof(int));
                    }

                case DataColumnDefinition.AllowedDataTypes.Long:
                    {
                        return (long)Value;
                    }

                case DataColumnDefinition.AllowedDataTypes.String:
                    {
                        return string.Format(@"N'{0}'", Abstracts.All__DBs.PrepareStringForDatabaseInsertOrUpdate((string)Value));
                    }

                case DataColumnDefinition.AllowedDataTypes.TimeSpan:
                    {
                        throw new Exception("TimeSpan is not currently supported");
                    }

                default:
                    {
                        // REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()
                        throw new Exception(this.ColumnDefinition.DataType.FullName + " is NOT currently supported!");
                    }
            }
        }

        /// <summary>
        /// This should always return string
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public string GetSQLValue()
        {
            if ((Value is null ) && !this.ColumnDefinition.Nullable)
                throw new Exception(this.ColumnDefinition.ColumnName + " can not be NULL");

            if (Value is null ) return SQL_NULL_VALUE;

            return GetSQLQuotedValue().ToString();
        }


        // '' <summary>
        // '' Just limit your result to NULL or Real Value
        // '' </summary>
        // '' <param name="pValue"></param>
        // '' <returns></returns>
        // '' <remarks></remarks>
        public static object TranslateNothingToNull(object pValue)
        {
            if (pValue == null)
            {
                return new DataColumnNullParamValue();
            }

            return pValue;
        }
    }
}