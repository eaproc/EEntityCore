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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.hr                  
{                  

    public class T___Client : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___Client()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCompanyName = new DataColumnDefinition(TableColumnNames.CompanyName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOwnerID = new DataColumnDefinition(TableColumnNames.OwnerID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSLAFileName = new DataColumnDefinition(TableColumnNames.SLAFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defScadwareURL = new DataColumnDefinition(TableColumnNames.ScadwareURL.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobile = new DataColumnDefinition(TableColumnNames.Mobile.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWebsiteURL = new DataColumnDefinition(TableColumnNames.WebsiteURL.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLogoFileName = new DataColumnDefinition(TableColumnNames.LogoFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNameAbbreviation = new DataColumnDefinition(TableColumnNames.NameAbbreviation.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(TableColumnNames.Address.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountName = new DataColumnDefinition(TableColumnNames.AccountName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public String CompanyName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.CompanyName.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public Int32 OwnerID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.OwnerID.ToString()]);
           }
       }


       public String SLAFileName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.SLAFileName.ToString()]);
           }
       }


       public String ScadwareURL {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ScadwareURL.ToString()]);
           }
       }


       public String Email {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Email.ToString()]);
           }
       }


       public String Mobile {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Mobile.ToString()]);
           }
       }


       public String WebsiteURL {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.WebsiteURL.ToString()]);
           }
       }


       public String LogoFileName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.LogoFileName.ToString()]);
           }
       }


       public NullableDateTime UpdatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]);
           }
       }


       public Boolean IsActive {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsActive.ToString()]);
           }
       }


       public String NameAbbreviation {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.NameAbbreviation.ToString()]);
           }
       }


       public String Address {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Address.ToString()]);
           }
       }


       public Int32 BankID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BankID.ToString()]);
           }
       }


       public String AccountName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountName.ToString()]);
           }
       }


       public String AccountNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountNumber.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___Client GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___Client(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___Client GetFullTable()                  
        {                  
            return new T___Client(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___Client GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___Client(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___Client GetRowWhereID(int pID)                  
        {                  
            return new T___Client(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___Client pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___Client pRow, params DataColumnParameter[] pParams)                  
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
        public T___Client GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___Client(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Client(drst);                  
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
        public T___Client getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___Client(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Client(drst);                  
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

                  
        public virtual string GetFillSQL() => Client__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
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
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramCompanyName.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramOwnerID.getSQLQuotedValueForAdd(),
                paramSLAFileName.getSQLQuotedValueForAdd(),
                paramScadwareURL.getSQLQuotedValueForAdd(),
                paramEmail.getSQLQuotedValueForAdd(),
                paramMobile.getSQLQuotedValueForAdd(),
                paramWebsiteURL.getSQLQuotedValueForAdd(),
                paramLogoFileName.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd(),
                paramIsActive.getSQLQuotedValueForAdd(),
                paramNameAbbreviation.getSQLQuotedValueForAdd(),
                paramAddress.getSQLQuotedValueForAdd(),
                paramBankID.getSQLQuotedValueForAdd(),
                paramAccountName.getSQLQuotedValueForAdd(),
                paramAccountNumber.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
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
