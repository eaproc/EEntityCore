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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.import                  
{                  

    public class T___CommonPerson : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___CommonPerson()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defDataMonitorID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DataMonitorID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defImportStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ImportStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIdentificationNo = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IdentificationNo.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonTitle = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonTitle.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FirstName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LastName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountry = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Country.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDateOfBirth = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DateOfBirth.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGender = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Gender.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomeAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.HomeAddress.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Email.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBirthPlace = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BirthPlace.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobileAreaCode = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MobileAreaCode.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobileNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MobileNumber.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defImportComment = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ImportComment.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID); 
          ColumnDefns.Add(defImportStatusID.ColumnName, defImportStatusID); 
          ColumnDefns.Add(defIdentificationNo.ColumnName, defIdentificationNo); 
          ColumnDefns.Add(defPersonTitle.ColumnName, defPersonTitle); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defCountry.ColumnName, defCountry); 
          ColumnDefns.Add(defDateOfBirth.ColumnName, defDateOfBirth); 
          ColumnDefns.Add(defGender.ColumnName, defGender); 
          ColumnDefns.Add(defHomeAddress.ColumnName, defHomeAddress); 
          ColumnDefns.Add(defEmail.ColumnName, defEmail); 
          ColumnDefns.Add(defBirthPlace.ColumnName, defBirthPlace); 
          ColumnDefns.Add(defMobileAreaCode.ColumnName, defMobileAreaCode); 
          ColumnDefns.Add(defMobileNumber.ColumnName, defMobileNumber); 
          ColumnDefns.Add(defImportComment.ColumnName, defImportComment); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_CommonPerson_DataMonitorID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "import.CommonPerson", "import.DataMonitor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_CommonPerson_ImportStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.CommonPerson", "import.ImportStatus"                  
                            ));                  

          }


                  
       public T___CommonPerson() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CommonPerson(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___CommonPerson(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CommonPerson(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CommonPerson(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___CommonPerson(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CommonPerson(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CommonPerson(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CommonPerson(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___CommonPerson(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "import.CommonPerson";
       public const string CommonPerson__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [DataMonitorID], [ImportStatusID], [IdentificationNo], [PersonTitle], [FirstName], [LastName], [Country], [DateOfBirth], [Gender], [HomeAddress], [Email], [BirthPlace], [MobileAreaCode], [MobileNumber], [ImportComment], [CreatedAt] FROM CommonPerson";
       public const string CommonPerson__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [DataMonitorID], [ImportStatusID], [IdentificationNo], [PersonTitle], [FirstName], [LastName], [Country], [DateOfBirth], [Gender], [HomeAddress], [Email], [BirthPlace], [MobileAreaCode], [MobileNumber], [ImportComment], [CreatedAt] FROM CommonPerson";


       public enum TableColumnNames
       {

           ID,
           DataMonitorID,
           ImportStatusID,
           IdentificationNo,
           PersonTitle,
           FirstName,
           LastName,
           Country,
           DateOfBirth,
           Gender,
           HomeAddress,
           Email,
           BirthPlace,
           MobileAreaCode,
           MobileNumber,
           ImportComment,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_import_CommonPerson, 
           fk_import_CommonPerson_DataMonitorID, 
           fk_import_CommonPerson_ImportStatusID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDataMonitorID;
       public static readonly DataColumnDefinition defImportStatusID;
       public static readonly DataColumnDefinition defIdentificationNo;
       public static readonly DataColumnDefinition defPersonTitle;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defCountry;
       public static readonly DataColumnDefinition defDateOfBirth;
       public static readonly DataColumnDefinition defGender;
       public static readonly DataColumnDefinition defHomeAddress;
       public static readonly DataColumnDefinition defEmail;
       public static readonly DataColumnDefinition defBirthPlace;
       public static readonly DataColumnDefinition defMobileAreaCode;
       public static readonly DataColumnDefinition defMobileNumber;
       public static readonly DataColumnDefinition defImportComment;
       public static readonly DataColumnDefinition defCreatedAt;

       public Int32 DataMonitorID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DataMonitorID.ToString()]);
           }
       }


       public Int32 ImportStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ImportStatusID.ToString()]);
           }
       }


       public String IdentificationNo {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IdentificationNo.ToString()]);
           }
       }


       public String PersonTitle {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PersonTitle.ToString()]);
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


       public String Country {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Country.ToString()]);
           }
       }


       public NullableDateTime DateOfBirth {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.DateOfBirth.ToString()]);
           }
       }


       public String Gender {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Gender.ToString()]);
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


       public String BirthPlace {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.BirthPlace.ToString()]);
           }
       }


       public String MobileAreaCode {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.MobileAreaCode.ToString()]);
           }
       }


       public String MobileNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.MobileNumber.ToString()]);
           }
       }


       public String ImportComment {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.ImportComment.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___CommonPerson GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___CommonPerson GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___CommonPerson GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___CommonPerson(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___CommonPerson GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => CommonPerson__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pDataMonitorID,
Int32 pImportStatusID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
                DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
                DataColumnParameter paramIdentificationNo = new DataColumnParameter(defIdentificationNo, defIdentificationNo.DefaultValue);
                DataColumnParameter paramPersonTitle = new DataColumnParameter(defPersonTitle, defPersonTitle.DefaultValue);
                DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, defFirstName.DefaultValue);
                DataColumnParameter paramLastName = new DataColumnParameter(defLastName, defLastName.DefaultValue);
                DataColumnParameter paramCountry = new DataColumnParameter(defCountry, defCountry.DefaultValue);
                DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, defDateOfBirth.DefaultValue);
                DataColumnParameter paramGender = new DataColumnParameter(defGender, defGender.DefaultValue);
                DataColumnParameter paramHomeAddress = new DataColumnParameter(defHomeAddress, defHomeAddress.DefaultValue);
                DataColumnParameter paramEmail = new DataColumnParameter(defEmail, defEmail.DefaultValue);
                DataColumnParameter paramBirthPlace = new DataColumnParameter(defBirthPlace, defBirthPlace.DefaultValue);
                DataColumnParameter paramMobileAreaCode = new DataColumnParameter(defMobileAreaCode, defMobileAreaCode.DefaultValue);
                DataColumnParameter paramMobileNumber = new DataColumnParameter(defMobileNumber, defMobileNumber.DefaultValue);
                DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, defImportComment.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramDataMonitorID.GetSQLQuotedValueForAdd(),
                paramImportStatusID.GetSQLQuotedValueForAdd(),
                paramIdentificationNo.GetSQLQuotedValueForAdd(),
                paramPersonTitle.GetSQLQuotedValueForAdd(),
                paramFirstName.GetSQLQuotedValueForAdd(),
                paramLastName.GetSQLQuotedValueForAdd(),
                paramCountry.GetSQLQuotedValueForAdd(),
                paramDateOfBirth.GetSQLQuotedValueForAdd(),
                paramGender.GetSQLQuotedValueForAdd(),
                paramHomeAddress.GetSQLQuotedValueForAdd(),
                paramEmail.GetSQLQuotedValueForAdd(),
                paramBirthPlace.GetSQLQuotedValueForAdd(),
                paramMobileAreaCode.GetSQLQuotedValueForAdd(),
                paramMobileNumber.GetSQLQuotedValueForAdd(),
                paramImportComment.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pDataMonitorID,
Int32 pImportStatusID,
String pIdentificationNo,
String pPersonTitle,
String pFirstName,
String pLastName,
String pCountry,
DateTime pDateOfBirth,
String pGender,
String pImportComment,
DateTime pCreatedAt,
Object pHomeAddress = null,
Object pEmail = null,
Object pBirthPlace = null,
Object pMobileAreaCode = null,
Object pMobileNumber = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
                DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
                DataColumnParameter paramIdentificationNo = new DataColumnParameter(defIdentificationNo, pIdentificationNo);
                DataColumnParameter paramPersonTitle = new DataColumnParameter(defPersonTitle, pPersonTitle);
                DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
                DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
                DataColumnParameter paramCountry = new DataColumnParameter(defCountry, pCountry);
                DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
                DataColumnParameter paramGender = new DataColumnParameter(defGender, pGender);
                DataColumnParameter paramHomeAddress = new DataColumnParameter(defHomeAddress, pHomeAddress);
                DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
                DataColumnParameter paramBirthPlace = new DataColumnParameter(defBirthPlace, pBirthPlace);
                DataColumnParameter paramMobileAreaCode = new DataColumnParameter(defMobileAreaCode, pMobileAreaCode);
                DataColumnParameter paramMobileNumber = new DataColumnParameter(defMobileNumber, pMobileNumber);
                DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramDataMonitorID.GetSQLQuotedValueForAdd(),
paramImportStatusID.GetSQLQuotedValueForAdd(),
paramIdentificationNo.GetSQLQuotedValueForAdd(),
paramPersonTitle.GetSQLQuotedValueForAdd(),
paramFirstName.GetSQLQuotedValueForAdd(),
paramLastName.GetSQLQuotedValueForAdd(),
paramCountry.GetSQLQuotedValueForAdd(),
paramDateOfBirth.GetSQLQuotedValueForAdd(),
paramGender.GetSQLQuotedValueForAdd(),
paramHomeAddress.GetSQLQuotedValueForAdd(),
paramEmail.GetSQLQuotedValueForAdd(),
paramBirthPlace.GetSQLQuotedValueForAdd(),
paramMobileAreaCode.GetSQLQuotedValueForAdd(),
paramMobileNumber.GetSQLQuotedValueForAdd(),
paramImportComment.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pDataMonitorID,
Int32 pImportStatusID,
String pIdentificationNo,
String pPersonTitle,
String pFirstName,
String pLastName,
String pCountry,
DateTime pDateOfBirth,
String pGender,
String pImportComment,
DateTime pCreatedAt,
Object pHomeAddress = null,
Object pEmail = null,
Object pBirthPlace = null,
Object pMobileAreaCode = null,
Object pMobileNumber = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
DataColumnParameter paramIdentificationNo = new DataColumnParameter(defIdentificationNo, pIdentificationNo);
DataColumnParameter paramPersonTitle = new DataColumnParameter(defPersonTitle, pPersonTitle);
DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
DataColumnParameter paramCountry = new DataColumnParameter(defCountry, pCountry);
DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
DataColumnParameter paramGender = new DataColumnParameter(defGender, pGender);
DataColumnParameter paramHomeAddress = new DataColumnParameter(defHomeAddress, pHomeAddress);
DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
DataColumnParameter paramBirthPlace = new DataColumnParameter(defBirthPlace, pBirthPlace);
DataColumnParameter paramMobileAreaCode = new DataColumnParameter(defMobileAreaCode, pMobileAreaCode);
DataColumnParameter paramMobileNumber = new DataColumnParameter(defMobileNumber, pMobileNumber);
DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramDataMonitorID.GetSQLQuotedValueForAdd(),
paramImportStatusID.GetSQLQuotedValueForAdd(),
paramIdentificationNo.GetSQLQuotedValueForAdd(),
paramPersonTitle.GetSQLQuotedValueForAdd(),
paramFirstName.GetSQLQuotedValueForAdd(),
paramLastName.GetSQLQuotedValueForAdd(),
paramCountry.GetSQLQuotedValueForAdd(),
paramDateOfBirth.GetSQLQuotedValueForAdd(),
paramGender.GetSQLQuotedValueForAdd(),
paramHomeAddress.GetSQLQuotedValueForAdd(),
paramEmail.GetSQLQuotedValueForAdd(),
paramBirthPlace.GetSQLQuotedValueForAdd(),
paramMobileAreaCode.GetSQLQuotedValueForAdd(),
paramMobileNumber.GetSQLQuotedValueForAdd(),
paramImportComment.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pDataMonitorID,
Int32 pImportStatusID,
String pIdentificationNo,
String pPersonTitle,
String pFirstName,
String pLastName,
String pCountry,
DateTime pDateOfBirth,
String pGender,
String pImportComment,
DateTime pCreatedAt,
Object pHomeAddress= null,
Object pEmail= null,
Object pBirthPlace= null,
Object pMobileAreaCode= null,
Object pMobileNumber= null){

        try{

DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
DataColumnParameter paramIdentificationNo = new DataColumnParameter(defIdentificationNo, pIdentificationNo);
DataColumnParameter paramPersonTitle = new DataColumnParameter(defPersonTitle, pPersonTitle);
DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
DataColumnParameter paramCountry = new DataColumnParameter(defCountry, pCountry);
DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
DataColumnParameter paramGender = new DataColumnParameter(defGender, pGender);
DataColumnParameter paramHomeAddress = new DataColumnParameter(defHomeAddress, pHomeAddress);
DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
DataColumnParameter paramBirthPlace = new DataColumnParameter(defBirthPlace, pBirthPlace);
DataColumnParameter paramMobileAreaCode = new DataColumnParameter(defMobileAreaCode, pMobileAreaCode);
DataColumnParameter paramMobileNumber = new DataColumnParameter(defMobileNumber, pMobileNumber);
DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) ", TABLE_NAME,paramDataMonitorID.GetSQLQuotedValueForAdd(),
paramImportStatusID.GetSQLQuotedValueForAdd(),
paramIdentificationNo.GetSQLQuotedValueForAdd(),
paramPersonTitle.GetSQLQuotedValueForAdd(),
paramFirstName.GetSQLQuotedValueForAdd(),
paramLastName.GetSQLQuotedValueForAdd(),
paramCountry.GetSQLQuotedValueForAdd(),
paramDateOfBirth.GetSQLQuotedValueForAdd(),
paramGender.GetSQLQuotedValueForAdd(),
paramHomeAddress.GetSQLQuotedValueForAdd(),
paramEmail.GetSQLQuotedValueForAdd(),
paramBirthPlace.GetSQLQuotedValueForAdd(),
paramMobileAreaCode.GetSQLQuotedValueForAdd(),
paramMobileNumber.GetSQLQuotedValueForAdd(),
paramImportComment.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);


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
Object pDataMonitorID = null,
Object pImportStatusID = null,
Object pIdentificationNo = null,
Object pPersonTitle = null,
Object pFirstName = null,
Object pLastName = null,
Object pCountry = null,
Object pDateOfBirth = null,
Object pGender = null,
Object pImportComment = null,
Object pCreatedAt = null,
Object pHomeAddress = null,
Object pEmail = null,
Object pBirthPlace = null,
Object pMobileAreaCode = null,
Object pMobileNumber = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
 DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
 DataColumnParameter paramIdentificationNo = new DataColumnParameter(defIdentificationNo, pIdentificationNo);
 DataColumnParameter paramPersonTitle = new DataColumnParameter(defPersonTitle, pPersonTitle);
 DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
 DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
 DataColumnParameter paramCountry = new DataColumnParameter(defCountry, pCountry);
 DataColumnParameter paramDateOfBirth = new DataColumnParameter(defDateOfBirth, pDateOfBirth);
 DataColumnParameter paramGender = new DataColumnParameter(defGender, pGender);
 DataColumnParameter paramHomeAddress = new DataColumnParameter(defHomeAddress, pHomeAddress);
 DataColumnParameter paramEmail = new DataColumnParameter(defEmail, pEmail);
 DataColumnParameter paramBirthPlace = new DataColumnParameter(defBirthPlace, pBirthPlace);
 DataColumnParameter paramMobileAreaCode = new DataColumnParameter(defMobileAreaCode, pMobileAreaCode);
 DataColumnParameter paramMobileNumber = new DataColumnParameter(defMobileNumber, pMobileNumber);
 DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [DataMonitorID]={2},[ImportStatusID]={3},[IdentificationNo]={4},[PersonTitle]={5},[FirstName]={6},[LastName]={7},[Country]={8},[DateOfBirth]={9},[Gender]={10},[HomeAddress]={11},[Email]={12},[BirthPlace]={13},[MobileAreaCode]={14},[MobileNumber]={15},[ImportComment]={16},[CreatedAt]={17} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramDataMonitorID.GetSQLQuotedValueForUpdate(),
paramImportStatusID.GetSQLQuotedValueForUpdate(),
paramIdentificationNo.GetSQLQuotedValueForUpdate(),
paramPersonTitle.GetSQLQuotedValueForUpdate(),
paramFirstName.GetSQLQuotedValueForUpdate(),
paramLastName.GetSQLQuotedValueForUpdate(),
paramCountry.GetSQLQuotedValueForUpdate(),
paramDateOfBirth.GetSQLQuotedValueForUpdate(),
paramGender.GetSQLQuotedValueForUpdate(),
paramHomeAddress.GetSQLQuotedValueForUpdate(),
paramEmail.GetSQLQuotedValueForUpdate(),
paramBirthPlace.GetSQLQuotedValueForUpdate(),
paramMobileAreaCode.GetSQLQuotedValueForUpdate(),
paramMobileNumber.GetSQLQuotedValueForUpdate(),
paramImportComment.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate()  ), true);


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
