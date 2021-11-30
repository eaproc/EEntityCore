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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.pay_gateway                  
{                  

    public class T___Payout : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Payout()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaidInAmount = new DataColumnDefinition(TableColumnNames.PaidInAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaidInCharges = new DataColumnDefinition(TableColumnNames.PaidInCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayoutAmount = new DataColumnDefinition(TableColumnNames.PayoutAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayoutCharge = new DataColumnDefinition(TableColumnNames.PayoutCharge.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(TableColumnNames.Balance.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTransactionStartDate = new DataColumnDefinition(TableColumnNames.TransactionStartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTransactionEndDate = new DataColumnDefinition(TableColumnNames.TransactionEndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAwaitingPayout = new DataColumnDefinition(TableColumnNames.AwaitingPayout.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSynced = new DataColumnDefinition(TableColumnNames.Synced.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountName = new DataColumnDefinition(TableColumnNames.AccountName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defPaidInAmount.ColumnName, defPaidInAmount); 
          ColumnDefns.Add(defPaidInCharges.ColumnName, defPaidInCharges); 
          ColumnDefns.Add(defPayoutAmount.ColumnName, defPayoutAmount); 
          ColumnDefns.Add(defPayoutCharge.ColumnName, defPayoutCharge); 
          ColumnDefns.Add(defBalance.ColumnName, defBalance); 
          ColumnDefns.Add(defTransactionStartDate.ColumnName, defTransactionStartDate); 
          ColumnDefns.Add(defTransactionEndDate.ColumnName, defTransactionEndDate); 
          ColumnDefns.Add(defAwaitingPayout.ColumnName, defAwaitingPayout); 
          ColumnDefns.Add(defSynced.ColumnName, defSynced); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountName.ColumnName, defAccountName); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_Payout_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_Payout_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_Payout_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Client_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "common.Bank"                  
                            ));                  

          }


                  
       public T___Payout() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Payout(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payout(DataTable FullTable) : base(FullTable)                                    
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
        public T___Payout(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "pay_gateway.Payout";
       public const string Payout__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CreatedByID], [UpdatedByID], [ClientID], [PaidInAmount], [PaidInCharges], [PayoutAmount], [PayoutCharge], [Balance], [TransactionStartDate], [TransactionEndDate], [AwaitingPayout], [Synced], [CreatedAt], [UpdatedAt], [BankID], [AccountName], [AccountNumber] FROM pay_gateway.Payout";
       public const string Payout__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CreatedByID], [UpdatedByID], [ClientID], [PaidInAmount], [PaidInCharges], [PayoutAmount], [PayoutCharge], [Balance], [TransactionStartDate], [TransactionEndDate], [AwaitingPayout], [Synced], [CreatedAt], [UpdatedAt], [BankID], [AccountName], [AccountNumber] FROM pay_gateway.Payout";


       public enum TableColumnNames
       {

           ID,
           CreatedByID,
           UpdatedByID,
           ClientID,
           PaidInAmount,
           PaidInCharges,
           PayoutAmount,
           PayoutCharge,
           Balance,
           TransactionStartDate,
           TransactionEndDate,
           AwaitingPayout,
           Synced,
           CreatedAt,
           UpdatedAt,
           BankID,
           AccountName,
           AccountNumber
       } 



       public enum TableConstraints{

           pk_pay_gateway_Payout, 
           fk_pay_gateway_Payout_CreatedByID, 
           fk_pay_gateway_Payout_UpdatedByID, 
           fk_pay_gateway_Payout_ClientID, 
           fk_hr_Client_BankID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defPaidInAmount;
       public static readonly DataColumnDefinition defPaidInCharges;
       public static readonly DataColumnDefinition defPayoutAmount;
       public static readonly DataColumnDefinition defPayoutCharge;
       public static readonly DataColumnDefinition defBalance;
       public static readonly DataColumnDefinition defTransactionStartDate;
       public static readonly DataColumnDefinition defTransactionEndDate;
       public static readonly DataColumnDefinition defAwaitingPayout;
       public static readonly DataColumnDefinition defSynced;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountName;
       public static readonly DataColumnDefinition defAccountNumber;

       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public int? UpdatedByID { get => (int?)TargettedRow[TableColumnNames.UpdatedByID.ToString()]; }


       public int ClientID { get => (int)TargettedRow[TableColumnNames.ClientID.ToString()]; }


       public decimal PaidInAmount { get => (decimal)TargettedRow[TableColumnNames.PaidInAmount.ToString()]; }


       public decimal PaidInCharges { get => (decimal)TargettedRow[TableColumnNames.PaidInCharges.ToString()]; }


       public decimal PayoutAmount { get => (decimal)TargettedRow[TableColumnNames.PayoutAmount.ToString()]; }


       public decimal PayoutCharge { get => (decimal)TargettedRow[TableColumnNames.PayoutCharge.ToString()]; }


       public decimal Balance { get => (decimal)TargettedRow[TableColumnNames.Balance.ToString()]; }


       public DateTime TransactionStartDate { get => (DateTime)TargettedRow[TableColumnNames.TransactionStartDate.ToString()]; }


       public DateTime TransactionEndDate { get => (DateTime)TargettedRow[TableColumnNames.TransactionEndDate.ToString()]; }


       public bool? AwaitingPayout { get => (bool?)TargettedRow[TableColumnNames.AwaitingPayout.ToString()]; }


       public bool? Synced { get => (bool?)TargettedRow[TableColumnNames.Synced.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


       public int BankID { get => (int)TargettedRow[TableColumnNames.BankID.ToString()]; }


       public string AccountName { get => (string)TargettedRow[TableColumnNames.AccountName.ToString()]; }


       public string AccountNumber { get => (string)TargettedRow[TableColumnNames.AccountNumber.ToString()]; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___Payout GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Payout GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Payout(conn.Fetch(Payout__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___Payout GetRowWhereIDUsingSQL(int pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Payout( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Payout GetRowWhereID(int pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Payout__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int CreatedByID,
            int ClientID,
            decimal PaidInAmount,
            decimal PaidInCharges,
            decimal PayoutAmount,
            decimal PayoutCharge,
            decimal Balance,
            DateTime TransactionStartDate,
            DateTime TransactionEndDate,
            DateTime CreatedAt,
            int BankID,
            string AccountName,
            string AccountNumber,
            int? UpdatedByID = null,
            bool? AwaitingPayout = null,
            bool? Synced = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramPaidInAmount = new (defPaidInAmount, PaidInAmount);
                DataColumnParameter paramPaidInCharges = new (defPaidInCharges, PaidInCharges);
                DataColumnParameter paramPayoutAmount = new (defPayoutAmount, PayoutAmount);
                DataColumnParameter paramPayoutCharge = new (defPayoutCharge, PayoutCharge);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramTransactionStartDate = new (defTransactionStartDate, TransactionStartDate);
                DataColumnParameter paramTransactionEndDate = new (defTransactionEndDate, TransactionEndDate);
                DataColumnParameter paramAwaitingPayout = new (defAwaitingPayout, AwaitingPayout);
                DataColumnParameter paramSynced = new (defSynced, Synced);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  ", TABLE_NAME,
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd(),
                        paramClientID.GetSQLQuotedValueForAdd(),
                        paramPaidInAmount.GetSQLQuotedValueForAdd(),
                        paramPaidInCharges.GetSQLQuotedValueForAdd(),
                        paramPayoutAmount.GetSQLQuotedValueForAdd(),
                        paramPayoutCharge.GetSQLQuotedValueForAdd(),
                        paramBalance.GetSQLQuotedValueForAdd(),
                        paramTransactionStartDate.GetSQLQuotedValueForAdd(),
                        paramTransactionEndDate.GetSQLQuotedValueForAdd(),
                        paramAwaitingPayout.GetSQLQuotedValueForAdd(),
                        paramSynced.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramBankID.GetSQLQuotedValueForAdd(),
                        paramAccountName.GetSQLQuotedValueForAdd(),
                        paramAccountNumber.GetSQLQuotedValueForAdd()                        )
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
            int CreatedByID,
            int ClientID,
            decimal PaidInAmount,
            decimal PaidInCharges,
            decimal PayoutAmount,
            decimal PayoutCharge,
            decimal Balance,
            DateTime TransactionStartDate,
            DateTime TransactionEndDate,
            DateTime CreatedAt,
            int BankID,
            string AccountName,
            string AccountNumber,
            int? UpdatedByID = null,
            bool? AwaitingPayout = null,
            bool? Synced = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramPaidInAmount = new (defPaidInAmount, PaidInAmount);
                DataColumnParameter paramPaidInCharges = new (defPaidInCharges, PaidInCharges);
                DataColumnParameter paramPayoutAmount = new (defPayoutAmount, PayoutAmount);
                DataColumnParameter paramPayoutCharge = new (defPayoutCharge, PayoutCharge);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramTransactionStartDate = new (defTransactionStartDate, TransactionStartDate);
                DataColumnParameter paramTransactionEndDate = new (defTransactionEndDate, TransactionEndDate);
                DataColumnParameter paramAwaitingPayout = new (defAwaitingPayout, AwaitingPayout);
                DataColumnParameter paramSynced = new (defSynced, Synced);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd(),
                        paramClientID.GetSQLQuotedValueForAdd(),
                        paramPaidInAmount.GetSQLQuotedValueForAdd(),
                        paramPaidInCharges.GetSQLQuotedValueForAdd(),
                        paramPayoutAmount.GetSQLQuotedValueForAdd(),
                        paramPayoutCharge.GetSQLQuotedValueForAdd(),
                        paramBalance.GetSQLQuotedValueForAdd(),
                        paramTransactionStartDate.GetSQLQuotedValueForAdd(),
                        paramTransactionEndDate.GetSQLQuotedValueForAdd(),
                        paramAwaitingPayout.GetSQLQuotedValueForAdd(),
                        paramSynced.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramBankID.GetSQLQuotedValueForAdd(),
                        paramAccountName.GetSQLQuotedValueForAdd(),
                        paramAccountNumber.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int CreatedByID,
            int ClientID,
            decimal PaidInAmount,
            decimal PaidInCharges,
            decimal PayoutAmount,
            decimal PayoutCharge,
            decimal Balance,
            DateTime TransactionStartDate,
            DateTime TransactionEndDate,
            DateTime CreatedAt,
            int BankID,
            string AccountName,
            string AccountNumber,
            int? UpdatedByID = null,
            bool? AwaitingPayout = null,
            bool? Synced = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramPaidInAmount = new (defPaidInAmount, PaidInAmount);
                DataColumnParameter paramPaidInCharges = new (defPaidInCharges, PaidInCharges);
                DataColumnParameter paramPayoutAmount = new (defPayoutAmount, PayoutAmount);
                DataColumnParameter paramPayoutCharge = new (defPayoutCharge, PayoutCharge);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramTransactionStartDate = new (defTransactionStartDate, TransactionStartDate);
                DataColumnParameter paramTransactionEndDate = new (defTransactionEndDate, TransactionEndDate);
                DataColumnParameter paramAwaitingPayout = new (defAwaitingPayout, AwaitingPayout);
                DataColumnParameter paramSynced = new (defSynced, Synced);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  ", TABLE_NAME,
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd(),
                        paramClientID.GetSQLQuotedValueForAdd(),
                        paramPaidInAmount.GetSQLQuotedValueForAdd(),
                        paramPaidInCharges.GetSQLQuotedValueForAdd(),
                        paramPayoutAmount.GetSQLQuotedValueForAdd(),
                        paramPayoutCharge.GetSQLQuotedValueForAdd(),
                        paramBalance.GetSQLQuotedValueForAdd(),
                        paramTransactionStartDate.GetSQLQuotedValueForAdd(),
                        paramTransactionEndDate.GetSQLQuotedValueForAdd(),
                        paramAwaitingPayout.GetSQLQuotedValueForAdd(),
                        paramSynced.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramBankID.GetSQLQuotedValueForAdd(),
                        paramAccountName.GetSQLQuotedValueForAdd(),
                        paramAccountNumber.GetSQLQuotedValueForAdd()                            
                            )
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
