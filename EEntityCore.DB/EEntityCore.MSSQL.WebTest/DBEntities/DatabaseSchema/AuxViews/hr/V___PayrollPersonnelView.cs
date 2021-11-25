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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.hr                  
{                  

    public class V___PayrollPersonnelView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static V___PayrollPersonnelView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defPersonnelNumber = new DataColumnDefinition(TableColumnNames.PersonnelNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(TableColumnNames.FullName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAttendanceCount = new DataColumnDefinition(TableColumnNames.AttendanceCount.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSalaryAmount = new DataColumnDefinition(TableColumnNames.SalaryAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerDay = new DataColumnDefinition(TableColumnNames.RatePerDay.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defApprovedAmount = new DataColumnDefinition(TableColumnNames.ApprovedAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsDisbursed = new DataColumnDefinition(TableColumnNames.IsDisbursed.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonnelID = new DataColumnDefinition(TableColumnNames.PersonnelID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayrollID = new DataColumnDefinition(TableColumnNames.PayrollID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBursarComments = new DataColumnDefinition(TableColumnNames.BursarComments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCalculatedAmount = new DataColumnDefinition(TableColumnNames.CalculatedAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDisbursedAmount = new DataColumnDefinition(TableColumnNames.DisbursedAmount.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHRComments = new DataColumnDefinition(TableColumnNames.HRComments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDisbursedAt = new DataColumnDefinition(TableColumnNames.DisbursedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStartDate = new DataColumnDefinition(TableColumnNames.StartDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndDate = new DataColumnDefinition(TableColumnNames.EndDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsApproved = new DataColumnDefinition(TableColumnNames.IsApproved.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayrollWorkingDays = new DataColumnDefinition(TableColumnNames.PayrollWorkingDays.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMonthWorkingDays = new DataColumnDefinition(TableColumnNames.MonthWorkingDays.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankName = new DataColumnDefinition(TableColumnNames.BankName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defPersonnelNumber.ColumnName, defPersonnelNumber); 
          ColumnDefns.Add(defFullName.ColumnName, defFullName); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defAttendanceCount.ColumnName, defAttendanceCount); 
          ColumnDefns.Add(defSalaryAmount.ColumnName, defSalaryAmount); 
          ColumnDefns.Add(defRatePerDay.ColumnName, defRatePerDay); 
          ColumnDefns.Add(defApprovedAmount.ColumnName, defApprovedAmount); 
          ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed); 
          ColumnDefns.Add(defPersonnelID.ColumnName, defPersonnelID); 
          ColumnDefns.Add(defPayrollID.ColumnName, defPayrollID); 
          ColumnDefns.Add(defBursarComments.ColumnName, defBursarComments); 
          ColumnDefns.Add(defCalculatedAmount.ColumnName, defCalculatedAmount); 
          ColumnDefns.Add(defDisbursedAmount.ColumnName, defDisbursedAmount); 
          ColumnDefns.Add(defHRComments.ColumnName, defHRComments); 
          ColumnDefns.Add(defDisbursedAt.ColumnName, defDisbursedAt); 
          ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defStartDate.ColumnName, defStartDate); 
          ColumnDefns.Add(defEndDate.ColumnName, defEndDate); 
          ColumnDefns.Add(defIsApproved.ColumnName, defIsApproved); 
          ColumnDefns.Add(defPayrollWorkingDays.ColumnName, defPayrollWorkingDays); 
          ColumnDefns.Add(defMonthWorkingDays.ColumnName, defMonthWorkingDays); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defBankName.ColumnName, defBankName); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("common.Bank");                  
            ReferencedTableNames.Add("common.PersonView");                  
            ReferencedTableNames.Add("hr.Payroll");                  
            ReferencedTableNames.Add("hr.PayrollPersonnel");                  
            ReferencedTableNames.Add("hr.Personnel");                  
            ReferencedTableNames.Add("hr.PersonnelBankDetail");                  

          }


                  
       public V___PayrollPersonnelView() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___PayrollPersonnelView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___PayrollPersonnelView(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public V___PayrollPersonnelView(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "hr.PayrollPersonnelView";
       public const string PayrollPersonnelView__NO__BINARY___SQL_FILL_QUERY = "SELECT [PersonnelNumber], [FullName], [FirstName], [LastName], [AttendanceCount], [SalaryAmount], [RatePerDay], [ApprovedAmount], [IsDisbursed], [PersonnelID], [PayrollID], [BursarComments], [CalculatedAmount], [DisbursedAmount], [HRComments], [DisbursedAt], [PictureFileName], [PersonID], [StartDate], [EndDate], [IsApproved], [PayrollWorkingDays], [MonthWorkingDays], [ID], [BankName], [BankID], [AccountNumber] FROM PayrollPersonnelView";
       public const string PayrollPersonnelView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [PersonnelNumber], [FullName], [FirstName], [LastName], [AttendanceCount], [SalaryAmount], [RatePerDay], [ApprovedAmount], [IsDisbursed], [PersonnelID], [PayrollID], [BursarComments], [CalculatedAmount], [DisbursedAmount], [HRComments], [DisbursedAt], [PictureFileName], [PersonID], [StartDate], [EndDate], [IsApproved], [PayrollWorkingDays], [MonthWorkingDays], [ID], [BankName], [BankID], [AccountNumber] FROM PayrollPersonnelView";


       public enum TableColumnNames
       {

           PersonnelNumber,
           FullName,
           FirstName,
           LastName,
           AttendanceCount,
           SalaryAmount,
           RatePerDay,
           ApprovedAmount,
           IsDisbursed,
           PersonnelID,
           PayrollID,
           BursarComments,
           CalculatedAmount,
           DisbursedAmount,
           HRComments,
           DisbursedAt,
           PictureFileName,
           PersonID,
           StartDate,
           EndDate,
           IsApproved,
           PayrollWorkingDays,
           MonthWorkingDays,
           ID,
           BankName,
           BankID,
           AccountNumber
       } 


 #endregion 


 #region Properties 

       private static List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defPersonnelNumber;
       public static readonly DataColumnDefinition defFullName;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defAttendanceCount;
       public static readonly DataColumnDefinition defSalaryAmount;
       public static readonly DataColumnDefinition defRatePerDay;
       public static readonly DataColumnDefinition defApprovedAmount;
       public static readonly DataColumnDefinition defIsDisbursed;
       public static readonly DataColumnDefinition defPersonnelID;
       public static readonly DataColumnDefinition defPayrollID;
       public static readonly DataColumnDefinition defBursarComments;
       public static readonly DataColumnDefinition defCalculatedAmount;
       public static readonly DataColumnDefinition defDisbursedAmount;
       public static readonly DataColumnDefinition defHRComments;
       public static readonly DataColumnDefinition defDisbursedAt;
       public static readonly DataColumnDefinition defPictureFileName;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defStartDate;
       public static readonly DataColumnDefinition defEndDate;
       public static readonly DataColumnDefinition defIsApproved;
       public static readonly DataColumnDefinition defPayrollWorkingDays;
       public static readonly DataColumnDefinition defMonthWorkingDays;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defBankName;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountNumber;

       public String PersonnelNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PersonnelNumber.ToString()]);
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


       public Int32 AttendanceCount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.AttendanceCount.ToString()]);
           }
       }


       public Decimal SalaryAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.SalaryAmount.ToString()]);
           }
       }


       public Decimal RatePerDay {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.RatePerDay.ToString()]);
           }
       }


       public Decimal ApprovedAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.ApprovedAmount.ToString()]);
           }
       }


       public Boolean IsDisbursed {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsDisbursed.ToString()]);
           }
       }


       public Int32 PersonnelID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonnelID.ToString()]);
           }
       }


       public Int32 PayrollID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PayrollID.ToString()]);
           }
       }


       public String BursarComments {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BursarComments.ToString()]);
           }
       }


       public Decimal CalculatedAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.CalculatedAmount.ToString()]);
           }
       }


       public Decimal DisbursedAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.DisbursedAmount.ToString()]);
           }
       }


       public String HRComments {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.HRComments.ToString()]);
           }
       }


       public NullableDateTime DisbursedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.DisbursedAt.ToString()]);
           }
       }


       public String PictureFileName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PictureFileName.ToString()]);
           }
       }


       public Int32 PersonID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonID.ToString()]);
           }
       }


       public NullableDateTime StartDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.StartDate.ToString()]);
           }
       }


       public NullableDateTime EndDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.EndDate.ToString()]);
           }
       }


       public Boolean IsApproved {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsApproved.ToString()]);
           }
       }


       public Int32 PayrollWorkingDays {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PayrollWorkingDays.ToString()]);
           }
       }


       public Int32 MonthWorkingDays {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.MonthWorkingDays.ToString()]);
           }
       }


       public String BankName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BankName.ToString()]);
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


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public V___PayrollPersonnelView GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new V___PayrollPersonnelView(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static V___PayrollPersonnelView GetFullTable()                  
        {                  
            return new V___PayrollPersonnelView(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static V___PayrollPersonnelView GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new V___PayrollPersonnelView(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public V___PayrollPersonnelView GetRowWhereID(int pID)                  
        {                  
            return new V___PayrollPersonnelView(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(V___PayrollPersonnelView pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(V___PayrollPersonnelView pRow, params DataColumnParameter[] pParams)                  
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
        public V___PayrollPersonnelView GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new V___PayrollPersonnelView(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___PayrollPersonnelView(drst);                  
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
        public V___PayrollPersonnelView getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new V___PayrollPersonnelView(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___PayrollPersonnelView(drst);                  
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

                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
#endregion                  
                  
                  



   }


}
