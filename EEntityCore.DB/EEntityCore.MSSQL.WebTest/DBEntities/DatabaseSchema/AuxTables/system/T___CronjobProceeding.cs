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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.system                  
{                  

    public class T___CronjobProceeding : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___CronjobProceeding()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCronjobID = new DataColumnDefinition(TableColumnNames.CronjobID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defProceedingStatusID = new DataColumnDefinition(TableColumnNames.ProceedingStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNextExpectedExecutionTime = new DataColumnDefinition(TableColumnNames.NextExpectedExecutionTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsSuccessful = new DataColumnDefinition(TableColumnNames.IsSuccessful.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCronjobID.ColumnName, defCronjobID); 
          ColumnDefns.Add(defProceedingStatusID.ColumnName, defProceedingStatusID); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defNextExpectedExecutionTime.ColumnName, defNextExpectedExecutionTime); 
          ColumnDefns.Add(defIsSuccessful.ColumnName, defIsSuccessful); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_CronjobProceeding_CronjobID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "system.CronjobProceeding", "system.Cronjob"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_CronjobProceeding_ProceedingStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.CronjobProceeding", "system.CronjobProceedingStatus"                  
                            ));                  

          }


                  
       public T___CronjobProceeding() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___CronjobProceeding(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___CronjobProceeding(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.CronjobProceeding";
       public const string CronjobProceeding__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CronjobID], [ProceedingStatusID], [Comments], [NextExpectedExecutionTime], [IsSuccessful], [CreatedAt] FROM CronjobProceeding";
       public const string CronjobProceeding__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CronjobID], [ProceedingStatusID], [Comments], [NextExpectedExecutionTime], [IsSuccessful], [CreatedAt] FROM CronjobProceeding";


       public enum TableColumnNames
       {

           ID,
           CronjobID,
           ProceedingStatusID,
           Comments,
           NextExpectedExecutionTime,
           IsSuccessful,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_system_CronjobProceeding, 
           fk_system_CronjobProceeding_CronjobID, 
           fk_system_CronjobProceeding_ProceedingStatusID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCronjobID;
       public static readonly DataColumnDefinition defProceedingStatusID;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defNextExpectedExecutionTime;
       public static readonly DataColumnDefinition defIsSuccessful;
       public static readonly DataColumnDefinition defCreatedAt;

       public int CronjobID { get => (int)TargettedRow[TableColumnNames.CronjobID.ToString()]; }


       public int ProceedingStatusID { get => (int)TargettedRow[TableColumnNames.ProceedingStatusID.ToString()]; }


       public string Comments { get => (string)TargettedRow[TableColumnNames.Comments.ToString()]; }


       public DateTime? NextExpectedExecutionTime { get => (DateTime?)TargettedRow[TableColumnNames.NextExpectedExecutionTime.ToString()]; }


       public bool IsSuccessful { get => (bool)TargettedRow[TableColumnNames.IsSuccessful.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___CronjobProceeding GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___CronjobProceeding GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___CronjobProceeding GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___CronjobProceeding(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___CronjobProceeding GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => CronjobProceeding__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int CronjobID,
            int ProceedingStatusID,
            bool IsSuccessful,
            DateTime CreatedAt,
            string Comments = null,
            DateTime? NextExpectedExecutionTime = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCronjobID = new (defCronjobID, CronjobID);
                DataColumnParameter paramProceedingStatusID = new (defProceedingStatusID, ProceedingStatusID);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramNextExpectedExecutionTime = new (defNextExpectedExecutionTime, NextExpectedExecutionTime);
                DataColumnParameter paramIsSuccessful = new (defIsSuccessful, IsSuccessful);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CronjobID],[ProceedingStatusID],[Comments],[NextExpectedExecutionTime],[IsSuccessful],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6})  ", TABLE_NAME,
                        paramCronjobID.GetSQLQuotedValueForAdd(),
                        paramProceedingStatusID.GetSQLQuotedValueForAdd(),
                        paramComments.GetSQLQuotedValueForAdd(),
                        paramNextExpectedExecutionTime.GetSQLQuotedValueForAdd(),
                        paramIsSuccessful.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd()                        )
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
            int CronjobID,
            int ProceedingStatusID,
            bool IsSuccessful,
            DateTime CreatedAt,
            string Comments = null,
            DateTime? NextExpectedExecutionTime = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCronjobID = new (defCronjobID, CronjobID);
                DataColumnParameter paramProceedingStatusID = new (defProceedingStatusID, ProceedingStatusID);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramNextExpectedExecutionTime = new (defNextExpectedExecutionTime, NextExpectedExecutionTime);
                DataColumnParameter paramIsSuccessful = new (defIsSuccessful, IsSuccessful);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CronjobID],[ProceedingStatusID],[Comments],[NextExpectedExecutionTime],[IsSuccessful],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramCronjobID.GetSQLQuotedValueForAdd(),
                        paramProceedingStatusID.GetSQLQuotedValueForAdd(),
                        paramComments.GetSQLQuotedValueForAdd(),
                        paramNextExpectedExecutionTime.GetSQLQuotedValueForAdd(),
                        paramIsSuccessful.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
