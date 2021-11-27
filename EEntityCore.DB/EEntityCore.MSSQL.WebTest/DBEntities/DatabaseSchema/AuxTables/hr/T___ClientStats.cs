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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.hr                  
{                  

    public class T___ClientStats : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ClientStats()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defClientID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTermID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defRegisteredStudentCount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RegisteredStudentCount.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAssignedStudentCount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AssignedStudentCount.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSCADWAREAccessCount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SCADWAREAccessCount.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSCADWAREAccessThreshold = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SCADWAREAccessThreshold.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAverageTermBill = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AverageTermBill.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRatePerStudent = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.RatePerStudent.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBilledPerStudent = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BilledPerStudent.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTotalReceivedOnSCADWAREBill = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TotalReceivedOnSCADWAREBill.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMinimumExpectedOnSCADWAREBill = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MinimumExpectedOnSCADWAREBill.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defExpectedOnSCADWAREBill = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ExpectedOnSCADWAREBill.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIPAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IPAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullScholarshipStudentCount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FullScholarshipStudentCount.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermStartDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermStartDate.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTermEndDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermEndDate.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defRegisteredStudentCount.ColumnName, defRegisteredStudentCount); 
          ColumnDefns.Add(defAssignedStudentCount.ColumnName, defAssignedStudentCount); 
          ColumnDefns.Add(defSCADWAREAccessCount.ColumnName, defSCADWAREAccessCount); 
          ColumnDefns.Add(defSCADWAREAccessThreshold.ColumnName, defSCADWAREAccessThreshold); 
          ColumnDefns.Add(defAverageTermBill.ColumnName, defAverageTermBill); 
          ColumnDefns.Add(defRatePerStudent.ColumnName, defRatePerStudent); 
          ColumnDefns.Add(defBilledPerStudent.ColumnName, defBilledPerStudent); 
          ColumnDefns.Add(defTotalReceivedOnSCADWAREBill.ColumnName, defTotalReceivedOnSCADWAREBill); 
          ColumnDefns.Add(defMinimumExpectedOnSCADWAREBill.ColumnName, defMinimumExpectedOnSCADWAREBill); 
          ColumnDefns.Add(defExpectedOnSCADWAREBill.ColumnName, defExpectedOnSCADWAREBill); 
          ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defFullScholarshipStudentCount.ColumnName, defFullScholarshipStudentCount); 
          ColumnDefns.Add(defTermStartDate.ColumnName, defTermStartDate); 
          ColumnDefns.Add(defTermEndDate.ColumnName, defTermEndDate); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_ClientStats_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "hr.ClientStats", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_ClientStats_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.ClientStats", "academic.Term"                  
                            ));                  

          }


                  
       public T___ClientStats() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ClientStats(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ClientStats(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___ClientStats(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.ClientStats";
       public const string ClientStats__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [TermID], [RegisteredStudentCount], [AssignedStudentCount], [SCADWAREAccessCount], [SCADWAREAccessThreshold], [AverageTermBill], [RatePerStudent], [BilledPerStudent], [TotalReceivedOnSCADWAREBill], [MinimumExpectedOnSCADWAREBill], [ExpectedOnSCADWAREBill], [IPAddress], [CreatedAt], [FullScholarshipStudentCount], [TermStartDate], [TermEndDate] FROM ClientStats";
       public const string ClientStats__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [ClientID], [TermID], [RegisteredStudentCount], [AssignedStudentCount], [SCADWAREAccessCount], [SCADWAREAccessThreshold], [AverageTermBill], [RatePerStudent], [BilledPerStudent], [TotalReceivedOnSCADWAREBill], [MinimumExpectedOnSCADWAREBill], [ExpectedOnSCADWAREBill], [IPAddress], [CreatedAt], [FullScholarshipStudentCount], [TermStartDate], [TermEndDate] FROM ClientStats";


       public enum TableColumnNames
       {

           ID,
           ClientID,
           TermID,
           RegisteredStudentCount,
           AssignedStudentCount,
           SCADWAREAccessCount,
           SCADWAREAccessThreshold,
           AverageTermBill,
           RatePerStudent,
           BilledPerStudent,
           TotalReceivedOnSCADWAREBill,
           MinimumExpectedOnSCADWAREBill,
           ExpectedOnSCADWAREBill,
           IPAddress,
           CreatedAt,
           FullScholarshipStudentCount,
           TermStartDate,
           TermEndDate
       } 



       public enum TableConstraints{

           pk_hr_ClientStats, 
           fk_hr_ClientStats_ClientID, 
           fk_hr_ClientStats_TermID, 
       } 


 #endregion 




 #region Properties 

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defRegisteredStudentCount;
       public static readonly DataColumnDefinition defAssignedStudentCount;
       public static readonly DataColumnDefinition defSCADWAREAccessCount;
       public static readonly DataColumnDefinition defSCADWAREAccessThreshold;
       public static readonly DataColumnDefinition defAverageTermBill;
       public static readonly DataColumnDefinition defRatePerStudent;
       public static readonly DataColumnDefinition defBilledPerStudent;
       public static readonly DataColumnDefinition defTotalReceivedOnSCADWAREBill;
       public static readonly DataColumnDefinition defMinimumExpectedOnSCADWAREBill;
       public static readonly DataColumnDefinition defExpectedOnSCADWAREBill;
       public static readonly DataColumnDefinition defIPAddress;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defFullScholarshipStudentCount;
       public static readonly DataColumnDefinition defTermStartDate;
       public static readonly DataColumnDefinition defTermEndDate;

       public Int32 ClientID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ClientID.ToString()]);
           }
       }


       public Int32 TermID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TermID.ToString()]);
           }
       }


       public Int32 RegisteredStudentCount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.RegisteredStudentCount.ToString()]);
           }
       }


       public Int32 AssignedStudentCount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.AssignedStudentCount.ToString()]);
           }
       }


       public Int32 SCADWAREAccessCount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.SCADWAREAccessCount.ToString()]);
           }
       }


       public Decimal SCADWAREAccessThreshold {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.SCADWAREAccessThreshold.ToString()]);
           }
       }


       public Decimal AverageTermBill {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.AverageTermBill.ToString()]);
           }
       }


       public Decimal RatePerStudent {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.RatePerStudent.ToString()]);
           }
       }


       public Decimal BilledPerStudent {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.BilledPerStudent.ToString()]);
           }
       }


       public Decimal TotalReceivedOnSCADWAREBill {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.TotalReceivedOnSCADWAREBill.ToString()]);
           }
       }


       public Decimal MinimumExpectedOnSCADWAREBill {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.MinimumExpectedOnSCADWAREBill.ToString()]);
           }
       }


       public Decimal ExpectedOnSCADWAREBill {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.ExpectedOnSCADWAREBill.ToString()]);
           }
       }


       public String IPAddress {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IPAddress.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public Int32 FullScholarshipStudentCount {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.FullScholarshipStudentCount.ToString()]);
           }
       }


       public NullableDateTime TermStartDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.TermStartDate.ToString()]);
           }
       }


       public NullableDateTime TermEndDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.TermEndDate.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___ClientStats GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___ClientStats GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___ClientStats GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___ClientStats(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___ClientStats GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => ClientStats__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pClientID,
Int32 pTermID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
                DataColumnParameter paramRegisteredStudentCount = new DataColumnParameter(defRegisteredStudentCount, defRegisteredStudentCount.DefaultValue);
                DataColumnParameter paramAssignedStudentCount = new DataColumnParameter(defAssignedStudentCount, defAssignedStudentCount.DefaultValue);
                DataColumnParameter paramSCADWAREAccessCount = new DataColumnParameter(defSCADWAREAccessCount, defSCADWAREAccessCount.DefaultValue);
                DataColumnParameter paramSCADWAREAccessThreshold = new DataColumnParameter(defSCADWAREAccessThreshold, defSCADWAREAccessThreshold.DefaultValue);
                DataColumnParameter paramAverageTermBill = new DataColumnParameter(defAverageTermBill, defAverageTermBill.DefaultValue);
                DataColumnParameter paramRatePerStudent = new DataColumnParameter(defRatePerStudent, defRatePerStudent.DefaultValue);
                DataColumnParameter paramBilledPerStudent = new DataColumnParameter(defBilledPerStudent, defBilledPerStudent.DefaultValue);
                DataColumnParameter paramTotalReceivedOnSCADWAREBill = new DataColumnParameter(defTotalReceivedOnSCADWAREBill, defTotalReceivedOnSCADWAREBill.DefaultValue);
                DataColumnParameter paramMinimumExpectedOnSCADWAREBill = new DataColumnParameter(defMinimumExpectedOnSCADWAREBill, defMinimumExpectedOnSCADWAREBill.DefaultValue);
                DataColumnParameter paramExpectedOnSCADWAREBill = new DataColumnParameter(defExpectedOnSCADWAREBill, defExpectedOnSCADWAREBill.DefaultValue);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, defIPAddress.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramFullScholarshipStudentCount = new DataColumnParameter(defFullScholarshipStudentCount, defFullScholarshipStudentCount.DefaultValue);
                DataColumnParameter paramTermStartDate = new DataColumnParameter(defTermStartDate, defTermStartDate.DefaultValue);
                DataColumnParameter paramTermEndDate = new DataColumnParameter(defTermEndDate, defTermEndDate.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramClientID.GetSQLQuotedValueForAdd(),
                paramTermID.GetSQLQuotedValueForAdd(),
                paramRegisteredStudentCount.GetSQLQuotedValueForAdd(),
                paramAssignedStudentCount.GetSQLQuotedValueForAdd(),
                paramSCADWAREAccessCount.GetSQLQuotedValueForAdd(),
                paramSCADWAREAccessThreshold.GetSQLQuotedValueForAdd(),
                paramAverageTermBill.GetSQLQuotedValueForAdd(),
                paramRatePerStudent.GetSQLQuotedValueForAdd(),
                paramBilledPerStudent.GetSQLQuotedValueForAdd(),
                paramTotalReceivedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
                paramMinimumExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
                paramExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
                paramIPAddress.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramFullScholarshipStudentCount.GetSQLQuotedValueForAdd(),
                paramTermStartDate.GetSQLQuotedValueForAdd(),
                paramTermEndDate.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pClientID,
Int32 pTermID,
Int32 pRegisteredStudentCount,
Int32 pAssignedStudentCount,
Int32 pSCADWAREAccessCount,
Decimal pSCADWAREAccessThreshold,
Decimal pAverageTermBill,
Decimal pRatePerStudent,
Decimal pBilledPerStudent,
Decimal pTotalReceivedOnSCADWAREBill,
Decimal pMinimumExpectedOnSCADWAREBill,
Decimal pExpectedOnSCADWAREBill,
String pIPAddress,
DateTime pCreatedAt,
Object pFullScholarshipStudentCount = null,
Object pTermStartDate = null,
Object pTermEndDate = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
                DataColumnParameter paramRegisteredStudentCount = new DataColumnParameter(defRegisteredStudentCount, pRegisteredStudentCount);
                DataColumnParameter paramAssignedStudentCount = new DataColumnParameter(defAssignedStudentCount, pAssignedStudentCount);
                DataColumnParameter paramSCADWAREAccessCount = new DataColumnParameter(defSCADWAREAccessCount, pSCADWAREAccessCount);
                DataColumnParameter paramSCADWAREAccessThreshold = new DataColumnParameter(defSCADWAREAccessThreshold, pSCADWAREAccessThreshold);
                DataColumnParameter paramAverageTermBill = new DataColumnParameter(defAverageTermBill, pAverageTermBill);
                DataColumnParameter paramRatePerStudent = new DataColumnParameter(defRatePerStudent, pRatePerStudent);
                DataColumnParameter paramBilledPerStudent = new DataColumnParameter(defBilledPerStudent, pBilledPerStudent);
                DataColumnParameter paramTotalReceivedOnSCADWAREBill = new DataColumnParameter(defTotalReceivedOnSCADWAREBill, pTotalReceivedOnSCADWAREBill);
                DataColumnParameter paramMinimumExpectedOnSCADWAREBill = new DataColumnParameter(defMinimumExpectedOnSCADWAREBill, pMinimumExpectedOnSCADWAREBill);
                DataColumnParameter paramExpectedOnSCADWAREBill = new DataColumnParameter(defExpectedOnSCADWAREBill, pExpectedOnSCADWAREBill);
                DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramFullScholarshipStudentCount = new DataColumnParameter(defFullScholarshipStudentCount, pFullScholarshipStudentCount);
                DataColumnParameter paramTermStartDate = new DataColumnParameter(defTermStartDate, pTermStartDate);
                DataColumnParameter paramTermEndDate = new DataColumnParameter(defTermEndDate, pTermEndDate);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramClientID.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramRegisteredStudentCount.GetSQLQuotedValueForAdd(),
paramAssignedStudentCount.GetSQLQuotedValueForAdd(),
paramSCADWAREAccessCount.GetSQLQuotedValueForAdd(),
paramSCADWAREAccessThreshold.GetSQLQuotedValueForAdd(),
paramAverageTermBill.GetSQLQuotedValueForAdd(),
paramRatePerStudent.GetSQLQuotedValueForAdd(),
paramBilledPerStudent.GetSQLQuotedValueForAdd(),
paramTotalReceivedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
paramMinimumExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
paramExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramFullScholarshipStudentCount.GetSQLQuotedValueForAdd(),
paramTermStartDate.GetSQLQuotedValueForAdd(),
paramTermEndDate.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pClientID,
Int32 pTermID,
Int32 pRegisteredStudentCount,
Int32 pAssignedStudentCount,
Int32 pSCADWAREAccessCount,
Decimal pSCADWAREAccessThreshold,
Decimal pAverageTermBill,
Decimal pRatePerStudent,
Decimal pBilledPerStudent,
Decimal pTotalReceivedOnSCADWAREBill,
Decimal pMinimumExpectedOnSCADWAREBill,
Decimal pExpectedOnSCADWAREBill,
String pIPAddress,
DateTime pCreatedAt,
Object pFullScholarshipStudentCount = null,
Object pTermStartDate = null,
Object pTermEndDate = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
DataColumnParameter paramRegisteredStudentCount = new DataColumnParameter(defRegisteredStudentCount, pRegisteredStudentCount);
DataColumnParameter paramAssignedStudentCount = new DataColumnParameter(defAssignedStudentCount, pAssignedStudentCount);
DataColumnParameter paramSCADWAREAccessCount = new DataColumnParameter(defSCADWAREAccessCount, pSCADWAREAccessCount);
DataColumnParameter paramSCADWAREAccessThreshold = new DataColumnParameter(defSCADWAREAccessThreshold, pSCADWAREAccessThreshold);
DataColumnParameter paramAverageTermBill = new DataColumnParameter(defAverageTermBill, pAverageTermBill);
DataColumnParameter paramRatePerStudent = new DataColumnParameter(defRatePerStudent, pRatePerStudent);
DataColumnParameter paramBilledPerStudent = new DataColumnParameter(defBilledPerStudent, pBilledPerStudent);
DataColumnParameter paramTotalReceivedOnSCADWAREBill = new DataColumnParameter(defTotalReceivedOnSCADWAREBill, pTotalReceivedOnSCADWAREBill);
DataColumnParameter paramMinimumExpectedOnSCADWAREBill = new DataColumnParameter(defMinimumExpectedOnSCADWAREBill, pMinimumExpectedOnSCADWAREBill);
DataColumnParameter paramExpectedOnSCADWAREBill = new DataColumnParameter(defExpectedOnSCADWAREBill, pExpectedOnSCADWAREBill);
DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramFullScholarshipStudentCount = new DataColumnParameter(defFullScholarshipStudentCount, pFullScholarshipStudentCount);
DataColumnParameter paramTermStartDate = new DataColumnParameter(defTermStartDate, pTermStartDate);
DataColumnParameter paramTermEndDate = new DataColumnParameter(defTermEndDate, pTermEndDate);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramClientID.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramRegisteredStudentCount.GetSQLQuotedValueForAdd(),
paramAssignedStudentCount.GetSQLQuotedValueForAdd(),
paramSCADWAREAccessCount.GetSQLQuotedValueForAdd(),
paramSCADWAREAccessThreshold.GetSQLQuotedValueForAdd(),
paramAverageTermBill.GetSQLQuotedValueForAdd(),
paramRatePerStudent.GetSQLQuotedValueForAdd(),
paramBilledPerStudent.GetSQLQuotedValueForAdd(),
paramTotalReceivedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
paramMinimumExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
paramExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramFullScholarshipStudentCount.GetSQLQuotedValueForAdd(),
paramTermStartDate.GetSQLQuotedValueForAdd(),
paramTermEndDate.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pClientID,
Int32 pTermID,
Int32 pRegisteredStudentCount,
Int32 pAssignedStudentCount,
Int32 pSCADWAREAccessCount,
Decimal pSCADWAREAccessThreshold,
Decimal pAverageTermBill,
Decimal pRatePerStudent,
Decimal pBilledPerStudent,
Decimal pTotalReceivedOnSCADWAREBill,
Decimal pMinimumExpectedOnSCADWAREBill,
Decimal pExpectedOnSCADWAREBill,
String pIPAddress,
DateTime pCreatedAt,
Object pFullScholarshipStudentCount= null,
Object pTermStartDate= null,
Object pTermEndDate= null){

        try{

DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
DataColumnParameter paramRegisteredStudentCount = new DataColumnParameter(defRegisteredStudentCount, pRegisteredStudentCount);
DataColumnParameter paramAssignedStudentCount = new DataColumnParameter(defAssignedStudentCount, pAssignedStudentCount);
DataColumnParameter paramSCADWAREAccessCount = new DataColumnParameter(defSCADWAREAccessCount, pSCADWAREAccessCount);
DataColumnParameter paramSCADWAREAccessThreshold = new DataColumnParameter(defSCADWAREAccessThreshold, pSCADWAREAccessThreshold);
DataColumnParameter paramAverageTermBill = new DataColumnParameter(defAverageTermBill, pAverageTermBill);
DataColumnParameter paramRatePerStudent = new DataColumnParameter(defRatePerStudent, pRatePerStudent);
DataColumnParameter paramBilledPerStudent = new DataColumnParameter(defBilledPerStudent, pBilledPerStudent);
DataColumnParameter paramTotalReceivedOnSCADWAREBill = new DataColumnParameter(defTotalReceivedOnSCADWAREBill, pTotalReceivedOnSCADWAREBill);
DataColumnParameter paramMinimumExpectedOnSCADWAREBill = new DataColumnParameter(defMinimumExpectedOnSCADWAREBill, pMinimumExpectedOnSCADWAREBill);
DataColumnParameter paramExpectedOnSCADWAREBill = new DataColumnParameter(defExpectedOnSCADWAREBill, pExpectedOnSCADWAREBill);
DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramFullScholarshipStudentCount = new DataColumnParameter(defFullScholarshipStudentCount, pFullScholarshipStudentCount);
DataColumnParameter paramTermStartDate = new DataColumnParameter(defTermStartDate, pTermStartDate);
DataColumnParameter paramTermEndDate = new DataColumnParameter(defTermEndDate, pTermEndDate);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) ", TABLE_NAME,paramClientID.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramRegisteredStudentCount.GetSQLQuotedValueForAdd(),
paramAssignedStudentCount.GetSQLQuotedValueForAdd(),
paramSCADWAREAccessCount.GetSQLQuotedValueForAdd(),
paramSCADWAREAccessThreshold.GetSQLQuotedValueForAdd(),
paramAverageTermBill.GetSQLQuotedValueForAdd(),
paramRatePerStudent.GetSQLQuotedValueForAdd(),
paramBilledPerStudent.GetSQLQuotedValueForAdd(),
paramTotalReceivedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
paramMinimumExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
paramExpectedOnSCADWAREBill.GetSQLQuotedValueForAdd(),
paramIPAddress.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramFullScholarshipStudentCount.GetSQLQuotedValueForAdd(),
paramTermStartDate.GetSQLQuotedValueForAdd(),
paramTermEndDate.GetSQLQuotedValueForAdd()  ), true);


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
Object pClientID = null,
Object pTermID = null,
Object pRegisteredStudentCount = null,
Object pAssignedStudentCount = null,
Object pSCADWAREAccessCount = null,
Object pSCADWAREAccessThreshold = null,
Object pAverageTermBill = null,
Object pRatePerStudent = null,
Object pBilledPerStudent = null,
Object pTotalReceivedOnSCADWAREBill = null,
Object pMinimumExpectedOnSCADWAREBill = null,
Object pExpectedOnSCADWAREBill = null,
Object pIPAddress = null,
Object pCreatedAt = null,
Object pFullScholarshipStudentCount = null,
Object pTermStartDate = null,
Object pTermEndDate = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
 DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
 DataColumnParameter paramRegisteredStudentCount = new DataColumnParameter(defRegisteredStudentCount, pRegisteredStudentCount);
 DataColumnParameter paramAssignedStudentCount = new DataColumnParameter(defAssignedStudentCount, pAssignedStudentCount);
 DataColumnParameter paramSCADWAREAccessCount = new DataColumnParameter(defSCADWAREAccessCount, pSCADWAREAccessCount);
 DataColumnParameter paramSCADWAREAccessThreshold = new DataColumnParameter(defSCADWAREAccessThreshold, pSCADWAREAccessThreshold);
 DataColumnParameter paramAverageTermBill = new DataColumnParameter(defAverageTermBill, pAverageTermBill);
 DataColumnParameter paramRatePerStudent = new DataColumnParameter(defRatePerStudent, pRatePerStudent);
 DataColumnParameter paramBilledPerStudent = new DataColumnParameter(defBilledPerStudent, pBilledPerStudent);
 DataColumnParameter paramTotalReceivedOnSCADWAREBill = new DataColumnParameter(defTotalReceivedOnSCADWAREBill, pTotalReceivedOnSCADWAREBill);
 DataColumnParameter paramMinimumExpectedOnSCADWAREBill = new DataColumnParameter(defMinimumExpectedOnSCADWAREBill, pMinimumExpectedOnSCADWAREBill);
 DataColumnParameter paramExpectedOnSCADWAREBill = new DataColumnParameter(defExpectedOnSCADWAREBill, pExpectedOnSCADWAREBill);
 DataColumnParameter paramIPAddress = new DataColumnParameter(defIPAddress, pIPAddress);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramFullScholarshipStudentCount = new DataColumnParameter(defFullScholarshipStudentCount, pFullScholarshipStudentCount);
 DataColumnParameter paramTermStartDate = new DataColumnParameter(defTermStartDate, pTermStartDate);
 DataColumnParameter paramTermEndDate = new DataColumnParameter(defTermEndDate, pTermEndDate);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [ClientID]={2},[TermID]={3},[RegisteredStudentCount]={4},[AssignedStudentCount]={5},[SCADWAREAccessCount]={6},[SCADWAREAccessThreshold]={7},[AverageTermBill]={8},[RatePerStudent]={9},[BilledPerStudent]={10},[TotalReceivedOnSCADWAREBill]={11},[MinimumExpectedOnSCADWAREBill]={12},[ExpectedOnSCADWAREBill]={13},[IPAddress]={14},[CreatedAt]={15},[FullScholarshipStudentCount]={16},[TermStartDate]={17},[TermEndDate]={18} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramClientID.GetSQLQuotedValueForUpdate(),
paramTermID.GetSQLQuotedValueForUpdate(),
paramRegisteredStudentCount.GetSQLQuotedValueForUpdate(),
paramAssignedStudentCount.GetSQLQuotedValueForUpdate(),
paramSCADWAREAccessCount.GetSQLQuotedValueForUpdate(),
paramSCADWAREAccessThreshold.GetSQLQuotedValueForUpdate(),
paramAverageTermBill.GetSQLQuotedValueForUpdate(),
paramRatePerStudent.GetSQLQuotedValueForUpdate(),
paramBilledPerStudent.GetSQLQuotedValueForUpdate(),
paramTotalReceivedOnSCADWAREBill.GetSQLQuotedValueForUpdate(),
paramMinimumExpectedOnSCADWAREBill.GetSQLQuotedValueForUpdate(),
paramExpectedOnSCADWAREBill.GetSQLQuotedValueForUpdate(),
paramIPAddress.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramFullScholarshipStudentCount.GetSQLQuotedValueForUpdate(),
paramTermStartDate.GetSQLQuotedValueForUpdate(),
paramTermEndDate.GetSQLQuotedValueForUpdate()  ), true);


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
