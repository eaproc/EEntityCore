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

        public object Value { private set; get; }

        //public bool IsNullButNotEqualsNothing
        //{
        //    get
        //    {
        //        return new DataColumnNullParamValue().Equals(Value) && Value is object;
        //    }
        //}

        ///// <summary>
        ///// Returns nothing too as null
        ///// </summary>
        ///// <value></value>
        ///// <returns></returns>
        ///// <remarks></remarks>
        //public bool IsNull
        //{
        //    get
        //    {
        //        return new DataColumnNullParamValue().Equals(Value);
        //    }
        //}

        //public static DataColumnParameter get_NULL_Value(DataColumnDefinition pColumn)
        //{
        //    return new DataColumnParameter(pColumn, new DataColumnNullParamValue());
        //}




        // ''' <summary>
        // ''' Only for BLob Type with no NULL result. Throws exception
        // ''' </summary>
        // ''' <returns></returns>
        // ''' <remarks></remarks>
        // Public Function getByteArrayValue() As Byte()
        // If Me.Value Is Nothing OrElse
        // Not DataColumnDefinition.getTypeAllowed(Me.DataType) = AllowedDataTypes.Blob Then Throw New Exception("Wrong Use of this method.")

        // If Me.IsNull Then Return Nothing REM incase for update
        // If TypeOf Me.Value Is System.Drawing.Image Then Return EImage.toByteArray(CType(Me.Value, System.Drawing.Image))
        // Return CType(Me.Value, Byte())

        // End Function

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
                        return (int)Value;
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
        /// For add, nothing is treated as null and nullval, else real value is returned
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public object GetSQLQuotedValueForAdd()
        {
            if ((Value is null ) && !this.ColumnDefinition.Nullable)
                throw new Exception(this.ColumnDefinition.ColumnName + " can not be NULL");

            if (Value is null ) return SQL_NULL_VALUE;

            return GetSQLQuotedValue();
        }

        ///// <summary>
        ///// For update, nothing is treated as leave same value, nullval means null, else real value is returned
        ///// </summary>
        ///// <returns></returns>
        ///// <remarks></remarks>
        //public object GetSQLQuotedValueForUpdate()
        //{
        //    if (IsNullButNotEqualsNothing && !this.ColumnDefinition.Nullable)
        //        throw new Exception(this.ColumnDefinition.ColumnName + " can not be NULL");
        //    if (Value is null)
        //        return this.ColumnDefinition.ColumnName;
        //    if (IsNull)
        //        return SQL_NULL_VALUE;
        //    return GetSQLQuotedValue();
        //}

        ///// <summary>
        ///// Just limit your result to NULL or Real Value
        ///// </summary>
        ///// <param name="pValue"></param>
        ///// <returns></returns>
        ///// <remarks></remarks>
        //public static object TranslateNothingToNull(object pValue)
        //{
        //    if (pValue is null)
        //        return new DataColumnNullParamValue();
        //    return pValue;
        //}

        // 'Public Shared Function getDefinition(pholder As IDataColumnDefinitionsHolder, pColumnName As String) As DataColumnDefinition
        // '    If pholder.getDefinitions().ContainsKey(pColumnName) Then Return pholder.getDefinitions()(pColumnName)
        // '    Throw New Exception(pColumnName & " is not added among the data column definitions.")
        // 'End Function


    }
}