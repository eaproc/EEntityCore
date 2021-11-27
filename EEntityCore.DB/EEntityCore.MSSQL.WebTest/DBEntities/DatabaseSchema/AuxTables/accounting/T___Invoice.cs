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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___Invoice : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Invoice()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defClientID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBillDefinition = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BillDefinition.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillDescription = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BillDescription.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BillAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotal = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Total.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCanBeDeleted = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CanBeDeleted.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defQuantity = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Quantity.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIpAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IpAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defOriginalBillID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.OriginalBillID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaymentTransactionID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentTransactionID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


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

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public int ClientID { get => (int)TargettedRow[TableColumnNames.ClientID.ToString()]; }


       public string BillDefinition { get => (string)TargettedRow[TableColumnNames.BillDefinition.ToString()]; }


       public string BillDescription { get => (string)TargettedRow[TableColumnNames.BillDescription.ToString()]; }


       public decimal BillAmount { get => (decimal)TargettedRow[TableColumnNames.BillAmount.ToString()]; }


       public decimal Total { get => (decimal)TargettedRow[TableColumnNames.Total.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public bool CanBeDeleted { get => (bool)TargettedRow[TableColumnNames.CanBeDeleted.ToString()]; }


       public int Quantity { get => (int)TargettedRow[TableColumnNames.Quantity.ToString()]; }


       public string IpAddress { get => (string)TargettedRow[TableColumnNames.IpAddress.ToString()]; }


       public int TermID { get => (int)TargettedRow[TableColumnNames.TermID.ToString()]; }


       public int OriginalBillID { get => (int)TargettedRow[TableColumnNames.OriginalBillID.ToString()]; }


       public int? PaymentTransactionID { get => (int?)TargettedRow[TableColumnNames.PaymentTransactionID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Invoice GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Invoice GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Invoice GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Invoice(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Invoice GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Invoice__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
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
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramClientID.GetSQLQuotedValueForAdd(),
                paramBillDefinition.GetSQLQuotedValueForAdd(),
                paramBillDescription.GetSQLQuotedValueForAdd(),
                paramBillAmount.GetSQLQuotedValueForAdd(),
                paramTotal.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedByID.GetSQLQuotedValueForAdd(),
                paramCanBeDeleted.GetSQLQuotedValueForAdd(),
                paramQuantity.GetSQLQuotedValueForAdd(),
                paramIpAddress.GetSQLQuotedValueForAdd(),
                paramTermID.GetSQLQuotedValueForAdd(),
                paramOriginalBillID.GetSQLQuotedValueForAdd(),
                paramPaymentTransactionID.GetSQLQuotedValueForAdd()  ), true);




                  
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
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramClientID.GetSQLQuotedValueForAdd(),
paramBillDefinition.GetSQLQuotedValueForAdd(),
paramBillDescription.GetSQLQuotedValueForAdd(),
paramBillAmount.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramCanBeDeleted.GetSQLQuotedValueForAdd(),
paramQuantity.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramOriginalBillID.GetSQLQuotedValueForAdd(),
paramPaymentTransactionID.GetSQLQuotedValueForAdd()  ), true);




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
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramClientID.GetSQLQuotedValueForAdd(),
paramBillDefinition.GetSQLQuotedValueForAdd(),
paramBillDescription.GetSQLQuotedValueForAdd(),
paramBillAmount.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramCanBeDeleted.GetSQLQuotedValueForAdd(),
paramQuantity.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramOriginalBillID.GetSQLQuotedValueForAdd(),
paramPaymentTransactionID.GetSQLQuotedValueForAdd()  ), true);




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
     String.Format("INSERT INTO {0}([ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramClientID.GetSQLQuotedValueForAdd(),
paramBillDefinition.GetSQLQuotedValueForAdd(),
paramBillDescription.GetSQLQuotedValueForAdd(),
paramBillAmount.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramCanBeDeleted.GetSQLQuotedValueForAdd(),
paramQuantity.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramOriginalBillID.GetSQLQuotedValueForAdd(),
paramPaymentTransactionID.GetSQLQuotedValueForAdd()  ), true);


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
     String.Format("UPDATE {0} SET [ClientID]={2},[BillDefinition]={3},[BillDescription]={4},[BillAmount]={5},[Total]={6},[CreatedAt]={7},[CreatedByID]={8},[CanBeDeleted]={9},[Quantity]={10},[IpAddress]={11},[TermID]={12},[OriginalBillID]={13},[PaymentTransactionID]={14} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramClientID.GetSQLQuotedValueForUpdate(),
paramBillDefinition.GetSQLQuotedValueForUpdate(),
paramBillDescription.GetSQLQuotedValueForUpdate(),
paramBillAmount.GetSQLQuotedValueForUpdate(),
paramTotal.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedByID.GetSQLQuotedValueForUpdate(),
paramCanBeDeleted.GetSQLQuotedValueForUpdate(),
paramQuantity.GetSQLQuotedValueForUpdate(),
paramIpAddress.GetSQLQuotedValueForUpdate(),
paramTermID.GetSQLQuotedValueForUpdate(),
paramOriginalBillID.GetSQLQuotedValueForUpdate(),
paramPaymentTransactionID.GetSQLQuotedValueForUpdate()  ), true);


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
