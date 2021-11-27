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

    public class T___Payout : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Payout()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defClientID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaidInAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaidInAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaidInCharges = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaidInCharges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayoutAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PayoutAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayoutCharge = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PayoutCharge.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Balance.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTransactionStartDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TransactionStartDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTransactionEndDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TransactionEndDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAwaitingPayout = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AwaitingPayout.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSynced = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Synced.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BankID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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
       public const string Payout__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CreatedByID], [UpdatedByID], [ClientID], [PaidInAmount], [PaidInCharges], [PayoutAmount], [PayoutCharge], [Balance], [TransactionStartDate], [TransactionEndDate], [AwaitingPayout], [Synced], [CreatedAt], [UpdatedAt], [BankID], [AccountName], [AccountNumber] FROM Payout";
       public const string Payout__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CreatedByID], [UpdatedByID], [ClientID], [PaidInAmount], [PaidInCharges], [PayoutAmount], [PayoutCharge], [Balance], [TransactionStartDate], [TransactionEndDate], [AwaitingPayout], [Synced], [CreatedAt], [UpdatedAt], [BankID], [AccountName], [AccountNumber] FROM Payout";


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


       public Int32 ClientID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ClientID.ToString()]);
           }
       }


       public Decimal PaidInAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PaidInAmount.ToString()]);
           }
       }


       public Decimal PaidInCharges {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PaidInCharges.ToString()]);
           }
       }


       public Decimal PayoutAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PayoutAmount.ToString()]);
           }
       }


       public Decimal PayoutCharge {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PayoutCharge.ToString()]);
           }
       }


       public Decimal Balance {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Balance.ToString()]);
           }
       }


       public NullableDateTime TransactionStartDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.TransactionStartDate.ToString()]);
           }
       }


       public NullableDateTime TransactionEndDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.TransactionEndDate.ToString()]);
           }
       }


       public Boolean AwaitingPayout {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.AwaitingPayout.ToString()]);
           }
       }


       public Boolean Synced {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.Synced.ToString()]);
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


       public Int32 BankID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BankID.ToString()]);
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
                                                      
        public static T___Payout GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Payout GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Payout(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Payout GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Payout__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCreatedByID,
Int32 pUpdatedByID,
Int32 pClientID,
Int32 pBankID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramPaidInAmount = new DataColumnParameter(defPaidInAmount, defPaidInAmount.DefaultValue);
                DataColumnParameter paramPaidInCharges = new DataColumnParameter(defPaidInCharges, defPaidInCharges.DefaultValue);
                DataColumnParameter paramPayoutAmount = new DataColumnParameter(defPayoutAmount, defPayoutAmount.DefaultValue);
                DataColumnParameter paramPayoutCharge = new DataColumnParameter(defPayoutCharge, defPayoutCharge.DefaultValue);
                DataColumnParameter paramBalance = new DataColumnParameter(defBalance, defBalance.DefaultValue);
                DataColumnParameter paramTransactionStartDate = new DataColumnParameter(defTransactionStartDate, defTransactionStartDate.DefaultValue);
                DataColumnParameter paramTransactionEndDate = new DataColumnParameter(defTransactionEndDate, defTransactionEndDate.DefaultValue);
                DataColumnParameter paramAwaitingPayout = new DataColumnParameter(defAwaitingPayout, defAwaitingPayout.DefaultValue);
                DataColumnParameter paramSynced = new DataColumnParameter(defSynced, defSynced.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, defAccountName.DefaultValue);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
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
                paramAccountNumber.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pCreatedByID,
Int32 pClientID,
Decimal pPaidInAmount,
Decimal pPaidInCharges,
Decimal pPayoutAmount,
Decimal pPayoutCharge,
Decimal pBalance,
DateTime pTransactionStartDate,
DateTime pTransactionEndDate,
DateTime pCreatedAt,
Int32 pBankID,
String pAccountName,
String pAccountNumber,
Object pUpdatedByID = null,
Object pAwaitingPayout = null,
Object pSynced = null,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramPaidInAmount = new DataColumnParameter(defPaidInAmount, pPaidInAmount);
                DataColumnParameter paramPaidInCharges = new DataColumnParameter(defPaidInCharges, pPaidInCharges);
                DataColumnParameter paramPayoutAmount = new DataColumnParameter(defPayoutAmount, pPayoutAmount);
                DataColumnParameter paramPayoutCharge = new DataColumnParameter(defPayoutCharge, pPayoutCharge);
                DataColumnParameter paramBalance = new DataColumnParameter(defBalance, pBalance);
                DataColumnParameter paramTransactionStartDate = new DataColumnParameter(defTransactionStartDate, pTransactionStartDate);
                DataColumnParameter paramTransactionEndDate = new DataColumnParameter(defTransactionEndDate, pTransactionEndDate);
                DataColumnParameter paramAwaitingPayout = new DataColumnParameter(defAwaitingPayout, pAwaitingPayout);
                DataColumnParameter paramSynced = new DataColumnParameter(defSynced, pSynced);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramAccountNumber.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pCreatedByID,
Int32 pClientID,
Decimal pPaidInAmount,
Decimal pPaidInCharges,
Decimal pPayoutAmount,
Decimal pPayoutCharge,
Decimal pBalance,
DateTime pTransactionStartDate,
DateTime pTransactionEndDate,
DateTime pCreatedAt,
Int32 pBankID,
String pAccountName,
String pAccountNumber,
Object pUpdatedByID = null,
Object pAwaitingPayout = null,
Object pSynced = null,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramPaidInAmount = new DataColumnParameter(defPaidInAmount, pPaidInAmount);
DataColumnParameter paramPaidInCharges = new DataColumnParameter(defPaidInCharges, pPaidInCharges);
DataColumnParameter paramPayoutAmount = new DataColumnParameter(defPayoutAmount, pPayoutAmount);
DataColumnParameter paramPayoutCharge = new DataColumnParameter(defPayoutCharge, pPayoutCharge);
DataColumnParameter paramBalance = new DataColumnParameter(defBalance, pBalance);
DataColumnParameter paramTransactionStartDate = new DataColumnParameter(defTransactionStartDate, pTransactionStartDate);
DataColumnParameter paramTransactionEndDate = new DataColumnParameter(defTransactionEndDate, pTransactionEndDate);
DataColumnParameter paramAwaitingPayout = new DataColumnParameter(defAwaitingPayout, pAwaitingPayout);
DataColumnParameter paramSynced = new DataColumnParameter(defSynced, pSynced);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramAccountNumber.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pCreatedByID,
Int32 pClientID,
Decimal pPaidInAmount,
Decimal pPaidInCharges,
Decimal pPayoutAmount,
Decimal pPayoutCharge,
Decimal pBalance,
DateTime pTransactionStartDate,
DateTime pTransactionEndDate,
DateTime pCreatedAt,
Int32 pBankID,
String pAccountName,
String pAccountNumber,
Object pUpdatedByID= null,
Object pAwaitingPayout= null,
Object pSynced= null,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramPaidInAmount = new DataColumnParameter(defPaidInAmount, pPaidInAmount);
DataColumnParameter paramPaidInCharges = new DataColumnParameter(defPaidInCharges, pPaidInCharges);
DataColumnParameter paramPayoutAmount = new DataColumnParameter(defPayoutAmount, pPayoutAmount);
DataColumnParameter paramPayoutCharge = new DataColumnParameter(defPayoutCharge, pPayoutCharge);
DataColumnParameter paramBalance = new DataColumnParameter(defBalance, pBalance);
DataColumnParameter paramTransactionStartDate = new DataColumnParameter(defTransactionStartDate, pTransactionStartDate);
DataColumnParameter paramTransactionEndDate = new DataColumnParameter(defTransactionEndDate, pTransactionEndDate);
DataColumnParameter paramAwaitingPayout = new DataColumnParameter(defAwaitingPayout, pAwaitingPayout);
DataColumnParameter paramSynced = new DataColumnParameter(defSynced, pSynced);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) ", TABLE_NAME,paramCreatedByID.GetSQLQuotedValueForAdd(),
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
paramAccountNumber.GetSQLQuotedValueForAdd()  ), true);


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
Object pCreatedByID = null,
Object pClientID = null,
Object pPaidInAmount = null,
Object pPaidInCharges = null,
Object pPayoutAmount = null,
Object pPayoutCharge = null,
Object pBalance = null,
Object pTransactionStartDate = null,
Object pTransactionEndDate = null,
Object pCreatedAt = null,
Object pBankID = null,
Object pAccountName = null,
Object pAccountNumber = null,
Object pUpdatedByID = null,
Object pAwaitingPayout = null,
Object pSynced = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
 DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
 DataColumnParameter paramPaidInAmount = new DataColumnParameter(defPaidInAmount, pPaidInAmount);
 DataColumnParameter paramPaidInCharges = new DataColumnParameter(defPaidInCharges, pPaidInCharges);
 DataColumnParameter paramPayoutAmount = new DataColumnParameter(defPayoutAmount, pPayoutAmount);
 DataColumnParameter paramPayoutCharge = new DataColumnParameter(defPayoutCharge, pPayoutCharge);
 DataColumnParameter paramBalance = new DataColumnParameter(defBalance, pBalance);
 DataColumnParameter paramTransactionStartDate = new DataColumnParameter(defTransactionStartDate, pTransactionStartDate);
 DataColumnParameter paramTransactionEndDate = new DataColumnParameter(defTransactionEndDate, pTransactionEndDate);
 DataColumnParameter paramAwaitingPayout = new DataColumnParameter(defAwaitingPayout, pAwaitingPayout);
 DataColumnParameter paramSynced = new DataColumnParameter(defSynced, pSynced);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
 DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
 DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [CreatedByID]={2},[UpdatedByID]={3},[ClientID]={4},[PaidInAmount]={5},[PaidInCharges]={6},[PayoutAmount]={7},[PayoutCharge]={8},[Balance]={9},[TransactionStartDate]={10},[TransactionEndDate]={11},[AwaitingPayout]={12},[Synced]={13},[CreatedAt]={14},[UpdatedAt]={15},[BankID]={16},[AccountName]={17},[AccountNumber]={18} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramCreatedByID.GetSQLQuotedValueForUpdate(),
paramUpdatedByID.GetSQLQuotedValueForUpdate(),
paramClientID.GetSQLQuotedValueForUpdate(),
paramPaidInAmount.GetSQLQuotedValueForUpdate(),
paramPaidInCharges.GetSQLQuotedValueForUpdate(),
paramPayoutAmount.GetSQLQuotedValueForUpdate(),
paramPayoutCharge.GetSQLQuotedValueForUpdate(),
paramBalance.GetSQLQuotedValueForUpdate(),
paramTransactionStartDate.GetSQLQuotedValueForUpdate(),
paramTransactionEndDate.GetSQLQuotedValueForUpdate(),
paramAwaitingPayout.GetSQLQuotedValueForUpdate(),
paramSynced.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramBankID.GetSQLQuotedValueForUpdate(),
paramAccountName.GetSQLQuotedValueForUpdate(),
paramAccountNumber.GetSQLQuotedValueForUpdate()  ), true);


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
