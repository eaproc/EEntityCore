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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.common                  
{                  

    public class T___Person : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Person()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defIdentificationNo = new DataColumnDefinition(TableColumnNames.IdentificationNo.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountryID = new DataColumnDefinition(TableColumnNames.CountryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDateOfBirth = new DataColumnDefinition(TableColumnNames.DateOfBirth.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGenderID = new DataColumnDefinition(TableColumnNames.GenderID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defHomeAddress = new DataColumnDefinition(TableColumnNames.HomeAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonTitleID = new DataColumnDefinition(TableColumnNames.PersonTitleID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsSuperUser = new DataColumnDefinition(TableColumnNames.IsSuperUser.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBloodTypeID = new DataColumnDefinition(TableColumnNames.BloodTypeID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBirthPlace = new DataColumnDefinition(TableColumnNames.BirthPlace.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMaritalStatusID = new DataColumnDefinition(TableColumnNames.MaritalStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCanBeUpdated = new DataColumnDefinition(TableColumnNames.CanBeUpdated.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCanBeDeleted = new DataColumnDefinition(TableColumnNames.CanBeDeleted.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDataMonitorID = new DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defIdentificationNo.ColumnName, defIdentificationNo); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defCountryID.ColumnName, defCountryID); 
          ColumnDefns.Add(defDateOfBirth.ColumnName, defDateOfBirth); 
          ColumnDefns.Add(defGenderID.ColumnName, defGenderID); 
          ColumnDefns.Add(defHomeAddress.ColumnName, defHomeAddress); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defPersonTitleID.ColumnName, defPersonTitleID); 
          ColumnDefns.Add(defIsSuperUser.ColumnName, defIsSuperUser); 
          ColumnDefns.Add(defBloodTypeID.ColumnName, defBloodTypeID); 
          ColumnDefns.Add(defBirthPlace.ColumnName, defBirthPlace); 
          ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName); 
          ColumnDefns.Add(defMaritalStatusID.ColumnName, defMaritalStatusID); 
          ColumnDefns.Add(defCanBeUpdated.ColumnName, defCanBeUpdated); 
          ColumnDefns.Add(defCanBeDeleted.ColumnName, defCanBeDeleted); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_DataMonitorID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "import.DataMonitor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_CountryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.Country"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_GenderID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.Gender"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_PersonTitleID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.PersonTitle"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_BloodTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.BloodType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_MaritalStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.MaritalStatus"                  
                            ));                  

          }


                  
       public T___Person() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Person(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Person(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Person(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "common.Person";
       public const string Person__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [IdentificationNo], [FirstName], [LastName], [CountryID], [DateOfBirth], [GenderID], [HomeAddress], [Email], [PersonTitleID], [IsSuperUser], [BloodTypeID], [BirthPlace], [PictureFileName], [MaritalStatusID], [CanBeUpdated], [CanBeDeleted], [CreatedAt], [UpdatedAt], [DataMonitorID] FROM Person";
       public const string Person__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [IdentificationNo], [FirstName], [LastName], [CountryID], [DateOfBirth], [GenderID], [HomeAddress], [Email], [PersonTitleID], [IsSuperUser], [BloodTypeID], [BirthPlace], [PictureFileName], [MaritalStatusID], [CanBeUpdated], [CanBeDeleted], [CreatedAt], [UpdatedAt], [DataMonitorID] FROM Person";


       public enum TableColumnNames
       {

           ID,
           IdentificationNo,
           FirstName,
           LastName,
           CountryID,
           DateOfBirth,
           GenderID,
           HomeAddress,
           Email,
           PersonTitleID,
           IsSuperUser,
           BloodTypeID,
           BirthPlace,
           PictureFileName,
           MaritalStatusID,
           CanBeUpdated,
           CanBeDeleted,
           CreatedAt,
           UpdatedAt,
           DataMonitorID
       } 



       public enum TableConstraints{

           pk_common_Person, 
           fk_common_Person_DataMonitorID, 
           fk_common_Person_CountryID, 
           fk_common_Person_GenderID, 
           fk_common_Person_PersonTitleID, 
           fk_common_Person_BloodTypeID, 
           fk_common_Person_MaritalStatusID, 
           uq_common_Person_IdentificationNo, 
           uq_common_Person_Email, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defIdentificationNo;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defCountryID;
       public static readonly DataColumnDefinition defDateOfBirth;
       public static readonly DataColumnDefinition defGenderID;
       public static readonly DataColumnDefinition defHomeAddress;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defPersonTitleID;
       public static readonly DataColumnDefinition defIsSuperUser;
       public static readonly DataColumnDefinition defBloodTypeID;
       public static readonly DataColumnDefinition defBirthPlace;
       public static readonly DataColumnDefinition defPictureFileName;
       public static readonly DataColumnDefinition defMaritalStatusID;
       public static readonly DataColumnDefinition defCanBeUpdated;
       public static readonly DataColumnDefinition defCanBeDeleted;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defDataMonitorID;

       public string IdentificationNo { get => (string)TargettedRow[TableColumnNames.IdentificationNo.ToString()]; }


       public string FirstName { get => (string)TargettedRow[TableColumnNames.FirstName.ToString()]; }


       public string LastName { get => (string)TargettedRow[TableColumnNames.LastName.ToString()]; }


       public int CountryID { get => (int)TargettedRow[TableColumnNames.CountryID.ToString()]; }


       public DateTime DateOfBirth { get => (DateTime)TargettedRow[TableColumnNames.DateOfBirth.ToString()]; }


       public int GenderID { get => (int)TargettedRow[TableColumnNames.GenderID.ToString()]; }


       public string HomeAddress { get => (string)TargettedRow[TableColumnNames.HomeAddress.ToString()]; }


       public string Email { get => (string)TargettedRow[TableColumnNames.Email.ToString()]; }


       public int? PersonTitleID { get => (int?)TargettedRow[TableColumnNames.PersonTitleID.ToString()]; }


       public bool IsSuperUser { get => (bool)TargettedRow[TableColumnNames.IsSuperUser.ToString()]; }


       public int? BloodTypeID { get => (int?)TargettedRow[TableColumnNames.BloodTypeID.ToString()]; }


       public string BirthPlace { get => (string)TargettedRow[TableColumnNames.BirthPlace.ToString()]; }


       public string PictureFileName { get => (string)TargettedRow[TableColumnNames.PictureFileName.ToString()]; }


       public int MaritalStatusID { get => (int)TargettedRow[TableColumnNames.MaritalStatusID.ToString()]; }


       public bool CanBeUpdated { get => (bool)TargettedRow[TableColumnNames.CanBeUpdated.ToString()]; }


       public bool CanBeDeleted { get => (bool)TargettedRow[TableColumnNames.CanBeDeleted.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


       public int? DataMonitorID { get => (int?)TargettedRow[TableColumnNames.DataMonitorID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Person GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Person GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Person GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Person(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Person GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Person__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            string IdentificationNo,
            string FirstName,
            string LastName,
            int CountryID,
            DateTime DateOfBirth,
            int GenderID,
            bool IsSuperUser,
            int MaritalStatusID,
            bool CanBeUpdated,
            bool CanBeDeleted,
            DateTime CreatedAt,
            string HomeAddress = null,
            string Email = null,
            int? PersonTitleID = null,
            int? BloodTypeID = null,
            string BirthPlace = null,
            string PictureFileName = null,
            DateTime? UpdatedAt = null,
            int? DataMonitorID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramIdentificationNo = new (defIdentificationNo, IdentificationNo);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramCountryID = new (defCountryID, CountryID);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramGenderID = new (defGenderID, GenderID);
                DataColumnParameter paramHomeAddress = new (defHomeAddress, HomeAddress);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramPersonTitleID = new (defPersonTitleID, PersonTitleID);
                DataColumnParameter paramIsSuperUser = new (defIsSuperUser, IsSuperUser);
                DataColumnParameter paramBloodTypeID = new (defBloodTypeID, BloodTypeID);
                DataColumnParameter paramBirthPlace = new (defBirthPlace, BirthPlace);
                DataColumnParameter paramPictureFileName = new (defPictureFileName, PictureFileName);
                DataColumnParameter paramMaritalStatusID = new (defMaritalStatusID, MaritalStatusID);
                DataColumnParameter paramCanBeUpdated = new (defCanBeUpdated, CanBeUpdated);
                DataColumnParameter paramCanBeDeleted = new (defCanBeDeleted, CanBeDeleted);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19})  ", TABLE_NAME,
                        paramIdentificationNo.GetSQLQuotedValueForAdd(),
                        paramFirstName.GetSQLQuotedValueForAdd(),
                        paramLastName.GetSQLQuotedValueForAdd(),
                        paramCountryID.GetSQLQuotedValueForAdd(),
                        paramDateOfBirth.GetSQLQuotedValueForAdd(),
                        paramGenderID.GetSQLQuotedValueForAdd(),
                        paramHomeAddress.GetSQLQuotedValueForAdd(),
                        paramEmail.GetSQLQuotedValueForAdd(),
                        paramPersonTitleID.GetSQLQuotedValueForAdd(),
                        paramIsSuperUser.GetSQLQuotedValueForAdd(),
                        paramBloodTypeID.GetSQLQuotedValueForAdd(),
                        paramBirthPlace.GetSQLQuotedValueForAdd(),
                        paramPictureFileName.GetSQLQuotedValueForAdd(),
                        paramMaritalStatusID.GetSQLQuotedValueForAdd(),
                        paramCanBeUpdated.GetSQLQuotedValueForAdd(),
                        paramCanBeDeleted.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramDataMonitorID.GetSQLQuotedValueForAdd()                        )
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
            string IdentificationNo,
            string FirstName,
            string LastName,
            int CountryID,
            DateTime DateOfBirth,
            int GenderID,
            bool IsSuperUser,
            int MaritalStatusID,
            bool CanBeUpdated,
            bool CanBeDeleted,
            DateTime CreatedAt,
            string HomeAddress = null,
            string Email = null,
            int? PersonTitleID = null,
            int? BloodTypeID = null,
            string BirthPlace = null,
            string PictureFileName = null,
            DateTime? UpdatedAt = null,
            int? DataMonitorID = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramIdentificationNo = new (defIdentificationNo, IdentificationNo);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramCountryID = new (defCountryID, CountryID);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramGenderID = new (defGenderID, GenderID);
                DataColumnParameter paramHomeAddress = new (defHomeAddress, HomeAddress);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramPersonTitleID = new (defPersonTitleID, PersonTitleID);
                DataColumnParameter paramIsSuperUser = new (defIsSuperUser, IsSuperUser);
                DataColumnParameter paramBloodTypeID = new (defBloodTypeID, BloodTypeID);
                DataColumnParameter paramBirthPlace = new (defBirthPlace, BirthPlace);
                DataColumnParameter paramPictureFileName = new (defPictureFileName, PictureFileName);
                DataColumnParameter paramMaritalStatusID = new (defMaritalStatusID, MaritalStatusID);
                DataColumnParameter paramCanBeUpdated = new (defCanBeUpdated, CanBeUpdated);
                DataColumnParameter paramCanBeDeleted = new (defCanBeDeleted, CanBeDeleted);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramIdentificationNo.GetSQLQuotedValueForAdd(),
                        paramFirstName.GetSQLQuotedValueForAdd(),
                        paramLastName.GetSQLQuotedValueForAdd(),
                        paramCountryID.GetSQLQuotedValueForAdd(),
                        paramDateOfBirth.GetSQLQuotedValueForAdd(),
                        paramGenderID.GetSQLQuotedValueForAdd(),
                        paramHomeAddress.GetSQLQuotedValueForAdd(),
                        paramEmail.GetSQLQuotedValueForAdd(),
                        paramPersonTitleID.GetSQLQuotedValueForAdd(),
                        paramIsSuperUser.GetSQLQuotedValueForAdd(),
                        paramBloodTypeID.GetSQLQuotedValueForAdd(),
                        paramBirthPlace.GetSQLQuotedValueForAdd(),
                        paramPictureFileName.GetSQLQuotedValueForAdd(),
                        paramMaritalStatusID.GetSQLQuotedValueForAdd(),
                        paramCanBeUpdated.GetSQLQuotedValueForAdd(),
                        paramCanBeDeleted.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramDataMonitorID.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
