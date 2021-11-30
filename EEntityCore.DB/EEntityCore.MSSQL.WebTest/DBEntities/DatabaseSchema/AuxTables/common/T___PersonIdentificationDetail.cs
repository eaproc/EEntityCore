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

    public class T___PersonIdentificationDetail : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PersonIdentificationDetail()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defNumber = new DataColumnDefinition(TableColumnNames.Number.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defIdentificationTypeID = new DataColumnDefinition(TableColumnNames.IdentificationTypeID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNIQUE);
          defIssuedDate = new DataColumnDefinition(TableColumnNames.IssuedDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIssuingCountryID = new DataColumnDefinition(TableColumnNames.IssuingCountryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defExpiryDate = new DataColumnDefinition(TableColumnNames.ExpiryDate.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIdentificationViabilityID = new DataColumnDefinition(TableColumnNames.IdentificationViabilityID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDocumentFileName = new DataColumnDefinition(TableColumnNames.DocumentFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defNumber.ColumnName, defNumber); 
          ColumnDefns.Add(defIdentificationTypeID.ColumnName, defIdentificationTypeID); 
          ColumnDefns.Add(defIssuedDate.ColumnName, defIssuedDate); 
          ColumnDefns.Add(defIssuingCountryID.ColumnName, defIssuingCountryID); 
          ColumnDefns.Add(defExpiryDate.ColumnName, defExpiryDate); 
          ColumnDefns.Add(defIdentificationViabilityID.ColumnName, defIdentificationViabilityID); 
          ColumnDefns.Add(defDocumentFileName.ColumnName, defDocumentFileName); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_PersonID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.Person"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_IdentificationTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.IdentificationType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_IssuingCountryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.Country"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_IdentificationViabilityID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.IdentificationViability"                  
                            ));                  

          }


                  
       public T___PersonIdentificationDetail() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PersonIdentificationDetail(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
        {                                    
        }                                    
                                            
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonIdentificationDetail(DataTable FullTable) : base(FullTable)                                    
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
        public T___PersonIdentificationDetail(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "common.PersonIdentificationDetail";
       public const string PersonIdentificationDetail__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PersonID], [Number], [IdentificationTypeID], [IssuedDate], [IssuingCountryID], [ExpiryDate], [IdentificationViabilityID], [DocumentFileName], [CreatedAt], [UpdatedAt] FROM common.PersonIdentificationDetail";
       public const string PersonIdentificationDetail__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PersonID], [Number], [IdentificationTypeID], [IssuedDate], [IssuingCountryID], [ExpiryDate], [IdentificationViabilityID], [DocumentFileName], [CreatedAt], [UpdatedAt] FROM common.PersonIdentificationDetail";


       public enum TableColumnNames
       {

           ID,
           PersonID,
           Number,
           IdentificationTypeID,
           IssuedDate,
           IssuingCountryID,
           ExpiryDate,
           IdentificationViabilityID,
           DocumentFileName,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_common_PersonIdentificationDetail, 
           fk_common_PersonIdentificationDetail_PersonID, 
           fk_common_PersonIdentificationDetail_IdentificationTypeID, 
           fk_common_PersonIdentificationDetail_IssuingCountryID, 
           fk_common_PersonIdentificationDetail_IdentificationViabilityID, 
           uq_common_PersonIdentificationDetail_PersonID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defNumber;
       public static readonly DataColumnDefinition defIdentificationTypeID;
       public static readonly DataColumnDefinition defIssuedDate;
       public static readonly DataColumnDefinition defIssuingCountryID;
       public static readonly DataColumnDefinition defExpiryDate;
       public static readonly DataColumnDefinition defIdentificationViabilityID;
       public static readonly DataColumnDefinition defDocumentFileName;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public int PersonID { get => (int)TargettedRow[TableColumnNames.PersonID.ToString()]; }


       public string Number { get => (string)TargettedRow[TableColumnNames.Number.ToString()]; }


       public int IdentificationTypeID { get => (int)TargettedRow[TableColumnNames.IdentificationTypeID.ToString()]; }


       public DateTime? IssuedDate { get => (DateTime?)TargettedRow[TableColumnNames.IssuedDate.ToString()]; }


       public int IssuingCountryID { get => (int)TargettedRow[TableColumnNames.IssuingCountryID.ToString()]; }


       public DateTime? ExpiryDate { get => (DateTime?)TargettedRow[TableColumnNames.ExpiryDate.ToString()]; }


       public int IdentificationViabilityID { get => (int)TargettedRow[TableColumnNames.IdentificationViabilityID.ToString()]; }


       public string DocumentFileName { get => (string)TargettedRow[TableColumnNames.DocumentFileName.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? UpdatedAt { get => (DateTime?)TargettedRow[TableColumnNames.UpdatedAt.ToString()]; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public T___PersonIdentificationDetail GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static T___PersonIdentificationDetail GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new T___PersonIdentificationDetail(conn.Fetch(PersonIdentificationDetail__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable()),                  
                transaction                  
                );                                                      
                                                      
        public static T___PersonIdentificationDetail GetRowWhereIDUsingSQL(int pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new T___PersonIdentificationDetail( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public T___PersonIdentificationDetail GetRowWhereID(int pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => PersonIdentificationDetail__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int PersonID,
            string Number,
            int IdentificationTypeID,
            int IssuingCountryID,
            int IdentificationViabilityID,
            DateTime CreatedAt,
            DateTime? IssuedDate = null,
            DateTime? ExpiryDate = null,
            string DocumentFileName = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramNumber = new (defNumber, Number);
                DataColumnParameter paramIdentificationTypeID = new (defIdentificationTypeID, IdentificationTypeID);
                DataColumnParameter paramIssuedDate = new (defIssuedDate, IssuedDate);
                DataColumnParameter paramIssuingCountryID = new (defIssuingCountryID, IssuingCountryID);
                DataColumnParameter paramExpiryDate = new (defExpiryDate, ExpiryDate);
                DataColumnParameter paramIdentificationViabilityID = new (defIdentificationViabilityID, IdentificationViabilityID);
                DataColumnParameter paramDocumentFileName = new (defDocumentFileName, DocumentFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramPersonID.GetSQLQuotedValueForAdd(),
                        paramNumber.GetSQLQuotedValueForAdd(),
                        paramIdentificationTypeID.GetSQLQuotedValueForAdd(),
                        paramIssuedDate.GetSQLQuotedValueForAdd(),
                        paramIssuingCountryID.GetSQLQuotedValueForAdd(),
                        paramExpiryDate.GetSQLQuotedValueForAdd(),
                        paramIdentificationViabilityID.GetSQLQuotedValueForAdd(),
                        paramDocumentFileName.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd()                        )
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
            int PersonID,
            string Number,
            int IdentificationTypeID,
            int IssuingCountryID,
            int IdentificationViabilityID,
            DateTime CreatedAt,
            DateTime? IssuedDate = null,
            DateTime? ExpiryDate = null,
            string DocumentFileName = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramNumber = new (defNumber, Number);
                DataColumnParameter paramIdentificationTypeID = new (defIdentificationTypeID, IdentificationTypeID);
                DataColumnParameter paramIssuedDate = new (defIssuedDate, IssuedDate);
                DataColumnParameter paramIssuingCountryID = new (defIssuingCountryID, IssuingCountryID);
                DataColumnParameter paramExpiryDate = new (defExpiryDate, ExpiryDate);
                DataColumnParameter paramIdentificationViabilityID = new (defIdentificationViabilityID, IdentificationViabilityID);
                DataColumnParameter paramDocumentFileName = new (defDocumentFileName, DocumentFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramPersonID.GetSQLQuotedValueForAdd(),
                        paramNumber.GetSQLQuotedValueForAdd(),
                        paramIdentificationTypeID.GetSQLQuotedValueForAdd(),
                        paramIssuedDate.GetSQLQuotedValueForAdd(),
                        paramIssuingCountryID.GetSQLQuotedValueForAdd(),
                        paramExpiryDate.GetSQLQuotedValueForAdd(),
                        paramIdentificationViabilityID.GetSQLQuotedValueForAdd(),
                        paramDocumentFileName.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  


        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int PersonID,
            string Number,
            int IdentificationTypeID,
            int IssuingCountryID,
            int IdentificationViabilityID,
            DateTime CreatedAt,
            DateTime? IssuedDate = null,
            DateTime? ExpiryDate = null,
            string DocumentFileName = null,
            DateTime? UpdatedAt = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramPersonID = new (defPersonID, PersonID);
                DataColumnParameter paramNumber = new (defNumber, Number);
                DataColumnParameter paramIdentificationTypeID = new (defIdentificationTypeID, IdentificationTypeID);
                DataColumnParameter paramIssuedDate = new (defIssuedDate, IssuedDate);
                DataColumnParameter paramIssuingCountryID = new (defIssuingCountryID, IssuingCountryID);
                DataColumnParameter paramExpiryDate = new (defExpiryDate, ExpiryDate);
                DataColumnParameter paramIdentificationViabilityID = new (defIdentificationViabilityID, IdentificationViabilityID);
                DataColumnParameter paramDocumentFileName = new (defDocumentFileName, DocumentFileName);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramUpdatedAt = new (defUpdatedAt, UpdatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) => conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10})  ", TABLE_NAME,
                        paramPersonID.GetSQLQuotedValueForAdd(),
                        paramNumber.GetSQLQuotedValueForAdd(),
                        paramIdentificationTypeID.GetSQLQuotedValueForAdd(),
                        paramIssuedDate.GetSQLQuotedValueForAdd(),
                        paramIssuingCountryID.GetSQLQuotedValueForAdd(),
                        paramExpiryDate.GetSQLQuotedValueForAdd(),
                        paramIdentificationViabilityID.GetSQLQuotedValueForAdd(),
                        paramDocumentFileName.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramUpdatedAt.GetSQLQuotedValueForAdd()                            
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
