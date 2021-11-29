using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using ELibrary.Standard.VB.Modules;                  
using EEntityCore.DB.MSSQL.Schemas;                  
using EEntityCore.DB.MSSQL;                  
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
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defDelivered = new DataColumnDefinition(TableColumnNames.Delivered.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSender = new DataColumnDefinition(TableColumnNames.Sender.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defReceiver = new DataColumnDefinition(TableColumnNames.Receiver.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBCC = new DataColumnDefinition(TableColumnNames.BCC.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCC = new DataColumnDefinition(TableColumnNames.CC.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSubject = new DataColumnDefinition(TableColumnNames.Subject.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMessageBodyFileName = new DataColumnDefinition(TableColumnNames.MessageBodyFileName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionMessage = new DataColumnDefinition(TableColumnNames.ExceptionMessage.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionStackTrace = new DataColumnDefinition(TableColumnNames.ExceptionStackTrace.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGateway = new DataColumnDefinition(TableColumnNames.Gateway.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public bool Delivered { get => (bool)TargettedRow[TableColumnNames.Delivered.ToString()]; }


       public string Sender { get => (string)TargettedRow[TableColumnNames.Sender.ToString()]; }


       public string Receiver { get => (string)TargettedRow[TableColumnNames.Receiver.ToString()]; }


       public string BCC { get => (string)TargettedRow[TableColumnNames.BCC.ToString()]; }


       public string CC { get => (string)TargettedRow[TableColumnNames.CC.ToString()]; }


       public string Subject { get => (string)TargettedRow[TableColumnNames.Subject.ToString()]; }


       public string MessageBodyFileName { get => (string)TargettedRow[TableColumnNames.MessageBodyFileName.ToString()]; }


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
        public T___EmailUsage GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___EmailUsage GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___EmailUsage GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___EmailUsage(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___EmailUsage GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => EmailUsage__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            bool Delivered,
            string Sender,
            string Receiver,
            string Subject,
            string MessageBodyFileName,
            DateTime CreatedAt,
            string Gateway,
            string BCC = null,
            string CC = null,
            DateTime? UpdatedAt = null,
            string ExceptionMessage = null,
            string ExceptionStackTrace = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramDelivered = new (defDelivered, Delivered);
                DataColumnParameter paramSender = new (defSender, Sender);
                DataColumnParameter paramReceiver = new (defReceiver, Receiver);
                DataColumnParameter paramBCC = new (defBCC, BCC);
                DataColumnParameter paramCC = new (defCC, CC);
                DataColumnParameter paramSubject = new (defSubject, Subject);
                DataColumnParameter paramMessageBodyFileName = new (defMessageBodyFileName, MessageBodyFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramExceptionMessage = new (defExceptionMessage, ExceptionMessage);
                DataColumnParameter paramExceptionStackTrace = new (defExceptionStackTrace, ExceptionStackTrace);
                DataColumnParameter paramGateway = new (defGateway, Gateway);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([Delivered],[Sender],[Receiver],[BCC],[CC],[Subject],[MessageBodyFileName],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  ", TABLE_NAME,
                        paramDelivered.GetSQLQuotedValueForAdd(),
                        paramSender.GetSQLQuotedValueForAdd(),
                        paramReceiver.GetSQLQuotedValueForAdd(),
                        paramBCC.GetSQLQuotedValueForAdd(),
                        paramCC.GetSQLQuotedValueForAdd(),
                        paramSubject.GetSQLQuotedValueForAdd(),
                        paramMessageBodyFileName.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramExceptionMessage.GetSQLQuotedValueForAdd(),
                        paramExceptionStackTrace.GetSQLQuotedValueForAdd(),
                        paramGateway.GetSQLQuotedValueForAdd()                        )
                    );
                         
                return conn.GetScopeIdentity().ToLong();
            });

        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool AddWithID(
            int ID,
            bool Delivered,
            string Sender,
            string Receiver,
            string Subject,
            string MessageBodyFileName,
            DateTime CreatedAt,
            string Gateway,
            string BCC = null,
            string CC = null,
            DateTime? UpdatedAt = null,
            string ExceptionMessage = null,
            string ExceptionStackTrace = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramDelivered = new (defDelivered, Delivered);
                DataColumnParameter paramSender = new (defSender, Sender);
                DataColumnParameter paramReceiver = new (defReceiver, Receiver);
                DataColumnParameter paramBCC = new (defBCC, BCC);
                DataColumnParameter paramCC = new (defCC, CC);
                DataColumnParameter paramSubject = new (defSubject, Subject);
                DataColumnParameter paramMessageBodyFileName = new (defMessageBodyFileName, MessageBodyFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramExceptionMessage = new (defExceptionMessage, ExceptionMessage);
                DataColumnParameter paramExceptionStackTrace = new (defExceptionStackTrace, ExceptionStackTrace);
                DataColumnParameter paramGateway = new (defGateway, Gateway);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Delivered],[Sender],[Receiver],[BCC],[CC],[Subject],[MessageBodyFileName],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramDelivered.GetSQLQuotedValueForAdd(),
                        paramSender.GetSQLQuotedValueForAdd(),
                        paramReceiver.GetSQLQuotedValueForAdd(),
                        paramBCC.GetSQLQuotedValueForAdd(),
                        paramCC.GetSQLQuotedValueForAdd(),
                        paramSubject.GetSQLQuotedValueForAdd(),
                        paramMessageBodyFileName.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramExceptionMessage.GetSQLQuotedValueForAdd(),
                        paramExceptionStackTrace.GetSQLQuotedValueForAdd(),
                        paramGateway.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
