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

    public class T___Personnel : Sample__Table, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___Personnel()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPersonnelNumber = new DataColumnDefinition(TableColumnNames.PersonnelNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmploymentDate = new DataColumnDefinition(TableColumnNames.EmploymentDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsSuperUser = new DataColumnDefinition(TableColumnNames.IsSuperUser.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPositionID = new DataColumnDefinition(TableColumnNames.PositionID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSalaryTypeID = new DataColumnDefinition(TableColumnNames.SalaryTypeID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defSalaryAmount = new DataColumnDefinition(TableColumnNames.SalaryAmount.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDuties = new DataColumnDefinition(TableColumnNames.Duties.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsWebVisible = new DataColumnDefinition(TableColumnNames.IsWebVisible.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public String PersonnelNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PersonnelNumber.ToString()]);
           }
       }


       public Int32 PersonID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonID.ToString()]);
           }
       }


       public Boolean IsActive {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsActive.ToString()]);
           }
       }


       public NullableDateTime EmploymentDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.EmploymentDate.ToString()]);
           }
       }


       public Boolean IsSuperUser {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsSuperUser.ToString()]);
           }
       }


       public Int32 PositionID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PositionID.ToString()]);
           }
       }


       public Int32 SalaryTypeID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.SalaryTypeID.ToString()]);
           }
       }


       public Decimal SalaryAmount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.SalaryAmount.ToString()]);
           }
       }


       public Int32 CreatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


       public Int32 UpdatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UpdatedByID.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public NullableDateTime UpdatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]);
           }
       }


       public String Duties {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Duties.ToString()]);
           }
       }


       public Boolean IsWebVisible {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsWebVisible.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___Personnel GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___Personnel(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___Personnel GetFullTable()                  
        {                  
            return new T___Personnel(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___Personnel GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___Personnel(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___Personnel GetRowWhereID(int pID)                  
        {                  
            return new T___Personnel(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___Personnel pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___Personnel pRow, params DataColumnParameter[] pParams)                  
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
        public T___Personnel GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___Personnel(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Personnel(drst);                  
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
        public T___Personnel getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___Personnel(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Personnel(drst);                  
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

                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> getForeignKeys()                  
        {                  
            return ForeignKeys;                  
        }                  
                  
        public string getTableName()                  
        {                  
            return TABLE_NAME;                  
        }                  

                  
        public virtual string getFillSQL(){                
            return Personnel__NO__BINARY___SQL_FILL_QUERY;                  
        }                  
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(String pPersonnelNumber,
Int32 pPersonID,
Int32 pPositionID,
Int32 pSalaryTypeID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPersonnelNumber = new DataColumnParameter(defPersonnelNumber, pPersonnelNumber);
                DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
                DataColumnParameter paramPositionID = new DataColumnParameter(defPositionID, pPositionID);
                DataColumnParameter paramSalaryTypeID = new DataColumnParameter(defSalaryTypeID, pSalaryTypeID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, defIsActive.DefaultValue);
                DataColumnParameter paramEmploymentDate = new DataColumnParameter(defEmploymentDate, defEmploymentDate.DefaultValue);
                DataColumnParameter paramIsSuperUser = new DataColumnParameter(defIsSuperUser, defIsSuperUser.DefaultValue);
                DataColumnParameter paramSalaryAmount = new DataColumnParameter(defSalaryAmount, defSalaryAmount.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramDuties = new DataColumnParameter(defDuties, defDuties.DefaultValue);
                DataColumnParameter paramIsWebVisible = new DataColumnParameter(defIsWebVisible, defIsWebVisible.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonnelNumber],[PersonID],[IsActive],[EmploymentDate],[IsSuperUser],[PositionID],[SalaryTypeID],[SalaryAmount],[CreatedByID],[UpdatedByID],[CreatedAt],[UpdatedAt],[Duties],[IsWebVisible]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramPersonnelNumber.getSQLQuotedValueForAdd(),
                paramPersonID.getSQLQuotedValueForAdd(),
                paramIsActive.getSQLQuotedValueForAdd(),
                paramEmploymentDate.getSQLQuotedValueForAdd(),
                paramIsSuperUser.getSQLQuotedValueForAdd(),
                paramPositionID.getSQLQuotedValueForAdd(),
                paramSalaryTypeID.getSQLQuotedValueForAdd(),
                paramSalaryAmount.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd(),
                paramUpdatedByID.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd(),
                paramDuties.getSQLQuotedValueForAdd(),
                paramIsWebVisible.getSQLQuotedValueForAdd()  ), true);




                  
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
