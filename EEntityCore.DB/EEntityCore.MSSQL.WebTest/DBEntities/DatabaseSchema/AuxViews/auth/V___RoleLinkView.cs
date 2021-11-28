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

    public class V___RoleLinkView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___RoleLinkView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRoleID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RoleID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBaseLinkID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BaseLinkID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBaseLinkPermissionID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BaseLinkPermissionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBaseLink = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BaseLink.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPermission = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Permission.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defInclusivePermissionID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.InclusivePermissionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defInclusivePermissionDefinition = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.InclusivePermissionDefinition.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defRoleID.ColumnName, defRoleID); 
          ColumnDefns.Add(defBaseLinkID.ColumnName, defBaseLinkID); 
          ColumnDefns.Add(defBaseLinkPermissionID.ColumnName, defBaseLinkPermissionID); 
          ColumnDefns.Add(defBaseLink.ColumnName, defBaseLink); 
          ColumnDefns.Add(defPermission.ColumnName, defPermission); 
          ColumnDefns.Add(defInclusivePermissionID.ColumnName, defInclusivePermissionID); 
          ColumnDefns.Add(defInclusivePermissionDefinition.ColumnName, defInclusivePermissionDefinition); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("auth.InclusivePermissionView");                  
            ReferencedTableNames.Add("auth.Link");                  
            ReferencedTableNames.Add("auth.RoleLink");                  

          }


                  
       public V___RoleLinkView() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___RoleLinkView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___RoleLinkView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___RoleLinkView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___RoleLinkView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___RoleLinkView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___RoleLinkView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___RoleLinkView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___RoleLinkView(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public V___RoleLinkView(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.RoleLinkView";
       public const string RoleLinkView__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [RoleID], [BaseLinkID], [BaseLinkPermissionID], [BaseLink], [Permission], [InclusivePermissionID], [InclusivePermissionDefinition] FROM RoleLinkView";
       public const string RoleLinkView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [RoleID], [BaseLinkID], [BaseLinkPermissionID], [BaseLink], [Permission], [InclusivePermissionID], [InclusivePermissionDefinition] FROM RoleLinkView";


       public enum TableColumnNames
       {

           ID,
           RoleID,
           BaseLinkID,
           BaseLinkPermissionID,
           BaseLink,
           Permission,
           InclusivePermissionID,
           InclusivePermissionDefinition
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defRoleID;
       public static readonly DataColumnDefinition defBaseLinkID;
       public static readonly DataColumnDefinition defBaseLinkPermissionID;
       public static readonly DataColumnDefinition defBaseLink;
       public static readonly DataColumnDefinition defPermission;
       public static readonly DataColumnDefinition defInclusivePermissionID;
       public static readonly DataColumnDefinition defInclusivePermissionDefinition;

       public int RoleID { get => (int)TargettedRow[TableColumnNames.RoleID.ToString()]; }


       public int BaseLinkID { get => (int)TargettedRow[TableColumnNames.BaseLinkID.ToString()]; }


       public int BaseLinkPermissionID { get => (int)TargettedRow[TableColumnNames.BaseLinkPermissionID.ToString()]; }


       public string BaseLink { get => (string)TargettedRow[TableColumnNames.BaseLink.ToString()]; }


       public string Permission { get => (string)TargettedRow[TableColumnNames.Permission.ToString()]; }


       public int InclusivePermissionID { get => (int)TargettedRow[TableColumnNames.InclusivePermissionID.ToString()]; }


       public string InclusivePermissionDefinition { get => (string)TargettedRow[TableColumnNames.InclusivePermissionDefinition.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public V___RoleLinkView GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static V___RoleLinkView GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static V___RoleLinkView GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new V___RoleLinkView(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public V___RoleLinkView GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => RoleLinkView__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
