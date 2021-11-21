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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___Payment : Sample__Table, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___Payment()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAmountCharged = new DataColumnDefinition(TableColumnNames.AmountCharged.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDiscountGiven = new DataColumnDefinition(TableColumnNames.DiscountGiven.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDiscountRateApplied = new DataColumnDefinition(TableColumnNames.DiscountRateApplied.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentChannelID = new DataColumnDefinition(TableColumnNames.PaymentChannelID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaymentEntryModeID = new DataColumnDefinition(TableColumnNames.PaymentEntryModeID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTransactionFileName = new DataColumnDefinition(TableColumnNames.TransactionFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIpAddress = new DataColumnDefinition(TableColumnNames.IpAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotal = new DataColumnDefinition(TableColumnNames.Total.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defAmountCharged.ColumnName, defAmountCharged); 
          ColumnDefns.Add(defDiscountGiven.ColumnName, defDiscountGiven); 
          ColumnDefns.Add(defDiscountRateApplied.ColumnName, defDiscountRateApplied); 
          ColumnDefns.Add(defPaymentChannelID.ColumnName, defPaymentChannelID); 
          ColumnDefns.Add(defPaymentEntryModeID.ColumnName, defPaymentEntryModeID); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defTransactionFileName.ColumnName, defTransactionFileName); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
          ColumnDefns.Add(defTotal.ColumnName, defTotal); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "academic.Term"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_PaymentChannelID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "accounting.PaymentChannel"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_PaymentEntryModeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "accounting.PaymentEntryMode"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "hr.Client"                  
                            ));                  

          }


                  
       public T___Payment() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Payment(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payment(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Payment(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "accounting.Payment";
       public const string Payment__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TermID], [AmountCharged], [DiscountGiven], [DiscountRateApplied], [PaymentChannelID], [PaymentEntryModeID], [Comments], [TransactionFileName], [CreatedAt], [CreatedByID], [IpAddress], [Total], [ClientID] FROM Payment";
       public const string Payment__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TermID], [AmountCharged], [DiscountGiven], [DiscountRateApplied], [PaymentChannelID], [PaymentEntryModeID], [Comments], [TransactionFileName], [CreatedAt], [CreatedByID], [IpAddress], [Total], [ClientID] FROM Payment";


       public enum TableColumnNames
       {

           ID,
           TermID,
           AmountCharged,
           DiscountGiven,
           DiscountRateApplied,
           PaymentChannelID,
           PaymentEntryModeID,
           Comments,
           TransactionFileName,
           CreatedAt,
           CreatedByID,
           IpAddress,
           Total,
           ClientID
       } 



       public enum TableConstraints{

           pk_accounting_Payment, 
           fk_accounting_Payment_CreatedByID, 
           fk_accounting_Payment_TermID, 
           fk_accounting_Payment_PaymentChannelID, 
           fk_accounting_Payment_PaymentEntryModeID, 
           fk_accounting_Payment_ClientID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defAmountCharged;
       public static readonly DataColumnDefinition defDiscountGiven;
       public static readonly DataColumnDefinition defDiscountRateApplied;
       public static readonly DataColumnDefinition defPaymentChannelID;
       public static readonly DataColumnDefinition defPaymentEntryModeID;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defTransactionFileName;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defIpAddress;
       public static readonly DataColumnDefinition defTotal;
       public static readonly DataColumnDefinition defClientID;

       public Int32 TermID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TermID.ToString()]);
           }
       }


       public Decimal AmountCharged {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.AmountCharged.ToString()]);
           }
       }


       public Decimal DiscountGiven {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.DiscountGiven.ToString()]);
           }
       }


       public Decimal DiscountRateApplied {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.DiscountRateApplied.ToString()]);
           }
       }


       public Int32 PaymentChannelID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PaymentChannelID.ToString()]);
           }
       }


       public Int32 PaymentEntryModeID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PaymentEntryModeID.ToString()]);
           }
       }


       public String Comments {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Comments.ToString()]);
           }
       }


       public String TransactionFileName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.TransactionFileName.ToString()]);
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


       public String IpAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IpAddress.ToString()]);
           }
       }


       public Decimal Total {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Total.ToString()]);
           }
       }


       public Int32 ClientID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ClientID.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___Payment GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___Payment(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___Payment GetFullTable()                  
        {                  
            return new T___Payment(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___Payment GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___Payment(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___Payment GetRowWhereID(int pID)                  
        {                  
            return new T___Payment(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___Payment pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___Payment pRow, params DataColumnParameter[] pParams)                  
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
        public T___Payment GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___Payment(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Payment(drst);                  
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
        public T___Payment getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___Payment(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Payment(drst);                  
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
            return Payment__NO__BINARY___SQL_FILL_QUERY;                  
        }                  
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pTermID,
Int32 pPaymentChannelID,
Int32 pPaymentEntryModeID,
Int32 pCreatedByID,
Int32 pClientID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
                DataColumnParameter paramPaymentChannelID = new DataColumnParameter(defPaymentChannelID, pPaymentChannelID);
                DataColumnParameter paramPaymentEntryModeID = new DataColumnParameter(defPaymentEntryModeID, pPaymentEntryModeID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramAmountCharged = new DataColumnParameter(defAmountCharged, defAmountCharged.DefaultValue);
                DataColumnParameter paramDiscountGiven = new DataColumnParameter(defDiscountGiven, defDiscountGiven.DefaultValue);
                DataColumnParameter paramDiscountRateApplied = new DataColumnParameter(defDiscountRateApplied, defDiscountRateApplied.DefaultValue);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, defComments.DefaultValue);
                DataColumnParameter paramTransactionFileName = new DataColumnParameter(defTransactionFileName, defTransactionFileName.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, defIpAddress.DefaultValue);
                DataColumnParameter paramTotal = new DataColumnParameter(defTotal, defTotal.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramTermID.getSQLQuotedValueForAdd(),
                paramAmountCharged.getSQLQuotedValueForAdd(),
                paramDiscountGiven.getSQLQuotedValueForAdd(),
                paramDiscountRateApplied.getSQLQuotedValueForAdd(),
                paramPaymentChannelID.getSQLQuotedValueForAdd(),
                paramPaymentEntryModeID.getSQLQuotedValueForAdd(),
                paramComments.getSQLQuotedValueForAdd(),
                paramTransactionFileName.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd(),
                paramIpAddress.getSQLQuotedValueForAdd(),
                paramTotal.getSQLQuotedValueForAdd(),
                paramClientID.getSQLQuotedValueForAdd()  ), true);




                  
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
