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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___ResidingPastor : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___ResidingPastor()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterID = new DataColumnDefinition(TableColumnNames.CenterID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defActivatedOn = new DataColumnDefinition(TableColumnNames.ActivatedOn.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDeactivatedOn = new DataColumnDefinition(TableColumnNames.DeactivatedOn.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIdPictureStoredPath = new DataColumnDefinition(TableColumnNames.IdPictureStoredPath.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCenterID.ColumnName, defCenterID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defActivatedOn.ColumnName, defActivatedOn); 
          ColumnDefns.Add(defDeactivatedOn.ColumnName, defDeactivatedOn); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
          ColumnDefns.Add(defIdPictureStoredPath.ColumnName, defIdPictureStoredPath); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ResidingPastor_CenterID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.ResidingPastor", "charity.Center"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ResidingPastor_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ResidingPastor", "common.Bank"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ResidingPastor_PersonID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ResidingPastor", "common.Person"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ResidingPastor_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ResidingPastor", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_ResidingPastor_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.ResidingPastor", "auth.Users"                  
                            ));                  

          }


                  
       public T___ResidingPastor() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ResidingPastor(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ResidingPastor(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___ResidingPastor(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "charity.ResidingPastor";
       public const string ResidingPastor__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [BankID], [AccountNumber], [PersonID], [ActivatedOn], [DeactivatedOn], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID], [IdPictureStoredPath] FROM ResidingPastor";
       public const string ResidingPastor__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [BankID], [AccountNumber], [PersonID], [ActivatedOn], [DeactivatedOn], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID], [IdPictureStoredPath] FROM ResidingPastor";


       public enum TableColumnNames
       {

           ID,
           CenterID,
           BankID,
           AccountNumber,
           PersonID,
           ActivatedOn,
           DeactivatedOn,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID,
           IdPictureStoredPath
       } 



       public enum TableConstraints{

           pk_charity_ResidingPastor, 
           fk_charity_ResidingPastor_CenterID, 
           fk_charity_ResidingPastor_BankID, 
           fk_charity_ResidingPastor_PersonID, 
           fk_charity_ResidingPastor_CreatedByID, 
           fk_charity_ResidingPastor_UpdatedByID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCenterID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defActivatedOn;
       public static readonly DataColumnDefinition defDeactivatedOn;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;
       public static readonly DataColumnDefinition defIdPictureStoredPath;

       public Int32 CenterID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CenterID.ToString()]);
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


       public Int32 PersonID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonID.ToString()]);
           }
       }


       public NullableDateTime ActivatedOn {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.ActivatedOn.ToString()]);
           }
       }


       public NullableDateTime DeactivatedOn {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.DeactivatedOn.ToString()]);
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


       public String IdPictureStoredPath {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IdPictureStoredPath.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___ResidingPastor GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___ResidingPastor(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___ResidingPastor GetFullTable()                  
        {                  
            return new T___ResidingPastor(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___ResidingPastor GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___ResidingPastor(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___ResidingPastor GetRowWhereID(int pID)                  
        {                  
            return new T___ResidingPastor(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___ResidingPastor pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___ResidingPastor pRow, params DataColumnParameter[] pParams)                  
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
        public T___ResidingPastor GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___ResidingPastor(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___ResidingPastor(drst);                  
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
        public T___ResidingPastor getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___ResidingPastor(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___ResidingPastor(drst);                  
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

                  
        public virtual string GetFillSQL() => ResidingPastor__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCenterID,
Int32 pBankID,
Int32 pPersonID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue);
                DataColumnParameter paramActivatedOn = new DataColumnParameter(defActivatedOn, defActivatedOn.DefaultValue);
                DataColumnParameter paramDeactivatedOn = new DataColumnParameter(defDeactivatedOn, defDeactivatedOn.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramIdPictureStoredPath = new DataColumnParameter(defIdPictureStoredPath, defIdPictureStoredPath.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BankID],[AccountNumber],[PersonID],[ActivatedOn],[DeactivatedOn],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[IdPictureStoredPath]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramCenterID.getSQLQuotedValueForAdd(),
                paramBankID.getSQLQuotedValueForAdd(),
                paramAccountNumber.getSQLQuotedValueForAdd(),
                paramPersonID.getSQLQuotedValueForAdd(),
                paramActivatedOn.getSQLQuotedValueForAdd(),
                paramDeactivatedOn.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd(),
                paramUpdatedByID.getSQLQuotedValueForAdd(),
                paramIdPictureStoredPath.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pCenterID,
Int32 pBankID,
String pAccountNumber,
Int32 pPersonID,
DateTime pActivatedOn,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pDeactivatedOn = null,
Object pIdPictureStoredPath = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
                DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
                DataColumnParameter paramActivatedOn = new DataColumnParameter(defActivatedOn, pActivatedOn);
                DataColumnParameter paramDeactivatedOn = new DataColumnParameter(defDeactivatedOn, pDeactivatedOn);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramIdPictureStoredPath = new DataColumnParameter(defIdPictureStoredPath, pIdPictureStoredPath);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BankID],[AccountNumber],[PersonID],[ActivatedOn],[DeactivatedOn],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[IdPictureStoredPath]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterID.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramPersonID.getSQLQuotedValueForAdd(),
paramActivatedOn.getSQLQuotedValueForAdd(),
paramDeactivatedOn.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramIdPictureStoredPath.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pCenterID,
Int32 pBankID,
String pAccountNumber,
Int32 pPersonID,
DateTime pActivatedOn,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pDeactivatedOn = null,
Object pIdPictureStoredPath = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
DataColumnParameter paramActivatedOn = new DataColumnParameter(defActivatedOn, pActivatedOn);
DataColumnParameter paramDeactivatedOn = new DataColumnParameter(defDeactivatedOn, pDeactivatedOn);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
DataColumnParameter paramIdPictureStoredPath = new DataColumnParameter(defIdPictureStoredPath, pIdPictureStoredPath);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BankID],[AccountNumber],[PersonID],[ActivatedOn],[DeactivatedOn],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[IdPictureStoredPath]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterID.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramPersonID.getSQLQuotedValueForAdd(),
paramActivatedOn.getSQLQuotedValueForAdd(),
paramDeactivatedOn.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramIdPictureStoredPath.getSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pCenterID,
Int32 pBankID,
String pAccountNumber,
Int32 pPersonID,
DateTime pActivatedOn,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pDeactivatedOn= null,
Object pIdPictureStoredPath= null){

        try{

DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
DataColumnParameter paramActivatedOn = new DataColumnParameter(defActivatedOn, pActivatedOn);
DataColumnParameter paramDeactivatedOn = new DataColumnParameter(defDeactivatedOn, pDeactivatedOn);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
DataColumnParameter paramIdPictureStoredPath = new DataColumnParameter(defIdPictureStoredPath, pIdPictureStoredPath);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([CenterID],[BankID],[AccountNumber],[PersonID],[ActivatedOn],[DeactivatedOn],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[IdPictureStoredPath]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) ", TABLE_NAME,paramCenterID.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramPersonID.getSQLQuotedValueForAdd(),
paramActivatedOn.getSQLQuotedValueForAdd(),
paramDeactivatedOn.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramIdPictureStoredPath.getSQLQuotedValueForAdd()  ), true);


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
Object pCenterID = null,
Object pBankID = null,
Object pAccountNumber = null,
Object pPersonID = null,
Object pActivatedOn = null,
Object pCreatedAt = null,
Object pUpdatedAt = null,
Object pCreatedByID = null,
Object pUpdatedByID = null,
Object pDeactivatedOn = null,
Object pIdPictureStoredPath = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
 DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
 DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
 DataColumnParameter paramPersonID = new DataColumnParameter(defPersonID, pPersonID);
 DataColumnParameter paramActivatedOn = new DataColumnParameter(defActivatedOn, pActivatedOn);
 DataColumnParameter paramDeactivatedOn = new DataColumnParameter(defDeactivatedOn, pDeactivatedOn);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
 DataColumnParameter paramIdPictureStoredPath = new DataColumnParameter(defIdPictureStoredPath, pIdPictureStoredPath);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [CenterID]={2},[BankID]={3},[AccountNumber]={4},[PersonID]={5},[ActivatedOn]={6},[DeactivatedOn]={7},[CreatedAt]={8},[UpdatedAt]={9},[CreatedByID]={10},[UpdatedByID]={11},[IdPictureStoredPath]={12} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramCenterID.getSQLQuotedValueForUpdate(),
paramBankID.getSQLQuotedValueForUpdate(),
paramAccountNumber.getSQLQuotedValueForUpdate(),
paramPersonID.getSQLQuotedValueForUpdate(),
paramActivatedOn.getSQLQuotedValueForUpdate(),
paramDeactivatedOn.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramUpdatedByID.getSQLQuotedValueForUpdate(),
paramIdPictureStoredPath.getSQLQuotedValueForUpdate()  ), true);


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
