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
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPaymentGatewayStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentGatewayStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsFinalized = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsFinalized.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defInitializedByUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.InitializedByUserID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defReference = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Reference.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccessCode = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccessCode.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defInitialLizeURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.InitialLizeURL.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentURL.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifiyURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.VerifiyURL.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAmountKobo = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AmountKobo.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifyResponseJSON = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.VerifyResponseJSON.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifiedByUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.VerifiedByUserID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       public Int32 PaymentGatewayStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PaymentGatewayStatusID.ToString()]);
           }
       }


       public Boolean IsFinalized {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsFinalized.ToString()]);
           }
       }


       public Int32 InitializedByUserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.InitializedByUserID.ToString()]);
           }
       }


       public String Reference {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Reference.ToString()]);
           }
       }


       public String AccessCode {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccessCode.ToString()]);
           }
       }


       public String InitialLizeURL {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.InitialLizeURL.ToString()]);
           }
       }


       public String PaymentURL {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PaymentURL.ToString()]);
           }
       }


       public String VerifiyURL {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.VerifiyURL.ToString()]);
           }
       }


       public Int32 AmountKobo {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.AmountKobo.ToString()]);
           }
       }


       public String VerifyResponseJSON {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.VerifyResponseJSON.ToString()]);
           }
       }


       public Int32 VerifiedByUserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.VerifiedByUserID.ToString()]);
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
                  
                  




        public static int AddNewDefault(Int32 pPaymentGatewayStatusID,
Int32 pInitializedByUserID,
Int32 pVerifiedByUserID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPaymentGatewayStatusID = new DataColumnParameter(defPaymentGatewayStatusID, pPaymentGatewayStatusID);
                DataColumnParameter paramInitializedByUserID = new DataColumnParameter(defInitializedByUserID, pInitializedByUserID);
                DataColumnParameter paramVerifiedByUserID = new DataColumnParameter(defVerifiedByUserID, pVerifiedByUserID);
                DataColumnParameter paramIsFinalized = new DataColumnParameter(defIsFinalized, defIsFinalized.DefaultValue);
                DataColumnParameter paramReference = new DataColumnParameter(defReference, defReference.DefaultValue);
                DataColumnParameter paramAccessCode = new DataColumnParameter(defAccessCode, defAccessCode.DefaultValue);
                DataColumnParameter paramInitialLizeURL = new DataColumnParameter(defInitialLizeURL, defInitialLizeURL.DefaultValue);
                DataColumnParameter paramPaymentURL = new DataColumnParameter(defPaymentURL, defPaymentURL.DefaultValue);
                DataColumnParameter paramVerifiyURL = new DataColumnParameter(defVerifiyURL, defVerifiyURL.DefaultValue);
                DataColumnParameter paramAmountKobo = new DataColumnParameter(defAmountKobo, defAmountKobo.DefaultValue);
                DataColumnParameter paramVerifyResponseJSON = new DataColumnParameter(defVerifyResponseJSON, defVerifyResponseJSON.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
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
                paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pPaymentGatewayStatusID,
Boolean pIsFinalized,
Int32 pInitializedByUserID,
String pInitialLizeURL,
Int32 pAmountKobo,
DateTime pCreatedAt,
Object pReference = null,
Object pAccessCode = null,
Object pPaymentURL = null,
Object pVerifiyURL = null,
Object pVerifyResponseJSON = null,
Object pVerifiedByUserID = null,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPaymentGatewayStatusID = new DataColumnParameter(defPaymentGatewayStatusID, pPaymentGatewayStatusID);
                DataColumnParameter paramIsFinalized = new DataColumnParameter(defIsFinalized, pIsFinalized);
                DataColumnParameter paramInitializedByUserID = new DataColumnParameter(defInitializedByUserID, pInitializedByUserID);
                DataColumnParameter paramReference = new DataColumnParameter(defReference, pReference);
                DataColumnParameter paramAccessCode = new DataColumnParameter(defAccessCode, pAccessCode);
                DataColumnParameter paramInitialLizeURL = new DataColumnParameter(defInitialLizeURL, pInitialLizeURL);
                DataColumnParameter paramPaymentURL = new DataColumnParameter(defPaymentURL, pPaymentURL);
                DataColumnParameter paramVerifiyURL = new DataColumnParameter(defVerifiyURL, pVerifiyURL);
                DataColumnParameter paramAmountKobo = new DataColumnParameter(defAmountKobo, pAmountKobo);
                DataColumnParameter paramVerifyResponseJSON = new DataColumnParameter(defVerifyResponseJSON, pVerifyResponseJSON);
                DataColumnParameter paramVerifiedByUserID = new DataColumnParameter(defVerifiedByUserID, pVerifiedByUserID);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pPaymentGatewayStatusID,
Boolean pIsFinalized,
Int32 pInitializedByUserID,
String pInitialLizeURL,
Int32 pAmountKobo,
DateTime pCreatedAt,
Object pReference = null,
Object pAccessCode = null,
Object pPaymentURL = null,
Object pVerifiyURL = null,
Object pVerifyResponseJSON = null,
Object pVerifiedByUserID = null,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramPaymentGatewayStatusID = new DataColumnParameter(defPaymentGatewayStatusID, pPaymentGatewayStatusID);
DataColumnParameter paramIsFinalized = new DataColumnParameter(defIsFinalized, pIsFinalized);
DataColumnParameter paramInitializedByUserID = new DataColumnParameter(defInitializedByUserID, pInitializedByUserID);
DataColumnParameter paramReference = new DataColumnParameter(defReference, pReference);
DataColumnParameter paramAccessCode = new DataColumnParameter(defAccessCode, pAccessCode);
DataColumnParameter paramInitialLizeURL = new DataColumnParameter(defInitialLizeURL, pInitialLizeURL);
DataColumnParameter paramPaymentURL = new DataColumnParameter(defPaymentURL, pPaymentURL);
DataColumnParameter paramVerifiyURL = new DataColumnParameter(defVerifiyURL, pVerifiyURL);
DataColumnParameter paramAmountKobo = new DataColumnParameter(defAmountKobo, pAmountKobo);
DataColumnParameter paramVerifyResponseJSON = new DataColumnParameter(defVerifyResponseJSON, pVerifyResponseJSON);
DataColumnParameter paramVerifiedByUserID = new DataColumnParameter(defVerifiedByUserID, pVerifiedByUserID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pPaymentGatewayStatusID,
Boolean pIsFinalized,
Int32 pInitializedByUserID,
String pInitialLizeURL,
Int32 pAmountKobo,
DateTime pCreatedAt,
Object pReference= null,
Object pAccessCode= null,
Object pPaymentURL= null,
Object pVerifiyURL= null,
Object pVerifyResponseJSON= null,
Object pVerifiedByUserID= null,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramPaymentGatewayStatusID = new DataColumnParameter(defPaymentGatewayStatusID, pPaymentGatewayStatusID);
DataColumnParameter paramIsFinalized = new DataColumnParameter(defIsFinalized, pIsFinalized);
DataColumnParameter paramInitializedByUserID = new DataColumnParameter(defInitializedByUserID, pInitializedByUserID);
DataColumnParameter paramReference = new DataColumnParameter(defReference, pReference);
DataColumnParameter paramAccessCode = new DataColumnParameter(defAccessCode, pAccessCode);
DataColumnParameter paramInitialLizeURL = new DataColumnParameter(defInitialLizeURL, pInitialLizeURL);
DataColumnParameter paramPaymentURL = new DataColumnParameter(defPaymentURL, pPaymentURL);
DataColumnParameter paramVerifiyURL = new DataColumnParameter(defVerifiyURL, pVerifiyURL);
DataColumnParameter paramAmountKobo = new DataColumnParameter(defAmountKobo, pAmountKobo);
DataColumnParameter paramVerifyResponseJSON = new DataColumnParameter(defVerifyResponseJSON, pVerifyResponseJSON);
DataColumnParameter paramVerifiedByUserID = new DataColumnParameter(defVerifiedByUserID, pVerifiedByUserID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramPaymentGatewayStatusID.GetSQLQuotedValueForAdd(),
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
Object pPaymentGatewayStatusID = null,
Object pIsFinalized = null,
Object pInitializedByUserID = null,
Object pInitialLizeURL = null,
Object pAmountKobo = null,
Object pCreatedAt = null,
Object pReference = null,
Object pAccessCode = null,
Object pPaymentURL = null,
Object pVerifiyURL = null,
Object pVerifyResponseJSON = null,
Object pVerifiedByUserID = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramPaymentGatewayStatusID = new DataColumnParameter(defPaymentGatewayStatusID, pPaymentGatewayStatusID);
 DataColumnParameter paramIsFinalized = new DataColumnParameter(defIsFinalized, pIsFinalized);
 DataColumnParameter paramInitializedByUserID = new DataColumnParameter(defInitializedByUserID, pInitializedByUserID);
 DataColumnParameter paramReference = new DataColumnParameter(defReference, pReference);
 DataColumnParameter paramAccessCode = new DataColumnParameter(defAccessCode, pAccessCode);
 DataColumnParameter paramInitialLizeURL = new DataColumnParameter(defInitialLizeURL, pInitialLizeURL);
 DataColumnParameter paramPaymentURL = new DataColumnParameter(defPaymentURL, pPaymentURL);
 DataColumnParameter paramVerifiyURL = new DataColumnParameter(defVerifiyURL, pVerifiyURL);
 DataColumnParameter paramAmountKobo = new DataColumnParameter(defAmountKobo, pAmountKobo);
 DataColumnParameter paramVerifyResponseJSON = new DataColumnParameter(defVerifyResponseJSON, pVerifyResponseJSON);
 DataColumnParameter paramVerifiedByUserID = new DataColumnParameter(defVerifiedByUserID, pVerifiedByUserID);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [PaymentGatewayStatusID]={2},[IsFinalized]={3},[InitializedByUserID]={4},[Reference]={5},[AccessCode]={6},[InitialLizeURL]={7},[PaymentURL]={8},[VerifiyURL]={9},[AmountKobo]={10},[VerifyResponseJSON]={11},[VerifiedByUserID]={12},[CreatedAt]={13},[UpdatedAt]={14} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramPaymentGatewayStatusID.GetSQLQuotedValueForUpdate(),
paramIsFinalized.GetSQLQuotedValueForUpdate(),
paramInitializedByUserID.GetSQLQuotedValueForUpdate(),
paramReference.GetSQLQuotedValueForUpdate(),
paramAccessCode.GetSQLQuotedValueForUpdate(),
paramInitialLizeURL.GetSQLQuotedValueForUpdate(),
paramPaymentURL.GetSQLQuotedValueForUpdate(),
paramVerifiyURL.GetSQLQuotedValueForUpdate(),
paramAmountKobo.GetSQLQuotedValueForUpdate(),
paramVerifyResponseJSON.GetSQLQuotedValueForUpdate(),
paramVerifiedByUserID.GetSQLQuotedValueForUpdate(),
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
