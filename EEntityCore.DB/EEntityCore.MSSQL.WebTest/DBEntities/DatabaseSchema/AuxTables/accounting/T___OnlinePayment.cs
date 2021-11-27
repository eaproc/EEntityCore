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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___OnlinePayment : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___OnlinePayment()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPaymentID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defTransactionDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TransactionDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChannel = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Channel.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIpAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IpAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayCharges = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.GatewayCharges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayLogReference = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.GatewayLogReference.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGateway = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Gateway.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPlatformCharges = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PlatformCharges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayAmountReceived = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.GatewayAmountReceived.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPlatformAmountReceived = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PlatformAmountReceived.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGatewayChargesExplaination = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.GatewayChargesExplaination.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPlatformChargesExplaination = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PlatformChargesExplaination.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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
       public const string OnlinePayment__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PaymentID], [TransactionDate], [Channel], [IpAddress], [GatewayCharges], [GatewayLogReference], [Gateway], [PlatformCharges], [GatewayAmountReceived], [PlatformAmountReceived], [GatewayChargesExplaination], [PlatformChargesExplaination], [CreatedAt] FROM OnlinePayment";
       public const string OnlinePayment__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PaymentID], [TransactionDate], [Channel], [IpAddress], [GatewayCharges], [GatewayLogReference], [Gateway], [PlatformCharges], [GatewayAmountReceived], [PlatformAmountReceived], [GatewayChargesExplaination], [PlatformChargesExplaination], [CreatedAt] FROM OnlinePayment";


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

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public Int32 PaymentID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PaymentID.ToString()]);
           }
       }


       public NullableDateTime TransactionDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.TransactionDate.ToString()]);
           }
       }


       public String Channel {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Channel.ToString()]);
           }
       }


       public String IpAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IpAddress.ToString()]);
           }
       }


       public Decimal GatewayCharges {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.GatewayCharges.ToString()]);
           }
       }


       public String GatewayLogReference {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.GatewayLogReference.ToString()]);
           }
       }


       public String Gateway {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Gateway.ToString()]);
           }
       }


       public Decimal PlatformCharges {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PlatformCharges.ToString()]);
           }
       }


       public Decimal GatewayAmountReceived {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.GatewayAmountReceived.ToString()]);
           }
       }


       public Decimal PlatformAmountReceived {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PlatformAmountReceived.ToString()]);
           }
       }


       public String GatewayChargesExplaination {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.GatewayChargesExplaination.ToString()]);
           }
       }


       public String PlatformChargesExplaination {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PlatformChargesExplaination.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


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
                                                      
        public static T___OnlinePayment GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___OnlinePayment GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___OnlinePayment(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___OnlinePayment GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => OnlinePayment__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pPaymentID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPaymentID = new DataColumnParameter(defPaymentID, pPaymentID);
                DataColumnParameter paramTransactionDate = new DataColumnParameter(defTransactionDate, defTransactionDate.DefaultValue);
                DataColumnParameter paramChannel = new DataColumnParameter(defChannel, defChannel.DefaultValue);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, defIpAddress.DefaultValue);
                DataColumnParameter paramGatewayCharges = new DataColumnParameter(defGatewayCharges, defGatewayCharges.DefaultValue);
                DataColumnParameter paramGatewayLogReference = new DataColumnParameter(defGatewayLogReference, defGatewayLogReference.DefaultValue);
                DataColumnParameter paramGateway = new DataColumnParameter(defGateway, defGateway.DefaultValue);
                DataColumnParameter paramPlatformCharges = new DataColumnParameter(defPlatformCharges, defPlatformCharges.DefaultValue);
                DataColumnParameter paramGatewayAmountReceived = new DataColumnParameter(defGatewayAmountReceived, defGatewayAmountReceived.DefaultValue);
                DataColumnParameter paramPlatformAmountReceived = new DataColumnParameter(defPlatformAmountReceived, defPlatformAmountReceived.DefaultValue);
                DataColumnParameter paramGatewayChargesExplaination = new DataColumnParameter(defGatewayChargesExplaination, defGatewayChargesExplaination.DefaultValue);
                DataColumnParameter paramPlatformChargesExplaination = new DataColumnParameter(defPlatformChargesExplaination, defPlatformChargesExplaination.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
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
                paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pPaymentID,
DateTime pTransactionDate,
String pChannel,
String pIpAddress,
Decimal pGatewayCharges,
String pGatewayLogReference,
String pGateway,
Decimal pPlatformCharges,
Decimal pGatewayAmountReceived,
Decimal pPlatformAmountReceived,
DateTime pCreatedAt,
Object pGatewayChargesExplaination = null,
Object pPlatformChargesExplaination = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPaymentID = new DataColumnParameter(defPaymentID, pPaymentID);
                DataColumnParameter paramTransactionDate = new DataColumnParameter(defTransactionDate, pTransactionDate);
                DataColumnParameter paramChannel = new DataColumnParameter(defChannel, pChannel);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
                DataColumnParameter paramGatewayCharges = new DataColumnParameter(defGatewayCharges, pGatewayCharges);
                DataColumnParameter paramGatewayLogReference = new DataColumnParameter(defGatewayLogReference, pGatewayLogReference);
                DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);
                DataColumnParameter paramPlatformCharges = new DataColumnParameter(defPlatformCharges, pPlatformCharges);
                DataColumnParameter paramGatewayAmountReceived = new DataColumnParameter(defGatewayAmountReceived, pGatewayAmountReceived);
                DataColumnParameter paramPlatformAmountReceived = new DataColumnParameter(defPlatformAmountReceived, pPlatformAmountReceived);
                DataColumnParameter paramGatewayChargesExplaination = new DataColumnParameter(defGatewayChargesExplaination, pGatewayChargesExplaination);
                DataColumnParameter paramPlatformChargesExplaination = new DataColumnParameter(defPlatformChargesExplaination, pPlatformChargesExplaination);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pPaymentID,
DateTime pTransactionDate,
String pChannel,
String pIpAddress,
Decimal pGatewayCharges,
String pGatewayLogReference,
String pGateway,
Decimal pPlatformCharges,
Decimal pGatewayAmountReceived,
Decimal pPlatformAmountReceived,
DateTime pCreatedAt,
Object pGatewayChargesExplaination = null,
Object pPlatformChargesExplaination = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramPaymentID = new DataColumnParameter(defPaymentID, pPaymentID);
DataColumnParameter paramTransactionDate = new DataColumnParameter(defTransactionDate, pTransactionDate);
DataColumnParameter paramChannel = new DataColumnParameter(defChannel, pChannel);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
DataColumnParameter paramGatewayCharges = new DataColumnParameter(defGatewayCharges, pGatewayCharges);
DataColumnParameter paramGatewayLogReference = new DataColumnParameter(defGatewayLogReference, pGatewayLogReference);
DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);
DataColumnParameter paramPlatformCharges = new DataColumnParameter(defPlatformCharges, pPlatformCharges);
DataColumnParameter paramGatewayAmountReceived = new DataColumnParameter(defGatewayAmountReceived, pGatewayAmountReceived);
DataColumnParameter paramPlatformAmountReceived = new DataColumnParameter(defPlatformAmountReceived, pPlatformAmountReceived);
DataColumnParameter paramGatewayChargesExplaination = new DataColumnParameter(defGatewayChargesExplaination, pGatewayChargesExplaination);
DataColumnParameter paramPlatformChargesExplaination = new DataColumnParameter(defPlatformChargesExplaination, pPlatformChargesExplaination);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pPaymentID,
DateTime pTransactionDate,
String pChannel,
String pIpAddress,
Decimal pGatewayCharges,
String pGatewayLogReference,
String pGateway,
Decimal pPlatformCharges,
Decimal pGatewayAmountReceived,
Decimal pPlatformAmountReceived,
DateTime pCreatedAt,
Object pGatewayChargesExplaination= null,
Object pPlatformChargesExplaination= null){

        try{

DataColumnParameter paramPaymentID = new DataColumnParameter(defPaymentID, pPaymentID);
DataColumnParameter paramTransactionDate = new DataColumnParameter(defTransactionDate, pTransactionDate);
DataColumnParameter paramChannel = new DataColumnParameter(defChannel, pChannel);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
DataColumnParameter paramGatewayCharges = new DataColumnParameter(defGatewayCharges, pGatewayCharges);
DataColumnParameter paramGatewayLogReference = new DataColumnParameter(defGatewayLogReference, pGatewayLogReference);
DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);
DataColumnParameter paramPlatformCharges = new DataColumnParameter(defPlatformCharges, pPlatformCharges);
DataColumnParameter paramGatewayAmountReceived = new DataColumnParameter(defGatewayAmountReceived, pGatewayAmountReceived);
DataColumnParameter paramPlatformAmountReceived = new DataColumnParameter(defPlatformAmountReceived, pPlatformAmountReceived);
DataColumnParameter paramGatewayChargesExplaination = new DataColumnParameter(defGatewayChargesExplaination, pGatewayChargesExplaination);
DataColumnParameter paramPlatformChargesExplaination = new DataColumnParameter(defPlatformChargesExplaination, pPlatformChargesExplaination);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramPaymentID.GetSQLQuotedValueForAdd(),
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
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);


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
Object pPaymentID = null,
Object pTransactionDate = null,
Object pChannel = null,
Object pIpAddress = null,
Object pGatewayCharges = null,
Object pGatewayLogReference = null,
Object pGateway = null,
Object pPlatformCharges = null,
Object pGatewayAmountReceived = null,
Object pPlatformAmountReceived = null,
Object pCreatedAt = null,
Object pGatewayChargesExplaination = null,
Object pPlatformChargesExplaination = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramPaymentID = new DataColumnParameter(defPaymentID, pPaymentID);
 DataColumnParameter paramTransactionDate = new DataColumnParameter(defTransactionDate, pTransactionDate);
 DataColumnParameter paramChannel = new DataColumnParameter(defChannel, pChannel);
 DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
 DataColumnParameter paramGatewayCharges = new DataColumnParameter(defGatewayCharges, pGatewayCharges);
 DataColumnParameter paramGatewayLogReference = new DataColumnParameter(defGatewayLogReference, pGatewayLogReference);
 DataColumnParameter paramGateway = new DataColumnParameter(defGateway, pGateway);
 DataColumnParameter paramPlatformCharges = new DataColumnParameter(defPlatformCharges, pPlatformCharges);
 DataColumnParameter paramGatewayAmountReceived = new DataColumnParameter(defGatewayAmountReceived, pGatewayAmountReceived);
 DataColumnParameter paramPlatformAmountReceived = new DataColumnParameter(defPlatformAmountReceived, pPlatformAmountReceived);
 DataColumnParameter paramGatewayChargesExplaination = new DataColumnParameter(defGatewayChargesExplaination, pGatewayChargesExplaination);
 DataColumnParameter paramPlatformChargesExplaination = new DataColumnParameter(defPlatformChargesExplaination, pPlatformChargesExplaination);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [PaymentID]={2},[TransactionDate]={3},[Channel]={4},[IpAddress]={5},[GatewayCharges]={6},[GatewayLogReference]={7},[Gateway]={8},[PlatformCharges]={9},[GatewayAmountReceived]={10},[PlatformAmountReceived]={11},[GatewayChargesExplaination]={12},[PlatformChargesExplaination]={13},[CreatedAt]={14} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramPaymentID.GetSQLQuotedValueForUpdate(),
paramTransactionDate.GetSQLQuotedValueForUpdate(),
paramChannel.GetSQLQuotedValueForUpdate(),
paramIpAddress.GetSQLQuotedValueForUpdate(),
paramGatewayCharges.GetSQLQuotedValueForUpdate(),
paramGatewayLogReference.GetSQLQuotedValueForUpdate(),
paramGateway.GetSQLQuotedValueForUpdate(),
paramPlatformCharges.GetSQLQuotedValueForUpdate(),
paramGatewayAmountReceived.GetSQLQuotedValueForUpdate(),
paramPlatformAmountReceived.GetSQLQuotedValueForUpdate(),
paramGatewayChargesExplaination.GetSQLQuotedValueForUpdate(),
paramPlatformChargesExplaination.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate()  ), true);


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
