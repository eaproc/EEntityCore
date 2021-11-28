using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using ELibrary.Standard.VB.Modules;                  
using EEntityCore.DB.Schemas.SQLServerSchema;                  
using EEntityCore.DB.MSSQL;                  
using EEntityCore.DB.Modules;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.accounting                  
{                  

    public class V___DealerView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___DealerView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BankID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountNumber.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDealerCode = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DealerCode.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCompanyName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CompanyName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWebsiteUrl = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.WebsiteUrl.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOfficeAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.OfficeAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountryID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CountryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FullName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PictureFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomeAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.HomeAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BankName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRegisteredEmail = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RegisteredEmail.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRegisteredMobile = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RegisteredMobile.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobileNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MobileNumber.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUsername = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Username.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


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
          ColumnDefns.Add(defFullName.ColumnName, defFullName); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName); 
          ColumnDefns.Add(defHomeAddress.ColumnName, defHomeAddress); 
          ColumnDefns.Add(defBankName.ColumnName, defBankName); 
          ColumnDefns.Add(defRegisteredEmail.ColumnName, defRegisteredEmail); 
          ColumnDefns.Add(defRegisteredMobile.ColumnName, defRegisteredMobile); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defMobileNumber.ColumnName, defMobileNumber); 
          ColumnDefns.Add(defUsername.ColumnName, defUsername); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("accounting.Dealer");                  
            ReferencedTableNames.Add("auth.UserVerifiedContact");                  
            ReferencedTableNames.Add("common.Bank");                  
            ReferencedTableNames.Add("common.PersonView");                  

          }


                  
       public V___DealerView() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___DealerView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___DealerView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___DealerView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___DealerView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___DealerView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___DealerView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___DealerView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___DealerView(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public V___DealerView(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.DealerView";
       public const string DealerView__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PersonID], [BankID], [AccountNumber], [IsActive], [DealerCode], [CompanyName], [WebsiteUrl], [OfficeAddress], [CountryID], [FullName], [FirstName], [LastName], [PictureFileName], [HomeAddress], [BankName], [RegisteredEmail], [RegisteredMobile], [Email], [MobileNumber], [Username], [UserID] FROM DealerView";
       public const string DealerView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PersonID], [BankID], [AccountNumber], [IsActive], [DealerCode], [CompanyName], [WebsiteUrl], [OfficeAddress], [CountryID], [FullName], [FirstName], [LastName], [PictureFileName], [HomeAddress], [BankName], [RegisteredEmail], [RegisteredMobile], [Email], [MobileNumber], [Username], [UserID] FROM DealerView";


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
           FullName,
           FirstName,
           LastName,
           PictureFileName,
           HomeAddress,
           BankName,
           RegisteredEmail,
           RegisteredMobile,
           Email,
           MobileNumber,
           Username,
           UserID
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

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
       public static readonly DataColumnDefinition defFullName;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defPictureFileName;
       public static readonly DataColumnDefinition defHomeAddress;
       public static readonly DataColumnDefinition defBankName;
       public static readonly DataColumnDefinition defRegisteredEmail;
       public static readonly DataColumnDefinition defRegisteredMobile;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defMobileNumber;
       public static readonly DataColumnDefinition defUsername;
       public static readonly DataColumnDefinition defUserID;

       public int PersonID { get => (int)TargettedRow[TableColumnNames.PersonID.ToString()]; }


       public int? BankID { get => (int?)TargettedRow[TableColumnNames.BankID.ToString()]; }


       public string AccountNumber { get => (string)TargettedRow[TableColumnNames.AccountNumber.ToString()]; }


       public bool IsActive { get => (bool)TargettedRow[TableColumnNames.IsActive.ToString()]; }


       public string DealerCode { get => (string)TargettedRow[TableColumnNames.DealerCode.ToString()]; }


       public string CompanyName { get => (string)TargettedRow[TableColumnNames.CompanyName.ToString()]; }


       public string WebsiteUrl { get => (string)TargettedRow[TableColumnNames.WebsiteUrl.ToString()]; }


       public string OfficeAddress { get => (string)TargettedRow[TableColumnNames.OfficeAddress.ToString()]; }


       public int CountryID { get => (int)TargettedRow[TableColumnNames.CountryID.ToString()]; }


       public string FullName { get => (string)TargettedRow[TableColumnNames.FullName.ToString()]; }


       public string FirstName { get => (string)TargettedRow[TableColumnNames.FirstName.ToString()]; }


       public string LastName { get => (string)TargettedRow[TableColumnNames.LastName.ToString()]; }


       public string PictureFileName { get => (string)TargettedRow[TableColumnNames.PictureFileName.ToString()]; }


       public string HomeAddress { get => (string)TargettedRow[TableColumnNames.HomeAddress.ToString()]; }


       public string BankName { get => (string)TargettedRow[TableColumnNames.BankName.ToString()]; }


       public string RegisteredEmail { get => (string)TargettedRow[TableColumnNames.RegisteredEmail.ToString()]; }


       public string RegisteredMobile { get => (string)TargettedRow[TableColumnNames.RegisteredMobile.ToString()]; }


       public string Email { get => (string)TargettedRow[TableColumnNames.Email.ToString()]; }


       public string MobileNumber { get => (string)TargettedRow[TableColumnNames.MobileNumber.ToString()]; }


       public string Username { get => (string)TargettedRow[TableColumnNames.Username.ToString()]; }


       public int? UserID { get => (int?)TargettedRow[TableColumnNames.UserID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public V___DealerView GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static V___DealerView GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static V___DealerView GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new V___DealerView(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public V___DealerView GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => DealerView__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
