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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.system                  
{                  

    public class T___PaystackLog : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PaystackLog()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPaymentGatewayStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentGatewayStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsFinalized = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsFinalized.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defInitializedByUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.InitializedByUserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defReference = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Reference.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccessCode = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccessCode.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defInitialLizeURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.InitialLizeURL.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentURL.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifiyURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.VerifiyURL.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAmountKobo = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AmountKobo.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifyResponseJSON = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.VerifyResponseJSON.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifiedByUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.VerifiedByUserID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPaymentGatewayStatusID.ColumnName, defPaymentGatewayStatusID); 
          ColumnDefns.Add(defIsFinalized.ColumnName, defIsFinalized); 
          ColumnDefns.Add(defInitializedByUserID.ColumnName, defInitializedByUserID); 
          ColumnDefns.Add(defReference.ColumnName, defReference); 
          ColumnDefns.Add(defAccessCode.ColumnName, defAccessCode); 
          ColumnDefns.Add(defInitialLizeURL.ColumnName, defInitialLizeURL); 
          ColumnDefns.Add(defPaymentURL.ColumnName, defPaymentURL); 
          ColumnDefns.Add(defVerifiyURL.ColumnName, defVerifiyURL); 
          ColumnDefns.Add(defAmountKobo.ColumnName, defAmountKobo); 
          ColumnDefns.Add(defVerifyResponseJSON.ColumnName, defVerifyResponseJSON); 
          ColumnDefns.Add(defVerifiedByUserID.ColumnName, defVerifiedByUserID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_PaystackLog_PaymentGatewayStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.PaystackLog", "system.PaymentGatewayStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_PaystackLog_InitializedByUserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.PaystackLog", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_PaystackLog_VerifiedByUserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.PaystackLog", "auth.Users"                  
                            ));                  

          }


                  
       public T___PaystackLog() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PaystackLog(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaystackLog(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PaystackLog(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.PaystackLog";
       public const string PaystackLog__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PaymentGatewayStatusID], [IsFinalized], [InitializedByUserID], [Reference], [AccessCode], [InitialLizeURL], [PaymentURL], [VerifiyURL], [AmountKobo], [VerifyResponseJSON], [VerifiedByUserID], [CreatedAt], [UpdatedAt] FROM PaystackLog";
       public const string PaystackLog__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PaymentGatewayStatusID], [IsFinalized], [InitializedByUserID], [Reference], [AccessCode], [InitialLizeURL], [PaymentURL], [VerifiyURL], [AmountKobo], [VerifyResponseJSON], [VerifiedByUserID], [CreatedAt], [UpdatedAt] FROM PaystackLog";


       public enum TableColumnNames
       {

           ID,
           PaymentGatewayStatusID,
           IsFinalized,
           InitializedByUserID,
           Reference,
           AccessCode,
           InitialLizeURL,
           PaymentURL,
           VerifiyURL,
           AmountKobo,
           VerifyResponseJSON,
           VerifiedByUserID,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_system_PaystackLog, 
           fk_system_PaystackLog_PaymentGatewayStatusID, 
           fk_system_PaystackLog_InitializedByUserID, 
           fk_system_PaystackLog_VerifiedByUserID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPaymentGatewayStatusID;
       public static readonly DataColumnDefinition defIsFinalized;
       public static readonly DataColumnDefinition defInitializedByUserID;
       public static readonly DataColumnDefinition defReference;
       public static readonly DataColumnDefinition defAccessCode;
       public static readonly DataColumnDefinition defInitialLizeURL;
       public static readonly DataColumnDefinition defPaymentURL;
       public static readonly DataColumnDefinition defVerifiyURL;
       public static readonly DataColumnDefinition defAmountKobo;
       public static readonly DataColumnDefinition defVerifyResponseJSON;
       public static readonly DataColumnDefinition defVerifiedByUserID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public int PaymentGatewayStatusID { get => (int)TargettedRow[TableColumnNames.PaymentGatewayStatusID.ToString()]; }


       public bool IsFinalized { get => (bool)TargettedRow[TableColumnNames.IsFinalized.ToString()]; }


       public int InitializedByUserID { get => (int)TargettedRow[TableColumnNames.InitializedByUserID.ToString()]; }


       public string Reference { get => (string)TargettedRow[TableColumnNames.Reference.ToString()]; }


       public string AccessCode { get => (string)TargettedRow[TableColumnNames.AccessCode.ToString()]; }


       public string InitialLizeURL { get => (string)TargettedRow[TableColumnNames.InitialLizeURL.ToString()]; }


       public string PaymentURL { get => (string)TargettedRow[TableColumnNames.PaymentURL.ToString()]; }


       public string VerifiyURL { get => (string)TargettedRow[TableColumnNames.VerifiyURL.ToString()]; }


       public int AmountKobo { get => (int)TargettedRow[TableColumnNames.AmountKobo.ToString()]; }


       public string VerifyResponseJSON { get => (string)TargettedRow[TableColumnNames.VerifyResponseJSON.ToString()]; }


       public int? VerifiedByUserID { get => (int?)TargettedRow[TableColumnNames.VerifiedByUserID.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___PaystackLog GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PaystackLog GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PaystackLog GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PaystackLog(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PaystackLog GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PaystackLog__NO__BINARY___SQL_FILL_QUERY;
                  
                  
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
            int PaymentGatewayStatusID,
            bool IsFinalized,
            int InitializedByUserID,
            string InitialLizeURL,
            int AmountKobo,
            DateTime CreatedAt,
            string Reference = null,
            string AccessCode = null,
            string PaymentURL = null,
            string VerifiyURL = null,
            string VerifyResponseJSON = null,
            int? VerifiedByUserID = null,
            DateTime? UpdatedAt = null
          ){

            try{

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPaymentGatewayStatusID = new (defPaymentGatewayStatusID, PaymentGatewayStatusID);
                DataColumnParameter paramIsFinalized = new (defIsFinalized, IsFinalized);
                DataColumnParameter paramInitializedByUserID = new (defInitializedByUserID, InitializedByUserID);
                DataColumnParameter paramReference = new (defReference, Reference);
                DataColumnParameter paramAccessCode = new (defAccessCode, AccessCode);
                DataColumnParameter paramInitialLizeURL = new (defInitialLizeURL, InitialLizeURL);
                DataColumnParameter paramPaymentURL = new (defPaymentURL, PaymentURL);
                DataColumnParameter paramVerifiyURL = new (defVerifiyURL, VerifiyURL);
                DataColumnParameter paramAmountKobo = new (defAmountKobo, AmountKobo);
                DataColumnParameter paramVerifyResponseJSON = new (defVerifyResponseJSON, VerifyResponseJSON);
                DataColumnParameter paramVerifiedByUserID = new (defVerifiedByUserID, VerifiedByUserID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);


                return DBConnectInterface.GetDBConn().DbExec(
     string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramPaymentGatewayStatusID.GetSQLQuotedValueForAdd(),
                        paramIsFinalized.GetSQLQuotedValueForAdd(),
                        paramInitializedByUserID.GetSQLQuotedValueForAdd(),
                        paramReference.GetSQLQuotedValueForAdd(),
                        paramAccessCode.GetSQLQuotedValueForAdd(),
                        paramInitialLizeURL.GetSQLQuotedValueForAdd(),
                        paramPaymentURL.GetSQLQuotedValueForAdd(),
                        paramVerifiyURL.GetSQLQuotedValueForAdd(),
                        paramAmountKobo.GetSQLQuotedValueForAdd(),
                        paramVerifyResponseJSON.GetSQLQuotedValueForAdd(),
                        paramVerifiedByUserID.GetSQLQuotedValueForAdd(),
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
