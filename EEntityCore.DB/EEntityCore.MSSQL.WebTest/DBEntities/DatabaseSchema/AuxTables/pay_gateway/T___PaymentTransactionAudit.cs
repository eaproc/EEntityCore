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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.pay_gateway                  
{                  

    public class T___PaymentTransactionAudit : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PaymentTransactionAudit()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTransactionStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TransactionStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaymentTransactionID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentTransactionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBank = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Bank.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IPAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequired = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentRequired.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharges = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Charges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequiredWithoutCharges = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentRequiredWithoutCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRefundAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RefundAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Balance.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTransactionStatusID.ColumnName, defTransactionStatusID); 
          ColumnDefns.Add(defPaymentTransactionID.ColumnName, defPaymentTransactionID); 
          ColumnDefns.Add(defAccountName.ColumnName, defAccountName); 
          ColumnDefns.Add(defBank.ColumnName, defBank); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defPaymentRequired.ColumnName, defPaymentRequired); 
          ColumnDefns.Add(defCharges.ColumnName, defCharges); 
          ColumnDefns.Add(defPaymentRequiredWithoutCharges.ColumnName, defPaymentRequiredWithoutCharges); 
          ColumnDefns.Add(defRefundAmount.ColumnName, defRefundAmount); 
          ColumnDefns.Add(defBalance.ColumnName, defBalance); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_PaymentTransactionAudit_TransactionStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransactionAudit", "pay_gateway.TransactionStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransactionAudit_PaymentTransactionID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "pay_gateway.PaymentTransactionAudit", "pay_gateway.PaymentTransaction"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransactionAudit_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransactionAudit", "auth.Users"                  
                            ));                  

          }


                  
       public T___PaymentTransactionAudit() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PaymentTransactionAudit(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionAudit(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PaymentTransactionAudit(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "pay_gateway.PaymentTransactionAudit";
       public const string PaymentTransactionAudit__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TransactionStatusID], [PaymentTransactionID], [AccountName], [Bank], [IPAddress], [PaymentRequired], [Charges], [PaymentRequiredWithoutCharges], [RefundAmount], [Balance], [CreatedAt], [CreatedByID] FROM PaymentTransactionAudit";
       public const string PaymentTransactionAudit__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TransactionStatusID], [PaymentTransactionID], [AccountName], [Bank], [IPAddress], [PaymentRequired], [Charges], [PaymentRequiredWithoutCharges], [RefundAmount], [Balance], [CreatedAt], [CreatedByID] FROM PaymentTransactionAudit";


       public enum TableColumnNames
       {

           ID,
           TransactionStatusID,
           PaymentTransactionID,
           AccountName,
           Bank,
           IPAddress,
           PaymentRequired,
           Charges,
           PaymentRequiredWithoutCharges,
           RefundAmount,
           Balance,
           CreatedAt,
           CreatedByID
       } 



       public enum TableConstraints{

           pk_pay_gateway_PaymentTransactionAudit, 
           fk_pay_gateway_PaymentTransactionAudit_TransactionStatusID, 
           fk_PaymentTransactionAudit_PaymentTransactionID, 
           fk_PaymentTransactionAudit_CreatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTransactionStatusID;
       public static readonly DataColumnDefinition defPaymentTransactionID;
       public static readonly DataColumnDefinition defAccountName;
       public static readonly DataColumnDefinition defBank;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defPaymentRequired;
       public static readonly DataColumnDefinition defCharges;
       public static readonly DataColumnDefinition defPaymentRequiredWithoutCharges;
       public static readonly DataColumnDefinition defRefundAmount;
       public static readonly DataColumnDefinition defBalance;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;

       public int TransactionStatusID { get => (int)TargettedRow[TableColumnNames.TransactionStatusID.ToString()]; }


       public int PaymentTransactionID { get => (int)TargettedRow[TableColumnNames.PaymentTransactionID.ToString()]; }


       public string AccountName { get => (string)TargettedRow[TableColumnNames.AccountName.ToString()]; }


       public string Bank { get => (string)TargettedRow[TableColumnNames.Bank.ToString()]; }


       public string IPAddress { get => (string)TargettedRow[TableColumnNames.IPAddress.ToString()]; }


       public decimal PaymentRequired { get => (decimal)TargettedRow[TableColumnNames.PaymentRequired.ToString()]; }


       public decimal Charges { get => (decimal)TargettedRow[TableColumnNames.Charges.ToString()]; }


       public decimal PaymentRequiredWithoutCharges { get => (decimal)TargettedRow[TableColumnNames.PaymentRequiredWithoutCharges.ToString()]; }


       public decimal RefundAmount { get => (decimal)TargettedRow[TableColumnNames.RefundAmount.ToString()]; }


       public decimal Balance { get => (decimal)TargettedRow[TableColumnNames.Balance.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___PaymentTransactionAudit GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PaymentTransactionAudit GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PaymentTransactionAudit GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PaymentTransactionAudit(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PaymentTransactionAudit GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PaymentTransactionAudit__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int TransactionStatusID,
            int PaymentTransactionID,
            string AccountName,
            string Bank,
            string IPAddress,
            decimal PaymentRequired,
            decimal Charges,
            decimal PaymentRequiredWithoutCharges,
            decimal RefundAmount,
            decimal Balance,
            DateTime CreatedAt,
            int CreatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramTransactionStatusID = new (defTransactionStatusID, TransactionStatusID);
                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramPaymentRequired = new (defPaymentRequired, PaymentRequired);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);
                DataColumnParameter paramRefundAmount = new (defRefundAmount, RefundAmount);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TransactionStatusID],[PaymentTransactionID],[AccountName],[Bank],[IPAddress],[PaymentRequired],[Charges],[PaymentRequiredWithoutCharges],[RefundAmount],[Balance],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramTransactionStatusID.GetSQLQuotedValueForAdd(),
                        paramPaymentTransactionID.GetSQLQuotedValueForAdd(),
                        paramAccountName.GetSQLQuotedValueForAdd(),
                        paramBank.GetSQLQuotedValueForAdd(),
                        paramIPAddress.GetSQLQuotedValueForAdd(),
                        paramPaymentRequired.GetSQLQuotedValueForAdd(),
                        paramCharges.GetSQLQuotedValueForAdd(),
                        paramPaymentRequiredWithoutCharges.GetSQLQuotedValueForAdd(),
                        paramRefundAmount.GetSQLQuotedValueForAdd(),
                        paramBalance.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd()                        )
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
            int TransactionStatusID,
            int PaymentTransactionID,
            string AccountName,
            string Bank,
            string IPAddress,
            decimal PaymentRequired,
            decimal Charges,
            decimal PaymentRequiredWithoutCharges,
            decimal RefundAmount,
            decimal Balance,
            DateTime CreatedAt,
            int CreatedByID,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramTransactionStatusID = new (defTransactionStatusID, TransactionStatusID);
                DataColumnParameter paramPaymentTransactionID = new (defPaymentTransactionID, PaymentTransactionID);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramPaymentRequired = new (defPaymentRequired, PaymentRequired);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);
                DataColumnParameter paramRefundAmount = new (defRefundAmount, RefundAmount);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[PaymentTransactionID],[AccountName],[Bank],[IPAddress],[PaymentRequired],[Charges],[PaymentRequiredWithoutCharges],[RefundAmount],[Balance],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramTransactionStatusID.GetSQLQuotedValueForAdd(),
                        paramPaymentTransactionID.GetSQLQuotedValueForAdd(),
                        paramAccountName.GetSQLQuotedValueForAdd(),
                        paramBank.GetSQLQuotedValueForAdd(),
                        paramIPAddress.GetSQLQuotedValueForAdd(),
                        paramPaymentRequired.GetSQLQuotedValueForAdd(),
                        paramCharges.GetSQLQuotedValueForAdd(),
                        paramPaymentRequiredWithoutCharges.GetSQLQuotedValueForAdd(),
                        paramRefundAmount.GetSQLQuotedValueForAdd(),
                        paramBalance.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
