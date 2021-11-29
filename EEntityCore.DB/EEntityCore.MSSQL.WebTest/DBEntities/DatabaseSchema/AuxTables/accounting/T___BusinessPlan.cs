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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___BusinessPlan : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___BusinessPlan()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defAcademicSessionID = new DataColumnDefinition(TableColumnNames.AcademicSessionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defStudentPopulation = new DataColumnDefinition(TableColumnNames.StudentPopulation.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAveragePricePerStudent = new DataColumnDefinition(TableColumnNames.AveragePricePerStudent.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSCADWAREAccessRevenue = new DataColumnDefinition(TableColumnNames.SCADWAREAccessRevenue.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSideContractRevenue = new DataColumnDefinition(TableColumnNames.SideContractRevenue.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGrossRevenue = new DataColumnDefinition(TableColumnNames.GrossRevenue.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWages = new DataColumnDefinition(TableColumnNames.Wages.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMarketing = new DataColumnDefinition(TableColumnNames.Marketing.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharity = new DataColumnDefinition(TableColumnNames.Charity.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOthers = new DataColumnDefinition(TableColumnNames.Others.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID); 
          ColumnDefns.Add(defStudentPopulation.ColumnName, defStudentPopulation); 
          ColumnDefns.Add(defAveragePricePerStudent.ColumnName, defAveragePricePerStudent); 
          ColumnDefns.Add(defSCADWAREAccessRevenue.ColumnName, defSCADWAREAccessRevenue); 
          ColumnDefns.Add(defSideContractRevenue.ColumnName, defSideContractRevenue); 
          ColumnDefns.Add(defGrossRevenue.ColumnName, defGrossRevenue); 
          ColumnDefns.Add(defWages.ColumnName, defWages); 
          ColumnDefns.Add(defMarketing.ColumnName, defMarketing); 
          ColumnDefns.Add(defCharity.ColumnName, defCharity); 
          ColumnDefns.Add(defOthers.ColumnName, defOthers); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_BusinessPlan_AcademicSessionID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.BusinessPlan", "academic.AcademicSession"                  
                            ));                  

          }


                  
       public T___BusinessPlan() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___BusinessPlan(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___BusinessPlan(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.BusinessPlan";
       public const string BusinessPlan__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [AcademicSessionID], [StudentPopulation], [AveragePricePerStudent], [SCADWAREAccessRevenue], [SideContractRevenue], [GrossRevenue], [Wages], [Marketing], [Charity], [Others], [CreatedAt], [UpdatedAt] FROM accounting.BusinessPlan";
       public const string BusinessPlan__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [AcademicSessionID], [StudentPopulation], [AveragePricePerStudent], [SCADWAREAccessRevenue], [SideContractRevenue], [GrossRevenue], [Wages], [Marketing], [Charity], [Others], [CreatedAt], [UpdatedAt] FROM accounting.BusinessPlan";


       public enum TableColumnNames
       {

           ID,
           AcademicSessionID,
           StudentPopulation,
           AveragePricePerStudent,
           SCADWAREAccessRevenue,
           SideContractRevenue,
           GrossRevenue,
           Wages,
           Marketing,
           Charity,
           Others,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_accounting_BusinessPlan, 
           fk_accounting_BusinessPlan_AcademicSessionID, 
           uq_accounting_BusinessPlan_AcademicSessionID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defAcademicSessionID;
       public static readonly DataColumnDefinition defStudentPopulation;
       public static readonly DataColumnDefinition defAveragePricePerStudent;
       public static readonly DataColumnDefinition defSCADWAREAccessRevenue;
       public static readonly DataColumnDefinition defSideContractRevenue;
       public static readonly DataColumnDefinition defGrossRevenue;
       public static readonly DataColumnDefinition defWages;
       public static readonly DataColumnDefinition defMarketing;
       public static readonly DataColumnDefinition defCharity;
       public static readonly DataColumnDefinition defOthers;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public int AcademicSessionID { get => (int)TargettedRow[TableColumnNames.AcademicSessionID.ToString()]; }


       public int StudentPopulation { get => (int)TargettedRow[TableColumnNames.StudentPopulation.ToString()]; }


       public decimal AveragePricePerStudent { get => (decimal)TargettedRow[TableColumnNames.AveragePricePerStudent.ToString()]; }


       public decimal SCADWAREAccessRevenue { get => (decimal)TargettedRow[TableColumnNames.SCADWAREAccessRevenue.ToString()]; }


       public decimal SideContractRevenue { get => (decimal)TargettedRow[TableColumnNames.SideContractRevenue.ToString()]; }


       public decimal GrossRevenue { get => (decimal)TargettedRow[TableColumnNames.GrossRevenue.ToString()]; }


       public decimal Wages { get => (decimal)TargettedRow[TableColumnNames.Wages.ToString()]; }


       public decimal Marketing { get => (decimal)TargettedRow[TableColumnNames.Marketing.ToString()]; }


       public decimal Charity { get => (decimal)TargettedRow[TableColumnNames.Charity.ToString()]; }


       public decimal Others { get => (decimal)TargettedRow[TableColumnNames.Others.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___BusinessPlan GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___BusinessPlan GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___BusinessPlan(conn.Fetch(BusinessPlan__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable(), DO__NOT____TARGET__ANY_ROWID),                  
                transaction                  
                );                                                      
                                                      
        public static T___BusinessPlan GetRowWhereIDUsingSQL(int pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___BusinessPlan( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___BusinessPlan GetRowWhereID(int pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => BusinessPlan__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int AcademicSessionID,
            int StudentPopulation,
            decimal AveragePricePerStudent,
            decimal SCADWAREAccessRevenue,
            decimal SideContractRevenue,
            decimal GrossRevenue,
            decimal Wages,
            decimal Marketing,
            decimal Charity,
            decimal Others,
            DateTime CreatedAt,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramAcademicSessionID = new (defAcademicSessionID, AcademicSessionID);
                DataColumnParameter paramStudentPopulation = new (defStudentPopulation, StudentPopulation);
                DataColumnParameter paramAveragePricePerStudent = new (defAveragePricePerStudent, AveragePricePerStudent);
                DataColumnParameter paramSCADWAREAccessRevenue = new (defSCADWAREAccessRevenue, SCADWAREAccessRevenue);
                DataColumnParameter paramSideContractRevenue = new (defSideContractRevenue, SideContractRevenue);
                DataColumnParameter paramGrossRevenue = new (defGrossRevenue, GrossRevenue);
                DataColumnParameter paramWages = new (defWages, Wages);
                DataColumnParameter paramMarketing = new (defMarketing, Marketing);
                DataColumnParameter paramCharity = new (defCharity, Charity);
                DataColumnParameter paramOthers = new (defOthers, Others);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramAcademicSessionID.GetSQLQuotedValueForAdd(),
                        paramStudentPopulation.GetSQLQuotedValueForAdd(),
                        paramAveragePricePerStudent.GetSQLQuotedValueForAdd(),
                        paramSCADWAREAccessRevenue.GetSQLQuotedValueForAdd(),
                        paramSideContractRevenue.GetSQLQuotedValueForAdd(),
                        paramGrossRevenue.GetSQLQuotedValueForAdd(),
                        paramWages.GetSQLQuotedValueForAdd(),
                        paramMarketing.GetSQLQuotedValueForAdd(),
                        paramCharity.GetSQLQuotedValueForAdd(),
                        paramOthers.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd()                        )
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
            int AcademicSessionID,
            int StudentPopulation,
            decimal AveragePricePerStudent,
            decimal SCADWAREAccessRevenue,
            decimal SideContractRevenue,
            decimal GrossRevenue,
            decimal Wages,
            decimal Marketing,
            decimal Charity,
            decimal Others,
            DateTime CreatedAt,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramAcademicSessionID = new (defAcademicSessionID, AcademicSessionID);
                DataColumnParameter paramStudentPopulation = new (defStudentPopulation, StudentPopulation);
                DataColumnParameter paramAveragePricePerStudent = new (defAveragePricePerStudent, AveragePricePerStudent);
                DataColumnParameter paramSCADWAREAccessRevenue = new (defSCADWAREAccessRevenue, SCADWAREAccessRevenue);
                DataColumnParameter paramSideContractRevenue = new (defSideContractRevenue, SideContractRevenue);
                DataColumnParameter paramGrossRevenue = new (defGrossRevenue, GrossRevenue);
                DataColumnParameter paramWages = new (defWages, Wages);
                DataColumnParameter paramMarketing = new (defMarketing, Marketing);
                DataColumnParameter paramCharity = new (defCharity, Charity);
                DataColumnParameter paramOthers = new (defOthers, Others);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramAcademicSessionID.GetSQLQuotedValueForAdd(),
                        paramStudentPopulation.GetSQLQuotedValueForAdd(),
                        paramAveragePricePerStudent.GetSQLQuotedValueForAdd(),
                        paramSCADWAREAccessRevenue.GetSQLQuotedValueForAdd(),
                        paramSideContractRevenue.GetSQLQuotedValueForAdd(),
                        paramGrossRevenue.GetSQLQuotedValueForAdd(),
                        paramWages.GetSQLQuotedValueForAdd(),
                        paramMarketing.GetSQLQuotedValueForAdd(),
                        paramCharity.GetSQLQuotedValueForAdd(),
                        paramOthers.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd()                        )
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
