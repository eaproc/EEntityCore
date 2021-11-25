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

    public class T___Link : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___Link()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defAppModuleID = new DataColumnDefinition(TableColumnNames.AppModuleID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defName = new DataColumnDefinition(TableColumnNames.Name.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLink = new DataColumnDefinition(TableColumnNames.Link.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defLinkPermissionID = new DataColumnDefinition(TableColumnNames.LinkPermissionID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defLinkParentID = new DataColumnDefinition(TableColumnNames.LinkParentID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defOwnedByRoleID = new DataColumnDefinition(TableColumnNames.OwnedByRoleID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDescription = new DataColumnDefinition(TableColumnNames.Description.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defAppModuleID.ColumnName, defAppModuleID); 
          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defLink.ColumnName, defLink); 
          ColumnDefns.Add(defLinkPermissionID.ColumnName, defLinkPermissionID); 
          ColumnDefns.Add(defLinkParentID.ColumnName, defLinkParentID); 
          ColumnDefns.Add(defOwnedByRoleID.ColumnName, defOwnedByRoleID); 
          ColumnDefns.Add(defDescription.ColumnName, defDescription); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_AppModuleID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.AppModule"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_LinkPermissionID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.LinkPermission"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_LinkParentID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.Link"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_OwnedByRoleID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.Role"                  
                            ));                  

          }


                  
       public T___Link() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Link(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Link(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Link(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "auth.Link";
       public const string Link__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [AppModuleID], [Name], [Link], [LinkPermissionID], [LinkParentID], [OwnedByRoleID], [Description], [CreatedAt], [UpdatedAt] FROM Link";
       public const string Link__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [AppModuleID], [Name], [Link], [LinkPermissionID], [LinkParentID], [OwnedByRoleID], [Description], [CreatedAt], [UpdatedAt] FROM Link";


       public enum TableColumnNames
       {

           ID,
           AppModuleID,
           Name,
           Link,
           LinkPermissionID,
           LinkParentID,
           OwnedByRoleID,
           Description,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_auth_Link, 
           fk_auth_Link_AppModuleID, 
           fk_auth_Link_LinkPermissionID, 
           fk_auth_Link_LinkParentID, 
           fk_auth_Link_OwnedByRoleID, 
           uq_auth_Link_Link, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defAppModuleID;
       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defLink;
       public static readonly DataColumnDefinition defLinkPermissionID;
       public static readonly DataColumnDefinition defLinkParentID;
       public static readonly DataColumnDefinition defOwnedByRoleID;
       public static readonly DataColumnDefinition defDescription;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public Int32 AppModuleID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.AppModuleID.ToString()]);
           }
       }


       public String Name {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Name.ToString()]);
           }
       }


       public String Link {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Link.ToString()]);
           }
       }


       public Int32 LinkPermissionID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.LinkPermissionID.ToString()]);
           }
       }


       public Int32 LinkParentID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.LinkParentID.ToString()]);
           }
       }


       public Int32 OwnedByRoleID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.OwnedByRoleID.ToString()]);
           }
       }


       public String Description {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Description.ToString()]);
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
        public T___Link GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___Link(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___Link GetFullTable()                  
        {                  
            return new T___Link(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___Link GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___Link(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___Link GetRowWhereID(int pID)                  
        {                  
            return new T___Link(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___Link pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___Link pRow, params DataColumnParameter[] pParams)                  
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
        public T___Link GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___Link(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Link(drst);                  
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
        public T___Link getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___Link(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Link(drst);                  
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

                  
        public virtual string GetFillSQL() => Link__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pAppModuleID,
String pLink,
Int32 pLinkPermissionID,
Int32 pLinkParentID,
Int32 pOwnedByRoleID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramAppModuleID = new DataColumnParameter(defAppModuleID, pAppModuleID);
                DataColumnParameter paramLink = new DataColumnParameter(defLink, pLink);
                DataColumnParameter paramLinkPermissionID = new DataColumnParameter(defLinkPermissionID, pLinkPermissionID);
                DataColumnParameter paramLinkParentID = new DataColumnParameter(defLinkParentID, pLinkParentID);
                DataColumnParameter paramOwnedByRoleID = new DataColumnParameter(defOwnedByRoleID, pOwnedByRoleID);
                DataColumnParameter paramName = new DataColumnParameter(defName, defName.DefaultValue);
                DataColumnParameter paramDescription = new DataColumnParameter(defDescription, defDescription.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramAppModuleID.getSQLQuotedValueForAdd(),
                paramName.getSQLQuotedValueForAdd(),
                paramLink.getSQLQuotedValueForAdd(),
                paramLinkPermissionID.getSQLQuotedValueForAdd(),
                paramLinkParentID.getSQLQuotedValueForAdd(),
                paramOwnedByRoleID.getSQLQuotedValueForAdd(),
                paramDescription.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pAppModuleID,
String pName,
String pLink,
Int32 pLinkPermissionID,
DateTime pCreatedAt,
Object pLinkParentID = null,
Object pOwnedByRoleID = null,
Object pDescription = null,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramAppModuleID = new DataColumnParameter(defAppModuleID, pAppModuleID);
                DataColumnParameter paramName = new DataColumnParameter(defName, pName);
                DataColumnParameter paramLink = new DataColumnParameter(defLink, pLink);
                DataColumnParameter paramLinkPermissionID = new DataColumnParameter(defLinkPermissionID, pLinkPermissionID);
                DataColumnParameter paramLinkParentID = new DataColumnParameter(defLinkParentID, pLinkParentID);
                DataColumnParameter paramOwnedByRoleID = new DataColumnParameter(defOwnedByRoleID, pOwnedByRoleID);
                DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramAppModuleID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramLink.getSQLQuotedValueForAdd(),
paramLinkPermissionID.getSQLQuotedValueForAdd(),
paramLinkParentID.getSQLQuotedValueForAdd(),
paramOwnedByRoleID.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pAppModuleID,
String pName,
String pLink,
Int32 pLinkPermissionID,
DateTime pCreatedAt,
Object pLinkParentID = null,
Object pOwnedByRoleID = null,
Object pDescription = null,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramAppModuleID = new DataColumnParameter(defAppModuleID, pAppModuleID);
DataColumnParameter paramName = new DataColumnParameter(defName, pName);
DataColumnParameter paramLink = new DataColumnParameter(defLink, pLink);
DataColumnParameter paramLinkPermissionID = new DataColumnParameter(defLinkPermissionID, pLinkPermissionID);
DataColumnParameter paramLinkParentID = new DataColumnParameter(defLinkParentID, pLinkParentID);
DataColumnParameter paramOwnedByRoleID = new DataColumnParameter(defOwnedByRoleID, pOwnedByRoleID);
DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramAppModuleID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramLink.getSQLQuotedValueForAdd(),
paramLinkPermissionID.getSQLQuotedValueForAdd(),
paramLinkParentID.getSQLQuotedValueForAdd(),
paramOwnedByRoleID.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pAppModuleID,
String pName,
String pLink,
Int32 pLinkPermissionID,
DateTime pCreatedAt,
Object pLinkParentID= null,
Object pOwnedByRoleID= null,
Object pDescription= null,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramAppModuleID = new DataColumnParameter(defAppModuleID, pAppModuleID);
DataColumnParameter paramName = new DataColumnParameter(defName, pName);
DataColumnParameter paramLink = new DataColumnParameter(defLink, pLink);
DataColumnParameter paramLinkPermissionID = new DataColumnParameter(defLinkPermissionID, pLinkPermissionID);
DataColumnParameter paramLinkParentID = new DataColumnParameter(defLinkParentID, pLinkParentID);
DataColumnParameter paramOwnedByRoleID = new DataColumnParameter(defOwnedByRoleID, pOwnedByRoleID);
DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) ", TABLE_NAME,paramAppModuleID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramLink.getSQLQuotedValueForAdd(),
paramLinkPermissionID.getSQLQuotedValueForAdd(),
paramLinkParentID.getSQLQuotedValueForAdd(),
paramOwnedByRoleID.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
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
Object pAppModuleID = null,
Object pName = null,
Object pLink = null,
Object pLinkPermissionID = null,
Object pCreatedAt = null,
Object pLinkParentID = null,
Object pOwnedByRoleID = null,
Object pDescription = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramAppModuleID = new DataColumnParameter(defAppModuleID, pAppModuleID);
 DataColumnParameter paramName = new DataColumnParameter(defName, pName);
 DataColumnParameter paramLink = new DataColumnParameter(defLink, pLink);
 DataColumnParameter paramLinkPermissionID = new DataColumnParameter(defLinkPermissionID, pLinkPermissionID);
 DataColumnParameter paramLinkParentID = new DataColumnParameter(defLinkParentID, pLinkParentID);
 DataColumnParameter paramOwnedByRoleID = new DataColumnParameter(defOwnedByRoleID, pOwnedByRoleID);
 DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [AppModuleID]={2},[Name]={3},[Link]={4},[LinkPermissionID]={5},[LinkParentID]={6},[OwnedByRoleID]={7},[Description]={8},[CreatedAt]={9},[UpdatedAt]={10} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramAppModuleID.getSQLQuotedValueForUpdate(),
paramName.getSQLQuotedValueForUpdate(),
paramLink.getSQLQuotedValueForUpdate(),
paramLinkPermissionID.getSQLQuotedValueForUpdate(),
paramLinkParentID.getSQLQuotedValueForUpdate(),
paramOwnedByRoleID.getSQLQuotedValueForUpdate(),
paramDescription.getSQLQuotedValueForUpdate(),
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
