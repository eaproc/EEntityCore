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

    public class T___PasswordResetHistory : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PasswordResetHistory()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defOldPassword = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.OldPassword.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNewPassword = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.NewPassword.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPasswordResetTypeID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PasswordResetTypeID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChangedByUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ChangedByUserID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIpAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IpAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defOldPassword.ColumnName, defOldPassword); 
          ColumnDefns.Add(defNewPassword.ColumnName, defNewPassword); 
          ColumnDefns.Add(defPasswordResetTypeID.ColumnName, defPasswordResetTypeID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defChangedByUserID.ColumnName, defChangedByUserID); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_PasswordResetHistory_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.PasswordResetHistory", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_PasswordResetHistory_PasswordResetTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.PasswordResetHistory", "auth.PasswordResetType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_PasswordResetHistory_ChangedByUserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.PasswordResetHistory", "auth.Users"                  
                            ));                  

          }


                  
       public T___PasswordResetHistory() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PasswordResetHistory(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetHistory(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PasswordResetHistory(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.PasswordResetHistory";
       public const string PasswordResetHistory__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [UserID], [OldPassword], [NewPassword], [PasswordResetTypeID], [CreatedAt], [ChangedByUserID], [IpAddress] FROM PasswordResetHistory";
       public const string PasswordResetHistory__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [UserID], [OldPassword], [NewPassword], [PasswordResetTypeID], [CreatedAt], [ChangedByUserID], [IpAddress] FROM PasswordResetHistory";


       public enum TableColumnNames
       {

           ID,
           UserID,
           OldPassword,
           NewPassword,
           PasswordResetTypeID,
           CreatedAt,
           ChangedByUserID,
           IpAddress
       } 



       public enum TableConstraints{

           pk_auth_PasswordResetHistory, 
           fk_auth_PasswordResetHistory_UserID, 
           fk_auth_PasswordResetHistory_PasswordResetTypeID, 
           fk_auth_PasswordResetHistory_ChangedByUserID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defOldPassword;
       public static readonly DataColumnDefinition defNewPassword;
       public static readonly DataColumnDefinition defPasswordResetTypeID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defChangedByUserID;
       public static readonly DataColumnDefinition defIpAddress;

       public Int32 UserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UserID.ToString()]);
           }
       }


       public String OldPassword {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.OldPassword.ToString()]);
           }
       }


       public String NewPassword {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.NewPassword.ToString()]);
           }
       }


       public Int32 PasswordResetTypeID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PasswordResetTypeID.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public Int32 ChangedByUserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ChangedByUserID.ToString()]);
           }
       }


       public String IpAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IpAddress.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___PasswordResetHistory GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PasswordResetHistory GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PasswordResetHistory GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PasswordResetHistory(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PasswordResetHistory GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PasswordResetHistory__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pUserID,
Int32 pPasswordResetTypeID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
                DataColumnParameter paramOldPassword = new DataColumnParameter(defOldPassword, defOldPassword.DefaultValue);
                DataColumnParameter paramNewPassword = new DataColumnParameter(defNewPassword, defNewPassword.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramChangedByUserID = new DataColumnParameter(defChangedByUserID, defChangedByUserID.DefaultValue);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, defIpAddress.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[OldPassword],[NewPassword],[PasswordResetTypeID],[CreatedAt],[ChangedByUserID],[IpAddress]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramUserID.GetSQLQuotedValueForAdd(),
                paramOldPassword.GetSQLQuotedValueForAdd(),
                paramNewPassword.GetSQLQuotedValueForAdd(),
                paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramChangedByUserID.GetSQLQuotedValueForAdd(),
                paramIpAddress.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pUserID,
String pOldPassword,
String pNewPassword,
Int32 pPasswordResetTypeID,
DateTime pCreatedAt,
Int32 pChangedByUserID,
String pIpAddress){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramOldPassword = new DataColumnParameter(defOldPassword, pOldPassword);
                DataColumnParameter paramNewPassword = new DataColumnParameter(defNewPassword, pNewPassword);
                DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramChangedByUserID = new DataColumnParameter(defChangedByUserID, pChangedByUserID);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[OldPassword],[NewPassword],[PasswordResetTypeID],[CreatedAt],[ChangedByUserID],[IpAddress]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramOldPassword.GetSQLQuotedValueForAdd(),
paramNewPassword.GetSQLQuotedValueForAdd(),
paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramChangedByUserID.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pUserID,
String pOldPassword,
String pNewPassword,
Int32 pPasswordResetTypeID,
DateTime pCreatedAt,
Int32 pChangedByUserID,
String pIpAddress){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramOldPassword = new DataColumnParameter(defOldPassword, pOldPassword);
DataColumnParameter paramNewPassword = new DataColumnParameter(defNewPassword, pNewPassword);
DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramChangedByUserID = new DataColumnParameter(defChangedByUserID, pChangedByUserID);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[OldPassword],[NewPassword],[PasswordResetTypeID],[CreatedAt],[ChangedByUserID],[IpAddress]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramOldPassword.GetSQLQuotedValueForAdd(),
paramNewPassword.GetSQLQuotedValueForAdd(),
paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramChangedByUserID.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pUserID,
String pOldPassword,
String pNewPassword,
Int32 pPasswordResetTypeID,
DateTime pCreatedAt,
Int32 pChangedByUserID,
String pIpAddress){

        try{

DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramOldPassword = new DataColumnParameter(defOldPassword, pOldPassword);
DataColumnParameter paramNewPassword = new DataColumnParameter(defNewPassword, pNewPassword);
DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramChangedByUserID = new DataColumnParameter(defChangedByUserID, pChangedByUserID);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([UserID],[OldPassword],[NewPassword],[PasswordResetTypeID],[CreatedAt],[ChangedByUserID],[IpAddress]) VALUES({1},{2},{3},{4},{5},{6},{7}) ", TABLE_NAME,paramUserID.GetSQLQuotedValueForAdd(),
paramOldPassword.GetSQLQuotedValueForAdd(),
paramNewPassword.GetSQLQuotedValueForAdd(),
paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramChangedByUserID.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd()  ), true);


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
Object pUserID = null,
Object pOldPassword = null,
Object pNewPassword = null,
Object pPasswordResetTypeID = null,
Object pCreatedAt = null,
Object pChangedByUserID = null,
Object pIpAddress = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
 DataColumnParameter paramOldPassword = new DataColumnParameter(defOldPassword, pOldPassword);
 DataColumnParameter paramNewPassword = new DataColumnParameter(defNewPassword, pNewPassword);
 DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramChangedByUserID = new DataColumnParameter(defChangedByUserID, pChangedByUserID);
 DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [UserID]={2},[OldPassword]={3},[NewPassword]={4},[PasswordResetTypeID]={5},[CreatedAt]={6},[ChangedByUserID]={7},[IpAddress]={8} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramUserID.GetSQLQuotedValueForUpdate(),
paramOldPassword.GetSQLQuotedValueForUpdate(),
paramNewPassword.GetSQLQuotedValueForUpdate(),
paramPasswordResetTypeID.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramChangedByUserID.GetSQLQuotedValueForUpdate(),
paramIpAddress.GetSQLQuotedValueForUpdate()  ), true);


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
