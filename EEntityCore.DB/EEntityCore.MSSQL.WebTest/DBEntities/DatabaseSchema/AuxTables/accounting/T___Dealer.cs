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

    public class T___Dealer : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Dealer()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPersonID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defBankID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BankID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountNumber.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDealerCode = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DealerCode.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defCompanyName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CompanyName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWebsiteUrl = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.WebsiteUrl.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOfficeAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.OfficeAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountryID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CountryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defDealerCode.ColumnName, defDealerCode); 
          ColumnDefns.Add(defCompanyName.ColumnName, defCompanyName); 
          ColumnDefns.Add(defWebsiteUrl.ColumnName, defWebsiteUrl); 
          ColumnDefns.Add(defOfficeAddress.ColumnName, defOfficeAddress); 
          ColumnDefns.Add(defCountryID.ColumnName, defCountryID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Dealer_PersonID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Dealer", "common.Person"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Dealer_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Dealer", "common.Bank"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Dealer_CountryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Dealer", "common.Country"                  
                            ));                  

          }


                  
       public T___Dealer() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Dealer(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Dealer(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Dealer(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Dealer(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Dealer(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Dealer(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Dealer(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Dealer(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Dealer(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.Dealer";
       public const string Dealer__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PersonID], [BankID], [AccountNumber], [IsActive], [DealerCode], [CompanyName], [WebsiteUrl], [OfficeAddress], [CountryID], [CreatedAt], [UpdatedAt] FROM Dealer";
       public const string Dealer__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PersonID], [BankID], [AccountNumber], [IsActive], [DealerCode], [CompanyName], [WebsiteUrl], [OfficeAddress], [CountryID], [CreatedAt], [UpdatedAt] FROM Dealer";


       public enum TableColumnNames
       {

           ID,
           PersonID,
           BankID,
           AccountNumber,
           IsActive,
           DealerCode,
           CompanyName,
           WebsiteUrl,
           OfficeAddress,
           CountryID,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_accounting_Dealer, 
           fk_accounting_Dealer_PersonID, 
           fk_accounting_Dealer_BankID, 
           fk_accounting_Dealer_CountryID, 
           uq_accounting_Dealer_DealerCode, 
           uq_accounting_Dealer_PersonID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defDealerCode;
       public static readonly DataColumnDefinition defCompanyName;
       public static readonly DataColumnDefinition defWebsiteUrl;
       public static readonly DataColumnDefinition defOfficeAddress;
       public static readonly DataColumnDefinition defCountryID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public int PersonID { get => (int)TargettedRow[TableColumnNames.PersonID.ToString()]; }


       public int? BankID { get => (int?)TargettedRow[TableColumnNames.BankID.ToString()]; }


       public string AccountNumber { get => (string)TargettedRow[TableColumnNames.AccountNumber.ToString()]; }


       public bool IsActive { get => (bool)TargettedRow[TableColumnNames.IsActive.ToString()]; }


       public string DealerCode { get => (string)TargettedRow[TableColumnNames.DealerCode.ToString()]; }


       public string CompanyName { get => (string)TargettedRow[TableColumnNames.CompanyName.ToString()]; }


       public string WebsiteUrl { get => (string)TargettedRow[TableColumnNames.WebsiteUrl.ToString()]; }


       public string OfficeAddress { get => (string)TargettedRow[TableColumnNames.OfficeAddress.ToString()]; }


       public int CountryID { get => (int)TargettedRow[TableColumnNames.CountryID.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Dealer GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Dealer GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Dealer GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Dealer(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Dealer GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Dealer__NO__BINARY___SQL_FILL_QUERY;
                  
                  
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
            int PersonID,
            bool IsActive,
            string DealerCode,
            int CountryID,
            DateTime CreatedAt,
            int? BankID = null,
            string AccountNumber = null,
            string CompanyName = null,
            string WebsiteUrl = null,
            string OfficeAddress = null,
            DateTime? UpdatedAt = null
          ){

            try{

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramDealerCode = new (defDealerCode, DealerCode);
                DataColumnParameter paramCompanyName = new (defCompanyName, CompanyName);
                DataColumnParameter paramWebsiteUrl = new (defWebsiteUrl, WebsiteUrl);
                DataColumnParameter paramOfficeAddress = new (defOfficeAddress, OfficeAddress);
                DataColumnParameter paramCountryID = new (defCountryID, CountryID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);


                return DBConnectInterface.GetDBConn().DbExec(
     string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonID],[BankID],[AccountNumber],[IsActive],[DealerCode],[CompanyName],[WebsiteUrl],[OfficeAddress],[CountryID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramPersonID.GetSQLQuotedValueForAdd(),
                        paramBankID.GetSQLQuotedValueForAdd(),
                        paramAccountNumber.GetSQLQuotedValueForAdd(),
                        paramIsActive.GetSQLQuotedValueForAdd(),
                        paramDealerCode.GetSQLQuotedValueForAdd(),
                        paramCompanyName.GetSQLQuotedValueForAdd(),
                        paramWebsiteUrl.GetSQLQuotedValueForAdd(),
                        paramOfficeAddress.GetSQLQuotedValueForAdd(),
                        paramCountryID.GetSQLQuotedValueForAdd(),
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
