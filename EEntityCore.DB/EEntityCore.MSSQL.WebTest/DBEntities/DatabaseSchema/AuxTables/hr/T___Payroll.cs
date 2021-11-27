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

    public class T___Payroll : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Payroll()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defStartDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.StartDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.EndDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPayrollWorkingDays = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PayrollWorkingDays.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsApproved = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsApproved.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defMonthWorkingDays = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.MonthWorkingDays.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defStartDate.ColumnName, defStartDate); 
          ColumnDefns.Add(defEndDate.ColumnName, defEndDate); 
          ColumnDefns.Add(defPayrollWorkingDays.ColumnName, defPayrollWorkingDays); 
          ColumnDefns.Add(defIsApproved.ColumnName, defIsApproved); 
          ColumnDefns.Add(defMonthWorkingDays.ColumnName, defMonthWorkingDays); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Payroll_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Payroll", "auth.Users"                  
                            ));                  

          }


                  
       public T___Payroll() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Payroll(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Payroll(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Payroll(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.Payroll";
       public const string Payroll__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [StartDate], [EndDate], [PayrollWorkingDays], [IsApproved], [MonthWorkingDays], [CreatedAt], [CreatedByID] FROM Payroll";
       public const string Payroll__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [StartDate], [EndDate], [PayrollWorkingDays], [IsApproved], [MonthWorkingDays], [CreatedAt], [CreatedByID] FROM Payroll";


       public enum TableColumnNames
       {

           ID,
           StartDate,
           EndDate,
           PayrollWorkingDays,
           IsApproved,
           MonthWorkingDays,
           CreatedAt,
           CreatedByID
       } 



       public enum TableConstraints{

           pk_hr_Payroll, 
           fk_hr_Payroll_CreatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defStartDate;
       public static readonly DataColumnDefinition defEndDate;
       public static readonly DataColumnDefinition defPayrollWorkingDays;
       public static readonly DataColumnDefinition defIsApproved;
       public static readonly DataColumnDefinition defMonthWorkingDays;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;

       public NullableDateTime StartDate { get => new (this.TargettedRow[TableColumnNames.StartDate.ToString()]); }


       public NullableDateTime EndDate { get => new (this.TargettedRow[TableColumnNames.EndDate.ToString()]); }


       public int PayrollWorkingDays { get => (int)TargettedRow[TableColumnNames.PayrollWorkingDays.ToString()]; }


       public bool IsApproved { get => (bool)TargettedRow[TableColumnNames.IsApproved.ToString()]; }


       public int MonthWorkingDays { get => (int)TargettedRow[TableColumnNames.MonthWorkingDays.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Payroll GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Payroll GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Payroll GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Payroll(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Payroll GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Payroll__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCreatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramStartDate = new DataColumnParameter(defStartDate, defStartDate.DefaultValue);
                DataColumnParameter paramEndDate = new DataColumnParameter(defEndDate, defEndDate.DefaultValue);
                DataColumnParameter paramPayrollWorkingDays = new DataColumnParameter(defPayrollWorkingDays, defPayrollWorkingDays.DefaultValue);
                DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, defIsApproved.DefaultValue);
                DataColumnParameter paramMonthWorkingDays = new DataColumnParameter(defMonthWorkingDays, defMonthWorkingDays.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[StartDate],[EndDate],[PayrollWorkingDays],[IsApproved],[MonthWorkingDays],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramStartDate.GetSQLQuotedValueForAdd(),
                paramEndDate.GetSQLQuotedValueForAdd(),
                paramPayrollWorkingDays.GetSQLQuotedValueForAdd(),
                paramIsApproved.GetSQLQuotedValueForAdd(),
                paramMonthWorkingDays.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(DateTime pStartDate,
DateTime pEndDate,
Int32 pPayrollWorkingDays,
Boolean pIsApproved,
Int32 pMonthWorkingDays,
DateTime pCreatedAt,
Int32 pCreatedByID){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramStartDate = new DataColumnParameter(defStartDate, pStartDate);
                DataColumnParameter paramEndDate = new DataColumnParameter(defEndDate, pEndDate);
                DataColumnParameter paramPayrollWorkingDays = new DataColumnParameter(defPayrollWorkingDays, pPayrollWorkingDays);
                DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, pIsApproved);
                DataColumnParameter paramMonthWorkingDays = new DataColumnParameter(defMonthWorkingDays, pMonthWorkingDays);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[StartDate],[EndDate],[PayrollWorkingDays],[IsApproved],[MonthWorkingDays],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramStartDate.GetSQLQuotedValueForAdd(),
paramEndDate.GetSQLQuotedValueForAdd(),
paramPayrollWorkingDays.GetSQLQuotedValueForAdd(),
paramIsApproved.GetSQLQuotedValueForAdd(),
paramMonthWorkingDays.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,DateTime pStartDate,
DateTime pEndDate,
Int32 pPayrollWorkingDays,
Boolean pIsApproved,
Int32 pMonthWorkingDays,
DateTime pCreatedAt,
Int32 pCreatedByID){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramStartDate = new DataColumnParameter(defStartDate, pStartDate);
DataColumnParameter paramEndDate = new DataColumnParameter(defEndDate, pEndDate);
DataColumnParameter paramPayrollWorkingDays = new DataColumnParameter(defPayrollWorkingDays, pPayrollWorkingDays);
DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, pIsApproved);
DataColumnParameter paramMonthWorkingDays = new DataColumnParameter(defMonthWorkingDays, pMonthWorkingDays);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[StartDate],[EndDate],[PayrollWorkingDays],[IsApproved],[MonthWorkingDays],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramStartDate.GetSQLQuotedValueForAdd(),
paramEndDate.GetSQLQuotedValueForAdd(),
paramPayrollWorkingDays.GetSQLQuotedValueForAdd(),
paramIsApproved.GetSQLQuotedValueForAdd(),
paramMonthWorkingDays.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(DateTime pStartDate,
DateTime pEndDate,
Int32 pPayrollWorkingDays,
Boolean pIsApproved,
Int32 pMonthWorkingDays,
DateTime pCreatedAt,
Int32 pCreatedByID){

        try{

DataColumnParameter paramStartDate = new DataColumnParameter(defStartDate, pStartDate);
DataColumnParameter paramEndDate = new DataColumnParameter(defEndDate, pEndDate);
DataColumnParameter paramPayrollWorkingDays = new DataColumnParameter(defPayrollWorkingDays, pPayrollWorkingDays);
DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, pIsApproved);
DataColumnParameter paramMonthWorkingDays = new DataColumnParameter(defMonthWorkingDays, pMonthWorkingDays);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([StartDate],[EndDate],[PayrollWorkingDays],[IsApproved],[MonthWorkingDays],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7}) ", TABLE_NAME,paramStartDate.GetSQLQuotedValueForAdd(),
paramEndDate.GetSQLQuotedValueForAdd(),
paramPayrollWorkingDays.GetSQLQuotedValueForAdd(),
paramIsApproved.GetSQLQuotedValueForAdd(),
paramMonthWorkingDays.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd()  ), true);


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
Object pStartDate = null,
Object pEndDate = null,
Object pPayrollWorkingDays = null,
Object pIsApproved = null,
Object pMonthWorkingDays = null,
Object pCreatedAt = null,
Object pCreatedByID = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramStartDate = new DataColumnParameter(defStartDate, pStartDate);
 DataColumnParameter paramEndDate = new DataColumnParameter(defEndDate, pEndDate);
 DataColumnParameter paramPayrollWorkingDays = new DataColumnParameter(defPayrollWorkingDays, pPayrollWorkingDays);
 DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, pIsApproved);
 DataColumnParameter paramMonthWorkingDays = new DataColumnParameter(defMonthWorkingDays, pMonthWorkingDays);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [StartDate]={2},[EndDate]={3},[PayrollWorkingDays]={4},[IsApproved]={5},[MonthWorkingDays]={6},[CreatedAt]={7},[CreatedByID]={8} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramStartDate.GetSQLQuotedValueForUpdate(),
paramEndDate.GetSQLQuotedValueForUpdate(),
paramPayrollWorkingDays.GetSQLQuotedValueForUpdate(),
paramIsApproved.GetSQLQuotedValueForUpdate(),
paramMonthWorkingDays.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedByID.GetSQLQuotedValueForUpdate()  ), true);


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
