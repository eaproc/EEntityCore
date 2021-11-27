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

    public class T___CashRequestProceeding : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___CashRequestProceeding()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTitle = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Title.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCashRequestID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CashRequestID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCashRequestStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CashRequestStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defRevisedAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RevisedAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Comments.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDocumentFileName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DocumentFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defCashRequestID.ColumnName, defCashRequestID); 
          ColumnDefns.Add(defCashRequestStatusID.ColumnName, defCashRequestStatusID); 
          ColumnDefns.Add(defRevisedAmount.ColumnName, defRevisedAmount); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defDocumentFileName.ColumnName, defDocumentFileName); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequestProceeding_CashRequestStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequestProceeding", "accounting.CashRequestStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequestProceeding_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequestProceeding", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequestProceeding_CashRequestID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.CashRequestProceeding", "accounting.CashRequest"                  
                            ));                  

          }


                  
       public T___CashRequestProceeding() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___CashRequestProceeding(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequestProceeding(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___CashRequestProceeding(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.CashRequestProceeding";
       public const string CashRequestProceeding__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Title], [CashRequestID], [CashRequestStatusID], [RevisedAmount], [Comments], [DocumentFileName], [CreatedAt], [CreatedByID] FROM CashRequestProceeding";
       public const string CashRequestProceeding__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Title], [CashRequestID], [CashRequestStatusID], [RevisedAmount], [Comments], [DocumentFileName], [CreatedAt], [CreatedByID] FROM CashRequestProceeding";


       public enum TableColumnNames
       {

           ID,
           Title,
           CashRequestID,
           CashRequestStatusID,
           RevisedAmount,
           Comments,
           DocumentFileName,
           CreatedAt,
           CreatedByID
       } 



       public enum TableConstraints{

           pk_accounting_CashRequestProceeding, 
           fk_accounting_CashRequestProceeding_CashRequestStatusID, 
           fk_accounting_CashRequestProceeding_CreatedByID, 
           fk_accounting_CashRequestProceeding_CashRequestID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defCashRequestID;
       public static readonly DataColumnDefinition defCashRequestStatusID;
       public static readonly DataColumnDefinition defRevisedAmount;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defDocumentFileName;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;

       public string Title { get => (string)TargettedRow[TableColumnNames.Title.ToString()]; }


       public int CashRequestID { get => (int)TargettedRow[TableColumnNames.CashRequestID.ToString()]; }


       public int CashRequestStatusID { get => (int)TargettedRow[TableColumnNames.CashRequestStatusID.ToString()]; }


       public decimal RevisedAmount { get => (decimal)TargettedRow[TableColumnNames.RevisedAmount.ToString()]; }


       public string Comments { get => (string)TargettedRow[TableColumnNames.Comments.ToString()]; }


       public string DocumentFileName { get => (string)TargettedRow[TableColumnNames.DocumentFileName.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___CashRequestProceeding GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___CashRequestProceeding GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___CashRequestProceeding GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___CashRequestProceeding(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___CashRequestProceeding GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => CashRequestProceeding__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCashRequestID,
Int32 pCashRequestStatusID,
Int32 pCreatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCashRequestID = new DataColumnParameter(defCashRequestID, pCashRequestID);
                DataColumnParameter paramCashRequestStatusID = new DataColumnParameter(defCashRequestStatusID, pCashRequestStatusID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramTitle = new DataColumnParameter(defTitle, defTitle.DefaultValue);
                DataColumnParameter paramRevisedAmount = new DataColumnParameter(defRevisedAmount, defRevisedAmount.DefaultValue);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, defComments.DefaultValue);
                DataColumnParameter paramDocumentFileName = new DataColumnParameter(defDocumentFileName, defDocumentFileName.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramTitle.GetSQLQuotedValueForAdd(),
                paramCashRequestID.GetSQLQuotedValueForAdd(),
                paramCashRequestStatusID.GetSQLQuotedValueForAdd(),
                paramRevisedAmount.GetSQLQuotedValueForAdd(),
                paramComments.GetSQLQuotedValueForAdd(),
                paramDocumentFileName.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pTitle,
Int32 pCashRequestID,
Int32 pCashRequestStatusID,
Decimal pRevisedAmount,
String pComments,
DateTime pCreatedAt,
Int32 pCreatedByID,
Object pDocumentFileName = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTitle = new DataColumnParameter(defTitle, pTitle);
                DataColumnParameter paramCashRequestID = new DataColumnParameter(defCashRequestID, pCashRequestID);
                DataColumnParameter paramCashRequestStatusID = new DataColumnParameter(defCashRequestStatusID, pCashRequestStatusID);
                DataColumnParameter paramRevisedAmount = new DataColumnParameter(defRevisedAmount, pRevisedAmount);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
                DataColumnParameter paramDocumentFileName = new DataColumnParameter(defDocumentFileName, pDocumentFileName);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramTitle.GetSQLQuotedValueForAdd(),
paramCashRequestID.GetSQLQuotedValueForAdd(),
paramCashRequestStatusID.GetSQLQuotedValueForAdd(),
paramRevisedAmount.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramDocumentFileName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pTitle,
Int32 pCashRequestID,
Int32 pCashRequestStatusID,
Decimal pRevisedAmount,
String pComments,
DateTime pCreatedAt,
Int32 pCreatedByID,
Object pDocumentFileName = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramTitle = new DataColumnParameter(defTitle, pTitle);
DataColumnParameter paramCashRequestID = new DataColumnParameter(defCashRequestID, pCashRequestID);
DataColumnParameter paramCashRequestStatusID = new DataColumnParameter(defCashRequestStatusID, pCashRequestStatusID);
DataColumnParameter paramRevisedAmount = new DataColumnParameter(defRevisedAmount, pRevisedAmount);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramDocumentFileName = new DataColumnParameter(defDocumentFileName, pDocumentFileName);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramTitle.GetSQLQuotedValueForAdd(),
paramCashRequestID.GetSQLQuotedValueForAdd(),
paramCashRequestStatusID.GetSQLQuotedValueForAdd(),
paramRevisedAmount.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramDocumentFileName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pTitle,
Int32 pCashRequestID,
Int32 pCashRequestStatusID,
Decimal pRevisedAmount,
String pComments,
DateTime pCreatedAt,
Int32 pCreatedByID,
Object pDocumentFileName= null){

        try{

DataColumnParameter paramTitle = new DataColumnParameter(defTitle, pTitle);
DataColumnParameter paramCashRequestID = new DataColumnParameter(defCashRequestID, pCashRequestID);
DataColumnParameter paramCashRequestStatusID = new DataColumnParameter(defCashRequestStatusID, pCashRequestStatusID);
DataColumnParameter paramRevisedAmount = new DataColumnParameter(defRevisedAmount, pRevisedAmount);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramDocumentFileName = new DataColumnParameter(defDocumentFileName, pDocumentFileName);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) ", TABLE_NAME,paramTitle.GetSQLQuotedValueForAdd(),
paramCashRequestID.GetSQLQuotedValueForAdd(),
paramCashRequestStatusID.GetSQLQuotedValueForAdd(),
paramRevisedAmount.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramDocumentFileName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);


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
Object pTitle = null,
Object pCashRequestID = null,
Object pCashRequestStatusID = null,
Object pRevisedAmount = null,
Object pComments = null,
Object pCreatedAt = null,
Object pCreatedByID = null,
Object pDocumentFileName = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramTitle = new DataColumnParameter(defTitle, pTitle);
 DataColumnParameter paramCashRequestID = new DataColumnParameter(defCashRequestID, pCashRequestID);
 DataColumnParameter paramCashRequestStatusID = new DataColumnParameter(defCashRequestStatusID, pCashRequestStatusID);
 DataColumnParameter paramRevisedAmount = new DataColumnParameter(defRevisedAmount, pRevisedAmount);
 DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
 DataColumnParameter paramDocumentFileName = new DataColumnParameter(defDocumentFileName, pDocumentFileName);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [Title]={2},[CashRequestID]={3},[CashRequestStatusID]={4},[RevisedAmount]={5},[Comments]={6},[DocumentFileName]={7},[CreatedAt]={8},[CreatedByID]={9} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramTitle.GetSQLQuotedValueForUpdate(),
paramCashRequestID.GetSQLQuotedValueForUpdate(),
paramCashRequestStatusID.GetSQLQuotedValueForUpdate(),
paramRevisedAmount.GetSQLQuotedValueForUpdate(),
paramComments.GetSQLQuotedValueForUpdate(),
paramDocumentFileName.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedByID.GetSQLQuotedValueForUpdate()  ), true);


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
