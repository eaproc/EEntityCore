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

    public class T___ExpenseRequest : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ExpenseRequest()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defBeneficiaryID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BeneficiaryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBankID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BankID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCategoryID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CategoryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.StatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defRequest = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Request.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defResponse = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Response.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAmountRequested = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AmountRequested.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAmountGranted = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AmountGranted.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defCategoryID.ColumnName, defCategoryID); 
          ColumnDefns.Add(defStatusID.ColumnName, defStatusID); 
          ColumnDefns.Add(defRequest.ColumnName, defRequest); 
          ColumnDefns.Add(defResponse.ColumnName, defResponse); 
          ColumnDefns.Add(defAmountRequested.ColumnName, defAmountRequested); 
          ColumnDefns.Add(defAmountGranted.ColumnName, defAmountGranted); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ExpenseRequest_CategoryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ExpenseRequest", "accounting.ExpenditureCategory"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ExpenseRequest_StatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ExpenseRequest", "accounting.CashRequestStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ExpenseRequest_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ExpenseRequest", "common.Bank"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ExpenseRequest_BeneficiaryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ExpenseRequest", "common.Person"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ExpenseRequest_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ExpenseRequest", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ExpenseRequest_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ExpenseRequest", "auth.Users"                  
                            ));                  

          }


                  
       public T___ExpenseRequest() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ExpenseRequest(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ExpenseRequest(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ExpenseRequest(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ExpenseRequest(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ExpenseRequest(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ExpenseRequest(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ExpenseRequest(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ExpenseRequest(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___ExpenseRequest(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.ExpenseRequest";
       public const string ExpenseRequest__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [BeneficiaryID], [BankID], [AccountNumber], [CategoryID], [StatusID], [Request], [Response], [AmountRequested], [AmountGranted], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM ExpenseRequest";
       public const string ExpenseRequest__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [BeneficiaryID], [BankID], [AccountNumber], [CategoryID], [StatusID], [Request], [Response], [AmountRequested], [AmountGranted], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM ExpenseRequest";


       public enum TableColumnNames
       {

           ID,
           BeneficiaryID,
           BankID,
           AccountNumber,
           CategoryID,
           StatusID,
           Request,
           Response,
           AmountRequested,
           AmountGranted,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_ExpenseRequest, 
           fk_charity_ExpenseRequest_CategoryID, 
           fk_charity_ExpenseRequest_StatusID, 
           fk_charity_ExpenseRequest_BankID, 
           fk_charity_ExpenseRequest_BeneficiaryID, 
           fk_charity_ExpenseRequest_CreatedByID, 
           fk_charity_ExpenseRequest_UpdatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defCategoryID;
       public static readonly DataColumnDefinition defStatusID;
       public static readonly DataColumnDefinition defRequest;
       public static readonly DataColumnDefinition defResponse;
       public static readonly DataColumnDefinition defAmountRequested;
       public static readonly DataColumnDefinition defAmountGranted;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public int BeneficiaryID { get => (int)TargettedRow[TableColumnNames.BeneficiaryID.ToString()]; }


       public int BankID { get => (int)TargettedRow[TableColumnNames.BankID.ToString()]; }


       public string AccountNumber { get => (string)TargettedRow[TableColumnNames.AccountNumber.ToString()]; }


       public int CategoryID { get => (int)TargettedRow[TableColumnNames.CategoryID.ToString()]; }


       public int StatusID { get => (int)TargettedRow[TableColumnNames.StatusID.ToString()]; }


       public string Request { get => (string)TargettedRow[TableColumnNames.Request.ToString()]; }


       public string Response { get => (string)TargettedRow[TableColumnNames.Response.ToString()]; }


       public decimal AmountRequested { get => (decimal)TargettedRow[TableColumnNames.AmountRequested.ToString()]; }


       public decimal AmountGranted { get => (decimal)TargettedRow[TableColumnNames.AmountGranted.ToString()]; }


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
        public T___ExpenseRequest GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___ExpenseRequest GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___ExpenseRequest GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___ExpenseRequest(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___ExpenseRequest GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => ExpenseRequest__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int BeneficiaryID,
            int BankID,
            string AccountNumber,
            int CategoryID,
            int StatusID,
            string Request,
            decimal AmountRequested,
            decimal AmountGranted,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string Response = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramCategoryID = new (defCategoryID, CategoryID);
                DataColumnParameter paramStatusID = new (defStatusID, StatusID);
                DataColumnParameter paramRequest = new (defRequest, Request);
                DataColumnParameter paramResponse = new (defResponse, Response);
                DataColumnParameter paramAmountRequested = new (defAmountRequested, AmountRequested);
                DataColumnParameter paramAmountGranted = new (defAmountGranted, AmountGranted);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([BeneficiaryID],[BankID],[AccountNumber],[CategoryID],[StatusID],[Request],[Response],[AmountRequested],[AmountGranted],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramBeneficiaryID.GetSQLQuotedValueForAdd(),
                        paramBankID.GetSQLQuotedValueForAdd(),
                        paramAccountNumber.GetSQLQuotedValueForAdd(),
                        paramCategoryID.GetSQLQuotedValueForAdd(),
                        paramStatusID.GetSQLQuotedValueForAdd(),
                        paramRequest.GetSQLQuotedValueForAdd(),
                        paramResponse.GetSQLQuotedValueForAdd(),
                        paramAmountRequested.GetSQLQuotedValueForAdd(),
                        paramAmountGranted.GetSQLQuotedValueForAdd(),
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
            int BeneficiaryID,
            int BankID,
            string AccountNumber,
            int CategoryID,
            int StatusID,
            string Request,
            decimal AmountRequested,
            decimal AmountGranted,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string Response = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramCategoryID = new (defCategoryID, CategoryID);
                DataColumnParameter paramStatusID = new (defStatusID, StatusID);
                DataColumnParameter paramRequest = new (defRequest, Request);
                DataColumnParameter paramResponse = new (defResponse, Response);
                DataColumnParameter paramAmountRequested = new (defAmountRequested, AmountRequested);
                DataColumnParameter paramAmountGranted = new (defAmountGranted, AmountGranted);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BeneficiaryID],[BankID],[AccountNumber],[CategoryID],[StatusID],[Request],[Response],[AmountRequested],[AmountGranted],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramBeneficiaryID.GetSQLQuotedValueForAdd(),
                        paramBankID.GetSQLQuotedValueForAdd(),
                        paramAccountNumber.GetSQLQuotedValueForAdd(),
                        paramCategoryID.GetSQLQuotedValueForAdd(),
                        paramStatusID.GetSQLQuotedValueForAdd(),
                        paramRequest.GetSQLQuotedValueForAdd(),
                        paramResponse.GetSQLQuotedValueForAdd(),
                        paramAmountRequested.GetSQLQuotedValueForAdd(),
                        paramAmountGranted.GetSQLQuotedValueForAdd(),
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
