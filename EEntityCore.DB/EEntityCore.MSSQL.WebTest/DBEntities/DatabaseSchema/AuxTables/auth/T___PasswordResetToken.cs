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

    public class T___PasswordResetToken : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PasswordResetToken()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defToken = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Token.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPasswordResetTypeID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PasswordResetTypeID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defExpiryDateTime = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExpiryDateTime.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsUsed = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsUsed.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defToken.ColumnName, defToken); 
          ColumnDefns.Add(defPasswordResetTypeID.ColumnName, defPasswordResetTypeID); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defExpiryDateTime.ColumnName, defExpiryDateTime); 
          ColumnDefns.Add(defIsUsed.ColumnName, defIsUsed); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_PasswordResetToken_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.PasswordResetToken", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_PasswordResetToken_PasswordResetTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.PasswordResetToken", "auth.PasswordResetType"                  
                            ));                  

          }


                  
       public T___PasswordResetToken() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetToken(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetToken(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetToken(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetToken(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PasswordResetToken(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetToken(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetToken(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PasswordResetToken(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PasswordResetToken(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.PasswordResetToken";
       public const string PasswordResetToken__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Token], [PasswordResetTypeID], [UserID], [ExpiryDateTime], [IsUsed], [CreatedAt], [UpdatedAt] FROM PasswordResetToken";
       public const string PasswordResetToken__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Token], [PasswordResetTypeID], [UserID], [ExpiryDateTime], [IsUsed], [CreatedAt], [UpdatedAt] FROM PasswordResetToken";


       public enum TableColumnNames
       {

           ID,
           Token,
           PasswordResetTypeID,
           UserID,
           ExpiryDateTime,
           IsUsed,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_auth_PasswordResetToken, 
           fk_auth_PasswordResetToken_UserID, 
           fk_auth_PasswordResetToken_PasswordResetTypeID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defToken;
       public static readonly DataColumnDefinition defPasswordResetTypeID;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defExpiryDateTime;
       public static readonly DataColumnDefinition defIsUsed;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public String Token {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Token.ToString()]);
           }
       }


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


       public NullableDateTime ExpiryDateTime {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.ExpiryDateTime.ToString()]);
           }
       }


       public Boolean IsUsed {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsUsed.ToString()]);
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
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___PasswordResetToken GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PasswordResetToken GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PasswordResetToken GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PasswordResetToken(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PasswordResetToken GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PasswordResetToken__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pPasswordResetTypeID,
Int32 pUserID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramToken = new DataColumnParameter(defToken, defToken.DefaultValue);
                DataColumnParameter paramExpiryDateTime = new DataColumnParameter(defExpiryDateTime, defExpiryDateTime.DefaultValue);
                DataColumnParameter paramIsUsed = new DataColumnParameter(defIsUsed, defIsUsed.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Token],[PasswordResetTypeID],[UserID],[ExpiryDateTime],[IsUsed],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramToken.GetSQLQuotedValueForAdd(),
                paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
                paramUserID.GetSQLQuotedValueForAdd(),
                paramExpiryDateTime.GetSQLQuotedValueForAdd(),
                paramIsUsed.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pToken,
Int32 pPasswordResetTypeID,
Int32 pUserID,
DateTime pExpiryDateTime,
Boolean pIsUsed,
DateTime pCreatedAt,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramToken = new DataColumnParameter(defToken, pToken);
                DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramExpiryDateTime = new DataColumnParameter(defExpiryDateTime, pExpiryDateTime);
                DataColumnParameter paramIsUsed = new DataColumnParameter(defIsUsed, pIsUsed);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Token],[PasswordResetTypeID],[UserID],[ExpiryDateTime],[IsUsed],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramToken.GetSQLQuotedValueForAdd(),
paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramExpiryDateTime.GetSQLQuotedValueForAdd(),
paramIsUsed.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pToken,
Int32 pPasswordResetTypeID,
Int32 pUserID,
DateTime pExpiryDateTime,
Boolean pIsUsed,
DateTime pCreatedAt,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramToken = new DataColumnParameter(defToken, pToken);
DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramExpiryDateTime = new DataColumnParameter(defExpiryDateTime, pExpiryDateTime);
DataColumnParameter paramIsUsed = new DataColumnParameter(defIsUsed, pIsUsed);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Token],[PasswordResetTypeID],[UserID],[ExpiryDateTime],[IsUsed],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramToken.GetSQLQuotedValueForAdd(),
paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramExpiryDateTime.GetSQLQuotedValueForAdd(),
paramIsUsed.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pToken,
Int32 pPasswordResetTypeID,
Int32 pUserID,
DateTime pExpiryDateTime,
Boolean pIsUsed,
DateTime pCreatedAt,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramToken = new DataColumnParameter(defToken, pToken);
DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramExpiryDateTime = new DataColumnParameter(defExpiryDateTime, pExpiryDateTime);
DataColumnParameter paramIsUsed = new DataColumnParameter(defIsUsed, pIsUsed);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([Token],[PasswordResetTypeID],[UserID],[ExpiryDateTime],[IsUsed],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7}) ", TABLE_NAME,paramToken.GetSQLQuotedValueForAdd(),
paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
paramUserID.GetSQLQuotedValueForAdd(),
paramExpiryDateTime.GetSQLQuotedValueForAdd(),
paramIsUsed.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);


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
Object pToken = null,
Object pPasswordResetTypeID = null,
Object pUserID = null,
Object pExpiryDateTime = null,
Object pIsUsed = null,
Object pCreatedAt = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramToken = new DataColumnParameter(defToken, pToken);
 DataColumnParameter paramPasswordResetTypeID = new DataColumnParameter(defPasswordResetTypeID, pPasswordResetTypeID);
 DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
 DataColumnParameter paramExpiryDateTime = new DataColumnParameter(defExpiryDateTime, pExpiryDateTime);
 DataColumnParameter paramIsUsed = new DataColumnParameter(defIsUsed, pIsUsed);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [Token]={2},[PasswordResetTypeID]={3},[UserID]={4},[ExpiryDateTime]={5},[IsUsed]={6},[CreatedAt]={7},[UpdatedAt]={8} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramToken.GetSQLQuotedValueForUpdate(),
paramPasswordResetTypeID.GetSQLQuotedValueForUpdate(),
paramUserID.GetSQLQuotedValueForUpdate(),
paramExpiryDateTime.GetSQLQuotedValueForUpdate(),
paramIsUsed.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate()  ), true);


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
