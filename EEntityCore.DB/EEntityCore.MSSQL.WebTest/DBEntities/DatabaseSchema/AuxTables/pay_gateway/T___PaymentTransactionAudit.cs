using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using EEntityCore.DB.Modules;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.pay_gateway                  
{                  

    public class T___PaymentTransactionAudit : Sample__Table, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___PaymentTransactionAudit()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTransactionStatusID = new DataColumnDefinition(TableColumnNames.TransactionStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaymentTransactionID = new DataColumnDefinition(TableColumnNames.PaymentTransactionID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountName = new DataColumnDefinition(TableColumnNames.AccountName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBank = new DataColumnDefinition(TableColumnNames.Bank.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequired = new DataColumnDefinition(TableColumnNames.PaymentRequired.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharges = new DataColumnDefinition(TableColumnNames.Charges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequiredWithoutCharges = new DataColumnDefinition(TableColumnNames.PaymentRequiredWithoutCharges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRefundAmount = new DataColumnDefinition(TableColumnNames.RefundAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalance = new DataColumnDefinition(TableColumnNames.Balance.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


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

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public Int32 TransactionStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TransactionStatusID.ToString()]);
           }
       }


       public Int32 PaymentTransactionID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PaymentTransactionID.ToString()]);
           }
       }


       public String AccountName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountName.ToString()]);
           }
       }


       public String Bank {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Bank.ToString()]);
           }
       }


       public String IPAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IPAddress.ToString()]);
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


       public Decimal PaymentRequiredWithoutCharges {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PaymentRequiredWithoutCharges.ToString()]);
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


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public Int32 CreatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___PaymentTransactionAudit GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___PaymentTransactionAudit(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___PaymentTransactionAudit GetFullTable()                  
        {                  
            return new T___PaymentTransactionAudit(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___PaymentTransactionAudit GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___PaymentTransactionAudit(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___PaymentTransactionAudit GetRowWhereID(int pID)                  
        {                  
            return new T___PaymentTransactionAudit(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___PaymentTransactionAudit pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
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
                  
        private bool IsAnyRowEqual(T___PaymentTransactionAudit pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
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
        public T___PaymentTransactionAudit GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___PaymentTransactionAudit(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___PaymentTransactionAudit(drst);                  
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
        public T___PaymentTransactionAudit getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___PaymentTransactionAudit(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___PaymentTransactionAudit(drst);                  
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
                if (!this.IsTargettedRowValid)                  
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
            return PaymentTransactionAudit__NO__BINARY___SQL_FILL_QUERY;                  
        }                  
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pTransactionStatusID,
Int32 pPaymentTransactionID,
Int32 pCreatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTransactionStatusID = new DataColumnParameter(defTransactionStatusID, pTransactionStatusID);
                DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, defAccountName.DefaultValue);
                DataColumnParameter paramBank = new DataColumnParameter(defBank, defBank.DefaultValue);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, defIPAddress.DefaultValue);
                DataColumnParameter paramPaymentRequired = new DataColumnParameter(defPaymentRequired, defPaymentRequired.DefaultValue);
                DataColumnParameter paramCharges = new DataColumnParameter(defCharges, defCharges.DefaultValue);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, defPaymentRequiredWithoutCharges.DefaultValue);
                DataColumnParameter paramRefundAmount = new DataColumnParameter(defRefundAmount, defRefundAmount.DefaultValue);
                DataColumnParameter paramBalance = new DataColumnParameter(defBalance, defBalance.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[PaymentTransactionID],[AccountName],[Bank],[IPAddress],[PaymentRequired],[Charges],[PaymentRequiredWithoutCharges],[RefundAmount],[Balance],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramTransactionStatusID.getSQLQuotedValueForAdd(),
                paramPaymentTransactionID.getSQLQuotedValueForAdd(),
                paramAccountName.getSQLQuotedValueForAdd(),
                paramBank.getSQLQuotedValueForAdd(),
                paramIPAddress.getSQLQuotedValueForAdd(),
                paramPaymentRequired.getSQLQuotedValueForAdd(),
                paramCharges.getSQLQuotedValueForAdd(),
                paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd(),
                paramRefundAmount.getSQLQuotedValueForAdd(),
                paramBalance.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
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
