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

    public class T___Users : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Users()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defUsername = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Username.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defUserPassword = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserPassword.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRememberToken = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RememberToken.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsActive.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defResetModeCarrier = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ResetModeCarrier.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defUsername.ColumnName, defUsername); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defUserPassword.ColumnName, defUserPassword); 
          ColumnDefns.Add(defRememberToken.ColumnName, defRememberToken); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defResetModeCarrier.ColumnName, defResetModeCarrier); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Users_PersonID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "auth.Users", "common.Person"                  
                            ));                  

          }


                  
       public T___Users() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Users(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Users(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Users(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.Users";
       public const string Users__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Username], [PersonID], [UserPassword], [RememberToken], [IsActive], [CreatedAt], [UpdatedAt], [ResetModeCarrier] FROM Users";
       public const string Users__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Username], [PersonID], [UserPassword], [RememberToken], [IsActive], [CreatedAt], [UpdatedAt], [ResetModeCarrier] FROM Users";


       public enum TableColumnNames
       {

           ID,
           Username,
           PersonID,
           UserPassword,
           RememberToken,
           IsActive,
           CreatedAt,
           UpdatedAt,
           ResetModeCarrier
       } 



       public enum TableConstraints{

           pk_auth_Users, 
           fk_auth_Users_PersonID, 
           uq_auth_Users_PersonID, 
           uq_auth_Users_Username, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defUsername;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defUserPassword;
       public static readonly DataColumnDefinition defRememberToken;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defResetModeCarrier;

       public String Username {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Username.ToString()]);
           }
       }


       public Int32 PersonID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonID.ToString()]);
           }
       }


       public String UserPassword {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.UserPassword.ToString()]);
           }
       }


       public String RememberToken {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.RememberToken.ToString()]);
           }
       }


       public Boolean IsActive {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsActive.ToString()]);
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


       public String ResetModeCarrier {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ResetModeCarrier.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Users GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Users GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Users GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Users(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Users GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Users__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(String pUsername,
Int32 pPersonID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramUsername = new DataColumnParameter(defUsername, pUsername);
                DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
                DataColumnParameter paramUserPassword = new DataColumnParameter(defUserPassword, defUserPassword.DefaultValue);
                DataColumnParameter paramRememberToken = new DataColumnParameter(defRememberToken, defRememberToken.DefaultValue);
                DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, defIsActive.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramResetModeCarrier = new DataColumnParameter(defResetModeCarrier, defResetModeCarrier.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Username],[PersonID],[UserPassword],[RememberToken],[IsActive],[CreatedAt],[UpdatedAt],[ResetModeCarrier]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramUsername.GetSQLQuotedValueForAdd(),
                paramPersonID.GetSQLQuotedValueForAdd(),
                paramUserPassword.GetSQLQuotedValueForAdd(),
                paramRememberToken.GetSQLQuotedValueForAdd(),
                paramIsActive.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd(),
                paramResetModeCarrier.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pUsername,
Int32 pPersonID,
String pUserPassword,
Boolean pIsActive,
DateTime pCreatedAt,
Object pRememberToken = null,
Object pUpdatedAt = null,
Object pResetModeCarrier = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramUsername = new DataColumnParameter(defUsername, pUsername);
                DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
                DataColumnParameter paramUserPassword = new DataColumnParameter(defUserPassword, pUserPassword);
                DataColumnParameter paramRememberToken = new DataColumnParameter(defRememberToken, pRememberToken);
                DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramResetModeCarrier = new DataColumnParameter(defResetModeCarrier, pResetModeCarrier);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Username],[PersonID],[UserPassword],[RememberToken],[IsActive],[CreatedAt],[UpdatedAt],[ResetModeCarrier]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramUsername.GetSQLQuotedValueForAdd(),
paramPersonID.GetSQLQuotedValueForAdd(),
paramUserPassword.GetSQLQuotedValueForAdd(),
paramRememberToken.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramResetModeCarrier.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pUsername,
Int32 pPersonID,
String pUserPassword,
Boolean pIsActive,
DateTime pCreatedAt,
Object pRememberToken = null,
Object pUpdatedAt = null,
Object pResetModeCarrier = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramUsername = new DataColumnParameter(defUsername, pUsername);
DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
DataColumnParameter paramUserPassword = new DataColumnParameter(defUserPassword, pUserPassword);
DataColumnParameter paramRememberToken = new DataColumnParameter(defRememberToken, pRememberToken);
DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramResetModeCarrier = new DataColumnParameter(defResetModeCarrier, pResetModeCarrier);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Username],[PersonID],[UserPassword],[RememberToken],[IsActive],[CreatedAt],[UpdatedAt],[ResetModeCarrier]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramUsername.GetSQLQuotedValueForAdd(),
paramPersonID.GetSQLQuotedValueForAdd(),
paramUserPassword.GetSQLQuotedValueForAdd(),
paramRememberToken.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramResetModeCarrier.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pUsername,
Int32 pPersonID,
String pUserPassword,
Boolean pIsActive,
DateTime pCreatedAt,
Object pRememberToken= null,
Object pUpdatedAt= null,
Object pResetModeCarrier= null){

        try{

DataColumnParameter paramUsername = new DataColumnParameter(defUsername, pUsername);
DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
DataColumnParameter paramUserPassword = new DataColumnParameter(defUserPassword, pUserPassword);
DataColumnParameter paramRememberToken = new DataColumnParameter(defRememberToken, pRememberToken);
DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramResetModeCarrier = new DataColumnParameter(defResetModeCarrier, pResetModeCarrier);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([Username],[PersonID],[UserPassword],[RememberToken],[IsActive],[CreatedAt],[UpdatedAt],[ResetModeCarrier]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) ", TABLE_NAME,paramUsername.GetSQLQuotedValueForAdd(),
paramPersonID.GetSQLQuotedValueForAdd(),
paramUserPassword.GetSQLQuotedValueForAdd(),
paramRememberToken.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramResetModeCarrier.GetSQLQuotedValueForAdd()  ), true);


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
Object pUsername = null,
Object pPersonID = null,
Object pUserPassword = null,
Object pIsActive = null,
Object pCreatedAt = null,
Object pRememberToken = null,
Object pUpdatedAt = null,
Object pResetModeCarrier = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramUsername = new DataColumnParameter(defUsername, pUsername);
 DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
 DataColumnParameter paramUserPassword = new DataColumnParameter(defUserPassword, pUserPassword);
 DataColumnParameter paramRememberToken = new DataColumnParameter(defRememberToken, pRememberToken);
 DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramResetModeCarrier = new DataColumnParameter(defResetModeCarrier, pResetModeCarrier);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [Username]={2},[PersonID]={3},[UserPassword]={4},[RememberToken]={5},[IsActive]={6},[CreatedAt]={7},[UpdatedAt]={8},[ResetModeCarrier]={9} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramUsername.GetSQLQuotedValueForUpdate(),
paramPersonID.GetSQLQuotedValueForUpdate(),
paramUserPassword.GetSQLQuotedValueForUpdate(),
paramRememberToken.GetSQLQuotedValueForUpdate(),
paramIsActive.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramResetModeCarrier.GetSQLQuotedValueForUpdate()  ), true);


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
