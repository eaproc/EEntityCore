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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.charity                  
{                  

    public class T___MonthlyDonation : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___MonthlyDonation()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defCenterID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CenterID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defResidingPastorID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ResidingPastorID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defBankID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BankID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defAccountNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AccountNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDonationYear = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DonationYear.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDonationMonth = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DonationMonth.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsApproved = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsApproved.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsDisbursed = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsDisbursed.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defCenterID.ColumnName, defCenterID); 
          ColumnDefns.Add(defResidingPastorID.ColumnName, defResidingPastorID); 
          ColumnDefns.Add(defBankID.ColumnName, defBankID); 
          ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber); 
          ColumnDefns.Add(defDonationYear.ColumnName, defDonationYear); 
          ColumnDefns.Add(defDonationMonth.ColumnName, defDonationMonth); 
          ColumnDefns.Add(defIsApproved.ColumnName, defIsApproved); 
          ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_CenterID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.MonthlyDonation", "charity.Center"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_ResidingPastorID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "charity.ResidingPastor"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_BankID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "common.Bank"                  
                            ));                  

          }


                  
       public T___MonthlyDonation() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___MonthlyDonation(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___MonthlyDonation(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___MonthlyDonation(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.MonthlyDonation";
       public const string MonthlyDonation__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [ResidingPastorID], [BankID], [AccountNumber], [DonationYear], [DonationMonth], [IsApproved], [IsDisbursed], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM MonthlyDonation";
       public const string MonthlyDonation__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [CenterID], [ResidingPastorID], [BankID], [AccountNumber], [DonationYear], [DonationMonth], [IsApproved], [IsDisbursed], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM MonthlyDonation";


       public enum TableColumnNames
       {

           ID,
           CenterID,
           ResidingPastorID,
           BankID,
           AccountNumber,
           DonationYear,
           DonationMonth,
           IsApproved,
           IsDisbursed,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_MonthlyDonation, 
           fk_charity_MonthlyDonation_UpdatedByID, 
           fk_charity_MonthlyDonation_CenterID, 
           fk_charity_MonthlyDonation_ResidingPastorID, 
           fk_charity_MonthlyDonation_CreatedByID, 
           fk_charity_MonthlyDonation_BankID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defCenterID;
       public static readonly DataColumnDefinition defResidingPastorID;
       public static readonly DataColumnDefinition defBankID;
       public static readonly DataColumnDefinition defAccountNumber;
       public static readonly DataColumnDefinition defDonationYear;
       public static readonly DataColumnDefinition defDonationMonth;
       public static readonly DataColumnDefinition defIsApproved;
       public static readonly DataColumnDefinition defIsDisbursed;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public Int32 CenterID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CenterID.ToString()]);
           }
       }


       public Int32 ResidingPastorID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ResidingPastorID.ToString()]);
           }
       }


       public Int32 BankID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.BankID.ToString()]);
           }
       }


       public String AccountNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.AccountNumber.ToString()]);
           }
       }


       public Int32 DonationYear {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DonationYear.ToString()]);
           }
       }


       public Int32 DonationMonth {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DonationMonth.ToString()]);
           }
       }


       public Boolean IsApproved {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsApproved.ToString()]);
           }
       }


       public Boolean IsDisbursed {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsDisbursed.ToString()]);
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


       public Int32 CreatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.CreatedByID.ToString()]);
           }
       }


       public Int32 UpdatedByID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UpdatedByID.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___MonthlyDonation GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___MonthlyDonation GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___MonthlyDonation GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___MonthlyDonation(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___MonthlyDonation GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => MonthlyDonation__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCenterID,
Int32 pResidingPastorID,
Int32 pBankID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
                DataColumnParameter paramResidingPastorID = new DataColumnParameter(defResidingPastorID, pResidingPastorID);
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue);
                DataColumnParameter paramDonationYear = new DataColumnParameter(defDonationYear, defDonationYear.DefaultValue);
                DataColumnParameter paramDonationMonth = new DataColumnParameter(defDonationMonth, defDonationMonth.DefaultValue);
                DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, defIsApproved.DefaultValue);
                DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, defIsDisbursed.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramCenterID.GetSQLQuotedValueForAdd(),
                paramResidingPastorID.GetSQLQuotedValueForAdd(),
                paramBankID.GetSQLQuotedValueForAdd(),
                paramAccountNumber.GetSQLQuotedValueForAdd(),
                paramDonationYear.GetSQLQuotedValueForAdd(),
                paramDonationMonth.GetSQLQuotedValueForAdd(),
                paramIsApproved.GetSQLQuotedValueForAdd(),
                paramIsDisbursed.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedByID.GetSQLQuotedValueForAdd(),
                paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pCenterID,
Int32 pResidingPastorID,
Int32 pBankID,
String pAccountNumber,
Int32 pDonationYear,
Int32 pDonationMonth,
Boolean pIsApproved,
Boolean pIsDisbursed,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
                DataColumnParameter paramResidingPastorID = new DataColumnParameter(defResidingPastorID, pResidingPastorID);
                DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
                DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
                DataColumnParameter paramDonationYear = new DataColumnParameter(defDonationYear, pDonationYear);
                DataColumnParameter paramDonationMonth = new DataColumnParameter(defDonationMonth, pDonationMonth);
                DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, pIsApproved);
                DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, pIsDisbursed);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramCenterID.GetSQLQuotedValueForAdd(),
paramResidingPastorID.GetSQLQuotedValueForAdd(),
paramBankID.GetSQLQuotedValueForAdd(),
paramAccountNumber.GetSQLQuotedValueForAdd(),
paramDonationYear.GetSQLQuotedValueForAdd(),
paramDonationMonth.GetSQLQuotedValueForAdd(),
paramIsApproved.GetSQLQuotedValueForAdd(),
paramIsDisbursed.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pCenterID,
Int32 pResidingPastorID,
Int32 pBankID,
String pAccountNumber,
Int32 pDonationYear,
Int32 pDonationMonth,
Boolean pIsApproved,
Boolean pIsDisbursed,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
DataColumnParameter paramResidingPastorID = new DataColumnParameter(defResidingPastorID, pResidingPastorID);
DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
DataColumnParameter paramDonationYear = new DataColumnParameter(defDonationYear, pDonationYear);
DataColumnParameter paramDonationMonth = new DataColumnParameter(defDonationMonth, pDonationMonth);
DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, pIsApproved);
DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, pIsDisbursed);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramCenterID.GetSQLQuotedValueForAdd(),
paramResidingPastorID.GetSQLQuotedValueForAdd(),
paramBankID.GetSQLQuotedValueForAdd(),
paramAccountNumber.GetSQLQuotedValueForAdd(),
paramDonationYear.GetSQLQuotedValueForAdd(),
paramDonationMonth.GetSQLQuotedValueForAdd(),
paramIsApproved.GetSQLQuotedValueForAdd(),
paramIsDisbursed.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pCenterID,
Int32 pResidingPastorID,
Int32 pBankID,
String pAccountNumber,
Int32 pDonationYear,
Int32 pDonationMonth,
Boolean pIsApproved,
Boolean pIsDisbursed,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID){

        try{

DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
DataColumnParameter paramResidingPastorID = new DataColumnParameter(defResidingPastorID, pResidingPastorID);
DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
DataColumnParameter paramDonationYear = new DataColumnParameter(defDonationYear, pDonationYear);
DataColumnParameter paramDonationMonth = new DataColumnParameter(defDonationMonth, pDonationMonth);
DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, pIsApproved);
DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, pIsDisbursed);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) ", TABLE_NAME,paramCenterID.GetSQLQuotedValueForAdd(),
paramResidingPastorID.GetSQLQuotedValueForAdd(),
paramBankID.GetSQLQuotedValueForAdd(),
paramAccountNumber.GetSQLQuotedValueForAdd(),
paramDonationYear.GetSQLQuotedValueForAdd(),
paramDonationMonth.GetSQLQuotedValueForAdd(),
paramIsApproved.GetSQLQuotedValueForAdd(),
paramIsDisbursed.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);


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
Object pCenterID = null,
Object pResidingPastorID = null,
Object pBankID = null,
Object pAccountNumber = null,
Object pDonationYear = null,
Object pDonationMonth = null,
Object pIsApproved = null,
Object pIsDisbursed = null,
Object pCreatedAt = null,
Object pUpdatedAt = null,
Object pCreatedByID = null,
Object pUpdatedByID = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramCenterID = new DataColumnParameter(defCenterID, pCenterID);
 DataColumnParameter paramResidingPastorID = new DataColumnParameter(defResidingPastorID, pResidingPastorID);
 DataColumnParameter paramBankID = new DataColumnParameter(defBankID, pBankID);
 DataColumnParameter paramAccountNumber = new DataColumnParameter(defAccountNumber, pAccountNumber);
 DataColumnParameter paramDonationYear = new DataColumnParameter(defDonationYear, pDonationYear);
 DataColumnParameter paramDonationMonth = new DataColumnParameter(defDonationMonth, pDonationMonth);
 DataColumnParameter paramIsApproved = new DataColumnParameter(defIsApproved, pIsApproved);
 DataColumnParameter paramIsDisbursed = new DataColumnParameter(defIsDisbursed, pIsDisbursed);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [CenterID]={2},[ResidingPastorID]={3},[BankID]={4},[AccountNumber]={5},[DonationYear]={6},[DonationMonth]={7},[IsApproved]={8},[IsDisbursed]={9},[CreatedAt]={10},[UpdatedAt]={11},[CreatedByID]={12},[UpdatedByID]={13} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramCenterID.GetSQLQuotedValueForUpdate(),
paramResidingPastorID.GetSQLQuotedValueForUpdate(),
paramBankID.GetSQLQuotedValueForUpdate(),
paramAccountNumber.GetSQLQuotedValueForUpdate(),
paramDonationYear.GetSQLQuotedValueForUpdate(),
paramDonationMonth.GetSQLQuotedValueForUpdate(),
paramIsApproved.GetSQLQuotedValueForUpdate(),
paramIsDisbursed.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramCreatedByID.GetSQLQuotedValueForUpdate(),
paramUpdatedByID.GetSQLQuotedValueForUpdate()  ), true);


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
