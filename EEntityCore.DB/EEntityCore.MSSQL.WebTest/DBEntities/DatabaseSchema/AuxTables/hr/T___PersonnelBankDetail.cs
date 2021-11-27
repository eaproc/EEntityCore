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

    public class T___PersonnelBankDetail : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PersonnelBankDetail()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defBankID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BankID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defPersonnelID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PersonnelID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defSwiftCode = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.SwiftCode.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIBAN = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IBAN.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsActive.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defPersonnelID.ColumnName, defPersonnelID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defSwiftCode.ColumnName, defSwiftCode); 
          ColumnDefns.Add(defIBAN.ColumnName, defIBAN); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PersonnelBankDetail_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PersonnelBankDetail", "common.Bank"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PersonnelBankDetail_PersonnelID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PersonnelBankDetail", "hr.Personnel"                  
                            ));                  

          }


                  
       public T___PersonnelBankDetail() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PersonnelBankDetail(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PersonnelBankDetail(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PersonnelBankDetail(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "hr.PersonnelBankDetail";
       public const string PersonnelBankDetail__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [BankID], [PersonnelID], [AccountNumber], [SwiftCode], [IBAN], [CreatedAt], [UpdatedAt], [IsActive] FROM PersonnelBankDetail";
       public const string PersonnelBankDetail__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [BankID], [PersonnelID], [AccountNumber], [SwiftCode], [IBAN], [CreatedAt], [UpdatedAt], [IsActive] FROM PersonnelBankDetail";


       public enum TableColumnNames
       {

           ID,
           BankID,
           PersonnelID,
           AccountNumber,
           SwiftCode,
           IBAN,
           CreatedAt,
           UpdatedAt,
           IsActive
       } 



       public enum TableConstraints{

           pk_hr_PersonnelBankDetail, 
           fk_hr_PersonnelBankDetail_BankID, 
           fk_hr_PersonnelBankDetail_PersonnelID, 
           uq_hr_PersonnelBankDetail_AccountNumber, 
           uq_hr_PersonnelBankDetail_ActiveBankAccount, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defPersonnelID;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defSwiftCode;
       public static readonly DataColumnDefinition defIBAN;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defIsActive;

       public Int32 BankID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BankID.ToString()]);
           }
       }


       public Int32 PersonnelID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonnelID.ToString()]);
           }
       }


       public String AccountNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountNumber.ToString()]);
           }
       }


       public String SwiftCode {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.SwiftCode.ToString()]);
           }
       }


       public String IBAN {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IBAN.ToString()]);
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


       public Boolean IsActive {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsActive.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___PersonnelBankDetail GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PersonnelBankDetail GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PersonnelBankDetail GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PersonnelBankDetail(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PersonnelBankDetail GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PersonnelBankDetail__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pBankID,
Int32 pPersonnelID,
String pAccountNumber){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramPersonnelID = new DataColumnParameter(defPersonnelID, pPersonnelID);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
                DataColumnParameter paramSwiftCode = new DataColumnParameter(defSwiftCode, defSwiftCode.DefaultValue);
                DataColumnParameter paramIBAN = new DataColumnParameter(defIBAN, defIBAN.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);
                DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, defIsActive.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BankID],[PersonnelID],[AccountNumber],[SwiftCode],[IBAN],[CreatedAt],[UpdatedAt],[IsActive]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramBankID.GetSQLQuotedValueForAdd(),
                paramPersonnelID.GetSQLQuotedValueForAdd(),
                paramAccountNumber.GetSQLQuotedValueForAdd(),
                paramSwiftCode.GetSQLQuotedValueForAdd(),
                paramIBAN.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd(),
                paramIsActive.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pBankID,
Int32 pPersonnelID,
String pAccountNumber,
DateTime pCreatedAt,
Boolean pIsActive,
Object pSwiftCode = null,
Object pIBAN = null,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramPersonnelID = new DataColumnParameter(defPersonnelID, pPersonnelID);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
                DataColumnParameter paramSwiftCode = new DataColumnParameter(defSwiftCode, pSwiftCode);
                DataColumnParameter paramIBAN = new DataColumnParameter(defIBAN, pIBAN);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BankID],[PersonnelID],[AccountNumber],[SwiftCode],[IBAN],[CreatedAt],[UpdatedAt],[IsActive]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramBankID.GetSQLQuotedValueForAdd(),
paramPersonnelID.GetSQLQuotedValueForAdd(),
paramAccountNumber.GetSQLQuotedValueForAdd(),
paramSwiftCode.GetSQLQuotedValueForAdd(),
paramIBAN.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pBankID,
Int32 pPersonnelID,
String pAccountNumber,
DateTime pCreatedAt,
Boolean pIsActive,
Object pSwiftCode = null,
Object pIBAN = null,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
DataColumnParameter paramPersonnelID = new DataColumnParameter(defPersonnelID, pPersonnelID);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
DataColumnParameter paramSwiftCode = new DataColumnParameter(defSwiftCode, pSwiftCode);
DataColumnParameter paramIBAN = new DataColumnParameter(defIBAN, pIBAN);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BankID],[PersonnelID],[AccountNumber],[SwiftCode],[IBAN],[CreatedAt],[UpdatedAt],[IsActive]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramBankID.GetSQLQuotedValueForAdd(),
paramPersonnelID.GetSQLQuotedValueForAdd(),
paramAccountNumber.GetSQLQuotedValueForAdd(),
paramSwiftCode.GetSQLQuotedValueForAdd(),
paramIBAN.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pBankID,
Int32 pPersonnelID,
String pAccountNumber,
DateTime pCreatedAt,
Boolean pIsActive,
Object pSwiftCode= null,
Object pIBAN= null,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
DataColumnParameter paramPersonnelID = new DataColumnParameter(defPersonnelID, pPersonnelID);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
DataColumnParameter paramSwiftCode = new DataColumnParameter(defSwiftCode, pSwiftCode);
DataColumnParameter paramIBAN = new DataColumnParameter(defIBAN, pIBAN);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([BankID],[PersonnelID],[AccountNumber],[SwiftCode],[IBAN],[CreatedAt],[UpdatedAt],[IsActive]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) ", TABLE_NAME,paramBankID.GetSQLQuotedValueForAdd(),
paramPersonnelID.GetSQLQuotedValueForAdd(),
paramAccountNumber.GetSQLQuotedValueForAdd(),
paramSwiftCode.GetSQLQuotedValueForAdd(),
paramIBAN.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd()  ), true);


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
Object pBankID = null,
Object pPersonnelID = null,
Object pAccountNumber = null,
Object pCreatedAt = null,
Object pIsActive = null,
Object pSwiftCode = null,
Object pIBAN = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
 DataColumnParameter paramPersonnelID = new DataColumnParameter(defPersonnelID, pPersonnelID);
 DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
 DataColumnParameter paramSwiftCode = new DataColumnParameter(defSwiftCode, pSwiftCode);
 DataColumnParameter paramIBAN = new DataColumnParameter(defIBAN, pIBAN);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [BankID]={2},[PersonnelID]={3},[AccountNumber]={4},[SwiftCode]={5},[IBAN]={6},[CreatedAt]={7},[UpdatedAt]={8},[IsActive]={9} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramBankID.GetSQLQuotedValueForUpdate(),
paramPersonnelID.GetSQLQuotedValueForUpdate(),
paramAccountNumber.GetSQLQuotedValueForUpdate(),
paramSwiftCode.GetSQLQuotedValueForUpdate(),
paramIBAN.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramIsActive.GetSQLQuotedValueForUpdate()  ), true);


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
