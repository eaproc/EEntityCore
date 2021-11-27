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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.import                  
{                  

    public class T___AccountingExpenditureDisbursed : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___AccountingExpenditureDisbursed()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defDataMonitorID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DataMonitorID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defImportStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ImportStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defRequest = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Request.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDisbursedDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DisbursedDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCategory = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Category.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiary = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Beneficiary.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNotes = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Notes.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotal = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Total.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defImportComment = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ImportComment.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID); 
          ColumnDefns.Add(defImportStatusID.ColumnName, defImportStatusID); 
          ColumnDefns.Add(defRequest.ColumnName, defRequest); 
          ColumnDefns.Add(defDisbursedDate.ColumnName, defDisbursedDate); 
          ColumnDefns.Add(defCategory.ColumnName, defCategory); 
          ColumnDefns.Add(defBeneficiary.ColumnName, defBeneficiary); 
          ColumnDefns.Add(defNotes.ColumnName, defNotes); 
          ColumnDefns.Add(defTotal.ColumnName, defTotal); 
          ColumnDefns.Add(defImportComment.ColumnName, defImportComment); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_AccountingExpenditureDisbursed_DataMonitorID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "import.AccountingExpenditureDisbursed", "import.DataMonitor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_AccountingExpenditureDisbursed_ImportStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.AccountingExpenditureDisbursed", "import.ImportStatus"                  
                            ));                  

          }


                  
       public T___AccountingExpenditureDisbursed() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___AccountingExpenditureDisbursed(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___AccountingExpenditureDisbursed(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "import.AccountingExpenditureDisbursed";
       public const string AccountingExpenditureDisbursed__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [DataMonitorID], [ImportStatusID], [Request], [DisbursedDate], [Category], [Beneficiary], [Notes], [Total], [ImportComment], [CreatedAt] FROM AccountingExpenditureDisbursed";
       public const string AccountingExpenditureDisbursed__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [DataMonitorID], [ImportStatusID], [Request], [DisbursedDate], [Category], [Beneficiary], [Notes], [Total], [ImportComment], [CreatedAt] FROM AccountingExpenditureDisbursed";


       public enum TableColumnNames
       {

           ID,
           DataMonitorID,
           ImportStatusID,
           Request,
           DisbursedDate,
           Category,
           Beneficiary,
           Notes,
           Total,
           ImportComment,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_import_AccountingExpenditureDisbursed, 
           fk_import_AccountingExpenditureDisbursed_DataMonitorID, 
           fk_import_AccountingExpenditureDisbursed_ImportStatusID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDataMonitorID;
       public static readonly DataColumnDefinition defImportStatusID;
       public static readonly DataColumnDefinition defRequest;
       public static readonly DataColumnDefinition defDisbursedDate;
       public static readonly DataColumnDefinition defCategory;
       public static readonly DataColumnDefinition defBeneficiary;
       public static readonly DataColumnDefinition defNotes;
       public static readonly DataColumnDefinition defTotal;
       public static readonly DataColumnDefinition defImportComment;
       public static readonly DataColumnDefinition defCreatedAt;

       public int DataMonitorID { get => (int)TargettedRow[TableColumnNames.DataMonitorID.ToString()]; }


       public int ImportStatusID { get => (int)TargettedRow[TableColumnNames.ImportStatusID.ToString()]; }


       public string Request { get => (string)TargettedRow[TableColumnNames.Request.ToString()]; }


       public NullableDateTime DisbursedDate { get => new (this.TargettedRow[TableColumnNames.DisbursedDate.ToString()]); }


       public string Category { get => (string)TargettedRow[TableColumnNames.Category.ToString()]; }


       public string Beneficiary { get => (string)TargettedRow[TableColumnNames.Beneficiary.ToString()]; }


       public string Notes { get => (string)TargettedRow[TableColumnNames.Notes.ToString()]; }


       public decimal Total { get => (decimal)TargettedRow[TableColumnNames.Total.ToString()]; }


       public string ImportComment { get => (string)TargettedRow[TableColumnNames.ImportComment.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___AccountingExpenditureDisbursed GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___AccountingExpenditureDisbursed GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___AccountingExpenditureDisbursed GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___AccountingExpenditureDisbursed(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___AccountingExpenditureDisbursed GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => AccountingExpenditureDisbursed__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pDataMonitorID,
Int32 pImportStatusID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
                DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
                DataColumnParameter paramRequest = new DataColumnParameter(defRequest, defRequest.DefaultValue);
                DataColumnParameter paramDisbursedDate = new DataColumnParameter(defDisbursedDate, defDisbursedDate.DefaultValue);
                DataColumnParameter paramCategory = new DataColumnParameter(defCategory, defCategory.DefaultValue);
                DataColumnParameter paramBeneficiary = new DataColumnParameter(defBeneficiary, defBeneficiary.DefaultValue);
                DataColumnParameter paramNotes = new DataColumnParameter(defNotes, defNotes.DefaultValue);
                DataColumnParameter paramTotal = new DataColumnParameter(defTotal, defTotal.DefaultValue);
                DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, defImportComment.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramDataMonitorID.GetSQLQuotedValueForAdd(),
                paramImportStatusID.GetSQLQuotedValueForAdd(),
                paramRequest.GetSQLQuotedValueForAdd(),
                paramDisbursedDate.GetSQLQuotedValueForAdd(),
                paramCategory.GetSQLQuotedValueForAdd(),
                paramBeneficiary.GetSQLQuotedValueForAdd(),
                paramNotes.GetSQLQuotedValueForAdd(),
                paramTotal.GetSQLQuotedValueForAdd(),
                paramImportComment.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pDataMonitorID,
Int32 pImportStatusID,
String pRequest,
DateTime pDisbursedDate,
String pCategory,
String pBeneficiary,
Decimal pTotal,
String pImportComment,
DateTime pCreatedAt,
Object pNotes = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
                DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
                DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
                DataColumnParameter paramDisbursedDate = new DataColumnParameter(defDisbursedDate, pDisbursedDate);
                DataColumnParameter paramCategory = new DataColumnParameter(defCategory, pCategory);
                DataColumnParameter paramBeneficiary = new DataColumnParameter(defBeneficiary, pBeneficiary);
                DataColumnParameter paramNotes = new DataColumnParameter(defNotes, pNotes);
                DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
                DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramDataMonitorID.GetSQLQuotedValueForAdd(),
paramImportStatusID.GetSQLQuotedValueForAdd(),
paramRequest.GetSQLQuotedValueForAdd(),
paramDisbursedDate.GetSQLQuotedValueForAdd(),
paramCategory.GetSQLQuotedValueForAdd(),
paramBeneficiary.GetSQLQuotedValueForAdd(),
paramNotes.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramImportComment.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pDataMonitorID,
Int32 pImportStatusID,
String pRequest,
DateTime pDisbursedDate,
String pCategory,
String pBeneficiary,
Decimal pTotal,
String pImportComment,
DateTime pCreatedAt,
Object pNotes = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
DataColumnParameter paramDisbursedDate = new DataColumnParameter(defDisbursedDate, pDisbursedDate);
DataColumnParameter paramCategory = new DataColumnParameter(defCategory, pCategory);
DataColumnParameter paramBeneficiary = new DataColumnParameter(defBeneficiary, pBeneficiary);
DataColumnParameter paramNotes = new DataColumnParameter(defNotes, pNotes);
DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramDataMonitorID.GetSQLQuotedValueForAdd(),
paramImportStatusID.GetSQLQuotedValueForAdd(),
paramRequest.GetSQLQuotedValueForAdd(),
paramDisbursedDate.GetSQLQuotedValueForAdd(),
paramCategory.GetSQLQuotedValueForAdd(),
paramBeneficiary.GetSQLQuotedValueForAdd(),
paramNotes.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramImportComment.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pDataMonitorID,
Int32 pImportStatusID,
String pRequest,
DateTime pDisbursedDate,
String pCategory,
String pBeneficiary,
Decimal pTotal,
String pImportComment,
DateTime pCreatedAt,
Object pNotes= null){

        try{

DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
DataColumnParameter paramDisbursedDate = new DataColumnParameter(defDisbursedDate, pDisbursedDate);
DataColumnParameter paramCategory = new DataColumnParameter(defCategory, pCategory);
DataColumnParameter paramBeneficiary = new DataColumnParameter(defBeneficiary, pBeneficiary);
DataColumnParameter paramNotes = new DataColumnParameter(defNotes, pNotes);
DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramDataMonitorID.GetSQLQuotedValueForAdd(),
paramImportStatusID.GetSQLQuotedValueForAdd(),
paramRequest.GetSQLQuotedValueForAdd(),
paramDisbursedDate.GetSQLQuotedValueForAdd(),
paramCategory.GetSQLQuotedValueForAdd(),
paramBeneficiary.GetSQLQuotedValueForAdd(),
paramNotes.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramImportComment.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);


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
Object pDataMonitorID = null,
Object pImportStatusID = null,
Object pRequest = null,
Object pDisbursedDate = null,
Object pCategory = null,
Object pBeneficiary = null,
Object pTotal = null,
Object pImportComment = null,
Object pCreatedAt = null,
Object pNotes = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
 DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
 DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
 DataColumnParameter paramDisbursedDate = new DataColumnParameter(defDisbursedDate, pDisbursedDate);
 DataColumnParameter paramCategory = new DataColumnParameter(defCategory, pCategory);
 DataColumnParameter paramBeneficiary = new DataColumnParameter(defBeneficiary, pBeneficiary);
 DataColumnParameter paramNotes = new DataColumnParameter(defNotes, pNotes);
 DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
 DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [DataMonitorID]={2},[ImportStatusID]={3},[Request]={4},[DisbursedDate]={5},[Category]={6},[Beneficiary]={7},[Notes]={8},[Total]={9},[ImportComment]={10},[CreatedAt]={11} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramDataMonitorID.GetSQLQuotedValueForUpdate(),
paramImportStatusID.GetSQLQuotedValueForUpdate(),
paramRequest.GetSQLQuotedValueForUpdate(),
paramDisbursedDate.GetSQLQuotedValueForUpdate(),
paramCategory.GetSQLQuotedValueForUpdate(),
paramBeneficiary.GetSQLQuotedValueForUpdate(),
paramNotes.GetSQLQuotedValueForUpdate(),
paramTotal.GetSQLQuotedValueForUpdate(),
paramImportComment.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate()  ), true);


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
