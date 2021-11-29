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

    public class T___Beneficiary : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Beneficiary()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterID = new DataColumnDefinition(TableColumnNames.CenterID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBeneficiaryStatusID = new DataColumnDefinition(TableColumnNames.BeneficiaryStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(TableColumnNames.Address.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCity = new DataColumnDefinition(TableColumnNames.City.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defState = new DataColumnDefinition(TableColumnNames.State.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defZipCode = new DataColumnDefinition(TableColumnNames.ZipCode.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSchoolName = new DataColumnDefinition(TableColumnNames.SchoolName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSchoolAddress = new DataColumnDefinition(TableColumnNames.SchoolAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defClassOnEnrollment = new DataColumnDefinition(TableColumnNames.ClassOnEnrollment.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomePhone = new DataColumnDefinition(TableColumnNames.HomePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAlternatePhone = new DataColumnDefinition(TableColumnNames.AlternatePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGenderID = new DataColumnDefinition(TableColumnNames.GenderID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDateOfBirth = new DataColumnDefinition(TableColumnNames.DateOfBirth.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVocation = new DataColumnDefinition(TableColumnNames.Vocation.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBirthCertificatePath = new DataColumnDefinition(TableColumnNames.BirthCertificatePath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPhotoPath = new DataColumnDefinition(TableColumnNames.PhotoPath.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);


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
       public const string Beneficiary__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [BeneficiaryStatusID], [FirstName], [LastName], [Address], [City], [State], [ZipCode], [SchoolName], [SchoolAddress], [ClassOnEnrollment], [HomePhone], [AlternatePhone], [Email], [GenderID], [DateOfBirth], [Vocation], [BirthCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.Beneficiary";
       public const string Beneficiary__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [BeneficiaryStatusID], [FirstName], [LastName], [Address], [City], [State], [ZipCode], [SchoolName], [SchoolAddress], [ClassOnEnrollment], [HomePhone], [AlternatePhone], [Email], [GenderID], [DateOfBirth], [Vocation], [BirthCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM charity.Beneficiary";


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

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public int CenterID { get => (int)TargettedRow[TableColumnNames.CenterID.ToString()]; }


       public int BeneficiaryStatusID { get => (int)TargettedRow[TableColumnNames.BeneficiaryStatusID.ToString()]; }


       public string FirstName { get => (string)TargettedRow[TableColumnNames.FirstName.ToString()]; }


       public string LastName { get => (string)TargettedRow[TableColumnNames.LastName.ToString()]; }


       public string Address { get => (string)TargettedRow[TableColumnNames.Address.ToString()]; }


       public string City { get => (string)TargettedRow[TableColumnNames.City.ToString()]; }


       public string State { get => (string)TargettedRow[TableColumnNames.State.ToString()]; }


       public string ZipCode { get => (string)TargettedRow[TableColumnNames.ZipCode.ToString()]; }


       public string SchoolName { get => (string)TargettedRow[TableColumnNames.SchoolName.ToString()]; }


       public string SchoolAddress { get => (string)TargettedRow[TableColumnNames.SchoolAddress.ToString()]; }


       public string ClassOnEnrollment { get => (string)TargettedRow[TableColumnNames.ClassOnEnrollment.ToString()]; }


       public string HomePhone { get => (string)TargettedRow[TableColumnNames.HomePhone.ToString()]; }


       public string AlternatePhone { get => (string)TargettedRow[TableColumnNames.AlternatePhone.ToString()]; }


       public string Email { get => (string)TargettedRow[TableColumnNames.Email.ToString()]; }


       public int GenderID { get => (int)TargettedRow[TableColumnNames.GenderID.ToString()]; }


       public DateTime DateOfBirth { get => (DateTime)TargettedRow[TableColumnNames.DateOfBirth.ToString()]; }


       public string Vocation { get => (string)TargettedRow[TableColumnNames.Vocation.ToString()]; }


       public string BirthCertificatePath { get => (string)TargettedRow[TableColumnNames.BirthCertificatePath.ToString()]; }


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
        public T___Beneficiary GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___Beneficiary GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___Beneficiary(conn.Fetch(Beneficiary__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable(), DO__NOT____TARGET__ANY_ROWID),                  
                transaction                  
                );                                                      
                                                      
        public static T___Beneficiary GetRowWhereIDUsingSQL(int pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___Beneficiary( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___Beneficiary GetRowWhereID(int pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => Beneficiary__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int CenterID,
            int BeneficiaryStatusID,
            string FirstName,
            string LastName,
            string Address,
            int GenderID,
            DateTime DateOfBirth,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string City = null,
            string State = null,
            string ZipCode = null,
            string SchoolName = null,
            string SchoolAddress = null,
            string ClassOnEnrollment = null,
            string HomePhone = null,
            string AlternatePhone = null,
            string Email = null,
            string Vocation = null,
            string BirthCertificatePath = null,
            string PhotoPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramBeneficiaryStatusID = new (defBeneficiaryStatusID, BeneficiaryStatusID);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramCity = new (defCity, City);
                DataColumnParameter paramState = new (defState, State);
                DataColumnParameter paramZipCode = new (defZipCode, ZipCode);
                DataColumnParameter paramSchoolName = new (defSchoolName, SchoolName);
                DataColumnParameter paramSchoolAddress = new (defSchoolAddress, SchoolAddress);
                DataColumnParameter paramClassOnEnrollment = new (defClassOnEnrollment, ClassOnEnrollment);
                DataColumnParameter paramHomePhone = new (defHomePhone, HomePhone);
                DataColumnParameter paramAlternatePhone = new (defAlternatePhone, AlternatePhone);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramGenderID = new (defGenderID, GenderID);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramVocation = new (defVocation, Vocation);
                DataColumnParameter paramBirthCertificatePath = new (defBirthCertificatePath, BirthCertificatePath);
                DataColumnParameter paramPhotoPath = new (defPhotoPath, PhotoPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23})  ", TABLE_NAME,
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
            int CenterID,
            int BeneficiaryStatusID,
            string FirstName,
            string LastName,
            string Address,
            int GenderID,
            DateTime DateOfBirth,
            DateTime CreatedAt,
            DateTime UpdatedAt,
            int CreatedByID,
            int UpdatedByID,
            string City = null,
            string State = null,
            string ZipCode = null,
            string SchoolName = null,
            string SchoolAddress = null,
            string ClassOnEnrollment = null,
            string HomePhone = null,
            string AlternatePhone = null,
            string Email = null,
            string Vocation = null,
            string BirthCertificatePath = null,
            string PhotoPath = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramCenterID = new (defCenterID, CenterID);
                DataColumnParameter paramBeneficiaryStatusID = new (defBeneficiaryStatusID, BeneficiaryStatusID);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramAddress = new (defAddress, Address);
                DataColumnParameter paramCity = new (defCity, City);
                DataColumnParameter paramState = new (defState, State);
                DataColumnParameter paramZipCode = new (defZipCode, ZipCode);
                DataColumnParameter paramSchoolName = new (defSchoolName, SchoolName);
                DataColumnParameter paramSchoolAddress = new (defSchoolAddress, SchoolAddress);
                DataColumnParameter paramClassOnEnrollment = new (defClassOnEnrollment, ClassOnEnrollment);
                DataColumnParameter paramHomePhone = new (defHomePhone, HomePhone);
                DataColumnParameter paramAlternatePhone = new (defAlternatePhone, AlternatePhone);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramGenderID = new (defGenderID, GenderID);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramVocation = new (defVocation, Vocation);
                DataColumnParameter paramBirthCertificatePath = new (defBirthCertificatePath, BirthCertificatePath);
                DataColumnParameter paramPhotoPath = new (defPhotoPath, PhotoPath);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramUpdatedByID = new (defUpdatedByID, UpdatedByID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
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
                        paramUpdatedByID.GetSQLQuotedValueForAdd()                        )
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
