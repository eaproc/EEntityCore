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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.pay_gateway                  
{                  

    public class T___PaymentTransactionTarget : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___PaymentTransactionTarget()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPaymentTransactionID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentTransactionID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStudentNumber = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.StudentNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.FirstName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.LastName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequiredWithoutCharges = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PaymentRequiredWithoutCharges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defPaymentTransactionID.ColumnName, defPaymentTransactionID); 
          ColumnDefns.Add(defStudentNumber.ColumnName, defStudentNumber); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defPaymentRequiredWithoutCharges.ColumnName, defPaymentRequiredWithoutCharges); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransactionTarget_PaymentTransactionID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "pay_gateway.PaymentTransactionTarget", "pay_gateway.PaymentTransaction"                  
                            ));                  

          }


                  
       public T___PaymentTransactionTarget() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___PaymentTransactionTarget(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___PaymentTransactionTarget(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___PaymentTransactionTarget(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "pay_gateway.PaymentTransactionTarget";
       public const string PaymentTransactionTarget__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [PaymentTransactionID], [StudentNumber], [FirstName], [LastName], [PaymentRequiredWithoutCharges] FROM PaymentTransactionTarget";
       public const string PaymentTransactionTarget__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [PaymentTransactionID], [StudentNumber], [FirstName], [LastName], [PaymentRequiredWithoutCharges] FROM PaymentTransactionTarget";


       public enum TableColumnNames
       {

           ID,
           PaymentTransactionID,
           StudentNumber,
           FirstName,
           LastName,
           PaymentRequiredWithoutCharges
       } 



       public enum TableConstraints{

           pk_pay_gateway_PaymentTransactionTarget, 
           fk_PaymentTransactionTarget_PaymentTransactionID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defPaymentTransactionID;
       public static readonly DataColumnDefinition defStudentNumber;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defPaymentRequiredWithoutCharges;

       public Int32 PaymentTransactionID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PaymentTransactionID.ToString()]);
           }
       }


       public String StudentNumber {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.StudentNumber.ToString()]);
           }
       }


       public String FirstName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FirstName.ToString()]);
           }
       }


       public String LastName {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.LastName.ToString()]);
           }
       }


       public Decimal PaymentRequiredWithoutCharges {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EDecimal.valueOf(this.TargettedRow[TableColumnNames.PaymentRequiredWithoutCharges.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___PaymentTransactionTarget GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___PaymentTransactionTarget GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___PaymentTransactionTarget GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___PaymentTransactionTarget(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___PaymentTransactionTarget GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => PaymentTransactionTarget__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pPaymentTransactionID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);
                DataColumnParameter paramStudentNumber = new DataColumnParameter(defStudentNumber, defStudentNumber.DefaultValue);
                DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, defFirstName.DefaultValue);
                DataColumnParameter paramLastName = new DataColumnParameter(defLastName, defLastName.DefaultValue);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, defPaymentRequiredWithoutCharges.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramPaymentTransactionID.GetSQLQuotedValueForAdd(),
                paramStudentNumber.GetSQLQuotedValueForAdd(),
                paramFirstName.GetSQLQuotedValueForAdd(),
                paramLastName.GetSQLQuotedValueForAdd(),
                paramPaymentRequiredWithoutCharges.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pPaymentTransactionID,
String pStudentNumber,
String pFirstName,
String pLastName,
Decimal pPaymentRequiredWithoutCharges){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);
                DataColumnParameter paramStudentNumber = new DataColumnParameter(defStudentNumber, pStudentNumber);
                DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
                DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
                DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramPaymentTransactionID.GetSQLQuotedValueForAdd(),
paramStudentNumber.GetSQLQuotedValueForAdd(),
paramFirstName.GetSQLQuotedValueForAdd(),
paramLastName.GetSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pPaymentTransactionID,
String pStudentNumber,
String pFirstName,
String pLastName,
Decimal pPaymentRequiredWithoutCharges){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);
DataColumnParameter paramStudentNumber = new DataColumnParameter(defStudentNumber, pStudentNumber);
DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramPaymentTransactionID.GetSQLQuotedValueForAdd(),
paramStudentNumber.GetSQLQuotedValueForAdd(),
paramFirstName.GetSQLQuotedValueForAdd(),
paramLastName.GetSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pPaymentTransactionID,
String pStudentNumber,
String pFirstName,
String pLastName,
Decimal pPaymentRequiredWithoutCharges){

        try{

DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);
DataColumnParameter paramStudentNumber = new DataColumnParameter(defStudentNumber, pStudentNumber);
DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5}) ", TABLE_NAME,paramPaymentTransactionID.GetSQLQuotedValueForAdd(),
paramStudentNumber.GetSQLQuotedValueForAdd(),
paramFirstName.GetSQLQuotedValueForAdd(),
paramLastName.GetSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.GetSQLQuotedValueForAdd()  ), true);


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
Object pPaymentTransactionID = null,
Object pStudentNumber = null,
Object pFirstName = null,
Object pLastName = null,
Object pPaymentRequiredWithoutCharges = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramPaymentTransactionID = new DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID);
 DataColumnParameter paramStudentNumber = new DataColumnParameter(defStudentNumber, pStudentNumber);
 DataColumnParameter paramFirstName = new DataColumnParameter(defFirstName, pFirstName);
 DataColumnParameter paramLastName = new DataColumnParameter(defLastName, pLastName);
 DataColumnParameter paramPaymentRequiredWithoutCharges = new DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [PaymentTransactionID]={2},[StudentNumber]={3},[FirstName]={4},[LastName]={5},[PaymentRequiredWithoutCharges]={6} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramPaymentTransactionID.GetSQLQuotedValueForUpdate(),
paramStudentNumber.GetSQLQuotedValueForUpdate(),
paramFirstName.GetSQLQuotedValueForUpdate(),
paramLastName.GetSQLQuotedValueForUpdate(),
paramPaymentRequiredWithoutCharges.GetSQLQuotedValueForUpdate()  ), true);


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
