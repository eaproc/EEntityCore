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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.accounting                  
{                  

    public class V___CashRequestLastResponse : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___CashRequestLastResponse()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequest = new DataColumnDefinition(TableColumnNames.Request.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDeadline = new DataColumnDefinition(TableColumnNames.Deadline.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTrackingID = new DataColumnDefinition(TableColumnNames.TrackingID.ToString(), typeof(int?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastProceedingDocumentFileName = new DataColumnDefinition(TableColumnNames.LastProceedingDocumentFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiaryID = new DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAmount = new DataColumnDefinition(TableColumnNames.Amount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCategory = new DataColumnDefinition(TableColumnNames.Category.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(TableColumnNames.FullName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRequestStatus = new DataColumnDefinition(TableColumnNames.RequestStatus.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpenditureCategoryID = new DataColumnDefinition(TableColumnNames.ExpenditureCategoryID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRevisedAmount = new DataColumnDefinition(TableColumnNames.RevisedAmount.ToString(), typeof(decimal),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTitle = new DataColumnDefinition(TableColumnNames.Title.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCashRequestStatusID = new DataColumnDefinition(TableColumnNames.CashRequestStatusID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastProceedingCreatedBy = new DataColumnDefinition(TableColumnNames.LastProceedingCreatedBy.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastResponseComments = new DataColumnDefinition(TableColumnNames.LastResponseComments.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastProceedingCreatedAt = new DataColumnDefinition(TableColumnNames.LastProceedingCreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastProceedingCreatedByID = new DataColumnDefinition(TableColumnNames.LastProceedingCreatedByID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCashRequestProceedingID = new DataColumnDefinition(TableColumnNames.CashRequestProceedingID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defRequest.ColumnName, defRequest); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defDeadline.ColumnName, defDeadline); 
          ColumnDefns.Add(defTrackingID.ColumnName, defTrackingID); 
          ColumnDefns.Add(defLastProceedingDocumentFileName.ColumnName, defLastProceedingDocumentFileName); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defAmount.ColumnName, defAmount); 
          ColumnDefns.Add(defCategory.ColumnName, defCategory); 
          ColumnDefns.Add(defFullName.ColumnName, defFullName); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName); 
          ColumnDefns.Add(defRequestStatus.ColumnName, defRequestStatus); 
          ColumnDefns.Add(defExpenditureCategoryID.ColumnName, defExpenditureCategoryID); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defRevisedAmount.ColumnName, defRevisedAmount); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defCashRequestStatusID.ColumnName, defCashRequestStatusID); 
          ColumnDefns.Add(defLastProceedingCreatedBy.ColumnName, defLastProceedingCreatedBy); 
          ColumnDefns.Add(defLastResponseComments.ColumnName, defLastResponseComments); 
          ColumnDefns.Add(defLastProceedingCreatedAt.ColumnName, defLastProceedingCreatedAt); 
          ColumnDefns.Add(defLastProceedingCreatedByID.ColumnName, defLastProceedingCreatedByID); 
          ColumnDefns.Add(defCashRequestProceedingID.ColumnName, defCashRequestProceedingID); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("accounting.CashRequest");                  
            ReferencedTableNames.Add("accounting.CashRequestProceeding");                  
            ReferencedTableNames.Add("accounting.CashRequestStatus");                  
            ReferencedTableNames.Add("accounting.ExpenditureCategory");                  
            ReferencedTableNames.Add("auth.Users");                  
            ReferencedTableNames.Add("common.PersonView");                  

          }


                  
       public V___CashRequestLastResponse() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___CashRequestLastResponse(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CashRequestLastResponse(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public V___CashRequestLastResponse(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.CashRequestLastResponse";
       public const string CashRequestLastResponse__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Request], [CreatedAt], [Deadline], [TrackingID], [LastProceedingDocumentFileName], [BeneficiaryID], [Amount], [Category], [FullName], [FirstName], [LastName], [PersonID], [PictureFileName], [RequestStatus], [ExpenditureCategoryID], [CreatedByID], [RevisedAmount], [Title], [CashRequestStatusID], [LastProceedingCreatedBy], [LastResponseComments], [LastProceedingCreatedAt], [LastProceedingCreatedByID], [CashRequestProceedingID] FROM accounting.CashRequestLastResponse";
       public const string CashRequestLastResponse__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Request], [CreatedAt], [Deadline], [TrackingID], [LastProceedingDocumentFileName], [BeneficiaryID], [Amount], [Category], [FullName], [FirstName], [LastName], [PersonID], [PictureFileName], [RequestStatus], [ExpenditureCategoryID], [CreatedByID], [RevisedAmount], [Title], [CashRequestStatusID], [LastProceedingCreatedBy], [LastResponseComments], [LastProceedingCreatedAt], [LastProceedingCreatedByID], [CashRequestProceedingID] FROM accounting.CashRequestLastResponse";


       public enum TableColumnNames
       {

           ID,
           Request,
           CreatedAt,
           Deadline,
           TrackingID,
           LastProceedingDocumentFileName,
           BeneficiaryID,
           Amount,
           Category,
           FullName,
           FirstName,
           LastName,
           PersonID,
           PictureFileName,
           RequestStatus,
           ExpenditureCategoryID,
           CreatedByID,
           RevisedAmount,
           Title,
           CashRequestStatusID,
           LastProceedingCreatedBy,
           LastResponseComments,
           LastProceedingCreatedAt,
           LastProceedingCreatedByID,
           CashRequestProceedingID
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defRequest;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defDeadline;
       public static readonly DataColumnDefinition defTrackingID;
       public static readonly DataColumnDefinition defLastProceedingDocumentFileName;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defAmount;
       public static readonly DataColumnDefinition defCategory;
       public static readonly DataColumnDefinition defFullName;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defPictureFileName;
       public static readonly DataColumnDefinition defRequestStatus;
       public static readonly DataColumnDefinition defExpenditureCategoryID;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defRevisedAmount;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defCashRequestStatusID;
       public static readonly DataColumnDefinition defLastProceedingCreatedBy;
       public static readonly DataColumnDefinition defLastResponseComments;
       public static readonly DataColumnDefinition defLastProceedingCreatedAt;
       public static readonly DataColumnDefinition defLastProceedingCreatedByID;
       public static readonly DataColumnDefinition defCashRequestProceedingID;

       public string Request { get => (string)TargettedRow[TableColumnNames.Request.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime Deadline { get => (DateTime)TargettedRow[TableColumnNames.Deadline.ToString()]; }


       public int? TrackingID { get => (int?)TargettedRow[TableColumnNames.TrackingID.ToString()]; }


       public string LastProceedingDocumentFileName { get => (string)TargettedRow[TableColumnNames.LastProceedingDocumentFileName.ToString()]; }


       public int BeneficiaryID { get => (int)TargettedRow[TableColumnNames.BeneficiaryID.ToString()]; }


       public decimal Amount { get => (decimal)TargettedRow[TableColumnNames.Amount.ToString()]; }


       public string Category { get => (string)TargettedRow[TableColumnNames.Category.ToString()]; }


       public string FullName { get => (string)TargettedRow[TableColumnNames.FullName.ToString()]; }


       public string FirstName { get => (string)TargettedRow[TableColumnNames.FirstName.ToString()]; }


       public string LastName { get => (string)TargettedRow[TableColumnNames.LastName.ToString()]; }


       public int PersonID { get => (int)TargettedRow[TableColumnNames.PersonID.ToString()]; }


       public string PictureFileName { get => (string)TargettedRow[TableColumnNames.PictureFileName.ToString()]; }


       public string RequestStatus { get => (string)TargettedRow[TableColumnNames.RequestStatus.ToString()]; }


       public int ExpenditureCategoryID { get => (int)TargettedRow[TableColumnNames.ExpenditureCategoryID.ToString()]; }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public decimal RevisedAmount { get => (decimal)TargettedRow[TableColumnNames.RevisedAmount.ToString()]; }


       public string Title { get => (string)TargettedRow[TableColumnNames.Title.ToString()]; }


       public int CashRequestStatusID { get => (int)TargettedRow[TableColumnNames.CashRequestStatusID.ToString()]; }


       public string LastProceedingCreatedBy { get => (string)TargettedRow[TableColumnNames.LastProceedingCreatedBy.ToString()]; }


       public string LastResponseComments { get => (string)TargettedRow[TableColumnNames.LastResponseComments.ToString()]; }


       public DateTime LastProceedingCreatedAt { get => (DateTime)TargettedRow[TableColumnNames.LastProceedingCreatedAt.ToString()]; }


       public int LastProceedingCreatedByID { get => (int)TargettedRow[TableColumnNames.LastProceedingCreatedByID.ToString()]; }


       public int CashRequestProceedingID { get => (int)TargettedRow[TableColumnNames.CashRequestProceedingID.ToString()]; }


 #endregion

 #region Methods                                                      
                                                      
                                                                        
        /// <summary>                                                                                                             
        /// Returns null on failure                                                                                                             
        /// </summary>                                                                                                             
        /// <returns></returns>                                                                                                             
        /// <remarks></remarks>                                                                        
        public V___CashRequestLastResponse GetFirstRow()                                                                        
        {                                                                        
            if (this.HasRows())                                                                        
                return new (AllRows.First());                                                                        
            return null;                                                                        
        }                                                                        
                                                                        
        public static V___CashRequestLastResponse GetFullTable(DBTransaction transaction = null) =>                   
            TransactionRunner.InvokeRun( (conn) =>                  
                new V___CashRequestLastResponse(conn.Fetch(CashRequestLastResponse__ALL_COLUMNS___SQL_FILL_QUERY).FirstTable(), DO__NOT____TARGET__ANY_ROWID),                  
                transaction                  
                );                                                      
                                                      
        public static V___CashRequestLastResponse GetRowWhereIDUsingSQL(int pID, DBTransaction transaction = null)                                                                        
        {                  
            return TransactionRunner.InvokeRun(                  
                (conn) =>                   
                new V___CashRequestLastResponse( conn.Fetch($"SELECT * FROM {TABLE_NAME} WHERE ID={pID}" ).FirstTable(), pID ),                  
                transaction                  
                );                  
        }                                                                        
                                                                        
        public V___CashRequestLastResponse GetRowWhereID(int pID) => new(this.RawTable, pID);                                                      
                                                      
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                                             
                                            
                                    
                  
        public virtual string GetFillSQL() => CashRequestLastResponse__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
