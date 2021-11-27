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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.common                  
{                  

    public class T___PersonIdentificationDetail : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PersonIdentificationDetail()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPersonID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Number.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defIdentificationTypeID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IdentificationTypeID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defIssuedDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IssuedDate.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIssuingCountryID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IssuingCountryID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defExpiryDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExpiryDate.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIdentificationViabilityID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IdentificationViabilityID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDocumentFileName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DocumentFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defNumber.ColumnName, defNumber); 
          ColumnDefns.Add(defIdentificationTypeID.ColumnName, defIdentificationTypeID); 
          ColumnDefns.Add(defIssuedDate.ColumnName, defIssuedDate); 
          ColumnDefns.Add(defIssuingCountryID.ColumnName, defIssuingCountryID); 
          ColumnDefns.Add(defExpiryDate.ColumnName, defExpiryDate); 
          ColumnDefns.Add(defIdentificationViabilityID.ColumnName, defIdentificationViabilityID); 
          ColumnDefns.Add(defDocumentFileName.ColumnName, defDocumentFileName); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_PersonID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.Person"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_IdentificationTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.IdentificationType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_IssuingCountryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.Country"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_IdentificationViabilityID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.IdentificationViability"                  
                            ));                  

          }


                  
       public T___PersonIdentificationDetail() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PersonIdentificationDetail(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PersonIdentificationDetail(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "common.PersonIdentificationDetail";
       public const string PersonIdentificationDetail__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PersonID], [Number], [IdentificationTypeID], [IssuedDate], [IssuingCountryID], [ExpiryDate], [IdentificationViabilityID], [DocumentFileName], [CreatedAt], [UpdatedAt] FROM PersonIdentificationDetail";
       public const string PersonIdentificationDetail__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PersonID], [Number], [IdentificationTypeID], [IssuedDate], [IssuingCountryID], [ExpiryDate], [IdentificationViabilityID], [DocumentFileName], [CreatedAt], [UpdatedAt] FROM PersonIdentificationDetail";


       public enum TableColumnNames
       {

           ID,
           PersonID,
           Number,
           IdentificationTypeID,
           IssuedDate,
           IssuingCountryID,
           ExpiryDate,
           IdentificationViabilityID,
           DocumentFileName,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_common_PersonIdentificationDetail, 
           fk_common_PersonIdentificationDetail_PersonID, 
           fk_common_PersonIdentificationDetail_IdentificationTypeID, 
           fk_common_PersonIdentificationDetail_IssuingCountryID, 
           fk_common_PersonIdentificationDetail_IdentificationViabilityID, 
           uq_common_PersonIdentificationDetail_PersonID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defNumber;
       public static readonly DataColumnDefinition defIdentificationTypeID;
       public static readonly DataColumnDefinition defIssuedDate;
       public static readonly DataColumnDefinition defIssuingCountryID;
       public static readonly DataColumnDefinition defExpiryDate;
       public static readonly DataColumnDefinition defIdentificationViabilityID;
       public static readonly DataColumnDefinition defDocumentFileName;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public int PersonID { get => (int)TargettedRow[TableColumnNames.PersonID.ToString()]; }


       public string Number { get => (string)TargettedRow[TableColumnNames.Number.ToString()]; }


       public int IdentificationTypeID { get => (int)TargettedRow[TableColumnNames.IdentificationTypeID.ToString()]; }


       public NullableDateTime IssuedDate { get => new (this.TargettedRow[TableColumnNames.IssuedDate.ToString()]); }


       public int IssuingCountryID { get => (int)TargettedRow[TableColumnNames.IssuingCountryID.ToString()]; }


       public NullableDateTime ExpiryDate { get => new (this.TargettedRow[TableColumnNames.ExpiryDate.ToString()]); }


       public int IdentificationViabilityID { get => (int)TargettedRow[TableColumnNames.IdentificationViabilityID.ToString()]; }


       public string DocumentFileName { get => (string)TargettedRow[TableColumnNames.DocumentFileName.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


       public NullableDateTime UpdatedAt { get => new (this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]); }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___PersonIdentificationDetail GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PersonIdentificationDetail GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PersonIdentificationDetail GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PersonIdentificationDetail(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PersonIdentificationDetail GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PersonIdentificationDetail__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pPersonID,
String pNumber,
Int32 pIdentificationTypeID,
Int32 pIssuingCountryID,
Int32 pIdentificationViabilityID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
                DataColumnParameter paramNumber = new DataColumnParameter(defNumber, pNumber);
                DataColumnParameter paramIdentificationTypeID = new DataColumnParameter(defIdentificationTypeID, pIdentificationTypeID);
                DataColumnParameter paramIssuingCountryID = new DataColumnParameter(defIssuingCountryID, pIssuingCountryID);
                DataColumnParameter paramIdentificationViabilityID = new DataColumnParameter(defIdentificationViabilityID, pIdentificationViabilityID);
                DataColumnParameter paramIssuedDate = new DataColumnParameter(defIssuedDate, defIssuedDate.DefaultValue);
                DataColumnParameter paramExpiryDate = new DataColumnParameter(defExpiryDate, defExpiryDate.DefaultValue);
                DataColumnParameter paramDocumentFileName = new DataColumnParameter(defDocumentFileName, defDocumentFileName.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramPersonID.GetSQLQuotedValueForAdd(),
                paramNumber.GetSQLQuotedValueForAdd(),
                paramIdentificationTypeID.GetSQLQuotedValueForAdd(),
                paramIssuedDate.GetSQLQuotedValueForAdd(),
                paramIssuingCountryID.GetSQLQuotedValueForAdd(),
                paramExpiryDate.GetSQLQuotedValueForAdd(),
                paramIdentificationViabilityID.GetSQLQuotedValueForAdd(),
                paramDocumentFileName.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pPersonID,
String pNumber,
Int32 pIdentificationTypeID,
Int32 pIssuingCountryID,
Int32 pIdentificationViabilityID,
DateTime pCreatedAt,
Object pIssuedDate = null,
Object pExpiryDate = null,
Object pDocumentFileName = null,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
                DataColumnParameter paramNumber = new DataColumnParameter(defNumber, pNumber);
                DataColumnParameter paramIdentificationTypeID = new DataColumnParameter(defIdentificationTypeID, pIdentificationTypeID);
                DataColumnParameter paramIssuedDate = new DataColumnParameter(defIssuedDate, pIssuedDate);
                DataColumnParameter paramIssuingCountryID = new DataColumnParameter(defIssuingCountryID, pIssuingCountryID);
                DataColumnParameter paramExpiryDate = new DataColumnParameter(defExpiryDate, pExpiryDate);
                DataColumnParameter paramIdentificationViabilityID = new DataColumnParameter(defIdentificationViabilityID, pIdentificationViabilityID);
                DataColumnParameter paramDocumentFileName = new DataColumnParameter(defDocumentFileName, pDocumentFileName);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramPersonID.GetSQLQuotedValueForAdd(),
paramNumber.GetSQLQuotedValueForAdd(),
paramIdentificationTypeID.GetSQLQuotedValueForAdd(),
paramIssuedDate.GetSQLQuotedValueForAdd(),
paramIssuingCountryID.GetSQLQuotedValueForAdd(),
paramExpiryDate.GetSQLQuotedValueForAdd(),
paramIdentificationViabilityID.GetSQLQuotedValueForAdd(),
paramDocumentFileName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pPersonID,
String pNumber,
Int32 pIdentificationTypeID,
Int32 pIssuingCountryID,
Int32 pIdentificationViabilityID,
DateTime pCreatedAt,
Object pIssuedDate = null,
Object pExpiryDate = null,
Object pDocumentFileName = null,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
DataColumnParameter paramNumber = new DataColumnParameter(defNumber, pNumber);
DataColumnParameter paramIdentificationTypeID = new DataColumnParameter(defIdentificationTypeID, pIdentificationTypeID);
DataColumnParameter paramIssuedDate = new DataColumnParameter(defIssuedDate, pIssuedDate);
DataColumnParameter paramIssuingCountryID = new DataColumnParameter(defIssuingCountryID, pIssuingCountryID);
DataColumnParameter paramExpiryDate = new DataColumnParameter(defExpiryDate, pExpiryDate);
DataColumnParameter paramIdentificationViabilityID = new DataColumnParameter(defIdentificationViabilityID, pIdentificationViabilityID);
DataColumnParameter paramDocumentFileName = new DataColumnParameter(defDocumentFileName, pDocumentFileName);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramPersonID.GetSQLQuotedValueForAdd(),
paramNumber.GetSQLQuotedValueForAdd(),
paramIdentificationTypeID.GetSQLQuotedValueForAdd(),
paramIssuedDate.GetSQLQuotedValueForAdd(),
paramIssuingCountryID.GetSQLQuotedValueForAdd(),
paramExpiryDate.GetSQLQuotedValueForAdd(),
paramIdentificationViabilityID.GetSQLQuotedValueForAdd(),
paramDocumentFileName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pPersonID,
String pNumber,
Int32 pIdentificationTypeID,
Int32 pIssuingCountryID,
Int32 pIdentificationViabilityID,
DateTime pCreatedAt,
Object pIssuedDate= null,
Object pExpiryDate= null,
Object pDocumentFileName= null,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
DataColumnParameter paramNumber = new DataColumnParameter(defNumber, pNumber);
DataColumnParameter paramIdentificationTypeID = new DataColumnParameter(defIdentificationTypeID, pIdentificationTypeID);
DataColumnParameter paramIssuedDate = new DataColumnParameter(defIssuedDate, pIssuedDate);
DataColumnParameter paramIssuingCountryID = new DataColumnParameter(defIssuingCountryID, pIssuingCountryID);
DataColumnParameter paramExpiryDate = new DataColumnParameter(defExpiryDate, pExpiryDate);
DataColumnParameter paramIdentificationViabilityID = new DataColumnParameter(defIdentificationViabilityID, pIdentificationViabilityID);
DataColumnParameter paramDocumentFileName = new DataColumnParameter(defDocumentFileName, pDocumentFileName);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramPersonID.GetSQLQuotedValueForAdd(),
paramNumber.GetSQLQuotedValueForAdd(),
paramIdentificationTypeID.GetSQLQuotedValueForAdd(),
paramIssuedDate.GetSQLQuotedValueForAdd(),
paramIssuingCountryID.GetSQLQuotedValueForAdd(),
paramExpiryDate.GetSQLQuotedValueForAdd(),
paramIdentificationViabilityID.GetSQLQuotedValueForAdd(),
paramDocumentFileName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);


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
Object pPersonID = null,
Object pNumber = null,
Object pIdentificationTypeID = null,
Object pIssuingCountryID = null,
Object pIdentificationViabilityID = null,
Object pCreatedAt = null,
Object pIssuedDate = null,
Object pExpiryDate = null,
Object pDocumentFileName = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
 DataColumnParameter paramNumber = new DataColumnParameter(defNumber, pNumber);
 DataColumnParameter paramIdentificationTypeID = new DataColumnParameter(defIdentificationTypeID, pIdentificationTypeID);
 DataColumnParameter paramIssuedDate = new DataColumnParameter(defIssuedDate, pIssuedDate);
 DataColumnParameter paramIssuingCountryID = new DataColumnParameter(defIssuingCountryID, pIssuingCountryID);
 DataColumnParameter paramExpiryDate = new DataColumnParameter(defExpiryDate, pExpiryDate);
 DataColumnParameter paramIdentificationViabilityID = new DataColumnParameter(defIdentificationViabilityID, pIdentificationViabilityID);
 DataColumnParameter paramDocumentFileName = new DataColumnParameter(defDocumentFileName, pDocumentFileName);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [PersonID]={2},[Number]={3},[IdentificationTypeID]={4},[IssuedDate]={5},[IssuingCountryID]={6},[ExpiryDate]={7},[IdentificationViabilityID]={8},[DocumentFileName]={9},[CreatedAt]={10},[UpdatedAt]={11} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramPersonID.GetSQLQuotedValueForUpdate(),
paramNumber.GetSQLQuotedValueForUpdate(),
paramIdentificationTypeID.GetSQLQuotedValueForUpdate(),
paramIssuedDate.GetSQLQuotedValueForUpdate(),
paramIssuingCountryID.GetSQLQuotedValueForUpdate(),
paramExpiryDate.GetSQLQuotedValueForUpdate(),
paramIdentificationViabilityID.GetSQLQuotedValueForUpdate(),
paramDocumentFileName.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate()  ), true);


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
