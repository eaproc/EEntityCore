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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.common                  
{                  

    public class T___PlannedEvent : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PlannedEvent()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCalendarEventID = new DataColumnDefinition(TableColumnNames.CalendarEventID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTitle = new DataColumnDefinition(TableColumnNames.Title.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStartDate = new DataColumnDefinition(TableColumnNames.StartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndDate = new DataColumnDefinition(TableColumnNames.EndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTrackID = new DataColumnDefinition(TableColumnNames.TrackID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAcademicSessionID = new DataColumnDefinition(TableColumnNames.AcademicSessionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCalendarEventID.ColumnName, defCalendarEventID); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defStartDate.ColumnName, defStartDate); 
          ColumnDefns.Add(defEndDate.ColumnName, defEndDate); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defTrackID.ColumnName, defTrackID); 
          ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEvent_CalendarEventID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PlannedEvent", "common.CalendarEvent"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEvent_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PlannedEvent", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEvent_AcademicSessionID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PlannedEvent", "academic.AcademicSession"                  
                            ));                  

          }


                  
       public T___PlannedEvent() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PlannedEvent(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PlannedEvent(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PlannedEvent(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "common.PlannedEvent";
       public const string PlannedEvent__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CalendarEventID], [Title], [StartDate], [EndDate], [Comments], [CreatedAt], [CreatedByID], [TrackID], [AcademicSessionID] FROM PlannedEvent";
       public const string PlannedEvent__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CalendarEventID], [Title], [StartDate], [EndDate], [Comments], [CreatedAt], [CreatedByID], [TrackID], [AcademicSessionID] FROM PlannedEvent";


       public enum TableColumnNames
       {

           ID,
           CalendarEventID,
           Title,
           StartDate,
           EndDate,
           Comments,
           CreatedAt,
           CreatedByID,
           TrackID,
           AcademicSessionID
       } 



       public enum TableConstraints{

           pk_common_PlannedEvent, 
           fk_common_PlannedEvent_CalendarEventID, 
           fk_common_PlannedEvent_CreatedByID, 
           fk_common_PlannedEvent_AcademicSessionID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCalendarEventID;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defStartDate;
       public static readonly DataColumnDefinition defEndDate;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defTrackID;
       public static readonly DataColumnDefinition defAcademicSessionID;

       public int CalendarEventID { get => (int)TargettedRow[TableColumnNames.CalendarEventID.ToString()]; }


       public string Title { get => (string)TargettedRow[TableColumnNames.Title.ToString()]; }


       public DateTime StartDate { get => (DateTime)TargettedRow[TableColumnNames.StartDate.ToString()]; }


       public DateTime EndDate { get => (DateTime)TargettedRow[TableColumnNames.EndDate.ToString()]; }


       public string Comments { get => (string)TargettedRow[TableColumnNames.Comments.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public int? TrackID { get => (int?)TargettedRow[TableColumnNames.TrackID.ToString()]; }


       public int AcademicSessionID { get => (int)TargettedRow[TableColumnNames.AcademicSessionID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___PlannedEvent GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PlannedEvent GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PlannedEvent GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PlannedEvent(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PlannedEvent GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PlannedEvent__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int CalendarEventID,
            string Title,
            DateTime StartDate,
            DateTime EndDate,
            DateTime CreatedAt,
            int CreatedByID,
            int AcademicSessionID,
            string Comments = null,
            int? TrackID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCalendarEventID = new (defCalendarEventID, CalendarEventID);
                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramStartDate = new (defStartDate, StartDate);
                DataColumnParameter paramEndDate = new (defEndDate, EndDate);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramTrackID = new (defTrackID, TrackID);
                DataColumnParameter paramAcademicSessionID = new (defAcademicSessionID, AcademicSessionID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CalendarEventID],[Title],[StartDate],[EndDate],[Comments],[CreatedAt],[CreatedByID],[TrackID],[AcademicSessionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  ", TABLE_NAME,
                        paramCalendarEventID.GetSQLQuotedValueForAdd(),
                        paramTitle.GetSQLQuotedValueForAdd(),
                        paramStartDate.GetSQLQuotedValueForAdd(),
                        paramEndDate.GetSQLQuotedValueForAdd(),
                        paramComments.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramTrackID.GetSQLQuotedValueForAdd(),
                        paramAcademicSessionID.GetSQLQuotedValueForAdd()                        )
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
            int CalendarEventID,
            string Title,
            DateTime StartDate,
            DateTime EndDate,
            DateTime CreatedAt,
            int CreatedByID,
            int AcademicSessionID,
            string Comments = null,
            int? TrackID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCalendarEventID = new (defCalendarEventID, CalendarEventID);
                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramStartDate = new (defStartDate, StartDate);
                DataColumnParameter paramEndDate = new (defEndDate, EndDate);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramTrackID = new (defTrackID, TrackID);
                DataColumnParameter paramAcademicSessionID = new (defAcademicSessionID, AcademicSessionID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CalendarEventID],[Title],[StartDate],[EndDate],[Comments],[CreatedAt],[CreatedByID],[TrackID],[AcademicSessionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramCalendarEventID.GetSQLQuotedValueForAdd(),
                        paramTitle.GetSQLQuotedValueForAdd(),
                        paramStartDate.GetSQLQuotedValueForAdd(),
                        paramEndDate.GetSQLQuotedValueForAdd(),
                        paramComments.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramTrackID.GetSQLQuotedValueForAdd(),
                        paramAcademicSessionID.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
