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

    public class T___Personnel : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Personnel()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPersonnelNumber = new DataColumnDefinition(TableColumnNames.PersonnelNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmploymentDate = new DataColumnDefinition(TableColumnNames.EmploymentDate.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsSuperUser = new DataColumnDefinition(TableColumnNames.IsSuperUser.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPositionID = new DataColumnDefinition(TableColumnNames.PositionID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSalaryTypeID = new DataColumnDefinition(TableColumnNames.SalaryTypeID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSalaryAmount = new DataColumnDefinition(TableColumnNames.SalaryAmount.ToString(), typeof(decimal?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDuties = new DataColumnDefinition(TableColumnNames.Duties.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsWebVisible = new DataColumnDefinition(TableColumnNames.IsWebVisible.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPersonnelNumber.ColumnName, defPersonnelNumber); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defEmploymentDate.ColumnName, defEmploymentDate); 
          ColumnDefns.Add(defIsSuperUser.ColumnName, defIsSuperUser); 
          ColumnDefns.Add(defPositionID.ColumnName, defPositionID); 
          ColumnDefns.Add(defSalaryTypeID.ColumnName, defSalaryTypeID); 
          ColumnDefns.Add(defSalaryAmount.ColumnName, defSalaryAmount); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defDuties.ColumnName, defDuties); 
          ColumnDefns.Add(defIsWebVisible.ColumnName, defIsWebVisible); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_PersonID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "common.Person"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_PositionID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "hr.Position"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_SalaryTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "hr.SalaryType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "auth.Users"                  
                            ));                  

          }


                  
       public T___Personnel() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Personnel(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Personnel(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Personnel(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.Personnel";
       public const string Personnel__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PersonnelNumber], [PersonID], [IsActive], [EmploymentDate], [IsSuperUser], [PositionID], [SalaryTypeID], [SalaryAmount], [CreatedByID], [UpdatedByID], [CreatedAt], [UpdatedAt], [Duties], [IsWebVisible] FROM Personnel";
       public const string Personnel__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PersonnelNumber], [PersonID], [IsActive], [EmploymentDate], [IsSuperUser], [PositionID], [SalaryTypeID], [SalaryAmount], [CreatedByID], [UpdatedByID], [CreatedAt], [UpdatedAt], [Duties], [IsWebVisible] FROM Personnel";


       public enum TableColumnNames
       {

           ID,
           PersonnelNumber,
           PersonID,
           IsActive,
           EmploymentDate,
           IsSuperUser,
           PositionID,
           SalaryTypeID,
           SalaryAmount,
           CreatedByID,
           UpdatedByID,
           CreatedAt,
           UpdatedAt,
           Duties,
           IsWebVisible
       } 



       public enum TableConstraints{

           pk_hr_Personnel, 
           fk_hr_Personnel_PersonID, 
           fk_hr_Personnel_PositionID, 
           fk_hr_Personnel_SalaryTypeID, 
           fk_hr_Personnel_CreatedByID, 
           fk_hr_Personnel_UpdatedByID, 
           uq_hr_Personnel_PersonnelNumber, 
           uq_hr_Personnel_PersonID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPersonnelNumber;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defEmploymentDate;
       public static readonly DataColumnDefinition defIsSuperUser;
       public static readonly DataColumnDefinition defPositionID;
       public static readonly DataColumnDefinition defSalaryTypeID;
       public static readonly DataColumnDefinition defSalaryAmount;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defDuties;
       public static readonly DataColumnDefinition defIsWebVisible;

       public string PersonnelNumber { get => (string)TargettedRow[TableColumnNames.PersonnelNumber.ToString()]; }


       public int PersonID { get => (int)TargettedRow[TableColumnNames.PersonID.ToString()]; }


       public bool IsActive { get => (bool)TargettedRow[TableColumnNames.IsActive.ToString()]; }


       public DateTime EmploymentDate { get => (DateTime)TargettedRow[TableColumnNames.EmploymentDate.ToString()]; }


       public bool IsSuperUser { get => (bool)TargettedRow[TableColumnNames.IsSuperUser.ToString()]; }


       public int PositionID { get => (int)TargettedRow[TableColumnNames.PositionID.ToString()]; }


       public int? SalaryTypeID { get => (int?)TargettedRow[TableColumnNames.SalaryTypeID.ToString()]; }


       public decimal? SalaryAmount { get => (decimal?)TargettedRow[TableColumnNames.SalaryAmount.ToString()]; }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public int? UpdatedByID { get => (int?)TargettedRow[TableColumnNames.UpdatedByID.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


       public string Duties { get => (string)TargettedRow[TableColumnNames.Duties.ToString()]; }


       public bool? IsWebVisible { get => (bool?)TargettedRow[TableColumnNames.IsWebVisible.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Personnel GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Personnel GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Personnel GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Personnel(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Personnel GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Personnel__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            string PersonnelNumber,
            int PersonID,
            bool IsActive,
            DateTime EmploymentDate,
            bool IsSuperUser,
            int PositionID,
            int CreatedByID,
            DateTime CreatedAt,
            int? SalaryTypeID = null,
            decimal? SalaryAmount = null,
            int? UpdatedByID = null,
            DateTime? UpdatedAt = null,
            string Duties = null,
            bool? IsWebVisible = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramPersonnelNumber = new (defPersonnelNumber, PersonnelNumber);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramEmploymentDate = new (defEmploymentDate, EmploymentDate);
                DataColumnParameter paramIsSuperUser = new (defIsSuperUser, IsSuperUser);
                DataColumnParameter paramPositionID = new (defPositionID, PositionID);
                DataColumnParameter paramSalaryTypeID = new (defSalaryTypeID, SalaryTypeID);
                DataColumnParameter paramSalaryAmount = new (defSalaryAmount, SalaryAmount);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramDuties = new (defDuties, Duties);
                DataColumnParameter paramIsWebVisible = new (defIsWebVisible, IsWebVisible);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PersonnelNumber],[PersonID],[IsActive],[EmploymentDate],[IsSuperUser],[PositionID],[SalaryTypeID],[SalaryAmount],[CreatedByID],[UpdatedByID],[CreatedAt],[UpdatedAt],[Duties],[IsWebVisible]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})  ", TABLE_NAME,
                        paramPersonnelNumber.GetSQLQuotedValueForAdd(),
                        paramPersonID.GetSQLQuotedValueForAdd(),
                        paramIsActive.GetSQLQuotedValueForAdd(),
                        paramEmploymentDate.GetSQLQuotedValueForAdd(),
                        paramIsSuperUser.GetSQLQuotedValueForAdd(),
                        paramPositionID.GetSQLQuotedValueForAdd(),
                        paramSalaryTypeID.GetSQLQuotedValueForAdd(),
                        paramSalaryAmount.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramDuties.GetSQLQuotedValueForAdd(),
                        paramIsWebVisible.GetSQLQuotedValueForAdd()                        )
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
            string PersonnelNumber,
            int PersonID,
            bool IsActive,
            DateTime EmploymentDate,
            bool IsSuperUser,
            int PositionID,
            int CreatedByID,
            DateTime CreatedAt,
            int? SalaryTypeID = null,
            decimal? SalaryAmount = null,
            int? UpdatedByID = null,
            DateTime? UpdatedAt = null,
            string Duties = null,
            bool? IsWebVisible = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPersonnelNumber = new (defPersonnelNumber, PersonnelNumber);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);
                DataColumnParameter paramEmploymentDate = new (defEmploymentDate, EmploymentDate);
                DataColumnParameter paramIsSuperUser = new (defIsSuperUser, IsSuperUser);
                DataColumnParameter paramPositionID = new (defPositionID, PositionID);
                DataColumnParameter paramSalaryTypeID = new (defSalaryTypeID, SalaryTypeID);
                DataColumnParameter paramSalaryAmount = new (defSalaryAmount, SalaryAmount);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramDuties = new (defDuties, Duties);
                DataColumnParameter paramIsWebVisible = new (defIsWebVisible, IsWebVisible);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonnelNumber],[PersonID],[IsActive],[EmploymentDate],[IsSuperUser],[PositionID],[SalaryTypeID],[SalaryAmount],[CreatedByID],[UpdatedByID],[CreatedAt],[UpdatedAt],[Duties],[IsWebVisible]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramPersonnelNumber.GetSQLQuotedValueForAdd(),
                        paramPersonID.GetSQLQuotedValueForAdd(),
                        paramIsActive.GetSQLQuotedValueForAdd(),
                        paramEmploymentDate.GetSQLQuotedValueForAdd(),
                        paramIsSuperUser.GetSQLQuotedValueForAdd(),
                        paramPositionID.GetSQLQuotedValueForAdd(),
                        paramSalaryTypeID.GetSQLQuotedValueForAdd(),
                        paramSalaryAmount.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramDuties.GetSQLQuotedValueForAdd(),
                        paramIsWebVisible.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
