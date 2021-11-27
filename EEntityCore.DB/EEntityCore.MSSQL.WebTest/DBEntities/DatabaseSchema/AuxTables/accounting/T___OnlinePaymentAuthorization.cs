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

    public class T___OnlinePaymentAuthorization : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___OnlinePaymentAuthorization()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defOnlinePaymentID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.OnlinePaymentID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defAuthorizationCode = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AuthorizationCode.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCardType = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CardType.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBIN = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BIN.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLast4Digits = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Last4Digits.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpirationMonth = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExpirationMonth.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpirationYear = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExpirationYear.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBank = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Bank.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountryCode = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CountryCode.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defOnlinePaymentID.ColumnName, defOnlinePaymentID); 
          ColumnDefns.Add(defAuthorizationCode.ColumnName, defAuthorizationCode); 
          ColumnDefns.Add(defCardType.ColumnName, defCardType); 
          ColumnDefns.Add(defBIN.ColumnName, defBIN); 
          ColumnDefns.Add(defLast4Digits.ColumnName, defLast4Digits); 
          ColumnDefns.Add(defExpirationMonth.ColumnName, defExpirationMonth); 
          ColumnDefns.Add(defExpirationYear.ColumnName, defExpirationYear); 
          ColumnDefns.Add(defBank.ColumnName, defBank); 
          ColumnDefns.Add(defCountryCode.ColumnName, defCountryCode); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_OnlinePaymentAuthorization_OnlinePaymentID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.OnlinePaymentAuthorization", "accounting.OnlinePayment"                  
                            ));                  

          }


                  
       public T___OnlinePaymentAuthorization() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___OnlinePaymentAuthorization(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___OnlinePaymentAuthorization(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___OnlinePaymentAuthorization(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.OnlinePaymentAuthorization";
       public const string OnlinePaymentAuthorization__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [OnlinePaymentID], [AuthorizationCode], [CardType], [BIN], [Last4Digits], [ExpirationMonth], [ExpirationYear], [Bank], [CountryCode], [CreatedAt] FROM OnlinePaymentAuthorization";
       public const string OnlinePaymentAuthorization__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [OnlinePaymentID], [AuthorizationCode], [CardType], [BIN], [Last4Digits], [ExpirationMonth], [ExpirationYear], [Bank], [CountryCode], [CreatedAt] FROM OnlinePaymentAuthorization";


       public enum TableColumnNames
       {

           ID,
           OnlinePaymentID,
           AuthorizationCode,
           CardType,
           BIN,
           Last4Digits,
           ExpirationMonth,
           ExpirationYear,
           Bank,
           CountryCode,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_accounting_OnlinePaymentAuthorization, 
           fk_accounting_OnlinePaymentAuthorization_OnlinePaymentID, 
           uq_accounting_OnlinePaymentAuthorization_OnlinePaymentID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defOnlinePaymentID;
       public static readonly DataColumnDefinition defAuthorizationCode;
       public static readonly DataColumnDefinition defCardType;
       public static readonly DataColumnDefinition defBIN;
       public static readonly DataColumnDefinition defLast4Digits;
       public static readonly DataColumnDefinition defExpirationMonth;
       public static readonly DataColumnDefinition defExpirationYear;
       public static readonly DataColumnDefinition defBank;
       public static readonly DataColumnDefinition defCountryCode;
       public static readonly DataColumnDefinition defCreatedAt;

       public int OnlinePaymentID { get => (int)TargettedRow[TableColumnNames.OnlinePaymentID.ToString()]; }


       public string AuthorizationCode { get => (string)TargettedRow[TableColumnNames.AuthorizationCode.ToString()]; }


       public string CardType { get => (string)TargettedRow[TableColumnNames.CardType.ToString()]; }


       public string BIN { get => (string)TargettedRow[TableColumnNames.BIN.ToString()]; }


       public string Last4Digits { get => (string)TargettedRow[TableColumnNames.Last4Digits.ToString()]; }


       public int? ExpirationMonth { get => (int?)TargettedRow[TableColumnNames.ExpirationMonth.ToString()]; }


       public int? ExpirationYear { get => (int?)TargettedRow[TableColumnNames.ExpirationYear.ToString()]; }


       public string Bank { get => (string)TargettedRow[TableColumnNames.Bank.ToString()]; }


       public string CountryCode { get => (string)TargettedRow[TableColumnNames.CountryCode.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___OnlinePaymentAuthorization GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___OnlinePaymentAuthorization GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___OnlinePaymentAuthorization GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___OnlinePaymentAuthorization(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___OnlinePaymentAuthorization GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => OnlinePaymentAuthorization__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pOnlinePaymentID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramOnlinePaymentID = new DataColumnParameter(defOnlinePaymentID, pOnlinePaymentID);
                DataColumnParameter paramAuthorizationCode = new DataColumnParameter(defAuthorizationCode, defAuthorizationCode.DefaultValue);
                DataColumnParameter paramCardType = new DataColumnParameter(defCardType, defCardType.DefaultValue);
                DataColumnParameter paramBIN = new DataColumnParameter(defBIN, defBIN.DefaultValue);
                DataColumnParameter paramLast4Digits = new DataColumnParameter(defLast4Digits, defLast4Digits.DefaultValue);
                DataColumnParameter paramExpirationMonth = new DataColumnParameter(defExpirationMonth, defExpirationMonth.DefaultValue);
                DataColumnParameter paramExpirationYear = new DataColumnParameter(defExpirationYear, defExpirationYear.DefaultValue);
                DataColumnParameter paramBank = new DataColumnParameter(defBank, defBank.DefaultValue);
                DataColumnParameter paramCountryCode = new DataColumnParameter(defCountryCode, defCountryCode.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramOnlinePaymentID.GetSQLQuotedValueForAdd(),
                paramAuthorizationCode.GetSQLQuotedValueForAdd(),
                paramCardType.GetSQLQuotedValueForAdd(),
                paramBIN.GetSQLQuotedValueForAdd(),
                paramLast4Digits.GetSQLQuotedValueForAdd(),
                paramExpirationMonth.GetSQLQuotedValueForAdd(),
                paramExpirationYear.GetSQLQuotedValueForAdd(),
                paramBank.GetSQLQuotedValueForAdd(),
                paramCountryCode.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pOnlinePaymentID,
DateTime pCreatedAt,
Object pAuthorizationCode = null,
Object pCardType = null,
Object pBIN = null,
Object pLast4Digits = null,
Object pExpirationMonth = null,
Object pExpirationYear = null,
Object pBank = null,
Object pCountryCode = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramOnlinePaymentID = new DataColumnParameter(defOnlinePaymentID, pOnlinePaymentID);
                DataColumnParameter paramAuthorizationCode = new DataColumnParameter(defAuthorizationCode, pAuthorizationCode);
                DataColumnParameter paramCardType = new DataColumnParameter(defCardType, pCardType);
                DataColumnParameter paramBIN = new DataColumnParameter(defBIN, pBIN);
                DataColumnParameter paramLast4Digits = new DataColumnParameter(defLast4Digits, pLast4Digits);
                DataColumnParameter paramExpirationMonth = new DataColumnParameter(defExpirationMonth, pExpirationMonth);
                DataColumnParameter paramExpirationYear = new DataColumnParameter(defExpirationYear, pExpirationYear);
                DataColumnParameter paramBank = new DataColumnParameter(defBank, pBank);
                DataColumnParameter paramCountryCode = new DataColumnParameter(defCountryCode, pCountryCode);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramOnlinePaymentID.GetSQLQuotedValueForAdd(),
paramAuthorizationCode.GetSQLQuotedValueForAdd(),
paramCardType.GetSQLQuotedValueForAdd(),
paramBIN.GetSQLQuotedValueForAdd(),
paramLast4Digits.GetSQLQuotedValueForAdd(),
paramExpirationMonth.GetSQLQuotedValueForAdd(),
paramExpirationYear.GetSQLQuotedValueForAdd(),
paramBank.GetSQLQuotedValueForAdd(),
paramCountryCode.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pOnlinePaymentID,
DateTime pCreatedAt,
Object pAuthorizationCode = null,
Object pCardType = null,
Object pBIN = null,
Object pLast4Digits = null,
Object pExpirationMonth = null,
Object pExpirationYear = null,
Object pBank = null,
Object pCountryCode = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramOnlinePaymentID = new DataColumnParameter(defOnlinePaymentID, pOnlinePaymentID);
DataColumnParameter paramAuthorizationCode = new DataColumnParameter(defAuthorizationCode, pAuthorizationCode);
DataColumnParameter paramCardType = new DataColumnParameter(defCardType, pCardType);
DataColumnParameter paramBIN = new DataColumnParameter(defBIN, pBIN);
DataColumnParameter paramLast4Digits = new DataColumnParameter(defLast4Digits, pLast4Digits);
DataColumnParameter paramExpirationMonth = new DataColumnParameter(defExpirationMonth, pExpirationMonth);
DataColumnParameter paramExpirationYear = new DataColumnParameter(defExpirationYear, pExpirationYear);
DataColumnParameter paramBank = new DataColumnParameter(defBank, pBank);
DataColumnParameter paramCountryCode = new DataColumnParameter(defCountryCode, pCountryCode);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramOnlinePaymentID.GetSQLQuotedValueForAdd(),
paramAuthorizationCode.GetSQLQuotedValueForAdd(),
paramCardType.GetSQLQuotedValueForAdd(),
paramBIN.GetSQLQuotedValueForAdd(),
paramLast4Digits.GetSQLQuotedValueForAdd(),
paramExpirationMonth.GetSQLQuotedValueForAdd(),
paramExpirationYear.GetSQLQuotedValueForAdd(),
paramBank.GetSQLQuotedValueForAdd(),
paramCountryCode.GetSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pOnlinePaymentID,
DateTime pCreatedAt,
Object pAuthorizationCode= null,
Object pCardType= null,
Object pBIN= null,
Object pLast4Digits= null,
Object pExpirationMonth= null,
Object pExpirationYear= null,
Object pBank= null,
Object pCountryCode= null){

        try{

DataColumnParameter paramOnlinePaymentID = new DataColumnParameter(defOnlinePaymentID, pOnlinePaymentID);
DataColumnParameter paramAuthorizationCode = new DataColumnParameter(defAuthorizationCode, pAuthorizationCode);
DataColumnParameter paramCardType = new DataColumnParameter(defCardType, pCardType);
DataColumnParameter paramBIN = new DataColumnParameter(defBIN, pBIN);
DataColumnParameter paramLast4Digits = new DataColumnParameter(defLast4Digits, pLast4Digits);
DataColumnParameter paramExpirationMonth = new DataColumnParameter(defExpirationMonth, pExpirationMonth);
DataColumnParameter paramExpirationYear = new DataColumnParameter(defExpirationYear, pExpirationYear);
DataColumnParameter paramBank = new DataColumnParameter(defBank, pBank);
DataColumnParameter paramCountryCode = new DataColumnParameter(defCountryCode, pCountryCode);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramOnlinePaymentID.GetSQLQuotedValueForAdd(),
paramAuthorizationCode.GetSQLQuotedValueForAdd(),
paramCardType.GetSQLQuotedValueForAdd(),
paramBIN.GetSQLQuotedValueForAdd(),
paramLast4Digits.GetSQLQuotedValueForAdd(),
paramExpirationMonth.GetSQLQuotedValueForAdd(),
paramExpirationYear.GetSQLQuotedValueForAdd(),
paramBank.GetSQLQuotedValueForAdd(),
paramCountryCode.GetSQLQuotedValueForAdd(),
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
Object pOnlinePaymentID = null,
Object pCreatedAt = null,
Object pAuthorizationCode = null,
Object pCardType = null,
Object pBIN = null,
Object pLast4Digits = null,
Object pExpirationMonth = null,
Object pExpirationYear = null,
Object pBank = null,
Object pCountryCode = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramOnlinePaymentID = new DataColumnParameter(defOnlinePaymentID, pOnlinePaymentID);
 DataColumnParameter paramAuthorizationCode = new DataColumnParameter(defAuthorizationCode, pAuthorizationCode);
 DataColumnParameter paramCardType = new DataColumnParameter(defCardType, pCardType);
 DataColumnParameter paramBIN = new DataColumnParameter(defBIN, pBIN);
 DataColumnParameter paramLast4Digits = new DataColumnParameter(defLast4Digits, pLast4Digits);
 DataColumnParameter paramExpirationMonth = new DataColumnParameter(defExpirationMonth, pExpirationMonth);
 DataColumnParameter paramExpirationYear = new DataColumnParameter(defExpirationYear, pExpirationYear);
 DataColumnParameter paramBank = new DataColumnParameter(defBank, pBank);
 DataColumnParameter paramCountryCode = new DataColumnParameter(defCountryCode, pCountryCode);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [OnlinePaymentID]={2},[AuthorizationCode]={3},[CardType]={4},[BIN]={5},[Last4Digits]={6},[ExpirationMonth]={7},[ExpirationYear]={8},[Bank]={9},[CountryCode]={10},[CreatedAt]={11} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramOnlinePaymentID.GetSQLQuotedValueForUpdate(),
paramAuthorizationCode.GetSQLQuotedValueForUpdate(),
paramCardType.GetSQLQuotedValueForUpdate(),
paramBIN.GetSQLQuotedValueForUpdate(),
paramLast4Digits.GetSQLQuotedValueForUpdate(),
paramExpirationMonth.GetSQLQuotedValueForUpdate(),
paramExpirationYear.GetSQLQuotedValueForUpdate(),
paramBank.GetSQLQuotedValueForUpdate(),
paramCountryCode.GetSQLQuotedValueForUpdate(),
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
