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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.auth                  
{                  

    public class T___UserNotification : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
 #region Constructors                  
                  
                  
       static T___UserNotification()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.PRIMARY);
          defUserID = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.UserID.ToString(), typeof(int),false, DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTitle = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Title.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defQuickNote = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.QuickNote.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDescription = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Description.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIconClass = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.IconClass.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHeadingColorClass = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.HeadingColorClass.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defReadAt = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.ReadAt.ToString(), typeof(DateTime?),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIdentifier = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.Identifier.ToString(), typeof(string),true, DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTargetURL = new DataColumnDefinition(new DatabaseInit(),TableColumnNames.TargetURL.ToString(), typeof(string),false, DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defUserID.ColumnName, defUserID); 
          ColumnDefns.Add(defTitle.ColumnName, defTitle); 
          ColumnDefns.Add(defQuickNote.ColumnName, defQuickNote); 
          ColumnDefns.Add(defDescription.ColumnName, defDescription); 
          ColumnDefns.Add(defIconClass.ColumnName, defIconClass); 
          ColumnDefns.Add(defHeadingColorClass.ColumnName, defHeadingColorClass); 
          ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt); 
          ColumnDefns.Add(defReadAt.ColumnName, defReadAt); 
          ColumnDefns.Add(defIdentifier.ColumnName, defIdentifier); 
          ColumnDefns.Add(defTargetURL.ColumnName, defTargetURL); 
                  
          ForeignKeys = new List<IDBTableDefinitionPlugIn.ForeignKeyDefinition>();                  
                  

            ForeignKeys.Add(new IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_UserNotification_UserID", false, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.UserNotification", "auth.Users"                  
                            ));                  

          }


                  
       public T___UserNotification() : base()                  
        {                  
        }                  


                  
   #region Full Access                                    
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                                      
                  
        /// <summary>                                                      
        /// FULL ACCESS. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="TableName"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(All__DBs DBConn) : base(DBConn)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(All__DBs DBConn, long pTargettedRowID) : base(DBConn,  pTargettedRowID: pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(All__DBs pDBConn, string pSQL) : base(pDBConn,  pSQL)                                    
        {                                    
        }                                    
                                    
                                    
        /// <summary>                                                      
        /// Full Access. This will load data with dbconn                                                      
        /// </summary>                                                      
        /// <param name="pTableName"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <param name="pSQL">Load table with your own SQL</param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(All__DBs pDBConn,  string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)                                    
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
        public T___UserNotification(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="pTableRows"></param>                                                      
        /// <param name="pTargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                                    
        {                                    
        }                                    
                                    
        /// <summary>                                                      
        /// Partial Access                                                      
        /// </summary>                                                      
        /// <param name="FullTable"></param>                                                      
        /// <param name="TargettedRowID"></param>                                                      
        /// <remarks></remarks>                                    
        public T___UserNotification(DataTable FullTable, int TargettedRowID) : base(FullTable, TargettedRowID)                                    
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
        public T___UserNotification(DataRow TargettedRow) : base(TargettedRow)                                    
        {                                    
        }                                    
                                    
        #endregion                                    
                                    
                                    
                                    
                                    
 #endregion                                    
                                    

 #region Consts and Enums                       

       public const string TABLE_NAME = "auth.UserNotification";
       public const string UserNotification__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [UserID], [Title], [QuickNote], [Description], [IconClass], [HeadingColorClass], [CreatedAt], [ReadAt], [Identifier], [TargetURL] FROM UserNotification";
       public const string UserNotification__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [UserID], [Title], [QuickNote], [Description], [IconClass], [HeadingColorClass], [CreatedAt], [ReadAt], [Identifier], [TargetURL] FROM UserNotification";


       public enum TableColumnNames
       {

           ID,
           UserID,
           Title,
           QuickNote,
           Description,
           IconClass,
           HeadingColorClass,
           CreatedAt,
           ReadAt,
           Identifier,
           TargetURL
       } 



       public enum TableConstraints{

           pk_auth_UserNotification, 
           fk_auth_UserNotification_UserID, 
       } 


 #endregion 




 #region Properties 

       private static readonly List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static readonly Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defUserID;
       public static readonly DataColumnDefinition defTitle;
       public static readonly DataColumnDefinition defQuickNote;
       public static readonly DataColumnDefinition defDescription;
       public static readonly DataColumnDefinition defIconClass;
       public static readonly DataColumnDefinition defHeadingColorClass;
       public static readonly DataColumnDefinition defCreatedAt;
       public static readonly DataColumnDefinition defReadAt;
       public static readonly DataColumnDefinition defIdentifier;
       public static readonly DataColumnDefinition defTargetURL;

       public int UserID { get => (int)TargettedRow[TableColumnNames.UserID.ToString()]; }


       public string Title { get => (string)TargettedRow[TableColumnNames.Title.ToString()]; }


       public string QuickNote { get => (string)TargettedRow[TableColumnNames.QuickNote.ToString()]; }


       public string Description { get => (string)TargettedRow[TableColumnNames.Description.ToString()]; }


       public string IconClass { get => (string)TargettedRow[TableColumnNames.IconClass.ToString()]; }


       public string HeadingColorClass { get => (string)TargettedRow[TableColumnNames.HeadingColorClass.ToString()]; }


       public DateTime CreatedAt { get => (DateTime)TargettedRow[TableColumnNames.CreatedAt.ToString()]; }


       public DateTime? ReadAt { get => (DateTime?)TargettedRow[TableColumnNames.ReadAt.ToString()]; }


       public string Identifier { get => (string)TargettedRow[TableColumnNames.Identifier.ToString()]; }


       public string TargetURL { get => (string)TargettedRow[TableColumnNames.TargetURL.ToString()]; }


 #endregion

 #region Methods                                    
                                    
                                                      
        /// <summary>                                                                                           
        /// Returns null on failure                                                                                           
        /// </summary>                                                                                           
        /// <returns></returns>                                                                                           
        /// <remarks></remarks>                                                      
        public T___UserNotification GetFirstRow()                                                      
        {                                                      
            if (this.HasRows())                                                      
                return new (AllRows.First());                                                      
            return null;                                                      
        }                                                      
                                                      
        public static T___UserNotification GetFullTable() => new(DBConnectInterface.GetDBConn());                                    
                                    
        public static T___UserNotification GetRowWhereIDUsingSQL(int pID)                                                      
        {                                                      
            return new T___UserNotification(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", pID, TABLE_NAME)).GetFirstRow();                                                      
        }                                                      
                                                      
        public T___UserNotification GetRowWhereID(int pID) => new(this.RawTable, pID);                                    
                                    
        public Dictionary<string, DataColumnDefinition> GetDefinitions() => ColumnDefns;                           
                          
                  
        public virtual string GetFillSQL() => UserNotification__NO__BINARY___SQL_FILL_QUERY;
                  
                  
        public List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> GetForeignKeys() => ForeignKeys;                  
                  
        public string GetTableName() => TableName;

                  
                  
 #endregion                  
                  
                  




        /// <summary> 
        /// You can not save image with this method 
        /// </summary> 
        /// <returns>Boolean</returns> 
        /// <remarks></remarks> 
        public static bool Add(
            int ID,
            int UserID,
            string Title,
            DateTime CreatedAt,
            string TargetURL,
            string QuickNote = null,
            string Description = null,
            string IconClass = null,
            string HeadingColorClass = null,
            DateTime? ReadAt = null,
            string Identifier = null
          ){

            try{

                DataColumnParameter paramID = new (defID, ID);
                DataColumnParameter paramUserID = new (defUserID, UserID);
                DataColumnParameter paramTitle = new (defTitle, Title);
                DataColumnParameter paramQuickNote = new (defQuickNote, QuickNote);
                DataColumnParameter paramDescription = new (defDescription, Description);
                DataColumnParameter paramIconClass = new (defIconClass, IconClass);
                DataColumnParameter paramHeadingColorClass = new (defHeadingColorClass, HeadingColorClass);
                DataColumnParameter paramCreatedAt = new (defCreatedAt, CreatedAt);
                DataColumnParameter paramReadAt = new (defReadAt, ReadAt);
                DataColumnParameter paramIdentifier = new (defIdentifier, Identifier);
                DataColumnParameter paramTargetURL = new (defTargetURL, TargetURL);


                return DBConnectInterface.GetDBConn().DbExec(
     string.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})  SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,
                        paramID.GetSQLQuotedValueForAdd(),
                        paramUserID.GetSQLQuotedValueForAdd(),
                        paramTitle.GetSQLQuotedValueForAdd(),
                        paramQuickNote.GetSQLQuotedValueForAdd(),
                        paramDescription.GetSQLQuotedValueForAdd(),
                        paramIconClass.GetSQLQuotedValueForAdd(),
                        paramHeadingColorClass.GetSQLQuotedValueForAdd(),
                        paramCreatedAt.GetSQLQuotedValueForAdd(),
                        paramReadAt.GetSQLQuotedValueForAdd(),
                        paramIdentifier.GetSQLQuotedValueForAdd(),
                        paramTargetURL.GetSQLQuotedValueForAdd()                        ) 
                      );


                  
                  
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
