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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___CashOut : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___CashOut()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCashRequestStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CashRequestStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCategoryID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CategoryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Amount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defReceiverID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ReceiverID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDescription = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Description.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RequestComments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defResponseComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ResponseComments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCashRequestStatusID.ColumnName, defCashRequestStatusID); 
          ColumnDefns.Add(defCategoryID.ColumnName, defCategoryID); 
          ColumnDefns.Add(defAmount.ColumnName, defAmount); 
          ColumnDefns.Add(defReceiverID.ColumnName, defReceiverID); 
          ColumnDefns.Add(defDescription.ColumnName, defDescription); 
          ColumnDefns.Add(defRequestComments.ColumnName, defRequestComments); 
          ColumnDefns.Add(defResponseComments.ColumnName, defResponseComments); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_CashOut_CashRequestStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.CashOut", "accounting.CashRequestStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_CashOut_CategoryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.CashOut", "accounting.ExpenditureCategory"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_CashOut_ReceiverID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.CashOut", "common.Person"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_CashOut_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.CashOut", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_CashOut_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.CashOut", "auth.Users"                  
                            ));                  

          }


                  
       public T___CashOut() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashOut(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashOut(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashOut(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashOut(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___CashOut(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashOut(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashOut(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashOut(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___CashOut(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.CashOut";
       public const string CashOut__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CashRequestStatusID], [CategoryID], [Amount], [ReceiverID], [Description], [RequestComments], [ResponseComments], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM CashOut";
       public const string CashOut__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CashRequestStatusID], [CategoryID], [Amount], [ReceiverID], [Description], [RequestComments], [ResponseComments], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM CashOut";


       public enum TableColumnNames
       {

           ID,
           CashRequestStatusID,
           CategoryID,
           Amount,
           ReceiverID,
           Description,
           RequestComments,
           ResponseComments,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_CashOut, 
           fk_charity_CashOut_CashRequestStatusID, 
           fk_charity_CashOut_CategoryID, 
           fk_charity_CashOut_ReceiverID, 
           fk_charity_CashOut_CreatedByID, 
           fk_charity_CashOut_UpdatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCashRequestStatusID;
       public static readonly DataColumnDefinition defCategoryID;
       public static readonly DataColumnDefinition defAmount;
       public static readonly DataColumnDefinition defReceiverID;
       public static readonly DataColumnDefinition defDescription;
       public static readonly DataColumnDefinition defRequestComments;
       public static readonly DataColumnDefinition defResponseComments;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public int CashRequestStatusID { get => (int)TargettedRow[TableColumnNames.CashRequestStatusID.ToString()]; }


       public int CategoryID { get => (int)TargettedRow[TableColumnNames.CategoryID.ToString()]; }


       public decimal Amount { get => (decimal)TargettedRow[TableColumnNames.Amount.ToString()]; }


       public int ReceiverID { get => (int)TargettedRow[TableColumnNames.ReceiverID.ToString()]; }


       public string Description { get => (string)TargettedRow[TableColumnNames.Description.ToString()]; }


       public string RequestComments { get => (string)TargettedRow[TableColumnNames.RequestComments.ToString()]; }


       public string ResponseComments { get => (string)TargettedRow[TableColumnNames.ResponseComments.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime UpdatedAt { get => (DateTime)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public int UpdatedByID { get => (int)TargettedRow[TableColumnNames.UpdatedByID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___CashOut GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___CashOut GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___CashOut GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___CashOut(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___CashOut GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => CashOut__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int CashRequestStatusID,
            int CategoryID,
            decimal Amount,
            int ReceiverID,
            string Description,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string RequestComments = null,
            string ResponseComments = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCashRequestStatusID = new (defCashRequestStatusID, CashRequestStatusID);
                DataColumnParameter paramCategoryID = new (defCategoryID, CategoryID);
                DataColumnParameter paramAmount = new (defAmount, Amount);
                DataColumnParameter paramReceiverID = new (defReceiverID, ReceiverID);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramRequestComments = new (defRequestComments, RequestComments);
                DataColumnParameter paramResponseComments = new (defResponseComments, ResponseComments);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CashRequestStatusID],[CategoryID],[Amount],[ReceiverID],[Description],[RequestComments],[ResponseComments],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  ", TABLE_NAME,
                        paramCashRequestStatusID.GetSQLQuotedValueForAdd(),
                        paramCategoryID.GetSQLQuotedValueForAdd(),
                        paramAmount.GetSQLQuotedValueForAdd(),
                        paramReceiverID.GetSQLQuotedValueForAdd(),
                        paramDescription.GetSQLQuotedValueForAdd(),
                        paramRequestComments.GetSQLQuotedValueForAdd(),
                        paramResponseComments.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd()                        )
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
            int CashRequestStatusID,
            int CategoryID,
            decimal Amount,
            int ReceiverID,
            string Description,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string RequestComments = null,
            string ResponseComments = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCashRequestStatusID = new (defCashRequestStatusID, CashRequestStatusID);
                DataColumnParameter paramCategoryID = new (defCategoryID, CategoryID);
                DataColumnParameter paramAmount = new (defAmount, Amount);
                DataColumnParameter paramReceiverID = new (defReceiverID, ReceiverID);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramRequestComments = new (defRequestComments, RequestComments);
                DataColumnParameter paramResponseComments = new (defResponseComments, ResponseComments);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CashRequestStatusID],[CategoryID],[Amount],[ReceiverID],[Description],[RequestComments],[ResponseComments],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramCashRequestStatusID.GetSQLQuotedValueForAdd(),
                        paramCategoryID.GetSQLQuotedValueForAdd(),
                        paramAmount.GetSQLQuotedValueForAdd(),
                        paramReceiverID.GetSQLQuotedValueForAdd(),
                        paramDescription.GetSQLQuotedValueForAdd(),
                        paramRequestComments.GetSQLQuotedValueForAdd(),
                        paramResponseComments.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
