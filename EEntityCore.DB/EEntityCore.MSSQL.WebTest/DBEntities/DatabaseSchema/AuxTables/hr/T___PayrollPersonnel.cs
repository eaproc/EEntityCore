using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using ELibrary.Standard.VB.Modules;                  
using EEntityCore.DB.MSSQL.Schemas;                  
using EEntityCore.DB.MSSQL;                  
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
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPayrollID = new DataColumnDefinition(TableColumnNames.PayrollID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonnelID = new DataColumnDefinition(TableColumnNames.PersonnelID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defAttendanceCount = new DataColumnDefinition(TableColumnNames.AttendanceCount.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSalaryAmount = new DataColumnDefinition(TableColumnNames.SalaryAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerDay = new DataColumnDefinition(TableColumnNames.RatePerDay.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCalculatedAmount = new DataColumnDefinition(TableColumnNames.CalculatedAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsDisbursed = new DataColumnDefinition(TableColumnNames.IsDisbursed.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHRComments = new DataColumnDefinition(TableColumnNames.HRComments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defApprovedAmount = new DataColumnDefinition(TableColumnNames.ApprovedAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBursarComments = new DataColumnDefinition(TableColumnNames.BursarComments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDisbursedAmount = new DataColumnDefinition(TableColumnNames.DisbursedAmount.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDisbursedAt = new DataColumnDefinition(TableColumnNames.DisbursedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);


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
       public const string PayrollPersonnel__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PayrollID], [PersonnelID], [AttendanceCount], [SalaryAmount], [RatePerDay], [CalculatedAmount], [IsDisbursed], [HRComments], [ApprovedAmount], [BursarComments], [DisbursedAmount], [UpdatedAt], [CreatedAt], [CreatedByID], [DisbursedAt], [UpdatedByID] FROM hr.PayrollPersonnel";
       public const string PayrollPersonnel__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PayrollID], [PersonnelID], [AttendanceCount], [SalaryAmount], [RatePerDay], [CalculatedAmount], [IsDisbursed], [HRComments], [ApprovedAmount], [BursarComments], [DisbursedAmount], [UpdatedAt], [CreatedAt], [CreatedByID], [DisbursedAt], [UpdatedByID] FROM hr.PayrollPersonnel";


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

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public int PayrollID { get => (int)TargettedRow[TableColumnNames.PayrollID.ToString()]; }


       public int PersonnelID { get => (int)TargettedRow[TableColumnNames.PersonnelID.ToString()]; }


       public int AttendanceCount { get => (int)TargettedRow[TableColumnNames.AttendanceCount.ToString()]; }


       public decimal SalaryAmount { get => (decimal)TargettedRow[TableColumnNames.SalaryAmount.ToString()]; }


       public decimal RatePerDay { get => (decimal)TargettedRow[TableColumnNames.RatePerDay.ToString()]; }


       public decimal CalculatedAmount { get => (decimal)TargettedRow[TableColumnNames.CalculatedAmount.ToString()]; }


       public bool IsDisbursed { get => (bool)TargettedRow[TableColumnNames.IsDisbursed.ToString()]; }


       public string HRComments { get => (string)TargettedRow[TableColumnNames.HRComments.ToString()]; }


       public decimal ApprovedAmount { get => (decimal)TargettedRow[TableColumnNames.ApprovedAmount.ToString()]; }


       public string BursarComments { get => (string)TargettedRow[TableColumnNames.BursarComments.ToString()]; }


       public decimal? DisbursedAmount { get => (decimal?)TargettedRow[TableColumnNames.DisbursedAmount.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public DateTime? DisbursedAt { get => (DateTime?)TargettedRow[TableColumnNames.DisbursedAt.ToString()]; }


       public int? UpdatedByID { get => (int?)TargettedRow[TableColumnNames.UpdatedByID.ToString()]; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PayrollPersonnel GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PayrollPersonnel GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___PayrollPersonnel(conn.Fetch(PayrollPersonnel__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable(), DO__NOT____TARGET__ANY_ROWID),                  
                transaction                  
                );                                                      
                                                      
        public static T___PayrollPersonnel GetRowWhereIDUsingSQL(int pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___PayrollPersonnel( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___PayrollPersonnel GetRowWhereID(int pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PayrollPersonnel__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int PayrollID,
            int PersonnelID,
            int AttendanceCount,
            decimal SalaryAmount,
            decimal RatePerDay,
            decimal CalculatedAmount,
            bool IsDisbursed,
            decimal ApprovedAmount,
            DateTime CreatedAt,
            int CreatedByID,
            string HRComments = null,
            string BursarComments = null,
            decimal? DisbursedAmount = null,
            DateTime? UpdatedAt = null,
            DateTime? DisbursedAt = null,
            int? UpdatedByID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramPayrollID = new (defPayrollID, PayrollID);
                DataColumnParameter paramPersonnelID = new (defPersonnelID, PersonnelID);
                DataColumnParameter paramAttendanceCount = new (defAttendanceCount, AttendanceCount);
                DataColumnParameter paramSalaryAmount = new (defSalaryAmount, SalaryAmount);
                DataColumnParameter paramRatePerDay = new (defRatePerDay, RatePerDay);
                DataColumnParameter paramCalculatedAmount = new (defCalculatedAmount, CalculatedAmount);
                DataColumnParameter paramIsDisbursed = new (defIsDisbursed, IsDisbursed);
                DataColumnParameter paramHRComments = new (defHRComments, HRComments);
                DataColumnParameter paramApprovedAmount = new (defApprovedAmount, ApprovedAmount);
                DataColumnParameter paramBursarComments = new (defBursarComments, BursarComments);
                DataColumnParameter paramDisbursedAmount = new (defDisbursedAmount, DisbursedAmount);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramDisbursedAt = new (defDisbursedAt, DisbursedAt);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
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
                        paramUpdatedByID.GetSQLQuotedValueForAdd()                        )
                    );
                         
                return conn.GetScopeIdentity().ToLong();
            });

        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool AddWithID(
            int ID,
            int PayrollID,
            int PersonnelID,
            int AttendanceCount,
            decimal SalaryAmount,
            decimal RatePerDay,
            decimal CalculatedAmount,
            bool IsDisbursed,
            decimal ApprovedAmount,
            DateTime CreatedAt,
            int CreatedByID,
            string HRComments = null,
            string BursarComments = null,
            decimal? DisbursedAmount = null,
            DateTime? UpdatedAt = null,
            DateTime? DisbursedAt = null,
            int? UpdatedByID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPayrollID = new (defPayrollID, PayrollID);
                DataColumnParameter paramPersonnelID = new (defPersonnelID, PersonnelID);
                DataColumnParameter paramAttendanceCount = new (defAttendanceCount, AttendanceCount);
                DataColumnParameter paramSalaryAmount = new (defSalaryAmount, SalaryAmount);
                DataColumnParameter paramRatePerDay = new (defRatePerDay, RatePerDay);
                DataColumnParameter paramCalculatedAmount = new (defCalculatedAmount, CalculatedAmount);
                DataColumnParameter paramIsDisbursed = new (defIsDisbursed, IsDisbursed);
                DataColumnParameter paramHRComments = new (defHRComments, HRComments);
                DataColumnParameter paramApprovedAmount = new (defApprovedAmount, ApprovedAmount);
                DataColumnParameter paramBursarComments = new (defBursarComments, BursarComments);
                DataColumnParameter paramDisbursedAmount = new (defDisbursedAmount, DisbursedAmount);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramDisbursedAt = new (defDisbursedAt, DisbursedAt);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
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
                        paramUpdatedByID.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        /// <summary>                  
        /// Deletes with an option to pass in transaction                  
        /// </summary>                  
        /// <returns></returns>                  
        /// <remarks></remarks>                  
        public bool DeleteRow(DBTransaction transaction = null)                  
        {                  
            return DeleteItemRow(ID, transaction);                  
        }                  
                  
        public static bool DeleteItemRow(long pID, DBTransaction transaction = null)                                                      
        {                  
            return TransactionRunner.InvokeRun(                  
               (conn) => conn.ExecuteTransactionQuery($"DELETE FROM {TABLE_NAME} WHERE ID={pID} ").ToBoolean(),                  
               transaction                  
               );                  
        }                  



   }


}
