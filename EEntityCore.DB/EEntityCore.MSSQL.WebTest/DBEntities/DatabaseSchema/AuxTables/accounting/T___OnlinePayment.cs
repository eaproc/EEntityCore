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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___OnlinePayment : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___OnlinePayment()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPaymentID = new DataColumnDefinition(TableColumnNames.PaymentID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defTransactionDate = new DataColumnDefinition(TableColumnNames.TransactionDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChannel = new DataColumnDefinition(TableColumnNames.Channel.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIpAddress = new DataColumnDefinition(TableColumnNames.IpAddress.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayCharges = new DataColumnDefinition(TableColumnNames.GatewayCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayLogReference = new DataColumnDefinition(TableColumnNames.GatewayLogReference.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGateway = new DataColumnDefinition(TableColumnNames.Gateway.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPlatformCharges = new DataColumnDefinition(TableColumnNames.PlatformCharges.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayAmountReceived = new DataColumnDefinition(TableColumnNames.GatewayAmountReceived.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPlatformAmountReceived = new DataColumnDefinition(TableColumnNames.PlatformAmountReceived.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayChargesExplaination = new DataColumnDefinition(TableColumnNames.GatewayChargesExplaination.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPlatformChargesExplaination = new DataColumnDefinition(TableColumnNames.PlatformChargesExplaination.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPaymentID.ColumnName, defPaymentID); 
          ColumnDefns.Add(defTransactionDate.ColumnName, defTransactionDate); 
          ColumnDefns.Add(defChannel.ColumnName, defChannel); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
          ColumnDefns.Add(defGatewayCharges.ColumnName, defGatewayCharges); 
          ColumnDefns.Add(defGatewayLogReference.ColumnName, defGatewayLogReference); 
          ColumnDefns.Add(defGateway.ColumnName, defGateway); 
          ColumnDefns.Add(defPlatformCharges.ColumnName, defPlatformCharges); 
          ColumnDefns.Add(defGatewayAmountReceived.ColumnName, defGatewayAmountReceived); 
          ColumnDefns.Add(defPlatformAmountReceived.ColumnName, defPlatformAmountReceived); 
          ColumnDefns.Add(defGatewayChargesExplaination.ColumnName, defGatewayChargesExplaination); 
          ColumnDefns.Add(defPlatformChargesExplaination.ColumnName, defPlatformChargesExplaination); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_OnlinePayment_PaymentID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.OnlinePayment", "accounting.Payment"                  
                            ));                  

          }


                  
       public T___OnlinePayment() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___OnlinePayment(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePayment(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___OnlinePayment(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.OnlinePayment";
       public const string OnlinePayment__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PaymentID], [TransactionDate], [Channel], [IpAddress], [GatewayCharges], [GatewayLogReference], [Gateway], [PlatformCharges], [GatewayAmountReceived], [PlatformAmountReceived], [GatewayChargesExplaination], [PlatformChargesExplaination], [CreatedAt] FROM accounting.OnlinePayment";
       public const string OnlinePayment__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PaymentID], [TransactionDate], [Channel], [IpAddress], [GatewayCharges], [GatewayLogReference], [Gateway], [PlatformCharges], [GatewayAmountReceived], [PlatformAmountReceived], [GatewayChargesExplaination], [PlatformChargesExplaination], [CreatedAt] FROM accounting.OnlinePayment";


       public enum TableColumnNames
       {

           ID,
           PaymentID,
           TransactionDate,
           Channel,
           IpAddress,
           GatewayCharges,
           GatewayLogReference,
           Gateway,
           PlatformCharges,
           GatewayAmountReceived,
           PlatformAmountReceived,
           GatewayChargesExplaination,
           PlatformChargesExplaination,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_accounting_OnlinePayment, 
           fk_accounting_OnlinePayment_PaymentID, 
           uq_accounting_OnlinePayment_PaymentID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPaymentID;
       public static readonly DataColumnDefinition defTransactionDate;
       public static readonly DataColumnDefinition defChannel;
       public static readonly DataColumnDefinition defIpAddress;
       public static readonly DataColumnDefinition defGatewayCharges;
       public static readonly DataColumnDefinition defGatewayLogReference;
       public static readonly DataColumnDefinition defGateway;
       public static readonly DataColumnDefinition defPlatformCharges;
       public static readonly DataColumnDefinition defGatewayAmountReceived;
       public static readonly DataColumnDefinition defPlatformAmountReceived;
       public static readonly DataColumnDefinition defGatewayChargesExplaination;
       public static readonly DataColumnDefinition defPlatformChargesExplaination;
       public static readonly DataColumnDefinition defCreatedAt;

       public int PaymentID { get => (int)TargettedRow[TableColumnNames.PaymentID.ToString()]; }


       public DateTime TransactionDate { get => (DateTime)TargettedRow[TableColumnNames.TransactionDate.ToString()]; }


       public string Channel { get => (string)TargettedRow[TableColumnNames.Channel.ToString()]; }


       public string IpAddress { get => (string)TargettedRow[TableColumnNames.IpAddress.ToString()]; }


       public decimal GatewayCharges { get => (decimal)TargettedRow[TableColumnNames.GatewayCharges.ToString()]; }


       public string GatewayLogReference { get => (string)TargettedRow[TableColumnNames.GatewayLogReference.ToString()]; }


       public string Gateway { get => (string)TargettedRow[TableColumnNames.Gateway.ToString()]; }


       public decimal PlatformCharges { get => (decimal)TargettedRow[TableColumnNames.PlatformCharges.ToString()]; }


       public decimal GatewayAmountReceived { get => (decimal)TargettedRow[TableColumnNames.GatewayAmountReceived.ToString()]; }


       public decimal PlatformAmountReceived { get => (decimal)TargettedRow[TableColumnNames.PlatformAmountReceived.ToString()]; }


       public string GatewayChargesExplaination { get => (string)TargettedRow[TableColumnNames.GatewayChargesExplaination.ToString()]; }


       public string PlatformChargesExplaination { get => (string)TargettedRow[TableColumnNames.PlatformChargesExplaination.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___OnlinePayment GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___OnlinePayment GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___OnlinePayment(conn.Fetch(OnlinePayment__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable(), DO__NOT____TARGET__ANY_ROWID),                  
                transaction                  
                );                                                      
                                                      
        public static T___OnlinePayment GetRowWhereIDUsingSQL(int pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___OnlinePayment( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___OnlinePayment GetRowWhereID(int pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => OnlinePayment__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int PaymentID,
            DateTime TransactionDate,
            string Channel,
            string IpAddress,
            decimal GatewayCharges,
            string GatewayLogReference,
            string Gateway,
            decimal PlatformCharges,
            decimal GatewayAmountReceived,
            decimal PlatformAmountReceived,
            DateTime CreatedAt,
            string GatewayChargesExplaination = null,
            string PlatformChargesExplaination = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramPaymentID = new (defPaymentID, PaymentID);
                DataColumnParameter paramTransactionDate = new (defTransactionDate, TransactionDate);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramGatewayCharges = new (defGatewayCharges, GatewayCharges);
                DataColumnParameter paramGatewayLogReference = new (defGatewayLogReference, GatewayLogReference);
                DataColumnParameter paramGateway = new (defGateway, Gateway);
                DataColumnParameter paramPlatformCharges = new (defPlatformCharges, PlatformCharges);
                DataColumnParameter paramGatewayAmountReceived = new (defGatewayAmountReceived, GatewayAmountReceived);
                DataColumnParameter paramPlatformAmountReceived = new (defPlatformAmountReceived, PlatformAmountReceived);
                DataColumnParameter paramGatewayChargesExplaination = new (defGatewayChargesExplaination, GatewayChargesExplaination);
                DataColumnParameter paramPlatformChargesExplaination = new (defPlatformChargesExplaination, PlatformChargesExplaination);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})  ", TABLE_NAME,
                        paramPaymentID.GetSQLQuotedValueForAdd(),
                        paramTransactionDate.GetSQLQuotedValueForAdd(),
                        paramChannel.GetSQLQuotedValueForAdd(),
                        paramIpAddress.GetSQLQuotedValueForAdd(),
                        paramGatewayCharges.GetSQLQuotedValueForAdd(),
                        paramGatewayLogReference.GetSQLQuotedValueForAdd(),
                        paramGateway.GetSQLQuotedValueForAdd(),
                        paramPlatformCharges.GetSQLQuotedValueForAdd(),
                        paramGatewayAmountReceived.GetSQLQuotedValueForAdd(),
                        paramPlatformAmountReceived.GetSQLQuotedValueForAdd(),
                        paramGatewayChargesExplaination.GetSQLQuotedValueForAdd(),
                        paramPlatformChargesExplaination.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd()                        )
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
            int PaymentID,
            DateTime TransactionDate,
            string Channel,
            string IpAddress,
            decimal GatewayCharges,
            string GatewayLogReference,
            string Gateway,
            decimal PlatformCharges,
            decimal GatewayAmountReceived,
            decimal PlatformAmountReceived,
            DateTime CreatedAt,
            string GatewayChargesExplaination = null,
            string PlatformChargesExplaination = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPaymentID = new (defPaymentID, PaymentID);
                DataColumnParameter paramTransactionDate = new (defTransactionDate, TransactionDate);
                DataColumnParameter paramChannel = new (defChannel, Channel);
                DataColumnParameter paramIpAddress = new (defIpAddress, IpAddress);
                DataColumnParameter paramGatewayCharges = new (defGatewayCharges, GatewayCharges);
                DataColumnParameter paramGatewayLogReference = new (defGatewayLogReference, GatewayLogReference);
                DataColumnParameter paramGateway = new (defGateway, Gateway);
                DataColumnParameter paramPlatformCharges = new (defPlatformCharges, PlatformCharges);
                DataColumnParameter paramGatewayAmountReceived = new (defGatewayAmountReceived, GatewayAmountReceived);
                DataColumnParameter paramPlatformAmountReceived = new (defPlatformAmountReceived, PlatformAmountReceived);
                DataColumnParameter paramGatewayChargesExplaination = new (defGatewayChargesExplaination, GatewayChargesExplaination);
                DataColumnParameter paramPlatformChargesExplaination = new (defPlatformChargesExplaination, PlatformChargesExplaination);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramPaymentID.GetSQLQuotedValueForAdd(),
                        paramTransactionDate.GetSQLQuotedValueForAdd(),
                        paramChannel.GetSQLQuotedValueForAdd(),
                        paramIpAddress.GetSQLQuotedValueForAdd(),
                        paramGatewayCharges.GetSQLQuotedValueForAdd(),
                        paramGatewayLogReference.GetSQLQuotedValueForAdd(),
                        paramGateway.GetSQLQuotedValueForAdd(),
                        paramPlatformCharges.GetSQLQuotedValueForAdd(),
                        paramGatewayAmountReceived.GetSQLQuotedValueForAdd(),
                        paramPlatformAmountReceived.GetSQLQuotedValueForAdd(),
                        paramGatewayChargesExplaination.GetSQLQuotedValueForAdd(),
                        paramPlatformChargesExplaination.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        /// <summary>                  
        /// Deletes with an option to pass in transaction                  
        /// </summary>                  
        /// <returns></returns>                  
        /// <remarks></remarks>                  
        public bool DeleteRow(DBTransaction transaction = null)                  
        {                  
            return DeleteItemRow(ID, transaction);                  
        }                  
                  
        public static bool DeleteItemRow(long pID, DBTransaction transaction = null)                                                      
        {                  
            return TransactionRunner.InvokeRun(                  
               (conn) => conn.ExecuteTransactionQuery($"DELETE FROM {TABLE_NAME} WHERE ID={pID} ").ToBoolean(),                  
               transaction                  
               );                  
        }                  



   }


}
