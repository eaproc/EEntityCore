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

    public class T___BeneficiaryRelation : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___BeneficiaryRelation()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defBeneficiaryID = new DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defRelationshipTypeID = new DataColumnDefinition(TableColumnNames.RelationshipTypeID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defMaritalStatusID = new DataColumnDefinition(TableColumnNames.MaritalStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsDeceased = new DataColumnDefinition(TableColumnNames.IsDeceased.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRelationshipNarration = new DataColumnDefinition(TableColumnNames.RelationshipNarration.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(TableColumnNames.FullName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOccupation = new DataColumnDefinition(TableColumnNames.Occupation.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(TableColumnNames.Address.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomePhone = new DataColumnDefinition(TableColumnNames.HomePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDeathCertificatePath = new DataColumnDefinition(TableColumnNames.DeathCertificatePath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPhotoPath = new DataColumnDefinition(TableColumnNames.PhotoPath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defRelationshipTypeID.ColumnName, defRelationshipTypeID); 
          ColumnDefns.Add(defMaritalStatusID.ColumnName, defMaritalStatusID); 
          ColumnDefns.Add(defIsDeceased.ColumnName, defIsDeceased); 
          ColumnDefns.Add(defRelationshipNarration.ColumnName, defRelationshipNarration); 
          ColumnDefns.Add(defFullName.ColumnName, defFullName); 
          ColumnDefns.Add(defOccupation.ColumnName, defOccupation); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defHomePhone.ColumnName, defHomePhone); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defDeathCertificatePath.ColumnName, defDeathCertificatePath); 
          ColumnDefns.Add(defPhotoPath.ColumnName, defPhotoPath); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_BeneficiaryRelation_BeneficiaryID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.BeneficiaryRelation", "charity.Beneficiary"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_BeneficiaryRelation_RelationshipTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.BeneficiaryRelation", "common.RelationshipType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_BeneficiaryRelation_MaritalStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.BeneficiaryRelation", "common.MaritalStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_BeneficiaryRelation_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.BeneficiaryRelation", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_BeneficiaryRelation_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.BeneficiaryRelation", "auth.Users"                  
                            ));                  

          }


                  
       public T___BeneficiaryRelation() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BeneficiaryRelation(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___BeneficiaryRelation(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___BeneficiaryRelation(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___BeneficiaryRelation(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___BeneficiaryRelation(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BeneficiaryRelation(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BeneficiaryRelation(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BeneficiaryRelation(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BeneficiaryRelation(DataTable FullTable) : base(FullTable)                                    
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
        public T___BeneficiaryRelation(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.BeneficiaryRelation";
       public const string BeneficiaryRelation__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [BeneficiaryID], [RelationshipTypeID], [MaritalStatusID], [IsDeceased], [RelationshipNarration], [FullName], [Occupation], [Address], [HomePhone], [Email], [DeathCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.BeneficiaryRelation";
       public const string BeneficiaryRelation__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [BeneficiaryID], [RelationshipTypeID], [MaritalStatusID], [IsDeceased], [RelationshipNarration], [FullName], [Occupation], [Address], [HomePhone], [Email], [DeathCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.BeneficiaryRelation";


       public enum TableColumnNames
       {

           ID,
           BeneficiaryID,
           RelationshipTypeID,
           MaritalStatusID,
           IsDeceased,
           RelationshipNarration,
           FullName,
           Occupation,
           Address,
           HomePhone,
           Email,
           DeathCertificatePath,
           PhotoPath,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_BeneficiaryRelation, 
           fk_charity_BeneficiaryRelation_BeneficiaryID, 
           fk_charity_BeneficiaryRelation_RelationshipTypeID, 
           fk_charity_BeneficiaryRelation_MaritalStatusID, 
           fk_charity_BeneficiaryRelation_CreatedByID, 
           fk_charity_BeneficiaryRelation_UpdatedByID, 
           uq_charity_BeneficiaryRelation_BeneficiaryID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defRelationshipTypeID;
       public static readonly DataColumnDefinition defMaritalStatusID;
       public static readonly DataColumnDefinition defIsDeceased;
       public static readonly DataColumnDefinition defRelationshipNarration;
       public static readonly DataColumnDefinition defFullName;
       public static readonly DataColumnDefinition defOccupation;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defHomePhone;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defDeathCertificatePath;
       public static readonly DataColumnDefinition defPhotoPath;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public int BeneficiaryID { get => (int)TargettedRow[TableColumnNames.BeneficiaryID.ToString()]; }


       public int RelationshipTypeID { get => (int)TargettedRow[TableColumnNames.RelationshipTypeID.ToString()]; }


       public int MaritalStatusID { get => (int)TargettedRow[TableColumnNames.MaritalStatusID.ToString()]; }


       public bool IsDeceased { get => (bool)TargettedRow[TableColumnNames.IsDeceased.ToString()]; }


       public string RelationshipNarration { get => (string)TargettedRow[TableColumnNames.RelationshipNarration.ToString()]; }


       public string FullName { get => (string)TargettedRow[TableColumnNames.FullName.ToString()]; }


       public string Occupation { get => (string)TargettedRow[TableColumnNames.Occupation.ToString()]; }


       public string Address { get => (string)TargettedRow[TableColumnNames.Address.ToString()]; }


       public string HomePhone { get => (string)TargettedRow[TableColumnNames.HomePhone.ToString()]; }


       public string Email { get => (string)TargettedRow[TableColumnNames.Email.ToString()]; }


       public string DeathCertificatePath { get => (string)TargettedRow[TableColumnNames.DeathCertificatePath.ToString()]; }


       public string PhotoPath { get => (string)TargettedRow[TableColumnNames.PhotoPath.ToString()]; }


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
        public T___BeneficiaryRelation GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___BeneficiaryRelation GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___BeneficiaryRelation(conn.Fetch(BeneficiaryRelation__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___BeneficiaryRelation GetRowWhereIDUsingSQL(int pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___BeneficiaryRelation( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___BeneficiaryRelation GetRowWhereID(int pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => BeneficiaryRelation__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int BeneficiaryID,
            int RelationshipTypeID,
            int MaritalStatusID,
            bool IsDeceased,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string RelationshipNarration = null,
            string FullName = null,
            string Occupation = null,
            string Address = null,
            string HomePhone = null,
            string Email = null,
            string DeathCertificatePath = null,
            string PhotoPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramRelationshipTypeID = new (defRelationshipTypeID, RelationshipTypeID);
                DataColumnParameter paramMaritalStatusID = new (defMaritalStatusID, MaritalStatusID);
                DataColumnParameter paramIsDeceased = new (defIsDeceased, IsDeceased);
                DataColumnParameter paramRelationshipNarration = new (defRelationshipNarration, RelationshipNarration);
                DataColumnParameter paramFullName = new (defFullName, FullName);
                DataColumnParameter paramOccupation = new (defOccupation, Occupation);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramHomePhone = new (defHomePhone, HomePhone);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramDeathCertificatePath = new (defDeathCertificatePath, DeathCertificatePath);
                DataColumnParameter paramPhotoPath = new (defPhotoPath, PhotoPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
                        paramBeneficiaryID.GetSQLQuotedValueForAdd(),
                        paramRelationshipTypeID.GetSQLQuotedValueForAdd(),
                        paramMaritalStatusID.GetSQLQuotedValueForAdd(),
                        paramIsDeceased.GetSQLQuotedValueForAdd(),
                        paramRelationshipNarration.GetSQLQuotedValueForAdd(),
                        paramFullName.GetSQLQuotedValueForAdd(),
                        paramOccupation.GetSQLQuotedValueForAdd(),
                        paramAddress.GetSQLQuotedValueForAdd(),
                        paramHomePhone.GetSQLQuotedValueForAdd(),
                        paramEmail.GetSQLQuotedValueForAdd(),
                        paramDeathCertificatePath.GetSQLQuotedValueForAdd(),
                        paramPhotoPath.GetSQLQuotedValueForAdd(),
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
            int BeneficiaryID,
            int RelationshipTypeID,
            int MaritalStatusID,
            bool IsDeceased,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string RelationshipNarration = null,
            string FullName = null,
            string Occupation = null,
            string Address = null,
            string HomePhone = null,
            string Email = null,
            string DeathCertificatePath = null,
            string PhotoPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramRelationshipTypeID = new (defRelationshipTypeID, RelationshipTypeID);
                DataColumnParameter paramMaritalStatusID = new (defMaritalStatusID, MaritalStatusID);
                DataColumnParameter paramIsDeceased = new (defIsDeceased, IsDeceased);
                DataColumnParameter paramRelationshipNarration = new (defRelationshipNarration, RelationshipNarration);
                DataColumnParameter paramFullName = new (defFullName, FullName);
                DataColumnParameter paramOccupation = new (defOccupation, Occupation);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramHomePhone = new (defHomePhone, HomePhone);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramDeathCertificatePath = new (defDeathCertificatePath, DeathCertificatePath);
                DataColumnParameter paramPhotoPath = new (defPhotoPath, PhotoPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramBeneficiaryID.GetSQLQuotedValueForAdd(),
                        paramRelationshipTypeID.GetSQLQuotedValueForAdd(),
                        paramMaritalStatusID.GetSQLQuotedValueForAdd(),
                        paramIsDeceased.GetSQLQuotedValueForAdd(),
                        paramRelationshipNarration.GetSQLQuotedValueForAdd(),
                        paramFullName.GetSQLQuotedValueForAdd(),
                        paramOccupation.GetSQLQuotedValueForAdd(),
                        paramAddress.GetSQLQuotedValueForAdd(),
                        paramHomePhone.GetSQLQuotedValueForAdd(),
                        paramEmail.GetSQLQuotedValueForAdd(),
                        paramDeathCertificatePath.GetSQLQuotedValueForAdd(),
                        paramPhotoPath.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int BeneficiaryID,
            int RelationshipTypeID,
            int MaritalStatusID,
            bool IsDeceased,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string RelationshipNarration = null,
            string FullName = null,
            string Occupation = null,
            string Address = null,
            string HomePhone = null,
            string Email = null,
            string DeathCertificatePath = null,
            string PhotoPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramBeneficiaryID = new (defBeneficiaryID, BeneficiaryID);
                DataColumnParameter paramRelationshipTypeID = new (defRelationshipTypeID, RelationshipTypeID);
                DataColumnParameter paramMaritalStatusID = new (defMaritalStatusID, MaritalStatusID);
                DataColumnParameter paramIsDeceased = new (defIsDeceased, IsDeceased);
                DataColumnParameter paramRelationshipNarration = new (defRelationshipNarration, RelationshipNarration);
                DataColumnParameter paramFullName = new (defFullName, FullName);
                DataColumnParameter paramOccupation = new (defOccupation, Occupation);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramHomePhone = new (defHomePhone, HomePhone);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramDeathCertificatePath = new (defDeathCertificatePath, DeathCertificatePath);
                DataColumnParameter paramPhotoPath = new (defPhotoPath, PhotoPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
                        paramBeneficiaryID.GetSQLQuotedValueForAdd(),
                        paramRelationshipTypeID.GetSQLQuotedValueForAdd(),
                        paramMaritalStatusID.GetSQLQuotedValueForAdd(),
                        paramIsDeceased.GetSQLQuotedValueForAdd(),
                        paramRelationshipNarration.GetSQLQuotedValueForAdd(),
                        paramFullName.GetSQLQuotedValueForAdd(),
                        paramOccupation.GetSQLQuotedValueForAdd(),
                        paramAddress.GetSQLQuotedValueForAdd(),
                        paramHomePhone.GetSQLQuotedValueForAdd(),
                        paramEmail.GetSQLQuotedValueForAdd(),
                        paramDeathCertificatePath.GetSQLQuotedValueForAdd(),
                        paramPhotoPath.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramUpdatedByID.GetSQLQuotedValueForAdd()                            
                            )
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
