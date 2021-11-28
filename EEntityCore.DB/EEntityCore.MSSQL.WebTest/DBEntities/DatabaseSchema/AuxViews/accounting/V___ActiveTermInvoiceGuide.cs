using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using ELibrary.Standard.VB.Modules;                  
using EEntityCore.DB.Schemas.SQLServerSchema;                  
using EEntityCore.DB.MSSQL;                  
using EEntityCore.DB.Modules;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.accounting                  
{                  

    public class V___ActiveTermInvoiceGuide : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___ActiveTermInvoiceGuide()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defCompanyName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CompanyName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermStartDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermStartDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCurrentWeek = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CurrentWeek.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstBillDeadline = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FirstBillDeadline.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSecondBillDeadline = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SecondBillDeadline.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermEndDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermEndDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerStudent = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RatePerStudent.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBilledRatePerStudent = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BilledRatePerStudent.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillableStudentCount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BillableStudentCount.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpectedMinimumBillable = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExpectedMinimumBillable.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpectedTotalBillable = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExpectedTotalBillable.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBilledAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BilledAmount.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Balance.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRegisteredStudentCount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RegisteredStudentCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullScholarshipStudentCount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FullScholarshipStudentCount.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


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


                  
       public V___ActiveTermInvoiceGuide() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermInvoiceGuide(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermInvoiceGuide(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermInvoiceGuide(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermInvoiceGuide(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
   #region Partial Access                                    
                                    
        // Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work                                                      
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermInvoiceGuide(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermInvoiceGuide(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermInvoiceGuide(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___ActiveTermInvoiceGuide(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public string CompanyName { get => (string)TargettedRow[TableColumnNames.CompanyName.ToString()]; }


       public DateTime? TermStartDate { get => (DateTime?)TargettedRow[TableColumnNames.TermStartDate.ToString()]; }


       public int? CurrentWeek { get => (int?)TargettedRow[TableColumnNames.CurrentWeek.ToString()]; }


       public DateTime? FirstBillDeadline { get => (DateTime?)TargettedRow[TableColumnNames.FirstBillDeadline.ToString()]; }


       public DateTime? SecondBillDeadline { get => (DateTime?)TargettedRow[TableColumnNames.SecondBillDeadline.ToString()]; }


       public DateTime? TermEndDate { get => (DateTime?)TargettedRow[TableColumnNames.TermEndDate.ToString()]; }


       public decimal RatePerStudent { get => (decimal)TargettedRow[TableColumnNames.RatePerStudent.ToString()]; }


       public decimal BilledRatePerStudent { get => (decimal)TargettedRow[TableColumnNames.BilledRatePerStudent.ToString()]; }


       public int? BillableStudentCount { get => (int?)TargettedRow[TableColumnNames.BillableStudentCount.ToString()]; }


       public decimal? ExpectedMinimumBillable { get => (decimal?)TargettedRow[TableColumnNames.ExpectedMinimumBillable.ToString()]; }


       public decimal? ExpectedTotalBillable { get => (decimal?)TargettedRow[TableColumnNames.ExpectedTotalBillable.ToString()]; }


       public decimal? BilledAmount { get => (decimal?)TargettedRow[TableColumnNames.BilledAmount.ToString()]; }


       public decimal? Balance { get => (decimal?)TargettedRow[TableColumnNames.Balance.ToString()]; }


       public int ClientID { get => (int)TargettedRow[TableColumnNames.ClientID.ToString()]; }


       public int RegisteredStudentCount { get => (int)TargettedRow[TableColumnNames.RegisteredStudentCount.ToString()]; }


       public int? FullScholarshipStudentCount { get => (int?)TargettedRow[TableColumnNames.FullScholarshipStudentCount.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public V___ActiveTermInvoiceGuide GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static V___ActiveTermInvoiceGuide GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static V___ActiveTermInvoiceGuide GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new V___ActiveTermInvoiceGuide(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public V___ActiveTermInvoiceGuide GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => ActiveTermInvoiceGuide__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
