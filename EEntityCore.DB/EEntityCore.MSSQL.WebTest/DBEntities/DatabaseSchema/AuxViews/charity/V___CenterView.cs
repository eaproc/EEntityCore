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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.charity                  
{                  

    public class V___CenterView : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static V___CenterView()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Name.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Address.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PastorName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorEmail = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PastorEmail.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorPhone = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PastorPhone.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PastorAddress.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PastorID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPastorPersonID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PastorPersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiaryCount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BeneficiaryCount.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChurchCapacity = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ChurchCapacity.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CenterStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterStatus = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CenterStatus.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       private static readonly List<string> ReferencedTableNames;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public string Name { get => (string)TargettedRow[TableColumnNames.Name.ToString()]; }


       public string Address { get => (string)TargettedRow[TableColumnNames.Address.ToString()]; }


       public string PastorName { get => (string)TargettedRow[TableColumnNames.PastorName.ToString()]; }


       public string PastorEmail { get => (string)TargettedRow[TableColumnNames.PastorEmail.ToString()]; }


       public string PastorPhone { get => (string)TargettedRow[TableColumnNames.PastorPhone.ToString()]; }


       public string PastorAddress { get => (string)TargettedRow[TableColumnNames.PastorAddress.ToString()]; }


       public int PastorID { get => (int)TargettedRow[TableColumnNames.PastorID.ToString()]; }


       public int PastorPersonID { get => (int)TargettedRow[TableColumnNames.PastorPersonID.ToString()]; }


       public int? BeneficiaryCount { get => (int?)TargettedRow[TableColumnNames.BeneficiaryCount.ToString()]; }


       public int ChurchCapacity { get => (int)TargettedRow[TableColumnNames.ChurchCapacity.ToString()]; }


       public int CenterStatusID { get => (int)TargettedRow[TableColumnNames.CenterStatusID.ToString()]; }


       public string CenterStatus { get => (string)TargettedRow[TableColumnNames.CenterStatus.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public V___CenterView GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static V___CenterView GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static V___CenterView GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new V___CenterView(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public V___CenterView GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => CenterView__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<string> GetReferencedTableNames() => ReferencedTableNames;                  
                  
        public string GetViewName() => TableName;

                  
                  
 #endregion                  
                  
                  



   }


}
