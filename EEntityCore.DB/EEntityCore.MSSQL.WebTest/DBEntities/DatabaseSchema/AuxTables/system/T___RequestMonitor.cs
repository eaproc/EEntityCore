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
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defAbsoluteURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AbsoluteURL.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestParametersJSON = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RequestParametersJSON.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IPAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionVariables = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SessionVariables.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBrowser = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Browser.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestBody = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RequestBody.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestHeaders = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RequestHeaders.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public string AbsoluteURL { get => (string)TargettedRow[TableColumnNames.AbsoluteURL.ToString()]; }


       public string RequestParametersJSON { get => (string)TargettedRow[TableColumnNames.RequestParametersJSON.ToString()]; }


       public string IPAddress { get => (string)TargettedRow[TableColumnNames.IPAddress.ToString()]; }


       public string SessionVariables { get => (string)TargettedRow[TableColumnNames.SessionVariables.ToString()]; }


       public string Browser { get => (string)TargettedRow[TableColumnNames.Browser.ToString()]; }


       public int? UserID { get => (int?)TargettedRow[TableColumnNames.UserID.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public string RequestBody { get => (string)TargettedRow[TableColumnNames.RequestBody.ToString()]; }


       public string RequestHeaders { get => (string)TargettedRow[TableColumnNames.RequestHeaders.ToString()]; }


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
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int ID,
            string AbsoluteURL,
            string IPAddress,
            DateTime CreatedAt,
            string RequestParametersJSON = null,
            string SessionVariables = null,
            string Browser = null,
            int? UserID = null,
            string RequestBody = null,
            string RequestHeaders = null
          ){

            try{

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramAbsoluteURL = new (defAbsoluteURL, AbsoluteURL);
                DataColumnParameter paramRequestParametersJSON = new (defRequestParametersJSON, RequestParametersJSON);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramSessionVariables = new (defSessionVariables, SessionVariables);
                DataColumnParameter paramBrowser = new (defBrowser, Browser);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramRequestBody = new (defRequestBody, RequestBody);
                DataColumnParameter paramRequestHeaders = new (defRequestHeaders, RequestHeaders);


                return DBConnectInterface.GetDBConn().DbExec(
     string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AbsoluteURL],[RequestParametersJSON],[IPAddress],[SessionVariables],[Browser],[UserID],[CreatedAt],[RequestBody],[RequestHeaders]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramAbsoluteURL.GetSQLQuotedValueForAdd(),
                        paramRequestParametersJSON.GetSQLQuotedValueForAdd(),
                        paramIPAddress.GetSQLQuotedValueForAdd(),
                        paramSessionVariables.GetSQLQuotedValueForAdd(),
                        paramBrowser.GetSQLQuotedValueForAdd(),
                        paramUserID.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramRequestBody.GetSQLQuotedValueForAdd(),
                        paramRequestHeaders.GetSQLQuotedValueForAdd()                        ) 
                      );


                  
                  
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
