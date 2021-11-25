using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
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
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defFileServerUrl = new DataColumnDefinition(TableColumnNames.FileServerUrl.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerAccessKey = new DataColumnDefinition(TableColumnNames.FileServerAccessKey.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerSecretKey = new DataColumnDefinition(TableColumnNames.FileServerSecretKey.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerBucket = new DataColumnDefinition(TableColumnNames.FileServerBucket.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientAPIID = new DataColumnDefinition(TableColumnNames.ClientAPIID.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClientAPIUrl = new DataColumnDefinition(TableColumnNames.ClientAPIUrl.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_HOST = new DataColumnDefinition(TableColumnNames.DB_HOST.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_DATABASE = new DataColumnDefinition(TableColumnNames.DB_DATABASE.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_USERNAME = new DataColumnDefinition(TableColumnNames.DB_USERNAME.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_PASSWORD = new DataColumnDefinition(TableColumnNames.DB_PASSWORD.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDB_PORT = new DataColumnDefinition(TableColumnNames.DB_PORT.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFileServerUrlHttps = new DataColumnDefinition(TableColumnNames.FileServerUrlHttps.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public Int32 ClientID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ClientID.ToString()]);
           }
       }


       public String FileServerUrl {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FileServerUrl.ToString()]);
           }
       }


       public String FileServerAccessKey {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FileServerAccessKey.ToString()]);
           }
       }


       public String FileServerSecretKey {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FileServerSecretKey.ToString()]);
           }
       }


       public String FileServerBucket {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FileServerBucket.ToString()]);
           }
       }


       public String ClientAPIID {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ClientAPIID.ToString()]);
           }
       }


       public String ClientAPIUrl {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ClientAPIUrl.ToString()]);
           }
       }


       public String DB_HOST {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.DB_HOST.ToString()]);
           }
       }


       public String DB_DATABASE {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.DB_DATABASE.ToString()]);
           }
       }


       public String DB_USERNAME {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.DB_USERNAME.ToString()]);
           }
       }


       public String DB_PASSWORD {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.DB_PASSWORD.ToString()]);
           }
       }


       public Int32 DB_PORT {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DB_PORT.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public NullableDateTime UpdatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]);
           }
       }


       public String FileServerUrlHttps {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FileServerUrlHttps.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___ClientConnection GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___ClientConnection(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___ClientConnection GetFullTable()                  
        {                  
            return new T___ClientConnection(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___ClientConnection GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___ClientConnection(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___ClientConnection GetRowWhereID(int pID)                  
        {                  
            return new T___ClientConnection(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___ClientConnection pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (!pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return false;                  
                }                  
                  
                return true;                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  
                  
        private bool IsAnyRowEqual(T___ClientConnection pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return true;                  
                }                  
                  
                return false;                  
            }                  
            catch (Exception )                  
            {                  
                return false;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___ClientConnection GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___ClientConnection(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___ClientConnection(drst);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM                errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___ClientConnection getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___ClientConnection(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___ClientConnection(drst);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        public Dictionary<string, DataColumnDefinition> getDefinitions()                  
        {                  
            return ColumnDefns;                  
        }                  
                  
        private bool RowEqual(string pColumnName, object pColumnValue)                  
        {                  
            try                  
            {                  
                if (!this.IsTargettedRowValid)                  
                    return false;                  
                switch (DataColumnDefinition.getTypeAllowed(ColumnDefns[pColumnName].DataType))                  
                {                  
                    case var @case when @case == DataColumnDefinition.AllowedDataTypes.Bool:                  
                        {                  
                            return EBoolean.valueOf(this.TargettedRow[pColumnName]) == EBoolean.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case1 when case1 == DataColumnDefinition.AllowedDataTypes.Blob:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    case var case2 when case2 == DataColumnDefinition.AllowedDataTypes.DateTime:                  
                        {                  
                            return EDateTime.EqualsDateWithoutTime(new NullableDateTime(this.TargettedRow[pColumnName]).DateTimeValue, new NullableDateTime(pColumnValue).DateTimeValue);                  
                        }                  
                  
                    case var case3 when case3 == DataColumnDefinition.AllowedDataTypes.Decimal:                  
                        {                  
                            return EDouble.valueOf(this.TargettedRow[pColumnName]) == EDouble.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case4 when case4 == DataColumnDefinition.AllowedDataTypes.Int:                  
                        {                  
                            return EInt.valueOf(this.TargettedRow[pColumnName]) == EInt.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case5 when case5 == DataColumnDefinition.AllowedDataTypes.Long:                  
                        {                  
                            return ELong.valueOf(this.TargettedRow[pColumnName]) == ELong.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case6 when case6 == DataColumnDefinition.AllowedDataTypes.String:                  
                        {                  
                            return EStrings.equalsIgnoreCase(EStrings.valueOf(this.TargettedRow[pColumnName]), EStrings.valueOf(pColumnValue));                  
                        }                  
                  
                    case var case7 when case7 == DataColumnDefinition.AllowedDataTypes.TimeSpan:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    default:                  
                        {                  
                            // REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()                                                       
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                }                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  

                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
        public virtual string GetFillSQL() => ClientConnection__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pClientID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramFileServerUrl = new DataColumnParameter(defFileServerUrl, defFileServerUrl.DefaultValue);
                DataColumnParameter paramFileServerAccessKey = new DataColumnParameter(defFileServerAccessKey, defFileServerAccessKey.DefaultValue);
                DataColumnParameter paramFileServerSecretKey = new DataColumnParameter(defFileServerSecretKey, defFileServerSecretKey.DefaultValue);
                DataColumnParameter paramFileServerBucket = new DataColumnParameter(defFileServerBucket, defFileServerBucket.DefaultValue);
                DataColumnParameter paramClientAPIID = new DataColumnParameter(defClientAPIID, defClientAPIID.DefaultValue);
                DataColumnParameter paramClientAPIUrl = new DataColumnParameter(defClientAPIUrl, defClientAPIUrl.DefaultValue);
                DataColumnParameter paramDB_HOST = new DataColumnParameter(defDB_HOST, defDB_HOST.DefaultValue);
                DataColumnParameter paramDB_DATABASE = new DataColumnParameter(defDB_DATABASE, defDB_DATABASE.DefaultValue);
                DataColumnParameter paramDB_USERNAME = new DataColumnParameter(defDB_USERNAME, defDB_USERNAME.DefaultValue);
                DataColumnParameter paramDB_PASSWORD = new DataColumnParameter(defDB_PASSWORD, defDB_PASSWORD.DefaultValue);
                DataColumnParameter paramDB_PORT = new DataColumnParameter(defDB_PORT, defDB_PORT.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramFileServerUrlHttps = new DataColumnParameter(defFileServerUrlHttps, defFileServerUrlHttps.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramClientID.getSQLQuotedValueForAdd(),
                paramFileServerUrl.getSQLQuotedValueForAdd(),
                paramFileServerAccessKey.getSQLQuotedValueForAdd(),
                paramFileServerSecretKey.getSQLQuotedValueForAdd(),
                paramFileServerBucket.getSQLQuotedValueForAdd(),
                paramClientAPIID.getSQLQuotedValueForAdd(),
                paramClientAPIUrl.getSQLQuotedValueForAdd(),
                paramDB_HOST.getSQLQuotedValueForAdd(),
                paramDB_DATABASE.getSQLQuotedValueForAdd(),
                paramDB_USERNAME.getSQLQuotedValueForAdd(),
                paramDB_PASSWORD.getSQLQuotedValueForAdd(),
                paramDB_PORT.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd(),
                paramFileServerUrlHttps.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pClientID,
String pFileServerUrl,
String pFileServerAccessKey,
String pFileServerSecretKey,
String pFileServerBucket,
String pClientAPIID,
String pClientAPIUrl,
String pDB_HOST,
String pDB_DATABASE,
String pDB_USERNAME,
String pDB_PASSWORD,
Int32 pDB_PORT,
DateTime pCreatedAt,
String pFileServerUrlHttps,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramFileServerUrl = new DataColumnParameter(defFileServerUrl, pFileServerUrl);
                DataColumnParameter paramFileServerAccessKey = new DataColumnParameter(defFileServerAccessKey, pFileServerAccessKey);
                DataColumnParameter paramFileServerSecretKey = new DataColumnParameter(defFileServerSecretKey, pFileServerSecretKey);
                DataColumnParameter paramFileServerBucket = new DataColumnParameter(defFileServerBucket, pFileServerBucket);
                DataColumnParameter paramClientAPIID = new DataColumnParameter(defClientAPIID, pClientAPIID);
                DataColumnParameter paramClientAPIUrl = new DataColumnParameter(defClientAPIUrl, pClientAPIUrl);
                DataColumnParameter paramDB_HOST = new DataColumnParameter(defDB_HOST, pDB_HOST);
                DataColumnParameter paramDB_DATABASE = new DataColumnParameter(defDB_DATABASE, pDB_DATABASE);
                DataColumnParameter paramDB_USERNAME = new DataColumnParameter(defDB_USERNAME, pDB_USERNAME);
                DataColumnParameter paramDB_PASSWORD = new DataColumnParameter(defDB_PASSWORD, pDB_PASSWORD);
                DataColumnParameter paramDB_PORT = new DataColumnParameter(defDB_PORT, pDB_PORT);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramFileServerUrlHttps = new DataColumnParameter(defFileServerUrlHttps, pFileServerUrlHttps);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramFileServerUrl.getSQLQuotedValueForAdd(),
paramFileServerAccessKey.getSQLQuotedValueForAdd(),
paramFileServerSecretKey.getSQLQuotedValueForAdd(),
paramFileServerBucket.getSQLQuotedValueForAdd(),
paramClientAPIID.getSQLQuotedValueForAdd(),
paramClientAPIUrl.getSQLQuotedValueForAdd(),
paramDB_HOST.getSQLQuotedValueForAdd(),
paramDB_DATABASE.getSQLQuotedValueForAdd(),
paramDB_USERNAME.getSQLQuotedValueForAdd(),
paramDB_PASSWORD.getSQLQuotedValueForAdd(),
paramDB_PORT.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramFileServerUrlHttps.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pClientID,
String pFileServerUrl,
String pFileServerAccessKey,
String pFileServerSecretKey,
String pFileServerBucket,
String pClientAPIID,
String pClientAPIUrl,
String pDB_HOST,
String pDB_DATABASE,
String pDB_USERNAME,
String pDB_PASSWORD,
Int32 pDB_PORT,
DateTime pCreatedAt,
String pFileServerUrlHttps,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramFileServerUrl = new DataColumnParameter(defFileServerUrl, pFileServerUrl);
DataColumnParameter paramFileServerAccessKey = new DataColumnParameter(defFileServerAccessKey, pFileServerAccessKey);
DataColumnParameter paramFileServerSecretKey = new DataColumnParameter(defFileServerSecretKey, pFileServerSecretKey);
DataColumnParameter paramFileServerBucket = new DataColumnParameter(defFileServerBucket, pFileServerBucket);
DataColumnParameter paramClientAPIID = new DataColumnParameter(defClientAPIID, pClientAPIID);
DataColumnParameter paramClientAPIUrl = new DataColumnParameter(defClientAPIUrl, pClientAPIUrl);
DataColumnParameter paramDB_HOST = new DataColumnParameter(defDB_HOST, pDB_HOST);
DataColumnParameter paramDB_DATABASE = new DataColumnParameter(defDB_DATABASE, pDB_DATABASE);
DataColumnParameter paramDB_USERNAME = new DataColumnParameter(defDB_USERNAME, pDB_USERNAME);
DataColumnParameter paramDB_PASSWORD = new DataColumnParameter(defDB_PASSWORD, pDB_PASSWORD);
DataColumnParameter paramDB_PORT = new DataColumnParameter(defDB_PORT, pDB_PORT);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramFileServerUrlHttps = new DataColumnParameter(defFileServerUrlHttps, pFileServerUrlHttps);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramFileServerUrl.getSQLQuotedValueForAdd(),
paramFileServerAccessKey.getSQLQuotedValueForAdd(),
paramFileServerSecretKey.getSQLQuotedValueForAdd(),
paramFileServerBucket.getSQLQuotedValueForAdd(),
paramClientAPIID.getSQLQuotedValueForAdd(),
paramClientAPIUrl.getSQLQuotedValueForAdd(),
paramDB_HOST.getSQLQuotedValueForAdd(),
paramDB_DATABASE.getSQLQuotedValueForAdd(),
paramDB_USERNAME.getSQLQuotedValueForAdd(),
paramDB_PASSWORD.getSQLQuotedValueForAdd(),
paramDB_PORT.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramFileServerUrlHttps.getSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pClientID,
String pFileServerUrl,
String pFileServerAccessKey,
String pFileServerSecretKey,
String pFileServerBucket,
String pClientAPIID,
String pClientAPIUrl,
String pDB_HOST,
String pDB_DATABASE,
String pDB_USERNAME,
String pDB_PASSWORD,
Int32 pDB_PORT,
DateTime pCreatedAt,
String pFileServerUrlHttps,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramFileServerUrl = new DataColumnParameter(defFileServerUrl, pFileServerUrl);
DataColumnParameter paramFileServerAccessKey = new DataColumnParameter(defFileServerAccessKey, pFileServerAccessKey);
DataColumnParameter paramFileServerSecretKey = new DataColumnParameter(defFileServerSecretKey, pFileServerSecretKey);
DataColumnParameter paramFileServerBucket = new DataColumnParameter(defFileServerBucket, pFileServerBucket);
DataColumnParameter paramClientAPIID = new DataColumnParameter(defClientAPIID, pClientAPIID);
DataColumnParameter paramClientAPIUrl = new DataColumnParameter(defClientAPIUrl, pClientAPIUrl);
DataColumnParameter paramDB_HOST = new DataColumnParameter(defDB_HOST, pDB_HOST);
DataColumnParameter paramDB_DATABASE = new DataColumnParameter(defDB_DATABASE, pDB_DATABASE);
DataColumnParameter paramDB_USERNAME = new DataColumnParameter(defDB_USERNAME, pDB_USERNAME);
DataColumnParameter paramDB_PASSWORD = new DataColumnParameter(defDB_PASSWORD, pDB_PASSWORD);
DataColumnParameter paramDB_PORT = new DataColumnParameter(defDB_PORT, pDB_PORT);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramFileServerUrlHttps = new DataColumnParameter(defFileServerUrlHttps, pFileServerUrlHttps);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}) ", TABLE_NAME,paramClientID.getSQLQuotedValueForAdd(),
paramFileServerUrl.getSQLQuotedValueForAdd(),
paramFileServerAccessKey.getSQLQuotedValueForAdd(),
paramFileServerSecretKey.getSQLQuotedValueForAdd(),
paramFileServerBucket.getSQLQuotedValueForAdd(),
paramClientAPIID.getSQLQuotedValueForAdd(),
paramClientAPIUrl.getSQLQuotedValueForAdd(),
paramDB_HOST.getSQLQuotedValueForAdd(),
paramDB_DATABASE.getSQLQuotedValueForAdd(),
paramDB_USERNAME.getSQLQuotedValueForAdd(),
paramDB_PASSWORD.getSQLQuotedValueForAdd(),
paramDB_PORT.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramFileServerUrlHttps.getSQLQuotedValueForAdd()  ), true);


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
Object pClientID = null,
Object pFileServerUrl = null,
Object pFileServerAccessKey = null,
Object pFileServerSecretKey = null,
Object pFileServerBucket = null,
Object pClientAPIID = null,
Object pClientAPIUrl = null,
Object pDB_HOST = null,
Object pDB_DATABASE = null,
Object pDB_USERNAME = null,
Object pDB_PASSWORD = null,
Object pDB_PORT = null,
Object pCreatedAt = null,
Object pFileServerUrlHttps = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
 DataColumnParameter paramFileServerUrl = new DataColumnParameter(defFileServerUrl, pFileServerUrl);
 DataColumnParameter paramFileServerAccessKey = new DataColumnParameter(defFileServerAccessKey, pFileServerAccessKey);
 DataColumnParameter paramFileServerSecretKey = new DataColumnParameter(defFileServerSecretKey, pFileServerSecretKey);
 DataColumnParameter paramFileServerBucket = new DataColumnParameter(defFileServerBucket, pFileServerBucket);
 DataColumnParameter paramClientAPIID = new DataColumnParameter(defClientAPIID, pClientAPIID);
 DataColumnParameter paramClientAPIUrl = new DataColumnParameter(defClientAPIUrl, pClientAPIUrl);
 DataColumnParameter paramDB_HOST = new DataColumnParameter(defDB_HOST, pDB_HOST);
 DataColumnParameter paramDB_DATABASE = new DataColumnParameter(defDB_DATABASE, pDB_DATABASE);
 DataColumnParameter paramDB_USERNAME = new DataColumnParameter(defDB_USERNAME, pDB_USERNAME);
 DataColumnParameter paramDB_PASSWORD = new DataColumnParameter(defDB_PASSWORD, pDB_PASSWORD);
 DataColumnParameter paramDB_PORT = new DataColumnParameter(defDB_PORT, pDB_PORT);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramFileServerUrlHttps = new DataColumnParameter(defFileServerUrlHttps, pFileServerUrlHttps);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [ClientID]={2},[FileServerUrl]={3},[FileServerAccessKey]={4},[FileServerSecretKey]={5},[FileServerBucket]={6},[ClientAPIID]={7},[ClientAPIUrl]={8},[DB_HOST]={9},[DB_DATABASE]={10},[DB_USERNAME]={11},[DB_PASSWORD]={12},[DB_PORT]={13},[CreatedAt]={14},[UpdatedAt]={15},[FileServerUrlHttps]={16} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramClientID.getSQLQuotedValueForUpdate(),
paramFileServerUrl.getSQLQuotedValueForUpdate(),
paramFileServerAccessKey.getSQLQuotedValueForUpdate(),
paramFileServerSecretKey.getSQLQuotedValueForUpdate(),
paramFileServerBucket.getSQLQuotedValueForUpdate(),
paramClientAPIID.getSQLQuotedValueForUpdate(),
paramClientAPIUrl.getSQLQuotedValueForUpdate(),
paramDB_HOST.getSQLQuotedValueForUpdate(),
paramDB_DATABASE.getSQLQuotedValueForUpdate(),
paramDB_USERNAME.getSQLQuotedValueForUpdate(),
paramDB_PASSWORD.getSQLQuotedValueForUpdate(),
paramDB_PORT.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramFileServerUrlHttps.getSQLQuotedValueForUpdate()  ), true);


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
