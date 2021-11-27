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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.auth                  
{                  

    public class T___UserVisitedPage : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___UserVisitedPage()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSessionID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SessionID.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IPAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTimedOut = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TimedOut.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWebURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.WebURL.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPage = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Page.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCheckedOutTime = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CheckedOutTime.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRoleID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RoleID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defSessionID.ColumnName, defSessionID); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defTimedOut.ColumnName, defTimedOut); 
          ColumnDefns.Add(defWebURL.ColumnName, defWebURL); 
          ColumnDefns.Add(defPage.ColumnName, defPage); 
          ColumnDefns.Add(defCheckedOutTime.ColumnName, defCheckedOutTime); 
          ColumnDefns.Add(defRoleID.ColumnName, defRoleID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_UserVisitedPage_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "auth.UserVisitedPage", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_UserVisitedPage_RoleID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.UserVisitedPage", "auth.Role"                  
                            ));                  

          }


                  
       public T___UserVisitedPage() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserVisitedPage(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserVisitedPage(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserVisitedPage(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserVisitedPage(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___UserVisitedPage(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserVisitedPage(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserVisitedPage(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserVisitedPage(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___UserVisitedPage(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.UserVisitedPage";
       public const string UserVisitedPage__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [UserID], [SessionID], [IPAddress], [TimedOut], [WebURL], [Page], [CheckedOutTime], [RoleID], [CreatedAt] FROM UserVisitedPage";
       public const string UserVisitedPage__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [UserID], [SessionID], [IPAddress], [TimedOut], [WebURL], [Page], [CheckedOutTime], [RoleID], [CreatedAt] FROM UserVisitedPage";


       public enum TableColumnNames
       {

           ID,
           UserID,
           SessionID,
           IPAddress,
           TimedOut,
           WebURL,
           Page,
           CheckedOutTime,
           RoleID,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_auth_UserVisitedPage, 
           fk_auth_UserVisitedPage_UserID, 
           fk_auth_UserVisitedPage_RoleID, 
       } 


 #endregion 




 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defSessionID;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defTimedOut;
       public static readonly DataColumnDefinition defWebURL;
       public static readonly DataColumnDefinition defPage;
       public static readonly DataColumnDefinition defCheckedOutTime;
       public static readonly DataColumnDefinition defRoleID;
       public static readonly DataColumnDefinition defCreatedAt;

       public Int32 UserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UserID.ToString()]);
           }
       }


       public String SessionID {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.SessionID.ToString()]);
           }
       }


       public String IPAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IPAddress.ToString()]);
           }
       }


       public Boolean TimedOut {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.TimedOut.ToString()]);
           }
       }


       public String WebURL {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.WebURL.ToString()]);
           }
       }


       public String Page {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Page.ToString()]);
           }
       }


       public NullableDateTime CheckedOutTime {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CheckedOutTime.ToString()]);
           }
       }


       public Int32 RoleID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.RoleID.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___UserVisitedPage GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___UserVisitedPage GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___UserVisitedPage GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___UserVisitedPage(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___UserVisitedPage GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => UserVisitedPage__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pUserID,
Int32 pRoleID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramRoleID = new DataColumnParameter(defRoleID, pRoleID);
                DataColumnParameter paramSessionID = new DataColumnParameter(defSessionID, defSessionID.DefaultValue);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, defIPAddress.DefaultValue);
                DataColumnParameter paramTimedOut = new DataColumnParameter(defTimedOut, defTimedOut.DefaultValue);
                DataColumnParameter paramWebURL = new DataColumnParameter(defWebURL, defWebURL.DefaultValue);
                DataColumnParameter paramPage = new DataColumnParameter(defPage, defPage.DefaultValue);
                DataColumnParameter paramCheckedOutTime = new DataColumnParameter(defCheckedOutTime, defCheckedOutTime.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[SessionID],[IPAddress],[TimedOut],[WebURL],[Page],[CheckedOutTime],[RoleID],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramUserID.GetSQLQuotedValueForAdd(),
                paramSessionID.GetSQLQuotedValueForAdd(),
                paramIPAddress.GetSQLQuotedValueForAdd(),
                paramTimedOut.GetSQLQuotedValueForAdd(),
                paramWebURL.GetSQLQuotedValueForAdd(),
                paramPage.GetSQLQuotedValueForAdd(),
                paramCheckedOutTime.GetSQLQuotedValueForAdd(),
                paramRoleID.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pUserID,
String pSessionID,
String pIPAddress,
Boolean pTimedOut,
String pWebURL,
String pPage,
Int32 pRoleID,
DateTime pCreatedAt,
Object pCheckedOutTime = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramSessionID = new DataColumnParameter(defSessionID, pSessionID);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
                DataColumnParameter paramTimedOut = new DataColumnParameter(defTimedOut, pTimedOut);
                DataColumnParameter paramWebURL = new DataColumnParameter(defWebURL, pWebURL);
                DataColumnParameter paramPage = new DataColumnParameter(defPage, pPage);
                DataColumnParameter paramCheckedOutTime = new DataColumnParameter(defCheckedOutTime, pCheckedOutTime);
                DataColumnParameter paramRoleID = new DataColumnParameter(defRoleID, pRoleID);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[SessionID],[IPAddress],[TimedOut],[WebURL],[Page],[CheckedOutTime],[RoleID],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramSessionID.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramTimedOut.GetSQLQuotedValueForAdd(),
paramWebURL.GetSQLQuotedValueForAdd(),
paramPage.GetSQLQuotedValueForAdd(),
paramCheckedOutTime.GetSQLQuotedValueForAdd(),
paramRoleID.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pUserID,
String pSessionID,
String pIPAddress,
Boolean pTimedOut,
String pWebURL,
String pPage,
Int32 pRoleID,
DateTime pCreatedAt,
Object pCheckedOutTime = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramSessionID = new DataColumnParameter(defSessionID, pSessionID);
DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
DataColumnParameter paramTimedOut = new DataColumnParameter(defTimedOut, pTimedOut);
DataColumnParameter paramWebURL = new DataColumnParameter(defWebURL, pWebURL);
DataColumnParameter paramPage = new DataColumnParameter(defPage, pPage);
DataColumnParameter paramCheckedOutTime = new DataColumnParameter(defCheckedOutTime, pCheckedOutTime);
DataColumnParameter paramRoleID = new DataColumnParameter(defRoleID, pRoleID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[SessionID],[IPAddress],[TimedOut],[WebURL],[Page],[CheckedOutTime],[RoleID],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramSessionID.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramTimedOut.GetSQLQuotedValueForAdd(),
paramWebURL.GetSQLQuotedValueForAdd(),
paramPage.GetSQLQuotedValueForAdd(),
paramCheckedOutTime.GetSQLQuotedValueForAdd(),
paramRoleID.GetSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pUserID,
String pSessionID,
String pIPAddress,
Boolean pTimedOut,
String pWebURL,
String pPage,
Int32 pRoleID,
DateTime pCreatedAt,
Object pCheckedOutTime= null){

        try{

DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramSessionID = new DataColumnParameter(defSessionID, pSessionID);
DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
DataColumnParameter paramTimedOut = new DataColumnParameter(defTimedOut, pTimedOut);
DataColumnParameter paramWebURL = new DataColumnParameter(defWebURL, pWebURL);
DataColumnParameter paramPage = new DataColumnParameter(defPage, pPage);
DataColumnParameter paramCheckedOutTime = new DataColumnParameter(defCheckedOutTime, pCheckedOutTime);
DataColumnParameter paramRoleID = new DataColumnParameter(defRoleID, pRoleID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([UserID],[SessionID],[IPAddress],[TimedOut],[WebURL],[Page],[CheckedOutTime],[RoleID],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) ", TABLE_NAME,paramUserID.GetSQLQuotedValueForAdd(),
paramSessionID.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramTimedOut.GetSQLQuotedValueForAdd(),
paramWebURL.GetSQLQuotedValueForAdd(),
paramPage.GetSQLQuotedValueForAdd(),
paramCheckedOutTime.GetSQLQuotedValueForAdd(),
paramRoleID.GetSQLQuotedValueForAdd(),
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
Object pUserID = null,
Object pSessionID = null,
Object pIPAddress = null,
Object pTimedOut = null,
Object pWebURL = null,
Object pPage = null,
Object pRoleID = null,
Object pCreatedAt = null,
Object pCheckedOutTime = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
 DataColumnParameter paramSessionID = new DataColumnParameter(defSessionID, pSessionID);
 DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
 DataColumnParameter paramTimedOut = new DataColumnParameter(defTimedOut, pTimedOut);
 DataColumnParameter paramWebURL = new DataColumnParameter(defWebURL, pWebURL);
 DataColumnParameter paramPage = new DataColumnParameter(defPage, pPage);
 DataColumnParameter paramCheckedOutTime = new DataColumnParameter(defCheckedOutTime, pCheckedOutTime);
 DataColumnParameter paramRoleID = new DataColumnParameter(defRoleID, pRoleID);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [UserID]={2},[SessionID]={3},[IPAddress]={4},[TimedOut]={5},[WebURL]={6},[Page]={7},[CheckedOutTime]={8},[RoleID]={9},[CreatedAt]={10} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramUserID.GetSQLQuotedValueForUpdate(),
paramSessionID.GetSQLQuotedValueForUpdate(),
paramIPAddress.GetSQLQuotedValueForUpdate(),
paramTimedOut.GetSQLQuotedValueForUpdate(),
paramWebURL.GetSQLQuotedValueForUpdate(),
paramPage.GetSQLQuotedValueForUpdate(),
paramCheckedOutTime.GetSQLQuotedValueForUpdate(),
paramRoleID.GetSQLQuotedValueForUpdate(),
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
