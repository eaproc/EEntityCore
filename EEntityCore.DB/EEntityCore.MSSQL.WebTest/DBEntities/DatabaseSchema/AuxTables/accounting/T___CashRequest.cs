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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___CashRequest : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___CashRequest()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defRequest = new DataColumnDefinition(TableColumnNames.Request.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpenditureCategoryID = new DataColumnDefinition(TableColumnNames.ExpenditureCategoryID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAmount = new DataColumnDefinition(TableColumnNames.Amount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDeadline = new DataColumnDefinition(TableColumnNames.Deadline.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBeneficiaryID = new DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTrackingID = new DataColumnDefinition(TableColumnNames.TrackingID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDataMonitorID = new DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defRequest.ColumnName, defRequest); 
          ColumnDefns.Add(defExpenditureCategoryID.ColumnName, defExpenditureCategoryID); 
          ColumnDefns.Add(defAmount.ColumnName, defAmount); 
          ColumnDefns.Add(defDeadline.ColumnName, defDeadline); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defTrackingID.ColumnName, defTrackingID); 
          ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_DataMonitorID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "import.DataMonitor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_ExpenditureCategoryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "accounting.ExpenditureCategory"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_BeneficiaryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "common.Person"                  
                            ));                  

          }


                  
       public T___CashRequest() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___CashRequest(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___CashRequest(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___CashRequest(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "accounting.CashRequest";
       public const string CashRequest__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Request], [ExpenditureCategoryID], [Amount], [Deadline], [CreatedAt], [CreatedByID], [BeneficiaryID], [TrackingID], [DataMonitorID] FROM CashRequest";
       public const string CashRequest__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Request], [ExpenditureCategoryID], [Amount], [Deadline], [CreatedAt], [CreatedByID], [BeneficiaryID], [TrackingID], [DataMonitorID] FROM CashRequest";


       public enum TableColumnNames
       {

           ID,
           Request,
           ExpenditureCategoryID,
           Amount,
           Deadline,
           CreatedAt,
           CreatedByID,
           BeneficiaryID,
           TrackingID,
           DataMonitorID
       } 



       public enum TableConstraints{

           pk_accounting_CashRequest, 
           fk_accounting_CashRequest_DataMonitorID, 
           fk_accounting_CashRequest_ExpenditureCategoryID, 
           fk_accounting_CashRequest_CreatedByID, 
           fk_accounting_CashRequest_BeneficiaryID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defRequest;
       public static readonly DataColumnDefinition defExpenditureCategoryID;
       public static readonly DataColumnDefinition defAmount;
       public static readonly DataColumnDefinition defDeadline;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defTrackingID;
       public static readonly DataColumnDefinition defDataMonitorID;

       public String Request {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Request.ToString()]);
           }
       }


       public Int32 ExpenditureCategoryID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ExpenditureCategoryID.ToString()]);
           }
       }


       public Decimal Amount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Amount.ToString()]);
           }
       }


       public NullableDateTime Deadline {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.Deadline.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public Int32 CreatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


       public Int32 BeneficiaryID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BeneficiaryID.ToString()]);
           }
       }


       public Int32 TrackingID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TrackingID.ToString()]);
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
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___CashRequest GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___CashRequest(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___CashRequest GetFullTable()                  
        {                  
            return new T___CashRequest(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___CashRequest GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___CashRequest(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___CashRequest GetRowWhereID(int pID)                  
        {                  
            return new T___CashRequest(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___CashRequest pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___CashRequest pRow, params DataColumnParameter[] pParams)                  
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
        public T___CashRequest GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___CashRequest(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___CashRequest(drst);                  
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
        public T___CashRequest getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___CashRequest(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___CashRequest(drst);                  
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

                  
        public virtual string GetFillSQL() => CashRequest__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pExpenditureCategoryID,
Int32 pCreatedByID,
Int32 pBeneficiaryID,
Int32 pDataMonitorID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramExpenditureCategoryID = new DataColumnParameter(defExpenditureCategoryID, pExpenditureCategoryID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
                DataColumnParameter paramRequest = new DataColumnParameter(defRequest, defRequest.DefaultValue);
                DataColumnParameter paramAmount = new DataColumnParameter(defAmount, defAmount.DefaultValue);
                DataColumnParameter paramDeadline = new DataColumnParameter(defDeadline, defDeadline.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramTrackingID = new DataColumnParameter(defTrackingID, defTrackingID.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramRequest.getSQLQuotedValueForAdd(),
                paramExpenditureCategoryID.getSQLQuotedValueForAdd(),
                paramAmount.getSQLQuotedValueForAdd(),
                paramDeadline.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd(),
                paramBeneficiaryID.getSQLQuotedValueForAdd(),
                paramTrackingID.getSQLQuotedValueForAdd(),
                paramDataMonitorID.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pRequest,
Int32 pExpenditureCategoryID,
Decimal pAmount,
DateTime pDeadline,
DateTime pCreatedAt,
Int32 pCreatedByID,
Int32 pBeneficiaryID,
Object pTrackingID = null,
Object pDataMonitorID = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
                DataColumnParameter paramExpenditureCategoryID = new DataColumnParameter(defExpenditureCategoryID, pExpenditureCategoryID);
                DataColumnParameter paramAmount = new DataColumnParameter(defAmount, pAmount);
                DataColumnParameter paramDeadline = new DataColumnParameter(defDeadline, pDeadline);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
                DataColumnParameter paramTrackingID = new DataColumnParameter(defTrackingID, pTrackingID);
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramExpenditureCategoryID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramDeadline.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramTrackingID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pRequest,
Int32 pExpenditureCategoryID,
Decimal pAmount,
DateTime pDeadline,
DateTime pCreatedAt,
Int32 pCreatedByID,
Int32 pBeneficiaryID,
Object pTrackingID = null,
Object pDataMonitorID = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
DataColumnParameter paramExpenditureCategoryID = new DataColumnParameter(defExpenditureCategoryID, pExpenditureCategoryID);
DataColumnParameter paramAmount = new DataColumnParameter(defAmount, pAmount);
DataColumnParameter paramDeadline = new DataColumnParameter(defDeadline, pDeadline);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
DataColumnParameter paramTrackingID = new DataColumnParameter(defTrackingID, pTrackingID);
DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramExpenditureCategoryID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramDeadline.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramTrackingID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pRequest,
Int32 pExpenditureCategoryID,
Decimal pAmount,
DateTime pDeadline,
DateTime pCreatedAt,
Int32 pCreatedByID,
Int32 pBeneficiaryID,
Object pTrackingID= null,
Object pDataMonitorID= null){

        try{

DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
DataColumnParameter paramExpenditureCategoryID = new DataColumnParameter(defExpenditureCategoryID, pExpenditureCategoryID);
DataColumnParameter paramAmount = new DataColumnParameter(defAmount, pAmount);
DataColumnParameter paramDeadline = new DataColumnParameter(defDeadline, pDeadline);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
DataColumnParameter paramTrackingID = new DataColumnParameter(defTrackingID, pTrackingID);
DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) ", TABLE_NAME,paramRequest.getSQLQuotedValueForAdd(),
paramExpenditureCategoryID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramDeadline.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramTrackingID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), true);


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
Object pRequest = null,
Object pExpenditureCategoryID = null,
Object pAmount = null,
Object pDeadline = null,
Object pCreatedAt = null,
Object pCreatedByID = null,
Object pBeneficiaryID = null,
Object pTrackingID = null,
Object pDataMonitorID = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramRequest = new DataColumnParameter(defRequest, pRequest);
 DataColumnParameter paramExpenditureCategoryID = new DataColumnParameter(defExpenditureCategoryID, pExpenditureCategoryID);
 DataColumnParameter paramAmount = new DataColumnParameter(defAmount, pAmount);
 DataColumnParameter paramDeadline = new DataColumnParameter(defDeadline, pDeadline);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
 DataColumnParameter paramTrackingID = new DataColumnParameter(defTrackingID, pTrackingID);
 DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [Request]={2},[ExpenditureCategoryID]={3},[Amount]={4},[Deadline]={5},[CreatedAt]={6},[CreatedByID]={7},[BeneficiaryID]={8},[TrackingID]={9},[DataMonitorID]={10} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramRequest.getSQLQuotedValueForUpdate(),
paramExpenditureCategoryID.getSQLQuotedValueForUpdate(),
paramAmount.getSQLQuotedValueForUpdate(),
paramDeadline.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramBeneficiaryID.getSQLQuotedValueForUpdate(),
paramTrackingID.getSQLQuotedValueForUpdate(),
paramDataMonitorID.getSQLQuotedValueForUpdate()  ), true);


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
