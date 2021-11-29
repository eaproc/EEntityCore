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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.auth                  
{                  

    public class V___UserLoginPlus1 : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___UserLoginPlus1()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defUsername = new DataColumnDefinition(TableColumnNames.Username.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastLoginTime = new DataColumnDefinition(TableColumnNames.LastLoginTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLoggedOutTime = new DataColumnDefinition(TableColumnNames.LoggedOutTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(TableColumnNames.IPAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionID = new DataColumnDefinition(TableColumnNames.SessionID.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionIDCreatedTime = new DataColumnDefinition(TableColumnNames.SessionIDCreatedTime.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionTimeoutMins = new DataColumnDefinition(TableColumnNames.SessionTimeoutMins.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastActive = new DataColumnDefinition(TableColumnNames.LastActive.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpiryDate = new DataColumnDefinition(TableColumnNames.ExpiryDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSecondsLeft = new DataColumnDefinition(TableColumnNames.SecondsLeft.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defActiveSessions = new DataColumnDefinition(TableColumnNames.ActiveSessions.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defUsername.ColumnName, defUsername); 
          ColumnDefns.Add(defLastLoginTime.ColumnName, defLastLoginTime); 
          ColumnDefns.Add(defLoggedOutTime.ColumnName, defLoggedOutTime); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defSessionID.ColumnName, defSessionID); 
          ColumnDefns.Add(defSessionIDCreatedTime.ColumnName, defSessionIDCreatedTime); 
          ColumnDefns.Add(defSessionTimeoutMins.ColumnName, defSessionTimeoutMins); 
          ColumnDefns.Add(defLastActive.ColumnName, defLastActive); 
          ColumnDefns.Add(defExpiryDate.ColumnName, defExpiryDate); 
          ColumnDefns.Add(defSecondsLeft.ColumnName, defSecondsLeft); 
          ColumnDefns.Add(defActiveSessions.ColumnName, defActiveSessions); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("auth.Session");                  
            ReferencedTableNames.Add("auth.UserLoginHistory");                  
            ReferencedTableNames.Add("auth.Users");                  

          }


                  
       public V___UserLoginPlus1() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___UserLoginPlus1(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___UserLoginPlus1(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public V___UserLoginPlus1(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.UserLoginPlus1";
       public const string UserLoginPlus1__NO__BINARY___SQL_FILL_QUERY = "SELECT [Username], [LastLoginTime], [LoggedOutTime], [IPAddress], [SessionID], [SessionIDCreatedTime], [SessionTimeoutMins], [LastActive], [ExpiryDate], [SecondsLeft], [ActiveSessions], [UserID], [PersonID], [IsActive] FROM UserLoginPlus1";
       public const string UserLoginPlus1__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [Username], [LastLoginTime], [LoggedOutTime], [IPAddress], [SessionID], [SessionIDCreatedTime], [SessionTimeoutMins], [LastActive], [ExpiryDate], [SecondsLeft], [ActiveSessions], [UserID], [PersonID], [IsActive] FROM UserLoginPlus1";


       public enum TableColumnNames
       {

           Username,
           LastLoginTime,
           LoggedOutTime,
           IPAddress,
           SessionID,
           SessionIDCreatedTime,
           SessionTimeoutMins,
           LastActive,
           ExpiryDate,
           SecondsLeft,
           ActiveSessions,
           UserID,
           PersonID,
           IsActive
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defUsername;
       public static readonly DataColumnDefinition defLastLoginTime;
       public static readonly DataColumnDefinition defLoggedOutTime;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defSessionID;
       public static readonly DataColumnDefinition defSessionIDCreatedTime;
       public static readonly DataColumnDefinition defSessionTimeoutMins;
       public static readonly DataColumnDefinition defLastActive;
       public static readonly DataColumnDefinition defExpiryDate;
       public static readonly DataColumnDefinition defSecondsLeft;
       public static readonly DataColumnDefinition defActiveSessions;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defIsActive;

       public string Username { get => (string)TargettedRow[TableColumnNames.Username.ToString()]; }


       public DateTime? LastLoginTime { get => (DateTime?)TargettedRow[TableColumnNames.LastLoginTime.ToString()]; }


       public DateTime? LoggedOutTime { get => (DateTime?)TargettedRow[TableColumnNames.LoggedOutTime.ToString()]; }


       public string IPAddress { get => (string)TargettedRow[TableColumnNames.IPAddress.ToString()]; }


       public string SessionID { get => (string)TargettedRow[TableColumnNames.SessionID.ToString()]; }


       public DateTime? SessionIDCreatedTime { get => (DateTime?)TargettedRow[TableColumnNames.SessionIDCreatedTime.ToString()]; }


       public int? SessionTimeoutMins { get => (int?)TargettedRow[TableColumnNames.SessionTimeoutMins.ToString()]; }


       public DateTime? LastActive { get => (DateTime?)TargettedRow[TableColumnNames.LastActive.ToString()]; }


       public DateTime? ExpiryDate { get => (DateTime?)TargettedRow[TableColumnNames.ExpiryDate.ToString()]; }


       public int? SecondsLeft { get => (int?)TargettedRow[TableColumnNames.SecondsLeft.ToString()]; }


       public string ActiveSessions { get => (string)TargettedRow[TableColumnNames.ActiveSessions.ToString()]; }


       public int UserID { get => (int)TargettedRow[TableColumnNames.UserID.ToString()]; }


       public int PersonID { get => (int)TargettedRow[TableColumnNames.PersonID.ToString()]; }


       public bool IsActive { get => (bool)TargettedRow[TableColumnNames.IsActive.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public V___UserLoginPlus1 GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static V___UserLoginPlus1 GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static V___UserLoginPlus1 GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new V___UserLoginPlus1(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public V___UserLoginPlus1 GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => UserLoginPlus1__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
