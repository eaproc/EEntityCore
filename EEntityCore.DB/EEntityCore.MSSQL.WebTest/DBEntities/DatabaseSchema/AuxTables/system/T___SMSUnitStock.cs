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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.system                  
{                  

    public class T___SMSUnitStock : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___SMSUnitStock()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defStockAmountNaira = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.StockAmountNaira.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defQuantity = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Quantity.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Comments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defStockAmountNaira.ColumnName, defStockAmountNaira); 
          ColumnDefns.Add(defQuantity.ColumnName, defQuantity); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  


          }


                  
       public T___SMSUnitStock() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUnitStock(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUnitStock(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUnitStock(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUnitStock(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___SMSUnitStock(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUnitStock(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUnitStock(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___SMSUnitStock(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___SMSUnitStock(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "system.SMSUnitStock";
       public const string SMSUnitStock__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [StockAmountNaira], [Quantity], [Comments], [CreatedAt] FROM SMSUnitStock";
       public const string SMSUnitStock__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [StockAmountNaira], [Quantity], [Comments], [CreatedAt] FROM SMSUnitStock";


       public enum TableColumnNames
       {

           ID,
           StockAmountNaira,
           Quantity,
           Comments,
           CreatedAt
       } 



       public enum TableConstraints{

           pk_system_SMSUnitStock, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defStockAmountNaira;
       public static readonly DataColumnDefinition defQuantity;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defCreatedAt;

       public Decimal StockAmountNaira {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.StockAmountNaira.ToString()]);
           }
       }


       public Decimal Quantity {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.Quantity.ToString()]);
           }
       }


       public String Comments {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Comments.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___SMSUnitStock GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___SMSUnitStock GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___SMSUnitStock GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___SMSUnitStock(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___SMSUnitStock GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => SMSUnitStock__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramStockAmountNaira = new DataColumnParameter(defStockAmountNaira, defStockAmountNaira.DefaultValue);
                DataColumnParameter paramQuantity = new DataColumnParameter(defQuantity, defQuantity.DefaultValue);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, defComments.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[StockAmountNaira],[Quantity],[Comments],[CreatedAt]) VALUES({1},{2},{3},{4},{5}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramStockAmountNaira.GetSQLQuotedValueForAdd(),
                paramQuantity.GetSQLQuotedValueForAdd(),
                paramComments.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Decimal pStockAmountNaira,
Decimal pQuantity,
DateTime pCreatedAt,
Object pComments = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramStockAmountNaira = new DataColumnParameter(defStockAmountNaira, pStockAmountNaira);
                DataColumnParameter paramQuantity = new DataColumnParameter(defQuantity, pQuantity);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[StockAmountNaira],[Quantity],[Comments],[CreatedAt]) VALUES({1},{2},{3},{4},{5}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramStockAmountNaira.GetSQLQuotedValueForAdd(),
paramQuantity.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Decimal pStockAmountNaira,
Decimal pQuantity,
DateTime pCreatedAt,
Object pComments = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramStockAmountNaira = new DataColumnParameter(defStockAmountNaira, pStockAmountNaira);
DataColumnParameter paramQuantity = new DataColumnParameter(defQuantity, pQuantity);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[StockAmountNaira],[Quantity],[Comments],[CreatedAt]) VALUES({1},{2},{3},{4},{5}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramStockAmountNaira.GetSQLQuotedValueForAdd(),
paramQuantity.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Decimal pStockAmountNaira,
Decimal pQuantity,
DateTime pCreatedAt,
Object pComments= null){

        try{

DataColumnParameter paramStockAmountNaira = new DataColumnParameter(defStockAmountNaira, pStockAmountNaira);
DataColumnParameter paramQuantity = new DataColumnParameter(defQuantity, pQuantity);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([StockAmountNaira],[Quantity],[Comments],[CreatedAt]) VALUES({1},{2},{3},{4}) ", TABLE_NAME,paramStockAmountNaira.GetSQLQuotedValueForAdd(),
paramQuantity.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd()  ), true);


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
Object pStockAmountNaira = null,
Object pQuantity = null,
Object pCreatedAt = null,
Object pComments = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramStockAmountNaira = new DataColumnParameter(defStockAmountNaira, pStockAmountNaira);
 DataColumnParameter paramQuantity = new DataColumnParameter(defQuantity, pQuantity);
 DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [StockAmountNaira]={2},[Quantity]={3},[Comments]={4},[CreatedAt]={5} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramStockAmountNaira.GetSQLQuotedValueForUpdate(),
paramQuantity.GetSQLQuotedValueForUpdate(),
paramComments.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate()  ), true);


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
