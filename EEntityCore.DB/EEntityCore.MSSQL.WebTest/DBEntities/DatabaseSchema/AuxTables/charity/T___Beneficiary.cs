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

    public class T___Beneficiary : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Beneficiary()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CenterID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBeneficiaryStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BeneficiaryStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defFirstName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FirstName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LastName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Address.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCity = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.City.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defState = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.State.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defZipCode = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ZipCode.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSchoolName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SchoolName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSchoolAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SchoolAddress.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClassOnEnrollment = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ClassOnEnrollment.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomePhone = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.HomePhone.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAlternatePhone = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AlternatePhone.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Email.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGenderID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.GenderID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDateOfBirth = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DateOfBirth.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVocation = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Vocation.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBirthCertificatePath = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BirthCertificatePath.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPhotoPath = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PhotoPath.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCenterID.ColumnName, defCenterID); 
          ColumnDefns.Add(defBeneficiaryStatusID.ColumnName, defBeneficiaryStatusID); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defCity.ColumnName, defCity); 
          ColumnDefns.Add(defState.ColumnName, defState); 
          ColumnDefns.Add(defZipCode.ColumnName, defZipCode); 
          ColumnDefns.Add(defSchoolName.ColumnName, defSchoolName); 
          ColumnDefns.Add(defSchoolAddress.ColumnName, defSchoolAddress); 
          ColumnDefns.Add(defClassOnEnrollment.ColumnName, defClassOnEnrollment); 
          ColumnDefns.Add(defHomePhone.ColumnName, defHomePhone); 
          ColumnDefns.Add(defAlternatePhone.ColumnName, defAlternatePhone); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defGenderID.ColumnName, defGenderID); 
          ColumnDefns.Add(defDateOfBirth.ColumnName, defDateOfBirth); 
          ColumnDefns.Add(defVocation.ColumnName, defVocation); 
          ColumnDefns.Add(defBirthCertificatePath.ColumnName, defBirthCertificatePath); 
          ColumnDefns.Add(defPhotoPath.ColumnName, defPhotoPath); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_CenterID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.Beneficiary", "charity.Center"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_GenderID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "common.Gender"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_BeneficiaryStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "charity.BeneficiaryStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "auth.Users"                  
                            ));                  

          }


                  
       public T___Beneficiary() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Beneficiary(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Beneficiary(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Beneficiary(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.Beneficiary";
       public const string Beneficiary__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [BeneficiaryStatusID], [FirstName], [LastName], [Address], [City], [State], [ZipCode], [SchoolName], [SchoolAddress], [ClassOnEnrollment], [HomePhone], [AlternatePhone], [Email], [GenderID], [DateOfBirth], [Vocation], [BirthCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM Beneficiary";
       public const string Beneficiary__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [BeneficiaryStatusID], [FirstName], [LastName], [Address], [City], [State], [ZipCode], [SchoolName], [SchoolAddress], [ClassOnEnrollment], [HomePhone], [AlternatePhone], [Email], [GenderID], [DateOfBirth], [Vocation], [BirthCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM Beneficiary";


       public enum TableColumnNames
       {

           ID,
           CenterID,
           BeneficiaryStatusID,
           FirstName,
           LastName,
           Address,
           City,
           State,
           ZipCode,
           SchoolName,
           SchoolAddress,
           ClassOnEnrollment,
           HomePhone,
           AlternatePhone,
           Email,
           GenderID,
           DateOfBirth,
           Vocation,
           BirthCertificatePath,
           PhotoPath,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_Beneficiary, 
           fk_charity_Beneficiary_CenterID, 
           fk_charity_Beneficiary_GenderID, 
           fk_charity_Beneficiary_BeneficiaryStatusID, 
           fk_charity_Beneficiary_CreatedByID, 
           fk_charity_Beneficiary_UpdatedByID, 
       } 


 #endregion 




 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCenterID;
       public static readonly DataColumnDefinition defBeneficiaryStatusID;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defCity;
       public static readonly DataColumnDefinition defState;
       public static readonly DataColumnDefinition defZipCode;
       public static readonly DataColumnDefinition defSchoolName;
       public static readonly DataColumnDefinition defSchoolAddress;
       public static readonly DataColumnDefinition defClassOnEnrollment;
       public static readonly DataColumnDefinition defHomePhone;
       public static readonly DataColumnDefinition defAlternatePhone;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defGenderID;
       public static readonly DataColumnDefinition defDateOfBirth;
       public static readonly DataColumnDefinition defVocation;
       public static readonly DataColumnDefinition defBirthCertificatePath;
       public static readonly DataColumnDefinition defPhotoPath;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public Int32 CenterID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CenterID.ToString()]);
           }
       }


       public Int32 BeneficiaryStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BeneficiaryStatusID.ToString()]);
           }
       }


       public String FirstName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FirstName.ToString()]);
           }
       }


       public String LastName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.LastName.ToString()]);
           }
       }


       public String Address {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Address.ToString()]);
           }
       }


       public String City {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.City.ToString()]);
           }
       }


       public String State {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.State.ToString()]);
           }
       }


       public String ZipCode {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ZipCode.ToString()]);
           }
       }


       public String SchoolName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.SchoolName.ToString()]);
           }
       }


       public String SchoolAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.SchoolAddress.ToString()]);
           }
       }


       public String ClassOnEnrollment {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ClassOnEnrollment.ToString()]);
           }
       }


       public String HomePhone {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.HomePhone.ToString()]);
           }
       }


       public String AlternatePhone {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AlternatePhone.ToString()]);
           }
       }


       public String Email {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Email.ToString()]);
           }
       }


       public Int32 GenderID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.GenderID.ToString()]);
           }
       }


       public NullableDateTime DateOfBirth {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.DateOfBirth.ToString()]);
           }
       }


       public String Vocation {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Vocation.ToString()]);
           }
       }


       public String BirthCertificatePath {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BirthCertificatePath.ToString()]);
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
        public T___Beneficiary GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Beneficiary GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Beneficiary GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Beneficiary(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Beneficiary GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Beneficiary__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCenterID,
Int32 pBeneficiaryStatusID,
Int32 pGenderID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
                DataColumnParameter paramBeneficiaryStatusID = new DataColumnParameter(defBeneficiaryStatusID, pBeneficiaryStatusID);
                DataColumnParameter paramGenderID = new DataColumnParameter(defGenderID, pGenderID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, defFirstName.DefaultValue);
                DataColumnParameter paramLastName = new DataColumnParameter(defLastName, defLastName.DefaultValue);
                DataColumnParameter paramAddress = new DataColumnParameter(defAddress, defAddress.DefaultValue);
                DataColumnParameter paramCity = new DataColumnParameter(defCity, defCity.DefaultValue);
                DataColumnParameter paramState = new DataColumnParameter(defState, defState.DefaultValue);
                DataColumnParameter paramZipCode = new DataColumnParameter(defZipCode, defZipCode.DefaultValue);
                DataColumnParameter paramSchoolName = new DataColumnParameter(defSchoolName, defSchoolName.DefaultValue);
                DataColumnParameter paramSchoolAddress = new DataColumnParameter(defSchoolAddress, defSchoolAddress.DefaultValue);
                DataColumnParameter paramClassOnEnrollment = new DataColumnParameter(defClassOnEnrollment, defClassOnEnrollment.DefaultValue);
                DataColumnParameter paramHomePhone = new DataColumnParameter(defHomePhone, defHomePhone.DefaultValue);
                DataColumnParameter paramAlternatePhone = new DataColumnParameter(defAlternatePhone, defAlternatePhone.DefaultValue);
                DataColumnParameter paramEmail = new DataColumnParameter(defEmail, defEmail.DefaultValue);
                DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, defDateOfBirth.DefaultValue);
                DataColumnParameter paramVocation = new DataColumnParameter(defVocation, defVocation.DefaultValue);
                DataColumnParameter paramBirthCertificatePath = new DataColumnParameter(defBirthCertificatePath, defBirthCertificatePath.DefaultValue);
                DataColumnParameter paramPhotoPath = new DataColumnParameter(defPhotoPath, defPhotoPath.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramCenterID.GetSQLQuotedValueForAdd(),
                paramBeneficiaryStatusID.GetSQLQuotedValueForAdd(),
                paramFirstName.GetSQLQuotedValueForAdd(),
                paramLastName.GetSQLQuotedValueForAdd(),
                paramAddress.GetSQLQuotedValueForAdd(),
                paramCity.GetSQLQuotedValueForAdd(),
                paramState.GetSQLQuotedValueForAdd(),
                paramZipCode.GetSQLQuotedValueForAdd(),
                paramSchoolName.GetSQLQuotedValueForAdd(),
                paramSchoolAddress.GetSQLQuotedValueForAdd(),
                paramClassOnEnrollment.GetSQLQuotedValueForAdd(),
                paramHomePhone.GetSQLQuotedValueForAdd(),
                paramAlternatePhone.GetSQLQuotedValueForAdd(),
                paramEmail.GetSQLQuotedValueForAdd(),
                paramGenderID.GetSQLQuotedValueForAdd(),
                paramDateOfBirth.GetSQLQuotedValueForAdd(),
                paramVocation.GetSQLQuotedValueForAdd(),
                paramBirthCertificatePath.GetSQLQuotedValueForAdd(),
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


        public static int AddWithID(Int32 pCenterID,
Int32 pBeneficiaryStatusID,
String pFirstName,
String pLastName,
String pAddress,
Int32 pGenderID,
DateTime pDateOfBirth,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pCity = null,
Object pState = null,
Object pZipCode = null,
Object pSchoolName = null,
Object pSchoolAddress = null,
Object pClassOnEnrollment = null,
Object pHomePhone = null,
Object pAlternatePhone = null,
Object pEmail = null,
Object pVocation = null,
Object pBirthCertificatePath = null,
Object pPhotoPath = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
                DataColumnParameter paramBeneficiaryStatusID = new DataColumnParameter(defBeneficiaryStatusID, pBeneficiaryStatusID);
                DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
                DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
                DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
                DataColumnParameter paramCity = new DataColumnParameter(defCity, pCity);
                DataColumnParameter paramState = new DataColumnParameter(defState, pState);
                DataColumnParameter paramZipCode = new DataColumnParameter(defZipCode, pZipCode);
                DataColumnParameter paramSchoolName = new DataColumnParameter(defSchoolName, pSchoolName);
                DataColumnParameter paramSchoolAddress = new DataColumnParameter(defSchoolAddress, pSchoolAddress);
                DataColumnParameter paramClassOnEnrollment = new DataColumnParameter(defClassOnEnrollment, pClassOnEnrollment);
                DataColumnParameter paramHomePhone = new DataColumnParameter(defHomePhone, pHomePhone);
                DataColumnParameter paramAlternatePhone = new DataColumnParameter(defAlternatePhone, pAlternatePhone);
                DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
                DataColumnParameter paramGenderID = new DataColumnParameter(defGenderID, pGenderID);
                DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
                DataColumnParameter paramVocation = new DataColumnParameter(defVocation, pVocation);
                DataColumnParameter paramBirthCertificatePath = new DataColumnParameter(defBirthCertificatePath, pBirthCertificatePath);
                DataColumnParameter paramPhotoPath = new DataColumnParameter(defPhotoPath, pPhotoPath);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramCenterID.GetSQLQuotedValueForAdd(),
paramBeneficiaryStatusID.GetSQLQuotedValueForAdd(),
paramFirstName.GetSQLQuotedValueForAdd(),
paramLastName.GetSQLQuotedValueForAdd(),
paramAddress.GetSQLQuotedValueForAdd(),
paramCity.GetSQLQuotedValueForAdd(),
paramState.GetSQLQuotedValueForAdd(),
paramZipCode.GetSQLQuotedValueForAdd(),
paramSchoolName.GetSQLQuotedValueForAdd(),
paramSchoolAddress.GetSQLQuotedValueForAdd(),
paramClassOnEnrollment.GetSQLQuotedValueForAdd(),
paramHomePhone.GetSQLQuotedValueForAdd(),
paramAlternatePhone.GetSQLQuotedValueForAdd(),
paramEmail.GetSQLQuotedValueForAdd(),
paramGenderID.GetSQLQuotedValueForAdd(),
paramDateOfBirth.GetSQLQuotedValueForAdd(),
paramVocation.GetSQLQuotedValueForAdd(),
paramBirthCertificatePath.GetSQLQuotedValueForAdd(),
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


        public static int  AddWithParseID(Int32 pParseID ,Int32 pCenterID,
Int32 pBeneficiaryStatusID,
String pFirstName,
String pLastName,
String pAddress,
Int32 pGenderID,
DateTime pDateOfBirth,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pCity = null,
Object pState = null,
Object pZipCode = null,
Object pSchoolName = null,
Object pSchoolAddress = null,
Object pClassOnEnrollment = null,
Object pHomePhone = null,
Object pAlternatePhone = null,
Object pEmail = null,
Object pVocation = null,
Object pBirthCertificatePath = null,
Object pPhotoPath = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
DataColumnParameter paramBeneficiaryStatusID = new DataColumnParameter(defBeneficiaryStatusID, pBeneficiaryStatusID);
DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
DataColumnParameter paramCity = new DataColumnParameter(defCity, pCity);
DataColumnParameter paramState = new DataColumnParameter(defState, pState);
DataColumnParameter paramZipCode = new DataColumnParameter(defZipCode, pZipCode);
DataColumnParameter paramSchoolName = new DataColumnParameter(defSchoolName, pSchoolName);
DataColumnParameter paramSchoolAddress = new DataColumnParameter(defSchoolAddress, pSchoolAddress);
DataColumnParameter paramClassOnEnrollment = new DataColumnParameter(defClassOnEnrollment, pClassOnEnrollment);
DataColumnParameter paramHomePhone = new DataColumnParameter(defHomePhone, pHomePhone);
DataColumnParameter paramAlternatePhone = new DataColumnParameter(defAlternatePhone, pAlternatePhone);
DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
DataColumnParameter paramGenderID = new DataColumnParameter(defGenderID, pGenderID);
DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
DataColumnParameter paramVocation = new DataColumnParameter(defVocation, pVocation);
DataColumnParameter paramBirthCertificatePath = new DataColumnParameter(defBirthCertificatePath, pBirthCertificatePath);
DataColumnParameter paramPhotoPath = new DataColumnParameter(defPhotoPath, pPhotoPath);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramCenterID.GetSQLQuotedValueForAdd(),
paramBeneficiaryStatusID.GetSQLQuotedValueForAdd(),
paramFirstName.GetSQLQuotedValueForAdd(),
paramLastName.GetSQLQuotedValueForAdd(),
paramAddress.GetSQLQuotedValueForAdd(),
paramCity.GetSQLQuotedValueForAdd(),
paramState.GetSQLQuotedValueForAdd(),
paramZipCode.GetSQLQuotedValueForAdd(),
paramSchoolName.GetSQLQuotedValueForAdd(),
paramSchoolAddress.GetSQLQuotedValueForAdd(),
paramClassOnEnrollment.GetSQLQuotedValueForAdd(),
paramHomePhone.GetSQLQuotedValueForAdd(),
paramAlternatePhone.GetSQLQuotedValueForAdd(),
paramEmail.GetSQLQuotedValueForAdd(),
paramGenderID.GetSQLQuotedValueForAdd(),
paramDateOfBirth.GetSQLQuotedValueForAdd(),
paramVocation.GetSQLQuotedValueForAdd(),
paramBirthCertificatePath.GetSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pCenterID,
Int32 pBeneficiaryStatusID,
String pFirstName,
String pLastName,
String pAddress,
Int32 pGenderID,
DateTime pDateOfBirth,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pCity= null,
Object pState= null,
Object pZipCode= null,
Object pSchoolName= null,
Object pSchoolAddress= null,
Object pClassOnEnrollment= null,
Object pHomePhone= null,
Object pAlternatePhone= null,
Object pEmail= null,
Object pVocation= null,
Object pBirthCertificatePath= null,
Object pPhotoPath= null){

        try{

DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
DataColumnParameter paramBeneficiaryStatusID = new DataColumnParameter(defBeneficiaryStatusID, pBeneficiaryStatusID);
DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
DataColumnParameter paramCity = new DataColumnParameter(defCity, pCity);
DataColumnParameter paramState = new DataColumnParameter(defState, pState);
DataColumnParameter paramZipCode = new DataColumnParameter(defZipCode, pZipCode);
DataColumnParameter paramSchoolName = new DataColumnParameter(defSchoolName, pSchoolName);
DataColumnParameter paramSchoolAddress = new DataColumnParameter(defSchoolAddress, pSchoolAddress);
DataColumnParameter paramClassOnEnrollment = new DataColumnParameter(defClassOnEnrollment, pClassOnEnrollment);
DataColumnParameter paramHomePhone = new DataColumnParameter(defHomePhone, pHomePhone);
DataColumnParameter paramAlternatePhone = new DataColumnParameter(defAlternatePhone, pAlternatePhone);
DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
DataColumnParameter paramGenderID = new DataColumnParameter(defGenderID, pGenderID);
DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
DataColumnParameter paramVocation = new DataColumnParameter(defVocation, pVocation);
DataColumnParameter paramBirthCertificatePath = new DataColumnParameter(defBirthCertificatePath, pBirthCertificatePath);
DataColumnParameter paramPhotoPath = new DataColumnParameter(defPhotoPath, pPhotoPath);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23}) ", TABLE_NAME,paramCenterID.GetSQLQuotedValueForAdd(),
paramBeneficiaryStatusID.GetSQLQuotedValueForAdd(),
paramFirstName.GetSQLQuotedValueForAdd(),
paramLastName.GetSQLQuotedValueForAdd(),
paramAddress.GetSQLQuotedValueForAdd(),
paramCity.GetSQLQuotedValueForAdd(),
paramState.GetSQLQuotedValueForAdd(),
paramZipCode.GetSQLQuotedValueForAdd(),
paramSchoolName.GetSQLQuotedValueForAdd(),
paramSchoolAddress.GetSQLQuotedValueForAdd(),
paramClassOnEnrollment.GetSQLQuotedValueForAdd(),
paramHomePhone.GetSQLQuotedValueForAdd(),
paramAlternatePhone.GetSQLQuotedValueForAdd(),
paramEmail.GetSQLQuotedValueForAdd(),
paramGenderID.GetSQLQuotedValueForAdd(),
paramDateOfBirth.GetSQLQuotedValueForAdd(),
paramVocation.GetSQLQuotedValueForAdd(),
paramBirthCertificatePath.GetSQLQuotedValueForAdd(),
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
Object pCenterID = null,
Object pBeneficiaryStatusID = null,
Object pFirstName = null,
Object pLastName = null,
Object pAddress = null,
Object pGenderID = null,
Object pDateOfBirth = null,
Object pCreatedAt = null,
Object pUpdatedAt = null,
Object pCreatedByID = null,
Object pUpdatedByID = null,
Object pCity = null,
Object pState = null,
Object pZipCode = null,
Object pSchoolName = null,
Object pSchoolAddress = null,
Object pClassOnEnrollment = null,
Object pHomePhone = null,
Object pAlternatePhone = null,
Object pEmail = null,
Object pVocation = null,
Object pBirthCertificatePath = null,
Object pPhotoPath = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
 DataColumnParameter paramBeneficiaryStatusID = new DataColumnParameter(defBeneficiaryStatusID, pBeneficiaryStatusID);
 DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
 DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
 DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
 DataColumnParameter paramCity = new DataColumnParameter(defCity, pCity);
 DataColumnParameter paramState = new DataColumnParameter(defState, pState);
 DataColumnParameter paramZipCode = new DataColumnParameter(defZipCode, pZipCode);
 DataColumnParameter paramSchoolName = new DataColumnParameter(defSchoolName, pSchoolName);
 DataColumnParameter paramSchoolAddress = new DataColumnParameter(defSchoolAddress, pSchoolAddress);
 DataColumnParameter paramClassOnEnrollment = new DataColumnParameter(defClassOnEnrollment, pClassOnEnrollment);
 DataColumnParameter paramHomePhone = new DataColumnParameter(defHomePhone, pHomePhone);
 DataColumnParameter paramAlternatePhone = new DataColumnParameter(defAlternatePhone, pAlternatePhone);
 DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
 DataColumnParameter paramGenderID = new DataColumnParameter(defGenderID, pGenderID);
 DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
 DataColumnParameter paramVocation = new DataColumnParameter(defVocation, pVocation);
 DataColumnParameter paramBirthCertificatePath = new DataColumnParameter(defBirthCertificatePath, pBirthCertificatePath);
 DataColumnParameter paramPhotoPath = new DataColumnParameter(defPhotoPath, pPhotoPath);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [CenterID]={2},[BeneficiaryStatusID]={3},[FirstName]={4},[LastName]={5},[Address]={6},[City]={7},[State]={8},[ZipCode]={9},[SchoolName]={10},[SchoolAddress]={11},[ClassOnEnrollment]={12},[HomePhone]={13},[AlternatePhone]={14},[Email]={15},[GenderID]={16},[DateOfBirth]={17},[Vocation]={18},[BirthCertificatePath]={19},[PhotoPath]={20},[CreatedAt]={21},[UpdatedAt]={22},[CreatedByID]={23},[UpdatedByID]={24} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramCenterID.GetSQLQuotedValueForUpdate(),
paramBeneficiaryStatusID.GetSQLQuotedValueForUpdate(),
paramFirstName.GetSQLQuotedValueForUpdate(),
paramLastName.GetSQLQuotedValueForUpdate(),
paramAddress.GetSQLQuotedValueForUpdate(),
paramCity.GetSQLQuotedValueForUpdate(),
paramState.GetSQLQuotedValueForUpdate(),
paramZipCode.GetSQLQuotedValueForUpdate(),
paramSchoolName.GetSQLQuotedValueForUpdate(),
paramSchoolAddress.GetSQLQuotedValueForUpdate(),
paramClassOnEnrollment.GetSQLQuotedValueForUpdate(),
paramHomePhone.GetSQLQuotedValueForUpdate(),
paramAlternatePhone.GetSQLQuotedValueForUpdate(),
paramEmail.GetSQLQuotedValueForUpdate(),
paramGenderID.GetSQLQuotedValueForUpdate(),
paramDateOfBirth.GetSQLQuotedValueForUpdate(),
paramVocation.GetSQLQuotedValueForUpdate(),
paramBirthCertificatePath.GetSQLQuotedValueForUpdate(),
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
