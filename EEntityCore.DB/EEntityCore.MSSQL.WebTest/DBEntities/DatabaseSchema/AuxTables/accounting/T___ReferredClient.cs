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

    public class T___ReferredClient : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___ReferredClient()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defDealerID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.DealerID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defClientID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ClientID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defTermID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defReferralTypeID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ReferralTypeID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defReferralBenefitStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ReferralBenefitStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defDealerID.ColumnName, defDealerID); 
          ColumnDefns.Add(defClientID.ColumnName, defClientID); 
          ColumnDefns.Add(defTermID.ColumnName, defTermID); 
          ColumnDefns.Add(defReferralTypeID.ColumnName, defReferralTypeID); 
          ColumnDefns.Add(defReferralBenefitStatusID.ColumnName, defReferralBenefitStatusID); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferredClient_DealerID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferredClient", "accounting.Dealer"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferredClient_ClientID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferredClient", "hr.Client"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferredClient_TermID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferredClient", "academic.Term"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferredClient_ReferralTypeID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferredClient", "accounting.ReferralType"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_ReferredClient_ReferralBenefitStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.ReferredClient", "accounting.ReferralBenefitStatus"                  
                            ));                  

          }


                  
       public T___ReferredClient() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___ReferredClient(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___ReferredClient(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___ReferredClient(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "accounting.ReferredClient";
       public const string ReferredClient__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [DealerID], [ClientID], [TermID], [ReferralTypeID], [ReferralBenefitStatusID], [CreatedAt], [UpdatedAt] FROM ReferredClient";
       public const string ReferredClient__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [DealerID], [ClientID], [TermID], [ReferralTypeID], [ReferralBenefitStatusID], [CreatedAt], [UpdatedAt] FROM ReferredClient";


       public enum TableColumnNames
       {

           ID,
           DealerID,
           ClientID,
           TermID,
           ReferralTypeID,
           ReferralBenefitStatusID,
           CreatedAt,
           UpdatedAt
       } 



       public enum TableConstraints{

           pk_accounting_ReferredClient, 
           fk_accounting_ReferredClient_DealerID, 
           fk_accounting_ReferredClient_ClientID, 
           fk_accounting_ReferredClient_TermID, 
           fk_accounting_ReferredClient_ReferralTypeID, 
           fk_accounting_ReferredClient_ReferralBenefitStatusID, 
           uq_accounting_ReferredClient_ClientID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defDealerID;
       public static readonly DataColumnDefinition defClientID;
       public static readonly DataColumnDefinition defTermID;
       public static readonly DataColumnDefinition defReferralTypeID;
       public static readonly DataColumnDefinition defReferralBenefitStatusID;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;

       public Int32 DealerID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.DealerID.ToString()]);
           }
       }


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


       public Int32 ReferralTypeID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ReferralTypeID.ToString()]);
           }
       }


       public Int32 ReferralBenefitStatusID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.ReferralBenefitStatusID.ToString()]);
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
        public T___ReferredClient GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___ReferredClient GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___ReferredClient GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___ReferredClient(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___ReferredClient GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => ReferredClient__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pDealerID,
Int32 pClientID,
Int32 pTermID,
Int32 pReferralTypeID,
Int32 pReferralBenefitStatusID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramDealerID = new DataColumnParameter(defDealerID, pDealerID);
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
                DataColumnParameter paramReferralTypeID = new DataColumnParameter(defReferralTypeID, pReferralTypeID);
                DataColumnParameter paramReferralBenefitStatusID = new DataColumnParameter(defReferralBenefitStatusID, pReferralBenefitStatusID);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DealerID],[ClientID],[TermID],[ReferralTypeID],[ReferralBenefitStatusID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramDealerID.GetSQLQuotedValueForAdd(),
                paramClientID.GetSQLQuotedValueForAdd(),
                paramTermID.GetSQLQuotedValueForAdd(),
                paramReferralTypeID.GetSQLQuotedValueForAdd(),
                paramReferralBenefitStatusID.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pDealerID,
Int32 pClientID,
Int32 pTermID,
Int32 pReferralTypeID,
Int32 pReferralBenefitStatusID,
DateTime pCreatedAt,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramDealerID = new DataColumnParameter(defDealerID, pDealerID);
                DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
                DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
                DataColumnParameter paramReferralTypeID = new DataColumnParameter(defReferralTypeID, pReferralTypeID);
                DataColumnParameter paramReferralBenefitStatusID = new DataColumnParameter(defReferralBenefitStatusID, pReferralBenefitStatusID);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DealerID],[ClientID],[TermID],[ReferralTypeID],[ReferralBenefitStatusID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramDealerID.GetSQLQuotedValueForAdd(),
paramClientID.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramReferralTypeID.GetSQLQuotedValueForAdd(),
paramReferralBenefitStatusID.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pDealerID,
Int32 pClientID,
Int32 pTermID,
Int32 pReferralTypeID,
Int32 pReferralBenefitStatusID,
DateTime pCreatedAt,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramDealerID = new DataColumnParameter(defDealerID, pDealerID);
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
DataColumnParameter paramReferralTypeID = new DataColumnParameter(defReferralTypeID, pReferralTypeID);
DataColumnParameter paramReferralBenefitStatusID = new DataColumnParameter(defReferralBenefitStatusID, pReferralBenefitStatusID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DealerID],[ClientID],[TermID],[ReferralTypeID],[ReferralBenefitStatusID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramDealerID.GetSQLQuotedValueForAdd(),
paramClientID.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramReferralTypeID.GetSQLQuotedValueForAdd(),
paramReferralBenefitStatusID.GetSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pDealerID,
Int32 pClientID,
Int32 pTermID,
Int32 pReferralTypeID,
Int32 pReferralBenefitStatusID,
DateTime pCreatedAt,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramDealerID = new DataColumnParameter(defDealerID, pDealerID);
DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
DataColumnParameter paramReferralTypeID = new DataColumnParameter(defReferralTypeID, pReferralTypeID);
DataColumnParameter paramReferralBenefitStatusID = new DataColumnParameter(defReferralBenefitStatusID, pReferralBenefitStatusID);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([DealerID],[ClientID],[TermID],[ReferralTypeID],[ReferralBenefitStatusID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7}) ", TABLE_NAME,paramDealerID.GetSQLQuotedValueForAdd(),
paramClientID.GetSQLQuotedValueForAdd(),
paramTermID.GetSQLQuotedValueForAdd(),
paramReferralTypeID.GetSQLQuotedValueForAdd(),
paramReferralBenefitStatusID.GetSQLQuotedValueForAdd(),
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
Object pDealerID = null,
Object pClientID = null,
Object pTermID = null,
Object pReferralTypeID = null,
Object pReferralBenefitStatusID = null,
Object pCreatedAt = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramDealerID = new DataColumnParameter(defDealerID, pDealerID);
 DataColumnParameter paramClientID = new DataColumnParameter(defClientID, pClientID);
 DataColumnParameter paramTermID = new DataColumnParameter(defTermID, pTermID);
 DataColumnParameter paramReferralTypeID = new DataColumnParameter(defReferralTypeID, pReferralTypeID);
 DataColumnParameter paramReferralBenefitStatusID = new DataColumnParameter(defReferralBenefitStatusID, pReferralBenefitStatusID);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [DealerID]={2},[ClientID]={3},[TermID]={4},[ReferralTypeID]={5},[ReferralBenefitStatusID]={6},[CreatedAt]={7},[UpdatedAt]={8} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramDealerID.GetSQLQuotedValueForUpdate(),
paramClientID.GetSQLQuotedValueForUpdate(),
paramTermID.GetSQLQuotedValueForUpdate(),
paramReferralTypeID.GetSQLQuotedValueForUpdate(),
paramReferralBenefitStatusID.GetSQLQuotedValueForUpdate(),
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
