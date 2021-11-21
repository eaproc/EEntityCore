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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___DonationInvoiceItem : Sample__Table, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___DonationInvoiceItem()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defMonthlyDonationID = new DataColumnDefinition(TableColumnNames.MonthlyDonationID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBeneficiaryID = new DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defCashOutID = new DataColumnDefinition(TableColumnNames.CashOutID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defDonationYear = new DataColumnDefinition(TableColumnNames.DonationYear.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defDonationMonth = new DataColumnDefinition(TableColumnNames.DonationMonth.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defAmount = new DataColumnDefinition(TableColumnNames.Amount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defMonthlyDonationID.ColumnName, defMonthlyDonationID); 
          ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID); 
          ColumnDefns.Add(defCashOutID.ColumnName, defCashOutID); 
          ColumnDefns.Add(defDonationYear.ColumnName, defDonationYear); 
          ColumnDefns.Add(defDonationMonth.ColumnName, defDonationMonth); 
          ColumnDefns.Add(defAmount.ColumnName, defAmount); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_DonationInvoiceItem_MonthlyDonationID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.DonationInvoiceItem", "charity.MonthlyDonation"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_DonationInvoiceItem_BeneficiaryID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.DonationInvoiceItem", "charity.Beneficiary"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_DonationInvoiceItem_CashOutID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.DonationInvoiceItem", "charity.CashOut"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_DonationInvoiceItem_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.DonationInvoiceItem", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_DonationInvoiceItem_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.DonationInvoiceItem", "auth.Users"                  
                            ));                  

          }


                  
       public T___DonationInvoiceItem() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___DonationInvoiceItem(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___DonationInvoiceItem(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___DonationInvoiceItem(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "charity.DonationInvoiceItem";
       public const string DonationInvoiceItem__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [MonthlyDonationID], [BeneficiaryID], [CashOutID], [DonationYear], [DonationMonth], [Amount], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM DonationInvoiceItem";
       public const string DonationInvoiceItem__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [MonthlyDonationID], [BeneficiaryID], [CashOutID], [DonationYear], [DonationMonth], [Amount], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM DonationInvoiceItem";


       public enum TableColumnNames
       {

           ID,
           MonthlyDonationID,
           BeneficiaryID,
           CashOutID,
           DonationYear,
           DonationMonth,
           Amount,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_DonationInvoiceItem, 
           fk_charity_DonationInvoiceItem_MonthlyDonationID, 
           fk_charity_DonationInvoiceItem_BeneficiaryID, 
           fk_charity_DonationInvoiceItem_CashOutID, 
           fk_charity_DonationInvoiceItem_CreatedByID, 
           fk_charity_DonationInvoiceItem_UpdatedByID, 
           uq_charity_DonationInvoiceItem_BeneficiaryID, 
       } 


 #endregion 


 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defMonthlyDonationID;
       public static readonly DataColumnDefinition defBeneficiaryID;
       public static readonly DataColumnDefinition defCashOutID;
       public static readonly DataColumnDefinition defDonationYear;
       public static readonly DataColumnDefinition defDonationMonth;
       public static readonly DataColumnDefinition defAmount;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public Int32 MonthlyDonationID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.MonthlyDonationID.ToString()]);
           }
       }


       public Int32 BeneficiaryID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BeneficiaryID.ToString()]);
           }
       }


       public Int32 CashOutID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CashOutID.ToString()]);
           }
       }


       public Int32 DonationYear {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DonationYear.ToString()]);
           }
       }


       public Int32 DonationMonth {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DonationMonth.ToString()]);
           }
       }


       public Decimal Amount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Amount.ToString()]);
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


       public Int32 CreatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


       public Int32 UpdatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UpdatedByID.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___DonationInvoiceItem GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___DonationInvoiceItem(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___DonationInvoiceItem GetFullTable()                  
        {                  
            return new T___DonationInvoiceItem(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___DonationInvoiceItem GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___DonationInvoiceItem(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___DonationInvoiceItem GetRowWhereID(int pID)                  
        {                  
            return new T___DonationInvoiceItem(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___DonationInvoiceItem pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___DonationInvoiceItem pRow, params DataColumnParameter[] pParams)                  
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
        public T___DonationInvoiceItem GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___DonationInvoiceItem(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___DonationInvoiceItem(drst);                  
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
        public T___DonationInvoiceItem getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___DonationInvoiceItem(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___DonationInvoiceItem(drst);                  
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

                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> getForeignKeys()                  
        {                  
            return ForeignKeys;                  
        }                  
                  
        public string getTableName()                  
        {                  
            return TABLE_NAME;                  
        }                  

                  
        public virtual string getFillSQL(){                
            return DonationInvoiceItem__NO__BINARY___SQL_FILL_QUERY;                  
        }                  
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pMonthlyDonationID,
Int32 pBeneficiaryID,
Int32 pCashOutID,
Int32 pDonationYear,
Int32 pDonationMonth,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramMonthlyDonationID = new DataColumnParameter(defMonthlyDonationID, pMonthlyDonationID);
                DataColumnParameter paramBeneficiaryID = new DataColumnParameter(defBeneficiaryID, pBeneficiaryID);
                DataColumnParameter paramCashOutID = new DataColumnParameter(defCashOutID, pCashOutID);
                DataColumnParameter paramDonationYear = new DataColumnParameter(defDonationYear, pDonationYear);
                DataColumnParameter paramDonationMonth = new DataColumnParameter(defDonationMonth, pDonationMonth);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramAmount = new DataColumnParameter(defAmount, defAmount.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[MonthlyDonationID],[BeneficiaryID],[CashOutID],[DonationYear],[DonationMonth],[Amount],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramMonthlyDonationID.getSQLQuotedValueForAdd(),
                paramBeneficiaryID.getSQLQuotedValueForAdd(),
                paramCashOutID.getSQLQuotedValueForAdd(),
                paramDonationYear.getSQLQuotedValueForAdd(),
                paramDonationMonth.getSQLQuotedValueForAdd(),
                paramAmount.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramUpdatedAt.getSQLQuotedValueForAdd(),
                paramCreatedByID.getSQLQuotedValueForAdd(),
                paramUpdatedByID.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
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
