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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.accounting                  
{                  

    public class V___TurnOverPerClient : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___TurnOverPerClient()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defClientID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Name.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBillTotal = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BillTotal.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defArrears = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Arrears.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentMade = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentMade.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDiscount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Discount.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBalanceDue = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BalanceDue.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSurplus = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Surplus.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defBillTotal.ColumnName, defBillTotal); 
          ColumnDefns.Add(defArrears.ColumnName, defArrears); 
          ColumnDefns.Add(defPaymentMade.ColumnName, defPaymentMade); 
          ColumnDefns.Add(defDiscount.ColumnName, defDiscount); 
          ColumnDefns.Add(defBalanceDue.ColumnName, defBalanceDue); 
          ColumnDefns.Add(defSurplus.ColumnName, defSurplus); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("accounting.Invoice");                  
            ReferencedTableNames.Add("accounting.Payment");                  
            ReferencedTableNames.Add("common.Person");                  
            ReferencedTableNames.Add("hr.Client");                  

          }


                  
       public V___TurnOverPerClient() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TurnOverPerClient(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___TurnOverPerClient(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___TurnOverPerClient(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___TurnOverPerClient(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___TurnOverPerClient(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TurnOverPerClient(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TurnOverPerClient(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___TurnOverPerClient(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public V___TurnOverPerClient(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.TurnOverPerClient";
       public const string TurnOverPerClient__NO__BINARY___SQL_FILL_QUERY = "SELECT [ClientID], [Name], [BillTotal], [Arrears], [PaymentMade], [Discount], [BalanceDue], [Surplus] FROM TurnOverPerClient";
       public const string TurnOverPerClient__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ClientID], [Name], [BillTotal], [Arrears], [PaymentMade], [Discount], [BalanceDue], [Surplus] FROM TurnOverPerClient";


       public enum TableColumnNames
       {

           ClientID,
           Name,
           BillTotal,
           Arrears,
           PaymentMade,
           Discount,
           BalanceDue,
           Surplus
       } 


 #endregion 




 #region Properties 

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defBillTotal;
       public static readonly DataColumnDefinition defArrears;
       public static readonly DataColumnDefinition defPaymentMade;
       public static readonly DataColumnDefinition defDiscount;
       public static readonly DataColumnDefinition defBalanceDue;
       public static readonly DataColumnDefinition defSurplus;

       public Int32 ClientID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ClientID.ToString()]);
           }
       }


       public String Name {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Name.ToString()]);
           }
       }


       public Decimal BillTotal {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.BillTotal.ToString()]);
           }
       }


       public Decimal Arrears {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Arrears.ToString()]);
           }
       }


       public Decimal PaymentMade {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PaymentMade.ToString()]);
           }
       }


       public Decimal Discount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Discount.ToString()]);
           }
       }


       public Decimal BalanceDue {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.BalanceDue.ToString()]);
           }
       }


       public Decimal Surplus {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Surplus.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public V___TurnOverPerClient GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static V___TurnOverPerClient GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static V___TurnOverPerClient GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new V___TurnOverPerClient(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public V___TurnOverPerClient GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => TurnOverPerClient__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
