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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.accounting                  
{                  

    public class V___DealerView : Sample__Table, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static V___DealerView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDealerCode = new DataColumnDefinition(TableColumnNames.DealerCode.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCompanyName = new DataColumnDefinition(TableColumnNames.CompanyName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWebsiteUrl = new DataColumnDefinition(TableColumnNames.WebsiteUrl.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOfficeAddress = new DataColumnDefinition(TableColumnNames.OfficeAddress.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountryID = new DataColumnDefinition(TableColumnNames.CountryID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(TableColumnNames.FullName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomeAddress = new DataColumnDefinition(TableColumnNames.HomeAddress.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankName = new DataColumnDefinition(TableColumnNames.BankName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRegisteredEmail = new DataColumnDefinition(TableColumnNames.RegisteredEmail.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRegisteredMobile = new DataColumnDefinition(TableColumnNames.RegisteredMobile.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobileNumber = new DataColumnDefinition(TableColumnNames.MobileNumber.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUsername = new DataColumnDefinition(TableColumnNames.Username.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       private static List<string> ReferencedTableNames;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public Int32 PersonID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonID.ToString()]);
           }
       }


       public Int32 BankID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BankID.ToString()]);
           }
       }


       public String AccountNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountNumber.ToString()]);
           }
       }


       public Boolean IsActive {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsActive.ToString()]);
           }
       }


       public String DealerCode {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.DealerCode.ToString()]);
           }
       }


       public String CompanyName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.CompanyName.ToString()]);
           }
       }


       public String WebsiteUrl {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.WebsiteUrl.ToString()]);
           }
       }


       public String OfficeAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.OfficeAddress.ToString()]);
           }
       }


       public Int32 CountryID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CountryID.ToString()]);
           }
       }


       public String FullName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FullName.ToString()]);
           }
       }


       public String FirstName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FirstName.ToString()]);
           }
       }


       public String LastName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.LastName.ToString()]);
           }
       }


       public String PictureFileName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PictureFileName.ToString()]);
           }
       }


       public String HomeAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.HomeAddress.ToString()]);
           }
       }


       public String BankName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BankName.ToString()]);
           }
       }


       public String RegisteredEmail {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.RegisteredEmail.ToString()]);
           }
       }


       public String RegisteredMobile {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.RegisteredMobile.ToString()]);
           }
       }


       public String Email {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Email.ToString()]);
           }
       }


       public String MobileNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.MobileNumber.ToString()]);
           }
       }


       public String Username {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Username.ToString()]);
           }
       }


       public Int32 UserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UserID.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public V___DealerView GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new V___DealerView(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static V___DealerView GetFullTable()                  
        {                  
            return new V___DealerView(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static V___DealerView GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new V___DealerView(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public V___DealerView GetRowWhereID(int pID)                  
        {                  
            return new V___DealerView(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(V___DealerView pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(V___DealerView pRow, params DataColumnParameter[] pParams)                  
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
        public V___DealerView GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new V___DealerView(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___DealerView(drst);                  
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
        public V___DealerView getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new V___DealerView(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___DealerView(drst);                  
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

                  
    public List<string> getReferencedTableNames()                  
    {                  
        return ReferencedTableNames;                  
    }                  
                  
    public string getViewName()                  
    {                  
        return TABLE_NAME;                  
    }                  

                  
                  
#endregion                  
                  
                  



   }


}
