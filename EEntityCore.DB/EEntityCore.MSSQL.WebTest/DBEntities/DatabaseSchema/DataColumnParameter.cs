using System;
using ELibrary.Standard.VB.Modules;
using ELibrary.Standard.VB.Objects;
using ELibrary.Standard.VB.Types;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema
{

    /// <summary>
    /// The purpose of this class is to differentiate when you are passing in null parameter or nothing(that is ignoring the parameter)
    /// </summary>
    /// <remarks>On Comparison you can't ignore a param. it is treated as null</remarks>
    public class DataColumnParameter : DatabaseSchema.DataColumnDefinition
    {
        public DataColumnParameter(DatabaseSchema.DataColumnDefinition pColumn, object pValue) : base(pColumn.ColumnName, pColumn.DataType, pColumn.Nullable, pColumn.DefaultValue, pColumn.ConstraintType)
        {
            vValue = pValue;
        }

        public DataColumnParameter(string pColumn, object pValue) : this(new DatabaseSchema.DataColumnDefinition(pColumn, typeof(object), false, null), pValue)
        {
        }

        public const string NULL_SQLServerValue = "NULL";
        private object vValue;

        public object Value
        {
            get
            {
                return vValue;
            }
        }

        public bool IsNullButNotEqualsNothing
        {
            get
            {
                return new DatabaseSchema.DataColumnNullParamValue().Equals(Value) && Value is object;
            }
        }

        /// <summary>
        /// Returns nothing too as null
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool IsNull
        {
            get
            {
                return new DatabaseSchema.DataColumnNullParamValue().Equals(Value);
            }
        }

        public static DataColumnParameter get_NULL_Value(DatabaseSchema.DataColumnDefinition pColumn)
        {
            return new DataColumnParameter(pColumn, new DatabaseSchema.DataColumnNullParamValue());
        }






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

        private object getSQLQuotedValue()
        {
            if (this.ConstraintType == DatabaseSchema.DataColumnDefinition.ConstraintTypes.FOREIGN & this.Nullable)
            {
                // REM This must be int
                try
                {
                    if (EInt.valueOf(Value) == 0)
                        return NULL_SQLServerValue;
                }
                catch (Exception ex)
                {
                    throw new Exception("Trying to translate 0 to NULL for NULLABLE FOREIGN KEYS", ex);
                }
            }

            switch (DatabaseSchema.DataColumnDefinition.getTypeAllowed(this.DataType))
            {
                case DatabaseSchema.DataColumnDefinition.AllowedDataTypes.Bool:
                    {
                        return EBoolean.valueOf(Value).toInt32();
                    }

                case DatabaseSchema.DataColumnDefinition.AllowedDataTypes.Blob:
                    {
                        throw new Exception("You can not pass Blob values as inline SQL. ColumnName: " + this.ColumnName);
                    }

                case DatabaseSchema.DataColumnDefinition.AllowedDataTypes.DateTime:
                    {
                        return DatabaseSchema.DatabaseInit.DBConnectInterface.GetDBConn().GetSQLDateTimeFormat(new NullableDateTime(Value), true);
                    }

                case DatabaseSchema.DataColumnDefinition.AllowedDataTypes.Decimal:
                    {
                        // REM Format to English Culture, Since Database Saves in English
                        // REM Use Culture to reformat it
                        return EDouble.valueOf(Value).ToString(new System.Globalization.CultureInfo(1033));   // USA
                    }

                case DatabaseSchema.DataColumnDefinition.AllowedDataTypes.Int:
                    {
                        return EInt.valueOf(Value);
                    }

                case DatabaseSchema.DataColumnDefinition.AllowedDataTypes.Long:
                    {
                        return ELong.valueOf(Value);
                    }

                case DatabaseSchema.DataColumnDefinition.AllowedDataTypes.String:
                    {
                        return string.Format(@"N\'{0}\'", EStrings.valueOf(Value));
                    }

                case DatabaseSchema.DataColumnDefinition.AllowedDataTypes.TimeSpan:
                    {
                        throw new Exception("TimeSpan is not currently supported");
                    }

                default:
                    {
                        // REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()
                        throw new Exception(this.DataType.FullName + " is NOT currently supported!");
                    }
            }
        }

        /// <summary>
        /// For add, nothing is treated as null and nullval, else real value is returned
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public object getSQLQuotedValueForAdd()
        {
            if ((Value is null || IsNull) && !this.Nullable)
                throw new Exception(this.ColumnName + " can not be NULL");
            if (Value is null || IsNull)
                return NULL_SQLServerValue;
            return getSQLQuotedValue();
        }

        /// <summary>
        /// For update, nothing is treated as leave same value, nullval means null, else real value is returned
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public object getSQLQuotedValueForUpdate()
        {
            if (IsNullButNotEqualsNothing && !this.Nullable)
                throw new Exception(this.ColumnName + " can not be NULL");
            if (Value is null)
                return this.ColumnName;
            if (IsNull)
                return NULL_SQLServerValue;
            return getSQLQuotedValue();
        }


        /// <summary>
        /// Just limit your result to NULL or Real Value
        /// </summary>
        /// <param name="pValue"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static object TranslateNothingToNull(object pValue)
        {
            if (pValue is null)
                return new DatabaseSchema.DataColumnNullParamValue();
            return pValue;
        }

        // 'Public Shared Function getDefinition(pholder As IDataColumnDefinitionsHolder, pColumnName As String) As DataColumnDefinition
        // '    If pholder.getDefinitions().ContainsKey(pColumnName) Then Return pholder.getDefinitions()(pColumnName)
        // '    Throw New Exception(pColumnName & " is not added among the data column definitions.")
        // 'End Function


    }
}