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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.charity                  
{                  

    public class V___MonthlyDonationView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___MonthlyDonationView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defDonationYear = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DonationYear.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDonationMonth = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DonationMonth.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsApproved = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsApproved.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsDisbursed = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsDisbursed.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotalAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TotalAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotalBeneficiaries = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TotalBeneficiaries.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FullName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobilePhone = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MobilePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defResidingPastorPersonID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ResidingPastorPersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BankName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CenterName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CenterAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CenterID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defResidingPastorID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ResidingPastorID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BankID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


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


                  
       public V___MonthlyDonationView() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___MonthlyDonationView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___MonthlyDonationView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___MonthlyDonationView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___MonthlyDonationView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___MonthlyDonationView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___MonthlyDonationView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___MonthlyDonationView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___MonthlyDonationView(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public int DonationYear { get => (int)TargettedRow[TableColumnNames.DonationYear.ToString()]; }


       public int DonationMonth { get => (int)TargettedRow[TableColumnNames.DonationMonth.ToString()]; }


       public string AccountNumber { get => (string)TargettedRow[TableColumnNames.AccountNumber.ToString()]; }


       public bool IsApproved { get => (bool)TargettedRow[TableColumnNames.IsApproved.ToString()]; }


       public bool IsDisbursed { get => (bool)TargettedRow[TableColumnNames.IsDisbursed.ToString()]; }


       public decimal TotalAmount { get => (decimal)TargettedRow[TableColumnNames.TotalAmount.ToString()]; }


       public int TotalBeneficiaries { get => (int)TargettedRow[TableColumnNames.TotalBeneficiaries.ToString()]; }


       public string FullName { get => (string)TargettedRow[TableColumnNames.FullName.ToString()]; }


       public string Email { get => (string)TargettedRow[TableColumnNames.Email.ToString()]; }


       public string MobilePhone { get => (string)TargettedRow[TableColumnNames.MobilePhone.ToString()]; }


       public int ResidingPastorPersonID { get => (int)TargettedRow[TableColumnNames.ResidingPastorPersonID.ToString()]; }


       public string BankName { get => (string)TargettedRow[TableColumnNames.BankName.ToString()]; }


       public string CenterName { get => (string)TargettedRow[TableColumnNames.CenterName.ToString()]; }


       public string CenterAddress { get => (string)TargettedRow[TableColumnNames.CenterAddress.ToString()]; }


       public int CenterID { get => (int)TargettedRow[TableColumnNames.CenterID.ToString()]; }


       public int ResidingPastorID { get => (int)TargettedRow[TableColumnNames.ResidingPastorID.ToString()]; }


       public int BankID { get => (int)TargettedRow[TableColumnNames.BankID.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime UpdatedAt { get => (DateTime)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public int UpdatedByID { get => (int)TargettedRow[TableColumnNames.UpdatedByID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public V___MonthlyDonationView GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static V___MonthlyDonationView GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static V___MonthlyDonationView GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new V___MonthlyDonationView(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public V___MonthlyDonationView GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => MonthlyDonationView__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
