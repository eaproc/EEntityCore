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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___AttendeeDetail : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___AttendeeDetail()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterVisitationID = new DataColumnDefinition(TableColumnNames.CenterVisitationID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defBeneficiaryID = new DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defIsPresent = new DataColumnDefinition(TableColumnNames.IsPresent.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureStoredPath = new DataColumnDefinition(TableColumnNames.PictureStoredPath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEducation = new DataColumnDefinition(TableColumnNames.Education.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmotion = new DataColumnDefinition(TableColumnNames.Emotion.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHealth = new DataColumnDefinition(TableColumnNames.Health.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSpiritual = new DataColumnDefinition(TableColumnNames.Spiritual.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSocial = new DataColumnDefinition(TableColumnNames.Social.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTalent = new DataColumnDefinition(TableColumnNames.Talent.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defObservations = new DataColumnDefinition(TableColumnNames.Observations.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChristSmilesFeedBack = new DataColumnDefinition(TableColumnNames.ChristSmilesFeedBack.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


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

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public int CenterVisitationID { get => (int)TargettedRow[TableColumnNames.CenterVisitationID.ToString()]; }


       public int BeneficiaryID { get => (int)TargettedRow[TableColumnNames.BeneficiaryID.ToString()]; }


       public bool IsPresent { get => (bool)TargettedRow[TableColumnNames.IsPresent.ToString()]; }


       public string PictureStoredPath { get => (string)TargettedRow[TableColumnNames.PictureStoredPath.ToString()]; }


       public string Education { get => (string)TargettedRow[TableColumnNames.Education.ToString()]; }


       public string Emotion { get => (string)TargettedRow[TableColumnNames.Emotion.ToString()]; }


       public string Health { get => (string)TargettedRow[TableColumnNames.Health.ToString()]; }


       public string Spiritual { get => (string)TargettedRow[TableColumnNames.Spiritual.ToString()]; }


       public string Social { get => (string)TargettedRow[TableColumnNames.Social.ToString()]; }


       public string Talent { get => (string)TargettedRow[TableColumnNames.Talent.ToString()]; }


       public string Observations { get => (string)TargettedRow[TableColumnNames.Observations.ToString()]; }


       public string ChristSmilesFeedBack { get => (string)TargettedRow[TableColumnNames.ChristSmilesFeedBack.ToString()]; }


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
        public T___AttendeeDetail GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___AttendeeDetail GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___AttendeeDetail GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___AttendeeDetail(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___AttendeeDetail GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => AttendeeDetail__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int CenterVisitationID,
            int BeneficiaryID,
            bool IsPresent,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string PictureStoredPath = null,
            string Education = null,
            string Emotion = null,
            string Health = null,
            string Spiritual = null,
            string Social = null,
            string Talent = null,
            string Observations = null,
            string ChristSmilesFeedBack = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCenterVisitationID = new (defCenterVisitationID, CenterVisitationID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramIsPresent = new (defIsPresent, IsPresent);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramEducation = new (defEducation, Education);
                DataColumnParameter paramEmotion = new (defEmotion, Emotion);
                DataColumnParameter paramHealth = new (defHealth, Health);
                DataColumnParameter paramSpiritual = new (defSpiritual, Spiritual);
                DataColumnParameter paramSocial = new (defSocial, Social);
                DataColumnParameter paramTalent = new (defTalent, Talent);
                DataColumnParameter paramObservations = new (defObservations, Observations);
                DataColumnParameter paramChristSmilesFeedBack = new (defChristSmilesFeedBack, ChristSmilesFeedBack);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
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
            int CenterVisitationID,
            int BeneficiaryID,
            bool IsPresent,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string PictureStoredPath = null,
            string Education = null,
            string Emotion = null,
            string Health = null,
            string Spiritual = null,
            string Social = null,
            string Talent = null,
            string Observations = null,
            string ChristSmilesFeedBack = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCenterVisitationID = new (defCenterVisitationID, CenterVisitationID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramIsPresent = new (defIsPresent, IsPresent);
                DataColumnParameter paramPictureStoredPath = new (defPictureStoredPath, PictureStoredPath);
                DataColumnParameter paramEducation = new (defEducation, Education);
                DataColumnParameter paramEmotion = new (defEmotion, Emotion);
                DataColumnParameter paramHealth = new (defHealth, Health);
                DataColumnParameter paramSpiritual = new (defSpiritual, Spiritual);
                DataColumnParameter paramSocial = new (defSocial, Social);
                DataColumnParameter paramTalent = new (defTalent, Talent);
                DataColumnParameter paramObservations = new (defObservations, Observations);
                DataColumnParameter paramChristSmilesFeedBack = new (defChristSmilesFeedBack, ChristSmilesFeedBack);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
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
                        paramUpdatedByID.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
