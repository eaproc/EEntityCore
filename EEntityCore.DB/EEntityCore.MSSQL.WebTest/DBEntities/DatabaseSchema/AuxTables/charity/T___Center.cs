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

    public class T___Center : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___Center()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defName = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Name.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defAddress = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Address.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defBeneficiariesAvailableOnRegistration = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.BeneficiariesAvailableOnRegistration.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCenterStatusID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CenterStatusID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defYearFounded = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.YearFounded.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defChurchCapacity = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ChurchCapacity.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defComments = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Comments.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureStoredPath = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.PictureStoredPath.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUpdatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defUpdatedByID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UpdatedByID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defName.ColumnName, defName); 
          ColumnDefns.Add(defAddress.ColumnName, defAddress); 
          ColumnDefns.Add(defBeneficiariesAvailableOnRegistration.ColumnName, defBeneficiariesAvailableOnRegistration); 
          ColumnDefns.Add(defCenterStatusID.ColumnName, defCenterStatusID); 
          ColumnDefns.Add(defYearFounded.ColumnName, defYearFounded); 
          ColumnDefns.Add(defChurchCapacity.ColumnName, defChurchCapacity); 
          ColumnDefns.Add(defComments.ColumnName, defComments); 
          ColumnDefns.Add(defPictureStoredPath.ColumnName, defPictureStoredPath); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt); 
          ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID); 
          ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Center_CenterStatusID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Center", "charity.CenterStatus"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Center_CreatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Center", "auth.Users"                  
                            ));                  
            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Center_UpdatedByID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Center", "auth.Users"                  
                            ));                  

          }


                  
       public T___Center() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___Center(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___Center(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___Center(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "charity.Center";
       public const string Center__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Name], [Address], [BeneficiariesAvailableOnRegistration], [CenterStatusID], [YearFounded], [ChurchCapacity], [Comments], [PictureStoredPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM Center";
       public const string Center__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Name], [Address], [BeneficiariesAvailableOnRegistration], [CenterStatusID], [YearFounded], [ChurchCapacity], [Comments], [PictureStoredPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM Center";


       public enum TableColumnNames
       {

           ID,
           Name,
           Address,
           BeneficiariesAvailableOnRegistration,
           CenterStatusID,
           YearFounded,
           ChurchCapacity,
           Comments,
           PictureStoredPath,
           CreatedAt,
           UpdatedAt,
           CreatedByID,
           UpdatedByID
       } 



       public enum TableConstraints{

           pk_charity_Center, 
           fk_charity_Center_CenterStatusID, 
           fk_charity_Center_CreatedByID, 
           fk_charity_Center_UpdatedByID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defName;
       public static readonly DataColumnDefinition defAddress;
       public static readonly DataColumnDefinition defBeneficiariesAvailableOnRegistration;
       public static readonly DataColumnDefinition defCenterStatusID;
       public static readonly DataColumnDefinition defYearFounded;
       public static readonly DataColumnDefinition defChurchCapacity;
       public static readonly DataColumnDefinition defComments;
       public static readonly DataColumnDefinition defPictureStoredPath;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defUpdatedAt;
       public static readonly DataColumnDefinition defCreatedByID;
       public static readonly DataColumnDefinition defUpdatedByID;

       public string Name { get => (string)TargettedRow[TableColumnNames.Name.ToString()]; }


       public string Address { get => (string)TargettedRow[TableColumnNames.Address.ToString()]; }


       public int BeneficiariesAvailableOnRegistration { get => (int)TargettedRow[TableColumnNames.BeneficiariesAvailableOnRegistration.ToString()]; }


       public int CenterStatusID { get => (int)TargettedRow[TableColumnNames.CenterStatusID.ToString()]; }


       public int YearFounded { get => (int)TargettedRow[TableColumnNames.YearFounded.ToString()]; }


       public int ChurchCapacity { get => (int)TargettedRow[TableColumnNames.ChurchCapacity.ToString()]; }


       public string Comments { get => (string)TargettedRow[TableColumnNames.Comments.ToString()]; }


       public string PictureStoredPath { get => (string)TargettedRow[TableColumnNames.PictureStoredPath.ToString()]; }


       public NullableDateTime CreatedAt { get => new (this.TargettedRow[TableColumnNames.CreatedAt.ToString()]); }


       public NullableDateTime UpdatedAt { get => new (this.TargettedRow[TableColumnNames.UpdatedAt.ToString()]); }


       public int CreatedByID { get => (int)TargettedRow[TableColumnNames.CreatedByID.ToString()]; }


       public int UpdatedByID { get => (int)TargettedRow[TableColumnNames.UpdatedByID.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___Center GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___Center GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___Center GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___Center(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___Center GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => Center__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        public static int AddNewDefault(Int32 pCenterStatusID,
Int32 pCreatedByID,
Int32 pUpdatedByID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramCenterStatusID = new DataColumnParameter(defCenterStatusID, pCenterStatusID);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);
                DataColumnParameter paramName = new DataColumnParameter(defName, defName.DefaultValue);
                DataColumnParameter paramAddress = new DataColumnParameter(defAddress, defAddress.DefaultValue);
                DataColumnParameter paramBeneficiariesAvailableOnRegistration = new DataColumnParameter(defBeneficiariesAvailableOnRegistration, defBeneficiariesAvailableOnRegistration.DefaultValue);
                DataColumnParameter paramYearFounded = new DataColumnParameter(defYearFounded, defYearFounded.DefaultValue);
                DataColumnParameter paramChurchCapacity = new DataColumnParameter(defChurchCapacity, defChurchCapacity.DefaultValue);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, defComments.DefaultValue);
                DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, defPictureStoredPath.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.GetSQLQuotedValueForAdd(),
                paramName.GetSQLQuotedValueForAdd(),
                paramAddress.GetSQLQuotedValueForAdd(),
                paramBeneficiariesAvailableOnRegistration.GetSQLQuotedValueForAdd(),
                paramCenterStatusID.GetSQLQuotedValueForAdd(),
                paramYearFounded.GetSQLQuotedValueForAdd(),
                paramChurchCapacity.GetSQLQuotedValueForAdd(),
                paramComments.GetSQLQuotedValueForAdd(),
                paramPictureStoredPath.GetSQLQuotedValueForAdd(),
                paramCreatedAt.GetSQLQuotedValueForAdd(),
                paramUpdatedAt.GetSQLQuotedValueForAdd(),
                paramCreatedByID.GetSQLQuotedValueForAdd(),
                paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pBeneficiariesAvailableOnRegistration,
Int32 pCenterStatusID,
Int32 pYearFounded,
Int32 pChurchCapacity,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pName = null,
Object pAddress = null,
Object pComments = null,
Object pPictureStoredPath = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramName = new DataColumnParameter(defName, pName);
                DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
                DataColumnParameter paramBeneficiariesAvailableOnRegistration = new DataColumnParameter(defBeneficiariesAvailableOnRegistration, pBeneficiariesAvailableOnRegistration);
                DataColumnParameter paramCenterStatusID = new DataColumnParameter(defCenterStatusID, pCenterStatusID);
                DataColumnParameter paramYearFounded = new DataColumnParameter(defYearFounded, pYearFounded);
                DataColumnParameter paramChurchCapacity = new DataColumnParameter(defChurchCapacity, pChurchCapacity);
                DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
                DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
                DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
                DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramName.GetSQLQuotedValueForAdd(),
paramAddress.GetSQLQuotedValueForAdd(),
paramBeneficiariesAvailableOnRegistration.GetSQLQuotedValueForAdd(),
paramCenterStatusID.GetSQLQuotedValueForAdd(),
paramYearFounded.GetSQLQuotedValueForAdd(),
paramChurchCapacity.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramPictureStoredPath.GetSQLQuotedValueForAdd(),
paramCreatedAt.GetSQLQuotedValueForAdd(),
paramUpdatedAt.GetSQLQuotedValueForAdd(),
paramCreatedByID.GetSQLQuotedValueForAdd(),
paramUpdatedByID.GetSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pBeneficiariesAvailableOnRegistration,
Int32 pCenterStatusID,
Int32 pYearFounded,
Int32 pChurchCapacity,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pName = null,
Object pAddress = null,
Object pComments = null,
Object pPictureStoredPath = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramName = new DataColumnParameter(defName, pName);
DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
DataColumnParameter paramBeneficiariesAvailableOnRegistration = new DataColumnParameter(defBeneficiariesAvailableOnRegistration, pBeneficiariesAvailableOnRegistration);
DataColumnParameter paramCenterStatusID = new DataColumnParameter(defCenterStatusID, pCenterStatusID);
DataColumnParameter paramYearFounded = new DataColumnParameter(defYearFounded, pYearFounded);
DataColumnParameter paramChurchCapacity = new DataColumnParameter(defChurchCapacity, pChurchCapacity);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.GetSQLQuotedValueForAdd(),
paramName.GetSQLQuotedValueForAdd(),
paramAddress.GetSQLQuotedValueForAdd(),
paramBeneficiariesAvailableOnRegistration.GetSQLQuotedValueForAdd(),
paramCenterStatusID.GetSQLQuotedValueForAdd(),
paramYearFounded.GetSQLQuotedValueForAdd(),
paramChurchCapacity.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramPictureStoredPath.GetSQLQuotedValueForAdd(),
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
        public static bool Add(Int32 pBeneficiariesAvailableOnRegistration,
Int32 pCenterStatusID,
Int32 pYearFounded,
Int32 pChurchCapacity,
DateTime pCreatedAt,
DateTime pUpdatedAt,
Int32 pCreatedByID,
Int32 pUpdatedByID,
Object pName= null,
Object pAddress= null,
Object pComments= null,
Object pPictureStoredPath= null){

        try{

DataColumnParameter paramName = new DataColumnParameter(defName, pName);
DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
DataColumnParameter paramBeneficiariesAvailableOnRegistration = new DataColumnParameter(defBeneficiariesAvailableOnRegistration, pBeneficiariesAvailableOnRegistration);
DataColumnParameter paramCenterStatusID = new DataColumnParameter(defCenterStatusID, pCenterStatusID);
DataColumnParameter paramYearFounded = new DataColumnParameter(defYearFounded, pYearFounded);
DataColumnParameter paramChurchCapacity = new DataColumnParameter(defChurchCapacity, pChurchCapacity);
DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([Name],[Address],[BeneficiariesAvailableOnRegistration],[CenterStatusID],[YearFounded],[ChurchCapacity],[Comments],[PictureStoredPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) ", TABLE_NAME,paramName.GetSQLQuotedValueForAdd(),
paramAddress.GetSQLQuotedValueForAdd(),
paramBeneficiariesAvailableOnRegistration.GetSQLQuotedValueForAdd(),
paramCenterStatusID.GetSQLQuotedValueForAdd(),
paramYearFounded.GetSQLQuotedValueForAdd(),
paramChurchCapacity.GetSQLQuotedValueForAdd(),
paramComments.GetSQLQuotedValueForAdd(),
paramPictureStoredPath.GetSQLQuotedValueForAdd(),
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
Object pBeneficiariesAvailableOnRegistration = null,
Object pCenterStatusID = null,
Object pYearFounded = null,
Object pChurchCapacity = null,
Object pCreatedAt = null,
Object pUpdatedAt = null,
Object pCreatedByID = null,
Object pUpdatedByID = null,
Object pName = null,
Object pAddress = null,
Object pComments = null,
Object pPictureStoredPath = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramName = new DataColumnParameter(defName, pName);
 DataColumnParameter paramAddress = new DataColumnParameter(defAddress, pAddress);
 DataColumnParameter paramBeneficiariesAvailableOnRegistration = new DataColumnParameter(defBeneficiariesAvailableOnRegistration, pBeneficiariesAvailableOnRegistration);
 DataColumnParameter paramCenterStatusID = new DataColumnParameter(defCenterStatusID, pCenterStatusID);
 DataColumnParameter paramYearFounded = new DataColumnParameter(defYearFounded, pYearFounded);
 DataColumnParameter paramChurchCapacity = new DataColumnParameter(defChurchCapacity, pChurchCapacity);
 DataColumnParameter paramComments = new DataColumnParameter(defComments, pComments);
 DataColumnParameter paramPictureStoredPath = new DataColumnParameter(defPictureStoredPath, pPictureStoredPath);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramUpdatedAt = new DataColumnParameter(defUpdatedAt, pUpdatedAt);
 DataColumnParameter paramCreatedByID = new DataColumnParameter(defCreatedByID, pCreatedByID);
 DataColumnParameter paramUpdatedByID = new DataColumnParameter(defUpdatedByID, pUpdatedByID);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [Name]={2},[Address]={3},[BeneficiariesAvailableOnRegistration]={4},[CenterStatusID]={5},[YearFounded]={6},[ChurchCapacity]={7},[Comments]={8},[PictureStoredPath]={9},[CreatedAt]={10},[UpdatedAt]={11},[CreatedByID]={12},[UpdatedByID]={13} WHERE ID={1} ", TABLE_NAME, paramID.GetSQLQuotedValueForUpdate(),paramName.GetSQLQuotedValueForUpdate(),
paramAddress.GetSQLQuotedValueForUpdate(),
paramBeneficiariesAvailableOnRegistration.GetSQLQuotedValueForUpdate(),
paramCenterStatusID.GetSQLQuotedValueForUpdate(),
paramYearFounded.GetSQLQuotedValueForUpdate(),
paramChurchCapacity.GetSQLQuotedValueForUpdate(),
paramComments.GetSQLQuotedValueForUpdate(),
paramPictureStoredPath.GetSQLQuotedValueForUpdate(),
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
