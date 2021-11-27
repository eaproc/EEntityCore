using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using EEntityCore.DB.Schemas.SQLServerSchema;                  
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
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTransactionStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TransactionStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defClientID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStudentNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.StudentNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FirstName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LastName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBank = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Bank.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChannel = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Channel.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IPAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSchoolDiscountGiven = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SchoolDiscountGiven.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequired = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentRequired.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharges = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Charges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRefundAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RefundAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Balance.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defConfirmationThreshold = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ConfirmationThreshold.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defConfirmationDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ConfirmationDate.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAwaitingDisbursement = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AwaitingDisbursement.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defConfirmedExplanation = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ConfirmedExplanation.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChargesBilledToClient = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ChargesBilledToClient.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequiredWithoutCharges = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentRequiredWithoutCharges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsMultiTarget = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsMultiTarget.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       public Int32 TransactionStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TransactionStatusID.ToString()]);
           }
       }


       public Int32 ClientID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ClientID.ToString()]);
           }
       }


       public String StudentNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.StudentNumber.ToString()]);
           }
       }


       public String FirstName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FirstName.ToString()]);
           }
       }


       public String LastName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.LastName.ToString()]);
           }
       }


       public String AccountName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountName.ToString()]);
           }
       }


       public String AccountNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountNumber.ToString()]);
           }
       }


       public String Bank {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Bank.ToString()]);
           }
       }


       public String Channel {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Channel.ToString()]);
           }
       }


       public String IPAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IPAddress.ToString()]);
           }
       }


       public Decimal SchoolDiscountGiven {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.SchoolDiscountGiven.ToString()]);
           }
       }


       public Decimal PaymentRequired {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PaymentRequired.ToString()]);
           }
       }


       public Decimal Charges {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Charges.ToString()]);
           }
       }


       public Decimal RefundAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.RefundAmount.ToString()]);
           }
       }


       public Decimal Balance {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Balance.ToString()]);
           }
       }


       public Decimal ConfirmationThreshold {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.ConfirmationThreshold.ToString()]);
           }
       }


       public NullableDateTime ConfirmationDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.ConfirmationDate.ToString()]);
           }
       }


       public Boolean AwaitingDisbursement {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.AwaitingDisbursement.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public NullableDateTime UpdatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]);
           }
       }


       public Int32 CreatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


       public Int32 UpdatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UpdatedByID.ToString()]);
           }
       }


       public String ConfirmedExplanation {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ConfirmedExplanation.ToString()]);
           }
       }


       public Boolean ChargesBilledToClient {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.ChargesBilledToClient.ToString()]);
           }
       }


       public Decimal PaymentRequiredWithoutCharges {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PaymentRequiredWithoutCharges.ToString()]);
           }
       }


       public Boolean IsMultiTarget {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsMultiTarget.ToString()]);
           }
       }


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
                  
                  




        public static int AddNewDefault(Int32 pTransactionStatusID,
Int32 pClientID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTransactionStatusID = new DataColumnParameter(defTransactionStatusID, pTransactionStatusID);
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramStudentNumber = new DataColumnParameter(defStudentNumber, defStudentNumber.DefaultValue);
                DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, defFirstName.DefaultValue);
                DataColumnParameter paramLastName = new DataColumnParameter(defLastName, defLastName.DefaultValue);
                DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, defAccountName.DefaultValue);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue);
                DataColumnParameter paramBank = new DataColumnParameter(defBank, defBank.DefaultValue);
                DataColumnParameter paramChannel = new DataColumnParameter(defChannel, defChannel.DefaultValue);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, defIPAddress.DefaultValue);
                DataColumnParameter paramSchoolDiscountGiven = new DataColumnParameter(defSchoolDiscountGiven, defSchoolDiscountGiven.DefaultValue);
                DataColumnParameter paramPaymentRequired = new DataColumnParameter(defPaymentRequired, defPaymentRequired.DefaultValue);
                DataColumnParameter paramCharges = new DataColumnParameter(defCharges, defCharges.DefaultValue);
                DataColumnParameter paramRefundAmount = new DataColumnParameter(defRefundAmount, defRefundAmount.DefaultValue);
                DataColumnParameter paramBalance = new DataColumnParameter(defBalance, defBalance.DefaultValue);
                DataColumnParameter paramConfirmationThreshold = new DataColumnParameter(defConfirmationThreshold, defConfirmationThreshold.DefaultValue);
                DataColumnParameter paramConfirmationDate = new DataColumnParameter(defConfirmationDate, defConfirmationDate.DefaultValue);
                DataColumnParameter paramAwaitingDisbursement = new DataColumnParameter(defAwaitingDisbursement, defAwaitingDisbursement.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramConfirmedExplanation = new DataColumnParameter(defConfirmedExplanation, defConfirmedExplanation.DefaultValue);
                DataColumnParameter paramChargesBilledToClient = new DataColumnParameter(defChargesBilledToClient, defChargesBilledToClient.DefaultValue);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, defPaymentRequiredWithoutCharges.DefaultValue);
                DataColumnParameter paramIsMultiTarget = new DataColumnParameter(defIsMultiTarget, defIsMultiTarget.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
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
                paramIsMultiTarget.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pTransactionStatusID,
Int32 pClientID,
String pStudentNumber,
String pFirstName,
String pLastName,
String pAccountName,
String pAccountNumber,
String pBank,
String pChannel,
String pIPAddress,
Decimal pSchoolDiscountGiven,
Decimal pPaymentRequired,
Decimal pCharges,
Decimal pRefundAmount,
Decimal pBalance,
DateTime pCreatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Decimal pPaymentRequiredWithoutCharges,
Object pConfirmationThreshold = null,
Object pConfirmationDate = null,
Object pAwaitingDisbursement = null,
Object pUpdatedAt = null,
Object pConfirmedExplanation = null,
Object pChargesBilledToClient = null,
Object pIsMultiTarget = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTransactionStatusID = new DataColumnParameter(defTransactionStatusID, pTransactionStatusID);
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramStudentNumber = new DataColumnParameter(defStudentNumber, pStudentNumber);
                DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
                DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
                DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
                DataColumnParameter paramBank = new DataColumnParameter(defBank, pBank);
                DataColumnParameter paramChannel = new DataColumnParameter(defChannel, pChannel);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
                DataColumnParameter paramSchoolDiscountGiven = new DataColumnParameter(defSchoolDiscountGiven, pSchoolDiscountGiven);
                DataColumnParameter paramPaymentRequired = new DataColumnParameter(defPaymentRequired, pPaymentRequired);
                DataColumnParameter paramCharges = new DataColumnParameter(defCharges, pCharges);
                DataColumnParameter paramRefundAmount = new DataColumnParameter(defRefundAmount, pRefundAmount);
                DataColumnParameter paramBalance = new DataColumnParameter(defBalance, pBalance);
                DataColumnParameter paramConfirmationThreshold = new DataColumnParameter(defConfirmationThreshold, pConfirmationThreshold);
                DataColumnParameter paramConfirmationDate = new DataColumnParameter(defConfirmationDate, pConfirmationDate);
                DataColumnParameter paramAwaitingDisbursement = new DataColumnParameter(defAwaitingDisbursement, pAwaitingDisbursement);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramConfirmedExplanation = new DataColumnParameter(defConfirmedExplanation, pConfirmedExplanation);
                DataColumnParameter paramChargesBilledToClient = new DataColumnParameter(defChargesBilledToClient, pChargesBilledToClient);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges);
                DataColumnParameter paramIsMultiTarget = new DataColumnParameter(defIsMultiTarget, pIsMultiTarget);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramIsMultiTarget.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pTransactionStatusID,
Int32 pClientID,
String pStudentNumber,
String pFirstName,
String pLastName,
String pAccountName,
String pAccountNumber,
String pBank,
String pChannel,
String pIPAddress,
Decimal pSchoolDiscountGiven,
Decimal pPaymentRequired,
Decimal pCharges,
Decimal pRefundAmount,
Decimal pBalance,
DateTime pCreatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Decimal pPaymentRequiredWithoutCharges,
Object pConfirmationThreshold = null,
Object pConfirmationDate = null,
Object pAwaitingDisbursement = null,
Object pUpdatedAt = null,
Object pConfirmedExplanation = null,
Object pChargesBilledToClient = null,
Object pIsMultiTarget = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramTransactionStatusID = new DataColumnParameter(defTransactionStatusID, pTransactionStatusID);
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramStudentNumber = new DataColumnParameter(defStudentNumber, pStudentNumber);
DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
DataColumnParameter paramBank = new DataColumnParameter(defBank, pBank);
DataColumnParameter paramChannel = new DataColumnParameter(defChannel, pChannel);
DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
DataColumnParameter paramSchoolDiscountGiven = new DataColumnParameter(defSchoolDiscountGiven, pSchoolDiscountGiven);
DataColumnParameter paramPaymentRequired = new DataColumnParameter(defPaymentRequired, pPaymentRequired);
DataColumnParameter paramCharges = new DataColumnParameter(defCharges, pCharges);
DataColumnParameter paramRefundAmount = new DataColumnParameter(defRefundAmount, pRefundAmount);
DataColumnParameter paramBalance = new DataColumnParameter(defBalance, pBalance);
DataColumnParameter paramConfirmationThreshold = new DataColumnParameter(defConfirmationThreshold, pConfirmationThreshold);
DataColumnParameter paramConfirmationDate = new DataColumnParameter(defConfirmationDate, pConfirmationDate);
DataColumnParameter paramAwaitingDisbursement = new DataColumnParameter(defAwaitingDisbursement, pAwaitingDisbursement);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
DataColumnParameter paramConfirmedExplanation = new DataColumnParameter(defConfirmedExplanation, pConfirmedExplanation);
DataColumnParameter paramChargesBilledToClient = new DataColumnParameter(defChargesBilledToClient, pChargesBilledToClient);
DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges);
DataColumnParameter paramIsMultiTarget = new DataColumnParameter(defIsMultiTarget, pIsMultiTarget);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramIsMultiTarget.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pTransactionStatusID,
Int32 pClientID,
String pStudentNumber,
String pFirstName,
String pLastName,
String pAccountName,
String pAccountNumber,
String pBank,
String pChannel,
String pIPAddress,
Decimal pSchoolDiscountGiven,
Decimal pPaymentRequired,
Decimal pCharges,
Decimal pRefundAmount,
Decimal pBalance,
DateTime pCreatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Decimal pPaymentRequiredWithoutCharges,
Object pConfirmationThreshold= null,
Object pConfirmationDate= null,
Object pAwaitingDisbursement= null,
Object pUpdatedAt= null,
Object pConfirmedExplanation= null,
Object pChargesBilledToClient= null,
Object pIsMultiTarget= null){

        try{

DataColumnParameter paramTransactionStatusID = new DataColumnParameter(defTransactionStatusID, pTransactionStatusID);
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramStudentNumber = new DataColumnParameter(defStudentNumber, pStudentNumber);
DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
DataColumnParameter paramBank = new DataColumnParameter(defBank, pBank);
DataColumnParameter paramChannel = new DataColumnParameter(defChannel, pChannel);
DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
DataColumnParameter paramSchoolDiscountGiven = new DataColumnParameter(defSchoolDiscountGiven, pSchoolDiscountGiven);
DataColumnParameter paramPaymentRequired = new DataColumnParameter(defPaymentRequired, pPaymentRequired);
DataColumnParameter paramCharges = new DataColumnParameter(defCharges, pCharges);
DataColumnParameter paramRefundAmount = new DataColumnParameter(defRefundAmount, pRefundAmount);
DataColumnParameter paramBalance = new DataColumnParameter(defBalance, pBalance);
DataColumnParameter paramConfirmationThreshold = new DataColumnParameter(defConfirmationThreshold, pConfirmationThreshold);
DataColumnParameter paramConfirmationDate = new DataColumnParameter(defConfirmationDate, pConfirmationDate);
DataColumnParameter paramAwaitingDisbursement = new DataColumnParameter(defAwaitingDisbursement, pAwaitingDisbursement);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
DataColumnParameter paramConfirmedExplanation = new DataColumnParameter(defConfirmedExplanation, pConfirmedExplanation);
DataColumnParameter paramChargesBilledToClient = new DataColumnParameter(defChargesBilledToClient, pChargesBilledToClient);
DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges);
DataColumnParameter paramIsMultiTarget = new DataColumnParameter(defIsMultiTarget, pIsMultiTarget);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26}) ", TABLE_NAME,paramTransactionStatusID.GetSQLQuotedValueForAdd(),
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
paramIsMultiTarget.GetSQLQuotedValueForAdd()  ), true);


}catch (Exception){
throw; 
}
}



/// <summary> 
/// Leave a column as nothing to skip and a Nullable Column as Null to actually Null it 
/// </summary> 
/// <returns>Boolean</returns> 
/// <remarks></remarks>                            
        public static bool Update(Int64 pID  ,
Object pTransactionStatusID = null,
Object pClientID = null,
Object pStudentNumber = null,
Object pFirstName = null,
Object pLastName = null,
Object pAccountName = null,
Object pAccountNumber = null,
Object pBank = null,
Object pChannel = null,
Object pIPAddress = null,
Object pSchoolDiscountGiven = null,
Object pPaymentRequired = null,
Object pCharges = null,
Object pRefundAmount = null,
Object pBalance = null,
Object pCreatedAt = null,
Object pCreatedByID = null,
Object pUpdatedByID = null,
Object pPaymentRequiredWithoutCharges = null,
Object pConfirmationThreshold = null,
Object pConfirmationDate = null,
Object pAwaitingDisbursement = null,
Object pUpdatedAt = null,
Object pConfirmedExplanation = null,
Object pChargesBilledToClient = null,
Object pIsMultiTarget = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramTransactionStatusID = new DataColumnParameter(defTransactionStatusID, pTransactionStatusID);
 DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
 DataColumnParameter paramStudentNumber = new DataColumnParameter(defStudentNumber, pStudentNumber);
 DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
 DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
 DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
 DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
 DataColumnParameter paramBank = new DataColumnParameter(defBank, pBank);
 DataColumnParameter paramChannel = new DataColumnParameter(defChannel, pChannel);
 DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
 DataColumnParameter paramSchoolDiscountGiven = new DataColumnParameter(defSchoolDiscountGiven, pSchoolDiscountGiven);
 DataColumnParameter paramPaymentRequired = new DataColumnParameter(defPaymentRequired, pPaymentRequired);
 DataColumnParameter paramCharges = new DataColumnParameter(defCharges, pCharges);
 DataColumnParameter paramRefundAmount = new DataColumnParameter(defRefundAmount, pRefundAmount);
 DataColumnParameter paramBalance = new DataColumnParameter(defBalance, pBalance);
 DataColumnParameter paramConfirmationThreshold = new DataColumnParameter(defConfirmationThreshold, pConfirmationThreshold);
 DataColumnParameter paramConfirmationDate = new DataColumnParameter(defConfirmationDate, pConfirmationDate);
 DataColumnParameter paramAwaitingDisbursement = new DataColumnParameter(defAwaitingDisbursement, pAwaitingDisbursement);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
 DataColumnParameter paramConfirmedExplanation = new DataColumnParameter(defConfirmedExplanation, pConfirmedExplanation);
 DataColumnParameter paramChargesBilledToClient = new DataColumnParameter(defChargesBilledToClient, pChargesBilledToClient);
 DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges);
 DataColumnParameter paramIsMultiTarget = new DataColumnParameter(defIsMultiTarget, pIsMultiTarget);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [TransactionStatusID]={2},[ClientID]={3},[StudentNumber]={4},[FirstName]={5},[LastName]={6},[AccountName]={7},[AccountNumber]={8},[Bank]={9},[Channel]={10},[IPAddress]={11},[SchoolDiscountGiven]={12},[PaymentRequired]={13},[Charges]={14},[RefundAmount]={15},[Balance]={16},[ConfirmationThreshold]={17},[ConfirmationDate]={18},[AwaitingDisbursement]={19},[CreatedAt]={20},[UpdatedAt]={21},[CreatedByID]={22},[UpdatedByID]={23},[ConfirmedExplanation]={24},[ChargesBilledToClient]={25},[PaymentRequiredWithoutCharges]={26},[IsMultiTarget]={27} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramTransactionStatusID.GetSQLQuotedValueForUpdate(),
paramClientID.GetSQLQuotedValueForUpdate(),
paramStudentNumber.GetSQLQuotedValueForUpdate(),
paramFirstName.GetSQLQuotedValueForUpdate(),
paramLastName.GetSQLQuotedValueForUpdate(),
paramAccountName.GetSQLQuotedValueForUpdate(),
paramAccountNumber.GetSQLQuotedValueForUpdate(),
paramBank.GetSQLQuotedValueForUpdate(),
paramChannel.GetSQLQuotedValueForUpdate(),
paramIPAddress.GetSQLQuotedValueForUpdate(),
paramSchoolDiscountGiven.GetSQLQuotedValueForUpdate(),
paramPaymentRequired.GetSQLQuotedValueForUpdate(),
paramCharges.GetSQLQuotedValueForUpdate(),
paramRefundAmount.GetSQLQuotedValueForUpdate(),
paramBalance.GetSQLQuotedValueForUpdate(),
paramConfirmationThreshold.GetSQLQuotedValueForUpdate(),
paramConfirmationDate.GetSQLQuotedValueForUpdate(),
paramAwaitingDisbursement.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedByID.GetSQLQuotedValueForUpdate(),
paramUpdatedByID.GetSQLQuotedValueForUpdate(),
paramConfirmedExplanation.GetSQLQuotedValueForUpdate(),
paramChargesBilledToClient.GetSQLQuotedValueForUpdate(),
paramPaymentRequiredWithoutCharges.GetSQLQuotedValueForUpdate(),
paramIsMultiTarget.GetSQLQuotedValueForUpdate()  ), true);


                       // Nothing means ignore but null means clear
                               return true;

}catch (Exception){
throw; 
}
}



                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
