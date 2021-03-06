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
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.common                  
{                  

    public class T___PlannedEventInterval : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PlannedEventInterval()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPlannedEventID = new DataColumnDefinition(TableColumnNames.PlannedEventID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDayOfWeekID = new DataColumnDefinition(TableColumnNames.DayOfWeekID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStartTime = new DataColumnDefinition(TableColumnNames.StartTime.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndTime = new DataColumnDefinition(TableColumnNames.EndTime.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPlannedEventID.ColumnName, defPlannedEventID); 
          ColumnDefns.Add(defDayOfWeekID.ColumnName, defDayOfWeekID); 
          ColumnDefns.Add(defStartTime.ColumnName, defStartTime); 
          ColumnDefns.Add(defEndTime.ColumnName, defEndTime); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEventInterval_PlannedEventID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "common.PlannedEventInterval", "common.PlannedEvent"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEventInterval_DayOfWeekID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PlannedEventInterval", "common.DayOfWeek"                  
                            ));                  

          }


                  
       public T___PlannedEventInterval() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEventInterval(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEventInterval(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEventInterval(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEventInterval(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PlannedEventInterval(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEventInterval(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEventInterval(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEventInterval(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEventInterval(DataTable FullTable) : base(FullTable)                                    
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
        public T___PlannedEventInterval(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "common.PlannedEventInterval";
       public const string PlannedEventInterval__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PlannedEventID], [DayOfWeekID], [StartTime], [EndTime], [CreatedAt] FROM common.PlannedEventInterval";
       public const string PlannedEventInterval__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PlannedEventID], [DayOfWeekID], [StartTime], [EndTime], [CreatedAt] FROM common.PlannedEventInterval";


       public enum TableColumnNames
       {

           ID,
           PlannedEventID,
           DayOfWeekID,
           StartTime,
           EndTime,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_common_PlannedEventInterval, 
           fk_common_PlannedEventInterval_PlannedEventID, 
           fk_common_PlannedEventInterval_DayOfWeekID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPlannedEventID;
       public static readonly DataColumnDefinition defDayOfWeekID;
       public static readonly DataColumnDefinition defStartTime;
       public static readonly DataColumnDefinition defEndTime;
       public static readonly DataColumnDefinition defCreatedAt;

       public int PlannedEventID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.PlannedEventID.ToString());  set => TargettedRow[TableColumnNames.PlannedEventID.ToString()] = value; }


       public int DayOfWeekID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DayOfWeekID.ToString());  set => TargettedRow[TableColumnNames.DayOfWeekID.ToString()] = value; }


       public DateTime StartTime { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.StartTime.ToString());  set => TargettedRow[TableColumnNames.StartTime.ToString()] = value; }


       public DateTime EndTime { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.EndTime.ToString());  set => TargettedRow[TableColumnNames.EndTime.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PlannedEventInterval GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PlannedEventInterval GetFullTable(TransactionRunner runner) =>                   
            runner.Run( (conn) =>                  
                new T___PlannedEventInterval(conn.Fetch(PlannedEventInterval__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable())                  
                );                                                      
                                                      
        public static T___PlannedEventInterval GetRowWhereIDUsingSQL(long pID, TransactionRunner runner)                                                                        
        {                  
            return runner.Run( (conn) =>  new T___PlannedEventInterval( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID )                  
                );                  
        }                                                                        
                                                                        
        public T___PlannedEventInterval GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PlannedEventInterval__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamPlannedEventID;
            private DataColumnParameter ParamDayOfWeekID;
            private DataColumnParameter ParamStartTime;
            private DataColumnParameter ParamEndTime;
            private DataColumnParameter ParamCreatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___PlannedEventInterval v):this(v.ID)                  
            {                  

                ParamPlannedEventID = new(defPlannedEventID, v.PlannedEventID);                  
                ParamDayOfWeekID = new(defDayOfWeekID, v.DayOfWeekID);                  
                ParamStartTime = new(defStartTime, v.StartTime);                  
                ParamEndTime = new(defEndTime, v.EndTime);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetPlannedEventID(int v)                  
            {                  
                ParamPlannedEventID = new(defPlannedEventID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDayOfWeekID(int v)                  
            {                  
                ParamDayOfWeekID = new(defDayOfWeekID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetStartTime(DateTime v)                  
            {                  
                ParamStartTime = new(defStartTime, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetEndTime(DateTime v)                  
            {                  
                ParamEndTime = new(defEndTime, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  

                  
            public string BuildSQL()                  
            {                  
                if (!this.CanUpdate()) throw new InvalidOperationException("Please, set at least a parameter to update.");                  
                  
                var p = this.GetTouchedColumns();                  
                System.Text.StringBuilder builder = new System.Text.StringBuilder($"UPDATE {TABLE_NAME} SET ");                  
                  
                foreach (var v in p) builder.Append($"{v.ColumnDefinition.ColumnName}={v.GetSQLValue()},");                  
                  
                builder = new System.Text.StringBuilder(builder.ToString().TrimEnd(','));                  
                builder.Append($" WHERE ID={ParamID.GetSQLValue()}");                  
                  
                return builder.ToString();                  
            }                  
                  
            public bool CanUpdate() => GetTouchedColumns().Count > 0;                  
                  
            private List<DataColumnParameter> GetTouchedColumns()                  
            {                  
                return this.GetType().GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)                  
                    .Where(x => x.GetValue(this) is DataColumnParameter)                  
                    .Select(x => (DataColumnParameter)x.GetValue(this))                  
                    .Where(x => !x.Equals(ParamID))                  
                    .ToList();                  
            }                  
                  
            public int Execute(TransactionRunner runner)                  
            {                  
                return runner.Run((conn) => conn.ExecuteTransactionQuery(this.BuildSQL()));                  
            }                  
        }                  
                  
        #endregion                  
                  





        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID( TransactionRunner runner, 
            int PlannedEventID
,            int DayOfWeekID
,            DateTime StartTime
,            DateTime EndTime
,            DateTime CreatedAt
          ){

                DataColumnParameter paramPlannedEventID = new (defPlannedEventID, PlannedEventID);
                DataColumnParameter paramDayOfWeekID = new (defDayOfWeekID, DayOfWeekID);
                DataColumnParameter paramStartTime = new (defStartTime, StartTime);
                DataColumnParameter paramEndTime = new (defEndTime, EndTime);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PlannedEventID],[DayOfWeekID],[StartTime],[EndTime],[CreatedAt]) VALUES({1},{2},{3},{4},{5})  ", TABLE_NAME,
                        paramPlannedEventID.GetSQLValue(),
                        paramDayOfWeekID.GetSQLValue(),
                        paramStartTime.GetSQLValue(),
                        paramEndTime.GetSQLValue(),
                        paramCreatedAt.GetSQLValue()                        )
                    );
                         
                return conn.GetScopeIdentity().ToLong();
            });

        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool AddWithID(TransactionRunner runner,
            int ID
,            int PlannedEventID
,            int DayOfWeekID
,            DateTime StartTime
,            DateTime EndTime
,            DateTime CreatedAt
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPlannedEventID = new (defPlannedEventID, PlannedEventID);
                DataColumnParameter paramDayOfWeekID = new (defDayOfWeekID, DayOfWeekID);
                DataColumnParameter paramStartTime = new (defStartTime, StartTime);
                DataColumnParameter paramEndTime = new (defEndTime, EndTime);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PlannedEventID],[DayOfWeekID],[StartTime],[EndTime],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLValue(),
                        paramPlannedEventID.GetSQLValue(),
                        paramDayOfWeekID.GetSQLValue(),
                        paramStartTime.GetSQLValue(),
                        paramEndTime.GetSQLValue(),
                        paramCreatedAt.GetSQLValue()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(TransactionRunner runner,
            int PlannedEventID
,            int DayOfWeekID
,            DateTime StartTime
,            DateTime EndTime
,            DateTime CreatedAt
          ){

                DataColumnParameter paramPlannedEventID = new (defPlannedEventID, PlannedEventID);
                DataColumnParameter paramDayOfWeekID = new (defDayOfWeekID, DayOfWeekID);
                DataColumnParameter paramStartTime = new (defStartTime, StartTime);
                DataColumnParameter paramEndTime = new (defEndTime, EndTime);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = runner;                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PlannedEventID],[DayOfWeekID],[StartTime],[EndTime],[CreatedAt]) VALUES({1},{2},{3},{4},{5})  ", TABLE_NAME,
                        paramPlannedEventID.GetSQLValue(),
                        paramDayOfWeekID.GetSQLValue(),
                        paramStartTime.GetSQLValue(),
                        paramEndTime.GetSQLValue(),
                        paramCreatedAt.GetSQLValue()                            
                            )
                        ).ToBoolean()
                    );


        }                  


                  
        /// <summary>                  
        /// Update current table. Works just for Target Row                  
        /// </summary>                  
        /// <param name="reloadTable">if you want this class reloaded</param>                  
        /// <param name="transaction"></param>                  
        /// <returns></returns>                  
        public bool Update(TransactionRunner runner, bool reloadTable = false)                  
        {                  
            return runner.Run(                  
               (conn) => {                  
                   bool r = new UpdateQueryBuilder(this).Execute(new (conn, false)).ToBoolean();                  
                   if (reloadTable) this.LoadFromRows( GetRowWhereIDUsingSQL(this.ID, new (conn, false)).TargettedRow );                  
                   return r;                  
               }                  
               );                  
        }                  
                  



                  
                  
        /// <summary>                  
        /// Deletes with an option to pass in transaction                  
        /// </summary>                  
        /// <returns></returns>                  
        /// <remarks></remarks>                  
        public bool DeleteRow(TransactionRunner runner)                  
        {                  
            return DeleteItemRow(runner, ID);                  
        }                  
                  
        public static bool DeleteItemRow(TransactionRunner runner, long pID)                                                      
        {                  
            return runner.Run(                  
               (conn) => conn.ExecuteTransactionQuery($"DELETE FROM {TABLE_NAME} WHERE ID={pID} ").ToBoolean()                  
               );                  
        }                  



   }


}
