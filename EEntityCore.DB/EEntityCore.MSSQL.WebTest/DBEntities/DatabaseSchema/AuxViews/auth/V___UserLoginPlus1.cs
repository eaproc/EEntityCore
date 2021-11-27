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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.auth                  
{                  

    public class V___UserLoginPlus1 : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___UserLoginPlus1()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defUsername = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Username.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastLoginTime = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LastLoginTime.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLoggedOutTime = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LoggedOutTime.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IPAddress.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SessionID.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionIDCreatedTime = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SessionIDCreatedTime.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionTimeoutMins = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SessionTimeoutMins.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastActive = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LastActive.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpiryDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExpiryDate.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSecondsLeft = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SecondsLeft.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defActiveSessions = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ActiveSessions.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsActive.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       public String Username {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Username.ToString()]);
           }
       }


       public NullableDateTime LastLoginTime {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.LastLoginTime.ToString()]);
           }
       }


       public NullableDateTime LoggedOutTime {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.LoggedOutTime.ToString()]);
           }
       }


       public String IPAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IPAddress.ToString()]);
           }
       }


       public String SessionID {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.SessionID.ToString()]);
           }
       }


       public NullableDateTime SessionIDCreatedTime {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.SessionIDCreatedTime.ToString()]);
           }
       }


       public Int32 SessionTimeoutMins {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.SessionTimeoutMins.ToString()]);
           }
       }


       public NullableDateTime LastActive {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.LastActive.ToString()]);
           }
       }


       public NullableDateTime ExpiryDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.ExpiryDate.ToString()]);
           }
       }


       public Int32 SecondsLeft {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.SecondsLeft.ToString()]);
           }
       }


       public String ActiveSessions {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ActiveSessions.ToString()]);
           }
       }


       public Int32 UserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UserID.ToString()]);
           }
       }


       public Int32 PersonID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonID.ToString()]);
           }
       }


       public Boolean IsActive {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsActive.ToString()]);
           }
       }


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
