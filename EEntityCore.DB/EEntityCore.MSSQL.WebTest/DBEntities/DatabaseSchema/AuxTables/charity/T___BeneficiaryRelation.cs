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

    public class T___BeneficiaryRelation : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___BeneficiaryRelation()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defBeneficiaryID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BeneficiaryID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defRelationshipTypeID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RelationshipTypeID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defMaritalStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MaritalStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsDeceased = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsDeceased.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRelationshipNarration = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RelationshipNarration.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FullName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOccupation = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Occupation.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Address.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomePhone = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.HomePhone.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Email.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDeathCertificatePath = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DeathCertificatePath.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPhotoPath = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PhotoPath.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


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
       public const string BeneficiaryRelation__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [BeneficiaryID], [RelationshipTypeID], [MaritalStatusID], [IsDeceased], [RelationshipNarration], [FullName], [Occupation], [Address], [HomePhone], [Email], [DeathCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM BeneficiaryRelation";
       public const string BeneficiaryRelation__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [BeneficiaryID], [RelationshipTypeID], [MaritalStatusID], [IsDeceased], [RelationshipNarration], [FullName], [Occupation], [Address], [HomePhone], [Email], [DeathCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM BeneficiaryRelation";


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

       public Int32 BeneficiaryID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BeneficiaryID.ToString()]);
           }
       }


       public Int32 RelationshipTypeID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.RelationshipTypeID.ToString()]);
           }
       }


       public Int32 MaritalStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.MaritalStatusID.ToString()]);
           }
       }


       public Boolean IsDeceased {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsDeceased.ToString()]);
           }
       }


       public String RelationshipNarration {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.RelationshipNarration.ToString()]);
           }
       }


       public String FullName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FullName.ToString()]);
           }
       }


       public String Occupation {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Occupation.ToString()]);
           }
       }


       public String Address {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Address.ToString()]);
           }
       }


       public String HomePhone {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.HomePhone.ToString()]);
           }
       }


       public String Email {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Email.ToString()]);
           }
       }


       public String DeathCertificatePath {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.DeathCertificatePath.ToString()]);
           }
       }


       public String PhotoPath {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PhotoPath.ToString()]);
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
                                                      
        public static T___BeneficiaryRelation GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___BeneficiaryRelation GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___BeneficiaryRelation(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___BeneficiaryRelation GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => BeneficiaryRelation__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pBeneficiaryID,
Int32 pRelationshipTypeID,
Int32 pMaritalStatusID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
                DataColumnParameter paramRelationshipTypeID = new DataColumnParameter(defRelationshipTypeID, pRelationshipTypeID);
                DataColumnParameter paramMaritalStatusID = new DataColumnParameter(defMaritalStatusID, pMaritalStatusID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramIsDeceased = new DataColumnParameter(defIsDeceased, defIsDeceased.DefaultValue);
                DataColumnParameter paramRelationshipNarration = new DataColumnParameter(defRelationshipNarration, defRelationshipNarration.DefaultValue);
                DataColumnParameter paramFullName = new DataColumnParameter(defFullName, defFullName.DefaultValue);
                DataColumnParameter paramOccupation = new DataColumnParameter(defOccupation, defOccupation.DefaultValue);
                DataColumnParameter paramAddress = new DataColumnParameter(defAddress, defAddress.DefaultValue);
                DataColumnParameter paramHomePhone = new DataColumnParameter(defHomePhone, defHomePhone.DefaultValue);
                DataColumnParameter paramEmail = new DataColumnParameter(defEmail, defEmail.DefaultValue);
                DataColumnParameter paramDeathCertificatePath = new DataColumnParameter(defDeathCertificatePath, defDeathCertificatePath.DefaultValue);
                DataColumnParameter paramPhotoPath = new DataColumnParameter(defPhotoPath, defPhotoPath.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
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
                paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pBeneficiaryID,
Int32 pRelationshipTypeID,
Int32 pMaritalStatusID,
Boolean pIsDeceased,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pRelationshipNarration = null,
Object pFullName = null,
Object pOccupation = null,
Object pAddress = null,
Object pHomePhone = null,
Object pEmail = null,
Object pDeathCertificatePath = null,
Object pPhotoPath = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
                DataColumnParameter paramRelationshipTypeID = new DataColumnParameter(defRelationshipTypeID, pRelationshipTypeID);
                DataColumnParameter paramMaritalStatusID = new DataColumnParameter(defMaritalStatusID, pMaritalStatusID);
                DataColumnParameter paramIsDeceased = new DataColumnParameter(defIsDeceased, pIsDeceased);
                DataColumnParameter paramRelationshipNarration = new DataColumnParameter(defRelationshipNarration, pRelationshipNarration);
                DataColumnParameter paramFullName = new DataColumnParameter(defFullName, pFullName);
                DataColumnParameter paramOccupation = new DataColumnParameter(defOccupation, pOccupation);
                DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
                DataColumnParameter paramHomePhone = new DataColumnParameter(defHomePhone, pHomePhone);
                DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
                DataColumnParameter paramDeathCertificatePath = new DataColumnParameter(defDeathCertificatePath, pDeathCertificatePath);
                DataColumnParameter paramPhotoPath = new DataColumnParameter(defPhotoPath, pPhotoPath);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pBeneficiaryID,
Int32 pRelationshipTypeID,
Int32 pMaritalStatusID,
Boolean pIsDeceased,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pRelationshipNarration = null,
Object pFullName = null,
Object pOccupation = null,
Object pAddress = null,
Object pHomePhone = null,
Object pEmail = null,
Object pDeathCertificatePath = null,
Object pPhotoPath = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
DataColumnParameter paramRelationshipTypeID = new DataColumnParameter(defRelationshipTypeID, pRelationshipTypeID);
DataColumnParameter paramMaritalStatusID = new DataColumnParameter(defMaritalStatusID, pMaritalStatusID);
DataColumnParameter paramIsDeceased = new DataColumnParameter(defIsDeceased, pIsDeceased);
DataColumnParameter paramRelationshipNarration = new DataColumnParameter(defRelationshipNarration, pRelationshipNarration);
DataColumnParameter paramFullName = new DataColumnParameter(defFullName, pFullName);
DataColumnParameter paramOccupation = new DataColumnParameter(defOccupation, pOccupation);
DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
DataColumnParameter paramHomePhone = new DataColumnParameter(defHomePhone, pHomePhone);
DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
DataColumnParameter paramDeathCertificatePath = new DataColumnParameter(defDeathCertificatePath, pDeathCertificatePath);
DataColumnParameter paramPhotoPath = new DataColumnParameter(defPhotoPath, pPhotoPath);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pBeneficiaryID,
Int32 pRelationshipTypeID,
Int32 pMaritalStatusID,
Boolean pIsDeceased,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pRelationshipNarration= null,
Object pFullName= null,
Object pOccupation= null,
Object pAddress= null,
Object pHomePhone= null,
Object pEmail= null,
Object pDeathCertificatePath= null,
Object pPhotoPath= null){

        try{

DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
DataColumnParameter paramRelationshipTypeID = new DataColumnParameter(defRelationshipTypeID, pRelationshipTypeID);
DataColumnParameter paramMaritalStatusID = new DataColumnParameter(defMaritalStatusID, pMaritalStatusID);
DataColumnParameter paramIsDeceased = new DataColumnParameter(defIsDeceased, pIsDeceased);
DataColumnParameter paramRelationshipNarration = new DataColumnParameter(defRelationshipNarration, pRelationshipNarration);
DataColumnParameter paramFullName = new DataColumnParameter(defFullName, pFullName);
DataColumnParameter paramOccupation = new DataColumnParameter(defOccupation, pOccupation);
DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
DataColumnParameter paramHomePhone = new DataColumnParameter(defHomePhone, pHomePhone);
DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
DataColumnParameter paramDeathCertificatePath = new DataColumnParameter(defDeathCertificatePath, pDeathCertificatePath);
DataColumnParameter paramPhotoPath = new DataColumnParameter(defPhotoPath, pPhotoPath);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) ", TABLE_NAME,paramBeneficiaryID.GetSQLQuotedValueForAdd(),
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
Object pBeneficiaryID = null,
Object pRelationshipTypeID = null,
Object pMaritalStatusID = null,
Object pIsDeceased = null,
Object pCreatedAt = null,
Object pUpdatedAt = null,
Object pCreatedByID = null,
Object pUpdatedByID = null,
Object pRelationshipNarration = null,
Object pFullName = null,
Object pOccupation = null,
Object pAddress = null,
Object pHomePhone = null,
Object pEmail = null,
Object pDeathCertificatePath = null,
Object pPhotoPath = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
 DataColumnParameter paramRelationshipTypeID = new DataColumnParameter(defRelationshipTypeID, pRelationshipTypeID);
 DataColumnParameter paramMaritalStatusID = new DataColumnParameter(defMaritalStatusID, pMaritalStatusID);
 DataColumnParameter paramIsDeceased = new DataColumnParameter(defIsDeceased, pIsDeceased);
 DataColumnParameter paramRelationshipNarration = new DataColumnParameter(defRelationshipNarration, pRelationshipNarration);
 DataColumnParameter paramFullName = new DataColumnParameter(defFullName, pFullName);
 DataColumnParameter paramOccupation = new DataColumnParameter(defOccupation, pOccupation);
 DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
 DataColumnParameter paramHomePhone = new DataColumnParameter(defHomePhone, pHomePhone);
 DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
 DataColumnParameter paramDeathCertificatePath = new DataColumnParameter(defDeathCertificatePath, pDeathCertificatePath);
 DataColumnParameter paramPhotoPath = new DataColumnParameter(defPhotoPath, pPhotoPath);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [BeneficiaryID]={2},[RelationshipTypeID]={3},[MaritalStatusID]={4},[IsDeceased]={5},[RelationshipNarration]={6},[FullName]={7},[Occupation]={8},[Address]={9},[HomePhone]={10},[Email]={11},[DeathCertificatePath]={12},[PhotoPath]={13},[CreatedAt]={14},[UpdatedAt]={15},[CreatedByID]={16},[UpdatedByID]={17} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramBeneficiaryID.GetSQLQuotedValueForUpdate(),
paramRelationshipTypeID.GetSQLQuotedValueForUpdate(),
paramMaritalStatusID.GetSQLQuotedValueForUpdate(),
paramIsDeceased.GetSQLQuotedValueForUpdate(),
paramRelationshipNarration.GetSQLQuotedValueForUpdate(),
paramFullName.GetSQLQuotedValueForUpdate(),
paramOccupation.GetSQLQuotedValueForUpdate(),
paramAddress.GetSQLQuotedValueForUpdate(),
paramHomePhone.GetSQLQuotedValueForUpdate(),
paramEmail.GetSQLQuotedValueForUpdate(),
paramDeathCertificatePath.GetSQLQuotedValueForUpdate(),
paramPhotoPath.GetSQLQuotedValueForUpdate(),
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
