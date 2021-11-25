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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.auth                  
{                  

    public class T___Session : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___Session()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defSessionID = new DataColumnDefinition(TableColumnNames.SessionID.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defSessionTimeoutMins = new DataColumnDefinition(TableColumnNames.SessionTimeoutMins.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsNewSession = new DataColumnDefinition(TableColumnNames.IsNewSession.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsReadOnly = new DataColumnDefinition(TableColumnNames.IsReadOnly.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastActive = new DataColumnDefinition(TableColumnNames.LastActive.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIpAddress = new DataColumnDefinition(TableColumnNames.IpAddress.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBrowser = new DataColumnDefinition(TableColumnNames.Browser.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionVariables = new DataColumnDefinition(TableColumnNames.SessionVariables.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defSessionID.ColumnName, defSessionID); 
          ColumnDefns.Add(defSessionTimeoutMins.ColumnName, defSessionTimeoutMins); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defIsNewSession.ColumnName, defIsNewSession); 
          ColumnDefns.Add(defIsReadOnly.ColumnName, defIsReadOnly); 
          ColumnDefns.Add(defLastActive.ColumnName, defLastActive); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
          ColumnDefns.Add(defBrowser.ColumnName, defBrowser); 
          ColumnDefns.Add(defSessionVariables.ColumnName, defSessionVariables); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  


          }


                  
       public T___Session() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Session(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Session(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Session(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "auth.Session";
       public const string Session__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [SessionID], [SessionTimeoutMins], [UserID], [IsNewSession], [IsReadOnly], [LastActive], [IpAddress], [Browser], [SessionVariables], [CreatedAt], [UpdatedAt] FROM Session";
       public const string Session__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [SessionID], [SessionTimeoutMins], [UserID], [IsNewSession], [IsReadOnly], [LastActive], [IpAddress], [Browser], [SessionVariables], [CreatedAt], [UpdatedAt] FROM Session";


       public enum TableColumnNames
       {

           ID,
           SessionID,
           SessionTimeoutMins,
           UserID,
           IsNewSession,
           IsReadOnly,
           LastActive,
           IpAddress,
           Browser,
           SessionVariables,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_auth_Session, 
           uq_auth_SessionID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defSessionID;
       public static readonly DataColumnDefinition defSessionTimeoutMins;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defIsNewSession;
       public static readonly DataColumnDefinition defIsReadOnly;
       public static readonly DataColumnDefinition defLastActive;
       public static readonly DataColumnDefinition defIpAddress;
       public static readonly DataColumnDefinition defBrowser;
       public static readonly DataColumnDefinition defSessionVariables;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public String SessionID {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.SessionID.ToString()]);
           }
       }


       public Int32 SessionTimeoutMins {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.SessionTimeoutMins.ToString()]);
           }
       }


       public Int32 UserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UserID.ToString()]);
           }
       }


       public Boolean IsNewSession {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsNewSession.ToString()]);
           }
       }


       public Boolean IsReadOnly {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsReadOnly.ToString()]);
           }
       }


       public NullableDateTime LastActive {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.LastActive.ToString()]);
           }
       }


       public String IpAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IpAddress.ToString()]);
           }
       }


       public String Browser {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Browser.ToString()]);
           }
       }


       public String SessionVariables {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.SessionVariables.ToString()]);
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


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___Session GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___Session(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___Session GetFullTable()                  
        {                  
            return new T___Session(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___Session GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___Session(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___Session GetRowWhereID(int pID)                  
        {                  
            return new T___Session(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___Session pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___Session pRow, params DataColumnParameter[] pParams)                  
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
        public T___Session GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___Session(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Session(drst);                  
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
        public T___Session getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___Session(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Session(drst);                  
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

                  
        public virtual string GetFillSQL() => Session__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(String pSessionID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramSessionID = new DataColumnParameter(defSessionID, pSessionID);
                DataColumnParameter paramSessionTimeoutMins = new DataColumnParameter(defSessionTimeoutMins, defSessionTimeoutMins.DefaultValue);
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, defUserID.DefaultValue);
                DataColumnParameter paramIsNewSession = new DataColumnParameter(defIsNewSession, defIsNewSession.DefaultValue);
                DataColumnParameter paramIsReadOnly = new DataColumnParameter(defIsReadOnly, defIsReadOnly.DefaultValue);
                DataColumnParameter paramLastActive = new DataColumnParameter(defLastActive, defLastActive.DefaultValue);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, defIpAddress.DefaultValue);
                DataColumnParameter paramBrowser = new DataColumnParameter(defBrowser, defBrowser.DefaultValue);
                DataColumnParameter paramSessionVariables = new DataColumnParameter(defSessionVariables, defSessionVariables.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramSessionID.getSQLQuotedValueForAdd(),
                paramSessionTimeoutMins.getSQLQuotedValueForAdd(),
                paramUserID.getSQLQuotedValueForAdd(),
                paramIsNewSession.getSQLQuotedValueForAdd(),
                paramIsReadOnly.getSQLQuotedValueForAdd(),
                paramLastActive.getSQLQuotedValueForAdd(),
                paramIpAddress.getSQLQuotedValueForAdd(),
                paramBrowser.getSQLQuotedValueForAdd(),
                paramSessionVariables.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pSessionID,
Int32 pSessionTimeoutMins,
DateTime pCreatedAt,
Object pUserID = null,
Object pIsNewSession = null,
Object pIsReadOnly = null,
Object pLastActive = null,
Object pIpAddress = null,
Object pBrowser = null,
Object pSessionVariables = null,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramSessionID = new DataColumnParameter(defSessionID, pSessionID);
                DataColumnParameter paramSessionTimeoutMins = new DataColumnParameter(defSessionTimeoutMins, pSessionTimeoutMins);
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramIsNewSession = new DataColumnParameter(defIsNewSession, pIsNewSession);
                DataColumnParameter paramIsReadOnly = new DataColumnParameter(defIsReadOnly, pIsReadOnly);
                DataColumnParameter paramLastActive = new DataColumnParameter(defLastActive, pLastActive);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
                DataColumnParameter paramBrowser = new DataColumnParameter(defBrowser, pBrowser);
                DataColumnParameter paramSessionVariables = new DataColumnParameter(defSessionVariables, pSessionVariables);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramSessionID.getSQLQuotedValueForAdd(),
paramSessionTimeoutMins.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramIsNewSession.getSQLQuotedValueForAdd(),
paramIsReadOnly.getSQLQuotedValueForAdd(),
paramLastActive.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramBrowser.getSQLQuotedValueForAdd(),
paramSessionVariables.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pSessionID,
Int32 pSessionTimeoutMins,
DateTime pCreatedAt,
Object pUserID = null,
Object pIsNewSession = null,
Object pIsReadOnly = null,
Object pLastActive = null,
Object pIpAddress = null,
Object pBrowser = null,
Object pSessionVariables = null,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramSessionID = new DataColumnParameter(defSessionID, pSessionID);
DataColumnParameter paramSessionTimeoutMins = new DataColumnParameter(defSessionTimeoutMins, pSessionTimeoutMins);
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramIsNewSession = new DataColumnParameter(defIsNewSession, pIsNewSession);
DataColumnParameter paramIsReadOnly = new DataColumnParameter(defIsReadOnly, pIsReadOnly);
DataColumnParameter paramLastActive = new DataColumnParameter(defLastActive, pLastActive);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
DataColumnParameter paramBrowser = new DataColumnParameter(defBrowser, pBrowser);
DataColumnParameter paramSessionVariables = new DataColumnParameter(defSessionVariables, pSessionVariables);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramSessionID.getSQLQuotedValueForAdd(),
paramSessionTimeoutMins.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramIsNewSession.getSQLQuotedValueForAdd(),
paramIsReadOnly.getSQLQuotedValueForAdd(),
paramLastActive.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramBrowser.getSQLQuotedValueForAdd(),
paramSessionVariables.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pSessionID,
Int32 pSessionTimeoutMins,
DateTime pCreatedAt,
Object pUserID= null,
Object pIsNewSession= null,
Object pIsReadOnly= null,
Object pLastActive= null,
Object pIpAddress= null,
Object pBrowser= null,
Object pSessionVariables= null,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramSessionID = new DataColumnParameter(defSessionID, pSessionID);
DataColumnParameter paramSessionTimeoutMins = new DataColumnParameter(defSessionTimeoutMins, pSessionTimeoutMins);
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramIsNewSession = new DataColumnParameter(defIsNewSession, pIsNewSession);
DataColumnParameter paramIsReadOnly = new DataColumnParameter(defIsReadOnly, pIsReadOnly);
DataColumnParameter paramLastActive = new DataColumnParameter(defLastActive, pLastActive);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
DataColumnParameter paramBrowser = new DataColumnParameter(defBrowser, pBrowser);
DataColumnParameter paramSessionVariables = new DataColumnParameter(defSessionVariables, pSessionVariables);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) ", TABLE_NAME,paramSessionID.getSQLQuotedValueForAdd(),
paramSessionTimeoutMins.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramIsNewSession.getSQLQuotedValueForAdd(),
paramIsReadOnly.getSQLQuotedValueForAdd(),
paramLastActive.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramBrowser.getSQLQuotedValueForAdd(),
paramSessionVariables.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), true);


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
Object pSessionID = null,
Object pSessionTimeoutMins = null,
Object pCreatedAt = null,
Object pUserID = null,
Object pIsNewSession = null,
Object pIsReadOnly = null,
Object pLastActive = null,
Object pIpAddress = null,
Object pBrowser = null,
Object pSessionVariables = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramSessionID = new DataColumnParameter(defSessionID, pSessionID);
 DataColumnParameter paramSessionTimeoutMins = new DataColumnParameter(defSessionTimeoutMins, pSessionTimeoutMins);
 DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
 DataColumnParameter paramIsNewSession = new DataColumnParameter(defIsNewSession, pIsNewSession);
 DataColumnParameter paramIsReadOnly = new DataColumnParameter(defIsReadOnly, pIsReadOnly);
 DataColumnParameter paramLastActive = new DataColumnParameter(defLastActive, pLastActive);
 DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
 DataColumnParameter paramBrowser = new DataColumnParameter(defBrowser, pBrowser);
 DataColumnParameter paramSessionVariables = new DataColumnParameter(defSessionVariables, pSessionVariables);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [SessionID]={2},[SessionTimeoutMins]={3},[UserID]={4},[IsNewSession]={5},[IsReadOnly]={6},[LastActive]={7},[IpAddress]={8},[Browser]={9},[SessionVariables]={10},[CreatedAt]={11},[UpdatedAt]={12} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramSessionID.getSQLQuotedValueForUpdate(),
paramSessionTimeoutMins.getSQLQuotedValueForUpdate(),
paramUserID.getSQLQuotedValueForUpdate(),
paramIsNewSession.getSQLQuotedValueForUpdate(),
paramIsReadOnly.getSQLQuotedValueForUpdate(),
paramLastActive.getSQLQuotedValueForUpdate(),
paramIpAddress.getSQLQuotedValueForUpdate(),
paramBrowser.getSQLQuotedValueForUpdate(),
paramSessionVariables.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate()  ), true);


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
