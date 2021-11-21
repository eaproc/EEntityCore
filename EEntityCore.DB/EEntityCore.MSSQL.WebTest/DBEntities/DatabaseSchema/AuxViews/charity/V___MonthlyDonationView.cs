using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.charity                  
{                  

    public class V___MonthlyDonationView : Sample__Table, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static V___MonthlyDonationView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defDonationYear = new DataColumnDefinition(TableColumnNames.DonationYear.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDonationMonth = new DataColumnDefinition(TableColumnNames.DonationMonth.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsApproved = new DataColumnDefinition(TableColumnNames.IsApproved.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsDisbursed = new DataColumnDefinition(TableColumnNames.IsDisbursed.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotalAmount = new DataColumnDefinition(TableColumnNames.TotalAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotalBeneficiaries = new DataColumnDefinition(TableColumnNames.TotalBeneficiaries.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(TableColumnNames.FullName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobilePhone = new DataColumnDefinition(TableColumnNames.MobilePhone.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defResidingPastorPersonID = new DataColumnDefinition(TableColumnNames.ResidingPastorPersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankName = new DataColumnDefinition(TableColumnNames.BankName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterName = new DataColumnDefinition(TableColumnNames.CenterName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterAddress = new DataColumnDefinition(TableColumnNames.CenterAddress.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterID = new DataColumnDefinition(TableColumnNames.CenterID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defResidingPastorID = new DataColumnDefinition(TableColumnNames.ResidingPastorID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defDonationYear.ColumnName, defDonationYear); 
          ColumnDefns.Add(defDonationMonth.ColumnName, defDonationMonth); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defIsApproved.ColumnName, defIsApproved); 
          ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed); 
          ColumnDefns.Add(defTotalAmount.ColumnName, defTotalAmount); 
          ColumnDefns.Add(defTotalBeneficiaries.ColumnName, defTotalBeneficiaries); 
          ColumnDefns.Add(defFullName.ColumnName, defFullName); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defMobilePhone.ColumnName, defMobilePhone); 
          ColumnDefns.Add(defResidingPastorPersonID.ColumnName, defResidingPastorPersonID); 
          ColumnDefns.Add(defBankName.ColumnName, defBankName); 
          ColumnDefns.Add(defCenterName.ColumnName, defCenterName); 
          ColumnDefns.Add(defCenterAddress.ColumnName, defCenterAddress); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCenterID.ColumnName, defCenterID); 
          ColumnDefns.Add(defResidingPastorID.ColumnName, defResidingPastorID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("charity.Center");                  
            ReferencedTableNames.Add("charity.DonationInvoiceItem");                  
            ReferencedTableNames.Add("charity.MonthlyDonation");                  
            ReferencedTableNames.Add("charity.ResidingPastor");                  
            ReferencedTableNames.Add("common.Bank");                  
            ReferencedTableNames.Add("common.PersonView");                  

          }


                  
        public V___MonthlyDonationView() : base(TABLE_NAME)                  
        {                  
        }                  


                  
                  
        #region Full Access                  
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                    
                  
        /// <summary>                                    
        /// FULL ACCESS. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="TableName"></param>                                    
        /// <remarks></remarks>                  
        public V___MonthlyDonationView(All__DBs DBConn, string TableName) : base(DBConn, TableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                    
        /// <remarks></remarks>                  
        public V___MonthlyDonationView(All__DBs DBConn, string pTableName, long pTargettedRowID) : base(DBConn, pTableName, pTargettedRowID: pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public V___MonthlyDonationView(All__DBs pDBConn, string pTableName, string pSQL) : base(pDBConn, pTableName, pSQL)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public V___MonthlyDonationView(All__DBs pDBConn, string pTableName, string pSQL, long pTargettedRowID) : base(pDBConn, pTableName, pSQL, pTargettedRowID)                  
        {                  
        }                  
                  
        #endregion                  
                  
                  
        #region Partial Access                  
                  
        // Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work                                    
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___MonthlyDonationView(DataRowCollection pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___MonthlyDonationView(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="FullTable"></param>                                    
        /// <param name="TargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___MonthlyDonationView(DataTable FullTable, int TargettedRowID, string TableName, All__DBs DBConn) : base(FullTable, TargettedRowID, TableName, DBConn)                  
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
        public V___MonthlyDonationView(DataRow TargettedRow) : base(TargettedRow)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___MonthlyDonationView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___MonthlyDonationView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___MonthlyDonationView(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName) : base(pTableRows, pTargettedRowID, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___MonthlyDonationView(DataTable FullTable, string pTableName) : base(FullTable, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___MonthlyDonationView(DataTable FullTable, string pTableName, long pTargettedRowID) : base(FullTable, pTableName, pTargettedRowID)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___MonthlyDonationView(DataRowCollection pDataRows, string pTableName) : base(pDataRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___MonthlyDonationView(IEnumerable<DataRow> pTableRows, string pTableName) : base(pTableRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access. Should always target this passed in                                    
        /// </summary>                                    
        /// <param name="pTargettedRow"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___MonthlyDonationView(DataRow pTargettedRow, string pTableName) : base(pTargettedRow, pTableName)                  
        {                  
        }                  
                  
                  
        #endregion                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
#endregion                  
                  
                  
                  
#region Consts and Enums                  

       public const string TABLE_NAME = "charity.MonthlyDonationView";
       public const string MonthlyDonationView__NO__BINARY___SQL_FILL_QUERY = "SELECT [DonationYear], [DonationMonth], [AccountNumber], [IsApproved], [IsDisbursed], [TotalAmount], [TotalBeneficiaries], [FullName], [Email], [MobilePhone], [ResidingPastorPersonID], [BankName], [CenterName], [CenterAddress], [ID], [CenterID], [ResidingPastorID], [BankID], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM MonthlyDonationView";
       public const string MonthlyDonationView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [DonationYear], [DonationMonth], [AccountNumber], [IsApproved], [IsDisbursed], [TotalAmount], [TotalBeneficiaries], [FullName], [Email], [MobilePhone], [ResidingPastorPersonID], [BankName], [CenterName], [CenterAddress], [ID], [CenterID], [ResidingPastorID], [BankID], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM MonthlyDonationView";


       public enum TableColumnNames
       {

           DonationYear,
           DonationMonth,
           AccountNumber,
           IsApproved,
           IsDisbursed,
           TotalAmount,
           TotalBeneficiaries,
           FullName,
           Email,
           MobilePhone,
           ResidingPastorPersonID,
           BankName,
           CenterName,
           CenterAddress,
           ID,
           CenterID,
           ResidingPastorID,
           BankID,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 


 #endregion 


 #region Properties 

        private static List<string> ReferencedTableNames;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defDonationYear;
       public static readonly DataColumnDefinition defDonationMonth;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defIsApproved;
       public static readonly DataColumnDefinition defIsDisbursed;
       public static readonly DataColumnDefinition defTotalAmount;
       public static readonly DataColumnDefinition defTotalBeneficiaries;
       public static readonly DataColumnDefinition defFullName;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defMobilePhone;
       public static readonly DataColumnDefinition defResidingPastorPersonID;
       public static readonly DataColumnDefinition defBankName;
       public static readonly DataColumnDefinition defCenterName;
       public static readonly DataColumnDefinition defCenterAddress;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCenterID;
       public static readonly DataColumnDefinition defResidingPastorID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public Int32 DonationYear {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DonationYear.ToString()]);
           }
       }


       public Int32 DonationMonth {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DonationMonth.ToString()]);
           }
       }


       public String AccountNumber {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountNumber.ToString()]);
           }
       }


       public Boolean IsApproved {
           get{ 
               if (!this.isValidRow) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsApproved.ToString()]);
           }
       }


       public Boolean IsDisbursed {
           get{ 
               if (!this.isValidRow) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsDisbursed.ToString()]);
           }
       }


       public Decimal TotalAmount {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.TotalAmount.ToString()]);
           }
       }


       public Int32 TotalBeneficiaries {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TotalBeneficiaries.ToString()]);
           }
       }


       public String FullName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FullName.ToString()]);
           }
       }


       public String Email {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Email.ToString()]);
           }
       }


       public String MobilePhone {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.MobilePhone.ToString()]);
           }
       }


       public Int32 ResidingPastorPersonID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ResidingPastorPersonID.ToString()]);
           }
       }


       public String BankName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BankName.ToString()]);
           }
       }


       public String CenterName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.CenterName.ToString()]);
           }
       }


       public String CenterAddress {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.CenterAddress.ToString()]);
           }
       }


       public Int32 CenterID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CenterID.ToString()]);
           }
       }


       public Int32 ResidingPastorID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ResidingPastorID.ToString()]);
           }
       }


       public Int32 BankID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BankID.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.isValidRow) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public NullableDateTime UpdatedAt {
           get{ 
               if (!this.isValidRow) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]);
           }
       }


       public Int32 CreatedByID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


       public Int32 UpdatedByID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UpdatedByID.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public V___MonthlyDonationView getFirstRow()                  
        {                  
            if (this.hasRows())                  
                return new V___MonthlyDonationView(this.AllRows.ToArray()[0]);                  
            return null;                  
        }                  
                  
        public static V___MonthlyDonationView getFullTable()                  
        {                  
            return new V___MonthlyDonationView(DatabaseInit.DBConnectInterface.GetDBConn(), TABLE_NAME);                  
        }                  
                  
        public static V___MonthlyDonationView getRowWhereIDUsingSQL(int pID)                  
        {                  
            return new V___MonthlyDonationView(DBConnectInterface.GetDBConn(), TABLE_NAME, string.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, (object)pID)).getFirstRow();                  
        }                  
                  
        public V___MonthlyDonationView getRowWhereID(int pID)                  
        {                  
            return new V___MonthlyDonationView(this.RawTable, TABLE_NAME, pID);                  
        }                  
                  
        private bool IsAllRowEqual(V___MonthlyDonationView pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.hasRows())                  
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
                  
        private bool IsAnyRowEqual(V___MonthlyDonationView pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.hasRows())                  
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
        public V___MonthlyDonationView getAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new V___MonthlyDonationView(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___MonthlyDonationView(drst.CopyToDataTable(), TABLE_NAME);                  
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
        public V___MonthlyDonationView getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new V___MonthlyDonationView(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___MonthlyDonationView(drst.CopyToDataTable(), TABLE_NAME);                  
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
                if (!this.isTargettedRowValid())                  
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
