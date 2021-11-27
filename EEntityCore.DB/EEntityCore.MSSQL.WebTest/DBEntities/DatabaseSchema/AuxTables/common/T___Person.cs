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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.common                  
{                  

    public class T___Person : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Person()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defIdentificationNo = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IdentificationNo.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defFirstName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FirstName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LastName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountryID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CountryID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDateOfBirth = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DateOfBirth.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGenderID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.GenderID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defHomeAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.HomeAddress.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Email.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defPersonTitleID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonTitleID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIsSuperUser = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsSuperUser.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBloodTypeID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BloodTypeID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBirthPlace = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BirthPlace.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PictureFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMaritalStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MaritalStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCanBeUpdated = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CanBeUpdated.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCanBeDeleted = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CanBeDeleted.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDataMonitorID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DataMonitorID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


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

       public String IdentificationNo {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IdentificationNo.ToString()]);
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


       public Int32 CountryID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CountryID.ToString()]);
           }
       }


       public NullableDateTime DateOfBirth {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.DateOfBirth.ToString()]);
           }
       }


       public Int32 GenderID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.GenderID.ToString()]);
           }
       }


       public String HomeAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.HomeAddress.ToString()]);
           }
       }


       public String Email {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Email.ToString()]);
           }
       }


       public Int32 PersonTitleID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonTitleID.ToString()]);
           }
       }


       public Boolean IsSuperUser {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsSuperUser.ToString()]);
           }
       }


       public Int32 BloodTypeID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BloodTypeID.ToString()]);
           }
       }


       public String BirthPlace {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BirthPlace.ToString()]);
           }
       }


       public String PictureFileName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PictureFileName.ToString()]);
           }
       }


       public Int32 MaritalStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.MaritalStatusID.ToString()]);
           }
       }


       public Boolean CanBeUpdated {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.CanBeUpdated.ToString()]);
           }
       }


       public Boolean CanBeDeleted {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.CanBeDeleted.ToString()]);
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


       public Int32 DataMonitorID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DataMonitorID.ToString()]);
           }
       }


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
                  
                  




        public static int AddNewDefault(String pIdentificationNo,
Int32 pCountryID,
Int32 pGenderID,
String pEmail,
Int32 pPersonTitleID,
Int32 pBloodTypeID,
Int32 pMaritalStatusID,
Int32 pDataMonitorID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramIdentificationNo = new DataColumnParameter(defIdentificationNo, pIdentificationNo);
                DataColumnParameter paramCountryID = new DataColumnParameter(defCountryID, pCountryID);
                DataColumnParameter paramGenderID = new DataColumnParameter(defGenderID, pGenderID);
                DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
                DataColumnParameter paramPersonTitleID = new DataColumnParameter(defPersonTitleID, pPersonTitleID);
                DataColumnParameter paramBloodTypeID = new DataColumnParameter(defBloodTypeID, pBloodTypeID);
                DataColumnParameter paramMaritalStatusID = new DataColumnParameter(defMaritalStatusID, pMaritalStatusID);
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
                DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, defFirstName.DefaultValue);
                DataColumnParameter paramLastName = new DataColumnParameter(defLastName, defLastName.DefaultValue);
                DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, defDateOfBirth.DefaultValue);
                DataColumnParameter paramHomeAddress = new DataColumnParameter(defHomeAddress, defHomeAddress.DefaultValue);
                DataColumnParameter paramIsSuperUser = new DataColumnParameter(defIsSuperUser, defIsSuperUser.DefaultValue);
                DataColumnParameter paramBirthPlace = new DataColumnParameter(defBirthPlace, defBirthPlace.DefaultValue);
                DataColumnParameter paramPictureFileName = new DataColumnParameter(defPictureFileName, defPictureFileName.DefaultValue);
                DataColumnParameter paramCanBeUpdated = new DataColumnParameter(defCanBeUpdated, defCanBeUpdated.DefaultValue);
                DataColumnParameter paramCanBeDeleted = new DataColumnParameter(defCanBeDeleted, defCanBeDeleted.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
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
                paramDataMonitorID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pIdentificationNo,
String pFirstName,
String pLastName,
Int32 pCountryID,
DateTime pDateOfBirth,
Int32 pGenderID,
Boolean pIsSuperUser,
Int32 pMaritalStatusID,
Boolean pCanBeUpdated,
Boolean pCanBeDeleted,
DateTime pCreatedAt,
Object pHomeAddress = null,
Object pEmail = null,
Object pPersonTitleID = null,
Object pBloodTypeID = null,
Object pBirthPlace = null,
Object pPictureFileName = null,
Object pUpdatedAt = null,
Object pDataMonitorID = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramIdentificationNo = new DataColumnParameter(defIdentificationNo, pIdentificationNo);
                DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
                DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
                DataColumnParameter paramCountryID = new DataColumnParameter(defCountryID, pCountryID);
                DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
                DataColumnParameter paramGenderID = new DataColumnParameter(defGenderID, pGenderID);
                DataColumnParameter paramHomeAddress = new DataColumnParameter(defHomeAddress, pHomeAddress);
                DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
                DataColumnParameter paramPersonTitleID = new DataColumnParameter(defPersonTitleID, pPersonTitleID);
                DataColumnParameter paramIsSuperUser = new DataColumnParameter(defIsSuperUser, pIsSuperUser);
                DataColumnParameter paramBloodTypeID = new DataColumnParameter(defBloodTypeID, pBloodTypeID);
                DataColumnParameter paramBirthPlace = new DataColumnParameter(defBirthPlace, pBirthPlace);
                DataColumnParameter paramPictureFileName = new DataColumnParameter(defPictureFileName, pPictureFileName);
                DataColumnParameter paramMaritalStatusID = new DataColumnParameter(defMaritalStatusID, pMaritalStatusID);
                DataColumnParameter paramCanBeUpdated = new DataColumnParameter(defCanBeUpdated, pCanBeUpdated);
                DataColumnParameter paramCanBeDeleted = new DataColumnParameter(defCanBeDeleted, pCanBeDeleted);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramDataMonitorID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pIdentificationNo,
String pFirstName,
String pLastName,
Int32 pCountryID,
DateTime pDateOfBirth,
Int32 pGenderID,
Boolean pIsSuperUser,
Int32 pMaritalStatusID,
Boolean pCanBeUpdated,
Boolean pCanBeDeleted,
DateTime pCreatedAt,
Object pHomeAddress = null,
Object pEmail = null,
Object pPersonTitleID = null,
Object pBloodTypeID = null,
Object pBirthPlace = null,
Object pPictureFileName = null,
Object pUpdatedAt = null,
Object pDataMonitorID = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramIdentificationNo = new DataColumnParameter(defIdentificationNo, pIdentificationNo);
DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
DataColumnParameter paramCountryID = new DataColumnParameter(defCountryID, pCountryID);
DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
DataColumnParameter paramGenderID = new DataColumnParameter(defGenderID, pGenderID);
DataColumnParameter paramHomeAddress = new DataColumnParameter(defHomeAddress, pHomeAddress);
DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
DataColumnParameter paramPersonTitleID = new DataColumnParameter(defPersonTitleID, pPersonTitleID);
DataColumnParameter paramIsSuperUser = new DataColumnParameter(defIsSuperUser, pIsSuperUser);
DataColumnParameter paramBloodTypeID = new DataColumnParameter(defBloodTypeID, pBloodTypeID);
DataColumnParameter paramBirthPlace = new DataColumnParameter(defBirthPlace, pBirthPlace);
DataColumnParameter paramPictureFileName = new DataColumnParameter(defPictureFileName, pPictureFileName);
DataColumnParameter paramMaritalStatusID = new DataColumnParameter(defMaritalStatusID, pMaritalStatusID);
DataColumnParameter paramCanBeUpdated = new DataColumnParameter(defCanBeUpdated, pCanBeUpdated);
DataColumnParameter paramCanBeDeleted = new DataColumnParameter(defCanBeDeleted, pCanBeDeleted);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
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
paramDataMonitorID.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pIdentificationNo,
String pFirstName,
String pLastName,
Int32 pCountryID,
DateTime pDateOfBirth,
Int32 pGenderID,
Boolean pIsSuperUser,
Int32 pMaritalStatusID,
Boolean pCanBeUpdated,
Boolean pCanBeDeleted,
DateTime pCreatedAt,
Object pHomeAddress= null,
Object pEmail= null,
Object pPersonTitleID= null,
Object pBloodTypeID= null,
Object pBirthPlace= null,
Object pPictureFileName= null,
Object pUpdatedAt= null,
Object pDataMonitorID= null){

        try{

DataColumnParameter paramIdentificationNo = new DataColumnParameter(defIdentificationNo, pIdentificationNo);
DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
DataColumnParameter paramCountryID = new DataColumnParameter(defCountryID, pCountryID);
DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
DataColumnParameter paramGenderID = new DataColumnParameter(defGenderID, pGenderID);
DataColumnParameter paramHomeAddress = new DataColumnParameter(defHomeAddress, pHomeAddress);
DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
DataColumnParameter paramPersonTitleID = new DataColumnParameter(defPersonTitleID, pPersonTitleID);
DataColumnParameter paramIsSuperUser = new DataColumnParameter(defIsSuperUser, pIsSuperUser);
DataColumnParameter paramBloodTypeID = new DataColumnParameter(defBloodTypeID, pBloodTypeID);
DataColumnParameter paramBirthPlace = new DataColumnParameter(defBirthPlace, pBirthPlace);
DataColumnParameter paramPictureFileName = new DataColumnParameter(defPictureFileName, pPictureFileName);
DataColumnParameter paramMaritalStatusID = new DataColumnParameter(defMaritalStatusID, pMaritalStatusID);
DataColumnParameter paramCanBeUpdated = new DataColumnParameter(defCanBeUpdated, pCanBeUpdated);
DataColumnParameter paramCanBeDeleted = new DataColumnParameter(defCanBeDeleted, pCanBeDeleted);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19}) ", TABLE_NAME,paramIdentificationNo.GetSQLQuotedValueForAdd(),
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
paramDataMonitorID.GetSQLQuotedValueForAdd()  ), true);


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
Object pIdentificationNo = null,
Object pFirstName = null,
Object pLastName = null,
Object pCountryID = null,
Object pDateOfBirth = null,
Object pGenderID = null,
Object pIsSuperUser = null,
Object pMaritalStatusID = null,
Object pCanBeUpdated = null,
Object pCanBeDeleted = null,
Object pCreatedAt = null,
Object pHomeAddress = null,
Object pEmail = null,
Object pPersonTitleID = null,
Object pBloodTypeID = null,
Object pBirthPlace = null,
Object pPictureFileName = null,
Object pUpdatedAt = null,
Object pDataMonitorID = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramIdentificationNo = new DataColumnParameter(defIdentificationNo, pIdentificationNo);
 DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
 DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
 DataColumnParameter paramCountryID = new DataColumnParameter(defCountryID, pCountryID);
 DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
 DataColumnParameter paramGenderID = new DataColumnParameter(defGenderID, pGenderID);
 DataColumnParameter paramHomeAddress = new DataColumnParameter(defHomeAddress, pHomeAddress);
 DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
 DataColumnParameter paramPersonTitleID = new DataColumnParameter(defPersonTitleID, pPersonTitleID);
 DataColumnParameter paramIsSuperUser = new DataColumnParameter(defIsSuperUser, pIsSuperUser);
 DataColumnParameter paramBloodTypeID = new DataColumnParameter(defBloodTypeID, pBloodTypeID);
 DataColumnParameter paramBirthPlace = new DataColumnParameter(defBirthPlace, pBirthPlace);
 DataColumnParameter paramPictureFileName = new DataColumnParameter(defPictureFileName, pPictureFileName);
 DataColumnParameter paramMaritalStatusID = new DataColumnParameter(defMaritalStatusID, pMaritalStatusID);
 DataColumnParameter paramCanBeUpdated = new DataColumnParameter(defCanBeUpdated, pCanBeUpdated);
 DataColumnParameter paramCanBeDeleted = new DataColumnParameter(defCanBeDeleted, pCanBeDeleted);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [IdentificationNo]={2},[FirstName]={3},[LastName]={4},[CountryID]={5},[DateOfBirth]={6},[GenderID]={7},[HomeAddress]={8},[Email]={9},[PersonTitleID]={10},[IsSuperUser]={11},[BloodTypeID]={12},[BirthPlace]={13},[PictureFileName]={14},[MaritalStatusID]={15},[CanBeUpdated]={16},[CanBeDeleted]={17},[CreatedAt]={18},[UpdatedAt]={19},[DataMonitorID]={20} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramIdentificationNo.GetSQLQuotedValueForUpdate(),
paramFirstName.GetSQLQuotedValueForUpdate(),
paramLastName.GetSQLQuotedValueForUpdate(),
paramCountryID.GetSQLQuotedValueForUpdate(),
paramDateOfBirth.GetSQLQuotedValueForUpdate(),
paramGenderID.GetSQLQuotedValueForUpdate(),
paramHomeAddress.GetSQLQuotedValueForUpdate(),
paramEmail.GetSQLQuotedValueForUpdate(),
paramPersonTitleID.GetSQLQuotedValueForUpdate(),
paramIsSuperUser.GetSQLQuotedValueForUpdate(),
paramBloodTypeID.GetSQLQuotedValueForUpdate(),
paramBirthPlace.GetSQLQuotedValueForUpdate(),
paramPictureFileName.GetSQLQuotedValueForUpdate(),
paramMaritalStatusID.GetSQLQuotedValueForUpdate(),
paramCanBeUpdated.GetSQLQuotedValueForUpdate(),
paramCanBeDeleted.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramDataMonitorID.GetSQLQuotedValueForUpdate()  ), true);


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
