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

    public class T___SMSUsage : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___SMSUsage()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defSMSDeliveryStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SMSDeliveryStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSender = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Sender.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defReceiver = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Receiver.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMessage = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Message.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UID.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAPICreateResponse = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.APICreateResponse.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAPIUpdateResponse = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.APIUpdateResponse.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSMSCostNaira = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SMSCostNaira.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionMessage = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExceptionMessage.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionStackTrace = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExceptionStackTrace.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGateway = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Gateway.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defSMSDeliveryStatusID.ColumnName, defSMSDeliveryStatusID); 
          ColumnDefns.Add(defSender.ColumnName, defSender); 
          ColumnDefns.Add(defReceiver.ColumnName, defReceiver); 
          ColumnDefns.Add(defMessage.ColumnName, defMessage); 
          ColumnDefns.Add(defUID.ColumnName, defUID); 
          ColumnDefns.Add(defAPICreateResponse.ColumnName, defAPICreateResponse); 
          ColumnDefns.Add(defAPIUpdateResponse.ColumnName, defAPIUpdateResponse); 
          ColumnDefns.Add(defSMSCostNaira.ColumnName, defSMSCostNaira); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defExceptionMessage.ColumnName, defExceptionMessage); 
          ColumnDefns.Add(defExceptionStackTrace.ColumnName, defExceptionStackTrace); 
          ColumnDefns.Add(defGateway.ColumnName, defGateway); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_SMSUsage_SMSDeliveryStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.SMSUsage", "system.SMSDeliveryStatus"                  
                            ));                  

          }


                  
       public T___SMSUsage() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___SMSUsage(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUsage(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___SMSUsage(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.SMSUsage";
       public const string SMSUsage__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [SMSDeliveryStatusID], [Sender], [Receiver], [Message], [UID], [APICreateResponse], [APIUpdateResponse], [SMSCostNaira], [CreatedAt], [UpdatedAt], [ExceptionMessage], [ExceptionStackTrace], [Gateway] FROM SMSUsage";
       public const string SMSUsage__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [SMSDeliveryStatusID], [Sender], [Receiver], [Message], [UID], [APICreateResponse], [APIUpdateResponse], [SMSCostNaira], [CreatedAt], [UpdatedAt], [ExceptionMessage], [ExceptionStackTrace], [Gateway] FROM SMSUsage";


       public enum TableColumnNames
       {

           ID,
           SMSDeliveryStatusID,
           Sender,
           Receiver,
           Message,
           UID,
           APICreateResponse,
           APIUpdateResponse,
           SMSCostNaira,
           CreatedAt,
           UpdatedAt,
           ExceptionMessage,
           ExceptionStackTrace,
           Gateway
       } 



       public enum TableConstraints{

           pk_system_SMSUsage, 
           fk_system_SMSUsage_SMSDeliveryStatusID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defSMSDeliveryStatusID;
       public static readonly DataColumnDefinition defSender;
       public static readonly DataColumnDefinition defReceiver;
       public static readonly DataColumnDefinition defMessage;
       public static readonly DataColumnDefinition defUID;
       public static readonly DataColumnDefinition defAPICreateResponse;
       public static readonly DataColumnDefinition defAPIUpdateResponse;
       public static readonly DataColumnDefinition defSMSCostNaira;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defExceptionMessage;
       public static readonly DataColumnDefinition defExceptionStackTrace;
       public static readonly DataColumnDefinition defGateway;

       public int SMSDeliveryStatusID { get => (int)TargettedRow[TableColumnNames.SMSDeliveryStatusID.ToString()]; }


       public string Sender { get => (string)TargettedRow[TableColumnNames.Sender.ToString()]; }


       public string Receiver { get => (string)TargettedRow[TableColumnNames.Receiver.ToString()]; }


       public string Message { get => (string)TargettedRow[TableColumnNames.Message.ToString()]; }


       public string UID { get => (string)TargettedRow[TableColumnNames.UID.ToString()]; }


       public string APICreateResponse { get => (string)TargettedRow[TableColumnNames.APICreateResponse.ToString()]; }


       public string APIUpdateResponse { get => (string)TargettedRow[TableColumnNames.APIUpdateResponse.ToString()]; }


       public decimal? SMSCostNaira { get => (decimal?)TargettedRow[TableColumnNames.SMSCostNaira.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


       public string ExceptionMessage { get => (string)TargettedRow[TableColumnNames.ExceptionMessage.ToString()]; }


       public string ExceptionStackTrace { get => (string)TargettedRow[TableColumnNames.ExceptionStackTrace.ToString()]; }


       public string Gateway { get => (string)TargettedRow[TableColumnNames.Gateway.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___SMSUsage GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___SMSUsage GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___SMSUsage GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___SMSUsage(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___SMSUsage GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => SMSUsage__NO__BINARY___SQL_FILL_QUERY;
                  
                  
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
            int SMSDeliveryStatusID,
            string Sender,
            string Receiver,
            string Message,
            DateTime CreatedAt,
            string Gateway,
            string UID = null,
            string APICreateResponse = null,
            string APIUpdateResponse = null,
            decimal? SMSCostNaira = null,
            DateTime? UpdatedAt = null,
            string ExceptionMessage = null,
            string ExceptionStackTrace = null
          ){

            try{

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramSMSDeliveryStatusID = new (defSMSDeliveryStatusID, SMSDeliveryStatusID);
                DataColumnParameter paramSender = new (defSender, Sender);
                DataColumnParameter paramReceiver = new (defReceiver, Receiver);
                DataColumnParameter paramMessage = new (defMessage, Message);
                DataColumnParameter paramUID = new (defUID, UID);
                DataColumnParameter paramAPICreateResponse = new (defAPICreateResponse, APICreateResponse);
                DataColumnParameter paramAPIUpdateResponse = new (defAPIUpdateResponse, APIUpdateResponse);
                DataColumnParameter paramSMSCostNaira = new (defSMSCostNaira, SMSCostNaira);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramExceptionMessage = new (defExceptionMessage, ExceptionMessage);
                DataColumnParameter paramExceptionStackTrace = new (defExceptionStackTrace, ExceptionStackTrace);
                DataColumnParameter paramGateway = new (defGateway, Gateway);


                return DBConnectInterface.GetDBConn().DbExec(
     string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramSMSDeliveryStatusID.GetSQLQuotedValueForAdd(),
                        paramSender.GetSQLQuotedValueForAdd(),
                        paramReceiver.GetSQLQuotedValueForAdd(),
                        paramMessage.GetSQLQuotedValueForAdd(),
                        paramUID.GetSQLQuotedValueForAdd(),
                        paramAPICreateResponse.GetSQLQuotedValueForAdd(),
                        paramAPIUpdateResponse.GetSQLQuotedValueForAdd(),
                        paramSMSCostNaira.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramExceptionMessage.GetSQLQuotedValueForAdd(),
                        paramExceptionStackTrace.GetSQLQuotedValueForAdd(),
                        paramGateway.GetSQLQuotedValueForAdd()                        ) 
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
