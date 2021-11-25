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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.common                  
{                  

    public class V___PlannedEventIntervalView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static V___PlannedEventIntervalView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defPlannedEventID = new DataColumnDefinition(TableColumnNames.PlannedEventID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDayOfWeekID = new DataColumnDefinition(TableColumnNames.DayOfWeekID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStartTime = new DataColumnDefinition(TableColumnNames.StartTime.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndTime = new DataColumnDefinition(TableColumnNames.EndTime.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIntervalDate = new DataColumnDefinition(TableColumnNames.IntervalDate.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStartDate = new DataColumnDefinition(TableColumnNames.StartDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndDate = new DataColumnDefinition(TableColumnNames.EndDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTitle = new DataColumnDefinition(TableColumnNames.Title.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCalendarEventID = new DataColumnDefinition(TableColumnNames.CalendarEventID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCanBeDeleted = new DataColumnDefinition(TableColumnNames.CanBeDeleted.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClassColor = new DataColumnDefinition(TableColumnNames.ClassColor.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCalendarEvent = new DataColumnDefinition(TableColumnNames.CalendarEvent.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defPlannedEventID.ColumnName, defPlannedEventID); 
          ColumnDefns.Add(defDayOfWeekID.ColumnName, defDayOfWeekID); 
          ColumnDefns.Add(defStartTime.ColumnName, defStartTime); 
          ColumnDefns.Add(defEndTime.ColumnName, defEndTime); 
          ColumnDefns.Add(defIntervalDate.ColumnName, defIntervalDate); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defStartDate.ColumnName, defStartDate); 
          ColumnDefns.Add(defEndDate.ColumnName, defEndDate); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defCalendarEventID.ColumnName, defCalendarEventID); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defCanBeDeleted.ColumnName, defCanBeDeleted); 
          ColumnDefns.Add(defClassColor.ColumnName, defClassColor); 
          ColumnDefns.Add(defCalendarEvent.ColumnName, defCalendarEvent); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("common.CalendarEvent");                  
            ReferencedTableNames.Add("common.PlannedEvent");                  
            ReferencedTableNames.Add("common.PlannedEventInterval");                  

          }


                  
       public V___PlannedEventIntervalView() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___PlannedEventIntervalView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PlannedEventIntervalView(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public V___PlannedEventIntervalView(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "common.PlannedEventIntervalView";
       public const string PlannedEventIntervalView__NO__BINARY___SQL_FILL_QUERY = "SELECT [PlannedEventID], [DayOfWeekID], [StartTime], [EndTime], [IntervalDate], [ID], [StartDate], [EndDate], [Comments], [Title], [CalendarEventID], [CreatedByID], [CanBeDeleted], [ClassColor], [CalendarEvent] FROM PlannedEventIntervalView";
       public const string PlannedEventIntervalView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [PlannedEventID], [DayOfWeekID], [StartTime], [EndTime], [IntervalDate], [ID], [StartDate], [EndDate], [Comments], [Title], [CalendarEventID], [CreatedByID], [CanBeDeleted], [ClassColor], [CalendarEvent] FROM PlannedEventIntervalView";


       public enum TableColumnNames
       {

           PlannedEventID,
           DayOfWeekID,
           StartTime,
           EndTime,
           IntervalDate,
           ID,
           StartDate,
           EndDate,
           Comments,
           Title,
           CalendarEventID,
           CreatedByID,
           CanBeDeleted,
           ClassColor,
           CalendarEvent
       } 


 #endregion 


 #region Properties 

       private static List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defPlannedEventID;
       public static readonly DataColumnDefinition defDayOfWeekID;
       public static readonly DataColumnDefinition defStartTime;
       public static readonly DataColumnDefinition defEndTime;
       public static readonly DataColumnDefinition defIntervalDate;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defStartDate;
       public static readonly DataColumnDefinition defEndDate;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defCalendarEventID;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defCanBeDeleted;
       public static readonly DataColumnDefinition defClassColor;
       public static readonly DataColumnDefinition defCalendarEvent;

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


       public NullableDateTime IntervalDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.IntervalDate.ToString()]);
           }
       }


       public NullableDateTime StartDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.StartDate.ToString()]);
           }
       }


       public NullableDateTime EndDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.EndDate.ToString()]);
           }
       }


       public String Comments {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Comments.ToString()]);
           }
       }


       public String Title {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Title.ToString()]);
           }
       }


       public Int32 CalendarEventID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CalendarEventID.ToString()]);
           }
       }


       public Int32 CreatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


       public Boolean CanBeDeleted {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.CanBeDeleted.ToString()]);
           }
       }


       public String ClassColor {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ClassColor.ToString()]);
           }
       }


       public String CalendarEvent {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.CalendarEvent.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public V___PlannedEventIntervalView GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new V___PlannedEventIntervalView(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static V___PlannedEventIntervalView GetFullTable()                  
        {                  
            return new V___PlannedEventIntervalView(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static V___PlannedEventIntervalView GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new V___PlannedEventIntervalView(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public V___PlannedEventIntervalView GetRowWhereID(int pID)                  
        {                  
            return new V___PlannedEventIntervalView(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(V___PlannedEventIntervalView pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(V___PlannedEventIntervalView pRow, params DataColumnParameter[] pParams)                  
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
        public V___PlannedEventIntervalView GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new V___PlannedEventIntervalView(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___PlannedEventIntervalView(drst);                  
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
        public V___PlannedEventIntervalView getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new V___PlannedEventIntervalView(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___PlannedEventIntervalView(drst);                  
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

                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
#endregion                  
                  
                  



   }


}
