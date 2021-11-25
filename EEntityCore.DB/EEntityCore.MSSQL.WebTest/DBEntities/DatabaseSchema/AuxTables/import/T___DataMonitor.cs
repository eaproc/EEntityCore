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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.import                  
{                  

    public class T___DataMonitor : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___DataMonitor()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defImportTypeID = new DataColumnDefinition(TableColumnNames.ImportTypeID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defImportedFileName = new DataColumnDefinition(TableColumnNames.ImportedFileName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defFileSizeBytes = new DataColumnDefinition(TableColumnNames.FileSizeBytes.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotalRowsRead = new DataColumnDefinition(TableColumnNames.TotalRowsRead.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defImportTypeID.ColumnName, defImportTypeID); 
          ColumnDefns.Add(defImportedFileName.ColumnName, defImportedFileName); 
          ColumnDefns.Add(defFileSizeBytes.ColumnName, defFileSizeBytes); 
          ColumnDefns.Add(defTotalRowsRead.ColumnName, defTotalRowsRead); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_DataMonitor_ImportTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.DataMonitor", "import.ImportType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_DataMonitor_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.DataMonitor", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_DataMonitor_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.DataMonitor", "auth.Users"                  
                            ));                  

          }


                  
       public T___DataMonitor() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___DataMonitor(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DataMonitor(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___DataMonitor(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "import.DataMonitor";
       public const string DataMonitor__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [ImportTypeID], [ImportedFileName], [FileSizeBytes], [TotalRowsRead], [CreatedByID], [CreatedAt], [UpdatedByID], [UpdatedAt] FROM DataMonitor";
       public const string DataMonitor__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [ImportTypeID], [ImportedFileName], [FileSizeBytes], [TotalRowsRead], [CreatedByID], [CreatedAt], [UpdatedByID], [UpdatedAt] FROM DataMonitor";


       public enum TableColumnNames
       {

           ID,
           ImportTypeID,
           ImportedFileName,
           FileSizeBytes,
           TotalRowsRead,
           CreatedByID,
           CreatedAt,
           UpdatedByID,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_import_DataMonitor, 
           fk_import_DataMonitor_ImportTypeID, 
           fk_import_DataMonitor_CreatedByID, 
           fk_import_DataMonitor_UpdatedByID, 
           uq_import_DataMonitor_ImportedFileName, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defImportTypeID;
       public static readonly DataColumnDefinition defImportedFileName;
       public static readonly DataColumnDefinition defFileSizeBytes;
       public static readonly DataColumnDefinition defTotalRowsRead;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedByID;
       public static readonly DataColumnDefinition defUpdatedAt;

       public Int32 ImportTypeID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ImportTypeID.ToString()]);
           }
       }


       public String ImportedFileName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ImportedFileName.ToString()]);
           }
       }


       public Int32 FileSizeBytes {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.FileSizeBytes.ToString()]);
           }
       }


       public Int32 TotalRowsRead {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TotalRowsRead.ToString()]);
           }
       }


       public Int32 CreatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public Int32 UpdatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UpdatedByID.ToString()]);
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
        public T___DataMonitor GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___DataMonitor(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___DataMonitor GetFullTable()                  
        {                  
            return new T___DataMonitor(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___DataMonitor GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___DataMonitor(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___DataMonitor GetRowWhereID(int pID)                  
        {                  
            return new T___DataMonitor(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___DataMonitor pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___DataMonitor pRow, params DataColumnParameter[] pParams)                  
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
        public T___DataMonitor GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___DataMonitor(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___DataMonitor(drst);                  
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
        public T___DataMonitor getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___DataMonitor(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___DataMonitor(drst);                  
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

                  
        public virtual string GetFillSQL() => DataMonitor__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pImportTypeID,
String pImportedFileName,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramImportTypeID = new DataColumnParameter(defImportTypeID, pImportTypeID);
                DataColumnParameter paramImportedFileName = new DataColumnParameter(defImportedFileName, pImportedFileName);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramFileSizeBytes = new DataColumnParameter(defFileSizeBytes, defFileSizeBytes.DefaultValue);
                DataColumnParameter paramTotalRowsRead = new DataColumnParameter(defTotalRowsRead, defTotalRowsRead.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramImportTypeID.getSQLQuotedValueForAdd(),
                paramImportedFileName.getSQLQuotedValueForAdd(),
                paramFileSizeBytes.getSQLQuotedValueForAdd(),
                paramTotalRowsRead.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedByID.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pImportTypeID,
String pImportedFileName,
Int32 pFileSizeBytes,
Int32 pTotalRowsRead,
Int32 pCreatedByID,
DateTime pCreatedAt,
Object pUpdatedByID = null,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramImportTypeID = new DataColumnParameter(defImportTypeID, pImportTypeID);
                DataColumnParameter paramImportedFileName = new DataColumnParameter(defImportedFileName, pImportedFileName);
                DataColumnParameter paramFileSizeBytes = new DataColumnParameter(defFileSizeBytes, pFileSizeBytes);
                DataColumnParameter paramTotalRowsRead = new DataColumnParameter(defTotalRowsRead, pTotalRowsRead);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramImportTypeID.getSQLQuotedValueForAdd(),
paramImportedFileName.getSQLQuotedValueForAdd(),
paramFileSizeBytes.getSQLQuotedValueForAdd(),
paramTotalRowsRead.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pImportTypeID,
String pImportedFileName,
Int32 pFileSizeBytes,
Int32 pTotalRowsRead,
Int32 pCreatedByID,
DateTime pCreatedAt,
Object pUpdatedByID = null,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramImportTypeID = new DataColumnParameter(defImportTypeID, pImportTypeID);
DataColumnParameter paramImportedFileName = new DataColumnParameter(defImportedFileName, pImportedFileName);
DataColumnParameter paramFileSizeBytes = new DataColumnParameter(defFileSizeBytes, pFileSizeBytes);
DataColumnParameter paramTotalRowsRead = new DataColumnParameter(defTotalRowsRead, pTotalRowsRead);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramImportTypeID.getSQLQuotedValueForAdd(),
paramImportedFileName.getSQLQuotedValueForAdd(),
paramFileSizeBytes.getSQLQuotedValueForAdd(),
paramTotalRowsRead.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pImportTypeID,
String pImportedFileName,
Int32 pFileSizeBytes,
Int32 pTotalRowsRead,
Int32 pCreatedByID,
DateTime pCreatedAt,
Object pUpdatedByID= null,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramImportTypeID = new DataColumnParameter(defImportTypeID, pImportTypeID);
DataColumnParameter paramImportedFileName = new DataColumnParameter(defImportedFileName, pImportedFileName);
DataColumnParameter paramFileSizeBytes = new DataColumnParameter(defFileSizeBytes, pFileSizeBytes);
DataColumnParameter paramTotalRowsRead = new DataColumnParameter(defTotalRowsRead, pTotalRowsRead);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) ", TABLE_NAME,paramImportTypeID.getSQLQuotedValueForAdd(),
paramImportedFileName.getSQLQuotedValueForAdd(),
paramFileSizeBytes.getSQLQuotedValueForAdd(),
paramTotalRowsRead.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
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
Object pImportTypeID = null,
Object pImportedFileName = null,
Object pFileSizeBytes = null,
Object pTotalRowsRead = null,
Object pCreatedByID = null,
Object pCreatedAt = null,
Object pUpdatedByID = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramImportTypeID = new DataColumnParameter(defImportTypeID, pImportTypeID);
 DataColumnParameter paramImportedFileName = new DataColumnParameter(defImportedFileName, pImportedFileName);
 DataColumnParameter paramFileSizeBytes = new DataColumnParameter(defFileSizeBytes, pFileSizeBytes);
 DataColumnParameter paramTotalRowsRead = new DataColumnParameter(defTotalRowsRead, pTotalRowsRead);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [ImportTypeID]={2},[ImportedFileName]={3},[FileSizeBytes]={4},[TotalRowsRead]={5},[CreatedByID]={6},[CreatedAt]={7},[UpdatedByID]={8},[UpdatedAt]={9} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramImportTypeID.getSQLQuotedValueForUpdate(),
paramImportedFileName.getSQLQuotedValueForUpdate(),
paramFileSizeBytes.getSQLQuotedValueForUpdate(),
paramTotalRowsRead.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedByID.getSQLQuotedValueForUpdate(),
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
