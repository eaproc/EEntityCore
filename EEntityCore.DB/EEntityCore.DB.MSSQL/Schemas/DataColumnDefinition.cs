using System;

namespace EEntityCore.DB.MSSQL.Schemas
{
    public class DataColumnDefinition
    {

        #region Constructors
        public DataColumnDefinition(
            //IDatabaseInit pointerDatabaseInit,
            string pColumnName, Type pDataType, 
            bool pNullable, 
            ConstraintTypes pConstraintType = ConstraintTypes.UNKNOWN
            )
        {
            //this.PointerDatabaseInit = pointerDatabaseInit;
            vNullable = pNullable;
            vDataType = pDataType;
            vColumnName = pColumnName;
            vConstraintType = pConstraintType;
        }

        #endregion


        #region Properties

        //// This part should adjust after it has been moved to MSSQL
        //private IDatabaseInit PointerDatabaseInit { get; }
        //public IDatabaseInit DatabaseInit { get { return PointerDatabaseInit.GetDatabaseInit(); } }

        private string vColumnName;
        private Type vDataType;


        private bool vNullable;
        private ConstraintTypes vConstraintType;

        public string ColumnName
        {
            get
            {
                return vColumnName;
            }
        }

        public Type DataType
        {
            get
            {
                return vDataType;
            }
        }

        public object DefaultValue
        {
            get
            {
                if (!Nullable)
                {
                    // REM WHoop up something
                    switch (AllowedType)
                    {
                        case AllowedDataTypes.Bool:
                            {
                                return false;
                            }

                        case AllowedDataTypes.Blob:
                            {
                                return new byte[] { };
                            }

                        case AllowedDataTypes.DateTime:
                            {
                                return DateTime.Now;
                            }

                        case AllowedDataTypes.Decimal:
                        case AllowedDataTypes.Int:
                        case AllowedDataTypes.Long:
                            {
                                return 0;
                            }

                        case AllowedDataTypes.String:
                            {
                                return string.Empty;              // REM Some database sees "" as NULL
                            }

                        case AllowedDataTypes.TimeSpan:
                            {
                                throw new NotImplementedException("Time Span is not implemented");
                            }

                        default:
                            {
                                // REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()
                                throw new NotImplementedException("UNKNOWN DATA TYPE");
                            }
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public bool Nullable
        {
            get
            {
                return vNullable;
            }
        }

        public ConstraintTypes ConstraintType
        {
            get
            {
                return vConstraintType;
            }
        }

        #endregion


        #region Enums and Consts


        public enum AllowedDataTypes
        {
            Bool,
            Int,
            Long,
            Decimal,
            String,
            Blob,
            DateTime,
            TimeSpan,
            UNKNOWN
        }

        public enum ConstraintTypes
        {
            FOREIGN,
            PRIMARY,
            UNIQUE,
            CHECK,
            UNKNOWN
        }

        #endregion

        public AllowedDataTypes AllowedType => GetTypeAllowed(this.DataType);


        public static AllowedDataTypes GetTypeAllowed(Type pType)
        {
            switch (pType)
            {
                case var @case when @case == typeof(bool):
                case var case22 when case22 == typeof(bool?):
                    {
                        return AllowedDataTypes.Bool;
                    }

                case var case1 when case1 == typeof(byte):
                case var case2 when case2 == typeof(sbyte):
                case var case3 when case3 == typeof(short):
                case var case4 when case4 == typeof(ushort):
                case var case5 when case5 == typeof(int):
                case var case6 when case6 == typeof(uint):
                case var case61 when case61 == typeof(int?):
                    {
                        return AllowedDataTypes.Int;
                    }

                case var case7 when case7 == typeof(long):
                case var case77 when case77 == typeof(long?):
                case var case8 when case8 == typeof(ulong):
                    {
                        return AllowedDataTypes.Long;
                    }

                case var case9 when case9 == typeof(decimal):
                case var case99 when case99 == typeof(decimal?):
                case var case10 when case10 == typeof(double):
                    {
                        return AllowedDataTypes.Decimal;
                    }

                case var case11 when case11 == typeof(string):
                case var case12 when case12 == typeof(char):
                    {
                        return AllowedDataTypes.String;
                    }

                case var case13 when case13 == typeof(byte[]):
                    {
                        return AllowedDataTypes.Blob;
                    }

                case var case17 when case17 == typeof(DateTime?):
                case var case14 when case14 == typeof(DateTime):
                    {
                        return AllowedDataTypes.DateTime;
                    }

                case var case15 when case15 == typeof(TimeSpan):
                    {
                        return AllowedDataTypes.TimeSpan;
                    }

                default:
                    {
                        return AllowedDataTypes.UNKNOWN;
                    }
            }
        }
    }
}