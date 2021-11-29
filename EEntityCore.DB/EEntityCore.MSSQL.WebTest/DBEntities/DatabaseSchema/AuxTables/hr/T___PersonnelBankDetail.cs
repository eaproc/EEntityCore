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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.hr                  
{                  

    public class T___PersonnelBankDetail : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PersonnelBankDetail()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defBankID = new DataColumnDefinition(TableColumnNames.BankID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPersonnelID = new DataColumnDefinition(TableColumnNames.PersonnelID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountNumber = new DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defSwiftCode = new DataColumnDefinition(TableColumnNames.SwiftCode.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIBAN = new DataColumnDefinition(TableColumnNames.IBAN.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(TableColumnNames.IsActive.ToString(), typeof(bool),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defPersonnelID.ColumnName, defPersonnelID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defSwiftCode.ColumnName, defSwiftCode); 
          ColumnDefns.Add(defIBAN.ColumnName, defIBAN); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PersonnelBankDetail_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PersonnelBankDetail", "common.Bank"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PersonnelBankDetail_PersonnelID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PersonnelBankDetail", "hr.Personnel"                  
                            ));                  

          }


                  
       public T___PersonnelBankDetail() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PersonnelBankDetail(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PersonnelBankDetail(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.PersonnelBankDetail";
       public const string PersonnelBankDetail__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [BankID], [PersonnelID], [AccountNumber], [SwiftCode], [IBAN], [CreatedAt], [UpdatedAt], [IsActive] FROM PersonnelBankDetail";
       public const string PersonnelBankDetail__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [BankID], [PersonnelID], [AccountNumber], [SwiftCode], [IBAN], [CreatedAt], [UpdatedAt], [IsActive] FROM PersonnelBankDetail";


       public enum TableColumnNames
       {

           ID,
           BankID,
           PersonnelID,
           AccountNumber,
           SwiftCode,
           IBAN,
           CreatedAt,
           UpdatedAt,
           IsActive
       } 



       public enum TableConstraints{

           pk_hr_PersonnelBankDetail, 
           fk_hr_PersonnelBankDetail_BankID, 
           fk_hr_PersonnelBankDetail_PersonnelID, 
           uq_hr_PersonnelBankDetail_AccountNumber, 
           uq_hr_PersonnelBankDetail_ActiveBankAccount, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defPersonnelID;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defSwiftCode;
       public static readonly DataColumnDefinition defIBAN;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defIsActive;

       public int BankID { get => (int)TargettedRow[TableColumnNames.BankID.ToString()]; }


       public int PersonnelID { get => (int)TargettedRow[TableColumnNames.PersonnelID.ToString()]; }


       public string AccountNumber { get => (string)TargettedRow[TableColumnNames.AccountNumber.ToString()]; }


       public string SwiftCode { get => (string)TargettedRow[TableColumnNames.SwiftCode.ToString()]; }


       public string IBAN { get => (string)TargettedRow[TableColumnNames.IBAN.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


       public bool IsActive { get => (bool)TargettedRow[TableColumnNames.IsActive.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___PersonnelBankDetail GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PersonnelBankDetail GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PersonnelBankDetail GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PersonnelBankDetail(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PersonnelBankDetail GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PersonnelBankDetail__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int BankID,
            int PersonnelID,
            string AccountNumber,
            DateTime CreatedAt,
            bool IsActive,
            string SwiftCode = null,
            string IBAN = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramPersonnelID = new (defPersonnelID, PersonnelID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramSwiftCode = new (defSwiftCode, SwiftCode);
                DataColumnParameter paramIBAN = new (defIBAN, IBAN);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([BankID],[PersonnelID],[AccountNumber],[SwiftCode],[IBAN],[CreatedAt],[UpdatedAt],[IsActive]) VALUES({1},{2},{3},{4},{5},{6},{7},{8})  ", TABLE_NAME,
                        paramBankID.GetSQLQuotedValueForAdd(),
                        paramPersonnelID.GetSQLQuotedValueForAdd(),
                        paramAccountNumber.GetSQLQuotedValueForAdd(),
                        paramSwiftCode.GetSQLQuotedValueForAdd(),
                        paramIBAN.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramIsActive.GetSQLQuotedValueForAdd()                        )
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
            int BankID,
            int PersonnelID,
            string AccountNumber,
            DateTime CreatedAt,
            bool IsActive,
            string SwiftCode = null,
            string IBAN = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramBankID = new (defBankID, BankID);
                DataColumnParameter paramPersonnelID = new (defPersonnelID, PersonnelID);
                DataColumnParameter paramAccountNumber = new (defAccountNumber, AccountNumber);
                DataColumnParameter paramSwiftCode = new (defSwiftCode, SwiftCode);
                DataColumnParameter paramIBAN = new (defIBAN, IBAN);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);
                DataColumnParameter paramIsActive = new (defIsActive, IsActive);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BankID],[PersonnelID],[AccountNumber],[SwiftCode],[IBAN],[CreatedAt],[UpdatedAt],[IsActive]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramBankID.GetSQLQuotedValueForAdd(),
                        paramPersonnelID.GetSQLQuotedValueForAdd(),
                        paramAccountNumber.GetSQLQuotedValueForAdd(),
                        paramSwiftCode.GetSQLQuotedValueForAdd(),
                        paramIBAN.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd(),
                        paramIsActive.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
