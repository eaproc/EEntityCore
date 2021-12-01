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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.import                  
{                  

    public class T___CommonPerson : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___CommonPerson()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defDataMonitorID = new DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defImportStatusID = new DataColumnDefinition(TableColumnNames.ImportStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIdentificationNo = new DataColumnDefinition(TableColumnNames.IdentificationNo.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonTitle = new DataColumnDefinition(TableColumnNames.PersonTitle.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCountry = new DataColumnDefinition(TableColumnNames.Country.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDateOfBirth = new DataColumnDefinition(TableColumnNames.DateOfBirth.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGender = new DataColumnDefinition(TableColumnNames.Gender.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHomeAddress = new DataColumnDefinition(TableColumnNames.HomeAddress.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEmail = new DataColumnDefinition(TableColumnNames.Email.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBirthPlace = new DataColumnDefinition(TableColumnNames.BirthPlace.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobileAreaCode = new DataColumnDefinition(TableColumnNames.MobileAreaCode.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMobileNumber = new DataColumnDefinition(TableColumnNames.MobileNumber.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defImportComment = new DataColumnDefinition(TableColumnNames.ImportComment.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


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
        public T___CommonPerson(DataTable FullTable, long TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CommonPerson(DataTable FullTable) : base(FullTable)                                    
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
       public const string CommonPerson__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [DataMonitorID], [ImportStatusID], [IdentificationNo], [PersonTitle], [FirstName], [LastName], [Country], [DateOfBirth], [Gender], [HomeAddress], [Email], [BirthPlace], [MobileAreaCode], [MobileNumber], [ImportComment], [CreatedAt] FROM import.CommonPerson";
       public const string CommonPerson__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [DataMonitorID], [ImportStatusID], [IdentificationNo], [PersonTitle], [FirstName], [LastName], [Country], [DateOfBirth], [Gender], [HomeAddress], [Email], [BirthPlace], [MobileAreaCode], [MobileNumber], [ImportComment], [CreatedAt] FROM import.CommonPerson";


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

       public int DataMonitorID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.DataMonitorID.ToString());  set => TargettedRow[TableColumnNames.DataMonitorID.ToString()] = value; }


       public int ImportStatusID { get => (int)TargettedRow.GetDBValueConverted<int>(TableColumnNames.ImportStatusID.ToString());  set => TargettedRow[TableColumnNames.ImportStatusID.ToString()] = value; }


       public string IdentificationNo { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.IdentificationNo.ToString());  set => TargettedRow[TableColumnNames.IdentificationNo.ToString()] = value; }


       public string PersonTitle { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.PersonTitle.ToString());  set => TargettedRow[TableColumnNames.PersonTitle.ToString()] = value; }


       public string FirstName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.FirstName.ToString());  set => TargettedRow[TableColumnNames.FirstName.ToString()] = value; }


       public string LastName { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.LastName.ToString());  set => TargettedRow[TableColumnNames.LastName.ToString()] = value; }


       public string Country { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Country.ToString());  set => TargettedRow[TableColumnNames.Country.ToString()] = value; }


       public DateTime DateOfBirth { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.DateOfBirth.ToString());  set => TargettedRow[TableColumnNames.DateOfBirth.ToString()] = value; }


       public string Gender { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Gender.ToString());  set => TargettedRow[TableColumnNames.Gender.ToString()] = value; }


       public string HomeAddress { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.HomeAddress.ToString());  set => TargettedRow[TableColumnNames.HomeAddress.ToString()] = value; }


       public string Email { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.Email.ToString());  set => TargettedRow[TableColumnNames.Email.ToString()] = value; }


       public string BirthPlace { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.BirthPlace.ToString());  set => TargettedRow[TableColumnNames.BirthPlace.ToString()] = value; }


       public string MobileAreaCode { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.MobileAreaCode.ToString());  set => TargettedRow[TableColumnNames.MobileAreaCode.ToString()] = value; }


       public string MobileNumber { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.MobileNumber.ToString());  set => TargettedRow[TableColumnNames.MobileNumber.ToString()] = value; }


       public string ImportComment { get => (string)TargettedRow.GetDBValueConverted<string>(TableColumnNames.ImportComment.ToString());  set => TargettedRow[TableColumnNames.ImportComment.ToString()] = value; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow.GetDBValueConverted<DateTime>(TableColumnNames.CreatedAt.ToString());  set => TargettedRow[TableColumnNames.CreatedAt.ToString()] = value; }


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
                                                                        
        public static T___CommonPerson GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___CommonPerson(conn.Fetch(CommonPerson__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___CommonPerson GetRowWhereIDUsingSQL(long pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___CommonPerson( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___CommonPerson GetRowWhereID(long pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => CommonPerson__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  

        #region Update Builder                  
                  
        public class UpdateQueryBuilder                  
        {                  
            private DataColumnParameter ParamID { get; }                  
            private DataColumnParameter ParamDataMonitorID;
            private DataColumnParameter ParamImportStatusID;
            private DataColumnParameter ParamIdentificationNo;
            private DataColumnParameter ParamPersonTitle;
            private DataColumnParameter ParamFirstName;
            private DataColumnParameter ParamLastName;
            private DataColumnParameter ParamCountry;
            private DataColumnParameter ParamDateOfBirth;
            private DataColumnParameter ParamGender;
            private DataColumnParameter ParamHomeAddress;
            private DataColumnParameter ParamEmail;
            private DataColumnParameter ParamBirthPlace;
            private DataColumnParameter ParamMobileAreaCode;
            private DataColumnParameter ParamMobileNumber;
            private DataColumnParameter ParamImportComment;
            private DataColumnParameter ParamCreatedAt;

                  
            public UpdateQueryBuilder(long ID)                  
            {                  
                ParamID = new(defID, ID);                  
            }                  

            public UpdateQueryBuilder( T___CommonPerson v):this(v.ID)                  
            {                  

                ParamDataMonitorID = new(defDataMonitorID, v.DataMonitorID);                  
                ParamImportStatusID = new(defImportStatusID, v.ImportStatusID);                  
                ParamIdentificationNo = new(defIdentificationNo, v.IdentificationNo);                  
                ParamPersonTitle = new(defPersonTitle, v.PersonTitle);                  
                ParamFirstName = new(defFirstName, v.FirstName);                  
                ParamLastName = new(defLastName, v.LastName);                  
                ParamCountry = new(defCountry, v.Country);                  
                ParamDateOfBirth = new(defDateOfBirth, v.DateOfBirth);                  
                ParamGender = new(defGender, v.Gender);                  
                ParamHomeAddress = new(defHomeAddress, v.HomeAddress);                  
                ParamEmail = new(defEmail, v.Email);                  
                ParamBirthPlace = new(defBirthPlace, v.BirthPlace);                  
                ParamMobileAreaCode = new(defMobileAreaCode, v.MobileAreaCode);                  
                ParamMobileNumber = new(defMobileNumber, v.MobileNumber);                  
                ParamImportComment = new(defImportComment, v.ImportComment);                  
                ParamCreatedAt = new(defCreatedAt, v.CreatedAt);                  
            }                  
                  
            public UpdateQueryBuilder SetDataMonitorID(int v)                  
            {                  
                ParamDataMonitorID = new(defDataMonitorID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetImportStatusID(int v)                  
            {                  
                ParamImportStatusID = new(defImportStatusID, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetIdentificationNo(string v)                  
            {                  
                ParamIdentificationNo = new(defIdentificationNo, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetPersonTitle(string v)                  
            {                  
                ParamPersonTitle = new(defPersonTitle, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetFirstName(string v)                  
            {                  
                ParamFirstName = new(defFirstName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetLastName(string v)                  
            {                  
                ParamLastName = new(defLastName, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCountry(string v)                  
            {                  
                ParamCountry = new(defCountry, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetDateOfBirth(DateTime v)                  
            {                  
                ParamDateOfBirth = new(defDateOfBirth, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetGender(string v)                  
            {                  
                ParamGender = new(defGender, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetHomeAddress(string v)                  
            {                  
                ParamHomeAddress = new(defHomeAddress, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetEmail(string v)                  
            {                  
                ParamEmail = new(defEmail, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetBirthPlace(string v)                  
            {                  
                ParamBirthPlace = new(defBirthPlace, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetMobileAreaCode(string v)                  
            {                  
                ParamMobileAreaCode = new(defMobileAreaCode, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetMobileNumber(string v)                  
            {                  
                ParamMobileNumber = new(defMobileNumber, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetImportComment(string v)                  
            {                  
                ParamImportComment = new(defImportComment, v);                  
                return this;                  
            }                  
                  
            public UpdateQueryBuilder SetCreatedAt(DateTime v)                  
            {                  
                ParamCreatedAt = new(defCreatedAt, v);                  
                return this;                  
            }                  

                  
            public string BuildSQL()                  
            {                  
                if (!this.CanUpdate()) throw new InvalidOperationException("Please, set at least a parameter to update.");                  
                  
                var p = this.GetTouchedColumns();                  
                System.Text.StringBuilder builder = new System.Text.StringBuilder($"UPDATE {TABLE_NAME} SET ");                  
                  
                foreach (var v in p) builder.Append($"{v.ColumnDefinition.ColumnName}={v.GetSQLQuotedValueForAdd()},");                  
                  
                builder = new System.Text.StringBuilder(builder.ToString().TrimEnd(','));                  
                builder.Append($" WHERE ID={ParamID.GetSQLQuotedValueForAdd()}");                  
                  
                return builder.ToString();                  
            }                  
                  
            public bool CanUpdate() => GetTouchedColumns().Count > 0;                  
                  
            private List<DataColumnParameter> GetTouchedColumns()                  
            {                  
                return this.GetType().GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)                  
                    .Where(x => x.GetValue(this) is DataColumnParameter)                  
                    .Select(x => (DataColumnParameter)x.GetValue(this))                  
                    .Where(x => !x.Equals(ParamID))                  
                    .ToList();                  
            }                  
                  
            public int Execute(DBTransaction trans = null)                  
            {                  
                return TransactionRunner.InvokeRun((conn) => conn.ExecuteTransactionQuery(this.BuildSQL()), trans);                  
            }                  
        }                  
                  
        #endregion                  
                  





        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int DataMonitorID,
            int ImportStatusID,
            string IdentificationNo,
            string PersonTitle,
            string FirstName,
            string LastName,
            string Country,
            DateTime DateOfBirth,
            string Gender,
            string ImportComment,
            DateTime CreatedAt,
            string HomeAddress = null,
            string Email = null,
            string BirthPlace = null,
            string MobileAreaCode = null,
            string MobileNumber = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);
                DataColumnParameter paramImportStatusID = new (defImportStatusID, ImportStatusID);
                DataColumnParameter paramIdentificationNo = new (defIdentificationNo, IdentificationNo);
                DataColumnParameter paramPersonTitle = new (defPersonTitle, PersonTitle);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramCountry = new (defCountry, Country);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramGender = new (defGender, Gender);
                DataColumnParameter paramHomeAddress = new (defHomeAddress, HomeAddress);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramBirthPlace = new (defBirthPlace, BirthPlace);
                DataColumnParameter paramMobileAreaCode = new (defMobileAreaCode, MobileAreaCode);
                DataColumnParameter paramMobileNumber = new (defMobileNumber, MobileNumber);
                DataColumnParameter paramImportComment = new (defImportComment, ImportComment);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
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
                        paramCreatedAt.GetSQLQuotedValueForAdd()                        )
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
            int DataMonitorID,
            int ImportStatusID,
            string IdentificationNo,
            string PersonTitle,
            string FirstName,
            string LastName,
            string Country,
            DateTime DateOfBirth,
            string Gender,
            string ImportComment,
            DateTime CreatedAt,
            string HomeAddress = null,
            string Email = null,
            string BirthPlace = null,
            string MobileAreaCode = null,
            string MobileNumber = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);
                DataColumnParameter paramImportStatusID = new (defImportStatusID, ImportStatusID);
                DataColumnParameter paramIdentificationNo = new (defIdentificationNo, IdentificationNo);
                DataColumnParameter paramPersonTitle = new (defPersonTitle, PersonTitle);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramCountry = new (defCountry, Country);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramGender = new (defGender, Gender);
                DataColumnParameter paramHomeAddress = new (defHomeAddress, HomeAddress);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramBirthPlace = new (defBirthPlace, BirthPlace);
                DataColumnParameter paramMobileAreaCode = new (defMobileAreaCode, MobileAreaCode);
                DataColumnParameter paramMobileNumber = new (defMobileNumber, MobileNumber);
                DataColumnParameter paramImportComment = new (defImportComment, ImportComment);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
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
                        paramCreatedAt.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int DataMonitorID,
            int ImportStatusID,
            string IdentificationNo,
            string PersonTitle,
            string FirstName,
            string LastName,
            string Country,
            DateTime DateOfBirth,
            string Gender,
            string ImportComment,
            DateTime CreatedAt,
            string HomeAddress = null,
            string Email = null,
            string BirthPlace = null,
            string MobileAreaCode = null,
            string MobileNumber = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramDataMonitorID = new (defDataMonitorID, DataMonitorID);
                DataColumnParameter paramImportStatusID = new (defImportStatusID, ImportStatusID);
                DataColumnParameter paramIdentificationNo = new (defIdentificationNo, IdentificationNo);
                DataColumnParameter paramPersonTitle = new (defPersonTitle, PersonTitle);
                DataColumnParameter paramFirstName = new (defFirstName, FirstName);
                DataColumnParameter paramLastName = new (defLastName, LastName);
                DataColumnParameter paramCountry = new (defCountry, Country);
                DataColumnParameter paramDateOfBirth = new (defDateOfBirth, DateOfBirth);
                DataColumnParameter paramGender = new (defGender, Gender);
                DataColumnParameter paramHomeAddress = new (defHomeAddress, HomeAddress);
                DataColumnParameter paramEmail = new (defEmail, Email);
                DataColumnParameter paramBirthPlace = new (defBirthPlace, BirthPlace);
                DataColumnParameter paramMobileAreaCode = new (defMobileAreaCode, MobileAreaCode);
                DataColumnParameter paramMobileNumber = new (defMobileNumber, MobileNumber);
                DataColumnParameter paramImportComment = new (defImportComment, ImportComment);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})  ", TABLE_NAME,
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
                        paramCreatedAt.GetSQLQuotedValueForAdd()                            
                            )
                        ).ToBoolean()
                    );


        }                  


                  
        /// <summary>                  
        /// Update current table. Works just for Target Row                  
        /// </summary>                  
        /// <param name="reloadTable">if you want this class reloaded</param>                  
        /// <param name="transaction"></param>                  
        /// <returns></returns>                  
        public bool Update(bool reloadTable = false, DBTransaction transaction = null)                  
        {                  
            return TransactionRunner.InvokeRun(                  
               (conn) => {                  
                   bool r = new UpdateQueryBuilder(this).Execute(conn).ToBoolean();                  
                   if (reloadTable) this.LoadFromRows( GetRowWhereIDUsingSQL(this.ID, conn).TargettedRow );                  
                   return r;                  
               },                  
               transaction                  
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
