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

    public class T___PayrollPersonnel : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___PayrollPersonnel()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPayrollID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PayrollID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonnelID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonnelID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defAttendanceCount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AttendanceCount.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSalaryAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SalaryAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerDay = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RatePerDay.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCalculatedAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CalculatedAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsDisbursed = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsDisbursed.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHRComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.HRComments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defApprovedAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ApprovedAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBursarComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BursarComments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDisbursedAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DisbursedAmount.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDisbursedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DisbursedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPayrollID.ColumnName, defPayrollID); 
          ColumnDefns.Add(defPersonnelID.ColumnName, defPersonnelID); 
          ColumnDefns.Add(defAttendanceCount.ColumnName, defAttendanceCount); 
          ColumnDefns.Add(defSalaryAmount.ColumnName, defSalaryAmount); 
          ColumnDefns.Add(defRatePerDay.ColumnName, defRatePerDay); 
          ColumnDefns.Add(defCalculatedAmount.ColumnName, defCalculatedAmount); 
          ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed); 
          ColumnDefns.Add(defHRComments.ColumnName, defHRComments); 
          ColumnDefns.Add(defApprovedAmount.ColumnName, defApprovedAmount); 
          ColumnDefns.Add(defBursarComments.ColumnName, defBursarComments); 
          ColumnDefns.Add(defDisbursedAmount.ColumnName, defDisbursedAmount); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defDisbursedAt.ColumnName, defDisbursedAt); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PayrollPersonnel", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PayrollPersonnel", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_PayrollID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "hr.PayrollPersonnel", "hr.Payroll"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_PersonnelID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PayrollPersonnel", "hr.Personnel"                  
                            ));                  

          }


                  
       public T___PayrollPersonnel() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PayrollPersonnel(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PayrollPersonnel(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PayrollPersonnel(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "hr.PayrollPersonnel";
       public const string PayrollPersonnel__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PayrollID], [PersonnelID], [AttendanceCount], [SalaryAmount], [RatePerDay], [CalculatedAmount], [IsDisbursed], [HRComments], [ApprovedAmount], [BursarComments], [DisbursedAmount], [UpdatedAt], [CreatedAt], [CreatedByID], [DisbursedAt], [UpdatedByID] FROM PayrollPersonnel";
       public const string PayrollPersonnel__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PayrollID], [PersonnelID], [AttendanceCount], [SalaryAmount], [RatePerDay], [CalculatedAmount], [IsDisbursed], [HRComments], [ApprovedAmount], [BursarComments], [DisbursedAmount], [UpdatedAt], [CreatedAt], [CreatedByID], [DisbursedAt], [UpdatedByID] FROM PayrollPersonnel";


       public enum TableColumnNames
       {

           ID,
           PayrollID,
           PersonnelID,
           AttendanceCount,
           SalaryAmount,
           RatePerDay,
           CalculatedAmount,
           IsDisbursed,
           HRComments,
           ApprovedAmount,
           BursarComments,
           DisbursedAmount,
           UpdatedAt,
           CreatedAt,
           CreatedByID,
           DisbursedAt,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_hr_PayrollPersonnel, 
           fk_hr_PayrollPersonnel_CreatedByID, 
           fk_hr_PayrollPersonnel_UpdatedByID, 
           fk_hr_PayrollPersonnel_PayrollID, 
           fk_hr_PayrollPersonnel_PersonnelID, 
           uq_hr_PayrollPersonnel_PersonnelID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPayrollID;
       public static readonly DataColumnDefinition defPersonnelID;
       public static readonly DataColumnDefinition defAttendanceCount;
       public static readonly DataColumnDefinition defSalaryAmount;
       public static readonly DataColumnDefinition defRatePerDay;
       public static readonly DataColumnDefinition defCalculatedAmount;
       public static readonly DataColumnDefinition defIsDisbursed;
       public static readonly DataColumnDefinition defHRComments;
       public static readonly DataColumnDefinition defApprovedAmount;
       public static readonly DataColumnDefinition defBursarComments;
       public static readonly DataColumnDefinition defDisbursedAmount;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defDisbursedAt;
       public static readonly DataColumnDefinition defUpdatedByID;

       public Int32 PayrollID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PayrollID.ToString()]);
           }
       }


       public Int32 PersonnelID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonnelID.ToString()]);
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


       public Decimal CalculatedAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.CalculatedAmount.ToString()]);
           }
       }


       public Boolean IsDisbursed {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsDisbursed.ToString()]);
           }
       }


       public String HRComments {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.HRComments.ToString()]);
           }
       }


       public Decimal ApprovedAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.ApprovedAmount.ToString()]);
           }
       }


       public String BursarComments {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BursarComments.ToString()]);
           }
       }


       public Decimal DisbursedAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.DisbursedAmount.ToString()]);
           }
       }


       public NullableDateTime UpdatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public Int32 CreatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


       public NullableDateTime DisbursedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.DisbursedAt.ToString()]);
           }
       }


       public Int32 UpdatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
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
        public T___PayrollPersonnel GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___PayrollPersonnel(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___PayrollPersonnel GetFullTable()                  
        {                  
            return new T___PayrollPersonnel(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___PayrollPersonnel GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___PayrollPersonnel(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___PayrollPersonnel GetRowWhereID(int pID)                  
        {                  
            return new T___PayrollPersonnel(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___PayrollPersonnel pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (!pRow.RowEqual(pParam.ColumnDefinition.ColumnName, pParam.Value))                  
                        return false;                  
                }                  
                  
                return true;                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  
                  
        private bool IsAnyRowEqual(T___PayrollPersonnel pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (pRow.RowEqual(pParam.ColumnDefinition.ColumnName, pParam.Value))                  
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
        public T___PayrollPersonnel GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___PayrollPersonnel(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___PayrollPersonnel(drst);                  
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
        public T___PayrollPersonnel getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___PayrollPersonnel(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___PayrollPersonnel(drst);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                  
                  
        private bool RowEqual(string pColumnName, object pColumnValue)                  
        {                  
            try                  
            {                  
                if (!this.IsTargettedRowValid)                  
                    return false;                  
                switch (DataColumnDefinition.GetTypeAllowed(ColumnDefns[pColumnName].DataType))                  
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

                  
        public virtual string GetFillSQL() => PayrollPersonnel__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pPayrollID,
Int32 pPersonnelID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPayrollID = new DataColumnParameter(defPayrollID, pPayrollID);
                DataColumnParameter paramPersonnelID = new DataColumnParameter(defPersonnelID, pPersonnelID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramAttendanceCount = new DataColumnParameter(defAttendanceCount, defAttendanceCount.DefaultValue);
                DataColumnParameter paramSalaryAmount = new DataColumnParameter(defSalaryAmount, defSalaryAmount.DefaultValue);
                DataColumnParameter paramRatePerDay = new DataColumnParameter(defRatePerDay, defRatePerDay.DefaultValue);
                DataColumnParameter paramCalculatedAmount = new DataColumnParameter(defCalculatedAmount, defCalculatedAmount.DefaultValue);
                DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, defIsDisbursed.DefaultValue);
                DataColumnParameter paramHRComments = new DataColumnParameter(defHRComments, defHRComments.DefaultValue);
                DataColumnParameter paramApprovedAmount = new DataColumnParameter(defApprovedAmount, defApprovedAmount.DefaultValue);
                DataColumnParameter paramBursarComments = new DataColumnParameter(defBursarComments, defBursarComments.DefaultValue);
                DataColumnParameter paramDisbursedAmount = new DataColumnParameter(defDisbursedAmount, defDisbursedAmount.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramDisbursedAt = new DataColumnParameter(defDisbursedAt, defDisbursedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramPayrollID.GetSQLQuotedValueForAdd(),
                paramPersonnelID.GetSQLQuotedValueForAdd(),
                paramAttendanceCount.GetSQLQuotedValueForAdd(),
                paramSalaryAmount.GetSQLQuotedValueForAdd(),
                paramRatePerDay.GetSQLQuotedValueForAdd(),
                paramCalculatedAmount.GetSQLQuotedValueForAdd(),
                paramIsDisbursed.GetSQLQuotedValueForAdd(),
                paramHRComments.GetSQLQuotedValueForAdd(),
                paramApprovedAmount.GetSQLQuotedValueForAdd(),
                paramBursarComments.GetSQLQuotedValueForAdd(),
                paramDisbursedAmount.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedByID.GetSQLQuotedValueForAdd(),
                paramDisbursedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pPayrollID,
Int32 pPersonnelID,
Int32 pAttendanceCount,
Decimal pSalaryAmount,
Decimal pRatePerDay,
Decimal pCalculatedAmount,
Boolean pIsDisbursed,
Decimal pApprovedAmount,
DateTime pCreatedAt,
Int32 pCreatedByID,
Object pHRComments = null,
Object pBursarComments = null,
Object pDisbursedAmount = null,
Object pUpdatedAt = null,
Object pDisbursedAt = null,
Object pUpdatedByID = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPayrollID = new DataColumnParameter(defPayrollID, pPayrollID);
                DataColumnParameter paramPersonnelID = new DataColumnParameter(defPersonnelID, pPersonnelID);
                DataColumnParameter paramAttendanceCount = new DataColumnParameter(defAttendanceCount, pAttendanceCount);
                DataColumnParameter paramSalaryAmount = new DataColumnParameter(defSalaryAmount, pSalaryAmount);
                DataColumnParameter paramRatePerDay = new DataColumnParameter(defRatePerDay, pRatePerDay);
                DataColumnParameter paramCalculatedAmount = new DataColumnParameter(defCalculatedAmount, pCalculatedAmount);
                DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, pIsDisbursed);
                DataColumnParameter paramHRComments = new DataColumnParameter(defHRComments, pHRComments);
                DataColumnParameter paramApprovedAmount = new DataColumnParameter(defApprovedAmount, pApprovedAmount);
                DataColumnParameter paramBursarComments = new DataColumnParameter(defBursarComments, pBursarComments);
                DataColumnParameter paramDisbursedAmount = new DataColumnParameter(defDisbursedAmount, pDisbursedAmount);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramDisbursedAt = new DataColumnParameter(defDisbursedAt, pDisbursedAt);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramPayrollID.GetSQLQuotedValueForAdd(),
paramPersonnelID.GetSQLQuotedValueForAdd(),
paramAttendanceCount.GetSQLQuotedValueForAdd(),
paramSalaryAmount.GetSQLQuotedValueForAdd(),
paramRatePerDay.GetSQLQuotedValueForAdd(),
paramCalculatedAmount.GetSQLQuotedValueForAdd(),
paramIsDisbursed.GetSQLQuotedValueForAdd(),
paramHRComments.GetSQLQuotedValueForAdd(),
paramApprovedAmount.GetSQLQuotedValueForAdd(),
paramBursarComments.GetSQLQuotedValueForAdd(),
paramDisbursedAmount.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramDisbursedAt.GetSQLQuotedValueForAdd(),
paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pPayrollID,
Int32 pPersonnelID,
Int32 pAttendanceCount,
Decimal pSalaryAmount,
Decimal pRatePerDay,
Decimal pCalculatedAmount,
Boolean pIsDisbursed,
Decimal pApprovedAmount,
DateTime pCreatedAt,
Int32 pCreatedByID,
Object pHRComments = null,
Object pBursarComments = null,
Object pDisbursedAmount = null,
Object pUpdatedAt = null,
Object pDisbursedAt = null,
Object pUpdatedByID = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramPayrollID = new DataColumnParameter(defPayrollID, pPayrollID);
DataColumnParameter paramPersonnelID = new DataColumnParameter(defPersonnelID, pPersonnelID);
DataColumnParameter paramAttendanceCount = new DataColumnParameter(defAttendanceCount, pAttendanceCount);
DataColumnParameter paramSalaryAmount = new DataColumnParameter(defSalaryAmount, pSalaryAmount);
DataColumnParameter paramRatePerDay = new DataColumnParameter(defRatePerDay, pRatePerDay);
DataColumnParameter paramCalculatedAmount = new DataColumnParameter(defCalculatedAmount, pCalculatedAmount);
DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, pIsDisbursed);
DataColumnParameter paramHRComments = new DataColumnParameter(defHRComments, pHRComments);
DataColumnParameter paramApprovedAmount = new DataColumnParameter(defApprovedAmount, pApprovedAmount);
DataColumnParameter paramBursarComments = new DataColumnParameter(defBursarComments, pBursarComments);
DataColumnParameter paramDisbursedAmount = new DataColumnParameter(defDisbursedAmount, pDisbursedAmount);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramDisbursedAt = new DataColumnParameter(defDisbursedAt, pDisbursedAt);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramPayrollID.GetSQLQuotedValueForAdd(),
paramPersonnelID.GetSQLQuotedValueForAdd(),
paramAttendanceCount.GetSQLQuotedValueForAdd(),
paramSalaryAmount.GetSQLQuotedValueForAdd(),
paramRatePerDay.GetSQLQuotedValueForAdd(),
paramCalculatedAmount.GetSQLQuotedValueForAdd(),
paramIsDisbursed.GetSQLQuotedValueForAdd(),
paramHRComments.GetSQLQuotedValueForAdd(),
paramApprovedAmount.GetSQLQuotedValueForAdd(),
paramBursarComments.GetSQLQuotedValueForAdd(),
paramDisbursedAmount.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramDisbursedAt.GetSQLQuotedValueForAdd(),
paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pPayrollID,
Int32 pPersonnelID,
Int32 pAttendanceCount,
Decimal pSalaryAmount,
Decimal pRatePerDay,
Decimal pCalculatedAmount,
Boolean pIsDisbursed,
Decimal pApprovedAmount,
DateTime pCreatedAt,
Int32 pCreatedByID,
Object pHRComments= null,
Object pBursarComments= null,
Object pDisbursedAmount= null,
Object pUpdatedAt= null,
Object pDisbursedAt= null,
Object pUpdatedByID= null){

        try{

DataColumnParameter paramPayrollID = new DataColumnParameter(defPayrollID, pPayrollID);
DataColumnParameter paramPersonnelID = new DataColumnParameter(defPersonnelID, pPersonnelID);
DataColumnParameter paramAttendanceCount = new DataColumnParameter(defAttendanceCount, pAttendanceCount);
DataColumnParameter paramSalaryAmount = new DataColumnParameter(defSalaryAmount, pSalaryAmount);
DataColumnParameter paramRatePerDay = new DataColumnParameter(defRatePerDay, pRatePerDay);
DataColumnParameter paramCalculatedAmount = new DataColumnParameter(defCalculatedAmount, pCalculatedAmount);
DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, pIsDisbursed);
DataColumnParameter paramHRComments = new DataColumnParameter(defHRComments, pHRComments);
DataColumnParameter paramApprovedAmount = new DataColumnParameter(defApprovedAmount, pApprovedAmount);
DataColumnParameter paramBursarComments = new DataColumnParameter(defBursarComments, pBursarComments);
DataColumnParameter paramDisbursedAmount = new DataColumnParameter(defDisbursedAmount, pDisbursedAmount);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramDisbursedAt = new DataColumnParameter(defDisbursedAt, pDisbursedAt);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) ", TABLE_NAME,paramPayrollID.GetSQLQuotedValueForAdd(),
paramPersonnelID.GetSQLQuotedValueForAdd(),
paramAttendanceCount.GetSQLQuotedValueForAdd(),
paramSalaryAmount.GetSQLQuotedValueForAdd(),
paramRatePerDay.GetSQLQuotedValueForAdd(),
paramCalculatedAmount.GetSQLQuotedValueForAdd(),
paramIsDisbursed.GetSQLQuotedValueForAdd(),
paramHRComments.GetSQLQuotedValueForAdd(),
paramApprovedAmount.GetSQLQuotedValueForAdd(),
paramBursarComments.GetSQLQuotedValueForAdd(),
paramDisbursedAmount.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramDisbursedAt.GetSQLQuotedValueForAdd(),
paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);


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
Object pPayrollID = null,
Object pPersonnelID = null,
Object pAttendanceCount = null,
Object pSalaryAmount = null,
Object pRatePerDay = null,
Object pCalculatedAmount = null,
Object pIsDisbursed = null,
Object pApprovedAmount = null,
Object pCreatedAt = null,
Object pCreatedByID = null,
Object pHRComments = null,
Object pBursarComments = null,
Object pDisbursedAmount = null,
Object pUpdatedAt = null,
Object pDisbursedAt = null,
Object pUpdatedByID = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramPayrollID = new DataColumnParameter(defPayrollID, pPayrollID);
 DataColumnParameter paramPersonnelID = new DataColumnParameter(defPersonnelID, pPersonnelID);
 DataColumnParameter paramAttendanceCount = new DataColumnParameter(defAttendanceCount, pAttendanceCount);
 DataColumnParameter paramSalaryAmount = new DataColumnParameter(defSalaryAmount, pSalaryAmount);
 DataColumnParameter paramRatePerDay = new DataColumnParameter(defRatePerDay, pRatePerDay);
 DataColumnParameter paramCalculatedAmount = new DataColumnParameter(defCalculatedAmount, pCalculatedAmount);
 DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, pIsDisbursed);
 DataColumnParameter paramHRComments = new DataColumnParameter(defHRComments, pHRComments);
 DataColumnParameter paramApprovedAmount = new DataColumnParameter(defApprovedAmount, pApprovedAmount);
 DataColumnParameter paramBursarComments = new DataColumnParameter(defBursarComments, pBursarComments);
 DataColumnParameter paramDisbursedAmount = new DataColumnParameter(defDisbursedAmount, pDisbursedAmount);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramDisbursedAt = new DataColumnParameter(defDisbursedAt, pDisbursedAt);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [PayrollID]={2},[PersonnelID]={3},[AttendanceCount]={4},[SalaryAmount]={5},[RatePerDay]={6},[CalculatedAmount]={7},[IsDisbursed]={8},[HRComments]={9},[ApprovedAmount]={10},[BursarComments]={11},[DisbursedAmount]={12},[UpdatedAt]={13},[CreatedAt]={14},[CreatedByID]={15},[DisbursedAt]={16},[UpdatedByID]={17} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramPayrollID.GetSQLQuotedValueForUpdate(),
paramPersonnelID.GetSQLQuotedValueForUpdate(),
paramAttendanceCount.GetSQLQuotedValueForUpdate(),
paramSalaryAmount.GetSQLQuotedValueForUpdate(),
paramRatePerDay.GetSQLQuotedValueForUpdate(),
paramCalculatedAmount.GetSQLQuotedValueForUpdate(),
paramIsDisbursed.GetSQLQuotedValueForUpdate(),
paramHRComments.GetSQLQuotedValueForUpdate(),
paramApprovedAmount.GetSQLQuotedValueForUpdate(),
paramBursarComments.GetSQLQuotedValueForUpdate(),
paramDisbursedAmount.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedByID.GetSQLQuotedValueForUpdate(),
paramDisbursedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedByID.GetSQLQuotedValueForUpdate()  ), true);


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
