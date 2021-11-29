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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.system                  
{                  

    public class T___ClientConnection : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ClientConnection()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defFileServerUrl = new DataColumnDefinition(TableColumnNames.FileServerUrl.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerAccessKey = new DataColumnDefinition(TableColumnNames.FileServerAccessKey.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerSecretKey = new DataColumnDefinition(TableColumnNames.FileServerSecretKey.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerBucket = new DataColumnDefinition(TableColumnNames.FileServerBucket.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientAPIID = new DataColumnDefinition(TableColumnNames.ClientAPIID.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientAPIUrl = new DataColumnDefinition(TableColumnNames.ClientAPIUrl.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_HOST = new DataColumnDefinition(TableColumnNames.DB_HOST.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_DATABASE = new DataColumnDefinition(TableColumnNames.DB_DATABASE.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_USERNAME = new DataColumnDefinition(TableColumnNames.DB_USERNAME.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_PASSWORD = new DataColumnDefinition(TableColumnNames.DB_PASSWORD.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_PORT = new DataColumnDefinition(TableColumnNames.DB_PORT.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerUrlHttps = new DataColumnDefinition(TableColumnNames.FileServerUrlHttps.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defFileServerUrl.ColumnName, defFileServerUrl); 
          ColumnDefns.Add(defFileServerAccessKey.ColumnName, defFileServerAccessKey); 
          ColumnDefns.Add(defFileServerSecretKey.ColumnName, defFileServerSecretKey); 
          ColumnDefns.Add(defFileServerBucket.ColumnName, defFileServerBucket); 
          ColumnDefns.Add(defClientAPIID.ColumnName, defClientAPIID); 
          ColumnDefns.Add(defClientAPIUrl.ColumnName, defClientAPIUrl); 
          ColumnDefns.Add(defDB_HOST.ColumnName, defDB_HOST); 
          ColumnDefns.Add(defDB_DATABASE.ColumnName, defDB_DATABASE); 
          ColumnDefns.Add(defDB_USERNAME.ColumnName, defDB_USERNAME); 
          ColumnDefns.Add(defDB_PASSWORD.ColumnName, defDB_PASSWORD); 
          ColumnDefns.Add(defDB_PORT.ColumnName, defDB_PORT); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defFileServerUrlHttps.ColumnName, defFileServerUrlHttps); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_ClientConnection_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.ClientConnection", "hr.Client"                  
                            ));                  

          }


                  
       public T___ClientConnection() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ClientConnection(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientConnection(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___ClientConnection(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.ClientConnection";
       public const string ClientConnection__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [FileServerUrl], [FileServerAccessKey], [FileServerSecretKey], [FileServerBucket], [ClientAPIID], [ClientAPIUrl], [DB_HOST], [DB_DATABASE], [DB_USERNAME], [DB_PASSWORD], [DB_PORT], [CreatedAt], [UpdatedAt], [FileServerUrlHttps] FROM ClientConnection";
       public const string ClientConnection__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [FileServerUrl], [FileServerAccessKey], [FileServerSecretKey], [FileServerBucket], [ClientAPIID], [ClientAPIUrl], [DB_HOST], [DB_DATABASE], [DB_USERNAME], [DB_PASSWORD], [DB_PORT], [CreatedAt], [UpdatedAt], [FileServerUrlHttps] FROM ClientConnection";


       public enum TableColumnNames
       {

           ID,
           ClientID,
           FileServerUrl,
           FileServerAccessKey,
           FileServerSecretKey,
           FileServerBucket,
           ClientAPIID,
           ClientAPIUrl,
           DB_HOST,
           DB_DATABASE,
           DB_USERNAME,
           DB_PASSWORD,
           DB_PORT,
           CreatedAt,
           UpdatedAt,
           FileServerUrlHttps
       } 



       public enum TableConstraints{

           pk_system_ClientConnection, 
           fk_system_ClientConnection_ClientID, 
           uq_system_ClientConnection_ClientID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defFileServerUrl;
       public static readonly DataColumnDefinition defFileServerAccessKey;
       public static readonly DataColumnDefinition defFileServerSecretKey;
       public static readonly DataColumnDefinition defFileServerBucket;
       public static readonly DataColumnDefinition defClientAPIID;
       public static readonly DataColumnDefinition defClientAPIUrl;
       public static readonly DataColumnDefinition defDB_HOST;
       public static readonly DataColumnDefinition defDB_DATABASE;
       public static readonly DataColumnDefinition defDB_USERNAME;
       public static readonly DataColumnDefinition defDB_PASSWORD;
       public static readonly DataColumnDefinition defDB_PORT;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defFileServerUrlHttps;

       public int ClientID { get => (int)TargettedRow[TableColumnNames.ClientID.ToString()]; }


       public string FileServerUrl { get => (string)TargettedRow[TableColumnNames.FileServerUrl.ToString()]; }


       public string FileServerAccessKey { get => (string)TargettedRow[TableColumnNames.FileServerAccessKey.ToString()]; }


       public string FileServerSecretKey { get => (string)TargettedRow[TableColumnNames.FileServerSecretKey.ToString()]; }


       public string FileServerBucket { get => (string)TargettedRow[TableColumnNames.FileServerBucket.ToString()]; }


       public string ClientAPIID { get => (string)TargettedRow[TableColumnNames.ClientAPIID.ToString()]; }


       public string ClientAPIUrl { get => (string)TargettedRow[TableColumnNames.ClientAPIUrl.ToString()]; }


       public string DB_HOST { get => (string)TargettedRow[TableColumnNames.DB_HOST.ToString()]; }


       public string DB_DATABASE { get => (string)TargettedRow[TableColumnNames.DB_DATABASE.ToString()]; }


       public string DB_USERNAME { get => (string)TargettedRow[TableColumnNames.DB_USERNAME.ToString()]; }


       public string DB_PASSWORD { get => (string)TargettedRow[TableColumnNames.DB_PASSWORD.ToString()]; }


       public int DB_PORT { get => (int)TargettedRow[TableColumnNames.DB_PORT.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


       public string FileServerUrlHttps { get => (string)TargettedRow[TableColumnNames.FileServerUrlHttps.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___ClientConnection GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___ClientConnection GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___ClientConnection GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___ClientConnection(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___ClientConnection GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => ClientConnection__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int ClientID,
            string FileServerUrl,
            string FileServerAccessKey,
            string FileServerSecretKey,
            string FileServerBucket,
            string ClientAPIID,
            string ClientAPIUrl,
            string DB_HOST,
            string DB_DATABASE,
            string DB_USERNAME,
            string DB_PASSWORD,
            int DB_PORT,
            DateTime CreatedAt,
            string FileServerUrlHttps,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramFileServerUrl = new (defFileServerUrl, FileServerUrl);
                DataColumnParameter paramFileServerAccessKey = new (defFileServerAccessKey, FileServerAccessKey);
                DataColumnParameter paramFileServerSecretKey = new (defFileServerSecretKey, FileServerSecretKey);
                DataColumnParameter paramFileServerBucket = new (defFileServerBucket, FileServerBucket);
                DataColumnParameter paramClientAPIID = new (defClientAPIID, ClientAPIID);
                DataColumnParameter paramClientAPIUrl = new (defClientAPIUrl, ClientAPIUrl);
                DataColumnParameter paramDB_HOST = new (defDB_HOST, DB_HOST);
                DataColumnParameter paramDB_DATABASE = new (defDB_DATABASE, DB_DATABASE);
                DataColumnParameter paramDB_USERNAME = new (defDB_USERNAME, DB_USERNAME);
                DataColumnParameter paramDB_PASSWORD = new (defDB_PASSWORD, DB_PASSWORD);
                DataColumnParameter paramDB_PORT = new (defDB_PORT, DB_PORT);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramFileServerUrlHttps = new (defFileServerUrlHttps, FileServerUrlHttps);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15})  ", TABLE_NAME,
                        paramClientID.GetSQLQuotedValueForAdd(),
                        paramFileServerUrl.GetSQLQuotedValueForAdd(),
                        paramFileServerAccessKey.GetSQLQuotedValueForAdd(),
                        paramFileServerSecretKey.GetSQLQuotedValueForAdd(),
                        paramFileServerBucket.GetSQLQuotedValueForAdd(),
                        paramClientAPIID.GetSQLQuotedValueForAdd(),
                        paramClientAPIUrl.GetSQLQuotedValueForAdd(),
                        paramDB_HOST.GetSQLQuotedValueForAdd(),
                        paramDB_DATABASE.GetSQLQuotedValueForAdd(),
                        paramDB_USERNAME.GetSQLQuotedValueForAdd(),
                        paramDB_PASSWORD.GetSQLQuotedValueForAdd(),
                        paramDB_PORT.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramFileServerUrlHttps.GetSQLQuotedValueForAdd()                        )
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
            int ClientID,
            string FileServerUrl,
            string FileServerAccessKey,
            string FileServerSecretKey,
            string FileServerBucket,
            string ClientAPIID,
            string ClientAPIUrl,
            string DB_HOST,
            string DB_DATABASE,
            string DB_USERNAME,
            string DB_PASSWORD,
            int DB_PORT,
            DateTime CreatedAt,
            string FileServerUrlHttps,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramClientID = new (defClientID, ClientID);
                DataColumnParameter paramFileServerUrl = new (defFileServerUrl, FileServerUrl);
                DataColumnParameter paramFileServerAccessKey = new (defFileServerAccessKey, FileServerAccessKey);
                DataColumnParameter paramFileServerSecretKey = new (defFileServerSecretKey, FileServerSecretKey);
                DataColumnParameter paramFileServerBucket = new (defFileServerBucket, FileServerBucket);
                DataColumnParameter paramClientAPIID = new (defClientAPIID, ClientAPIID);
                DataColumnParameter paramClientAPIUrl = new (defClientAPIUrl, ClientAPIUrl);
                DataColumnParameter paramDB_HOST = new (defDB_HOST, DB_HOST);
                DataColumnParameter paramDB_DATABASE = new (defDB_DATABASE, DB_DATABASE);
                DataColumnParameter paramDB_USERNAME = new (defDB_USERNAME, DB_USERNAME);
                DataColumnParameter paramDB_PASSWORD = new (defDB_PASSWORD, DB_PASSWORD);
                DataColumnParameter paramDB_PORT = new (defDB_PORT, DB_PORT);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramFileServerUrlHttps = new (defFileServerUrlHttps, FileServerUrlHttps);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramClientID.GetSQLQuotedValueForAdd(),
                        paramFileServerUrl.GetSQLQuotedValueForAdd(),
                        paramFileServerAccessKey.GetSQLQuotedValueForAdd(),
                        paramFileServerSecretKey.GetSQLQuotedValueForAdd(),
                        paramFileServerBucket.GetSQLQuotedValueForAdd(),
                        paramClientAPIID.GetSQLQuotedValueForAdd(),
                        paramClientAPIUrl.GetSQLQuotedValueForAdd(),
                        paramDB_HOST.GetSQLQuotedValueForAdd(),
                        paramDB_DATABASE.GetSQLQuotedValueForAdd(),
                        paramDB_USERNAME.GetSQLQuotedValueForAdd(),
                        paramDB_PASSWORD.GetSQLQuotedValueForAdd(),
                        paramDB_PORT.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramFileServerUrlHttps.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
