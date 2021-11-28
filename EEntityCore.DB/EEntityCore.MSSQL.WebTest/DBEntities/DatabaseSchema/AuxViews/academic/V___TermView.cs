using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using ELibrary.Standard.VB.Modules;                  
using EEntityCore.DB.Schemas.SQLServerSchema;                  
using EEntityCore.DB.MSSQL;                  
using EEntityCore.DB.Modules;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.academic                  
{                  

    public class V___TermView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___TermView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Name.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermOrder = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermOrder.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAcademicSession = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AcademicSession.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAcademicSessionID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AcademicSessionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermStartDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermStartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermEndDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermEndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionStartDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SessionStartDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSessionEndDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SessionEndDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermOrderID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermOrderID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDescription = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Description.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defTermOrder.ColumnName, defTermOrder); 
          ColumnDefns.Add(defAcademicSession.ColumnName, defAcademicSession); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID); 
          ColumnDefns.Add(defTermStartDate.ColumnName, defTermStartDate); 
          ColumnDefns.Add(defTermEndDate.ColumnName, defTermEndDate); 
          ColumnDefns.Add(defSessionStartDate.ColumnName, defSessionStartDate); 
          ColumnDefns.Add(defSessionEndDate.ColumnName, defSessionEndDate); 
          ColumnDefns.Add(defTermOrderID.ColumnName, defTermOrderID); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDescription.ColumnName, defDescription); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("academic.AcademicSession");                  
            ReferencedTableNames.Add("academic.Term");                  
            ReferencedTableNames.Add("academic.TermOrder");                  

          }


                  
       public V___TermView() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___TermView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TermView(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public V___TermView(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "academic.TermView";
       public const string TermView__NO__BINARY___SQL_FILL_QUERY = "SELECT [Name], [TermOrder], [AcademicSession], [IsActive], [AcademicSessionID], [TermStartDate], [TermEndDate], [SessionStartDate], [SessionEndDate], [TermOrderID], [ID], [Description] FROM TermView";
       public const string TermView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [Name], [TermOrder], [AcademicSession], [IsActive], [AcademicSessionID], [TermStartDate], [TermEndDate], [SessionStartDate], [SessionEndDate], [TermOrderID], [ID], [Description] FROM TermView";


       public enum TableColumnNames
       {

           Name,
           TermOrder,
           AcademicSession,
           IsActive,
           AcademicSessionID,
           TermStartDate,
           TermEndDate,
           SessionStartDate,
           SessionEndDate,
           TermOrderID,
           ID,
           Description
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defTermOrder;
       public static readonly DataColumnDefinition defAcademicSession;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defAcademicSessionID;
       public static readonly DataColumnDefinition defTermStartDate;
       public static readonly DataColumnDefinition defTermEndDate;
       public static readonly DataColumnDefinition defSessionStartDate;
       public static readonly DataColumnDefinition defSessionEndDate;
       public static readonly DataColumnDefinition defTermOrderID;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDescription;

       public string Name { get => (string)TargettedRow[TableColumnNames.Name.ToString()]; }


       public string TermOrder { get => (string)TargettedRow[TableColumnNames.TermOrder.ToString()]; }


       public string AcademicSession { get => (string)TargettedRow[TableColumnNames.AcademicSession.ToString()]; }


       public bool IsActive { get => (bool)TargettedRow[TableColumnNames.IsActive.ToString()]; }


       public int AcademicSessionID { get => (int)TargettedRow[TableColumnNames.AcademicSessionID.ToString()]; }


       public DateTime TermStartDate { get => (DateTime)TargettedRow[TableColumnNames.TermStartDate.ToString()]; }


       public DateTime TermEndDate { get => (DateTime)TargettedRow[TableColumnNames.TermEndDate.ToString()]; }


       public DateTime SessionStartDate { get => (DateTime)TargettedRow[TableColumnNames.SessionStartDate.ToString()]; }


       public DateTime SessionEndDate { get => (DateTime)TargettedRow[TableColumnNames.SessionEndDate.ToString()]; }


       public int TermOrderID { get => (int)TargettedRow[TableColumnNames.TermOrderID.ToString()]; }


       public string Description { get => (string)TargettedRow[TableColumnNames.Description.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public V___TermView GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static V___TermView GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static V___TermView GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new V___TermView(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public V___TermView GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => TermView__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
