using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using ELibrary.Standard.VB.Modules;                  
using EEntityCore.DB.MSSQL.Schemas;                  
using EEntityCore.DB.MSSQL;                  
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
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSessionID = new DataColumnDefinition(TableColumnNames.SessionID.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTimedOut = new DataColumnDefinition(TableColumnNames.TimedOut.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWebURL = new DataColumnDefinition(TableColumnNames.WebURL.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPage = new DataColumnDefinition(TableColumnNames.Page.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCheckedOutTime = new DataColumnDefinition(TableColumnNames.CheckedOutTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRoleID = new DataColumnDefinition(TableColumnNames.RoleID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


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
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserVisitedPage(DataTable FullTable) : base(FullTable)                                    
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
       public const string UserVisitedPage__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [UserID], [SessionID], [IPAddress], [TimedOut], [WebURL], [Page], [CheckedOutTime], [RoleID], [CreatedAt] FROM auth.UserVisitedPage";
       public const string UserVisitedPage__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [UserID], [SessionID], [IPAddress], [TimedOut], [WebURL], [Page], [CheckedOutTime], [RoleID], [CreatedAt] FROM auth.UserVisitedPage";


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

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public int UserID { get => (int)TargettedRow[TableColumnNames.UserID.ToString()]; }


       public string SessionID { get => (string)TargettedRow[TableColumnNames.SessionID.ToString()]; }


       public string IPAddress { get => (string)TargettedRow[TableColumnNames.IPAddress.ToString()]; }


       public bool TimedOut { get => (bool)TargettedRow[TableColumnNames.TimedOut.ToString()]; }


       public string WebURL { get => (string)TargettedRow[TableColumnNames.WebURL.ToString()]; }


       public string Page { get => (string)TargettedRow[TableColumnNames.Page.ToString()]; }


       public DateTime? CheckedOutTime { get => (DateTime?)TargettedRow[TableColumnNames.CheckedOutTime.ToString()]; }


       public int RoleID { get => (int)TargettedRow[TableColumnNames.RoleID.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


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
                                                                        
        public static T___UserVisitedPage GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___UserVisitedPage(conn.Fetch(UserVisitedPage__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___UserVisitedPage GetRowWhereIDUsingSQL(int pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___UserVisitedPage( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___UserVisitedPage GetRowWhereID(int pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => UserVisitedPage__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int UserID,
            string SessionID,
            string IPAddress,
            bool TimedOut,
            string WebURL,
            string Page,
            int RoleID,
            DateTime CreatedAt,
            DateTime? CheckedOutTime = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramSessionID = new (defSessionID, SessionID);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramTimedOut = new (defTimedOut, TimedOut);
                DataColumnParameter paramWebURL = new (defWebURL, WebURL);
                DataColumnParameter paramPage = new (defPage, Page);
                DataColumnParameter paramCheckedOutTime = new (defCheckedOutTime, CheckedOutTime);
                DataColumnParameter paramRoleID = new (defRoleID, RoleID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([UserID],[SessionID],[IPAddress],[TimedOut],[WebURL],[Page],[CheckedOutTime],[RoleID],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramUserID.GetSQLQuotedValueForAdd(),
                        paramSessionID.GetSQLQuotedValueForAdd(),
                        paramIPAddress.GetSQLQuotedValueForAdd(),
                        paramTimedOut.GetSQLQuotedValueForAdd(),
                        paramWebURL.GetSQLQuotedValueForAdd(),
                        paramPage.GetSQLQuotedValueForAdd(),
                        paramCheckedOutTime.GetSQLQuotedValueForAdd(),
                        paramRoleID.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd()                        )
                    );
                         
                return conn.GetScopeIdentity().ToLong();
            });

        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool AddWithID(
            int ID,
            int UserID,
            string SessionID,
            string IPAddress,
            bool TimedOut,
            string WebURL,
            string Page,
            int RoleID,
            DateTime CreatedAt,
            DateTime? CheckedOutTime = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramSessionID = new (defSessionID, SessionID);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramTimedOut = new (defTimedOut, TimedOut);
                DataColumnParameter paramWebURL = new (defWebURL, WebURL);
                DataColumnParameter paramPage = new (defPage, Page);
                DataColumnParameter paramCheckedOutTime = new (defCheckedOutTime, CheckedOutTime);
                DataColumnParameter paramRoleID = new (defRoleID, RoleID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[SessionID],[IPAddress],[TimedOut],[WebURL],[Page],[CheckedOutTime],[RoleID],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramUserID.GetSQLQuotedValueForAdd(),
                        paramSessionID.GetSQLQuotedValueForAdd(),
                        paramIPAddress.GetSQLQuotedValueForAdd(),
                        paramTimedOut.GetSQLQuotedValueForAdd(),
                        paramWebURL.GetSQLQuotedValueForAdd(),
                        paramPage.GetSQLQuotedValueForAdd(),
                        paramCheckedOutTime.GetSQLQuotedValueForAdd(),
                        paramRoleID.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int UserID,
            string SessionID,
            string IPAddress,
            bool TimedOut,
            string WebURL,
            string Page,
            int RoleID,
            DateTime CreatedAt,
            DateTime? CheckedOutTime = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramSessionID = new (defSessionID, SessionID);
                DataColumnParameter paramIPAddress = new (defIPAddress, IPAddress);
                DataColumnParameter paramTimedOut = new (defTimedOut, TimedOut);
                DataColumnParameter paramWebURL = new (defWebURL, WebURL);
                DataColumnParameter paramPage = new (defPage, Page);
                DataColumnParameter paramCheckedOutTime = new (defCheckedOutTime, CheckedOutTime);
                DataColumnParameter paramRoleID = new (defRoleID, RoleID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([UserID],[SessionID],[IPAddress],[TimedOut],[WebURL],[Page],[CheckedOutTime],[RoleID],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramUserID.GetSQLQuotedValueForAdd(),
                        paramSessionID.GetSQLQuotedValueForAdd(),
                        paramIPAddress.GetSQLQuotedValueForAdd(),
                        paramTimedOut.GetSQLQuotedValueForAdd(),
                        paramWebURL.GetSQLQuotedValueForAdd(),
                        paramPage.GetSQLQuotedValueForAdd(),
                        paramCheckedOutTime.GetSQLQuotedValueForAdd(),
                        paramRoleID.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd()                            
                            )
                        ).ToBoolean()
                    );


        }                  


                  
                  
        /// <summary>                  
        /// Deletes with an option to pass in transaction                  
        /// </summary>                  
        /// <returns></returns>                  
        /// <remarks></remarks>                  
        public bool DeleteRow(DBTransaction transaction = null)                  
        {                  
            return DeleteItemRow(ID, transaction);                  
        }                  
                  
        public static bool DeleteItemRow(long pID, DBTransaction transaction = null)                                                      
        {                  
            return TransactionRunner.InvokeRun(                  
               (conn) => conn.ExecuteTransactionQuery($"DELETE FROM {TABLE_NAME} WHERE ID={pID} ").ToBoolean(),                  
               transaction                  
               );                  
        }                  



   }


}
