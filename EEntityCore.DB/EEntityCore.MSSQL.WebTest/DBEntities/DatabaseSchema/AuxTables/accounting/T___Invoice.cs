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

    public class T___Invoice : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___Invoice()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBillDefinition = new DataColumnDefinition(TableColumnNames.BillDefinition.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillDescription = new DataColumnDefinition(TableColumnNames.BillDescription.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillAmount = new DataColumnDefinition(TableColumnNames.BillAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotal = new DataColumnDefinition(TableColumnNames.Total.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCanBeDeleted = new DataColumnDefinition(TableColumnNames.CanBeDeleted.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defQuantity = new DataColumnDefinition(TableColumnNames.Quantity.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIpAddress = new DataColumnDefinition(TableColumnNames.IpAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defOriginalBillID = new DataColumnDefinition(TableColumnNames.OriginalBillID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaymentTransactionID = new DataColumnDefinition(TableColumnNames.PaymentTransactionID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defBillDefinition.ColumnName, defBillDefinition); 
          ColumnDefns.Add(defBillDescription.ColumnName, defBillDescription); 
          ColumnDefns.Add(defBillAmount.ColumnName, defBillAmount); 
          ColumnDefns.Add(defTotal.ColumnName, defTotal); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defCanBeDeleted.ColumnName, defCanBeDeleted); 
          ColumnDefns.Add(defQuantity.ColumnName, defQuantity); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defOriginalBillID.ColumnName, defOriginalBillID); 
          ColumnDefns.Add(defPaymentTransactionID.ColumnName, defPaymentTransactionID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_PaymentTransactionID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "pay_gateway.PaymentTransaction"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_OriginalBillID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "accounting.Bill"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "academic.Term"                  
                            ));                  

          }


                  
       public T___Invoice() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Invoice(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Invoice(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Invoice(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "accounting.Invoice";
       public const string Invoice__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [BillDefinition], [BillDescription], [BillAmount], [Total], [CreatedAt], [CreatedByID], [CanBeDeleted], [Quantity], [IpAddress], [TermID], [OriginalBillID], [PaymentTransactionID] FROM Invoice";
       public const string Invoice__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [BillDefinition], [BillDescription], [BillAmount], [Total], [CreatedAt], [CreatedByID], [CanBeDeleted], [Quantity], [IpAddress], [TermID], [OriginalBillID], [PaymentTransactionID] FROM Invoice";


       public enum TableColumnNames
       {

           ID,
           ClientID,
           BillDefinition,
           BillDescription,
           BillAmount,
           Total,
           CreatedAt,
           CreatedByID,
           CanBeDeleted,
           Quantity,
           IpAddress,
           TermID,
           OriginalBillID,
           PaymentTransactionID
       } 



       public enum TableConstraints{

           pk_accounting_Invoice, 
           fk_accounting_Invoice_PaymentTransactionID, 
           fk_accounting_Invoice_OriginalBillID, 
           fk_accounting_Invoice_ClientID, 
           fk_accounting_Invoice_CreatedByID, 
           fk_accounting_Invoice_TermID, 
           uq_accounting_Invoice_PaymentTransactionID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defBillDefinition;
       public static readonly DataColumnDefinition defBillDescription;
       public static readonly DataColumnDefinition defBillAmount;
       public static readonly DataColumnDefinition defTotal;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defCanBeDeleted;
       public static readonly DataColumnDefinition defQuantity;
       public static readonly DataColumnDefinition defIpAddress;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defOriginalBillID;
       public static readonly DataColumnDefinition defPaymentTransactionID;

       public Int32 ClientID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ClientID.ToString()]);
           }
       }


       public String BillDefinition {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BillDefinition.ToString()]);
           }
       }


       public String BillDescription {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BillDescription.ToString()]);
           }
       }


       public Decimal BillAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.BillAmount.ToString()]);
           }
       }


       public Decimal Total {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Total.ToString()]);
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


       public Boolean CanBeDeleted {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.CanBeDeleted.ToString()]);
           }
       }


       public Int32 Quantity {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.Quantity.ToString()]);
           }
       }


       public String IpAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IpAddress.ToString()]);
           }
       }


       public Int32 TermID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TermID.ToString()]);
           }
       }


       public Int32 OriginalBillID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.OriginalBillID.ToString()]);
           }
       }


       public Int32 PaymentTransactionID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PaymentTransactionID.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___Invoice GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___Invoice(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___Invoice GetFullTable()                  
        {                  
            return new T___Invoice(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___Invoice GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___Invoice(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___Invoice GetRowWhereID(int pID)                  
        {                  
            return new T___Invoice(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___Invoice pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___Invoice pRow, params DataColumnParameter[] pParams)                  
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
        public T___Invoice GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___Invoice(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Invoice(drst);                  
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
        public T___Invoice getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___Invoice(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Invoice(drst);                  
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

                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
        public virtual string GetFillSQL() => Invoice__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pClientID,
Int32 pCreatedByID,
Int32 pTermID,
Int32 pOriginalBillID,
Int32 pPaymentTransactionID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
                DataColumnParameter paramOriginalBillID = new DataColumnParameter(defOriginalBillID, pOriginalBillID);
                DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);
                DataColumnParameter paramBillDefinition = new DataColumnParameter(defBillDefinition, defBillDefinition.DefaultValue);
                DataColumnParameter paramBillDescription = new DataColumnParameter(defBillDescription, defBillDescription.DefaultValue);
                DataColumnParameter paramBillAmount = new DataColumnParameter(defBillAmount, defBillAmount.DefaultValue);
                DataColumnParameter paramTotal = new DataColumnParameter(defTotal, defTotal.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramCanBeDeleted = new DataColumnParameter(defCanBeDeleted, defCanBeDeleted.DefaultValue);
                DataColumnParameter paramQuantity = new DataColumnParameter(defQuantity, defQuantity.DefaultValue);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, defIpAddress.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramClientID.getSQLQuotedValueForAdd(),
                paramBillDefinition.getSQLQuotedValueForAdd(),
                paramBillDescription.getSQLQuotedValueForAdd(),
                paramBillAmount.getSQLQuotedValueForAdd(),
                paramTotal.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd(),
                paramCanBeDeleted.getSQLQuotedValueForAdd(),
                paramQuantity.getSQLQuotedValueForAdd(),
                paramIpAddress.getSQLQuotedValueForAdd(),
                paramTermID.getSQLQuotedValueForAdd(),
                paramOriginalBillID.getSQLQuotedValueForAdd(),
                paramPaymentTransactionID.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pClientID,
String pBillDefinition,
Decimal pBillAmount,
Decimal pTotal,
DateTime pCreatedAt,
Int32 pCreatedByID,
Boolean pCanBeDeleted,
Int32 pQuantity,
String pIpAddress,
Int32 pTermID,
Int32 pOriginalBillID,
Object pBillDescription = null,
Object pPaymentTransactionID = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramBillDefinition = new DataColumnParameter(defBillDefinition, pBillDefinition);
                DataColumnParameter paramBillDescription = new DataColumnParameter(defBillDescription, pBillDescription);
                DataColumnParameter paramBillAmount = new DataColumnParameter(defBillAmount, pBillAmount);
                DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramCanBeDeleted = new DataColumnParameter(defCanBeDeleted, pCanBeDeleted);
                DataColumnParameter paramQuantity = new DataColumnParameter(defQuantity, pQuantity);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
                DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
                DataColumnParameter paramOriginalBillID = new DataColumnParameter(defOriginalBillID, pOriginalBillID);
                DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramBillDefinition.getSQLQuotedValueForAdd(),
paramBillDescription.getSQLQuotedValueForAdd(),
paramBillAmount.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramQuantity.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramOriginalBillID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pClientID,
String pBillDefinition,
Decimal pBillAmount,
Decimal pTotal,
DateTime pCreatedAt,
Int32 pCreatedByID,
Boolean pCanBeDeleted,
Int32 pQuantity,
String pIpAddress,
Int32 pTermID,
Int32 pOriginalBillID,
Object pBillDescription = null,
Object pPaymentTransactionID = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramBillDefinition = new DataColumnParameter(defBillDefinition, pBillDefinition);
DataColumnParameter paramBillDescription = new DataColumnParameter(defBillDescription, pBillDescription);
DataColumnParameter paramBillAmount = new DataColumnParameter(defBillAmount, pBillAmount);
DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramCanBeDeleted = new DataColumnParameter(defCanBeDeleted, pCanBeDeleted);
DataColumnParameter paramQuantity = new DataColumnParameter(defQuantity, pQuantity);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
DataColumnParameter paramOriginalBillID = new DataColumnParameter(defOriginalBillID, pOriginalBillID);
DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramBillDefinition.getSQLQuotedValueForAdd(),
paramBillDescription.getSQLQuotedValueForAdd(),
paramBillAmount.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramQuantity.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramOriginalBillID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pClientID,
String pBillDefinition,
Decimal pBillAmount,
Decimal pTotal,
DateTime pCreatedAt,
Int32 pCreatedByID,
Boolean pCanBeDeleted,
Int32 pQuantity,
String pIpAddress,
Int32 pTermID,
Int32 pOriginalBillID,
Object pBillDescription= null,
Object pPaymentTransactionID= null){

        try{

DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramBillDefinition = new DataColumnParameter(defBillDefinition, pBillDefinition);
DataColumnParameter paramBillDescription = new DataColumnParameter(defBillDescription, pBillDescription);
DataColumnParameter paramBillAmount = new DataColumnParameter(defBillAmount, pBillAmount);
DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramCanBeDeleted = new DataColumnParameter(defCanBeDeleted, pCanBeDeleted);
DataColumnParameter paramQuantity = new DataColumnParameter(defQuantity, pQuantity);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
DataColumnParameter paramOriginalBillID = new DataColumnParameter(defOriginalBillID, pOriginalBillID);
DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramClientID.getSQLQuotedValueForAdd(),
paramBillDefinition.getSQLQuotedValueForAdd(),
paramBillDescription.getSQLQuotedValueForAdd(),
paramBillAmount.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramQuantity.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramOriginalBillID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd()  ), true);


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
Object pClientID = null,
Object pBillDefinition = null,
Object pBillAmount = null,
Object pTotal = null,
Object pCreatedAt = null,
Object pCreatedByID = null,
Object pCanBeDeleted = null,
Object pQuantity = null,
Object pIpAddress = null,
Object pTermID = null,
Object pOriginalBillID = null,
Object pBillDescription = null,
Object pPaymentTransactionID = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
 DataColumnParameter paramBillDefinition = new DataColumnParameter(defBillDefinition, pBillDefinition);
 DataColumnParameter paramBillDescription = new DataColumnParameter(defBillDescription, pBillDescription);
 DataColumnParameter paramBillAmount = new DataColumnParameter(defBillAmount, pBillAmount);
 DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramCanBeDeleted = new DataColumnParameter(defCanBeDeleted, pCanBeDeleted);
 DataColumnParameter paramQuantity = new DataColumnParameter(defQuantity, pQuantity);
 DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
 DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
 DataColumnParameter paramOriginalBillID = new DataColumnParameter(defOriginalBillID, pOriginalBillID);
 DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [ClientID]={2},[BillDefinition]={3},[BillDescription]={4},[BillAmount]={5},[Total]={6},[CreatedAt]={7},[CreatedByID]={8},[CanBeDeleted]={9},[Quantity]={10},[IpAddress]={11},[TermID]={12},[OriginalBillID]={13},[PaymentTransactionID]={14} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramClientID.getSQLQuotedValueForUpdate(),
paramBillDefinition.getSQLQuotedValueForUpdate(),
paramBillDescription.getSQLQuotedValueForUpdate(),
paramBillAmount.getSQLQuotedValueForUpdate(),
paramTotal.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramCanBeDeleted.getSQLQuotedValueForUpdate(),
paramQuantity.getSQLQuotedValueForUpdate(),
paramIpAddress.getSQLQuotedValueForUpdate(),
paramTermID.getSQLQuotedValueForUpdate(),
paramOriginalBillID.getSQLQuotedValueForUpdate(),
paramPaymentTransactionID.getSQLQuotedValueForUpdate()  ), true);


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
