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
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defToken = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Token.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPasswordResetTypeID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PasswordResetTypeID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defExpiryDateTime = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExpiryDateTime.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsUsed = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsUsed.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       public string Token { get => (string)TargettedRow[TableColumnNames.Token.ToString()]; }


       public int PasswordResetTypeID { get => (int)TargettedRow[TableColumnNames.PasswordResetTypeID.ToString()]; }


       public int UserID { get => (int)TargettedRow[TableColumnNames.UserID.ToString()]; }


       public DateTime ExpiryDateTime { get => (DateTime)TargettedRow[TableColumnNames.ExpiryDateTime.ToString()]; }


       public bool IsUsed { get => (bool)TargettedRow[TableColumnNames.IsUsed.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


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
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int ID,
            string Token,
            int PasswordResetTypeID,
            int UserID,
            DateTime ExpiryDateTime,
            bool IsUsed,
            DateTime CreatedAt,
            DateTime? UpdatedAt = null
          ){

            try{

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramToken = new (defToken, Token);
                DataColumnParameter paramPasswordResetTypeID = new (defPasswordResetTypeID, PasswordResetTypeID);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramExpiryDateTime = new (defExpiryDateTime, ExpiryDateTime);
                DataColumnParameter paramIsUsed = new (defIsUsed, IsUsed);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);


                return DBConnectInterface.GetDBConn().DbExec(
     string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Token],[PasswordResetTypeID],[UserID],[ExpiryDateTime],[IsUsed],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramToken.GetSQLQuotedValueForAdd(),
                        paramPasswordResetTypeID.GetSQLQuotedValueForAdd(),
                        paramUserID.GetSQLQuotedValueForAdd(),
                        paramExpiryDateTime.GetSQLQuotedValueForAdd(),
                        paramIsUsed.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd()                        ) 
                      );


                  
                  
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
