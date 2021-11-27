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

    public class T___RequestMonitor : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___RequestMonitor()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defAbsoluteURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AbsoluteURL.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestParametersJSON = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RequestParametersJSON.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IPAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionVariables = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SessionVariables.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBrowser = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Browser.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestBody = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RequestBody.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestHeaders = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RequestHeaders.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defAbsoluteURL.ColumnName, defAbsoluteURL); 
          ColumnDefns.Add(defRequestParametersJSON.ColumnName, defRequestParametersJSON); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defSessionVariables.ColumnName, defSessionVariables); 
          ColumnDefns.Add(defBrowser.ColumnName, defBrowser); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defRequestBody.ColumnName, defRequestBody); 
          ColumnDefns.Add(defRequestHeaders.ColumnName, defRequestHeaders); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_RequestMonitor_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.RequestMonitor", "auth.Users"                  
                            ));                  

          }


                  
       public T___RequestMonitor() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___RequestMonitor(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___RequestMonitor(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___RequestMonitor(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.RequestMonitor";
       public const string RequestMonitor__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [AbsoluteURL], [RequestParametersJSON], [IPAddress], [SessionVariables], [Browser], [UserID], [CreatedAt], [RequestBody], [RequestHeaders] FROM RequestMonitor";
       public const string RequestMonitor__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [AbsoluteURL], [RequestParametersJSON], [IPAddress], [SessionVariables], [Browser], [UserID], [CreatedAt], [RequestBody], [RequestHeaders] FROM RequestMonitor";


       public enum TableColumnNames
       {

           ID,
           AbsoluteURL,
           RequestParametersJSON,
           IPAddress,
           SessionVariables,
           Browser,
           UserID,
           CreatedAt,
           RequestBody,
           RequestHeaders
       } 



       public enum TableConstraints{

           pk_system_RequestMonitor, 
           fk_system_RequestMonitor_UserID, 
       } 


 #endregion 




 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defAbsoluteURL;
       public static readonly DataColumnDefinition defRequestParametersJSON;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defSessionVariables;
       public static readonly DataColumnDefinition defBrowser;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defRequestBody;
       public static readonly DataColumnDefinition defRequestHeaders;

       public String AbsoluteURL {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AbsoluteURL.ToString()]);
           }
       }


       public String RequestParametersJSON {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.RequestParametersJSON.ToString()]);
           }
       }


       public String IPAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IPAddress.ToString()]);
           }
       }


       public String SessionVariables {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.SessionVariables.ToString()]);
           }
       }


       public String Browser {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Browser.ToString()]);
           }
       }


       public Int32 UserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UserID.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public String RequestBody {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.RequestBody.ToString()]);
           }
       }


       public String RequestHeaders {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.RequestHeaders.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___RequestMonitor GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___RequestMonitor GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___RequestMonitor GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___RequestMonitor(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___RequestMonitor GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => RequestMonitor__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pUserID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramAbsoluteURL = new DataColumnParameter(defAbsoluteURL, defAbsoluteURL.DefaultValue);
                DataColumnParameter paramRequestParametersJSON = new DataColumnParameter(defRequestParametersJSON, defRequestParametersJSON.DefaultValue);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, defIPAddress.DefaultValue);
                DataColumnParameter paramSessionVariables = new DataColumnParameter(defSessionVariables, defSessionVariables.DefaultValue);
                DataColumnParameter paramBrowser = new DataColumnParameter(defBrowser, defBrowser.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramRequestBody = new DataColumnParameter(defRequestBody, defRequestBody.DefaultValue);
                DataColumnParameter paramRequestHeaders = new DataColumnParameter(defRequestHeaders, defRequestHeaders.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AbsoluteURL],[RequestParametersJSON],[IPAddress],[SessionVariables],[Browser],[UserID],[CreatedAt],[RequestBody],[RequestHeaders]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramAbsoluteURL.GetSQLQuotedValueForAdd(),
                paramRequestParametersJSON.GetSQLQuotedValueForAdd(),
                paramIPAddress.GetSQLQuotedValueForAdd(),
                paramSessionVariables.GetSQLQuotedValueForAdd(),
                paramBrowser.GetSQLQuotedValueForAdd(),
                paramUserID.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramRequestBody.GetSQLQuotedValueForAdd(),
                paramRequestHeaders.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pAbsoluteURL,
String pIPAddress,
DateTime pCreatedAt,
Object pRequestParametersJSON = null,
Object pSessionVariables = null,
Object pBrowser = null,
Object pUserID = null,
Object pRequestBody = null,
Object pRequestHeaders = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramAbsoluteURL = new DataColumnParameter(defAbsoluteURL, pAbsoluteURL);
                DataColumnParameter paramRequestParametersJSON = new DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
                DataColumnParameter paramSessionVariables = new DataColumnParameter(defSessionVariables, pSessionVariables);
                DataColumnParameter paramBrowser = new DataColumnParameter(defBrowser, pBrowser);
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramRequestBody = new DataColumnParameter(defRequestBody, pRequestBody);
                DataColumnParameter paramRequestHeaders = new DataColumnParameter(defRequestHeaders, pRequestHeaders);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AbsoluteURL],[RequestParametersJSON],[IPAddress],[SessionVariables],[Browser],[UserID],[CreatedAt],[RequestBody],[RequestHeaders]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramAbsoluteURL.GetSQLQuotedValueForAdd(),
paramRequestParametersJSON.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramSessionVariables.GetSQLQuotedValueForAdd(),
paramBrowser.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramRequestBody.GetSQLQuotedValueForAdd(),
paramRequestHeaders.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pAbsoluteURL,
String pIPAddress,
DateTime pCreatedAt,
Object pRequestParametersJSON = null,
Object pSessionVariables = null,
Object pBrowser = null,
Object pUserID = null,
Object pRequestBody = null,
Object pRequestHeaders = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramAbsoluteURL = new DataColumnParameter(defAbsoluteURL, pAbsoluteURL);
DataColumnParameter paramRequestParametersJSON = new DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON);
DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
DataColumnParameter paramSessionVariables = new DataColumnParameter(defSessionVariables, pSessionVariables);
DataColumnParameter paramBrowser = new DataColumnParameter(defBrowser, pBrowser);
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramRequestBody = new DataColumnParameter(defRequestBody, pRequestBody);
DataColumnParameter paramRequestHeaders = new DataColumnParameter(defRequestHeaders, pRequestHeaders);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AbsoluteURL],[RequestParametersJSON],[IPAddress],[SessionVariables],[Browser],[UserID],[CreatedAt],[RequestBody],[RequestHeaders]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramAbsoluteURL.GetSQLQuotedValueForAdd(),
paramRequestParametersJSON.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramSessionVariables.GetSQLQuotedValueForAdd(),
paramBrowser.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramRequestBody.GetSQLQuotedValueForAdd(),
paramRequestHeaders.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pAbsoluteURL,
String pIPAddress,
DateTime pCreatedAt,
Object pRequestParametersJSON= null,
Object pSessionVariables= null,
Object pBrowser= null,
Object pUserID= null,
Object pRequestBody= null,
Object pRequestHeaders= null){

        try{

DataColumnParameter paramAbsoluteURL = new DataColumnParameter(defAbsoluteURL, pAbsoluteURL);
DataColumnParameter paramRequestParametersJSON = new DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON);
DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
DataColumnParameter paramSessionVariables = new DataColumnParameter(defSessionVariables, pSessionVariables);
DataColumnParameter paramBrowser = new DataColumnParameter(defBrowser, pBrowser);
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramRequestBody = new DataColumnParameter(defRequestBody, pRequestBody);
DataColumnParameter paramRequestHeaders = new DataColumnParameter(defRequestHeaders, pRequestHeaders);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([AbsoluteURL],[RequestParametersJSON],[IPAddress],[SessionVariables],[Browser],[UserID],[CreatedAt],[RequestBody],[RequestHeaders]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) ", TABLE_NAME,paramAbsoluteURL.GetSQLQuotedValueForAdd(),
paramRequestParametersJSON.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramSessionVariables.GetSQLQuotedValueForAdd(),
paramBrowser.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramRequestBody.GetSQLQuotedValueForAdd(),
paramRequestHeaders.GetSQLQuotedValueForAdd()  ), true);


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
Object pAbsoluteURL = null,
Object pIPAddress = null,
Object pCreatedAt = null,
Object pRequestParametersJSON = null,
Object pSessionVariables = null,
Object pBrowser = null,
Object pUserID = null,
Object pRequestBody = null,
Object pRequestHeaders = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramAbsoluteURL = new DataColumnParameter(defAbsoluteURL, pAbsoluteURL);
 DataColumnParameter paramRequestParametersJSON = new DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON);
 DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
 DataColumnParameter paramSessionVariables = new DataColumnParameter(defSessionVariables, pSessionVariables);
 DataColumnParameter paramBrowser = new DataColumnParameter(defBrowser, pBrowser);
 DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramRequestBody = new DataColumnParameter(defRequestBody, pRequestBody);
 DataColumnParameter paramRequestHeaders = new DataColumnParameter(defRequestHeaders, pRequestHeaders);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [AbsoluteURL]={2},[RequestParametersJSON]={3},[IPAddress]={4},[SessionVariables]={5},[Browser]={6},[UserID]={7},[CreatedAt]={8},[RequestBody]={9},[RequestHeaders]={10} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramAbsoluteURL.GetSQLQuotedValueForUpdate(),
paramRequestParametersJSON.GetSQLQuotedValueForUpdate(),
paramIPAddress.GetSQLQuotedValueForUpdate(),
paramSessionVariables.GetSQLQuotedValueForUpdate(),
paramBrowser.GetSQLQuotedValueForUpdate(),
paramUserID.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramRequestBody.GetSQLQuotedValueForUpdate(),
paramRequestHeaders.GetSQLQuotedValueForUpdate()  ), true);


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
