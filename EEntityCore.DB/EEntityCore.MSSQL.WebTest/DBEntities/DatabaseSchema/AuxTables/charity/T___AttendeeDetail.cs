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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___AttendeeDetail : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___AttendeeDetail()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterVisitationID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CenterVisitationID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defBeneficiaryID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BeneficiaryID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defIsPresent = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsPresent.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureStoredPath = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PictureStoredPath.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEducation = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Education.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmotion = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Emotion.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHealth = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Health.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSpiritual = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Spiritual.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSocial = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Social.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTalent = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Talent.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defObservations = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Observations.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChristSmilesFeedBack = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ChristSmilesFeedBack.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCenterVisitationID.ColumnName, defCenterVisitationID); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defIsPresent.ColumnName, defIsPresent); 
          ColumnDefns.Add(defPictureStoredPath.ColumnName, defPictureStoredPath); 
          ColumnDefns.Add(defEducation.ColumnName, defEducation); 
          ColumnDefns.Add(defEmotion.ColumnName, defEmotion); 
          ColumnDefns.Add(defHealth.ColumnName, defHealth); 
          ColumnDefns.Add(defSpiritual.ColumnName, defSpiritual); 
          ColumnDefns.Add(defSocial.ColumnName, defSocial); 
          ColumnDefns.Add(defTalent.ColumnName, defTalent); 
          ColumnDefns.Add(defObservations.ColumnName, defObservations); 
          ColumnDefns.Add(defChristSmilesFeedBack.ColumnName, defChristSmilesFeedBack); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_CenterVisitationID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.AttendeeDetail", "charity.CenterVisitation"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_BeneficiaryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.AttendeeDetail", "charity.Beneficiary"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.AttendeeDetail", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.AttendeeDetail", "auth.Users"                  
                            ));                  

          }


                  
       public T___AttendeeDetail() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___AttendeeDetail(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AttendeeDetail(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___AttendeeDetail(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "charity.AttendeeDetail";
       public const string AttendeeDetail__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CenterVisitationID], [BeneficiaryID], [IsPresent], [PictureStoredPath], [Education], [Emotion], [Health], [Spiritual], [Social], [Talent], [Observations], [ChristSmilesFeedBack], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM AttendeeDetail";
       public const string AttendeeDetail__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CenterVisitationID], [BeneficiaryID], [IsPresent], [PictureStoredPath], [Education], [Emotion], [Health], [Spiritual], [Social], [Talent], [Observations], [ChristSmilesFeedBack], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM AttendeeDetail";


       public enum TableColumnNames
       {

           ID,
           CenterVisitationID,
           BeneficiaryID,
           IsPresent,
           PictureStoredPath,
           Education,
           Emotion,
           Health,
           Spiritual,
           Social,
           Talent,
           Observations,
           ChristSmilesFeedBack,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_AttendeeDetail, 
           fk_charity_AttendeeDetail_CenterVisitationID, 
           fk_charity_AttendeeDetail_BeneficiaryID, 
           fk_charity_AttendeeDetail_CreatedByID, 
           fk_charity_AttendeeDetail_UpdatedByID, 
           uq_charity_AttendeeDetail_BeneficiaryID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCenterVisitationID;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defIsPresent;
       public static readonly DataColumnDefinition defPictureStoredPath;
       public static readonly DataColumnDefinition defEducation;
       public static readonly DataColumnDefinition defEmotion;
       public static readonly DataColumnDefinition defHealth;
       public static readonly DataColumnDefinition defSpiritual;
       public static readonly DataColumnDefinition defSocial;
       public static readonly DataColumnDefinition defTalent;
       public static readonly DataColumnDefinition defObservations;
       public static readonly DataColumnDefinition defChristSmilesFeedBack;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public Int32 CenterVisitationID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CenterVisitationID.ToString()]);
           }
       }


       public Int32 BeneficiaryID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BeneficiaryID.ToString()]);
           }
       }


       public Boolean IsPresent {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsPresent.ToString()]);
           }
       }


       public String PictureStoredPath {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PictureStoredPath.ToString()]);
           }
       }


       public String Education {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Education.ToString()]);
           }
       }


       public String Emotion {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Emotion.ToString()]);
           }
       }


       public String Health {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Health.ToString()]);
           }
       }


       public String Spiritual {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Spiritual.ToString()]);
           }
       }


       public String Social {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Social.ToString()]);
           }
       }


       public String Talent {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Talent.ToString()]);
           }
       }


       public String Observations {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Observations.ToString()]);
           }
       }


       public String ChristSmilesFeedBack {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ChristSmilesFeedBack.ToString()]);
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
        public T___AttendeeDetail GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___AttendeeDetail(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___AttendeeDetail GetFullTable()                  
        {                  
            return new T___AttendeeDetail(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___AttendeeDetail GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___AttendeeDetail(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___AttendeeDetail GetRowWhereID(int pID)                  
        {                  
            return new T___AttendeeDetail(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___AttendeeDetail pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___AttendeeDetail pRow, params DataColumnParameter[] pParams)                  
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
        public T___AttendeeDetail GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___AttendeeDetail(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___AttendeeDetail(drst);                  
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
        public T___AttendeeDetail getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___AttendeeDetail(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___AttendeeDetail(drst);                  
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

                  
        public virtual string GetFillSQL() => AttendeeDetail__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCenterVisitationID,
Int32 pBeneficiaryID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterVisitationID = new DataColumnParameter(defCenterVisitationID, pCenterVisitationID);
                DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramIsPresent = new DataColumnParameter(defIsPresent, defIsPresent.DefaultValue);
                DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, defPictureStoredPath.DefaultValue);
                DataColumnParameter paramEducation = new DataColumnParameter(defEducation, defEducation.DefaultValue);
                DataColumnParameter paramEmotion = new DataColumnParameter(defEmotion, defEmotion.DefaultValue);
                DataColumnParameter paramHealth = new DataColumnParameter(defHealth, defHealth.DefaultValue);
                DataColumnParameter paramSpiritual = new DataColumnParameter(defSpiritual, defSpiritual.DefaultValue);
                DataColumnParameter paramSocial = new DataColumnParameter(defSocial, defSocial.DefaultValue);
                DataColumnParameter paramTalent = new DataColumnParameter(defTalent, defTalent.DefaultValue);
                DataColumnParameter paramObservations = new DataColumnParameter(defObservations, defObservations.DefaultValue);
                DataColumnParameter paramChristSmilesFeedBack = new DataColumnParameter(defChristSmilesFeedBack, defChristSmilesFeedBack.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramCenterVisitationID.GetSQLQuotedValueForAdd(),
                paramBeneficiaryID.GetSQLQuotedValueForAdd(),
                paramIsPresent.GetSQLQuotedValueForAdd(),
                paramPictureStoredPath.GetSQLQuotedValueForAdd(),
                paramEducation.GetSQLQuotedValueForAdd(),
                paramEmotion.GetSQLQuotedValueForAdd(),
                paramHealth.GetSQLQuotedValueForAdd(),
                paramSpiritual.GetSQLQuotedValueForAdd(),
                paramSocial.GetSQLQuotedValueForAdd(),
                paramTalent.GetSQLQuotedValueForAdd(),
                paramObservations.GetSQLQuotedValueForAdd(),
                paramChristSmilesFeedBack.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedByID.GetSQLQuotedValueForAdd(),
                paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pCenterVisitationID,
Int32 pBeneficiaryID,
Boolean pIsPresent,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pPictureStoredPath = null,
Object pEducation = null,
Object pEmotion = null,
Object pHealth = null,
Object pSpiritual = null,
Object pSocial = null,
Object pTalent = null,
Object pObservations = null,
Object pChristSmilesFeedBack = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterVisitationID = new DataColumnParameter(defCenterVisitationID, pCenterVisitationID);
                DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
                DataColumnParameter paramIsPresent = new DataColumnParameter(defIsPresent, pIsPresent);
                DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
                DataColumnParameter paramEducation = new DataColumnParameter(defEducation, pEducation);
                DataColumnParameter paramEmotion = new DataColumnParameter(defEmotion, pEmotion);
                DataColumnParameter paramHealth = new DataColumnParameter(defHealth, pHealth);
                DataColumnParameter paramSpiritual = new DataColumnParameter(defSpiritual, pSpiritual);
                DataColumnParameter paramSocial = new DataColumnParameter(defSocial, pSocial);
                DataColumnParameter paramTalent = new DataColumnParameter(defTalent, pTalent);
                DataColumnParameter paramObservations = new DataColumnParameter(defObservations, pObservations);
                DataColumnParameter paramChristSmilesFeedBack = new DataColumnParameter(defChristSmilesFeedBack, pChristSmilesFeedBack);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramCenterVisitationID.GetSQLQuotedValueForAdd(),
paramBeneficiaryID.GetSQLQuotedValueForAdd(),
paramIsPresent.GetSQLQuotedValueForAdd(),
paramPictureStoredPath.GetSQLQuotedValueForAdd(),
paramEducation.GetSQLQuotedValueForAdd(),
paramEmotion.GetSQLQuotedValueForAdd(),
paramHealth.GetSQLQuotedValueForAdd(),
paramSpiritual.GetSQLQuotedValueForAdd(),
paramSocial.GetSQLQuotedValueForAdd(),
paramTalent.GetSQLQuotedValueForAdd(),
paramObservations.GetSQLQuotedValueForAdd(),
paramChristSmilesFeedBack.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pCenterVisitationID,
Int32 pBeneficiaryID,
Boolean pIsPresent,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pPictureStoredPath = null,
Object pEducation = null,
Object pEmotion = null,
Object pHealth = null,
Object pSpiritual = null,
Object pSocial = null,
Object pTalent = null,
Object pObservations = null,
Object pChristSmilesFeedBack = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramCenterVisitationID = new DataColumnParameter(defCenterVisitationID, pCenterVisitationID);
DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
DataColumnParameter paramIsPresent = new DataColumnParameter(defIsPresent, pIsPresent);
DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
DataColumnParameter paramEducation = new DataColumnParameter(defEducation, pEducation);
DataColumnParameter paramEmotion = new DataColumnParameter(defEmotion, pEmotion);
DataColumnParameter paramHealth = new DataColumnParameter(defHealth, pHealth);
DataColumnParameter paramSpiritual = new DataColumnParameter(defSpiritual, pSpiritual);
DataColumnParameter paramSocial = new DataColumnParameter(defSocial, pSocial);
DataColumnParameter paramTalent = new DataColumnParameter(defTalent, pTalent);
DataColumnParameter paramObservations = new DataColumnParameter(defObservations, pObservations);
DataColumnParameter paramChristSmilesFeedBack = new DataColumnParameter(defChristSmilesFeedBack, pChristSmilesFeedBack);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramCenterVisitationID.GetSQLQuotedValueForAdd(),
paramBeneficiaryID.GetSQLQuotedValueForAdd(),
paramIsPresent.GetSQLQuotedValueForAdd(),
paramPictureStoredPath.GetSQLQuotedValueForAdd(),
paramEducation.GetSQLQuotedValueForAdd(),
paramEmotion.GetSQLQuotedValueForAdd(),
paramHealth.GetSQLQuotedValueForAdd(),
paramSpiritual.GetSQLQuotedValueForAdd(),
paramSocial.GetSQLQuotedValueForAdd(),
paramTalent.GetSQLQuotedValueForAdd(),
paramObservations.GetSQLQuotedValueForAdd(),
paramChristSmilesFeedBack.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pCenterVisitationID,
Int32 pBeneficiaryID,
Boolean pIsPresent,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pPictureStoredPath= null,
Object pEducation= null,
Object pEmotion= null,
Object pHealth= null,
Object pSpiritual= null,
Object pSocial= null,
Object pTalent= null,
Object pObservations= null,
Object pChristSmilesFeedBack= null){

        try{

DataColumnParameter paramCenterVisitationID = new DataColumnParameter(defCenterVisitationID, pCenterVisitationID);
DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
DataColumnParameter paramIsPresent = new DataColumnParameter(defIsPresent, pIsPresent);
DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
DataColumnParameter paramEducation = new DataColumnParameter(defEducation, pEducation);
DataColumnParameter paramEmotion = new DataColumnParameter(defEmotion, pEmotion);
DataColumnParameter paramHealth = new DataColumnParameter(defHealth, pHealth);
DataColumnParameter paramSpiritual = new DataColumnParameter(defSpiritual, pSpiritual);
DataColumnParameter paramSocial = new DataColumnParameter(defSocial, pSocial);
DataColumnParameter paramTalent = new DataColumnParameter(defTalent, pTalent);
DataColumnParameter paramObservations = new DataColumnParameter(defObservations, pObservations);
DataColumnParameter paramChristSmilesFeedBack = new DataColumnParameter(defChristSmilesFeedBack, pChristSmilesFeedBack);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) ", TABLE_NAME,paramCenterVisitationID.GetSQLQuotedValueForAdd(),
paramBeneficiaryID.GetSQLQuotedValueForAdd(),
paramIsPresent.GetSQLQuotedValueForAdd(),
paramPictureStoredPath.GetSQLQuotedValueForAdd(),
paramEducation.GetSQLQuotedValueForAdd(),
paramEmotion.GetSQLQuotedValueForAdd(),
paramHealth.GetSQLQuotedValueForAdd(),
paramSpiritual.GetSQLQuotedValueForAdd(),
paramSocial.GetSQLQuotedValueForAdd(),
paramTalent.GetSQLQuotedValueForAdd(),
paramObservations.GetSQLQuotedValueForAdd(),
paramChristSmilesFeedBack.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
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
Object pCenterVisitationID = null,
Object pBeneficiaryID = null,
Object pIsPresent = null,
Object pCreatedAt = null,
Object pUpdatedAt = null,
Object pCreatedByID = null,
Object pUpdatedByID = null,
Object pPictureStoredPath = null,
Object pEducation = null,
Object pEmotion = null,
Object pHealth = null,
Object pSpiritual = null,
Object pSocial = null,
Object pTalent = null,
Object pObservations = null,
Object pChristSmilesFeedBack = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramCenterVisitationID = new DataColumnParameter(defCenterVisitationID, pCenterVisitationID);
 DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
 DataColumnParameter paramIsPresent = new DataColumnParameter(defIsPresent, pIsPresent);
 DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
 DataColumnParameter paramEducation = new DataColumnParameter(defEducation, pEducation);
 DataColumnParameter paramEmotion = new DataColumnParameter(defEmotion, pEmotion);
 DataColumnParameter paramHealth = new DataColumnParameter(defHealth, pHealth);
 DataColumnParameter paramSpiritual = new DataColumnParameter(defSpiritual, pSpiritual);
 DataColumnParameter paramSocial = new DataColumnParameter(defSocial, pSocial);
 DataColumnParameter paramTalent = new DataColumnParameter(defTalent, pTalent);
 DataColumnParameter paramObservations = new DataColumnParameter(defObservations, pObservations);
 DataColumnParameter paramChristSmilesFeedBack = new DataColumnParameter(defChristSmilesFeedBack, pChristSmilesFeedBack);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [CenterVisitationID]={2},[BeneficiaryID]={3},[IsPresent]={4},[PictureStoredPath]={5},[Education]={6},[Emotion]={7},[Health]={8},[Spiritual]={9},[Social]={10},[Talent]={11},[Observations]={12},[ChristSmilesFeedBack]={13},[CreatedAt]={14},[UpdatedAt]={15},[CreatedByID]={16},[UpdatedByID]={17} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramCenterVisitationID.GetSQLQuotedValueForUpdate(),
paramBeneficiaryID.GetSQLQuotedValueForUpdate(),
paramIsPresent.GetSQLQuotedValueForUpdate(),
paramPictureStoredPath.GetSQLQuotedValueForUpdate(),
paramEducation.GetSQLQuotedValueForUpdate(),
paramEmotion.GetSQLQuotedValueForUpdate(),
paramHealth.GetSQLQuotedValueForUpdate(),
paramSpiritual.GetSQLQuotedValueForUpdate(),
paramSocial.GetSQLQuotedValueForUpdate(),
paramTalent.GetSQLQuotedValueForUpdate(),
paramObservations.GetSQLQuotedValueForUpdate(),
paramChristSmilesFeedBack.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedByID.GetSQLQuotedValueForUpdate(),
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
