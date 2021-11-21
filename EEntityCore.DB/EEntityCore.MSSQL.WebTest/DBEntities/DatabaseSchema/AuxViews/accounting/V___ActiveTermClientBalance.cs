using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.accounting                  
{                  

    public class V___ActiveTermClientBalance : Sample__Table, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static V___ActiveTermClientBalance()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defClientID = new DataColumnDefinition(TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermID = new DataColumnDefinition(TableColumnNames.TermID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTerm = new DataColumnDefinition(TableColumnNames.Term.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCompanyName = new DataColumnDefinition(TableColumnNames.CompanyName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defName = new DataColumnDefinition(TableColumnNames.Name.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(TableColumnNames.FullName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillTotal = new DataColumnDefinition(TableColumnNames.BillTotal.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defArrears = new DataColumnDefinition(TableColumnNames.Arrears.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentMade = new DataColumnDefinition(TableColumnNames.PaymentMade.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDiscount = new DataColumnDefinition(TableColumnNames.Discount.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalanceDue = new DataColumnDefinition(TableColumnNames.BalanceDue.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSurplus = new DataColumnDefinition(TableColumnNames.Surplus.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defTerm.ColumnName, defTerm); 
          ColumnDefns.Add(defCompanyName.ColumnName, defCompanyName); 
          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defFullName.ColumnName, defFullName); 
          ColumnDefns.Add(defBillTotal.ColumnName, defBillTotal); 
          ColumnDefns.Add(defArrears.ColumnName, defArrears); 
          ColumnDefns.Add(defPaymentMade.ColumnName, defPaymentMade); 
          ColumnDefns.Add(defDiscount.ColumnName, defDiscount); 
          ColumnDefns.Add(defBalanceDue.ColumnName, defBalanceDue); 
          ColumnDefns.Add(defSurplus.ColumnName, defSurplus); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("academic.Term");                  
            ReferencedTableNames.Add("accounting.Invoice");                  
            ReferencedTableNames.Add("accounting.Payment");                  
            ReferencedTableNames.Add("common.PersonView");                  
            ReferencedTableNames.Add("hr.Client");                  

          }


                  
        public V___ActiveTermClientBalance() : base(TABLE_NAME)                  
        {                  
        }                  


                  
                  
        #region Full Access                  
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                    
                  
        /// <summary>                                    
        /// FULL ACCESS. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="TableName"></param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance(All__DBs DBConn, string TableName) : base(DBConn, TableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance(All__DBs DBConn, string pTableName, long pTargettedRowID) : base(DBConn, pTableName, pTargettedRowID: pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance(All__DBs pDBConn, string pTableName, string pSQL) : base(pDBConn, pTableName, pSQL)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance(All__DBs pDBConn, string pTableName, string pSQL, long pTargettedRowID) : base(pDBConn, pTableName, pSQL, pTargettedRowID)                  
        {                  
        }                  
                  
        #endregion                  
                  
                  
        #region Partial Access                  
                  
        // Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work                                    
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance(DataRowCollection pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="FullTable"></param>                                    
        /// <param name="TargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance(DataTable FullTable, int TargettedRowID, string TableName, All__DBs DBConn) : base(FullTable, TargettedRowID, TableName, DBConn)                  
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
        public V___ActiveTermClientBalance(DataRow TargettedRow) : base(TargettedRow)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermClientBalance(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermClientBalance(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermClientBalance(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName) : base(pTableRows, pTargettedRowID, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance(DataTable FullTable, string pTableName) : base(FullTable, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance(DataTable FullTable, string pTableName, long pTargettedRowID) : base(FullTable, pTableName, pTargettedRowID)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance(DataRowCollection pDataRows, string pTableName) : base(pDataRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermClientBalance(IEnumerable<DataRow> pTableRows, string pTableName) : base(pTableRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access. Should always target this passed in                                    
        /// </summary>                                    
        /// <param name="pTargettedRow"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___ActiveTermClientBalance(DataRow pTargettedRow, string pTableName) : base(pTargettedRow, pTableName)                  
        {                  
        }                  
                  
                  
        #endregion                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
#endregion                  
                  
                  
                  
#region Consts and Enums                  

       public const string TABLE_NAME = "accounting.ActiveTermClientBalance";
       public const string ActiveTermClientBalance__NO__BINARY___SQL_FILL_QUERY = "SELECT [ClientID], [TermID], [Term], [CompanyName], [Name], [FullName], [BillTotal], [Arrears], [PaymentMade], [Discount], [BalanceDue], [Surplus] FROM ActiveTermClientBalance";
       public const string ActiveTermClientBalance__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ClientID], [TermID], [Term], [CompanyName], [Name], [FullName], [BillTotal], [Arrears], [PaymentMade], [Discount], [BalanceDue], [Surplus] FROM ActiveTermClientBalance";


       public enum TableColumnNames
       {

           ClientID,
           TermID,
           Term,
           CompanyName,
           Name,
           FullName,
           BillTotal,
           Arrears,
           PaymentMade,
           Discount,
           BalanceDue,
           Surplus
       } 


 #endregion 


 #region Properties 

        private static List<string> ReferencedTableNames;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defTerm;
       public static readonly DataColumnDefinition defCompanyName;
       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defFullName;
       public static readonly DataColumnDefinition defBillTotal;
       public static readonly DataColumnDefinition defArrears;
       public static readonly DataColumnDefinition defPaymentMade;
       public static readonly DataColumnDefinition defDiscount;
       public static readonly DataColumnDefinition defBalanceDue;
       public static readonly DataColumnDefinition defSurplus;

       public Int32 ClientID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ClientID.ToString()]);
           }
       }


       public Int32 TermID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TermID.ToString()]);
           }
       }


       public String Term {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Term.ToString()]);
           }
       }


       public String CompanyName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.CompanyName.ToString()]);
           }
       }


       public String Name {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Name.ToString()]);
           }
       }


       public String FullName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FullName.ToString()]);
           }
       }


       public Decimal BillTotal {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.BillTotal.ToString()]);
           }
       }


       public Decimal Arrears {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Arrears.ToString()]);
           }
       }


       public Decimal PaymentMade {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PaymentMade.ToString()]);
           }
       }


       public Decimal Discount {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Discount.ToString()]);
           }
       }


       public Decimal BalanceDue {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.BalanceDue.ToString()]);
           }
       }


       public Decimal Surplus {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Surplus.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public V___ActiveTermClientBalance getFirstRow()                  
        {                  
            if (this.hasRows())                  
                return new V___ActiveTermClientBalance(this.AllRows.ToArray()[0]);                  
            return null;                  
        }                  
                  
        public static V___ActiveTermClientBalance getFullTable()                  
        {                  
            return new V___ActiveTermClientBalance(DatabaseInit.DBConnectInterface.GetDBConn(), TABLE_NAME);                  
        }                  
                  
        public static V___ActiveTermClientBalance getRowWhereIDUsingSQL(int pID)                  
        {                  
            return new V___ActiveTermClientBalance(DBConnectInterface.GetDBConn(), TABLE_NAME, string.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, (object)pID)).getFirstRow();                  
        }                  
                  
        public V___ActiveTermClientBalance getRowWhereID(int pID)                  
        {                  
            return new V___ActiveTermClientBalance(this.RawTable, TABLE_NAME, pID);                  
        }                  
                  
        private bool IsAllRowEqual(V___ActiveTermClientBalance pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.hasRows())                  
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
                  
        private bool IsAnyRowEqual(V___ActiveTermClientBalance pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.hasRows())                  
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
        public V___ActiveTermClientBalance getAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new V___ActiveTermClientBalance(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___ActiveTermClientBalance(drst.CopyToDataTable(), TABLE_NAME);                  
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
        public V___ActiveTermClientBalance getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new V___ActiveTermClientBalance(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___ActiveTermClientBalance(drst.CopyToDataTable(), TABLE_NAME);                  
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
                if (!this.isTargettedRowValid())                  
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

                  
    public List<string> getReferencedTableNames()                  
    {                  
        return ReferencedTableNames;                  
    }                  
                  
    public string getViewName()                  
    {                  
        return TABLE_NAME;                  
    }                  

                  
                  
#endregion                  
                  
                  



   }


}
