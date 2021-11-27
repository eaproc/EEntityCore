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

    public class T___EmailUsage : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___EmailUsage()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defDelivered = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Delivered.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSender = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Sender.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defReceiver = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Receiver.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBCC = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BCC.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCC = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CC.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSubject = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Subject.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMessageBodyFileName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MessageBodyFileName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionMessage = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExceptionMessage.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExceptionStackTrace = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExceptionStackTrace.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGateway = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Gateway.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


       public NullableDateTime UpdatedAt { get => new (this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]); }


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
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Delivered],[Sender],[Receiver],[BCC],[CC],[Subject],[MessageBodyFileName],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
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
                paramGateway.GetSQLQuotedValueForAdd()  ), true);




                  
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
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Delivered],[Sender],[Receiver],[BCC],[CC],[Subject],[MessageBodyFileName],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramGateway.GetSQLQuotedValueForAdd()  ), true);




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
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Delivered],[Sender],[Receiver],[BCC],[CC],[Subject],[MessageBodyFileName],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramGateway.GetSQLQuotedValueForAdd()  ), true);




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
     String.Format("INSERT INTO {0}([Delivered],[Sender],[Receiver],[BCC],[CC],[Subject],[MessageBodyFileName],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) ", TABLE_NAME,paramDelivered.GetSQLQuotedValueForAdd(),
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
paramGateway.GetSQLQuotedValueForAdd()  ), true);


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
     String.Format("UPDATE {0} SET [Delivered]={2},[Sender]={3},[Receiver]={4},[BCC]={5},[CC]={6},[Subject]={7},[MessageBodyFileName]={8},[CreatedAt]={9},[UpdatedAt]={10},[ExceptionMessage]={11},[ExceptionStackTrace]={12},[Gateway]={13} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramDelivered.GetSQLQuotedValueForUpdate(),
paramSender.GetSQLQuotedValueForUpdate(),
paramReceiver.GetSQLQuotedValueForUpdate(),
paramBCC.GetSQLQuotedValueForUpdate(),
paramCC.GetSQLQuotedValueForUpdate(),
paramSubject.GetSQLQuotedValueForUpdate(),
paramMessageBodyFileName.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramExceptionMessage.GetSQLQuotedValueForUpdate(),
paramExceptionStackTrace.GetSQLQuotedValueForUpdate(),
paramGateway.GetSQLQuotedValueForUpdate()  ), true);


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
