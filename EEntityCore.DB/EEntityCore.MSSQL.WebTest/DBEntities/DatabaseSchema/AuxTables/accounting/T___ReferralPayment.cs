using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using ELibrary.Standard.VB.Modules;                  
using EEntityCore.DB.Schemas.SQLServerSchema;                  
using EEntityCore.DB.MSSQL;                  
using EEntityCore.DB.Modules;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___ReferralPayment : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ReferralPayment()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defReferredClientID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ReferredClientID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Amount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Comments.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defReferredClientID.ColumnName, defReferredClientID); 
          ColumnDefns.Add(defAmount.ColumnName, defAmount); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferralPayment_ReferredClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferralPayment", "accounting.ReferredClient"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferralPayment_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferralPayment", "academic.Term"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferralPayment_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferralPayment", "auth.Users"                  
                            ));                  

          }


                  
       public T___ReferralPayment() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferralPayment(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferralPayment(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferralPayment(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferralPayment(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ReferralPayment(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferralPayment(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferralPayment(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferralPayment(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___ReferralPayment(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.ReferralPayment";
       public const string ReferralPayment__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [ReferredClientID], [Amount], [TermID], [Comments], [CreatedByID], [CreatedAt] FROM ReferralPayment";
       public const string ReferralPayment__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [ReferredClientID], [Amount], [TermID], [Comments], [CreatedByID], [CreatedAt] FROM ReferralPayment";


       public enum TableColumnNames
       {

           ID,
           ReferredClientID,
           Amount,
           TermID,
           Comments,
           CreatedByID,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_accounting_ReferralPayment, 
           fk_accounting_ReferralPayment_ReferredClientID, 
           fk_accounting_ReferralPayment_TermID, 
           fk_accounting_ReferralPayment_CreatedByID, 
           uq_accounting_ReferralPayment, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defReferredClientID;
       public static readonly DataColumnDefinition defAmount;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defCreatedAt;

       public int ReferredClientID { get => (int)TargettedRow[TableColumnNames.ReferredClientID.ToString()]; }


       public decimal Amount { get => (decimal)TargettedRow[TableColumnNames.Amount.ToString()]; }


       public int TermID { get => (int)TargettedRow[TableColumnNames.TermID.ToString()]; }


       public string Comments { get => (string)TargettedRow[TableColumnNames.Comments.ToString()]; }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___ReferralPayment GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___ReferralPayment GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___ReferralPayment GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___ReferralPayment(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___ReferralPayment GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => ReferralPayment__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static long InsertGetID(
            int ReferredClientID,
            decimal Amount,
            int TermID,
            int CreatedByID,
            DateTime CreatedAt,
            string Comments = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramReferredClientID = new (defReferredClientID, ReferredClientID);
                DataColumnParameter paramAmount = new (defAmount, Amount);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
            {                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" INSERT INTO {0}([ReferredClientID],[Amount],[TermID],[Comments],[CreatedByID],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6})  ", TABLE_NAME,
                        paramReferredClientID.GetSQLQuotedValueForAdd(),
                        paramAmount.GetSQLQuotedValueForAdd(),
                        paramTermID.GetSQLQuotedValueForAdd(),
                        paramComments.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
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
            int ReferredClientID,
            decimal Amount,
            int TermID,
            int CreatedByID,
            DateTime CreatedAt,
            string Comments = null,
            DBTransaction transaction = null
          ){

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramReferredClientID = new (defReferredClientID, ReferredClientID);
                DataColumnParameter paramAmount = new (defAmount, Amount);
                DataColumnParameter paramTermID = new (defTermID, TermID);
                DataColumnParameter paramComments = new (defComments, Comments);
                DataColumnParameter paramCreatedByID = new (defCreatedByID, CreatedByID);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);

                  
                  
            using var r = new TransactionRunner(transaction);                  
                  
            return r.Run( (conn) =>                   
                      conn.ExecuteTransactionQuery(                  
                    string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ReferredClientID],[Amount],[TermID],[Comments],[CreatedByID],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramReferredClientID.GetSQLQuotedValueForAdd(),
                        paramAmount.GetSQLQuotedValueForAdd(),
                        paramTermID.GetSQLQuotedValueForAdd(),
                        paramComments.GetSQLQuotedValueForAdd(),
                        paramCreatedByID.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd()                        )
                    ).ToBoolean() 
               );
        }                  




                  
                  
        public static bool DeleteItemRow(long pID)                                    
        {                  
            return DeleteRow(DBConnectInterface.GetDBConn(), pID: pID, pTableName: TABLE_NAME);                  
        }                                    


   }


}
