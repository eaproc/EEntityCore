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

    public class T___SMSUsage : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___SMSUsage()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defSMSDeliveryStatusID = new DataColumnDefinition(TableColumnNames.SMSDeliveryStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSender = new DataColumnDefinition(TableColumnNames.Sender.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defReceiver = new DataColumnDefinition(TableColumnNames.Receiver.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMessage = new DataColumnDefinition(TableColumnNames.Message.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUID = new DataColumnDefinition(TableColumnNames.UID.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAPICreateResponse = new DataColumnDefinition(TableColumnNames.APICreateResponse.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAPIUpdateResponse = new DataColumnDefinition(TableColumnNames.APIUpdateResponse.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSMSCostNaira = new DataColumnDefinition(TableColumnNames.SMSCostNaira.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionMessage = new DataColumnDefinition(TableColumnNames.ExceptionMessage.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionStackTrace = new DataColumnDefinition(TableColumnNames.ExceptionStackTrace.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGateway = new DataColumnDefinition(TableColumnNames.Gateway.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public Int32 SMSDeliveryStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.SMSDeliveryStatusID.ToString()]);
           }
       }


       public String Sender {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Sender.ToString()]);
           }
       }


       public String Receiver {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Receiver.ToString()]);
           }
       }


       public String Message {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Message.ToString()]);
           }
       }


       public String UID {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.UID.ToString()]);
           }
       }


       public String APICreateResponse {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.APICreateResponse.ToString()]);
           }
       }


       public String APIUpdateResponse {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.APIUpdateResponse.ToString()]);
           }
       }


       public Decimal SMSCostNaira {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.SMSCostNaira.ToString()]);
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


       public String ExceptionMessage {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ExceptionMessage.ToString()]);
           }
       }


       public String ExceptionStackTrace {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ExceptionStackTrace.ToString()]);
           }
       }


       public String Gateway {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Gateway.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___SMSUsage GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___SMSUsage(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___SMSUsage GetFullTable()                  
        {                  
            return new T___SMSUsage(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___SMSUsage GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___SMSUsage(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___SMSUsage GetRowWhereID(int pID)                  
        {                  
            return new T___SMSUsage(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___SMSUsage pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___SMSUsage pRow, params DataColumnParameter[] pParams)                  
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
        public T___SMSUsage GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___SMSUsage(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___SMSUsage(drst);                  
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
        public T___SMSUsage getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___SMSUsage(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___SMSUsage(drst);                  
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

                  
        public virtual string GetFillSQL() => SMSUsage__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pSMSDeliveryStatusID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramSMSDeliveryStatusID = new DataColumnParameter(defSMSDeliveryStatusID, pSMSDeliveryStatusID);
                DataColumnParameter paramSender = new DataColumnParameter(defSender, defSender.DefaultValue);
                DataColumnParameter paramReceiver = new DataColumnParameter(defReceiver, defReceiver.DefaultValue);
                DataColumnParameter paramMessage = new DataColumnParameter(defMessage, defMessage.DefaultValue);
                DataColumnParameter paramUID = new DataColumnParameter(defUID, defUID.DefaultValue);
                DataColumnParameter paramAPICreateResponse = new DataColumnParameter(defAPICreateResponse, defAPICreateResponse.DefaultValue);
                DataColumnParameter paramAPIUpdateResponse = new DataColumnParameter(defAPIUpdateResponse, defAPIUpdateResponse.DefaultValue);
                DataColumnParameter paramSMSCostNaira = new DataColumnParameter(defSMSCostNaira, defSMSCostNaira.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, defExceptionMessage.DefaultValue);
                DataColumnParameter paramExceptionStackTrace = new DataColumnParameter(defExceptionStackTrace, defExceptionStackTrace.DefaultValue);
                DataColumnParameter paramGateway = new DataColumnParameter(defGateway, defGateway.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramSMSDeliveryStatusID.getSQLQuotedValueForAdd(),
                paramSender.getSQLQuotedValueForAdd(),
                paramReceiver.getSQLQuotedValueForAdd(),
                paramMessage.getSQLQuotedValueForAdd(),
                paramUID.getSQLQuotedValueForAdd(),
                paramAPICreateResponse.getSQLQuotedValueForAdd(),
                paramAPIUpdateResponse.getSQLQuotedValueForAdd(),
                paramSMSCostNaira.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd(),
                paramExceptionMessage.getSQLQuotedValueForAdd(),
                paramExceptionStackTrace.getSQLQuotedValueForAdd(),
                paramGateway.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pSMSDeliveryStatusID,
String pSender,
String pReceiver,
String pMessage,
DateTime pCreatedAt,
String pGateway,
Object pUID = null,
Object pAPICreateResponse = null,
Object pAPIUpdateResponse = null,
Object pSMSCostNaira = null,
Object pUpdatedAt = null,
Object pExceptionMessage = null,
Object pExceptionStackTrace = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramSMSDeliveryStatusID = new DataColumnParameter(defSMSDeliveryStatusID, pSMSDeliveryStatusID);
                DataColumnParameter paramSender = new DataColumnParameter(defSender, pSender);
                DataColumnParameter paramReceiver = new DataColumnParameter(defReceiver, pReceiver);
                DataColumnParameter paramMessage = new DataColumnParameter(defMessage, pMessage);
                DataColumnParameter paramUID = new DataColumnParameter(defUID, pUID);
                DataColumnParameter paramAPICreateResponse = new DataColumnParameter(defAPICreateResponse, pAPICreateResponse);
                DataColumnParameter paramAPIUpdateResponse = new DataColumnParameter(defAPIUpdateResponse, pAPIUpdateResponse);
                DataColumnParameter paramSMSCostNaira = new DataColumnParameter(defSMSCostNaira, pSMSCostNaira);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
                DataColumnParameter paramExceptionStackTrace = new DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace);
                DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramSMSDeliveryStatusID.getSQLQuotedValueForAdd(),
paramSender.getSQLQuotedValueForAdd(),
paramReceiver.getSQLQuotedValueForAdd(),
paramMessage.getSQLQuotedValueForAdd(),
paramUID.getSQLQuotedValueForAdd(),
paramAPICreateResponse.getSQLQuotedValueForAdd(),
paramAPIUpdateResponse.getSQLQuotedValueForAdd(),
paramSMSCostNaira.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramExceptionStackTrace.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pSMSDeliveryStatusID,
String pSender,
String pReceiver,
String pMessage,
DateTime pCreatedAt,
String pGateway,
Object pUID = null,
Object pAPICreateResponse = null,
Object pAPIUpdateResponse = null,
Object pSMSCostNaira = null,
Object pUpdatedAt = null,
Object pExceptionMessage = null,
Object pExceptionStackTrace = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramSMSDeliveryStatusID = new DataColumnParameter(defSMSDeliveryStatusID, pSMSDeliveryStatusID);
DataColumnParameter paramSender = new DataColumnParameter(defSender, pSender);
DataColumnParameter paramReceiver = new DataColumnParameter(defReceiver, pReceiver);
DataColumnParameter paramMessage = new DataColumnParameter(defMessage, pMessage);
DataColumnParameter paramUID = new DataColumnParameter(defUID, pUID);
DataColumnParameter paramAPICreateResponse = new DataColumnParameter(defAPICreateResponse, pAPICreateResponse);
DataColumnParameter paramAPIUpdateResponse = new DataColumnParameter(defAPIUpdateResponse, pAPIUpdateResponse);
DataColumnParameter paramSMSCostNaira = new DataColumnParameter(defSMSCostNaira, pSMSCostNaira);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
DataColumnParameter paramExceptionStackTrace = new DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace);
DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramSMSDeliveryStatusID.getSQLQuotedValueForAdd(),
paramSender.getSQLQuotedValueForAdd(),
paramReceiver.getSQLQuotedValueForAdd(),
paramMessage.getSQLQuotedValueForAdd(),
paramUID.getSQLQuotedValueForAdd(),
paramAPICreateResponse.getSQLQuotedValueForAdd(),
paramAPIUpdateResponse.getSQLQuotedValueForAdd(),
paramSMSCostNaira.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramExceptionStackTrace.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pSMSDeliveryStatusID,
String pSender,
String pReceiver,
String pMessage,
DateTime pCreatedAt,
String pGateway,
Object pUID= null,
Object pAPICreateResponse= null,
Object pAPIUpdateResponse= null,
Object pSMSCostNaira= null,
Object pUpdatedAt= null,
Object pExceptionMessage= null,
Object pExceptionStackTrace= null){

        try{

DataColumnParameter paramSMSDeliveryStatusID = new DataColumnParameter(defSMSDeliveryStatusID, pSMSDeliveryStatusID);
DataColumnParameter paramSender = new DataColumnParameter(defSender, pSender);
DataColumnParameter paramReceiver = new DataColumnParameter(defReceiver, pReceiver);
DataColumnParameter paramMessage = new DataColumnParameter(defMessage, pMessage);
DataColumnParameter paramUID = new DataColumnParameter(defUID, pUID);
DataColumnParameter paramAPICreateResponse = new DataColumnParameter(defAPICreateResponse, pAPICreateResponse);
DataColumnParameter paramAPIUpdateResponse = new DataColumnParameter(defAPIUpdateResponse, pAPIUpdateResponse);
DataColumnParameter paramSMSCostNaira = new DataColumnParameter(defSMSCostNaira, pSMSCostNaira);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
DataColumnParameter paramExceptionStackTrace = new DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace);
DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramSMSDeliveryStatusID.getSQLQuotedValueForAdd(),
paramSender.getSQLQuotedValueForAdd(),
paramReceiver.getSQLQuotedValueForAdd(),
paramMessage.getSQLQuotedValueForAdd(),
paramUID.getSQLQuotedValueForAdd(),
paramAPICreateResponse.getSQLQuotedValueForAdd(),
paramAPIUpdateResponse.getSQLQuotedValueForAdd(),
paramSMSCostNaira.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramExceptionStackTrace.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd()  ), true);


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
Object pSMSDeliveryStatusID = null,
Object pSender = null,
Object pReceiver = null,
Object pMessage = null,
Object pCreatedAt = null,
Object pGateway = null,
Object pUID = null,
Object pAPICreateResponse = null,
Object pAPIUpdateResponse = null,
Object pSMSCostNaira = null,
Object pUpdatedAt = null,
Object pExceptionMessage = null,
Object pExceptionStackTrace = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramSMSDeliveryStatusID = new DataColumnParameter(defSMSDeliveryStatusID, pSMSDeliveryStatusID);
 DataColumnParameter paramSender = new DataColumnParameter(defSender, pSender);
 DataColumnParameter paramReceiver = new DataColumnParameter(defReceiver, pReceiver);
 DataColumnParameter paramMessage = new DataColumnParameter(defMessage, pMessage);
 DataColumnParameter paramUID = new DataColumnParameter(defUID, pUID);
 DataColumnParameter paramAPICreateResponse = new DataColumnParameter(defAPICreateResponse, pAPICreateResponse);
 DataColumnParameter paramAPIUpdateResponse = new DataColumnParameter(defAPIUpdateResponse, pAPIUpdateResponse);
 DataColumnParameter paramSMSCostNaira = new DataColumnParameter(defSMSCostNaira, pSMSCostNaira);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
 DataColumnParameter paramExceptionStackTrace = new DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace);
 DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [SMSDeliveryStatusID]={2},[Sender]={3},[Receiver]={4},[Message]={5},[UID]={6},[APICreateResponse]={7},[APIUpdateResponse]={8},[SMSCostNaira]={9},[CreatedAt]={10},[UpdatedAt]={11},[ExceptionMessage]={12},[ExceptionStackTrace]={13},[Gateway]={14} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramSMSDeliveryStatusID.getSQLQuotedValueForUpdate(),
paramSender.getSQLQuotedValueForUpdate(),
paramReceiver.getSQLQuotedValueForUpdate(),
paramMessage.getSQLQuotedValueForUpdate(),
paramUID.getSQLQuotedValueForUpdate(),
paramAPICreateResponse.getSQLQuotedValueForUpdate(),
paramAPIUpdateResponse.getSQLQuotedValueForUpdate(),
paramSMSCostNaira.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramExceptionMessage.getSQLQuotedValueForUpdate(),
paramExceptionStackTrace.getSQLQuotedValueForUpdate(),
paramGateway.getSQLQuotedValueForUpdate()  ), true);


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
