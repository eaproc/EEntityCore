using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using EEntityCore.DB.Modules;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.import                  
{                  

    public class T___AccountingExpenditureDisbursed : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___AccountingExpenditureDisbursed()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defDataMonitorID = new DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defImportStatusID = new DataColumnDefinition(TableColumnNames.ImportStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defRequest = new DataColumnDefinition(TableColumnNames.Request.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDisbursedDate = new DataColumnDefinition(TableColumnNames.DisbursedDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCategory = new DataColumnDefinition(TableColumnNames.Category.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiary = new DataColumnDefinition(TableColumnNames.Beneficiary.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defNotes = new DataColumnDefinition(TableColumnNames.Notes.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotal = new DataColumnDefinition(TableColumnNames.Total.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defImportComment = new DataColumnDefinition(TableColumnNames.ImportComment.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID); 
          ColumnDefns.Add(defImportStatusID.ColumnName, defImportStatusID); 
          ColumnDefns.Add(defRequest.ColumnName, defRequest); 
          ColumnDefns.Add(defDisbursedDate.ColumnName, defDisbursedDate); 
          ColumnDefns.Add(defCategory.ColumnName, defCategory); 
          ColumnDefns.Add(defBeneficiary.ColumnName, defBeneficiary); 
          ColumnDefns.Add(defNotes.ColumnName, defNotes); 
          ColumnDefns.Add(defTotal.ColumnName, defTotal); 
          ColumnDefns.Add(defImportComment.ColumnName, defImportComment); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_AccountingExpenditureDisbursed_DataMonitorID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "import.AccountingExpenditureDisbursed", "import.DataMonitor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_AccountingExpenditureDisbursed_ImportStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.AccountingExpenditureDisbursed", "import.ImportStatus"                  
                            ));                  

          }


                  
       public T___AccountingExpenditureDisbursed() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___AccountingExpenditureDisbursed(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___AccountingExpenditureDisbursed(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___AccountingExpenditureDisbursed(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "import.AccountingExpenditureDisbursed";
       public const string AccountingExpenditureDisbursed__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [DataMonitorID], [ImportStatusID], [Request], [DisbursedDate], [Category], [Beneficiary], [Notes], [Total], [ImportComment], [CreatedAt] FROM AccountingExpenditureDisbursed";
       public const string AccountingExpenditureDisbursed__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [DataMonitorID], [ImportStatusID], [Request], [DisbursedDate], [Category], [Beneficiary], [Notes], [Total], [ImportComment], [CreatedAt] FROM AccountingExpenditureDisbursed";


       public enum TableColumnNames
       {

           ID,
           DataMonitorID,
           ImportStatusID,
           Request,
           DisbursedDate,
           Category,
           Beneficiary,
           Notes,
           Total,
           ImportComment,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_import_AccountingExpenditureDisbursed, 
           fk_import_AccountingExpenditureDisbursed_DataMonitorID, 
           fk_import_AccountingExpenditureDisbursed_ImportStatusID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDataMonitorID;
       public static readonly DataColumnDefinition defImportStatusID;
       public static readonly DataColumnDefinition defRequest;
       public static readonly DataColumnDefinition defDisbursedDate;
       public static readonly DataColumnDefinition defCategory;
       public static readonly DataColumnDefinition defBeneficiary;
       public static readonly DataColumnDefinition defNotes;
       public static readonly DataColumnDefinition defTotal;
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


       public String Request {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Request.ToString()]);
           }
       }


       public NullableDateTime DisbursedDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.DisbursedDate.ToString()]);
           }
       }


       public String Category {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Category.ToString()]);
           }
       }


       public String Beneficiary {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Beneficiary.ToString()]);
           }
       }


       public String Notes {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Notes.ToString()]);
           }
       }


       public Decimal Total {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Total.ToString()]);
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
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___AccountingExpenditureDisbursed GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___AccountingExpenditureDisbursed(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___AccountingExpenditureDisbursed GetFullTable()                  
        {                  
            return new T___AccountingExpenditureDisbursed(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___AccountingExpenditureDisbursed GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___AccountingExpenditureDisbursed(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___AccountingExpenditureDisbursed GetRowWhereID(int pID)                  
        {                  
            return new T___AccountingExpenditureDisbursed(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___AccountingExpenditureDisbursed pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (!pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return false;                  
                }                  
                  
                return true;                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  
                  
        private bool IsAnyRowEqual(T___AccountingExpenditureDisbursed pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return true;                  
                }                  
                  
                return false;                  
            }                  
            catch (Exception )                  
            {                  
                return false;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___AccountingExpenditureDisbursed GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___AccountingExpenditureDisbursed(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___AccountingExpenditureDisbursed(drst);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM                errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___AccountingExpenditureDisbursed getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___AccountingExpenditureDisbursed(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___AccountingExpenditureDisbursed(drst);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        public Dictionary<string, DataColumnDefinition> getDefinitions()                  
        {                  
            return ColumnDefns;                  
        }                  
                  
        private bool RowEqual(string pColumnName, object pColumnValue)                  
        {                  
            try                  
            {                  
                if (!this.IsTargettedRowValid)                  
                    return false;                  
                switch (DataColumnDefinition.getTypeAllowed(ColumnDefns[pColumnName].DataType))                  
                {                  
                    case var @case when @case == DataColumnDefinition.AllowedDataTypes.Bool:                  
                        {                  
                            return EBoolean.valueOf(this.TargettedRow[pColumnName]) == EBoolean.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case1 when case1 == DataColumnDefinition.AllowedDataTypes.Blob:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    case var case2 when case2 == DataColumnDefinition.AllowedDataTypes.DateTime:                  
                        {                  
                            return EDateTime.EqualsDateWithoutTime(new NullableDateTime(this.TargettedRow[pColumnName]).DateTimeValue, new NullableDateTime(pColumnValue).DateTimeValue);                  
                        }                  
                  
                    case var case3 when case3 == DataColumnDefinition.AllowedDataTypes.Decimal:                  
                        {                  
                            return EDouble.valueOf(this.TargettedRow[pColumnName]) == EDouble.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case4 when case4 == DataColumnDefinition.AllowedDataTypes.Int:                  
                        {                  
                            return EInt.valueOf(this.TargettedRow[pColumnName]) == EInt.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case5 when case5 == DataColumnDefinition.AllowedDataTypes.Long:                  
                        {                  
                            return ELong.valueOf(this.TargettedRow[pColumnName]) == ELong.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case6 when case6 == DataColumnDefinition.AllowedDataTypes.String:                  
                        {                  
                            return EStrings.equalsIgnoreCase(EStrings.valueOf(this.TargettedRow[pColumnName]), EStrings.valueOf(pColumnValue));                  
                        }                  
                  
                    case var case7 when case7 == DataColumnDefinition.AllowedDataTypes.TimeSpan:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    default:                  
                        {                  
                            // REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()                                                       
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                }                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  

                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
        public virtual string GetFillSQL() => AccountingExpenditureDisbursed__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pDataMonitorID,
Int32 pImportStatusID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
                DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
                DataColumnParameter paramRequest = new DataColumnParameter(defRequest, defRequest.DefaultValue);
                DataColumnParameter paramDisbursedDate = new DataColumnParameter(defDisbursedDate, defDisbursedDate.DefaultValue);
                DataColumnParameter paramCategory = new DataColumnParameter(defCategory, defCategory.DefaultValue);
                DataColumnParameter paramBeneficiary = new DataColumnParameter(defBeneficiary, defBeneficiary.DefaultValue);
                DataColumnParameter paramNotes = new DataColumnParameter(defNotes, defNotes.DefaultValue);
                DataColumnParameter paramTotal = new DataColumnParameter(defTotal, defTotal.DefaultValue);
                DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, defImportComment.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramDataMonitorID.getSQLQuotedValueForAdd(),
                paramImportStatusID.getSQLQuotedValueForAdd(),
                paramRequest.getSQLQuotedValueForAdd(),
                paramDisbursedDate.getSQLQuotedValueForAdd(),
                paramCategory.getSQLQuotedValueForAdd(),
                paramBeneficiary.getSQLQuotedValueForAdd(),
                paramNotes.getSQLQuotedValueForAdd(),
                paramTotal.getSQLQuotedValueForAdd(),
                paramImportComment.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pDataMonitorID,
Int32 pImportStatusID,
String pRequest,
DateTime pDisbursedDate,
String pCategory,
String pBeneficiary,
Decimal pTotal,
String pImportComment,
DateTime pCreatedAt,
Object pNotes = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
                DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
                DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
                DataColumnParameter paramDisbursedDate = new DataColumnParameter(defDisbursedDate, pDisbursedDate);
                DataColumnParameter paramCategory = new DataColumnParameter(defCategory, pCategory);
                DataColumnParameter paramBeneficiary = new DataColumnParameter(defBeneficiary, pBeneficiary);
                DataColumnParameter paramNotes = new DataColumnParameter(defNotes, pNotes);
                DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
                DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramDisbursedDate.getSQLQuotedValueForAdd(),
paramCategory.getSQLQuotedValueForAdd(),
paramBeneficiary.getSQLQuotedValueForAdd(),
paramNotes.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pDataMonitorID,
Int32 pImportStatusID,
String pRequest,
DateTime pDisbursedDate,
String pCategory,
String pBeneficiary,
Decimal pTotal,
String pImportComment,
DateTime pCreatedAt,
Object pNotes = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
DataColumnParameter paramDisbursedDate = new DataColumnParameter(defDisbursedDate, pDisbursedDate);
DataColumnParameter paramCategory = new DataColumnParameter(defCategory, pCategory);
DataColumnParameter paramBeneficiary = new DataColumnParameter(defBeneficiary, pBeneficiary);
DataColumnParameter paramNotes = new DataColumnParameter(defNotes, pNotes);
DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramDisbursedDate.getSQLQuotedValueForAdd(),
paramCategory.getSQLQuotedValueForAdd(),
paramBeneficiary.getSQLQuotedValueForAdd(),
paramNotes.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), true);




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
String pRequest,
DateTime pDisbursedDate,
String pCategory,
String pBeneficiary,
Decimal pTotal,
String pImportComment,
DateTime pCreatedAt,
Object pNotes= null){

        try{

DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
DataColumnParameter paramDisbursedDate = new DataColumnParameter(defDisbursedDate, pDisbursedDate);
DataColumnParameter paramCategory = new DataColumnParameter(defCategory, pCategory);
DataColumnParameter paramBeneficiary = new DataColumnParameter(defBeneficiary, pBeneficiary);
DataColumnParameter paramNotes = new DataColumnParameter(defNotes, pNotes);
DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramDisbursedDate.getSQLQuotedValueForAdd(),
paramCategory.getSQLQuotedValueForAdd(),
paramBeneficiary.getSQLQuotedValueForAdd(),
paramNotes.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), true);


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
Object pRequest = null,
Object pDisbursedDate = null,
Object pCategory = null,
Object pBeneficiary = null,
Object pTotal = null,
Object pImportComment = null,
Object pCreatedAt = null,
Object pNotes = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
 DataColumnParameter paramImportStatusID = new DataColumnParameter(defImportStatusID, pImportStatusID);
 DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
 DataColumnParameter paramDisbursedDate = new DataColumnParameter(defDisbursedDate, pDisbursedDate);
 DataColumnParameter paramCategory = new DataColumnParameter(defCategory, pCategory);
 DataColumnParameter paramBeneficiary = new DataColumnParameter(defBeneficiary, pBeneficiary);
 DataColumnParameter paramNotes = new DataColumnParameter(defNotes, pNotes);
 DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
 DataColumnParameter paramImportComment = new DataColumnParameter(defImportComment, pImportComment);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [DataMonitorID]={2},[ImportStatusID]={3},[Request]={4},[DisbursedDate]={5},[Category]={6},[Beneficiary]={7},[Notes]={8},[Total]={9},[ImportComment]={10},[CreatedAt]={11} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramDataMonitorID.getSQLQuotedValueForUpdate(),
paramImportStatusID.getSQLQuotedValueForUpdate(),
paramRequest.getSQLQuotedValueForUpdate(),
paramDisbursedDate.getSQLQuotedValueForUpdate(),
paramCategory.getSQLQuotedValueForUpdate(),
paramBeneficiary.getSQLQuotedValueForUpdate(),
paramNotes.getSQLQuotedValueForUpdate(),
paramTotal.getSQLQuotedValueForUpdate(),
paramImportComment.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate()  ), true);


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
