using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
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
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defPaymentTransactionID = new DataColumnDefinition(TableColumnNames.PaymentTransactionID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defStudentNumber = new DataColumnDefinition(TableColumnNames.StudentNumber.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPaymentRequiredWithoutCharges = new DataColumnDefinition(TableColumnNames.PaymentRequiredWithoutCharges.ToString(), typeof(Decimal),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

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
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___PaymentTransactionTarget GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___PaymentTransactionTarget(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___PaymentTransactionTarget GetFullTable()                  
        {                  
            return new T___PaymentTransactionTarget(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___PaymentTransactionTarget GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___PaymentTransactionTarget(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___PaymentTransactionTarget GetRowWhereID(int pID)                  
        {                  
            return new T___PaymentTransactionTarget(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___PaymentTransactionTarget pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (!pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return false;                  
                }                  
                  
                return true;                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  
                  
        private bool IsAnyRowEqual(T___PaymentTransactionTarget pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.HasRows())                  
                    return false;                  
                foreach (var pParam in pParams)                  
                {                  
                    if (pRow.RowEqual(pParam.ColumnName, pParam.Value))                  
                        return true;                  
                }                  
                  
                return false;                  
            }                  
            catch (Exception )                  
            {                  
                return false;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___PaymentTransactionTarget GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___PaymentTransactionTarget(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___PaymentTransactionTarget(drst);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM                errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___PaymentTransactionTarget getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___PaymentTransactionTarget(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___PaymentTransactionTarget(drst);                  
                return null;                  
            }                  
            catch (Exception)                  
            {                  
                // REM errorMsg(ex.Message, 1)                                                       
                return null;                  
            }                  
        }                  
                  
        public Dictionary<string, DataColumnDefinition> getDefinitions()                  
        {                  
            return ColumnDefns;                  
        }                  
                  
        private bool RowEqual(string pColumnName, object pColumnValue)                  
        {                  
            try                  
            {                  
                if (!this.IsTargettedRowValid)                  
                    return false;                  
                switch (DataColumnDefinition.getTypeAllowed(ColumnDefns[pColumnName].DataType))                  
                {                  
                    case var @case when @case == DataColumnDefinition.AllowedDataTypes.Bool:                  
                        {                  
                            return EBoolean.valueOf(this.TargettedRow[pColumnName]) == EBoolean.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case1 when case1 == DataColumnDefinition.AllowedDataTypes.Blob:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    case var case2 when case2 == DataColumnDefinition.AllowedDataTypes.DateTime:                  
                        {                  
                            return EDateTime.EqualsDateWithoutTime(new NullableDateTime(this.TargettedRow[pColumnName]).DateTimeValue, new NullableDateTime(pColumnValue).DateTimeValue);                  
                        }                  
                  
                    case var case3 when case3 == DataColumnDefinition.AllowedDataTypes.Decimal:                  
                        {                  
                            return EDouble.valueOf(this.TargettedRow[pColumnName]) == EDouble.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case4 when case4 == DataColumnDefinition.AllowedDataTypes.Int:                  
                        {                  
                            return EInt.valueOf(this.TargettedRow[pColumnName]) == EInt.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case5 when case5 == DataColumnDefinition.AllowedDataTypes.Long:                  
                        {                  
                            return ELong.valueOf(this.TargettedRow[pColumnName]) == ELong.valueOf(pColumnValue);                  
                        }                  
                  
                    case var case6 when case6 == DataColumnDefinition.AllowedDataTypes.String:                  
                        {                  
                            return EStrings.equalsIgnoreCase(EStrings.valueOf(this.TargettedRow[pColumnName]), EStrings.valueOf(pColumnValue));                  
                        }                  
                  
                    case var case7 when case7 == DataColumnDefinition.AllowedDataTypes.TimeSpan:                  
                        {                  
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                  
                    default:                  
                        {                  
                            // REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()                                                       
                            return object.Equals(this.TargettedRow[pColumnName], pColumnValue);                  
                        }                  
                }                  
            }                  
            catch (Exception)                  
            {                  
                return false;                  
            }                  
        }                  

                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
        public virtual string GetFillSQL() => PaymentTransactionTarget__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
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
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramPaymentTransactionID.getSQLQuotedValueForAdd(),
                paramStudentNumber.getSQLQuotedValueForAdd(),
                paramFirstName.getSQLQuotedValueForAdd(),
                paramLastName.getSQLQuotedValueForAdd(),
                paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd()  ), true);




                  
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
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd()  ), true);




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
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd()  ), true);




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
     String.Format("INSERT INTO {0}([PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5}) ", TABLE_NAME,paramPaymentTransactionID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd()  ), true);


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
     String.Format("UPDATE {0} SET [PaymentTransactionID]={2},[StudentNumber]={3},[FirstName]={4},[LastName]={5},[PaymentRequiredWithoutCharges]={6} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramPaymentTransactionID.getSQLQuotedValueForUpdate(),
paramStudentNumber.getSQLQuotedValueForUpdate(),
paramFirstName.getSQLQuotedValueForUpdate(),
paramLastName.getSQLQuotedValueForUpdate(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForUpdate()  ), true);


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
