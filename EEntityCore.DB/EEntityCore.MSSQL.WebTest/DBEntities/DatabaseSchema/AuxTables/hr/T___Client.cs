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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.hr                  
{                  

    public class T___Client : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Client()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCompanyName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CompanyName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOwnerID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.OwnerID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSLAFileName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SLAFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defScadwareURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ScadwareURL.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Email.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobile = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Mobile.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWebsiteURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.WebsiteURL.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLogoFileName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LogoFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsActive.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNameAbbreviation = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.NameAbbreviation.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Address.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BankID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountNumber.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCompanyName.ColumnName, defCompanyName); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defOwnerID.ColumnName, defOwnerID); 
          ColumnDefns.Add(defSLAFileName.ColumnName, defSLAFileName); 
          ColumnDefns.Add(defScadwareURL.ColumnName, defScadwareURL); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defMobile.ColumnName, defMobile); 
          ColumnDefns.Add(defWebsiteURL.ColumnName, defWebsiteURL); 
          ColumnDefns.Add(defLogoFileName.ColumnName, defLogoFileName); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defNameAbbreviation.ColumnName, defNameAbbreviation); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountName.ColumnName, defAccountName); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Client_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Client", "common.Bank"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Client_OwnerID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Client", "common.Person"                  
                            ));                  

          }


                  
       public T___Client() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Client(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Client(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Client(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.Client";
       public const string Client__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CompanyName], [CreatedAt], [OwnerID], [SLAFileName], [ScadwareURL], [Email], [Mobile], [WebsiteURL], [LogoFileName], [UpdatedAt], [IsActive], [NameAbbreviation], [Address], [BankID], [AccountName], [AccountNumber] FROM Client";
       public const string Client__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CompanyName], [CreatedAt], [OwnerID], [SLAFileName], [ScadwareURL], [Email], [Mobile], [WebsiteURL], [LogoFileName], [UpdatedAt], [IsActive], [NameAbbreviation], [Address], [BankID], [AccountName], [AccountNumber] FROM Client";


       public enum TableColumnNames
       {

           ID,
           CompanyName,
           CreatedAt,
           OwnerID,
           SLAFileName,
           ScadwareURL,
           Email,
           Mobile,
           WebsiteURL,
           LogoFileName,
           UpdatedAt,
           IsActive,
           NameAbbreviation,
           Address,
           BankID,
           AccountName,
           AccountNumber
       } 



       public enum TableConstraints{

           pk_hr_Client, 
           fk_hr_Client_BankID, 
           fk_hr_Client_OwnerID, 
           uq_hr_Client_CompanyName, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCompanyName;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defOwnerID;
       public static readonly DataColumnDefinition defSLAFileName;
       public static readonly DataColumnDefinition defScadwareURL;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defMobile;
       public static readonly DataColumnDefinition defWebsiteURL;
       public static readonly DataColumnDefinition defLogoFileName;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defNameAbbreviation;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountName;
       public static readonly DataColumnDefinition defAccountNumber;

       public string CompanyName { get => (string)TargettedRow[TableColumnNames.CompanyName.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


       public int OwnerID { get => (int)TargettedRow[TableColumnNames.OwnerID.ToString()]; }


       public string SLAFileName { get => (string)TargettedRow[TableColumnNames.SLAFileName.ToString()]; }


       public string ScadwareURL { get => (string)TargettedRow[TableColumnNames.ScadwareURL.ToString()]; }


       public string Email { get => (string)TargettedRow[TableColumnNames.Email.ToString()]; }


       public string Mobile { get => (string)TargettedRow[TableColumnNames.Mobile.ToString()]; }


       public string WebsiteURL { get => (string)TargettedRow[TableColumnNames.WebsiteURL.ToString()]; }


       public string LogoFileName { get => (string)TargettedRow[TableColumnNames.LogoFileName.ToString()]; }


       public NullableDateTime UpdatedAt { get => new (this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]); }


       public bool IsActive { get => (bool)TargettedRow[TableColumnNames.IsActive.ToString()]; }


       public string NameAbbreviation { get => (string)TargettedRow[TableColumnNames.NameAbbreviation.ToString()]; }


       public string Address { get => (string)TargettedRow[TableColumnNames.Address.ToString()]; }


       public int? BankID { get => (int?)TargettedRow[TableColumnNames.BankID.ToString()]; }


       public string AccountName { get => (string)TargettedRow[TableColumnNames.AccountName.ToString()]; }


       public string AccountNumber { get => (string)TargettedRow[TableColumnNames.AccountNumber.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Client GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Client GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Client GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Client(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Client GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Client__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(String pCompanyName,
Int32 pOwnerID,
Int32 pBankID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCompanyName = new DataColumnParameter(defCompanyName, pCompanyName);
                DataColumnParameter paramOwnerID = new DataColumnParameter(defOwnerID, pOwnerID);
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramSLAFileName = new DataColumnParameter(defSLAFileName, defSLAFileName.DefaultValue);
                DataColumnParameter paramScadwareURL = new DataColumnParameter(defScadwareURL, defScadwareURL.DefaultValue);
                DataColumnParameter paramEmail = new DataColumnParameter(defEmail, defEmail.DefaultValue);
                DataColumnParameter paramMobile = new DataColumnParameter(defMobile, defMobile.DefaultValue);
                DataColumnParameter paramWebsiteURL = new DataColumnParameter(defWebsiteURL, defWebsiteURL.DefaultValue);
                DataColumnParameter paramLogoFileName = new DataColumnParameter(defLogoFileName, defLogoFileName.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, defIsActive.DefaultValue);
                DataColumnParameter paramNameAbbreviation = new DataColumnParameter(defNameAbbreviation, defNameAbbreviation.DefaultValue);
                DataColumnParameter paramAddress = new DataColumnParameter(defAddress, defAddress.DefaultValue);
                DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, defAccountName.DefaultValue);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramCompanyName.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramOwnerID.GetSQLQuotedValueForAdd(),
                paramSLAFileName.GetSQLQuotedValueForAdd(),
                paramScadwareURL.GetSQLQuotedValueForAdd(),
                paramEmail.GetSQLQuotedValueForAdd(),
                paramMobile.GetSQLQuotedValueForAdd(),
                paramWebsiteURL.GetSQLQuotedValueForAdd(),
                paramLogoFileName.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd(),
                paramIsActive.GetSQLQuotedValueForAdd(),
                paramNameAbbreviation.GetSQLQuotedValueForAdd(),
                paramAddress.GetSQLQuotedValueForAdd(),
                paramBankID.GetSQLQuotedValueForAdd(),
                paramAccountName.GetSQLQuotedValueForAdd(),
                paramAccountNumber.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pCompanyName,
DateTime pCreatedAt,
Int32 pOwnerID,
Boolean pIsActive,
String pNameAbbreviation,
Object pSLAFileName = null,
Object pScadwareURL = null,
Object pEmail = null,
Object pMobile = null,
Object pWebsiteURL = null,
Object pLogoFileName = null,
Object pUpdatedAt = null,
Object pAddress = null,
Object pBankID = null,
Object pAccountName = null,
Object pAccountNumber = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCompanyName = new DataColumnParameter(defCompanyName, pCompanyName);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramOwnerID = new DataColumnParameter(defOwnerID, pOwnerID);
                DataColumnParameter paramSLAFileName = new DataColumnParameter(defSLAFileName, pSLAFileName);
                DataColumnParameter paramScadwareURL = new DataColumnParameter(defScadwareURL, pScadwareURL);
                DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
                DataColumnParameter paramMobile = new DataColumnParameter(defMobile, pMobile);
                DataColumnParameter paramWebsiteURL = new DataColumnParameter(defWebsiteURL, pWebsiteURL);
                DataColumnParameter paramLogoFileName = new DataColumnParameter(defLogoFileName, pLogoFileName);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
                DataColumnParameter paramNameAbbreviation = new DataColumnParameter(defNameAbbreviation, pNameAbbreviation);
                DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramCompanyName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramOwnerID.GetSQLQuotedValueForAdd(),
paramSLAFileName.GetSQLQuotedValueForAdd(),
paramScadwareURL.GetSQLQuotedValueForAdd(),
paramEmail.GetSQLQuotedValueForAdd(),
paramMobile.GetSQLQuotedValueForAdd(),
paramWebsiteURL.GetSQLQuotedValueForAdd(),
paramLogoFileName.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd(),
paramNameAbbreviation.GetSQLQuotedValueForAdd(),
paramAddress.GetSQLQuotedValueForAdd(),
paramBankID.GetSQLQuotedValueForAdd(),
paramAccountName.GetSQLQuotedValueForAdd(),
paramAccountNumber.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pCompanyName,
DateTime pCreatedAt,
Int32 pOwnerID,
Boolean pIsActive,
String pNameAbbreviation,
Object pSLAFileName = null,
Object pScadwareURL = null,
Object pEmail = null,
Object pMobile = null,
Object pWebsiteURL = null,
Object pLogoFileName = null,
Object pUpdatedAt = null,
Object pAddress = null,
Object pBankID = null,
Object pAccountName = null,
Object pAccountNumber = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramCompanyName = new DataColumnParameter(defCompanyName, pCompanyName);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramOwnerID = new DataColumnParameter(defOwnerID, pOwnerID);
DataColumnParameter paramSLAFileName = new DataColumnParameter(defSLAFileName, pSLAFileName);
DataColumnParameter paramScadwareURL = new DataColumnParameter(defScadwareURL, pScadwareURL);
DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
DataColumnParameter paramMobile = new DataColumnParameter(defMobile, pMobile);
DataColumnParameter paramWebsiteURL = new DataColumnParameter(defWebsiteURL, pWebsiteURL);
DataColumnParameter paramLogoFileName = new DataColumnParameter(defLogoFileName, pLogoFileName);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
DataColumnParameter paramNameAbbreviation = new DataColumnParameter(defNameAbbreviation, pNameAbbreviation);
DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramCompanyName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramOwnerID.GetSQLQuotedValueForAdd(),
paramSLAFileName.GetSQLQuotedValueForAdd(),
paramScadwareURL.GetSQLQuotedValueForAdd(),
paramEmail.GetSQLQuotedValueForAdd(),
paramMobile.GetSQLQuotedValueForAdd(),
paramWebsiteURL.GetSQLQuotedValueForAdd(),
paramLogoFileName.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd(),
paramNameAbbreviation.GetSQLQuotedValueForAdd(),
paramAddress.GetSQLQuotedValueForAdd(),
paramBankID.GetSQLQuotedValueForAdd(),
paramAccountName.GetSQLQuotedValueForAdd(),
paramAccountNumber.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pCompanyName,
DateTime pCreatedAt,
Int32 pOwnerID,
Boolean pIsActive,
String pNameAbbreviation,
Object pSLAFileName= null,
Object pScadwareURL= null,
Object pEmail= null,
Object pMobile= null,
Object pWebsiteURL= null,
Object pLogoFileName= null,
Object pUpdatedAt= null,
Object pAddress= null,
Object pBankID= null,
Object pAccountName= null,
Object pAccountNumber= null){

        try{

DataColumnParameter paramCompanyName = new DataColumnParameter(defCompanyName, pCompanyName);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramOwnerID = new DataColumnParameter(defOwnerID, pOwnerID);
DataColumnParameter paramSLAFileName = new DataColumnParameter(defSLAFileName, pSLAFileName);
DataColumnParameter paramScadwareURL = new DataColumnParameter(defScadwareURL, pScadwareURL);
DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
DataColumnParameter paramMobile = new DataColumnParameter(defMobile, pMobile);
DataColumnParameter paramWebsiteURL = new DataColumnParameter(defWebsiteURL, pWebsiteURL);
DataColumnParameter paramLogoFileName = new DataColumnParameter(defLogoFileName, pLogoFileName);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
DataColumnParameter paramNameAbbreviation = new DataColumnParameter(defNameAbbreviation, pNameAbbreviation);
DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) ", TABLE_NAME,paramCompanyName.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramOwnerID.GetSQLQuotedValueForAdd(),
paramSLAFileName.GetSQLQuotedValueForAdd(),
paramScadwareURL.GetSQLQuotedValueForAdd(),
paramEmail.GetSQLQuotedValueForAdd(),
paramMobile.GetSQLQuotedValueForAdd(),
paramWebsiteURL.GetSQLQuotedValueForAdd(),
paramLogoFileName.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd(),
paramNameAbbreviation.GetSQLQuotedValueForAdd(),
paramAddress.GetSQLQuotedValueForAdd(),
paramBankID.GetSQLQuotedValueForAdd(),
paramAccountName.GetSQLQuotedValueForAdd(),
paramAccountNumber.GetSQLQuotedValueForAdd()  ), true);


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
Object pCompanyName = null,
Object pCreatedAt = null,
Object pOwnerID = null,
Object pIsActive = null,
Object pNameAbbreviation = null,
Object pSLAFileName = null,
Object pScadwareURL = null,
Object pEmail = null,
Object pMobile = null,
Object pWebsiteURL = null,
Object pLogoFileName = null,
Object pUpdatedAt = null,
Object pAddress = null,
Object pBankID = null,
Object pAccountName = null,
Object pAccountNumber = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramCompanyName = new DataColumnParameter(defCompanyName, pCompanyName);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramOwnerID = new DataColumnParameter(defOwnerID, pOwnerID);
 DataColumnParameter paramSLAFileName = new DataColumnParameter(defSLAFileName, pSLAFileName);
 DataColumnParameter paramScadwareURL = new DataColumnParameter(defScadwareURL, pScadwareURL);
 DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
 DataColumnParameter paramMobile = new DataColumnParameter(defMobile, pMobile);
 DataColumnParameter paramWebsiteURL = new DataColumnParameter(defWebsiteURL, pWebsiteURL);
 DataColumnParameter paramLogoFileName = new DataColumnParameter(defLogoFileName, pLogoFileName);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
 DataColumnParameter paramNameAbbreviation = new DataColumnParameter(defNameAbbreviation, pNameAbbreviation);
 DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
 DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
 DataColumnParameter paramAccountName = new DataColumnParameter(defAccountName, pAccountName);
 DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [CompanyName]={2},[CreatedAt]={3},[OwnerID]={4},[SLAFileName]={5},[ScadwareURL]={6},[Email]={7},[Mobile]={8},[WebsiteURL]={9},[LogoFileName]={10},[UpdatedAt]={11},[IsActive]={12},[NameAbbreviation]={13},[Address]={14},[BankID]={15},[AccountName]={16},[AccountNumber]={17} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramCompanyName.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramOwnerID.GetSQLQuotedValueForUpdate(),
paramSLAFileName.GetSQLQuotedValueForUpdate(),
paramScadwareURL.GetSQLQuotedValueForUpdate(),
paramEmail.GetSQLQuotedValueForUpdate(),
paramMobile.GetSQLQuotedValueForUpdate(),
paramWebsiteURL.GetSQLQuotedValueForUpdate(),
paramLogoFileName.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramIsActive.GetSQLQuotedValueForUpdate(),
paramNameAbbreviation.GetSQLQuotedValueForUpdate(),
paramAddress.GetSQLQuotedValueForUpdate(),
paramBankID.GetSQLQuotedValueForUpdate(),
paramAccountName.GetSQLQuotedValueForUpdate(),
paramAccountNumber.GetSQLQuotedValueForUpdate()  ), true);


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
