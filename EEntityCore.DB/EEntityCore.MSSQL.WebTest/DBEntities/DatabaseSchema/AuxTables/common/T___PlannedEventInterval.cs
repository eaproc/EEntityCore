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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.common                  
{                  

    public class T___PlannedEventInterval : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PlannedEventInterval()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPlannedEventID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PlannedEventID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDayOfWeekID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DayOfWeekID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStartTime = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.StartTime.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndTime = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.EndTime.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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
        public T___PlannedEventInterval(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
       public const string PlannedEventInterval__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PlannedEventID], [DayOfWeekID], [StartTime], [EndTime], [CreatedAt] FROM PlannedEventInterval";
       public const string PlannedEventInterval__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PlannedEventID], [DayOfWeekID], [StartTime], [EndTime], [CreatedAt] FROM PlannedEventInterval";


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

       public Int32 PlannedEventID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PlannedEventID.ToString()]);
           }
       }


       public Int32 DayOfWeekID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DayOfWeekID.ToString()]);
           }
       }


       public NullableDateTime StartTime {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.StartTime.ToString()]);
           }
       }


       public NullableDateTime EndTime {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.EndTime.ToString()]);
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
        public T___PlannedEventInterval GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PlannedEventInterval GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PlannedEventInterval GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PlannedEventInterval(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PlannedEventInterval GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PlannedEventInterval__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pPlannedEventID,
Int32 pDayOfWeekID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPlannedEventID = new DataColumnParameter(defPlannedEventID, pPlannedEventID);
                DataColumnParameter paramDayOfWeekID = new DataColumnParameter(defDayOfWeekID, pDayOfWeekID);
                DataColumnParameter paramStartTime = new DataColumnParameter(defStartTime, defStartTime.DefaultValue);
                DataColumnParameter paramEndTime = new DataColumnParameter(defEndTime, defEndTime.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PlannedEventID],[DayOfWeekID],[StartTime],[EndTime],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramPlannedEventID.GetSQLQuotedValueForAdd(),
                paramDayOfWeekID.GetSQLQuotedValueForAdd(),
                paramStartTime.GetSQLQuotedValueForAdd(),
                paramEndTime.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pPlannedEventID,
Int32 pDayOfWeekID,
DateTime pStartTime,
DateTime pEndTime,
DateTime pCreatedAt){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPlannedEventID = new DataColumnParameter(defPlannedEventID, pPlannedEventID);
                DataColumnParameter paramDayOfWeekID = new DataColumnParameter(defDayOfWeekID, pDayOfWeekID);
                DataColumnParameter paramStartTime = new DataColumnParameter(defStartTime, pStartTime);
                DataColumnParameter paramEndTime = new DataColumnParameter(defEndTime, pEndTime);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PlannedEventID],[DayOfWeekID],[StartTime],[EndTime],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramPlannedEventID.GetSQLQuotedValueForAdd(),
paramDayOfWeekID.GetSQLQuotedValueForAdd(),
paramStartTime.GetSQLQuotedValueForAdd(),
paramEndTime.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pPlannedEventID,
Int32 pDayOfWeekID,
DateTime pStartTime,
DateTime pEndTime,
DateTime pCreatedAt){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramPlannedEventID = new DataColumnParameter(defPlannedEventID, pPlannedEventID);
DataColumnParameter paramDayOfWeekID = new DataColumnParameter(defDayOfWeekID, pDayOfWeekID);
DataColumnParameter paramStartTime = new DataColumnParameter(defStartTime, pStartTime);
DataColumnParameter paramEndTime = new DataColumnParameter(defEndTime, pEndTime);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PlannedEventID],[DayOfWeekID],[StartTime],[EndTime],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramPlannedEventID.GetSQLQuotedValueForAdd(),
paramDayOfWeekID.GetSQLQuotedValueForAdd(),
paramStartTime.GetSQLQuotedValueForAdd(),
paramEndTime.GetSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pPlannedEventID,
Int32 pDayOfWeekID,
DateTime pStartTime,
DateTime pEndTime,
DateTime pCreatedAt){

        try{

DataColumnParameter paramPlannedEventID = new DataColumnParameter(defPlannedEventID, pPlannedEventID);
DataColumnParameter paramDayOfWeekID = new DataColumnParameter(defDayOfWeekID, pDayOfWeekID);
DataColumnParameter paramStartTime = new DataColumnParameter(defStartTime, pStartTime);
DataColumnParameter paramEndTime = new DataColumnParameter(defEndTime, pEndTime);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([PlannedEventID],[DayOfWeekID],[StartTime],[EndTime],[CreatedAt]) VALUES({1},{2},{3},{4},{5}) ", TABLE_NAME,paramPlannedEventID.GetSQLQuotedValueForAdd(),
paramDayOfWeekID.GetSQLQuotedValueForAdd(),
paramStartTime.GetSQLQuotedValueForAdd(),
paramEndTime.GetSQLQuotedValueForAdd(),
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
Object pPlannedEventID = null,
Object pDayOfWeekID = null,
Object pStartTime = null,
Object pEndTime = null,
Object pCreatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramPlannedEventID = new DataColumnParameter(defPlannedEventID, pPlannedEventID);
 DataColumnParameter paramDayOfWeekID = new DataColumnParameter(defDayOfWeekID, pDayOfWeekID);
 DataColumnParameter paramStartTime = new DataColumnParameter(defStartTime, pStartTime);
 DataColumnParameter paramEndTime = new DataColumnParameter(defEndTime, pEndTime);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [PlannedEventID]={2},[DayOfWeekID]={3},[StartTime]={4},[EndTime]={5},[CreatedAt]={6} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramPlannedEventID.GetSQLQuotedValueForUpdate(),
paramDayOfWeekID.GetSQLQuotedValueForUpdate(),
paramStartTime.GetSQLQuotedValueForUpdate(),
paramEndTime.GetSQLQuotedValueForUpdate(),
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
