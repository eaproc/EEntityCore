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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.auth                  
{                  

    public class T___UserPasswordResetMode : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___UserPasswordResetMode()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPasswordResetTypeID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PasswordResetTypeID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defModeCarrier = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ModeCarrier.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPasswordResetTypeID.ColumnName, defPasswordResetTypeID); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defModeCarrier.ColumnName, defModeCarrier); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_UserPasswordResetMode_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.UserPasswordResetMode", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_UserPasswordResetMode_PasswordResetTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.UserPasswordResetMode", "auth.PasswordResetType"                  
                            ));                  

          }


                  
       public T___UserPasswordResetMode() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserPasswordResetMode(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserPasswordResetMode(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserPasswordResetMode(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserPasswordResetMode(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___UserPasswordResetMode(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserPasswordResetMode(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserPasswordResetMode(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserPasswordResetMode(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___UserPasswordResetMode(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.UserPasswordResetMode";
       public const string UserPasswordResetMode__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PasswordResetTypeID], [UserID], [ModeCarrier], [CreatedAt] FROM UserPasswordResetMode";
       public const string UserPasswordResetMode__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PasswordResetTypeID], [UserID], [ModeCarrier], [CreatedAt] FROM UserPasswordResetMode";


       public enum TableColumnNames
       {

           ID,
           PasswordResetTypeID,
           UserID,
           ModeCarrier,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_auth_UserPasswordResetMode, 
           fk_auth_UserPasswordResetMode_UserID, 
           fk_auth_UserPasswordResetMode_PasswordResetTypeID, 
           uq_auth_UserPasswordResetMode_PasswordResetTypeID, 
           uq_auth_UserPasswordResetMode_ModeCarrier, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPasswordResetTypeID;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defModeCarrier;
       public static readonly DataColumnDefinition defCreatedAt;

       public Int32 PasswordResetTypeID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PasswordResetTypeID.ToString()]);
           }
       }


       public Int32 UserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UserID.ToString()]);
           }
       }


       public String ModeCarrier {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ModeCarrier.ToString()]);
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
        public T___UserPasswordResetMode GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___UserPasswordResetMode GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___UserPasswordResetMode GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___UserPasswordResetMode(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___UserPasswordResetMode GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => UserPasswordResetMode__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pPasswordResetTypeID,
Int32 pUserID,
String pModeCarrier){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramModeCarrier = new DataColumnParameter(defModeCarrier, pModeCarrier);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PasswordResetTypeID],[UserID],[ModeCarrier],[CreatedAt]) VALUES({1},{2},{3},{4},{5}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
                paramUserID.GetSQLQuotedValueForAdd(),
                paramModeCarrier.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pPasswordResetTypeID,
Int32 pUserID,
String pModeCarrier,
DateTime pCreatedAt){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramModeCarrier = new DataColumnParameter(defModeCarrier, pModeCarrier);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PasswordResetTypeID],[UserID],[ModeCarrier],[CreatedAt]) VALUES({1},{2},{3},{4},{5}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramModeCarrier.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pPasswordResetTypeID,
Int32 pUserID,
String pModeCarrier,
DateTime pCreatedAt){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramModeCarrier = new DataColumnParameter(defModeCarrier, pModeCarrier);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PasswordResetTypeID],[UserID],[ModeCarrier],[CreatedAt]) VALUES({1},{2},{3},{4},{5}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramModeCarrier.GetSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pPasswordResetTypeID,
Int32 pUserID,
String pModeCarrier,
DateTime pCreatedAt){

        try{

DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramModeCarrier = new DataColumnParameter(defModeCarrier, pModeCarrier);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([PasswordResetTypeID],[UserID],[ModeCarrier],[CreatedAt]) VALUES({1},{2},{3},{4}) ", TABLE_NAME,paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramModeCarrier.GetSQLQuotedValueForAdd(),
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
Object pPasswordResetTypeID = null,
Object pUserID = null,
Object pModeCarrier = null,
Object pCreatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
 DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
 DataColumnParameter paramModeCarrier = new DataColumnParameter(defModeCarrier, pModeCarrier);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [PasswordResetTypeID]={2},[UserID]={3},[ModeCarrier]={4},[CreatedAt]={5} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramPasswordResetTypeID.GetSQLQuotedValueForUpdate(),
paramUserID.GetSQLQuotedValueForUpdate(),
paramModeCarrier.GetSQLQuotedValueForUpdate(),
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
