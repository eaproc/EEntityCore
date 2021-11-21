using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.accounting                  
{                  

    public class V___ActiveTermInvoiceGuide : Sample__Table, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static V___ActiveTermInvoiceGuide()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defCompanyName = new DataColumnDefinition(TableColumnNames.CompanyName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermStartDate = new DataColumnDefinition(TableColumnNames.TermStartDate.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCurrentWeek = new DataColumnDefinition(TableColumnNames.CurrentWeek.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstBillDeadline = new DataColumnDefinition(TableColumnNames.FirstBillDeadline.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSecondBillDeadline = new DataColumnDefinition(TableColumnNames.SecondBillDeadline.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermEndDate = new DataColumnDefinition(TableColumnNames.TermEndDate.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerStudent = new DataColumnDefinition(TableColumnNames.RatePerStudent.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBilledRatePerStudent = new DataColumnDefinition(TableColumnNames.BilledRatePerStudent.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillableStudentCount = new DataColumnDefinition(TableColumnNames.BillableStudentCount.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpectedMinimumBillable = new DataColumnDefinition(TableColumnNames.ExpectedMinimumBillable.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpectedTotalBillable = new DataColumnDefinition(TableColumnNames.ExpectedTotalBillable.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBilledAmount = new DataColumnDefinition(TableColumnNames.BilledAmount.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(TableColumnNames.Balance.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRegisteredStudentCount = new DataColumnDefinition(TableColumnNames.RegisteredStudentCount.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullScholarshipStudentCount = new DataColumnDefinition(TableColumnNames.FullScholarshipStudentCount.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defCompanyName.ColumnName, defCompanyName); 
          ColumnDefns.Add(defTermStartDate.ColumnName, defTermStartDate); 
          ColumnDefns.Add(defCurrentWeek.ColumnName, defCurrentWeek); 
          ColumnDefns.Add(defFirstBillDeadline.ColumnName, defFirstBillDeadline); 
          ColumnDefns.Add(defSecondBillDeadline.ColumnName, defSecondBillDeadline); 
          ColumnDefns.Add(defTermEndDate.ColumnName, defTermEndDate); 
          ColumnDefns.Add(defRatePerStudent.ColumnName, defRatePerStudent); 
          ColumnDefns.Add(defBilledRatePerStudent.ColumnName, defBilledRatePerStudent); 
          ColumnDefns.Add(defBillableStudentCount.ColumnName, defBillableStudentCount); 
          ColumnDefns.Add(defExpectedMinimumBillable.ColumnName, defExpectedMinimumBillable); 
          ColumnDefns.Add(defExpectedTotalBillable.ColumnName, defExpectedTotalBillable); 
          ColumnDefns.Add(defBilledAmount.ColumnName, defBilledAmount); 
          ColumnDefns.Add(defBalance.ColumnName, defBalance); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defRegisteredStudentCount.ColumnName, defRegisteredStudentCount); 
          ColumnDefns.Add(defFullScholarshipStudentCount.ColumnName, defFullScholarshipStudentCount); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("academic.Term");                  
            ReferencedTableNames.Add("accounting.Invoice");                  
            ReferencedTableNames.Add("accounting.TermBill");                  
            ReferencedTableNames.Add("hr.Client");                  
            ReferencedTableNames.Add("hr.ClientStats");                  

          }


                  
        public V___ActiveTermInvoiceGuide() : base(TABLE_NAME)                  
        {                  
        }                  


                  
                  
        #region Full Access                  
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                    
                  
        /// <summary>                                    
        /// FULL ACCESS. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="TableName"></param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide(All__DBs DBConn, string TableName) : base(DBConn, TableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide(All__DBs DBConn, string pTableName, long pTargettedRowID) : base(DBConn, pTableName, pTargettedRowID: pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide(All__DBs pDBConn, string pTableName, string pSQL) : base(pDBConn, pTableName, pSQL)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide(All__DBs pDBConn, string pTableName, string pSQL, long pTargettedRowID) : base(pDBConn, pTableName, pSQL, pTargettedRowID)                  
        {                  
        }                  
                  
        #endregion                  
                  
                  
        #region Partial Access                  
                  
        // Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work                                    
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide(DataRowCollection pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="FullTable"></param>                                    
        /// <param name="TargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide(DataTable FullTable, int TargettedRowID, string TableName, All__DBs DBConn) : base(FullTable, TargettedRowID, TableName, DBConn)                  
        {                  
        }                  
                  
                  
        #endregion                  
                  
                  
        #region Shallow Access                  
        // In the real definition, shallow reference partial. Just that it means partial with no DBConn                                    
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="TargettedRow"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermInvoiceGuide(DataRow TargettedRow) : base(TargettedRow)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermInvoiceGuide(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermInvoiceGuide(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermInvoiceGuide(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName) : base(pTableRows, pTargettedRowID, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide(DataTable FullTable, string pTableName) : base(FullTable, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide(DataTable FullTable, string pTableName, long pTargettedRowID) : base(FullTable, pTableName, pTargettedRowID)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide(DataRowCollection pDataRows, string pTableName) : base(pDataRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermInvoiceGuide(IEnumerable<DataRow> pTableRows, string pTableName) : base(pTableRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access. Should always target this passed in                                    
        /// </summary>                                    
        /// <param name="pTargettedRow"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermInvoiceGuide(DataRow pTargettedRow, string pTableName) : base(pTargettedRow, pTableName)                  
        {                  
        }                  
                  
                  
        #endregion                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
#endregion                  
                  
                  
                  
#region Consts and Enums                  

       public const string TABLE_NAME = "accounting.ActiveTermInvoiceGuide";
       public const string ActiveTermInvoiceGuide__NO__BINARY___SQL_FILL_QUERY = "SELECT [CompanyName], [TermStartDate], [CurrentWeek], [FirstBillDeadline], [SecondBillDeadline], [TermEndDate], [RatePerStudent], [BilledRatePerStudent], [BillableStudentCount], [ExpectedMinimumBillable], [ExpectedTotalBillable], [BilledAmount], [Balance], [ClientID], [RegisteredStudentCount], [FullScholarshipStudentCount] FROM ActiveTermInvoiceGuide";
       public const string ActiveTermInvoiceGuide__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [CompanyName], [TermStartDate], [CurrentWeek], [FirstBillDeadline], [SecondBillDeadline], [TermEndDate], [RatePerStudent], [BilledRatePerStudent], [BillableStudentCount], [ExpectedMinimumBillable], [ExpectedTotalBillable], [BilledAmount], [Balance], [ClientID], [RegisteredStudentCount], [FullScholarshipStudentCount] FROM ActiveTermInvoiceGuide";


       public enum TableColumnNames
       {

           CompanyName,
           TermStartDate,
           CurrentWeek,
           FirstBillDeadline,
           SecondBillDeadline,
           TermEndDate,
           RatePerStudent,
           BilledRatePerStudent,
           BillableStudentCount,
           ExpectedMinimumBillable,
           ExpectedTotalBillable,
           BilledAmount,
           Balance,
           ClientID,
           RegisteredStudentCount,
           FullScholarshipStudentCount
       } 


 #endregion 


 #region Properties 

        private static List<string> ReferencedTableNames;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defCompanyName;
       public static readonly DataColumnDefinition defTermStartDate;
       public static readonly DataColumnDefinition defCurrentWeek;
       public static readonly DataColumnDefinition defFirstBillDeadline;
       public static readonly DataColumnDefinition defSecondBillDeadline;
       public static readonly DataColumnDefinition defTermEndDate;
       public static readonly DataColumnDefinition defRatePerStudent;
       public static readonly DataColumnDefinition defBilledRatePerStudent;
       public static readonly DataColumnDefinition defBillableStudentCount;
       public static readonly DataColumnDefinition defExpectedMinimumBillable;
       public static readonly DataColumnDefinition defExpectedTotalBillable;
       public static readonly DataColumnDefinition defBilledAmount;
       public static readonly DataColumnDefinition defBalance;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defRegisteredStudentCount;
       public static readonly DataColumnDefinition defFullScholarshipStudentCount;

       public String CompanyName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.CompanyName.ToString()]);
           }
       }


       public NullableDateTime TermStartDate {
           get{ 
               if (!this.isValidRow) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.TermStartDate.ToString()]);
           }
       }


       public Int32 CurrentWeek {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CurrentWeek.ToString()]);
           }
       }


       public NullableDateTime FirstBillDeadline {
           get{ 
               if (!this.isValidRow) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.FirstBillDeadline.ToString()]);
           }
       }


       public NullableDateTime SecondBillDeadline {
           get{ 
               if (!this.isValidRow) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.SecondBillDeadline.ToString()]);
           }
       }


       public NullableDateTime TermEndDate {
           get{ 
               if (!this.isValidRow) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.TermEndDate.ToString()]);
           }
       }


       public Decimal RatePerStudent {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.RatePerStudent.ToString()]);
           }
       }


       public Decimal BilledRatePerStudent {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.BilledRatePerStudent.ToString()]);
           }
       }


       public Int32 BillableStudentCount {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BillableStudentCount.ToString()]);
           }
       }


       public Decimal ExpectedMinimumBillable {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.ExpectedMinimumBillable.ToString()]);
           }
       }


       public Decimal ExpectedTotalBillable {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.ExpectedTotalBillable.ToString()]);
           }
       }


       public Decimal BilledAmount {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.BilledAmount.ToString()]);
           }
       }


       public Decimal Balance {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Balance.ToString()]);
           }
       }


       public Int32 ClientID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ClientID.ToString()]);
           }
       }


       public Int32 RegisteredStudentCount {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.RegisteredStudentCount.ToString()]);
           }
       }


       public Int32 FullScholarshipStudentCount {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.FullScholarshipStudentCount.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide getFirstRow()                  
        {                  
            if (this.hasRows())                  
                return new V___ActiveTermInvoiceGuide(this.AllRows.ToArray()[0]);                  
            return null;                  
        }                  
                  
        public static V___ActiveTermInvoiceGuide getFullTable()                  
        {                  
            return new V___ActiveTermInvoiceGuide(DatabaseInit.DBConnectInterface.GetDBConn(), TABLE_NAME);                  
        }                  
                  
        public static V___ActiveTermInvoiceGuide getRowWhereIDUsingSQL(int pID)                  
        {                  
            return new V___ActiveTermInvoiceGuide(DBConnectInterface.GetDBConn(), TABLE_NAME, string.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, (object)pID)).getFirstRow();                  
        }                  
                  
        public V___ActiveTermInvoiceGuide getRowWhereID(int pID)                  
        {                  
            return new V___ActiveTermInvoiceGuide(this.RawTable, TABLE_NAME, pID);                  
        }                  
                  
        private bool IsAllRowEqual(V___ActiveTermInvoiceGuide pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.hasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (!pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return false;                  
                }                  
                  
                return true;                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  
                  
        private bool IsAnyRowEqual(V___ActiveTermInvoiceGuide pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.hasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return true;                  
                }                  
                  
                return false;                  
            }                  
            catch (Exception )                  
            {                  
                return false;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide getAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new V___ActiveTermInvoiceGuide(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___ActiveTermInvoiceGuide(drst.CopyToDataTable(), TABLE_NAME);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM                errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public V___ActiveTermInvoiceGuide getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new V___ActiveTermInvoiceGuide(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___ActiveTermInvoiceGuide(drst.CopyToDataTable(), TABLE_NAME);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        public Dictionary<string, DataColumnDefinition> getDefinitions()                  
        {                  
            return ColumnDefns;                  
        }                  
                  
        private bool RowEqual(string pColumnName, object pColumnValue)                  
        {                  
            try                  
            {                  
                if (!this.isTargettedRowValid())                  
                    return false;                  
                switch (DataColumnDefinition.getTypeAllowed(ColumnDefns[pColumnName].DataType))                  
                {                  
                    case var @case when @case == DataColumnDefinition.AllowedDataTypes.Bool:                  
                        {                  
                            return EBoolean.valueOf(this.TargettedRow[pColumnName]) == EBoolean.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case1 when case1 == DataColumnDefinition.AllowedDataTypes.Blob:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    case var case2 when case2 == DataColumnDefinition.AllowedDataTypes.DateTime:                  
                        {                  
                            return EDateTime.EqualsDateWithoutTime(new NullableDateTime(this.TargettedRow[pColumnName]).DateTimeValue, new NullableDateTime(pColumnValue).DateTimeValue);                  
                        }                  
                  
                    case var case3 when case3 == DataColumnDefinition.AllowedDataTypes.Decimal:                  
                        {                  
                            return EDouble.valueOf(this.TargettedRow[pColumnName]) == EDouble.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case4 when case4 == DataColumnDefinition.AllowedDataTypes.Int:                  
                        {                  
                            return EInt.valueOf(this.TargettedRow[pColumnName]) == EInt.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case5 when case5 == DataColumnDefinition.AllowedDataTypes.Long:                  
                        {                  
                            return ELong.valueOf(this.TargettedRow[pColumnName]) == ELong.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case6 when case6 == DataColumnDefinition.AllowedDataTypes.String:                  
                        {                  
                            return EStrings.equalsIgnoreCase(EStrings.valueOf(this.TargettedRow[pColumnName]), EStrings.valueOf(pColumnValue));                  
                        }                  
                  
                    case var case7 when case7 == DataColumnDefinition.AllowedDataTypes.TimeSpan:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    default:                  
                        {                  
                            // REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()                                                       
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                }                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  

                  
    public List<string> getReferencedTableNames()                  
    {                  
        return ReferencedTableNames;                  
    }                  
                  
    public string getViewName()                  
    {                  
        return TABLE_NAME;                  
    }                  

                  
                  
#endregion                  
                  
                  



   }


}
