using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using ELibrary.Standard.VB.Modules;                  
using EEntityCore.DB.MSSQL.Schemas;                  
using EEntityCore.DB.MSSQL;                  
using EEntityCore.DB.Modules;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.hr                  
{                  

    public class T___ClientStats : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ClientStats()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defRegisteredStudentCount = new DataColumnDefinition(TableColumnNames.RegisteredStudentCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAssignedStudentCount = new DataColumnDefinition(TableColumnNames.AssignedStudentCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSCADWAREAccessCount = new DataColumnDefinition(TableColumnNames.SCADWAREAccessCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSCADWAREAccessThreshold = new DataColumnDefinition(TableColumnNames.SCADWAREAccessThreshold.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAverageTermBill = new DataColumnDefinition(TableColumnNames.AverageTermBill.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerStudent = new DataColumnDefinition(TableColumnNames.RatePerStudent.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBilledPerStudent = new DataColumnDefinition(TableColumnNames.BilledPerStudent.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotalReceivedOnSCADWAREBill = new DataColumnDefinition(TableColumnNames.TotalReceivedOnSCADWAREBill.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMinimumExpectedOnSCADWAREBill = new DataColumnDefinition(TableColumnNames.MinimumExpectedOnSCADWAREBill.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpectedOnSCADWAREBill = new DataColumnDefinition(TableColumnNames.ExpectedOnSCADWAREBill.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullScholarshipStudentCount = new DataColumnDefinition(TableColumnNames.FullScholarshipStudentCount.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermStartDate = new DataColumnDefinition(TableColumnNames.TermStartDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermEndDate = new DataColumnDefinition(TableColumnNames.TermEndDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defRegisteredStudentCount.ColumnName, defRegisteredStudentCount); 
          ColumnDefns.Add(defAssignedStudentCount.ColumnName, defAssignedStudentCount); 
          ColumnDefns.Add(defSCADWAREAccessCount.ColumnName, defSCADWAREAccessCount); 
          ColumnDefns.Add(defSCADWAREAccessThreshold.ColumnName, defSCADWAREAccessThreshold); 
          ColumnDefns.Add(defAverageTermBill.ColumnName, defAverageTermBill); 
          ColumnDefns.Add(defRatePerStudent.ColumnName, defRatePerStudent); 
          ColumnDefns.Add(defBilledPerStudent.ColumnName, defBilledPerStudent); 
          ColumnDefns.Add(defTotalReceivedOnSCADWAREBill.ColumnName, defTotalReceivedOnSCADWAREBill); 
          ColumnDefns.Add(defMinimumExpectedOnSCADWAREBill.ColumnName, defMinimumExpectedOnSCADWAREBill); 
          ColumnDefns.Add(defExpectedOnSCADWAREBill.ColumnName, defExpectedOnSCADWAREBill); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defFullScholarshipStudentCount.ColumnName, defFullScholarshipStudentCount); 
          ColumnDefns.Add(defTermStartDate.ColumnName, defTermStartDate); 
          ColumnDefns.Add(defTermEndDate.ColumnName, defTermEndDate); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_ClientStats_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "hr.ClientStats", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_ClientStats_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.ClientStats", "academic.Term"                  
                            ));                  

          }


                  
       public T___ClientStats() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ClientStats(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___ClientStats(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.ClientStats";
       public const string ClientStats__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [TermID], [RegisteredStudentCount], [AssignedStudentCount], [SCADWAREAccessCount], [SCADWAREAccessThreshold], [AverageTermBill], [RatePerStudent], [BilledPerStudent], [TotalReceivedOnSCADWAREBill], [MinimumExpectedOnSCADWAREBill], [ExpectedOnSCADWAREBill], [IPAddress], [CreatedAt], [FullScholarshipStudentCount], [TermStartDate], [TermEndDate] FROM hr.ClientStats";
       public const string ClientStats__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [TermID], [RegisteredStudentCount], [AssignedStudentCount], [SCADWAREAccessCount], [SCADWAREAccessThreshold], [AverageTermBill], [RatePerStudent], [BilledPerStudent], [TotalReceivedOnSCADWAREBill], [MinimumExpectedOnSCADWAREBill], [ExpectedOnSCADWAREBill], [IPAddress], [CreatedAt], [FullScholarshipStudentCount], [TermStartDate], [TermEndDate] FROM hr.ClientStats";


       public enum TableColumnNames
       {

           ID,
           ClientID,
           TermID,
           RegisteredStudentCount,
           AssignedStudentCount,
           SCADWAREAccessCount,
           SCADWAREAccessThreshold,
           AverageTermBill,
           RatePerStudent,
           BilledPerStudent,
           TotalReceivedOnSCADWAREBill,
           MinimumExpectedOnSCADWAREBill,
           ExpectedOnSCADWAREBill,
           IPAddress,
           CreatedAt,
           FullScholarshipStudentCount,
           TermStartDate,
           TermEndDate
       } 



       public enum TableConstraints{

           pk_hr_ClientStats, 
           fk_hr_ClientStats_ClientID, 
           fk_hr_ClientStats_TermID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defRegisteredStudentCount;
       public static readonly DataColumnDefinition defAssignedStudentCount;
       public static readonly DataColumnDefinition defSCADWAREAccessCount;
       public static readonly DataColumnDefinition defSCADWAREAccessThreshold;
       public static readonly DataColumnDefinition defAverageTermBill;
       public static readonly DataColumnDefinition defRatePerStudent;
       public static readonly DataColumnDefinition defBilledPerStudent;
       public static readonly DataColumnDefinition defTotalReceivedOnSCADWAREBill;
       public static readonly DataColumnDefinition defMinimumExpectedOnSCADWAREBill;
       public static readonly DataColumnDefinition defExpectedOnSCADWAREBill;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defFullScholarshipStudentCount;
       public static readonly DataColumnDefinition defTermStartDate;
       public static readonly DataColumnDefinition defTermEndDate;

       public int ClientID { get => (int)TargettedRow[TableColumnNames.ClientID.ToString()]; }


       public int TermID { get => (int)TargettedRow[TableColumnNames.TermID.ToString()]; }


       public int RegisteredStudentCount { get => (int)TargettedRow[TableColumnNames.RegisteredStudentCount.ToString()]; }


       public int AssignedStudentCount { get => (int)TargettedRow[TableColumnNames.AssignedStudentCount.ToString()]; }


       public int SCADWAREAccessCount { get => (int)TargettedRow[TableColumnNames.SCADWAREAccessCount.ToString()]; }


       public decimal SCADWAREAccessThreshold { get => (decimal)TargettedRow[TableColumnNames.SCADWAREAccessThreshold.ToString()]; }


       public decimal AverageTermBill { get => (decimal)TargettedRow[TableColumnNames.AverageTermBill.ToString()]; }


       public decimal RatePerStudent { get => (decimal)TargettedRow[TableColumnNames.RatePerStudent.ToString()]; }


       public decimal BilledPerStudent { get => (decimal)TargettedRow[TableColumnNames.BilledPerStudent.ToString()]; }


       public decimal TotalReceivedOnSCADWAREBill { get => (decimal)TargettedRow[TableColumnNames.TotalReceivedOnSCADWAREBill.ToString()]; }


       public decimal MinimumExpectedOnSCADWAREBill { get => (decimal)TargettedRow[TableColumnNames.MinimumExpectedOnSCADWAREBill.ToString()]; }


       public decimal ExpectedOnSCADWAREBill { get => (decimal)TargettedRow[TableColumnNames.ExpectedOnSCADWAREBill.ToString()]; }


       public string IPAddress { get => (string)TargettedRow[TableColumnNames.IPAddress.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public int? FullScholarshipStudentCount { get => (int?)TargettedRow[TableColumnNames.FullScholarshipStudentCount.ToString()]; }


       public DateTime? TermStartDate { get => (DateTime?)TargettedRow[TableColumnNames.TermStartDate.ToString()]; }


       public DateTime? TermEndDate { get => (DateTime?)TargettedRow[TableColumnNames.TermEndDate.ToString()]; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___ClientStats GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___ClientStats GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___ClientStats(conn.Fetch(ClientStats__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable(), DO__NOT____TARGET__ANY_ROWID),                  
                transaction                  
                );                                                      
                                                      
        public static T___ClientStats GetRowWhereIDUsingSQL(int pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___ClientStats( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___ClientStats GetRowWhereID(int pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => ClientStats__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int ClientID,
            int TermID,
            int RegisteredStudentCount,
            int AssignedStudentCount,
            int SCADWAREAccessCount,
            decimal SCADWAREAccessThreshold,
            decimal AverageTermBill,
            decimal RatePerStudent,
            decimal BilledPerStudent,
            decimal TotalReceivedOnSCADWAREBill,
            decimal MinimumExpectedOnSCADWAREBill,
            decimal ExpectedOnSCADWAREBill,
            string IPAddress,
            DateTime CreatedAt,
            int? FullScholarshipStudentCount = null,
            DateTime? TermStartDate = null,
            DateTime? TermEndDate = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramRegisteredStudentCount = new (defRegisteredStudentCount, RegisteredStudentCount);
                DataColumnParameter paramAssignedStudentCount = new (defAssignedStudentCount, AssignedStudentCount);
                DataColumnParameter paramSCADWAREAccessCount = new (defSCADWAREAccessCount, SCADWAREAccessCount);
                DataColumnParameter paramSCADWAREAccessThreshold = new (defSCADWAREAccessThreshold, SCADWAREAccessThreshold);
                DataColumnParameter paramAverageTermBill = new (defAverageTermBill, AverageTermBill);
                DataColumnParameter paramRatePerStudent = new (defRatePerStudent, RatePerStudent);
                DataColumnParameter paramBilledPerStudent = new (defBilledPerStudent, BilledPerStudent);
                DataColumnParameter paramTotalReceivedOnSCADWAREBill = new (defTotalReceivedOnSCADWAREBill, TotalReceivedOnSCADWAREBill);
                DataColumnParameter paramMinimumExpectedOnSCADWAREBill = new (defMinimumExpectedOnSCADWAREBill, MinimumExpectedOnSCADWAREBill);
                DataColumnParameter paramExpectedOnSCADWAREBill = new (defExpectedOnSCADWAREBill, ExpectedOnSCADWAREBill);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramFullScholarshipStudentCount = new (defFullScholarshipStudentCount, FullScholarshipStudentCount);
                DataColumnParameter paramTermStartDate = new (defTermStartDate, TermStartDate);
                DataColumnParameter paramTermEndDate = new (defTermEndDate, TermEndDate);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  ", TABLE_NAME,
                        paramClientID.GetSQLQuotedValueForAdd(),
                        paramTermID.GetSQLQuotedValueForAdd(),
                        paramRegisteredStudentCount.GetSQLQuotedValueForAdd(),
                        paramAssignedStudentCount.GetSQLQuotedValueForAdd(),
                        paramSCADWAREAccessCount.GetSQLQuotedValueForAdd(),
                        paramSCADWAREAccessThreshold.GetSQLQuotedValueForAdd(),
                        paramAverageTermBill.GetSQLQuotedValueForAdd(),
                        paramRatePerStudent.GetSQLQuotedValueForAdd(),
                        paramBilledPerStudent.GetSQLQuotedValueForAdd(),
                        paramTotalReceivedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
                        paramMinimumExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
                        paramExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
                        paramIPAddress.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramFullScholarshipStudentCount.GetSQLQuotedValueForAdd(),
                        paramTermStartDate.GetSQLQuotedValueForAdd(),
                        paramTermEndDate.GetSQLQuotedValueForAdd()                        )
                    );
                         
                return conn.GetScopeIdentity().ToLong();
            });

        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool AddWithID(
            int ID,
            int ClientID,
            int TermID,
            int RegisteredStudentCount,
            int AssignedStudentCount,
            int SCADWAREAccessCount,
            decimal SCADWAREAccessThreshold,
            decimal AverageTermBill,
            decimal RatePerStudent,
            decimal BilledPerStudent,
            decimal TotalReceivedOnSCADWAREBill,
            decimal MinimumExpectedOnSCADWAREBill,
            decimal ExpectedOnSCADWAREBill,
            string IPAddress,
            DateTime CreatedAt,
            int? FullScholarshipStudentCount = null,
            DateTime? TermStartDate = null,
            DateTime? TermEndDate = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramRegisteredStudentCount = new (defRegisteredStudentCount, RegisteredStudentCount);
                DataColumnParameter paramAssignedStudentCount = new (defAssignedStudentCount, AssignedStudentCount);
                DataColumnParameter paramSCADWAREAccessCount = new (defSCADWAREAccessCount, SCADWAREAccessCount);
                DataColumnParameter paramSCADWAREAccessThreshold = new (defSCADWAREAccessThreshold, SCADWAREAccessThreshold);
                DataColumnParameter paramAverageTermBill = new (defAverageTermBill, AverageTermBill);
                DataColumnParameter paramRatePerStudent = new (defRatePerStudent, RatePerStudent);
                DataColumnParameter paramBilledPerStudent = new (defBilledPerStudent, BilledPerStudent);
                DataColumnParameter paramTotalReceivedOnSCADWAREBill = new (defTotalReceivedOnSCADWAREBill, TotalReceivedOnSCADWAREBill);
                DataColumnParameter paramMinimumExpectedOnSCADWAREBill = new (defMinimumExpectedOnSCADWAREBill, MinimumExpectedOnSCADWAREBill);
                DataColumnParameter paramExpectedOnSCADWAREBill = new (defExpectedOnSCADWAREBill, ExpectedOnSCADWAREBill);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramFullScholarshipStudentCount = new (defFullScholarshipStudentCount, FullScholarshipStudentCount);
                DataColumnParameter paramTermStartDate = new (defTermStartDate, TermStartDate);
                DataColumnParameter paramTermEndDate = new (defTermEndDate, TermEndDate);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramClientID.GetSQLQuotedValueForAdd(),
                        paramTermID.GetSQLQuotedValueForAdd(),
                        paramRegisteredStudentCount.GetSQLQuotedValueForAdd(),
                        paramAssignedStudentCount.GetSQLQuotedValueForAdd(),
                        paramSCADWAREAccessCount.GetSQLQuotedValueForAdd(),
                        paramSCADWAREAccessThreshold.GetSQLQuotedValueForAdd(),
                        paramAverageTermBill.GetSQLQuotedValueForAdd(),
                        paramRatePerStudent.GetSQLQuotedValueForAdd(),
                        paramBilledPerStudent.GetSQLQuotedValueForAdd(),
                        paramTotalReceivedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
                        paramMinimumExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
                        paramExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
                        paramIPAddress.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramFullScholarshipStudentCount.GetSQLQuotedValueForAdd(),
                        paramTermStartDate.GetSQLQuotedValueForAdd(),
                        paramTermEndDate.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        /// <summary>                  
        /// Deletes with an option to pass in transaction                  
        /// </summary>                  
        /// <returns></returns>                  
        /// <remarks></remarks>                  
        public bool DeleteRow(DBTransaction transaction = null)                  
        {                  
            return DeleteItemRow(ID, transaction);                  
        }                  
                  
        public static bool DeleteItemRow(long pID, DBTransaction transaction = null)                                                      
        {                  
            return TransactionRunner.InvokeRun(                  
               (conn) => conn.ExecuteTransactionQuery($"DELETE FROM {TABLE_NAME} WHERE ID={pID} ").ToBoolean(),                  
               transaction                  
               );                  
        }                  



   }


}
