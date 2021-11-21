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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.charity                  
{                  

    public class V___CenterView : Sample__Table, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static V___CenterView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defName = new DataColumnDefinition(TableColumnNames.Name.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(TableColumnNames.Address.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorName = new DataColumnDefinition(TableColumnNames.PastorName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorEmail = new DataColumnDefinition(TableColumnNames.PastorEmail.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorPhone = new DataColumnDefinition(TableColumnNames.PastorPhone.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorAddress = new DataColumnDefinition(TableColumnNames.PastorAddress.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorID = new DataColumnDefinition(TableColumnNames.PastorID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorPersonID = new DataColumnDefinition(TableColumnNames.PastorPersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiaryCount = new DataColumnDefinition(TableColumnNames.BeneficiaryCount.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChurchCapacity = new DataColumnDefinition(TableColumnNames.ChurchCapacity.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterStatusID = new DataColumnDefinition(TableColumnNames.CenterStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterStatus = new DataColumnDefinition(TableColumnNames.CenterStatus.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defPastorName.ColumnName, defPastorName); 
          ColumnDefns.Add(defPastorEmail.ColumnName, defPastorEmail); 
          ColumnDefns.Add(defPastorPhone.ColumnName, defPastorPhone); 
          ColumnDefns.Add(defPastorAddress.ColumnName, defPastorAddress); 
          ColumnDefns.Add(defPastorID.ColumnName, defPastorID); 
          ColumnDefns.Add(defPastorPersonID.ColumnName, defPastorPersonID); 
          ColumnDefns.Add(defBeneficiaryCount.ColumnName, defBeneficiaryCount); 
          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defChurchCapacity.ColumnName, defChurchCapacity); 
          ColumnDefns.Add(defCenterStatusID.ColumnName, defCenterStatusID); 
          ColumnDefns.Add(defCenterStatus.ColumnName, defCenterStatus); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("charity.Beneficiary");                  
            ReferencedTableNames.Add("charity.Center");                  
            ReferencedTableNames.Add("charity.CenterStatus");                  
            ReferencedTableNames.Add("charity.ResidingPastor");                  
            ReferencedTableNames.Add("common.PersonView");                  

          }


                  
       public V___CenterView() : base()                  
        {                  
        }                  


                  
        #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public V___CenterView(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public V___CenterView(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public V___CenterView(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
#endregion                                    
                                    
                                    
                                    
#region Consts and Enums                       

       public const string TABLE_NAME = "charity.CenterView";
       public const string CenterView__NO__BINARY___SQL_FILL_QUERY = "SELECT [Name], [Address], [PastorName], [PastorEmail], [PastorPhone], [PastorAddress], [PastorID], [PastorPersonID], [BeneficiaryCount], [ID], [ChurchCapacity], [CenterStatusID], [CenterStatus] FROM CenterView";
       public const string CenterView__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [Name], [Address], [PastorName], [PastorEmail], [PastorPhone], [PastorAddress], [PastorID], [PastorPersonID], [BeneficiaryCount], [ID], [ChurchCapacity], [CenterStatusID], [CenterStatus] FROM CenterView";


       public enum TableColumnNames
       {

           Name,
           Address,
           PastorName,
           PastorEmail,
           PastorPhone,
           PastorAddress,
           PastorID,
           PastorPersonID,
           BeneficiaryCount,
           ID,
           ChurchCapacity,
           CenterStatusID,
           CenterStatus
       } 


 #endregion 


 #region Properties 

       private static List<string> ReferencedTableNames;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defPastorName;
       public static readonly DataColumnDefinition defPastorEmail;
       public static readonly DataColumnDefinition defPastorPhone;
       public static readonly DataColumnDefinition defPastorAddress;
       public static readonly DataColumnDefinition defPastorID;
       public static readonly DataColumnDefinition defPastorPersonID;
       public static readonly DataColumnDefinition defBeneficiaryCount;
       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defChurchCapacity;
       public static readonly DataColumnDefinition defCenterStatusID;
       public static readonly DataColumnDefinition defCenterStatus;

       public String Name {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Name.ToString()]);
           }
       }


       public String Address {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Address.ToString()]);
           }
       }


       public String PastorName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PastorName.ToString()]);
           }
       }


       public String PastorEmail {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PastorEmail.ToString()]);
           }
       }


       public String PastorPhone {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PastorPhone.ToString()]);
           }
       }


       public String PastorAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PastorAddress.ToString()]);
           }
       }


       public Int32 PastorID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PastorID.ToString()]);
           }
       }


       public Int32 PastorPersonID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PastorPersonID.ToString()]);
           }
       }


       public Int32 BeneficiaryCount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BeneficiaryCount.ToString()]);
           }
       }


       public Int32 ChurchCapacity {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ChurchCapacity.ToString()]);
           }
       }


       public Int32 CenterStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CenterStatusID.ToString()]);
           }
       }


       public String CenterStatus {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.CenterStatus.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public V___CenterView GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new V___CenterView(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static V___CenterView GetFullTable()                  
        {                  
            return new V___CenterView(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static V___CenterView GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new V___CenterView(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public V___CenterView GetRowWhereID(int pID)                  
        {                  
            return new V___CenterView(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(V___CenterView pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(V___CenterView pRow, params DataColumnParameter[] pParams)                  
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
        public V___CenterView GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new V___CenterView(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___CenterView(drst);                  
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
        public V___CenterView getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new V___CenterView(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___CenterView(drst);                  
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
