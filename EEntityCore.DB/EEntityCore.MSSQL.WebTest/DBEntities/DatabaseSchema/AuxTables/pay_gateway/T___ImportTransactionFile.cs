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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.pay_gateway                  
{                  

    public class T___ImportTransactionFile : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ImportTransactionFile()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defFilePath = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FilePath.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defFilePath.ColumnName, defFilePath); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.ImportTransactionFile", "auth.Users"                  
                            ));                  

          }


                  
       public T___ImportTransactionFile() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ImportTransactionFile(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ImportTransactionFile(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ImportTransactionFile(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ImportTransactionFile(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ImportTransactionFile(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ImportTransactionFile(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ImportTransactionFile(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ImportTransactionFile(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___ImportTransactionFile(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "pay_gateway.ImportTransactionFile";
       public const string ImportTransactionFile__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [FilePath], [CreatedAt], [CreatedByID] FROM ImportTransactionFile";
       public const string ImportTransactionFile__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [FilePath], [CreatedAt], [CreatedByID] FROM ImportTransactionFile";


       public enum TableColumnNames
       {

           ID,
           FilePath,
           CreatedAt,
           CreatedByID
       } 



       public enum TableConstraints{

           pk_pay_gateway_ImportTransactionFile, 
           fk_pay_gateway_CreatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defFilePath;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;

       public String FilePath {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FilePath.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public Int32 CreatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___ImportTransactionFile GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___ImportTransactionFile GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___ImportTransactionFile GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___ImportTransactionFile(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___ImportTransactionFile GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => ImportTransactionFile__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCreatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramFilePath = new DataColumnParameter(defFilePath, defFilePath.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[FilePath],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramFilePath.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pFilePath,
DateTime pCreatedAt,
Int32 pCreatedByID){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramFilePath = new DataColumnParameter(defFilePath, pFilePath);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[FilePath],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramFilePath.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pFilePath,
DateTime pCreatedAt,
Int32 pCreatedByID){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramFilePath = new DataColumnParameter(defFilePath, pFilePath);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[FilePath],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramFilePath.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pFilePath,
DateTime pCreatedAt,
Int32 pCreatedByID){

        try{

DataColumnParameter paramFilePath = new DataColumnParameter(defFilePath, pFilePath);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([FilePath],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3}) ", TABLE_NAME,paramFilePath.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);


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
Object pFilePath = null,
Object pCreatedAt = null,
Object pCreatedByID = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramFilePath = new DataColumnParameter(defFilePath, pFilePath);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [FilePath]={2},[CreatedAt]={3},[CreatedByID]={4} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramFilePath.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedByID.GetSQLQuotedValueForUpdate()  ), true);


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
