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

    public class T___Payment : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Payment()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTermID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAmountCharged = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AmountCharged.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDiscountGiven = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DiscountGiven.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDiscountRateApplied = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DiscountRateApplied.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentChannelID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentChannelID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPaymentEntryModeID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentEntryModeID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Comments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTransactionFileName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TransactionFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIpAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IpAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotal = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Total.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


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

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public int TermID { get => (int)TargettedRow[TableColumnNames.TermID.ToString()]; }


       public decimal AmountCharged { get => (decimal)TargettedRow[TableColumnNames.AmountCharged.ToString()]; }


       public decimal DiscountGiven { get => (decimal)TargettedRow[TableColumnNames.DiscountGiven.ToString()]; }


       public decimal DiscountRateApplied { get => (decimal)TargettedRow[TableColumnNames.DiscountRateApplied.ToString()]; }


       public int PaymentChannelID { get => (int)TargettedRow[TableColumnNames.PaymentChannelID.ToString()]; }


       public int PaymentEntryModeID { get => (int)TargettedRow[TableColumnNames.PaymentEntryModeID.ToString()]; }


       public string Comments { get => (string)TargettedRow[TableColumnNames.Comments.ToString()]; }


       public string TransactionFileName { get => (string)TargettedRow[TableColumnNames.TransactionFileName.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public string IpAddress { get => (string)TargettedRow[TableColumnNames.IpAddress.ToString()]; }


       public decimal Total { get => (decimal)TargettedRow[TableColumnNames.Total.ToString()]; }


       public int ClientID { get => (int)TargettedRow[TableColumnNames.ClientID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Payment GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Payment GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Payment GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Payment(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Payment GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Payment__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
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
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramTermID.GetSQLQuotedValueForAdd(),
                paramAmountCharged.GetSQLQuotedValueForAdd(),
                paramDiscountGiven.GetSQLQuotedValueForAdd(),
                paramDiscountRateApplied.GetSQLQuotedValueForAdd(),
                paramPaymentChannelID.GetSQLQuotedValueForAdd(),
                paramPaymentEntryModeID.GetSQLQuotedValueForAdd(),
                paramComments.GetSQLQuotedValueForAdd(),
                paramTransactionFileName.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedByID.GetSQLQuotedValueForAdd(),
                paramIpAddress.GetSQLQuotedValueForAdd(),
                paramTotal.GetSQLQuotedValueForAdd(),
                paramClientID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pTermID,
Decimal pAmountCharged,
Decimal pDiscountGiven,
Decimal pDiscountRateApplied,
Int32 pPaymentChannelID,
Int32 pPaymentEntryModeID,
DateTime pCreatedAt,
Int32 pCreatedByID,
String pIpAddress,
Decimal pTotal,
Int32 pClientID,
Object pComments = null,
Object pTransactionFileName = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
                DataColumnParameter paramAmountCharged = new DataColumnParameter(defAmountCharged, pAmountCharged);
                DataColumnParameter paramDiscountGiven = new DataColumnParameter(defDiscountGiven, pDiscountGiven);
                DataColumnParameter paramDiscountRateApplied = new DataColumnParameter(defDiscountRateApplied, pDiscountRateApplied);
                DataColumnParameter paramPaymentChannelID = new DataColumnParameter(defPaymentChannelID, pPaymentChannelID);
                DataColumnParameter paramPaymentEntryModeID = new DataColumnParameter(defPaymentEntryModeID, pPaymentEntryModeID);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
                DataColumnParameter paramTransactionFileName = new DataColumnParameter(defTransactionFileName, pTransactionFileName);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
                DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramAmountCharged.GetSQLQuotedValueForAdd(),
paramDiscountGiven.GetSQLQuotedValueForAdd(),
paramDiscountRateApplied.GetSQLQuotedValueForAdd(),
paramPaymentChannelID.GetSQLQuotedValueForAdd(),
paramPaymentEntryModeID.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramTransactionFileName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramClientID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pTermID,
Decimal pAmountCharged,
Decimal pDiscountGiven,
Decimal pDiscountRateApplied,
Int32 pPaymentChannelID,
Int32 pPaymentEntryModeID,
DateTime pCreatedAt,
Int32 pCreatedByID,
String pIpAddress,
Decimal pTotal,
Int32 pClientID,
Object pComments = null,
Object pTransactionFileName = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
DataColumnParameter paramAmountCharged = new DataColumnParameter(defAmountCharged, pAmountCharged);
DataColumnParameter paramDiscountGiven = new DataColumnParameter(defDiscountGiven, pDiscountGiven);
DataColumnParameter paramDiscountRateApplied = new DataColumnParameter(defDiscountRateApplied, pDiscountRateApplied);
DataColumnParameter paramPaymentChannelID = new DataColumnParameter(defPaymentChannelID, pPaymentChannelID);
DataColumnParameter paramPaymentEntryModeID = new DataColumnParameter(defPaymentEntryModeID, pPaymentEntryModeID);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramTransactionFileName = new DataColumnParameter(defTransactionFileName, pTransactionFileName);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramAmountCharged.GetSQLQuotedValueForAdd(),
paramDiscountGiven.GetSQLQuotedValueForAdd(),
paramDiscountRateApplied.GetSQLQuotedValueForAdd(),
paramPaymentChannelID.GetSQLQuotedValueForAdd(),
paramPaymentEntryModeID.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramTransactionFileName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramClientID.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pTermID,
Decimal pAmountCharged,
Decimal pDiscountGiven,
Decimal pDiscountRateApplied,
Int32 pPaymentChannelID,
Int32 pPaymentEntryModeID,
DateTime pCreatedAt,
Int32 pCreatedByID,
String pIpAddress,
Decimal pTotal,
Int32 pClientID,
Object pComments= null,
Object pTransactionFileName= null){

        try{

DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
DataColumnParameter paramAmountCharged = new DataColumnParameter(defAmountCharged, pAmountCharged);
DataColumnParameter paramDiscountGiven = new DataColumnParameter(defDiscountGiven, pDiscountGiven);
DataColumnParameter paramDiscountRateApplied = new DataColumnParameter(defDiscountRateApplied, pDiscountRateApplied);
DataColumnParameter paramPaymentChannelID = new DataColumnParameter(defPaymentChannelID, pPaymentChannelID);
DataColumnParameter paramPaymentEntryModeID = new DataColumnParameter(defPaymentEntryModeID, pPaymentEntryModeID);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramTransactionFileName = new DataColumnParameter(defTransactionFileName, pTransactionFileName);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramTermID.GetSQLQuotedValueForAdd(),
paramAmountCharged.GetSQLQuotedValueForAdd(),
paramDiscountGiven.GetSQLQuotedValueForAdd(),
paramDiscountRateApplied.GetSQLQuotedValueForAdd(),
paramPaymentChannelID.GetSQLQuotedValueForAdd(),
paramPaymentEntryModeID.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramTransactionFileName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramClientID.GetSQLQuotedValueForAdd()  ), true);


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
Object pTermID = null,
Object pAmountCharged = null,
Object pDiscountGiven = null,
Object pDiscountRateApplied = null,
Object pPaymentChannelID = null,
Object pPaymentEntryModeID = null,
Object pCreatedAt = null,
Object pCreatedByID = null,
Object pIpAddress = null,
Object pTotal = null,
Object pClientID = null,
Object pComments = null,
Object pTransactionFileName = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
 DataColumnParameter paramAmountCharged = new DataColumnParameter(defAmountCharged, pAmountCharged);
 DataColumnParameter paramDiscountGiven = new DataColumnParameter(defDiscountGiven, pDiscountGiven);
 DataColumnParameter paramDiscountRateApplied = new DataColumnParameter(defDiscountRateApplied, pDiscountRateApplied);
 DataColumnParameter paramPaymentChannelID = new DataColumnParameter(defPaymentChannelID, pPaymentChannelID);
 DataColumnParameter paramPaymentEntryModeID = new DataColumnParameter(defPaymentEntryModeID, pPaymentEntryModeID);
 DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
 DataColumnParameter paramTransactionFileName = new DataColumnParameter(defTransactionFileName, pTransactionFileName);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
 DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
 DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [TermID]={2},[AmountCharged]={3},[DiscountGiven]={4},[DiscountRateApplied]={5},[PaymentChannelID]={6},[PaymentEntryModeID]={7},[Comments]={8},[TransactionFileName]={9},[CreatedAt]={10},[CreatedByID]={11},[IpAddress]={12},[Total]={13},[ClientID]={14} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramTermID.GetSQLQuotedValueForUpdate(),
paramAmountCharged.GetSQLQuotedValueForUpdate(),
paramDiscountGiven.GetSQLQuotedValueForUpdate(),
paramDiscountRateApplied.GetSQLQuotedValueForUpdate(),
paramPaymentChannelID.GetSQLQuotedValueForUpdate(),
paramPaymentEntryModeID.GetSQLQuotedValueForUpdate(),
paramComments.GetSQLQuotedValueForUpdate(),
paramTransactionFileName.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedByID.GetSQLQuotedValueForUpdate(),
paramIpAddress.GetSQLQuotedValueForUpdate(),
paramTotal.GetSQLQuotedValueForUpdate(),
paramClientID.GetSQLQuotedValueForUpdate()  ), true);


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
