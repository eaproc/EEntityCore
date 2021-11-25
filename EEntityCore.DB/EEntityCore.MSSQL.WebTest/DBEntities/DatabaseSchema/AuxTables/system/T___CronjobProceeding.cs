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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.system                  
{                  

    public class T___CronjobProceeding : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___CronjobProceeding()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCronjobID = new DataColumnDefinition(TableColumnNames.CronjobID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defProceedingStatusID = new DataColumnDefinition(TableColumnNames.ProceedingStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNextExpectedExecutionTime = new DataColumnDefinition(TableColumnNames.NextExpectedExecutionTime.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsSuccessful = new DataColumnDefinition(TableColumnNames.IsSuccessful.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCronjobID.ColumnName, defCronjobID); 
          ColumnDefns.Add(defProceedingStatusID.ColumnName, defProceedingStatusID); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defNextExpectedExecutionTime.ColumnName, defNextExpectedExecutionTime); 
          ColumnDefns.Add(defIsSuccessful.ColumnName, defIsSuccessful); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_CronjobProceeding_CronjobID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "system.CronjobProceeding", "system.Cronjob"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_CronjobProceeding_ProceedingStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.CronjobProceeding", "system.CronjobProceedingStatus"                  
                            ));                  

          }


                  
       public T___CronjobProceeding() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___CronjobProceeding(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CronjobProceeding(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___CronjobProceeding(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "system.CronjobProceeding";
       public const string CronjobProceeding__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CronjobID], [ProceedingStatusID], [Comments], [NextExpectedExecutionTime], [IsSuccessful], [CreatedAt] FROM CronjobProceeding";
       public const string CronjobProceeding__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CronjobID], [ProceedingStatusID], [Comments], [NextExpectedExecutionTime], [IsSuccessful], [CreatedAt] FROM CronjobProceeding";


       public enum TableColumnNames
       {

           ID,
           CronjobID,
           ProceedingStatusID,
           Comments,
           NextExpectedExecutionTime,
           IsSuccessful,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_system_CronjobProceeding, 
           fk_system_CronjobProceeding_CronjobID, 
           fk_system_CronjobProceeding_ProceedingStatusID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCronjobID;
       public static readonly DataColumnDefinition defProceedingStatusID;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defNextExpectedExecutionTime;
       public static readonly DataColumnDefinition defIsSuccessful;
       public static readonly DataColumnDefinition defCreatedAt;

       public Int32 CronjobID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CronjobID.ToString()]);
           }
       }


       public Int32 ProceedingStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ProceedingStatusID.ToString()]);
           }
       }


       public String Comments {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Comments.ToString()]);
           }
       }


       public NullableDateTime NextExpectedExecutionTime {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.NextExpectedExecutionTime.ToString()]);
           }
       }


       public Boolean IsSuccessful {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsSuccessful.ToString()]);
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
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___CronjobProceeding GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___CronjobProceeding(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___CronjobProceeding GetFullTable()                  
        {                  
            return new T___CronjobProceeding(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___CronjobProceeding GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___CronjobProceeding(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___CronjobProceeding GetRowWhereID(int pID)                  
        {                  
            return new T___CronjobProceeding(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___CronjobProceeding pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___CronjobProceeding pRow, params DataColumnParameter[] pParams)                  
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
        public T___CronjobProceeding GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___CronjobProceeding(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___CronjobProceeding(drst);                  
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
        public T___CronjobProceeding getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___CronjobProceeding(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___CronjobProceeding(drst);                  
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

                  
        public virtual string GetFillSQL() => CronjobProceeding__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCronjobID,
Int32 pProceedingStatusID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCronjobID = new DataColumnParameter(defCronjobID, pCronjobID);
                DataColumnParameter paramProceedingStatusID = new DataColumnParameter(defProceedingStatusID, pProceedingStatusID);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, defComments.DefaultValue);
                DataColumnParameter paramNextExpectedExecutionTime = new DataColumnParameter(defNextExpectedExecutionTime, defNextExpectedExecutionTime.DefaultValue);
                DataColumnParameter paramIsSuccessful = new DataColumnParameter(defIsSuccessful, defIsSuccessful.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CronjobID],[ProceedingStatusID],[Comments],[NextExpectedExecutionTime],[IsSuccessful],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramCronjobID.getSQLQuotedValueForAdd(),
                paramProceedingStatusID.getSQLQuotedValueForAdd(),
                paramComments.getSQLQuotedValueForAdd(),
                paramNextExpectedExecutionTime.getSQLQuotedValueForAdd(),
                paramIsSuccessful.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pCronjobID,
Int32 pProceedingStatusID,
Boolean pIsSuccessful,
DateTime pCreatedAt,
Object pComments = null,
Object pNextExpectedExecutionTime = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCronjobID = new DataColumnParameter(defCronjobID, pCronjobID);
                DataColumnParameter paramProceedingStatusID = new DataColumnParameter(defProceedingStatusID, pProceedingStatusID);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
                DataColumnParameter paramNextExpectedExecutionTime = new DataColumnParameter(defNextExpectedExecutionTime, pNextExpectedExecutionTime);
                DataColumnParameter paramIsSuccessful = new DataColumnParameter(defIsSuccessful, pIsSuccessful);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CronjobID],[ProceedingStatusID],[Comments],[NextExpectedExecutionTime],[IsSuccessful],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCronjobID.getSQLQuotedValueForAdd(),
paramProceedingStatusID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramNextExpectedExecutionTime.getSQLQuotedValueForAdd(),
paramIsSuccessful.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pCronjobID,
Int32 pProceedingStatusID,
Boolean pIsSuccessful,
DateTime pCreatedAt,
Object pComments = null,
Object pNextExpectedExecutionTime = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramCronjobID = new DataColumnParameter(defCronjobID, pCronjobID);
DataColumnParameter paramProceedingStatusID = new DataColumnParameter(defProceedingStatusID, pProceedingStatusID);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramNextExpectedExecutionTime = new DataColumnParameter(defNextExpectedExecutionTime, pNextExpectedExecutionTime);
DataColumnParameter paramIsSuccessful = new DataColumnParameter(defIsSuccessful, pIsSuccessful);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CronjobID],[ProceedingStatusID],[Comments],[NextExpectedExecutionTime],[IsSuccessful],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCronjobID.getSQLQuotedValueForAdd(),
paramProceedingStatusID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramNextExpectedExecutionTime.getSQLQuotedValueForAdd(),
paramIsSuccessful.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pCronjobID,
Int32 pProceedingStatusID,
Boolean pIsSuccessful,
DateTime pCreatedAt,
Object pComments= null,
Object pNextExpectedExecutionTime= null){

        try{

DataColumnParameter paramCronjobID = new DataColumnParameter(defCronjobID, pCronjobID);
DataColumnParameter paramProceedingStatusID = new DataColumnParameter(defProceedingStatusID, pProceedingStatusID);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramNextExpectedExecutionTime = new DataColumnParameter(defNextExpectedExecutionTime, pNextExpectedExecutionTime);
DataColumnParameter paramIsSuccessful = new DataColumnParameter(defIsSuccessful, pIsSuccessful);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([CronjobID],[ProceedingStatusID],[Comments],[NextExpectedExecutionTime],[IsSuccessful],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6}) ", TABLE_NAME,paramCronjobID.getSQLQuotedValueForAdd(),
paramProceedingStatusID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramNextExpectedExecutionTime.getSQLQuotedValueForAdd(),
paramIsSuccessful.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), true);


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
Object pCronjobID = null,
Object pProceedingStatusID = null,
Object pIsSuccessful = null,
Object pCreatedAt = null,
Object pComments = null,
Object pNextExpectedExecutionTime = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramCronjobID = new DataColumnParameter(defCronjobID, pCronjobID);
 DataColumnParameter paramProceedingStatusID = new DataColumnParameter(defProceedingStatusID, pProceedingStatusID);
 DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
 DataColumnParameter paramNextExpectedExecutionTime = new DataColumnParameter(defNextExpectedExecutionTime, pNextExpectedExecutionTime);
 DataColumnParameter paramIsSuccessful = new DataColumnParameter(defIsSuccessful, pIsSuccessful);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [CronjobID]={2},[ProceedingStatusID]={3},[Comments]={4},[NextExpectedExecutionTime]={5},[IsSuccessful]={6},[CreatedAt]={7} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramCronjobID.getSQLQuotedValueForUpdate(),
paramProceedingStatusID.getSQLQuotedValueForUpdate(),
paramComments.getSQLQuotedValueForUpdate(),
paramNextExpectedExecutionTime.getSQLQuotedValueForUpdate(),
paramIsSuccessful.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate()  ), true);


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
