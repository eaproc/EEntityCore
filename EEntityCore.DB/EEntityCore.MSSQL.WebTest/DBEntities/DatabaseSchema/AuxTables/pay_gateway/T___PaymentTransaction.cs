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

    public class T___PaymentTransaction : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PaymentTransaction()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTransactionStatusID = new DataColumnDefinition(TableColumnNames.TransactionStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStudentNumber = new DataColumnDefinition(TableColumnNames.StudentNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountName = new DataColumnDefinition(TableColumnNames.AccountName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBank = new DataColumnDefinition(TableColumnNames.Bank.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChannel = new DataColumnDefinition(TableColumnNames.Channel.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSchoolDiscountGiven = new DataColumnDefinition(TableColumnNames.SchoolDiscountGiven.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequired = new DataColumnDefinition(TableColumnNames.PaymentRequired.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharges = new DataColumnDefinition(TableColumnNames.Charges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRefundAmount = new DataColumnDefinition(TableColumnNames.RefundAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(TableColumnNames.Balance.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defConfirmationThreshold = new DataColumnDefinition(TableColumnNames.ConfirmationThreshold.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defConfirmationDate = new DataColumnDefinition(TableColumnNames.ConfirmationDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAwaitingDisbursement = new DataColumnDefinition(TableColumnNames.AwaitingDisbursement.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defConfirmedExplanation = new DataColumnDefinition(TableColumnNames.ConfirmedExplanation.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChargesBilledToClient = new DataColumnDefinition(TableColumnNames.ChargesBilledToClient.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequiredWithoutCharges = new DataColumnDefinition(TableColumnNames.PaymentRequiredWithoutCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsMultiTarget = new DataColumnDefinition(TableColumnNames.IsMultiTarget.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTransactionStatusID.ColumnName, defTransactionStatusID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defStudentNumber.ColumnName, defStudentNumber); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defAccountName.ColumnName, defAccountName); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defBank.ColumnName, defBank); 
          ColumnDefns.Add(defChannel.ColumnName, defChannel); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defSchoolDiscountGiven.ColumnName, defSchoolDiscountGiven); 
          ColumnDefns.Add(defPaymentRequired.ColumnName, defPaymentRequired); 
          ColumnDefns.Add(defCharges.ColumnName, defCharges); 
          ColumnDefns.Add(defRefundAmount.ColumnName, defRefundAmount); 
          ColumnDefns.Add(defBalance.ColumnName, defBalance); 
          ColumnDefns.Add(defConfirmationThreshold.ColumnName, defConfirmationThreshold); 
          ColumnDefns.Add(defConfirmationDate.ColumnName, defConfirmationDate); 
          ColumnDefns.Add(defAwaitingDisbursement.ColumnName, defAwaitingDisbursement); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
          ColumnDefns.Add(defConfirmedExplanation.ColumnName, defConfirmedExplanation); 
          ColumnDefns.Add(defChargesBilledToClient.ColumnName, defChargesBilledToClient); 
          ColumnDefns.Add(defPaymentRequiredWithoutCharges.ColumnName, defPaymentRequiredWithoutCharges); 
          ColumnDefns.Add(defIsMultiTarget.ColumnName, defIsMultiTarget); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_PaymentTransaction_TransactionStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "pay_gateway.TransactionStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_PaymentTransaction_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransaction_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransaction_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "auth.Users"                  
                            ));                  

          }


                  
       public T___PaymentTransaction() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PaymentTransaction(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransaction(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PaymentTransaction(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "pay_gateway.PaymentTransaction";
       public const string PaymentTransaction__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TransactionStatusID], [ClientID], [StudentNumber], [FirstName], [LastName], [AccountName], [AccountNumber], [Bank], [Channel], [IPAddress], [SchoolDiscountGiven], [PaymentRequired], [Charges], [RefundAmount], [Balance], [ConfirmationThreshold], [ConfirmationDate], [AwaitingDisbursement], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID], [ConfirmedExplanation], [ChargesBilledToClient], [PaymentRequiredWithoutCharges], [IsMultiTarget] FROM PaymentTransaction";
       public const string PaymentTransaction__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TransactionStatusID], [ClientID], [StudentNumber], [FirstName], [LastName], [AccountName], [AccountNumber], [Bank], [Channel], [IPAddress], [SchoolDiscountGiven], [PaymentRequired], [Charges], [RefundAmount], [Balance], [ConfirmationThreshold], [ConfirmationDate], [AwaitingDisbursement], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID], [ConfirmedExplanation], [ChargesBilledToClient], [PaymentRequiredWithoutCharges], [IsMultiTarget] FROM PaymentTransaction";


       public enum TableColumnNames
       {

           ID,
           TransactionStatusID,
           ClientID,
           StudentNumber,
           FirstName,
           LastName,
           AccountName,
           AccountNumber,
           Bank,
           Channel,
           IPAddress,
           SchoolDiscountGiven,
           PaymentRequired,
           Charges,
           RefundAmount,
           Balance,
           ConfirmationThreshold,
           ConfirmationDate,
           AwaitingDisbursement,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID,
           ConfirmedExplanation,
           ChargesBilledToClient,
           PaymentRequiredWithoutCharges,
           IsMultiTarget
       } 



       public enum TableConstraints{

           pk_pay_gateway_PaymentTransaction, 
           fk_pay_gateway_PaymentTransaction_TransactionStatusID, 
           fk_pay_gateway_PaymentTransaction_ClientID, 
           fk_PaymentTransaction_CreatedByID, 
           fk_PaymentTransaction_UpdatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTransactionStatusID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defStudentNumber;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defAccountName;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defBank;
       public static readonly DataColumnDefinition defChannel;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defSchoolDiscountGiven;
       public static readonly DataColumnDefinition defPaymentRequired;
       public static readonly DataColumnDefinition defCharges;
       public static readonly DataColumnDefinition defRefundAmount;
       public static readonly DataColumnDefinition defBalance;
       public static readonly DataColumnDefinition defConfirmationThreshold;
       public static readonly DataColumnDefinition defConfirmationDate;
       public static readonly DataColumnDefinition defAwaitingDisbursement;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;
       public static readonly DataColumnDefinition defConfirmedExplanation;
       public static readonly DataColumnDefinition defChargesBilledToClient;
       public static readonly DataColumnDefinition defPaymentRequiredWithoutCharges;
       public static readonly DataColumnDefinition defIsMultiTarget;

       public int TransactionStatusID { get => (int)TargettedRow[TableColumnNames.TransactionStatusID.ToString()]; }


       public int ClientID { get => (int)TargettedRow[TableColumnNames.ClientID.ToString()]; }


       public string StudentNumber { get => (string)TargettedRow[TableColumnNames.StudentNumber.ToString()]; }


       public string FirstName { get => (string)TargettedRow[TableColumnNames.FirstName.ToString()]; }


       public string LastName { get => (string)TargettedRow[TableColumnNames.LastName.ToString()]; }


       public string AccountName { get => (string)TargettedRow[TableColumnNames.AccountName.ToString()]; }


       public string AccountNumber { get => (string)TargettedRow[TableColumnNames.AccountNumber.ToString()]; }


       public string Bank { get => (string)TargettedRow[TableColumnNames.Bank.ToString()]; }


       public string Channel { get => (string)TargettedRow[TableColumnNames.Channel.ToString()]; }


       public string IPAddress { get => (string)TargettedRow[TableColumnNames.IPAddress.ToString()]; }


       public decimal SchoolDiscountGiven { get => (decimal)TargettedRow[TableColumnNames.SchoolDiscountGiven.ToString()]; }


       public decimal PaymentRequired { get => (decimal)TargettedRow[TableColumnNames.PaymentRequired.ToString()]; }


       public decimal Charges { get => (decimal)TargettedRow[TableColumnNames.Charges.ToString()]; }


       public decimal RefundAmount { get => (decimal)TargettedRow[TableColumnNames.RefundAmount.ToString()]; }


       public decimal Balance { get => (decimal)TargettedRow[TableColumnNames.Balance.ToString()]; }


       public decimal? ConfirmationThreshold { get => (decimal?)TargettedRow[TableColumnNames.ConfirmationThreshold.ToString()]; }


       public DateTime? ConfirmationDate { get => (DateTime?)TargettedRow[TableColumnNames.ConfirmationDate.ToString()]; }


       public bool? AwaitingDisbursement { get => (bool?)TargettedRow[TableColumnNames.AwaitingDisbursement.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public int UpdatedByID { get => (int)TargettedRow[TableColumnNames.UpdatedByID.ToString()]; }


       public string ConfirmedExplanation { get => (string)TargettedRow[TableColumnNames.ConfirmedExplanation.ToString()]; }


       public bool? ChargesBilledToClient { get => (bool?)TargettedRow[TableColumnNames.ChargesBilledToClient.ToString()]; }


       public decimal PaymentRequiredWithoutCharges { get => (decimal)TargettedRow[TableColumnNames.PaymentRequiredWithoutCharges.ToString()]; }


       public bool? IsMultiTarget { get => (bool?)TargettedRow[TableColumnNames.IsMultiTarget.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___PaymentTransaction GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PaymentTransaction GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PaymentTransaction GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PaymentTransaction(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PaymentTransaction GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PaymentTransaction__NO__BINARY___SQL_FILL_QUERY;
                  
                  
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
            int ClientID,
            string StudentNumber,
            string FirstName,
            string LastName,
            string AccountName,
            string AccountNumber,
            string Bank,
            string Channel,
            string IPAddress,
            decimal SchoolDiscountGiven,
            decimal PaymentRequired,
            decimal Charges,
            decimal RefundAmount,
            decimal Balance,
            DateTime CreatedAt,
            int CreatedByID,
            int UpdatedByID,
            decimal PaymentRequiredWithoutCharges,
            decimal? ConfirmationThreshold = null,
            DateTime? ConfirmationDate = null,
            bool? AwaitingDisbursement = null,
            DateTime? UpdatedAt = null,
            string ConfirmedExplanation = null,
            bool? ChargesBilledToClient = null,
            bool? IsMultiTarget = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramTransactionStatusID = new (defTransactionStatusID, TransactionStatusID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramStudentNumber = new (defStudentNumber, StudentNumber);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramSchoolDiscountGiven = new (defSchoolDiscountGiven, SchoolDiscountGiven);
                DataColumnParameter paramPaymentRequired = new (defPaymentRequired, PaymentRequired);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramRefundAmount = new (defRefundAmount, RefundAmount);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramConfirmationThreshold = new (defConfirmationThreshold, ConfirmationThreshold);
                DataColumnParameter paramConfirmationDate = new (defConfirmationDate, ConfirmationDate);
                DataColumnParameter paramAwaitingDisbursement = new (defAwaitingDisbursement, AwaitingDisbursement);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramConfirmedExplanation = new (defConfirmedExplanation, ConfirmedExplanation);
                DataColumnParameter paramChargesBilledToClient = new (defChargesBilledToClient, ChargesBilledToClient);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);
                DataColumnParameter paramIsMultiTarget = new (defIsMultiTarget, IsMultiTarget);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26})  ", TABLE_NAME,
                        paramTransactionStatusID.GetSQLQuotedValueForAdd(),
                        paramClientID.GetSQLQuotedValueForAdd(),
                        paramStudentNumber.GetSQLQuotedValueForAdd(),
                        paramFirstName.GetSQLQuotedValueForAdd(),
                        paramLastName.GetSQLQuotedValueForAdd(),
                        paramAccountName.GetSQLQuotedValueForAdd(),
                        paramAccountNumber.GetSQLQuotedValueForAdd(),
                        paramBank.GetSQLQuotedValueForAdd(),
                        paramChannel.GetSQLQuotedValueForAdd(),
                        paramIPAddress.GetSQLQuotedValueForAdd(),
                        paramSchoolDiscountGiven.GetSQLQuotedValueForAdd(),
                        paramPaymentRequired.GetSQLQuotedValueForAdd(),
                        paramCharges.GetSQLQuotedValueForAdd(),
                        paramRefundAmount.GetSQLQuotedValueForAdd(),
                        paramBalance.GetSQLQuotedValueForAdd(),
                        paramConfirmationThreshold.GetSQLQuotedValueForAdd(),
                        paramConfirmationDate.GetSQLQuotedValueForAdd(),
                        paramAwaitingDisbursement.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd(),
                        paramConfirmedExplanation.GetSQLQuotedValueForAdd(),
                        paramChargesBilledToClient.GetSQLQuotedValueForAdd(),
                        paramPaymentRequiredWithoutCharges.GetSQLQuotedValueForAdd(),
                        paramIsMultiTarget.GetSQLQuotedValueForAdd()                        )
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
            int ClientID,
            string StudentNumber,
            string FirstName,
            string LastName,
            string AccountName,
            string AccountNumber,
            string Bank,
            string Channel,
            string IPAddress,
            decimal SchoolDiscountGiven,
            decimal PaymentRequired,
            decimal Charges,
            decimal RefundAmount,
            decimal Balance,
            DateTime CreatedAt,
            int CreatedByID,
            int UpdatedByID,
            decimal PaymentRequiredWithoutCharges,
            decimal? ConfirmationThreshold = null,
            DateTime? ConfirmationDate = null,
            bool? AwaitingDisbursement = null,
            DateTime? UpdatedAt = null,
            string ConfirmedExplanation = null,
            bool? ChargesBilledToClient = null,
            bool? IsMultiTarget = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramTransactionStatusID = new (defTransactionStatusID, TransactionStatusID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramStudentNumber = new (defStudentNumber, StudentNumber);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramAccountName = new (defAccountName, AccountName);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramBank = new (defBank, Bank);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramSchoolDiscountGiven = new (defSchoolDiscountGiven, SchoolDiscountGiven);
                DataColumnParameter paramPaymentRequired = new (defPaymentRequired, PaymentRequired);
                DataColumnParameter paramCharges = new (defCharges, Charges);
                DataColumnParameter paramRefundAmount = new (defRefundAmount, RefundAmount);
                DataColumnParameter paramBalance = new (defBalance, Balance);
                DataColumnParameter paramConfirmationThreshold = new (defConfirmationThreshold, ConfirmationThreshold);
                DataColumnParameter paramConfirmationDate = new (defConfirmationDate, ConfirmationDate);
                DataColumnParameter paramAwaitingDisbursement = new (defAwaitingDisbursement, AwaitingDisbursement);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramConfirmedExplanation = new (defConfirmedExplanation, ConfirmedExplanation);
                DataColumnParameter paramChargesBilledToClient = new (defChargesBilledToClient, ChargesBilledToClient);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new (defPaymentRequiredWithoutCharges, PaymentRequiredWithoutCharges);
                DataColumnParameter paramIsMultiTarget = new (defIsMultiTarget, IsMultiTarget);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramTransactionStatusID.GetSQLQuotedValueForAdd(),
                        paramClientID.GetSQLQuotedValueForAdd(),
                        paramStudentNumber.GetSQLQuotedValueForAdd(),
                        paramFirstName.GetSQLQuotedValueForAdd(),
                        paramLastName.GetSQLQuotedValueForAdd(),
                        paramAccountName.GetSQLQuotedValueForAdd(),
                        paramAccountNumber.GetSQLQuotedValueForAdd(),
                        paramBank.GetSQLQuotedValueForAdd(),
                        paramChannel.GetSQLQuotedValueForAdd(),
                        paramIPAddress.GetSQLQuotedValueForAdd(),
                        paramSchoolDiscountGiven.GetSQLQuotedValueForAdd(),
                        paramPaymentRequired.GetSQLQuotedValueForAdd(),
                        paramCharges.GetSQLQuotedValueForAdd(),
                        paramRefundAmount.GetSQLQuotedValueForAdd(),
                        paramBalance.GetSQLQuotedValueForAdd(),
                        paramConfirmationThreshold.GetSQLQuotedValueForAdd(),
                        paramConfirmationDate.GetSQLQuotedValueForAdd(),
                        paramAwaitingDisbursement.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd(),
                        paramConfirmedExplanation.GetSQLQuotedValueForAdd(),
                        paramChargesBilledToClient.GetSQLQuotedValueForAdd(),
                        paramPaymentRequiredWithoutCharges.GetSQLQuotedValueForAdd(),
                        paramIsMultiTarget.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
