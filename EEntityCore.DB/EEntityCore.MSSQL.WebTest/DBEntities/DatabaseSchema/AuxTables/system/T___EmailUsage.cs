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

    public class T___EmailUsage : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___EmailUsage()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defDelivered = new DataColumnDefinition(TableColumnNames.Delivered.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSender = new DataColumnDefinition(TableColumnNames.Sender.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defReceiver = new DataColumnDefinition(TableColumnNames.Receiver.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBCC = new DataColumnDefinition(TableColumnNames.BCC.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCC = new DataColumnDefinition(TableColumnNames.CC.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSubject = new DataColumnDefinition(TableColumnNames.Subject.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMessageBodyFileName = new DataColumnDefinition(TableColumnNames.MessageBodyFileName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionMessage = new DataColumnDefinition(TableColumnNames.ExceptionMessage.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionStackTrace = new DataColumnDefinition(TableColumnNames.ExceptionStackTrace.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGateway = new DataColumnDefinition(TableColumnNames.Gateway.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDelivered.ColumnName, defDelivered); 
          ColumnDefns.Add(defSender.ColumnName, defSender); 
          ColumnDefns.Add(defReceiver.ColumnName, defReceiver); 
          ColumnDefns.Add(defBCC.ColumnName, defBCC); 
          ColumnDefns.Add(defCC.ColumnName, defCC); 
          ColumnDefns.Add(defSubject.ColumnName, defSubject); 
          ColumnDefns.Add(defMessageBodyFileName.ColumnName, defMessageBodyFileName); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defExceptionMessage.ColumnName, defExceptionMessage); 
          ColumnDefns.Add(defExceptionStackTrace.ColumnName, defExceptionStackTrace); 
          ColumnDefns.Add(defGateway.ColumnName, defGateway); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  


          }


                  
       public T___EmailUsage() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___EmailUsage(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___EmailUsage(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___EmailUsage(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___EmailUsage(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___EmailUsage(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___EmailUsage(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___EmailUsage(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___EmailUsage(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___EmailUsage(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "system.EmailUsage";
       public const string EmailUsage__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Delivered], [Sender], [Receiver], [BCC], [CC], [Subject], [MessageBodyFileName], [CreatedAt], [UpdatedAt], [ExceptionMessage], [ExceptionStackTrace], [Gateway] FROM EmailUsage";
       public const string EmailUsage__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Delivered], [Sender], [Receiver], [BCC], [CC], [Subject], [MessageBodyFileName], [CreatedAt], [UpdatedAt], [ExceptionMessage], [ExceptionStackTrace], [Gateway] FROM EmailUsage";


       public enum TableColumnNames
       {

           ID,
           Delivered,
           Sender,
           Receiver,
           BCC,
           CC,
           Subject,
           MessageBodyFileName,
           CreatedAt,
           UpdatedAt,
           ExceptionMessage,
           ExceptionStackTrace,
           Gateway
       } 



       public enum TableConstraints{

           pk_system_EmailUsage, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDelivered;
       public static readonly DataColumnDefinition defSender;
       public static readonly DataColumnDefinition defReceiver;
       public static readonly DataColumnDefinition defBCC;
       public static readonly DataColumnDefinition defCC;
       public static readonly DataColumnDefinition defSubject;
       public static readonly DataColumnDefinition defMessageBodyFileName;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defExceptionMessage;
       public static readonly DataColumnDefinition defExceptionStackTrace;
       public static readonly DataColumnDefinition defGateway;

       public Boolean Delivered {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.Delivered.ToString()]);
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


       public String BCC {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BCC.ToString()]);
           }
       }


       public String CC {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.CC.ToString()]);
           }
       }


       public String Subject {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Subject.ToString()]);
           }
       }


       public String MessageBodyFileName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.MessageBodyFileName.ToString()]);
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
        public T___EmailUsage GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___EmailUsage(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___EmailUsage GetFullTable()                  
        {                  
            return new T___EmailUsage(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___EmailUsage GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___EmailUsage(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___EmailUsage GetRowWhereID(int pID)                  
        {                  
            return new T___EmailUsage(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___EmailUsage pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___EmailUsage pRow, params DataColumnParameter[] pParams)                  
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
        public T___EmailUsage GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___EmailUsage(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___EmailUsage(drst);                  
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
        public T___EmailUsage getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___EmailUsage(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___EmailUsage(drst);                  
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

                  
        public virtual string GetFillSQL() => EmailUsage__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramDelivered = new DataColumnParameter(defDelivered, defDelivered.DefaultValue);
                DataColumnParameter paramSender = new DataColumnParameter(defSender, defSender.DefaultValue);
                DataColumnParameter paramReceiver = new DataColumnParameter(defReceiver, defReceiver.DefaultValue);
                DataColumnParameter paramBCC = new DataColumnParameter(defBCC, defBCC.DefaultValue);
                DataColumnParameter paramCC = new DataColumnParameter(defCC, defCC.DefaultValue);
                DataColumnParameter paramSubject = new DataColumnParameter(defSubject, defSubject.DefaultValue);
                DataColumnParameter paramMessageBodyFileName = new DataColumnParameter(defMessageBodyFileName, defMessageBodyFileName.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, defExceptionMessage.DefaultValue);
                DataColumnParameter paramExceptionStackTrace = new DataColumnParameter(defExceptionStackTrace, defExceptionStackTrace.DefaultValue);
                DataColumnParameter paramGateway = new DataColumnParameter(defGateway, defGateway.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Delivered],[Sender],[Receiver],[BCC],[CC],[Subject],[MessageBodyFileName],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramDelivered.getSQLQuotedValueForAdd(),
                paramSender.getSQLQuotedValueForAdd(),
                paramReceiver.getSQLQuotedValueForAdd(),
                paramBCC.getSQLQuotedValueForAdd(),
                paramCC.getSQLQuotedValueForAdd(),
                paramSubject.getSQLQuotedValueForAdd(),
                paramMessageBodyFileName.getSQLQuotedValueForAdd(),
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


        public static int AddWithID(Boolean pDelivered,
String pSender,
String pReceiver,
String pSubject,
String pMessageBodyFileName,
DateTime pCreatedAt,
String pGateway,
Object pBCC = null,
Object pCC = null,
Object pUpdatedAt = null,
Object pExceptionMessage = null,
Object pExceptionStackTrace = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramDelivered = new DataColumnParameter(defDelivered, pDelivered);
                DataColumnParameter paramSender = new DataColumnParameter(defSender, pSender);
                DataColumnParameter paramReceiver = new DataColumnParameter(defReceiver, pReceiver);
                DataColumnParameter paramBCC = new DataColumnParameter(defBCC, pBCC);
                DataColumnParameter paramCC = new DataColumnParameter(defCC, pCC);
                DataColumnParameter paramSubject = new DataColumnParameter(defSubject, pSubject);
                DataColumnParameter paramMessageBodyFileName = new DataColumnParameter(defMessageBodyFileName, pMessageBodyFileName);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
                DataColumnParameter paramExceptionStackTrace = new DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace);
                DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Delivered],[Sender],[Receiver],[BCC],[CC],[Subject],[MessageBodyFileName],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDelivered.getSQLQuotedValueForAdd(),
paramSender.getSQLQuotedValueForAdd(),
paramReceiver.getSQLQuotedValueForAdd(),
paramBCC.getSQLQuotedValueForAdd(),
paramCC.getSQLQuotedValueForAdd(),
paramSubject.getSQLQuotedValueForAdd(),
paramMessageBodyFileName.getSQLQuotedValueForAdd(),
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


        public static int  AddWithParseID(Int32 pParseID ,Boolean pDelivered,
String pSender,
String pReceiver,
String pSubject,
String pMessageBodyFileName,
DateTime pCreatedAt,
String pGateway,
Object pBCC = null,
Object pCC = null,
Object pUpdatedAt = null,
Object pExceptionMessage = null,
Object pExceptionStackTrace = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramDelivered = new DataColumnParameter(defDelivered, pDelivered);
DataColumnParameter paramSender = new DataColumnParameter(defSender, pSender);
DataColumnParameter paramReceiver = new DataColumnParameter(defReceiver, pReceiver);
DataColumnParameter paramBCC = new DataColumnParameter(defBCC, pBCC);
DataColumnParameter paramCC = new DataColumnParameter(defCC, pCC);
DataColumnParameter paramSubject = new DataColumnParameter(defSubject, pSubject);
DataColumnParameter paramMessageBodyFileName = new DataColumnParameter(defMessageBodyFileName, pMessageBodyFileName);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
DataColumnParameter paramExceptionStackTrace = new DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace);
DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Delivered],[Sender],[Receiver],[BCC],[CC],[Subject],[MessageBodyFileName],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDelivered.getSQLQuotedValueForAdd(),
paramSender.getSQLQuotedValueForAdd(),
paramReceiver.getSQLQuotedValueForAdd(),
paramBCC.getSQLQuotedValueForAdd(),
paramCC.getSQLQuotedValueForAdd(),
paramSubject.getSQLQuotedValueForAdd(),
paramMessageBodyFileName.getSQLQuotedValueForAdd(),
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
        public static bool Add(Boolean pDelivered,
String pSender,
String pReceiver,
String pSubject,
String pMessageBodyFileName,
DateTime pCreatedAt,
String pGateway,
Object pBCC= null,
Object pCC= null,
Object pUpdatedAt= null,
Object pExceptionMessage= null,
Object pExceptionStackTrace= null){

        try{

DataColumnParameter paramDelivered = new DataColumnParameter(defDelivered, pDelivered);
DataColumnParameter paramSender = new DataColumnParameter(defSender, pSender);
DataColumnParameter paramReceiver = new DataColumnParameter(defReceiver, pReceiver);
DataColumnParameter paramBCC = new DataColumnParameter(defBCC, pBCC);
DataColumnParameter paramCC = new DataColumnParameter(defCC, pCC);
DataColumnParameter paramSubject = new DataColumnParameter(defSubject, pSubject);
DataColumnParameter paramMessageBodyFileName = new DataColumnParameter(defMessageBodyFileName, pMessageBodyFileName);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
DataColumnParameter paramExceptionStackTrace = new DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace);
DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([Delivered],[Sender],[Receiver],[BCC],[CC],[Subject],[MessageBodyFileName],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) ", TABLE_NAME,paramDelivered.getSQLQuotedValueForAdd(),
paramSender.getSQLQuotedValueForAdd(),
paramReceiver.getSQLQuotedValueForAdd(),
paramBCC.getSQLQuotedValueForAdd(),
paramCC.getSQLQuotedValueForAdd(),
paramSubject.getSQLQuotedValueForAdd(),
paramMessageBodyFileName.getSQLQuotedValueForAdd(),
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
Object pDelivered = null,
Object pSender = null,
Object pReceiver = null,
Object pSubject = null,
Object pMessageBodyFileName = null,
Object pCreatedAt = null,
Object pGateway = null,
Object pBCC = null,
Object pCC = null,
Object pUpdatedAt = null,
Object pExceptionMessage = null,
Object pExceptionStackTrace = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramDelivered = new DataColumnParameter(defDelivered, pDelivered);
 DataColumnParameter paramSender = new DataColumnParameter(defSender, pSender);
 DataColumnParameter paramReceiver = new DataColumnParameter(defReceiver, pReceiver);
 DataColumnParameter paramBCC = new DataColumnParameter(defBCC, pBCC);
 DataColumnParameter paramCC = new DataColumnParameter(defCC, pCC);
 DataColumnParameter paramSubject = new DataColumnParameter(defSubject, pSubject);
 DataColumnParameter paramMessageBodyFileName = new DataColumnParameter(defMessageBodyFileName, pMessageBodyFileName);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramExceptionMessage = new DataColumnParameter(defExceptionMessage, pExceptionMessage);
 DataColumnParameter paramExceptionStackTrace = new DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace);
 DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [Delivered]={2},[Sender]={3},[Receiver]={4},[BCC]={5},[CC]={6},[Subject]={7},[MessageBodyFileName]={8},[CreatedAt]={9},[UpdatedAt]={10},[ExceptionMessage]={11},[ExceptionStackTrace]={12},[Gateway]={13} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramDelivered.getSQLQuotedValueForUpdate(),
paramSender.getSQLQuotedValueForUpdate(),
paramReceiver.getSQLQuotedValueForUpdate(),
paramBCC.getSQLQuotedValueForUpdate(),
paramCC.getSQLQuotedValueForUpdate(),
paramSubject.getSQLQuotedValueForUpdate(),
paramMessageBodyFileName.getSQLQuotedValueForUpdate(),
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
