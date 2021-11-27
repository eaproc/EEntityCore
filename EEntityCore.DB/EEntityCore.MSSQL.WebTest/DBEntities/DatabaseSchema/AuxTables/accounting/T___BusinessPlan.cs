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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.accounting                  
{                  

    public class T___BusinessPlan : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___BusinessPlan()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defAcademicSessionID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AcademicSessionID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defStudentPopulation = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.StudentPopulation.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAveragePricePerStudent = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AveragePricePerStudent.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSCADWAREAccessRevenue = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SCADWAREAccessRevenue.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSideContractRevenue = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SideContractRevenue.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defGrossRevenue = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.GrossRevenue.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defWages = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Wages.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMarketing = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Marketing.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCharity = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Charity.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defOthers = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Others.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID); 
          ColumnDefns.Add(defStudentPopulation.ColumnName, defStudentPopulation); 
          ColumnDefns.Add(defAveragePricePerStudent.ColumnName, defAveragePricePerStudent); 
          ColumnDefns.Add(defSCADWAREAccessRevenue.ColumnName, defSCADWAREAccessRevenue); 
          ColumnDefns.Add(defSideContractRevenue.ColumnName, defSideContractRevenue); 
          ColumnDefns.Add(defGrossRevenue.ColumnName, defGrossRevenue); 
          ColumnDefns.Add(defWages.ColumnName, defWages); 
          ColumnDefns.Add(defMarketing.ColumnName, defMarketing); 
          ColumnDefns.Add(defCharity.ColumnName, defCharity); 
          ColumnDefns.Add(defOthers.ColumnName, defOthers); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_BusinessPlan_AcademicSessionID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.BusinessPlan", "academic.AcademicSession"                  
                            ));                  

          }


                  
       public T___BusinessPlan() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___BusinessPlan(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___BusinessPlan(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___BusinessPlan(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.BusinessPlan";
       public const string BusinessPlan__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [AcademicSessionID], [StudentPopulation], [AveragePricePerStudent], [SCADWAREAccessRevenue], [SideContractRevenue], [GrossRevenue], [Wages], [Marketing], [Charity], [Others], [CreatedAt], [UpdatedAt] FROM BusinessPlan";
       public const string BusinessPlan__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [AcademicSessionID], [StudentPopulation], [AveragePricePerStudent], [SCADWAREAccessRevenue], [SideContractRevenue], [GrossRevenue], [Wages], [Marketing], [Charity], [Others], [CreatedAt], [UpdatedAt] FROM BusinessPlan";


       public enum TableColumnNames
       {

           ID,
           AcademicSessionID,
           StudentPopulation,
           AveragePricePerStudent,
           SCADWAREAccessRevenue,
           SideContractRevenue,
           GrossRevenue,
           Wages,
           Marketing,
           Charity,
           Others,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_accounting_BusinessPlan, 
           fk_accounting_BusinessPlan_AcademicSessionID, 
           uq_accounting_BusinessPlan_AcademicSessionID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defAcademicSessionID;
       public static readonly DataColumnDefinition defStudentPopulation;
       public static readonly DataColumnDefinition defAveragePricePerStudent;
       public static readonly DataColumnDefinition defSCADWAREAccessRevenue;
       public static readonly DataColumnDefinition defSideContractRevenue;
       public static readonly DataColumnDefinition defGrossRevenue;
       public static readonly DataColumnDefinition defWages;
       public static readonly DataColumnDefinition defMarketing;
       public static readonly DataColumnDefinition defCharity;
       public static readonly DataColumnDefinition defOthers;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public Int32 AcademicSessionID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.AcademicSessionID.ToString()]);
           }
       }


       public Int32 StudentPopulation {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.StudentPopulation.ToString()]);
           }
       }


       public Decimal AveragePricePerStudent {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.AveragePricePerStudent.ToString()]);
           }
       }


       public Decimal SCADWAREAccessRevenue {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.SCADWAREAccessRevenue.ToString()]);
           }
       }


       public Decimal SideContractRevenue {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.SideContractRevenue.ToString()]);
           }
       }


       public Decimal GrossRevenue {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.GrossRevenue.ToString()]);
           }
       }


       public Decimal Wages {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Wages.ToString()]);
           }
       }


       public Decimal Marketing {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Marketing.ToString()]);
           }
       }


       public Decimal Charity {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Charity.ToString()]);
           }
       }


       public Decimal Others {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Others.ToString()]);
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


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___BusinessPlan GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___BusinessPlan GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___BusinessPlan GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___BusinessPlan(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___BusinessPlan GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => BusinessPlan__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pAcademicSessionID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
                DataColumnParameter paramStudentPopulation = new DataColumnParameter(defStudentPopulation, defStudentPopulation.DefaultValue);
                DataColumnParameter paramAveragePricePerStudent = new DataColumnParameter(defAveragePricePerStudent, defAveragePricePerStudent.DefaultValue);
                DataColumnParameter paramSCADWAREAccessRevenue = new DataColumnParameter(defSCADWAREAccessRevenue, defSCADWAREAccessRevenue.DefaultValue);
                DataColumnParameter paramSideContractRevenue = new DataColumnParameter(defSideContractRevenue, defSideContractRevenue.DefaultValue);
                DataColumnParameter paramGrossRevenue = new DataColumnParameter(defGrossRevenue, defGrossRevenue.DefaultValue);
                DataColumnParameter paramWages = new DataColumnParameter(defWages, defWages.DefaultValue);
                DataColumnParameter paramMarketing = new DataColumnParameter(defMarketing, defMarketing.DefaultValue);
                DataColumnParameter paramCharity = new DataColumnParameter(defCharity, defCharity.DefaultValue);
                DataColumnParameter paramOthers = new DataColumnParameter(defOthers, defOthers.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramAcademicSessionID.GetSQLQuotedValueForAdd(),
                paramStudentPopulation.GetSQLQuotedValueForAdd(),
                paramAveragePricePerStudent.GetSQLQuotedValueForAdd(),
                paramSCADWAREAccessRevenue.GetSQLQuotedValueForAdd(),
                paramSideContractRevenue.GetSQLQuotedValueForAdd(),
                paramGrossRevenue.GetSQLQuotedValueForAdd(),
                paramWages.GetSQLQuotedValueForAdd(),
                paramMarketing.GetSQLQuotedValueForAdd(),
                paramCharity.GetSQLQuotedValueForAdd(),
                paramOthers.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pAcademicSessionID,
Int32 pStudentPopulation,
Decimal pAveragePricePerStudent,
Decimal pSCADWAREAccessRevenue,
Decimal pSideContractRevenue,
Decimal pGrossRevenue,
Decimal pWages,
Decimal pMarketing,
Decimal pCharity,
Decimal pOthers,
DateTime pCreatedAt,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
                DataColumnParameter paramStudentPopulation = new DataColumnParameter(defStudentPopulation, pStudentPopulation);
                DataColumnParameter paramAveragePricePerStudent = new DataColumnParameter(defAveragePricePerStudent, pAveragePricePerStudent);
                DataColumnParameter paramSCADWAREAccessRevenue = new DataColumnParameter(defSCADWAREAccessRevenue, pSCADWAREAccessRevenue);
                DataColumnParameter paramSideContractRevenue = new DataColumnParameter(defSideContractRevenue, pSideContractRevenue);
                DataColumnParameter paramGrossRevenue = new DataColumnParameter(defGrossRevenue, pGrossRevenue);
                DataColumnParameter paramWages = new DataColumnParameter(defWages, pWages);
                DataColumnParameter paramMarketing = new DataColumnParameter(defMarketing, pMarketing);
                DataColumnParameter paramCharity = new DataColumnParameter(defCharity, pCharity);
                DataColumnParameter paramOthers = new DataColumnParameter(defOthers, pOthers);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramAcademicSessionID.GetSQLQuotedValueForAdd(),
paramStudentPopulation.GetSQLQuotedValueForAdd(),
paramAveragePricePerStudent.GetSQLQuotedValueForAdd(),
paramSCADWAREAccessRevenue.GetSQLQuotedValueForAdd(),
paramSideContractRevenue.GetSQLQuotedValueForAdd(),
paramGrossRevenue.GetSQLQuotedValueForAdd(),
paramWages.GetSQLQuotedValueForAdd(),
paramMarketing.GetSQLQuotedValueForAdd(),
paramCharity.GetSQLQuotedValueForAdd(),
paramOthers.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pAcademicSessionID,
Int32 pStudentPopulation,
Decimal pAveragePricePerStudent,
Decimal pSCADWAREAccessRevenue,
Decimal pSideContractRevenue,
Decimal pGrossRevenue,
Decimal pWages,
Decimal pMarketing,
Decimal pCharity,
Decimal pOthers,
DateTime pCreatedAt,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
DataColumnParameter paramStudentPopulation = new DataColumnParameter(defStudentPopulation, pStudentPopulation);
DataColumnParameter paramAveragePricePerStudent = new DataColumnParameter(defAveragePricePerStudent, pAveragePricePerStudent);
DataColumnParameter paramSCADWAREAccessRevenue = new DataColumnParameter(defSCADWAREAccessRevenue, pSCADWAREAccessRevenue);
DataColumnParameter paramSideContractRevenue = new DataColumnParameter(defSideContractRevenue, pSideContractRevenue);
DataColumnParameter paramGrossRevenue = new DataColumnParameter(defGrossRevenue, pGrossRevenue);
DataColumnParameter paramWages = new DataColumnParameter(defWages, pWages);
DataColumnParameter paramMarketing = new DataColumnParameter(defMarketing, pMarketing);
DataColumnParameter paramCharity = new DataColumnParameter(defCharity, pCharity);
DataColumnParameter paramOthers = new DataColumnParameter(defOthers, pOthers);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramAcademicSessionID.GetSQLQuotedValueForAdd(),
paramStudentPopulation.GetSQLQuotedValueForAdd(),
paramAveragePricePerStudent.GetSQLQuotedValueForAdd(),
paramSCADWAREAccessRevenue.GetSQLQuotedValueForAdd(),
paramSideContractRevenue.GetSQLQuotedValueForAdd(),
paramGrossRevenue.GetSQLQuotedValueForAdd(),
paramWages.GetSQLQuotedValueForAdd(),
paramMarketing.GetSQLQuotedValueForAdd(),
paramCharity.GetSQLQuotedValueForAdd(),
paramOthers.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pAcademicSessionID,
Int32 pStudentPopulation,
Decimal pAveragePricePerStudent,
Decimal pSCADWAREAccessRevenue,
Decimal pSideContractRevenue,
Decimal pGrossRevenue,
Decimal pWages,
Decimal pMarketing,
Decimal pCharity,
Decimal pOthers,
DateTime pCreatedAt,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
DataColumnParameter paramStudentPopulation = new DataColumnParameter(defStudentPopulation, pStudentPopulation);
DataColumnParameter paramAveragePricePerStudent = new DataColumnParameter(defAveragePricePerStudent, pAveragePricePerStudent);
DataColumnParameter paramSCADWAREAccessRevenue = new DataColumnParameter(defSCADWAREAccessRevenue, pSCADWAREAccessRevenue);
DataColumnParameter paramSideContractRevenue = new DataColumnParameter(defSideContractRevenue, pSideContractRevenue);
DataColumnParameter paramGrossRevenue = new DataColumnParameter(defGrossRevenue, pGrossRevenue);
DataColumnParameter paramWages = new DataColumnParameter(defWages, pWages);
DataColumnParameter paramMarketing = new DataColumnParameter(defMarketing, pMarketing);
DataColumnParameter paramCharity = new DataColumnParameter(defCharity, pCharity);
DataColumnParameter paramOthers = new DataColumnParameter(defOthers, pOthers);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) ", TABLE_NAME,paramAcademicSessionID.GetSQLQuotedValueForAdd(),
paramStudentPopulation.GetSQLQuotedValueForAdd(),
paramAveragePricePerStudent.GetSQLQuotedValueForAdd(),
paramSCADWAREAccessRevenue.GetSQLQuotedValueForAdd(),
paramSideContractRevenue.GetSQLQuotedValueForAdd(),
paramGrossRevenue.GetSQLQuotedValueForAdd(),
paramWages.GetSQLQuotedValueForAdd(),
paramMarketing.GetSQLQuotedValueForAdd(),
paramCharity.GetSQLQuotedValueForAdd(),
paramOthers.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);


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
Object pAcademicSessionID = null,
Object pStudentPopulation = null,
Object pAveragePricePerStudent = null,
Object pSCADWAREAccessRevenue = null,
Object pSideContractRevenue = null,
Object pGrossRevenue = null,
Object pWages = null,
Object pMarketing = null,
Object pCharity = null,
Object pOthers = null,
Object pCreatedAt = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
 DataColumnParameter paramStudentPopulation = new DataColumnParameter(defStudentPopulation, pStudentPopulation);
 DataColumnParameter paramAveragePricePerStudent = new DataColumnParameter(defAveragePricePerStudent, pAveragePricePerStudent);
 DataColumnParameter paramSCADWAREAccessRevenue = new DataColumnParameter(defSCADWAREAccessRevenue, pSCADWAREAccessRevenue);
 DataColumnParameter paramSideContractRevenue = new DataColumnParameter(defSideContractRevenue, pSideContractRevenue);
 DataColumnParameter paramGrossRevenue = new DataColumnParameter(defGrossRevenue, pGrossRevenue);
 DataColumnParameter paramWages = new DataColumnParameter(defWages, pWages);
 DataColumnParameter paramMarketing = new DataColumnParameter(defMarketing, pMarketing);
 DataColumnParameter paramCharity = new DataColumnParameter(defCharity, pCharity);
 DataColumnParameter paramOthers = new DataColumnParameter(defOthers, pOthers);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [AcademicSessionID]={2},[StudentPopulation]={3},[AveragePricePerStudent]={4},[SCADWAREAccessRevenue]={5},[SideContractRevenue]={6},[GrossRevenue]={7},[Wages]={8},[Marketing]={9},[Charity]={10},[Others]={11},[CreatedAt]={12},[UpdatedAt]={13} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramAcademicSessionID.GetSQLQuotedValueForUpdate(),
paramStudentPopulation.GetSQLQuotedValueForUpdate(),
paramAveragePricePerStudent.GetSQLQuotedValueForUpdate(),
paramSCADWAREAccessRevenue.GetSQLQuotedValueForUpdate(),
paramSideContractRevenue.GetSQLQuotedValueForUpdate(),
paramGrossRevenue.GetSQLQuotedValueForUpdate(),
paramWages.GetSQLQuotedValueForUpdate(),
paramMarketing.GetSQLQuotedValueForUpdate(),
paramCharity.GetSQLQuotedValueForUpdate(),
paramOthers.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate()  ), true);


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
