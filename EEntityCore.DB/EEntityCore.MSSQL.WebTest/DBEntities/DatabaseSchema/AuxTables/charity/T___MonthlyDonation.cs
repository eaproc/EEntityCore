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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___MonthlyDonation : Sample__Table, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___MonthlyDonation()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterID = new DataColumnDefinition(TableColumnNames.CenterID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defResidingPastorID = new DataColumnDefinition(TableColumnNames.ResidingPastorID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDonationYear = new DataColumnDefinition(TableColumnNames.DonationYear.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDonationMonth = new DataColumnDefinition(TableColumnNames.DonationMonth.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsApproved = new DataColumnDefinition(TableColumnNames.IsApproved.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsDisbursed = new DataColumnDefinition(TableColumnNames.IsDisbursed.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCenterID.ColumnName, defCenterID); 
          ColumnDefns.Add(defResidingPastorID.ColumnName, defResidingPastorID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defDonationYear.ColumnName, defDonationYear); 
          ColumnDefns.Add(defDonationMonth.ColumnName, defDonationMonth); 
          ColumnDefns.Add(defIsApproved.ColumnName, defIsApproved); 
          ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_CenterID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.MonthlyDonation", "charity.Center"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_ResidingPastorID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "charity.ResidingPastor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "common.Bank"                  
                            ));                  

          }


                  
        public T___MonthlyDonation() : base(TABLE_NAME)                  
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
        public T___MonthlyDonation(All__DBs DBConn, string TableName) : base(DBConn, TableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                    
        /// <remarks></remarks>                  
        public T___MonthlyDonation(All__DBs DBConn, string pTableName, long pTargettedRowID) : base(DBConn, pTableName, pTargettedRowID: pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public T___MonthlyDonation(All__DBs pDBConn, string pTableName, string pSQL) : base(pDBConn, pTableName, pSQL)                  
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
        public T___MonthlyDonation(All__DBs pDBConn, string pTableName, string pSQL, long pTargettedRowID) : base(pDBConn, pTableName, pSQL, pTargettedRowID)                  
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
        public T___MonthlyDonation(DataRowCollection pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public T___MonthlyDonation(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="FullTable"></param>                                    
        /// <param name="TargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public T___MonthlyDonation(DataTable FullTable, int TargettedRowID, string TableName, All__DBs DBConn) : base(FullTable, TargettedRowID, TableName, DBConn)                  
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
        public T___MonthlyDonation(DataRow TargettedRow) : base(TargettedRow)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public T___MonthlyDonation(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public T___MonthlyDonation(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public T___MonthlyDonation(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName) : base(pTableRows, pTargettedRowID, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public T___MonthlyDonation(DataTable FullTable, string pTableName) : base(FullTable, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public T___MonthlyDonation(DataTable FullTable, string pTableName, long pTargettedRowID) : base(FullTable, pTableName, pTargettedRowID)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public T___MonthlyDonation(DataRowCollection pDataRows, string pTableName) : base(pDataRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public T___MonthlyDonation(IEnumerable<DataRow> pTableRows, string pTableName) : base(pTableRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access. Should always target this passed in                                    
        /// </summary>                                    
        /// <param name="pTargettedRow"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public T___MonthlyDonation(DataRow pTargettedRow, string pTableName) : base(pTargettedRow, pTableName)                  
        {                  
        }                  
                  
                  
        #endregion                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
#endregion                  
                  
                  
                  
#region Consts and Enums                  

       public const string TABLE_NAME = "charity.MonthlyDonation";
       public const string MonthlyDonation__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [ResidingPastorID], [BankID], [AccountNumber], [DonationYear], [DonationMonth], [IsApproved], [IsDisbursed], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM MonthlyDonation";
       public const string MonthlyDonation__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [ResidingPastorID], [BankID], [AccountNumber], [DonationYear], [DonationMonth], [IsApproved], [IsDisbursed], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM MonthlyDonation";


       public enum TableColumnNames
       {

           ID,
           CenterID,
           ResidingPastorID,
           BankID,
           AccountNumber,
           DonationYear,
           DonationMonth,
           IsApproved,
           IsDisbursed,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_MonthlyDonation, 
           fk_charity_MonthlyDonation_UpdatedByID, 
           fk_charity_MonthlyDonation_CenterID, 
           fk_charity_MonthlyDonation_ResidingPastorID, 
           fk_charity_MonthlyDonation_CreatedByID, 
           fk_charity_MonthlyDonation_BankID, 
       } 


 #endregion 


 #region Properties 

        private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCenterID;
       public static readonly DataColumnDefinition defResidingPastorID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defDonationYear;
       public static readonly DataColumnDefinition defDonationMonth;
       public static readonly DataColumnDefinition defIsApproved;
       public static readonly DataColumnDefinition defIsDisbursed;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

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


       public String AccountNumber {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountNumber.ToString()]);
           }
       }


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
        public T___MonthlyDonation getFirstRow()                  
        {                  
            if (this.hasRows())                  
                return new T___MonthlyDonation(this.AllRows.ToArray()[0]);                  
            return null;                  
        }                  
                  
        public static T___MonthlyDonation getFullTable()                  
        {                  
            return new T___MonthlyDonation(DatabaseInit.DBConnectInterface.GetDBConn(), TABLE_NAME);                  
        }                  
                  
        public static T___MonthlyDonation getRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___MonthlyDonation(DBConnectInterface.GetDBConn(), TABLE_NAME, string.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, (object)pID)).getFirstRow();                  
        }                  
                  
        public T___MonthlyDonation getRowWhereID(int pID)                  
        {                  
            return new T___MonthlyDonation(this.RawTable, TABLE_NAME, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___MonthlyDonation pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___MonthlyDonation pRow, params DataColumnParameter[] pParams)                  
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
        public T___MonthlyDonation getAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___MonthlyDonation(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___MonthlyDonation(drst.CopyToDataTable(), TABLE_NAME);                  
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
        public T___MonthlyDonation getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___MonthlyDonation(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___MonthlyDonation(drst.CopyToDataTable(), TABLE_NAME);                  
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

                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> getForeignKeys()                  
        {                  
            return ForeignKeys;                  
        }                  
                  
        public string getTableName()                  
        {                  
            return TABLE_NAME;                  
        }                  

                  
        public virtual string getFillSQL(){                
            return MonthlyDonation__NO__BINARY___SQL_FILL_QUERY;                  
        }                  
                  
                  
                  
#endregion                  
                  
                  




        public static int addNewDefault(Int32 pCenterID,
Int32 pResidingPastorID,
Int32 pBankID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
                DataColumnParameter paramResidingPastorID = new DataColumnParameter(defResidingPastorID, pResidingPastorID);
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue);
                DataColumnParameter paramDonationYear = new DataColumnParameter(defDonationYear, defDonationYear.DefaultValue);
                DataColumnParameter paramDonationMonth = new DataColumnParameter(defDonationMonth, defDonationMonth.DefaultValue);
                DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, defIsApproved.DefaultValue);
                DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, defIsDisbursed.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramCenterID.getSQLQuotedValueForAdd(),
                paramResidingPastorID.getSQLQuotedValueForAdd(),
                paramBankID.getSQLQuotedValueForAdd(),
                paramAccountNumber.getSQLQuotedValueForAdd(),
                paramDonationYear.getSQLQuotedValueForAdd(),
                paramDonationMonth.getSQLQuotedValueForAdd(),
                paramIsApproved.getSQLQuotedValueForAdd(),
                paramIsDisbursed.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd(),
                paramUpdatedByID.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   




        public static bool DeleteItemRow(long pID)                  
        {                  
            try                  
            {                  
                return DBConnectInterface.GetDBConn().DbExec(string.Format("DELETE FROM {0} WHERE ID={1} ", TABLE_NAME, pID));                  
            }                  
            catch (Exception)                  
            {                  
                throw;                  
            }                  
        }                  


   }


}
