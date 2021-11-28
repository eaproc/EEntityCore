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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.common                  
{                  

    public class V___StaffPersons : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___StaffPersons()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defIdentificationNo = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IdentificationNo.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonnelNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonnelNumber.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsGuardian = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsGuardian.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobilePhone = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MobilePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGender = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Gender.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountry = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Country.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountryID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CountryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGenderID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.GenderID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDateOfBirth = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DateOfBirth.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomeAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.HomeAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomePhone = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.HomePhone.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonTitleID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonTitleID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBloodTypeID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BloodTypeID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PictureFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMaritalStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MaritalStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUsername = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Username.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsActive.ToString(), typeof(bool?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonnelID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonnelID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBirthPlace = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BirthPlace.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTitle = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Title.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMaritalStatus = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MaritalStatus.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBloodType = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BloodType.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsSuperUser = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsSuperUser.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCanBeDeleted = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CanBeDeleted.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCanBeUpdated = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CanBeUpdated.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defIdentificationNo.ColumnName, defIdentificationNo); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defPersonnelNumber.ColumnName, defPersonnelNumber); 
          ColumnDefns.Add(defIsGuardian.ColumnName, defIsGuardian); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defMobilePhone.ColumnName, defMobilePhone); 
          ColumnDefns.Add(defGender.ColumnName, defGender); 
          ColumnDefns.Add(defCountry.ColumnName, defCountry); 
          ColumnDefns.Add(defCountryID.ColumnName, defCountryID); 
          ColumnDefns.Add(defGenderID.ColumnName, defGenderID); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDateOfBirth.ColumnName, defDateOfBirth); 
          ColumnDefns.Add(defHomeAddress.ColumnName, defHomeAddress); 
          ColumnDefns.Add(defHomePhone.ColumnName, defHomePhone); 
          ColumnDefns.Add(defPersonTitleID.ColumnName, defPersonTitleID); 
          ColumnDefns.Add(defBloodTypeID.ColumnName, defBloodTypeID); 
          ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName); 
          ColumnDefns.Add(defMaritalStatusID.ColumnName, defMaritalStatusID); 
          ColumnDefns.Add(defUsername.ColumnName, defUsername); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defPersonnelID.ColumnName, defPersonnelID); 
          ColumnDefns.Add(defBirthPlace.ColumnName, defBirthPlace); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defMaritalStatus.ColumnName, defMaritalStatus); 
          ColumnDefns.Add(defBloodType.ColumnName, defBloodType); 
          ColumnDefns.Add(defIsSuperUser.ColumnName, defIsSuperUser); 
          ColumnDefns.Add(defCanBeDeleted.ColumnName, defCanBeDeleted); 
          ColumnDefns.Add(defCanBeUpdated.ColumnName, defCanBeUpdated); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("common.ExpandedPersons");                  

          }


                  
       public V___StaffPersons() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___StaffPersons(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___StaffPersons(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___StaffPersons(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___StaffPersons(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___StaffPersons(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___StaffPersons(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___StaffPersons(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___StaffPersons(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public V___StaffPersons(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "common.StaffPersons";
       public const string StaffPersons__NO__BINARY___SQL_FILL_QUERY = "SELECT [IdentificationNo], [FirstName], [LastName], [PersonnelNumber], [IsGuardian], [Email], [MobilePhone], [Gender], [Country], [CountryID], [GenderID], [ID], [DateOfBirth], [HomeAddress], [HomePhone], [PersonTitleID], [BloodTypeID], [PictureFileName], [MaritalStatusID], [Username], [IsActive], [PersonnelID], [BirthPlace], [Title], [MaritalStatus], [BloodType], [IsSuperUser], [CanBeDeleted], [CanBeUpdated] FROM StaffPersons";
       public const string StaffPersons__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [IdentificationNo], [FirstName], [LastName], [PersonnelNumber], [IsGuardian], [Email], [MobilePhone], [Gender], [Country], [CountryID], [GenderID], [ID], [DateOfBirth], [HomeAddress], [HomePhone], [PersonTitleID], [BloodTypeID], [PictureFileName], [MaritalStatusID], [Username], [IsActive], [PersonnelID], [BirthPlace], [Title], [MaritalStatus], [BloodType], [IsSuperUser], [CanBeDeleted], [CanBeUpdated] FROM StaffPersons";


       public enum TableColumnNames
       {

           IdentificationNo,
           FirstName,
           LastName,
           PersonnelNumber,
           IsGuardian,
           Email,
           MobilePhone,
           Gender,
           Country,
           CountryID,
           GenderID,
           ID,
           DateOfBirth,
           HomeAddress,
           HomePhone,
           PersonTitleID,
           BloodTypeID,
           PictureFileName,
           MaritalStatusID,
           Username,
           IsActive,
           PersonnelID,
           BirthPlace,
           Title,
           MaritalStatus,
           BloodType,
           IsSuperUser,
           CanBeDeleted,
           CanBeUpdated
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defIdentificationNo;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defPersonnelNumber;
       public static readonly DataColumnDefinition defIsGuardian;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defMobilePhone;
       public static readonly DataColumnDefinition defGender;
       public static readonly DataColumnDefinition defCountry;
       public static readonly DataColumnDefinition defCountryID;
       public static readonly DataColumnDefinition defGenderID;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDateOfBirth;
       public static readonly DataColumnDefinition defHomeAddress;
       public static readonly DataColumnDefinition defHomePhone;
       public static readonly DataColumnDefinition defPersonTitleID;
       public static readonly DataColumnDefinition defBloodTypeID;
       public static readonly DataColumnDefinition defPictureFileName;
       public static readonly DataColumnDefinition defMaritalStatusID;
       public static readonly DataColumnDefinition defUsername;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defPersonnelID;
       public static readonly DataColumnDefinition defBirthPlace;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defMaritalStatus;
       public static readonly DataColumnDefinition defBloodType;
       public static readonly DataColumnDefinition defIsSuperUser;
       public static readonly DataColumnDefinition defCanBeDeleted;
       public static readonly DataColumnDefinition defCanBeUpdated;

       public string IdentificationNo { get => (string)TargettedRow[TableColumnNames.IdentificationNo.ToString()]; }


       public string FirstName { get => (string)TargettedRow[TableColumnNames.FirstName.ToString()]; }


       public string LastName { get => (string)TargettedRow[TableColumnNames.LastName.ToString()]; }


       public string PersonnelNumber { get => (string)TargettedRow[TableColumnNames.PersonnelNumber.ToString()]; }


       public bool? IsGuardian { get => (bool?)TargettedRow[TableColumnNames.IsGuardian.ToString()]; }


       public string Email { get => (string)TargettedRow[TableColumnNames.Email.ToString()]; }


       public string MobilePhone { get => (string)TargettedRow[TableColumnNames.MobilePhone.ToString()]; }


       public string Gender { get => (string)TargettedRow[TableColumnNames.Gender.ToString()]; }


       public string Country { get => (string)TargettedRow[TableColumnNames.Country.ToString()]; }


       public int CountryID { get => (int)TargettedRow[TableColumnNames.CountryID.ToString()]; }


       public int GenderID { get => (int)TargettedRow[TableColumnNames.GenderID.ToString()]; }


       public DateTime DateOfBirth { get => (DateTime)TargettedRow[TableColumnNames.DateOfBirth.ToString()]; }


       public string HomeAddress { get => (string)TargettedRow[TableColumnNames.HomeAddress.ToString()]; }


       public string HomePhone { get => (string)TargettedRow[TableColumnNames.HomePhone.ToString()]; }


       public int? PersonTitleID { get => (int?)TargettedRow[TableColumnNames.PersonTitleID.ToString()]; }


       public int? BloodTypeID { get => (int?)TargettedRow[TableColumnNames.BloodTypeID.ToString()]; }


       public string PictureFileName { get => (string)TargettedRow[TableColumnNames.PictureFileName.ToString()]; }


       public int MaritalStatusID { get => (int)TargettedRow[TableColumnNames.MaritalStatusID.ToString()]; }


       public string Username { get => (string)TargettedRow[TableColumnNames.Username.ToString()]; }


       public bool? IsActive { get => (bool?)TargettedRow[TableColumnNames.IsActive.ToString()]; }


       public int? PersonnelID { get => (int?)TargettedRow[TableColumnNames.PersonnelID.ToString()]; }


       public string BirthPlace { get => (string)TargettedRow[TableColumnNames.BirthPlace.ToString()]; }


       public string Title { get => (string)TargettedRow[TableColumnNames.Title.ToString()]; }


       public string MaritalStatus { get => (string)TargettedRow[TableColumnNames.MaritalStatus.ToString()]; }


       public string BloodType { get => (string)TargettedRow[TableColumnNames.BloodType.ToString()]; }


       public bool IsSuperUser { get => (bool)TargettedRow[TableColumnNames.IsSuperUser.ToString()]; }


       public bool CanBeDeleted { get => (bool)TargettedRow[TableColumnNames.CanBeDeleted.ToString()]; }


       public bool CanBeUpdated { get => (bool)TargettedRow[TableColumnNames.CanBeUpdated.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public V___StaffPersons GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static V___StaffPersons GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static V___StaffPersons GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new V___StaffPersons(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public V___StaffPersons GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => StaffPersons__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
