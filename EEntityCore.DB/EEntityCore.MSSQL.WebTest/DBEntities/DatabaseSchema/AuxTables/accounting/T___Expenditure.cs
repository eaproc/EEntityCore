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

    public class T___Expenditure : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Expenditure()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTermID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defIpAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IpAddress.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCashRequestID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CashRequestID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defTotal = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Total.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDataMonitorID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DataMonitorID.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCharges = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Charges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defSpentAmount = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SpentAmount.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChargesComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ChargesComments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defCashRequestID.ColumnName, defCashRequestID); 
          ColumnDefns.Add(defTotal.ColumnName, defTotal); 
          ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID); 
          ColumnDefns.Add(defCharges.ColumnName, defCharges); 
          ColumnDefns.Add(defSpentAmount.ColumnName, defSpentAmount); 
          ColumnDefns.Add(defChargesComments.ColumnName, defChargesComments); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Expenditure_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Expenditure", "academic.Term"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Expenditure_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Expenditure", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Expenditure_CashRequestID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Expenditure", "accounting.CashRequest"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Expenditure_DataMonitorID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Expenditure", "import.DataMonitor"                  
                            ));                  

          }


                  
       public T___Expenditure() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Expenditure(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Expenditure(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Expenditure(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.Expenditure";
       public const string Expenditure__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TermID], [IpAddress], [CreatedAt], [CreatedByID], [CashRequestID], [Total], [DataMonitorID], [Charges], [SpentAmount], [ChargesComments] FROM Expenditure";
       public const string Expenditure__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TermID], [IpAddress], [CreatedAt], [CreatedByID], [CashRequestID], [Total], [DataMonitorID], [Charges], [SpentAmount], [ChargesComments] FROM Expenditure";


       public enum TableColumnNames
       {

           ID,
           TermID,
           IpAddress,
           CreatedAt,
           CreatedByID,
           CashRequestID,
           Total,
           DataMonitorID,
           Charges,
           SpentAmount,
           ChargesComments
       } 



       public enum TableConstraints{

           pk_accounting_Expenditure, 
           fk_accounting_Expenditure_TermID, 
           fk_accounting_Expenditure_CreatedByID, 
           fk_accounting_Expenditure_CashRequestID, 
           fk_accounting_Expenditure_DataMonitorID, 
           uq_accounting_Expenditure_CashRequestID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defIpAddress;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defCashRequestID;
       public static readonly DataColumnDefinition defTotal;
       public static readonly DataColumnDefinition defDataMonitorID;
       public static readonly DataColumnDefinition defCharges;
       public static readonly DataColumnDefinition defSpentAmount;
       public static readonly DataColumnDefinition defChargesComments;

       public int TermID { get => (int)TargettedRow[TableColumnNames.TermID.ToString()]; }


       public string IpAddress { get => (string)TargettedRow[TableColumnNames.IpAddress.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public int CashRequestID { get => (int)TargettedRow[TableColumnNames.CashRequestID.ToString()]; }


       public decimal Total { get => (decimal)TargettedRow[TableColumnNames.Total.ToString()]; }


       public int? DataMonitorID { get => (int?)TargettedRow[TableColumnNames.DataMonitorID.ToString()]; }


       public decimal Charges { get => (decimal)TargettedRow[TableColumnNames.Charges.ToString()]; }


       public decimal SpentAmount { get => (decimal)TargettedRow[TableColumnNames.SpentAmount.ToString()]; }


       public string ChargesComments { get => (string)TargettedRow[TableColumnNames.ChargesComments.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Expenditure GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Expenditure GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Expenditure GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Expenditure(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Expenditure GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Expenditure__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pTermID,
Int32 pCreatedByID,
Int32 pCashRequestID,
Int32 pDataMonitorID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramCashRequestID = new DataColumnParameter(defCashRequestID, pCashRequestID);
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, defIpAddress.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramTotal = new DataColumnParameter(defTotal, defTotal.DefaultValue);
                DataColumnParameter paramCharges = new DataColumnParameter(defCharges, defCharges.DefaultValue);
                DataColumnParameter paramSpentAmount = new DataColumnParameter(defSpentAmount, defSpentAmount.DefaultValue);
                DataColumnParameter paramChargesComments = new DataColumnParameter(defChargesComments, defChargesComments.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[IpAddress],[CreatedAt],[CreatedByID],[CashRequestID],[Total],[DataMonitorID],[Charges],[SpentAmount],[ChargesComments]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramTermID.GetSQLQuotedValueForAdd(),
                paramIpAddress.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedByID.GetSQLQuotedValueForAdd(),
                paramCashRequestID.GetSQLQuotedValueForAdd(),
                paramTotal.GetSQLQuotedValueForAdd(),
                paramDataMonitorID.GetSQLQuotedValueForAdd(),
                paramCharges.GetSQLQuotedValueForAdd(),
                paramSpentAmount.GetSQLQuotedValueForAdd(),
                paramChargesComments.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pTermID,
String pIpAddress,
DateTime pCreatedAt,
Int32 pCreatedByID,
Int32 pCashRequestID,
Decimal pTotal,
Decimal pCharges,
Decimal pSpentAmount,
Object pDataMonitorID = null,
Object pChargesComments = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
                DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramCashRequestID = new DataColumnParameter(defCashRequestID, pCashRequestID);
                DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
                DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
                DataColumnParameter paramCharges = new DataColumnParameter(defCharges, pCharges);
                DataColumnParameter paramSpentAmount = new DataColumnParameter(defSpentAmount, pSpentAmount);
                DataColumnParameter paramChargesComments = new DataColumnParameter(defChargesComments, pChargesComments);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[IpAddress],[CreatedAt],[CreatedByID],[CashRequestID],[Total],[DataMonitorID],[Charges],[SpentAmount],[ChargesComments]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramCashRequestID.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramDataMonitorID.GetSQLQuotedValueForAdd(),
paramCharges.GetSQLQuotedValueForAdd(),
paramSpentAmount.GetSQLQuotedValueForAdd(),
paramChargesComments.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pTermID,
String pIpAddress,
DateTime pCreatedAt,
Int32 pCreatedByID,
Int32 pCashRequestID,
Decimal pTotal,
Decimal pCharges,
Decimal pSpentAmount,
Object pDataMonitorID = null,
Object pChargesComments = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramCashRequestID = new DataColumnParameter(defCashRequestID, pCashRequestID);
DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
DataColumnParameter paramCharges = new DataColumnParameter(defCharges, pCharges);
DataColumnParameter paramSpentAmount = new DataColumnParameter(defSpentAmount, pSpentAmount);
DataColumnParameter paramChargesComments = new DataColumnParameter(defChargesComments, pChargesComments);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[IpAddress],[CreatedAt],[CreatedByID],[CashRequestID],[Total],[DataMonitorID],[Charges],[SpentAmount],[ChargesComments]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramCashRequestID.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramDataMonitorID.GetSQLQuotedValueForAdd(),
paramCharges.GetSQLQuotedValueForAdd(),
paramSpentAmount.GetSQLQuotedValueForAdd(),
paramChargesComments.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pTermID,
String pIpAddress,
DateTime pCreatedAt,
Int32 pCreatedByID,
Int32 pCashRequestID,
Decimal pTotal,
Decimal pCharges,
Decimal pSpentAmount,
Object pDataMonitorID= null,
Object pChargesComments= null){

        try{

DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramCashRequestID = new DataColumnParameter(defCashRequestID, pCashRequestID);
DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
DataColumnParameter paramCharges = new DataColumnParameter(defCharges, pCharges);
DataColumnParameter paramSpentAmount = new DataColumnParameter(defSpentAmount, pSpentAmount);
DataColumnParameter paramChargesComments = new DataColumnParameter(defChargesComments, pChargesComments);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([TermID],[IpAddress],[CreatedAt],[CreatedByID],[CashRequestID],[Total],[DataMonitorID],[Charges],[SpentAmount],[ChargesComments]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramTermID.GetSQLQuotedValueForAdd(),
paramIpAddress.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramCashRequestID.GetSQLQuotedValueForAdd(),
paramTotal.GetSQLQuotedValueForAdd(),
paramDataMonitorID.GetSQLQuotedValueForAdd(),
paramCharges.GetSQLQuotedValueForAdd(),
paramSpentAmount.GetSQLQuotedValueForAdd(),
paramChargesComments.GetSQLQuotedValueForAdd()  ), true);


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
Object pTermID = null,
Object pIpAddress = null,
Object pCreatedAt = null,
Object pCreatedByID = null,
Object pCashRequestID = null,
Object pTotal = null,
Object pCharges = null,
Object pSpentAmount = null,
Object pDataMonitorID = null,
Object pChargesComments = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
 DataColumnParameter paramIpAddress = new DataColumnParameter(defIpAddress, pIpAddress);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramCashRequestID = new DataColumnParameter(defCashRequestID, pCashRequestID);
 DataColumnParameter paramTotal = new DataColumnParameter(defTotal, pTotal);
 DataColumnParameter paramDataMonitorID = new DataColumnParameter(defDataMonitorID, pDataMonitorID);
 DataColumnParameter paramCharges = new DataColumnParameter(defCharges, pCharges);
 DataColumnParameter paramSpentAmount = new DataColumnParameter(defSpentAmount, pSpentAmount);
 DataColumnParameter paramChargesComments = new DataColumnParameter(defChargesComments, pChargesComments);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [TermID]={2},[IpAddress]={3},[CreatedAt]={4},[CreatedByID]={5},[CashRequestID]={6},[Total]={7},[DataMonitorID]={8},[Charges]={9},[SpentAmount]={10},[ChargesComments]={11} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramTermID.GetSQLQuotedValueForUpdate(),
paramIpAddress.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedByID.GetSQLQuotedValueForUpdate(),
paramCashRequestID.GetSQLQuotedValueForUpdate(),
paramTotal.GetSQLQuotedValueForUpdate(),
paramDataMonitorID.GetSQLQuotedValueForUpdate(),
paramCharges.GetSQLQuotedValueForUpdate(),
paramSpentAmount.GetSQLQuotedValueForUpdate(),
paramChargesComments.GetSQLQuotedValueForUpdate()  ), true);


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
