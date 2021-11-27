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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.system                  
{                  

    public class T___ServerExceptionLogger : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ServerExceptionLogger()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTraceID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TraceID.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defRequestParametersJSON = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RequestParametersJSON.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionMessage = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExceptionMessage.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStackTrace = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.StackTrace.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsResolved = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsResolved.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Comments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAbsoluteURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AbsoluteURL.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IPAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTraceID.ColumnName, defTraceID); 
          ColumnDefns.Add(defRequestParametersJSON.ColumnName, defRequestParametersJSON); 
          ColumnDefns.Add(defExceptionMessage.ColumnName, defExceptionMessage); 
          ColumnDefns.Add(defStackTrace.ColumnName, defStackTrace); 
          ColumnDefns.Add(defIsResolved.ColumnName, defIsResolved); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defAbsoluteURL.ColumnName, defAbsoluteURL); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_ServerExceptionLogger_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.ServerExceptionLogger", "auth.Users"                  
                            ));                  

          }


                  
       public T___ServerExceptionLogger() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ServerExceptionLogger(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ServerExceptionLogger(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___ServerExceptionLogger(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.ServerExceptionLogger";
       public const string ServerExceptionLogger__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TraceID], [RequestParametersJSON], [ExceptionMessage], [StackTrace], [IsResolved], [Comments], [CreatedAt], [UpdatedAt], [AbsoluteURL], [IPAddress], [UserID] FROM ServerExceptionLogger";
       public const string ServerExceptionLogger__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TraceID], [RequestParametersJSON], [ExceptionMessage], [StackTrace], [IsResolved], [Comments], [CreatedAt], [UpdatedAt], [AbsoluteURL], [IPAddress], [UserID] FROM ServerExceptionLogger";


       public enum TableColumnNames
       {

           ID,
           TraceID,
           RequestParametersJSON,
           ExceptionMessage,
           StackTrace,
           IsResolved,
           Comments,
           CreatedAt,
           UpdatedAt,
           AbsoluteURL,
           IPAddress,
           UserID
       } 



       public enum TableConstraints{

           pk_system_ServerExceptionLogger, 
           fk_system_ServerExceptionLogger_UserID, 
           uq_system_ServerExceptionLogger_TraceID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTraceID;
       public static readonly DataColumnDefinition defRequestParametersJSON;
       public static readonly DataColumnDefinition defExceptionMessage;
       public static readonly DataColumnDefinition defStackTrace;
       public static readonly DataColumnDefinition defIsResolved;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defAbsoluteURL;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defUserID;

       public string TraceID { get => (string)TargettedRow[TableColumnNames.TraceID.ToString()]; }


       public string RequestParametersJSON { get => (string)TargettedRow[TableColumnNames.RequestParametersJSON.ToString()]; }


       public string ExceptionMessage { get => (string)TargettedRow[TableColumnNames.ExceptionMessage.ToString()]; }


       public string StackTrace { get => (string)TargettedRow[TableColumnNames.StackTrace.ToString()]; }


       public bool IsResolved { get => (bool)TargettedRow[TableColumnNames.IsResolved.ToString()]; }


       public string Comments { get => (string)TargettedRow[TableColumnNames.Comments.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


       public NullableDateTime UpdatedAt { get => new (this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]); }


       public string AbsoluteURL { get => (string)TargettedRow[TableColumnNames.AbsoluteURL.ToString()]; }


       public string IPAddress { get => (string)TargettedRow[TableColumnNames.IPAddress.ToString()]; }


       public int? UserID { get => (int?)TargettedRow[TableColumnNames.UserID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___ServerExceptionLogger GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___ServerExceptionLogger GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___ServerExceptionLogger GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___ServerExceptionLogger(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___ServerExceptionLogger GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => ServerExceptionLogger__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(String pTraceID,
Int32 pUserID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTraceID = new DataColumnParameter(defTraceID, pTraceID);
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramRequestParametersJSON = new DataColumnParameter(defRequestParametersJSON, defRequestParametersJSON.DefaultValue);
                DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, defExceptionMessage.DefaultValue);
                DataColumnParameter paramStackTrace = new DataColumnParameter(defStackTrace, defStackTrace.DefaultValue);
                DataColumnParameter paramIsResolved = new DataColumnParameter(defIsResolved, defIsResolved.DefaultValue);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, defComments.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramAbsoluteURL = new DataColumnParameter(defAbsoluteURL, defAbsoluteURL.DefaultValue);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, defIPAddress.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramTraceID.GetSQLQuotedValueForAdd(),
                paramRequestParametersJSON.GetSQLQuotedValueForAdd(),
                paramExceptionMessage.GetSQLQuotedValueForAdd(),
                paramStackTrace.GetSQLQuotedValueForAdd(),
                paramIsResolved.GetSQLQuotedValueForAdd(),
                paramComments.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd(),
                paramAbsoluteURL.GetSQLQuotedValueForAdd(),
                paramIPAddress.GetSQLQuotedValueForAdd(),
                paramUserID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pTraceID,
String pExceptionMessage,
Boolean pIsResolved,
DateTime pCreatedAt,
String pAbsoluteURL,
String pIPAddress,
Object pRequestParametersJSON = null,
Object pStackTrace = null,
Object pComments = null,
Object pUpdatedAt = null,
Object pUserID = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTraceID = new DataColumnParameter(defTraceID, pTraceID);
                DataColumnParameter paramRequestParametersJSON = new DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON);
                DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
                DataColumnParameter paramStackTrace = new DataColumnParameter(defStackTrace, pStackTrace);
                DataColumnParameter paramIsResolved = new DataColumnParameter(defIsResolved, pIsResolved);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramAbsoluteURL = new DataColumnParameter(defAbsoluteURL, pAbsoluteURL);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramTraceID.GetSQLQuotedValueForAdd(),
paramRequestParametersJSON.GetSQLQuotedValueForAdd(),
paramExceptionMessage.GetSQLQuotedValueForAdd(),
paramStackTrace.GetSQLQuotedValueForAdd(),
paramIsResolved.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramAbsoluteURL.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pTraceID,
String pExceptionMessage,
Boolean pIsResolved,
DateTime pCreatedAt,
String pAbsoluteURL,
String pIPAddress,
Object pRequestParametersJSON = null,
Object pStackTrace = null,
Object pComments = null,
Object pUpdatedAt = null,
Object pUserID = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramTraceID = new DataColumnParameter(defTraceID, pTraceID);
DataColumnParameter paramRequestParametersJSON = new DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON);
DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
DataColumnParameter paramStackTrace = new DataColumnParameter(defStackTrace, pStackTrace);
DataColumnParameter paramIsResolved = new DataColumnParameter(defIsResolved, pIsResolved);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramAbsoluteURL = new DataColumnParameter(defAbsoluteURL, pAbsoluteURL);
DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramTraceID.GetSQLQuotedValueForAdd(),
paramRequestParametersJSON.GetSQLQuotedValueForAdd(),
paramExceptionMessage.GetSQLQuotedValueForAdd(),
paramStackTrace.GetSQLQuotedValueForAdd(),
paramIsResolved.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramAbsoluteURL.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pTraceID,
String pExceptionMessage,
Boolean pIsResolved,
DateTime pCreatedAt,
String pAbsoluteURL,
String pIPAddress,
Object pRequestParametersJSON= null,
Object pStackTrace= null,
Object pComments= null,
Object pUpdatedAt= null,
Object pUserID= null){

        try{

DataColumnParameter paramTraceID = new DataColumnParameter(defTraceID, pTraceID);
DataColumnParameter paramRequestParametersJSON = new DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON);
DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
DataColumnParameter paramStackTrace = new DataColumnParameter(defStackTrace, pStackTrace);
DataColumnParameter paramIsResolved = new DataColumnParameter(defIsResolved, pIsResolved);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramAbsoluteURL = new DataColumnParameter(defAbsoluteURL, pAbsoluteURL);
DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) ", TABLE_NAME,paramTraceID.GetSQLQuotedValueForAdd(),
paramRequestParametersJSON.GetSQLQuotedValueForAdd(),
paramExceptionMessage.GetSQLQuotedValueForAdd(),
paramStackTrace.GetSQLQuotedValueForAdd(),
paramIsResolved.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramAbsoluteURL.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd()  ), true);


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
Object pTraceID = null,
Object pExceptionMessage = null,
Object pIsResolved = null,
Object pCreatedAt = null,
Object pAbsoluteURL = null,
Object pIPAddress = null,
Object pRequestParametersJSON = null,
Object pStackTrace = null,
Object pComments = null,
Object pUpdatedAt = null,
Object pUserID = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramTraceID = new DataColumnParameter(defTraceID, pTraceID);
 DataColumnParameter paramRequestParametersJSON = new DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON);
 DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
 DataColumnParameter paramStackTrace = new DataColumnParameter(defStackTrace, pStackTrace);
 DataColumnParameter paramIsResolved = new DataColumnParameter(defIsResolved, pIsResolved);
 DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramAbsoluteURL = new DataColumnParameter(defAbsoluteURL, pAbsoluteURL);
 DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
 DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [TraceID]={2},[RequestParametersJSON]={3},[ExceptionMessage]={4},[StackTrace]={5},[IsResolved]={6},[Comments]={7},[CreatedAt]={8},[UpdatedAt]={9},[AbsoluteURL]={10},[IPAddress]={11},[UserID]={12} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramTraceID.GetSQLQuotedValueForUpdate(),
paramRequestParametersJSON.GetSQLQuotedValueForUpdate(),
paramExceptionMessage.GetSQLQuotedValueForUpdate(),
paramStackTrace.GetSQLQuotedValueForUpdate(),
paramIsResolved.GetSQLQuotedValueForUpdate(),
paramComments.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramAbsoluteURL.GetSQLQuotedValueForUpdate(),
paramIPAddress.GetSQLQuotedValueForUpdate(),
paramUserID.GetSQLQuotedValueForUpdate()  ), true);


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
