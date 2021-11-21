using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.pay_gateway                  
{                  

    public class T___PaymentTransaction : Sample__Table, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___PaymentTransaction()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTransactionStatusID = new DataColumnDefinition(TableColumnNames.TransactionStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStudentNumber = new DataColumnDefinition(TableColumnNames.StudentNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountName = new DataColumnDefinition(TableColumnNames.AccountName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBank = new DataColumnDefinition(TableColumnNames.Bank.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChannel = new DataColumnDefinition(TableColumnNames.Channel.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSchoolDiscountGiven = new DataColumnDefinition(TableColumnNames.SchoolDiscountGiven.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequired = new DataColumnDefinition(TableColumnNames.PaymentRequired.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharges = new DataColumnDefinition(TableColumnNames.Charges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRefundAmount = new DataColumnDefinition(TableColumnNames.RefundAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(TableColumnNames.Balance.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defConfirmationThreshold = new DataColumnDefinition(TableColumnNames.ConfirmationThreshold.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defConfirmationDate = new DataColumnDefinition(TableColumnNames.ConfirmationDate.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAwaitingDisbursement = new DataColumnDefinition(TableColumnNames.AwaitingDisbursement.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defConfirmedExplanation = new DataColumnDefinition(TableColumnNames.ConfirmedExplanation.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChargesBilledToClient = new DataColumnDefinition(TableColumnNames.ChargesBilledToClient.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequiredWithoutCharges = new DataColumnDefinition(TableColumnNames.PaymentRequiredWithoutCharges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsMultiTarget = new DataColumnDefinition(TableColumnNames.IsMultiTarget.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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


                  
        public T___PaymentTransaction() : base(TABLE_NAME)                  
        {                  
        }                  


                  
                  
        #region Full Access                  
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                    
                  
        /// <summary>                                    
        /// FULL ACCESS. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="TableName"></param>                                    
        /// <remarks></remarks>                  
        public T___PaymentTransaction(All__DBs DBConn, string TableName) : base(DBConn, TableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                    
        /// <remarks></remarks>                  
        public T___PaymentTransaction(All__DBs DBConn, string pTableName, long pTargettedRowID) : base(DBConn, pTableName, pTargettedRowID: pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public T___PaymentTransaction(All__DBs pDBConn, string pTableName, string pSQL) : base(pDBConn, pTableName, pSQL)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public T___PaymentTransaction(All__DBs pDBConn, string pTableName, string pSQL, long pTargettedRowID) : base(pDBConn, pTableName, pSQL, pTargettedRowID)                  
        {                  
        }                  
                  
        #endregion                  
                  
                  
        #region Partial Access                  
                  
        // Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work                                    
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public T___PaymentTransaction(DataRowCollection pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public T___PaymentTransaction(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="FullTable"></param>                                    
        /// <param name="TargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public T___PaymentTransaction(DataTable FullTable, int TargettedRowID, string TableName, All__DBs DBConn) : base(FullTable, TargettedRowID, TableName, DBConn)                  
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
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public T___PaymentTransaction(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public T___PaymentTransaction(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public T___PaymentTransaction(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName) : base(pTableRows, pTargettedRowID, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public T___PaymentTransaction(DataTable FullTable, string pTableName) : base(FullTable, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public T___PaymentTransaction(DataTable FullTable, string pTableName, long pTargettedRowID) : base(FullTable, pTableName, pTargettedRowID)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public T___PaymentTransaction(DataRowCollection pDataRows, string pTableName) : base(pDataRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public T___PaymentTransaction(IEnumerable<DataRow> pTableRows, string pTableName) : base(pTableRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access. Should always target this passed in                                    
        /// </summary>                                    
        /// <param name="pTargettedRow"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public T___PaymentTransaction(DataRow pTargettedRow, string pTableName) : base(pTargettedRow, pTableName)                  
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

        private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

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
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TransactionStatusID.ToString()]);
           }
       }


       public Int32 ClientID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ClientID.ToString()]);
           }
       }


       public String StudentNumber {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.StudentNumber.ToString()]);
           }
       }


       public String FirstName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FirstName.ToString()]);
           }
       }


       public String LastName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.LastName.ToString()]);
           }
       }


       public String AccountName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountName.ToString()]);
           }
       }


       public String AccountNumber {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountNumber.ToString()]);
           }
       }


       public String Bank {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Bank.ToString()]);
           }
       }


       public String Channel {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Channel.ToString()]);
           }
       }


       public String IPAddress {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IPAddress.ToString()]);
           }
       }


       public Decimal SchoolDiscountGiven {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.SchoolDiscountGiven.ToString()]);
           }
       }


       public Decimal PaymentRequired {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PaymentRequired.ToString()]);
           }
       }


       public Decimal Charges {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Charges.ToString()]);
           }
       }


       public Decimal RefundAmount {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.RefundAmount.ToString()]);
           }
       }


       public Decimal Balance {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Balance.ToString()]);
           }
       }


       public Decimal ConfirmationThreshold {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.ConfirmationThreshold.ToString()]);
           }
       }


       public NullableDateTime ConfirmationDate {
           get{ 
               if (!this.isValidRow) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.ConfirmationDate.ToString()]);
           }
       }


       public Boolean AwaitingDisbursement {
           get{ 
               if (!this.isValidRow) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.AwaitingDisbursement.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.isValidRow) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public NullableDateTime UpdatedAt {
           get{ 
               if (!this.isValidRow) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]);
           }
       }


       public Int32 CreatedByID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


       public Int32 UpdatedByID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UpdatedByID.ToString()]);
           }
       }


       public String ConfirmedExplanation {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ConfirmedExplanation.ToString()]);
           }
       }


       public Boolean ChargesBilledToClient {
           get{ 
               if (!this.isValidRow) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.ChargesBilledToClient.ToString()]);
           }
       }


       public Decimal PaymentRequiredWithoutCharges {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PaymentRequiredWithoutCharges.ToString()]);
           }
       }


       public Boolean IsMultiTarget {
           get{ 
               if (!this.isValidRow) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsMultiTarget.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___PaymentTransaction getFirstRow()                  
        {                  
            if (this.hasRows())                  
                return new T___PaymentTransaction(this.AllRows.ToArray()[0]);                  
            return null;                  
        }                  
                  
        public static T___PaymentTransaction getFullTable()                  
        {                  
            return new T___PaymentTransaction(DatabaseInit.DBConnectInterface.GetDBConn(), TABLE_NAME);                  
        }                  
                  
        public static T___PaymentTransaction getRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___PaymentTransaction(DBConnectInterface.GetDBConn(), TABLE_NAME, string.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, (object)pID)).getFirstRow();                  
        }                  
                  
        public T___PaymentTransaction getRowWhereID(int pID)                  
        {                  
            return new T___PaymentTransaction(this.RawTable, TABLE_NAME, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___PaymentTransaction pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.hasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (!pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return false;                  
                }                  
                  
                return true;                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  
                  
        private bool IsAnyRowEqual(T___PaymentTransaction pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.hasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return true;                  
                }                  
                  
                return false;                  
            }                  
            catch (Exception )                  
            {                  
                return false;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___PaymentTransaction getAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___PaymentTransaction(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___PaymentTransaction(drst.CopyToDataTable(), TABLE_NAME);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM                errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___PaymentTransaction getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___PaymentTransaction(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___PaymentTransaction(drst.CopyToDataTable(), TABLE_NAME);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        public Dictionary<string, DataColumnDefinition> getDefinitions()                  
        {                  
            return ColumnDefns;                  
        }                  
                  
        private bool RowEqual(string pColumnName, object pColumnValue)                  
        {                  
            try                  
            {                  
                if (!this.isTargettedRowValid())                  
                    return false;                  
                switch (DataColumnDefinition.getTypeAllowed(ColumnDefns[pColumnName].DataType))                  
                {                  
                    case var @case when @case == DataColumnDefinition.AllowedDataTypes.Bool:                  
                        {                  
                            return EBoolean.valueOf(this.TargettedRow[pColumnName]) == EBoolean.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case1 when case1 == DataColumnDefinition.AllowedDataTypes.Blob:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    case var case2 when case2 == DataColumnDefinition.AllowedDataTypes.DateTime:                  
                        {                  
                            return EDateTime.EqualsDateWithoutTime(new NullableDateTime(this.TargettedRow[pColumnName]).DateTimeValue, new NullableDateTime(pColumnValue).DateTimeValue);                  
                        }                  
                  
                    case var case3 when case3 == DataColumnDefinition.AllowedDataTypes.Decimal:                  
                        {                  
                            return EDouble.valueOf(this.TargettedRow[pColumnName]) == EDouble.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case4 when case4 == DataColumnDefinition.AllowedDataTypes.Int:                  
                        {                  
                            return EInt.valueOf(this.TargettedRow[pColumnName]) == EInt.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case5 when case5 == DataColumnDefinition.AllowedDataTypes.Long:                  
                        {                  
                            return ELong.valueOf(this.TargettedRow[pColumnName]) == ELong.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case6 when case6 == DataColumnDefinition.AllowedDataTypes.String:                  
                        {                  
                            return EStrings.equalsIgnoreCase(EStrings.valueOf(this.TargettedRow[pColumnName]), EStrings.valueOf(pColumnValue));                  
                        }                  
                  
                    case var case7 when case7 == DataColumnDefinition.AllowedDataTypes.TimeSpan:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    default:                  
                        {                  
                            // REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()                                                       
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                }                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  

                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> getForeignKeys()                  
        {                  
            return ForeignKeys;                  
        }                  
                  
        public string getTableName()                  
        {                  
            return TABLE_NAME;                  
        }                  

                  
        public virtual string getFillSQL(){                
            return PaymentTransaction__NO__BINARY___SQL_FILL_QUERY;                  
        }                  
                  
                  
                  
#endregion                  
                  
                  




        public static int addNewDefault(Int32 pTransactionStatusID,
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
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramTransactionStatusID.getSQLQuotedValueForAdd(),
                paramClientID.getSQLQuotedValueForAdd(),
                paramStudentNumber.getSQLQuotedValueForAdd(),
                paramFirstName.getSQLQuotedValueForAdd(),
                paramLastName.getSQLQuotedValueForAdd(),
                paramAccountName.getSQLQuotedValueForAdd(),
                paramAccountNumber.getSQLQuotedValueForAdd(),
                paramBank.getSQLQuotedValueForAdd(),
                paramChannel.getSQLQuotedValueForAdd(),
                paramIPAddress.getSQLQuotedValueForAdd(),
                paramSchoolDiscountGiven.getSQLQuotedValueForAdd(),
                paramPaymentRequired.getSQLQuotedValueForAdd(),
                paramCharges.getSQLQuotedValueForAdd(),
                paramRefundAmount.getSQLQuotedValueForAdd(),
                paramBalance.getSQLQuotedValueForAdd(),
                paramConfirmationThreshold.getSQLQuotedValueForAdd(),
                paramConfirmationDate.getSQLQuotedValueForAdd(),
                paramAwaitingDisbursement.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd(),
                paramUpdatedByID.getSQLQuotedValueForAdd(),
                paramConfirmedExplanation.getSQLQuotedValueForAdd(),
                paramChargesBilledToClient.getSQLQuotedValueForAdd(),
                paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd(),
                paramIsMultiTarget.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   




        public static bool DeleteItemRow(long pID)                  
        {                  
            try                  
            {                  
                return DBConnectInterface.GetDBConn().DbExec(string.Format("DELETE FROM {0} WHERE ID={1} ", TABLE_NAME, pID));                  
            }                  
            catch (Exception)                  
            {                  
                throw;                  
            }                  
        }                  


   }


}
