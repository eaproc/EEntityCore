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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.academic                  
{                  

    public class T___TestTable : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___TestTable()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defTestString = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TestString.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestStringNull = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TestStringNull.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestInt32 = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TestInt32.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestInt32Null = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TestInt32Null.ToString(), typeof(Int32),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestBool = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TestBool.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestBoolNull = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TestBoolNull.ToString(), typeof(Boolean),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestDecimal = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TestDecimal.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestDecimalNull = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TestDecimalNull.ToString(), typeof(Decimal),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestDateTime = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TestDateTime.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTestDateTimeNull = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TestDateTimeNull.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defTestString.ColumnName, defTestString); 
          ColumnDefns.Add(defTestStringNull.ColumnName, defTestStringNull); 
          ColumnDefns.Add(defTestInt32.ColumnName, defTestInt32); 
          ColumnDefns.Add(defTestInt32Null.ColumnName, defTestInt32Null); 
          ColumnDefns.Add(defTestBool.ColumnName, defTestBool); 
          ColumnDefns.Add(defTestBoolNull.ColumnName, defTestBoolNull); 
          ColumnDefns.Add(defTestDecimal.ColumnName, defTestDecimal); 
          ColumnDefns.Add(defTestDecimalNull.ColumnName, defTestDecimalNull); 
          ColumnDefns.Add(defTestDateTime.ColumnName, defTestDateTime); 
          ColumnDefns.Add(defTestDateTimeNull.ColumnName, defTestDateTimeNull); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  


          }


                  
       public T___TestTable() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___TestTable(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___TestTable(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___TestTable(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "academic.TestTable";
       public const string TestTable__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [TestString], [TestStringNull], [TestInt32], [TestInt32Null], [TestBool], [TestBoolNull], [TestDecimal], [TestDecimalNull], [TestDateTime], [TestDateTimeNull] FROM TestTable";
       public const string TestTable__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [TestString], [TestStringNull], [TestInt32], [TestInt32Null], [TestBool], [TestBoolNull], [TestDecimal], [TestDecimalNull], [TestDateTime], [TestDateTimeNull] FROM TestTable";


       public enum TableColumnNames
       {

           ID,
           TestString,
           TestStringNull,
           TestInt32,
           TestInt32Null,
           TestBool,
           TestBoolNull,
           TestDecimal,
           TestDecimalNull,
           TestDateTime,
           TestDateTimeNull
       } 



       public enum TableConstraints{

           pk_academic_TestTable, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defTestString;
       public static readonly DataColumnDefinition defTestStringNull;
       public static readonly DataColumnDefinition defTestInt32;
       public static readonly DataColumnDefinition defTestInt32Null;
       public static readonly DataColumnDefinition defTestBool;
       public static readonly DataColumnDefinition defTestBoolNull;
       public static readonly DataColumnDefinition defTestDecimal;
       public static readonly DataColumnDefinition defTestDecimalNull;
       public static readonly DataColumnDefinition defTestDateTime;
       public static readonly DataColumnDefinition defTestDateTimeNull;

       public string TestString { get => (string)TargettedRow[TableColumnNames.TestString.ToString()]; }


       public string TestStringNull { get => (string)TargettedRow[TableColumnNames.TestStringNull.ToString()]; }


       public int TestInt32 { get => (int)TargettedRow[TableColumnNames.TestInt32.ToString()]; }


       public int? TestInt32Null { get => (int?)TargettedRow[TableColumnNames.TestInt32Null.ToString()]; }


       public bool TestBool { get => (bool)TargettedRow[TableColumnNames.TestBool.ToString()]; }


       public bool? TestBoolNull { get => (bool?)TargettedRow[TableColumnNames.TestBoolNull.ToString()]; }


       public decimal TestDecimal { get => (decimal)TargettedRow[TableColumnNames.TestDecimal.ToString()]; }


       public decimal? TestDecimalNull { get => (decimal?)TargettedRow[TableColumnNames.TestDecimalNull.ToString()]; }


       public NullableDateTime TestDateTime { get => new (this.TargettedRow[TableColumnNames.TestDateTime.ToString()]); }


       public NullableDateTime TestDateTimeNull { get => new (this.TargettedRow[TableColumnNames.TestDateTimeNull.ToString()]); }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___TestTable GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___TestTable GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___TestTable GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___TestTable(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___TestTable GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => TestTable__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTestString = new DataColumnParameter(defTestString, defTestString.DefaultValue);
                DataColumnParameter paramTestStringNull = new DataColumnParameter(defTestStringNull, defTestStringNull.DefaultValue);
                DataColumnParameter paramTestInt32 = new DataColumnParameter(defTestInt32, defTestInt32.DefaultValue);
                DataColumnParameter paramTestInt32Null = new DataColumnParameter(defTestInt32Null, defTestInt32Null.DefaultValue);
                DataColumnParameter paramTestBool = new DataColumnParameter(defTestBool, defTestBool.DefaultValue);
                DataColumnParameter paramTestBoolNull = new DataColumnParameter(defTestBoolNull, defTestBoolNull.DefaultValue);
                DataColumnParameter paramTestDecimal = new DataColumnParameter(defTestDecimal, defTestDecimal.DefaultValue);
                DataColumnParameter paramTestDecimalNull = new DataColumnParameter(defTestDecimalNull, defTestDecimalNull.DefaultValue);
                DataColumnParameter paramTestDateTime = new DataColumnParameter(defTestDateTime, defTestDateTime.DefaultValue);
                DataColumnParameter paramTestDateTimeNull = new DataColumnParameter(defTestDateTimeNull, defTestDateTimeNull.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TestString],[TestStringNull],[TestInt32],[TestInt32Null],[TestBool],[TestBoolNull],[TestDecimal],[TestDecimalNull],[TestDateTime],[TestDateTimeNull]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramTestString.GetSQLQuotedValueForAdd(),
                paramTestStringNull.GetSQLQuotedValueForAdd(),
                paramTestInt32.GetSQLQuotedValueForAdd(),
                paramTestInt32Null.GetSQLQuotedValueForAdd(),
                paramTestBool.GetSQLQuotedValueForAdd(),
                paramTestBoolNull.GetSQLQuotedValueForAdd(),
                paramTestDecimal.GetSQLQuotedValueForAdd(),
                paramTestDecimalNull.GetSQLQuotedValueForAdd(),
                paramTestDateTime.GetSQLQuotedValueForAdd(),
                paramTestDateTimeNull.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pTestString,
Int32 pTestInt32,
Boolean pTestBool,
Decimal pTestDecimal,
DateTime pTestDateTime,
DateTime pTestDateTimeNull,
Object pTestStringNull = null,
Object pTestInt32Null = null,
Object pTestBoolNull = null,
Object pTestDecimalNull = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramTestString = new DataColumnParameter(defTestString, pTestString);
                DataColumnParameter paramTestStringNull = new DataColumnParameter(defTestStringNull, pTestStringNull);
                DataColumnParameter paramTestInt32 = new DataColumnParameter(defTestInt32, pTestInt32);
                DataColumnParameter paramTestInt32Null = new DataColumnParameter(defTestInt32Null, pTestInt32Null);
                DataColumnParameter paramTestBool = new DataColumnParameter(defTestBool, pTestBool);
                DataColumnParameter paramTestBoolNull = new DataColumnParameter(defTestBoolNull, pTestBoolNull);
                DataColumnParameter paramTestDecimal = new DataColumnParameter(defTestDecimal, pTestDecimal);
                DataColumnParameter paramTestDecimalNull = new DataColumnParameter(defTestDecimalNull, pTestDecimalNull);
                DataColumnParameter paramTestDateTime = new DataColumnParameter(defTestDateTime, pTestDateTime);
                DataColumnParameter paramTestDateTimeNull = new DataColumnParameter(defTestDateTimeNull, pTestDateTimeNull);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TestString],[TestStringNull],[TestInt32],[TestInt32Null],[TestBool],[TestBoolNull],[TestDecimal],[TestDecimalNull],[TestDateTime],[TestDateTimeNull]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramTestString.GetSQLQuotedValueForAdd(),
paramTestStringNull.GetSQLQuotedValueForAdd(),
paramTestInt32.GetSQLQuotedValueForAdd(),
paramTestInt32Null.GetSQLQuotedValueForAdd(),
paramTestBool.GetSQLQuotedValueForAdd(),
paramTestBoolNull.GetSQLQuotedValueForAdd(),
paramTestDecimal.GetSQLQuotedValueForAdd(),
paramTestDecimalNull.GetSQLQuotedValueForAdd(),
paramTestDateTime.GetSQLQuotedValueForAdd(),
paramTestDateTimeNull.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pTestString,
Int32 pTestInt32,
Boolean pTestBool,
Decimal pTestDecimal,
DateTime pTestDateTime,
DateTime pTestDateTimeNull,
Object pTestStringNull = null,
Object pTestInt32Null = null,
Object pTestBoolNull = null,
Object pTestDecimalNull = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramTestString = new DataColumnParameter(defTestString, pTestString);
DataColumnParameter paramTestStringNull = new DataColumnParameter(defTestStringNull, pTestStringNull);
DataColumnParameter paramTestInt32 = new DataColumnParameter(defTestInt32, pTestInt32);
DataColumnParameter paramTestInt32Null = new DataColumnParameter(defTestInt32Null, pTestInt32Null);
DataColumnParameter paramTestBool = new DataColumnParameter(defTestBool, pTestBool);
DataColumnParameter paramTestBoolNull = new DataColumnParameter(defTestBoolNull, pTestBoolNull);
DataColumnParameter paramTestDecimal = new DataColumnParameter(defTestDecimal, pTestDecimal);
DataColumnParameter paramTestDecimalNull = new DataColumnParameter(defTestDecimalNull, pTestDecimalNull);
DataColumnParameter paramTestDateTime = new DataColumnParameter(defTestDateTime, pTestDateTime);
DataColumnParameter paramTestDateTimeNull = new DataColumnParameter(defTestDateTimeNull, pTestDateTimeNull);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TestString],[TestStringNull],[TestInt32],[TestInt32Null],[TestBool],[TestBoolNull],[TestDecimal],[TestDecimalNull],[TestDateTime],[TestDateTimeNull]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramTestString.GetSQLQuotedValueForAdd(),
paramTestStringNull.GetSQLQuotedValueForAdd(),
paramTestInt32.GetSQLQuotedValueForAdd(),
paramTestInt32Null.GetSQLQuotedValueForAdd(),
paramTestBool.GetSQLQuotedValueForAdd(),
paramTestBoolNull.GetSQLQuotedValueForAdd(),
paramTestDecimal.GetSQLQuotedValueForAdd(),
paramTestDecimalNull.GetSQLQuotedValueForAdd(),
paramTestDateTime.GetSQLQuotedValueForAdd(),
paramTestDateTimeNull.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pTestString,
Int32 pTestInt32,
Boolean pTestBool,
Decimal pTestDecimal,
DateTime pTestDateTime,
DateTime pTestDateTimeNull,
Object pTestStringNull= null,
Object pTestInt32Null= null,
Object pTestBoolNull= null,
Object pTestDecimalNull= null){

        try{

DataColumnParameter paramTestString = new DataColumnParameter(defTestString, pTestString);
DataColumnParameter paramTestStringNull = new DataColumnParameter(defTestStringNull, pTestStringNull);
DataColumnParameter paramTestInt32 = new DataColumnParameter(defTestInt32, pTestInt32);
DataColumnParameter paramTestInt32Null = new DataColumnParameter(defTestInt32Null, pTestInt32Null);
DataColumnParameter paramTestBool = new DataColumnParameter(defTestBool, pTestBool);
DataColumnParameter paramTestBoolNull = new DataColumnParameter(defTestBoolNull, pTestBoolNull);
DataColumnParameter paramTestDecimal = new DataColumnParameter(defTestDecimal, pTestDecimal);
DataColumnParameter paramTestDecimalNull = new DataColumnParameter(defTestDecimalNull, pTestDecimalNull);
DataColumnParameter paramTestDateTime = new DataColumnParameter(defTestDateTime, pTestDateTime);
DataColumnParameter paramTestDateTimeNull = new DataColumnParameter(defTestDateTimeNull, pTestDateTimeNull);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([TestString],[TestStringNull],[TestInt32],[TestInt32Null],[TestBool],[TestBoolNull],[TestDecimal],[TestDecimalNull],[TestDateTime],[TestDateTimeNull]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramTestString.GetSQLQuotedValueForAdd(),
paramTestStringNull.GetSQLQuotedValueForAdd(),
paramTestInt32.GetSQLQuotedValueForAdd(),
paramTestInt32Null.GetSQLQuotedValueForAdd(),
paramTestBool.GetSQLQuotedValueForAdd(),
paramTestBoolNull.GetSQLQuotedValueForAdd(),
paramTestDecimal.GetSQLQuotedValueForAdd(),
paramTestDecimalNull.GetSQLQuotedValueForAdd(),
paramTestDateTime.GetSQLQuotedValueForAdd(),
paramTestDateTimeNull.GetSQLQuotedValueForAdd()  ), true);


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
Object pTestString = null,
Object pTestInt32 = null,
Object pTestBool = null,
Object pTestDecimal = null,
Object pTestDateTime = null,
Object pTestDateTimeNull = null,
Object pTestStringNull = null,
Object pTestInt32Null = null,
Object pTestBoolNull = null,
Object pTestDecimalNull = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramTestString = new DataColumnParameter(defTestString, pTestString);
 DataColumnParameter paramTestStringNull = new DataColumnParameter(defTestStringNull, pTestStringNull);
 DataColumnParameter paramTestInt32 = new DataColumnParameter(defTestInt32, pTestInt32);
 DataColumnParameter paramTestInt32Null = new DataColumnParameter(defTestInt32Null, pTestInt32Null);
 DataColumnParameter paramTestBool = new DataColumnParameter(defTestBool, pTestBool);
 DataColumnParameter paramTestBoolNull = new DataColumnParameter(defTestBoolNull, pTestBoolNull);
 DataColumnParameter paramTestDecimal = new DataColumnParameter(defTestDecimal, pTestDecimal);
 DataColumnParameter paramTestDecimalNull = new DataColumnParameter(defTestDecimalNull, pTestDecimalNull);
 DataColumnParameter paramTestDateTime = new DataColumnParameter(defTestDateTime, pTestDateTime);
 DataColumnParameter paramTestDateTimeNull = new DataColumnParameter(defTestDateTimeNull, pTestDateTimeNull);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [TestString]={2},[TestStringNull]={3},[TestInt32]={4},[TestInt32Null]={5},[TestBool]={6},[TestBoolNull]={7},[TestDecimal]={8},[TestDecimalNull]={9},[TestDateTime]={10},[TestDateTimeNull]={11} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramTestString.GetSQLQuotedValueForUpdate(),
paramTestStringNull.GetSQLQuotedValueForUpdate(),
paramTestInt32.GetSQLQuotedValueForUpdate(),
paramTestInt32Null.GetSQLQuotedValueForUpdate(),
paramTestBool.GetSQLQuotedValueForUpdate(),
paramTestBoolNull.GetSQLQuotedValueForUpdate(),
paramTestDecimal.GetSQLQuotedValueForUpdate(),
paramTestDecimalNull.GetSQLQuotedValueForUpdate(),
paramTestDateTime.GetSQLQuotedValueForUpdate(),
paramTestDateTimeNull.GetSQLQuotedValueForUpdate()  ), true);


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
