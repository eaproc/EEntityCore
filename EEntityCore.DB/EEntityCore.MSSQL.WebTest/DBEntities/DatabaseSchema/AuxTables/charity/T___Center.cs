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

    public class T___Center : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___Center()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defName = new DataColumnDefinition(TableColumnNames.Name.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(TableColumnNames.Address.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiariesAvailableOnRegistration = new DataColumnDefinition(TableColumnNames.BeneficiariesAvailableOnRegistration.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterStatusID = new DataColumnDefinition(TableColumnNames.CenterStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defYearFounded = new DataColumnDefinition(TableColumnNames.YearFounded.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChurchCapacity = new DataColumnDefinition(TableColumnNames.ChurchCapacity.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(TableColumnNames.Comments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureStoredPath = new DataColumnDefinition(TableColumnNames.PictureStoredPath.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defBeneficiariesAvailableOnRegistration.ColumnName, defBeneficiariesAvailableOnRegistration); 
          ColumnDefns.Add(defCenterStatusID.ColumnName, defCenterStatusID); 
          ColumnDefns.Add(defYearFounded.ColumnName, defYearFounded); 
          ColumnDefns.Add(defChurchCapacity.ColumnName, defChurchCapacity); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defPictureStoredPath.ColumnName, defPictureStoredPath); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Center_CenterStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Center", "charity.CenterStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Center_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Center", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Center_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Center", "auth.Users"                  
                            ));                  

          }


                  
       public T___Center() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Center(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Center(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "charity.Center";
       public const string Center__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Name], [Address], [BeneficiariesAvailableOnRegistration], [CenterStatusID], [YearFounded], [ChurchCapacity], [Comments], [PictureStoredPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM Center";
       public const string Center__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Name], [Address], [BeneficiariesAvailableOnRegistration], [CenterStatusID], [YearFounded], [ChurchCapacity], [Comments], [PictureStoredPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM Center";


       public enum TableColumnNames
       {

           ID,
           Name,
           Address,
           BeneficiariesAvailableOnRegistration,
           CenterStatusID,
           YearFounded,
           ChurchCapacity,
           Comments,
           PictureStoredPath,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_Center, 
           fk_charity_Center_CenterStatusID, 
           fk_charity_Center_CreatedByID, 
           fk_charity_Center_UpdatedByID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defBeneficiariesAvailableOnRegistration;
       public static readonly DataColumnDefinition defCenterStatusID;
       public static readonly DataColumnDefinition defYearFounded;
       public static readonly DataColumnDefinition defChurchCapacity;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defPictureStoredPath;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public String Name {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Name.ToString()]);
           }
       }


       public String Address {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Address.ToString()]);
           }
       }


       public Int32 BeneficiariesAvailableOnRegistration {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BeneficiariesAvailableOnRegistration.ToString()]);
           }
       }


       public Int32 CenterStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CenterStatusID.ToString()]);
           }
       }


       public Int32 YearFounded {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.YearFounded.ToString()]);
           }
       }


       public Int32 ChurchCapacity {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ChurchCapacity.ToString()]);
           }
       }


       public String Comments {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Comments.ToString()]);
           }
       }


       public String PictureStoredPath {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PictureStoredPath.ToString()]);
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


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___Center GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___Center(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___Center GetFullTable()                  
        {                  
            return new T___Center(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___Center GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___Center(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___Center GetRowWhereID(int pID)                  
        {                  
            return new T___Center(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___Center pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___Center pRow, params DataColumnParameter[] pParams)                  
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
        public T___Center GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___Center(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Center(drst);                  
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
        public T___Center getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___Center(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___Center(drst);                  
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

                  
        public virtual string GetFillSQL() => Center__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCenterStatusID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterStatusID = new DataColumnParameter(defCenterStatusID, pCenterStatusID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramName = new DataColumnParameter(defName, defName.DefaultValue);
                DataColumnParameter paramAddress = new DataColumnParameter(defAddress, defAddress.DefaultValue);
                DataColumnParameter paramBeneficiariesAvailableOnRegistration = new DataColumnParameter(defBeneficiariesAvailableOnRegistration, defBeneficiariesAvailableOnRegistration.DefaultValue);
                DataColumnParameter paramYearFounded = new DataColumnParameter(defYearFounded, defYearFounded.DefaultValue);
                DataColumnParameter paramChurchCapacity = new DataColumnParameter(defChurchCapacity, defChurchCapacity.DefaultValue);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, defComments.DefaultValue);
                DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, defPictureStoredPath.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramName.getSQLQuotedValueForAdd(),
                paramAddress.getSQLQuotedValueForAdd(),
                paramBeneficiariesAvailableOnRegistration.getSQLQuotedValueForAdd(),
                paramCenterStatusID.getSQLQuotedValueForAdd(),
                paramYearFounded.getSQLQuotedValueForAdd(),
                paramChurchCapacity.getSQLQuotedValueForAdd(),
                paramComments.getSQLQuotedValueForAdd(),
                paramPictureStoredPath.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd(),
                paramUpdatedByID.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pBeneficiariesAvailableOnRegistration,
Int32 pCenterStatusID,
Int32 pYearFounded,
Int32 pChurchCapacity,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pName = null,
Object pAddress = null,
Object pComments = null,
Object pPictureStoredPath = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramName = new DataColumnParameter(defName, pName);
                DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
                DataColumnParameter paramBeneficiariesAvailableOnRegistration = new DataColumnParameter(defBeneficiariesAvailableOnRegistration, pBeneficiariesAvailableOnRegistration);
                DataColumnParameter paramCenterStatusID = new DataColumnParameter(defCenterStatusID, pCenterStatusID);
                DataColumnParameter paramYearFounded = new DataColumnParameter(defYearFounded, pYearFounded);
                DataColumnParameter paramChurchCapacity = new DataColumnParameter(defChurchCapacity, pChurchCapacity);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
                DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramBeneficiariesAvailableOnRegistration.getSQLQuotedValueForAdd(),
paramCenterStatusID.getSQLQuotedValueForAdd(),
paramYearFounded.getSQLQuotedValueForAdd(),
paramChurchCapacity.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramPictureStoredPath.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pBeneficiariesAvailableOnRegistration,
Int32 pCenterStatusID,
Int32 pYearFounded,
Int32 pChurchCapacity,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pName = null,
Object pAddress = null,
Object pComments = null,
Object pPictureStoredPath = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramName = new DataColumnParameter(defName, pName);
DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
DataColumnParameter paramBeneficiariesAvailableOnRegistration = new DataColumnParameter(defBeneficiariesAvailableOnRegistration, pBeneficiariesAvailableOnRegistration);
DataColumnParameter paramCenterStatusID = new DataColumnParameter(defCenterStatusID, pCenterStatusID);
DataColumnParameter paramYearFounded = new DataColumnParameter(defYearFounded, pYearFounded);
DataColumnParameter paramChurchCapacity = new DataColumnParameter(defChurchCapacity, pChurchCapacity);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramBeneficiariesAvailableOnRegistration.getSQLQuotedValueForAdd(),
paramCenterStatusID.getSQLQuotedValueForAdd(),
paramYearFounded.getSQLQuotedValueForAdd(),
paramChurchCapacity.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramPictureStoredPath.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pBeneficiariesAvailableOnRegistration,
Int32 pCenterStatusID,
Int32 pYearFounded,
Int32 pChurchCapacity,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pName= null,
Object pAddress= null,
Object pComments= null,
Object pPictureStoredPath= null){

        try{

DataColumnParameter paramName = new DataColumnParameter(defName, pName);
DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
DataColumnParameter paramBeneficiariesAvailableOnRegistration = new DataColumnParameter(defBeneficiariesAvailableOnRegistration, pBeneficiariesAvailableOnRegistration);
DataColumnParameter paramCenterStatusID = new DataColumnParameter(defCenterStatusID, pCenterStatusID);
DataColumnParameter paramYearFounded = new DataColumnParameter(defYearFounded, pYearFounded);
DataColumnParameter paramChurchCapacity = new DataColumnParameter(defChurchCapacity, pChurchCapacity);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) ", TABLE_NAME,paramName.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramBeneficiariesAvailableOnRegistration.getSQLQuotedValueForAdd(),
paramCenterStatusID.getSQLQuotedValueForAdd(),
paramYearFounded.getSQLQuotedValueForAdd(),
paramChurchCapacity.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramPictureStoredPath.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), true);


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
Object pBeneficiariesAvailableOnRegistration = null,
Object pCenterStatusID = null,
Object pYearFounded = null,
Object pChurchCapacity = null,
Object pCreatedAt = null,
Object pUpdatedAt = null,
Object pCreatedByID = null,
Object pUpdatedByID = null,
Object pName = null,
Object pAddress = null,
Object pComments = null,
Object pPictureStoredPath = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramName = new DataColumnParameter(defName, pName);
 DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
 DataColumnParameter paramBeneficiariesAvailableOnRegistration = new DataColumnParameter(defBeneficiariesAvailableOnRegistration, pBeneficiariesAvailableOnRegistration);
 DataColumnParameter paramCenterStatusID = new DataColumnParameter(defCenterStatusID, pCenterStatusID);
 DataColumnParameter paramYearFounded = new DataColumnParameter(defYearFounded, pYearFounded);
 DataColumnParameter paramChurchCapacity = new DataColumnParameter(defChurchCapacity, pChurchCapacity);
 DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
 DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [Name]={2},[Address]={3},[BeneficiariesAvailableOnRegistration]={4},[CenterStatusID]={5},[YearFounded]={6},[ChurchCapacity]={7},[Comments]={8},[PictureStoredPath]={9},[CreatedAt]={10},[UpdatedAt]={11},[CreatedByID]={12},[UpdatedByID]={13} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramName.getSQLQuotedValueForUpdate(),
paramAddress.getSQLQuotedValueForUpdate(),
paramBeneficiariesAvailableOnRegistration.getSQLQuotedValueForUpdate(),
paramCenterStatusID.getSQLQuotedValueForUpdate(),
paramYearFounded.getSQLQuotedValueForUpdate(),
paramChurchCapacity.getSQLQuotedValueForUpdate(),
paramComments.getSQLQuotedValueForUpdate(),
paramPictureStoredPath.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramUpdatedByID.getSQLQuotedValueForUpdate()  ), true);


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
