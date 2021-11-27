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

    public class T___Term : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Term()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Name.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defDescription = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Description.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defStartDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.StartDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defEndDate = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.EndDate.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIsActive = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IsActive.ToString(), typeof(Boolean),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAcademicSessionID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.AcademicSessionID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);
          defTermOrderID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TermOrderID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNIQUE);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defDescription.ColumnName, defDescription); 
          ColumnDefns.Add(defStartDate.ColumnName, defStartDate); 
          ColumnDefns.Add(defEndDate.ColumnName, defEndDate); 
          ColumnDefns.Add(defIsActive.ColumnName, defIsActive); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID); 
          ColumnDefns.Add(defTermOrderID.ColumnName, defTermOrderID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_academic_Term_AcademicSessionID", false, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "academic.Term", "academic.AcademicSession"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_academic_Term_TermOrderID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "academic.Term", "academic.TermOrder"                  
                            ));                  

          }


                  
       public T___Term() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Term(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Term(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Term(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Term(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Term(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Term(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Term(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Term(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Term(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "academic.Term";
       public const string Term__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Name], [Description], [StartDate], [EndDate], [IsActive], [CreatedAt], [UpdatedAt], [AcademicSessionID], [TermOrderID] FROM Term";
       public const string Term__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Name], [Description], [StartDate], [EndDate], [IsActive], [CreatedAt], [UpdatedAt], [AcademicSessionID], [TermOrderID] FROM Term";


       public enum TableColumnNames
       {

           ID,
           Name,
           Description,
           StartDate,
           EndDate,
           IsActive,
           CreatedAt,
           UpdatedAt,
           AcademicSessionID,
           TermOrderID
       } 



       public enum TableConstraints{

           pk_academic_Term, 
           fk_academic_Term_AcademicSessionID, 
           fk_academic_Term_TermOrderID, 
           uq_academic_Term_AcademicSessionID, 
           uq_academic_Term_name, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defDescription;
       public static readonly DataColumnDefinition defStartDate;
       public static readonly DataColumnDefinition defEndDate;
       public static readonly DataColumnDefinition defIsActive;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defAcademicSessionID;
       public static readonly DataColumnDefinition defTermOrderID;

       public String Name {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Name.ToString()]);
           }
       }


       public String Description {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Description.ToString()]);
           }
       }


       public NullableDateTime StartDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.StartDate.ToString()]);
           }
       }


       public NullableDateTime EndDate {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.EndDate.ToString()]);
           }
       }


       public Boolean IsActive {
           get{ 
               if (!this.IsTargettedRowValid) return false;
               return EBoolean.valueOf(this.TargettedRow[TableColumnNames.IsActive.ToString()]);
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


       public Int32 AcademicSessionID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.AcademicSessionID.ToString()]);
           }
       }


       public Int32 TermOrderID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.TermOrderID.ToString()]);
           }
       }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Term GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Term GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Term GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Term(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Term GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Term__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(String pName,
Int32 pAcademicSessionID,
Int32 pTermOrderID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramName = new DataColumnParameter(defName, pName);
                DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
                DataColumnParameter paramTermOrderID = new DataColumnParameter(defTermOrderID, pTermOrderID);
                DataColumnParameter paramDescription = new DataColumnParameter(defDescription, defDescription.DefaultValue);
                DataColumnParameter paramStartDate = new DataColumnParameter(defStartDate, defStartDate.DefaultValue);
                DataColumnParameter paramEndDate = new DataColumnParameter(defEndDate, defEndDate.DefaultValue);
                DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, defIsActive.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Description],[StartDate],[EndDate],[IsActive],[CreatedAt],[UpdatedAt],[AcademicSessionID],[TermOrderID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramName.GetSQLQuotedValueForAdd(),
                paramDescription.GetSQLQuotedValueForAdd(),
                paramStartDate.GetSQLQuotedValueForAdd(),
                paramEndDate.GetSQLQuotedValueForAdd(),
                paramIsActive.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd(),
                paramAcademicSessionID.GetSQLQuotedValueForAdd(),
                paramTermOrderID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(String pName,
DateTime pStartDate,
DateTime pEndDate,
Boolean pIsActive,
DateTime pCreatedAt,
Int32 pAcademicSessionID,
Int32 pTermOrderID,
Object pDescription = null,
Object pUpdatedAt = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramName = new DataColumnParameter(defName, pName);
                DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
                DataColumnParameter paramStartDate = new DataColumnParameter(defStartDate, pStartDate);
                DataColumnParameter paramEndDate = new DataColumnParameter(defEndDate, pEndDate);
                DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
                DataColumnParameter paramTermOrderID = new DataColumnParameter(defTermOrderID, pTermOrderID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Description],[StartDate],[EndDate],[IsActive],[CreatedAt],[UpdatedAt],[AcademicSessionID],[TermOrderID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramName.GetSQLQuotedValueForAdd(),
paramDescription.GetSQLQuotedValueForAdd(),
paramStartDate.GetSQLQuotedValueForAdd(),
paramEndDate.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramAcademicSessionID.GetSQLQuotedValueForAdd(),
paramTermOrderID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,String pName,
DateTime pStartDate,
DateTime pEndDate,
Boolean pIsActive,
DateTime pCreatedAt,
Int32 pAcademicSessionID,
Int32 pTermOrderID,
Object pDescription = null,
Object pUpdatedAt = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramName = new DataColumnParameter(defName, pName);
DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
DataColumnParameter paramStartDate = new DataColumnParameter(defStartDate, pStartDate);
DataColumnParameter paramEndDate = new DataColumnParameter(defEndDate, pEndDate);
DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
DataColumnParameter paramTermOrderID = new DataColumnParameter(defTermOrderID, pTermOrderID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Description],[StartDate],[EndDate],[IsActive],[CreatedAt],[UpdatedAt],[AcademicSessionID],[TermOrderID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramName.GetSQLQuotedValueForAdd(),
paramDescription.GetSQLQuotedValueForAdd(),
paramStartDate.GetSQLQuotedValueForAdd(),
paramEndDate.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramAcademicSessionID.GetSQLQuotedValueForAdd(),
paramTermOrderID.GetSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(String pName,
DateTime pStartDate,
DateTime pEndDate,
Boolean pIsActive,
DateTime pCreatedAt,
Int32 pAcademicSessionID,
Int32 pTermOrderID,
Object pDescription= null,
Object pUpdatedAt= null){

        try{

DataColumnParameter paramName = new DataColumnParameter(defName, pName);
DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
DataColumnParameter paramStartDate = new DataColumnParameter(defStartDate, pStartDate);
DataColumnParameter paramEndDate = new DataColumnParameter(defEndDate, pEndDate);
DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
DataColumnParameter paramTermOrderID = new DataColumnParameter(defTermOrderID, pTermOrderID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([Name],[Description],[StartDate],[EndDate],[IsActive],[CreatedAt],[UpdatedAt],[AcademicSessionID],[TermOrderID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) ", TABLE_NAME,paramName.GetSQLQuotedValueForAdd(),
paramDescription.GetSQLQuotedValueForAdd(),
paramStartDate.GetSQLQuotedValueForAdd(),
paramEndDate.GetSQLQuotedValueForAdd(),
paramIsActive.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramAcademicSessionID.GetSQLQuotedValueForAdd(),
paramTermOrderID.GetSQLQuotedValueForAdd()  ), true);


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
Object pName = null,
Object pStartDate = null,
Object pEndDate = null,
Object pIsActive = null,
Object pCreatedAt = null,
Object pAcademicSessionID = null,
Object pTermOrderID = null,
Object pDescription = null,
Object pUpdatedAt = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramName = new DataColumnParameter(defName, pName);
 DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
 DataColumnParameter paramStartDate = new DataColumnParameter(defStartDate, pStartDate);
 DataColumnParameter paramEndDate = new DataColumnParameter(defEndDate, pEndDate);
 DataColumnParameter paramIsActive = new DataColumnParameter(defIsActive, pIsActive);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramAcademicSessionID = new DataColumnParameter(defAcademicSessionID, pAcademicSessionID);
 DataColumnParameter paramTermOrderID = new DataColumnParameter(defTermOrderID, pTermOrderID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [Name]={2},[Description]={3},[StartDate]={4},[EndDate]={5},[IsActive]={6},[CreatedAt]={7},[UpdatedAt]={8},[AcademicSessionID]={9},[TermOrderID]={10} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramName.GetSQLQuotedValueForUpdate(),
paramDescription.GetSQLQuotedValueForUpdate(),
paramStartDate.GetSQLQuotedValueForUpdate(),
paramEndDate.GetSQLQuotedValueForUpdate(),
paramIsActive.GetSQLQuotedValueForUpdate(),
paramCreatedAt.GetSQLQuotedValueForUpdate(),
paramUpdatedAt.GetSQLQuotedValueForUpdate(),
paramAcademicSessionID.GetSQLQuotedValueForUpdate(),
paramTermOrderID.GetSQLQuotedValueForUpdate()  ), true);


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
