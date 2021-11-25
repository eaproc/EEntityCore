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

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.auth                  
{                  

    public class T___UserNotification : SimpleTablePlugIn, IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static T___UserNotification()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.PRIMARY);
          defUserID = new DataColumnDefinition(TableColumnNames.UserID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.FOREIGN);
          defTitle = new DataColumnDefinition(TableColumnNames.Title.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defQuickNote = new DataColumnDefinition(TableColumnNames.QuickNote.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defDescription = new DataColumnDefinition(TableColumnNames.Description.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIconClass = new DataColumnDefinition(TableColumnNames.IconClass.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defHeadingColorClass = new DataColumnDefinition(TableColumnNames.HeadingColorClass.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defCreatedAt = new DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), typeof(DateTime),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defReadAt = new DataColumnDefinition(TableColumnNames.ReadAt.ToString(), typeof(DateTime),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defIdentifier = new DataColumnDefinition(TableColumnNames.Identifier.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defTargetURL = new DataColumnDefinition(TableColumnNames.TargetURL.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


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

       private static List<IDBTableDefinitionPlugIn.ForeignKeyDefinition> ForeignKeys;                  

       public override string TableName => TABLE_NAME;
       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

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

       public Int32 UserID {
           get{ 
               if (!this.IsTargettedRowValid) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.UserID.ToString()]);
           }
       }


       public String Title {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Title.ToString()]);
           }
       }


       public String QuickNote {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.QuickNote.ToString()]);
           }
       }


       public String Description {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Description.ToString()]);
           }
       }


       public String IconClass {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.IconClass.ToString()]);
           }
       }


       public String HeadingColorClass {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.HeadingColorClass.ToString()]);
           }
       }


       public NullableDateTime CreatedAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.CreatedAt.ToString()]);
           }
       }


       public NullableDateTime ReadAt {
           get{ 
               if (!this.IsTargettedRowValid) return NullableDateTime.NULL_TIME;                          
               return  new NullableDateTime(this.TargettedRow[TableColumnNames.ReadAt.ToString()]);
           }
       }


       public String Identifier {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Identifier.ToString()]);
           }
       }


       public String TargetURL {
           get{ 
               if (!this.IsTargettedRowValid) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.TargetURL.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public T___UserNotification GetFirstRow()                  
        {                  
            if (this.HasRows())                  
                return new T___UserNotification(this.AllRows.First());                  
            return null;                  
        }                  
                  
        public static T___UserNotification GetFullTable()                  
        {                  
            return new T___UserNotification(DBConnectInterface.GetDBConn());                  
        }                  
                  
        public static T___UserNotification GetRowWhereIDUsingSQL(int pID)                  
        {                  
            return new T___UserNotification(DBConnectInterface.GetDBConn(), string.Format("SELECT * FROM {0} WHERE ID={1}", (object)pID)).GetFirstRow();                  
        }                  
                  
        public T___UserNotification GetRowWhereID(int pID)                  
        {                  
            return new T___UserNotification(this.RawTable, pID);                  
        }                  
                  
        private bool IsAllRowEqual(T___UserNotification pRow, params DataColumnParameter[] pParams)                  
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
                  
        private bool IsAnyRowEqual(T___UserNotification pRow, params DataColumnParameter[] pParams)                  
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
        public T___UserNotification GetAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new T___UserNotification(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___UserNotification(drst);                  
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
        public T___UserNotification getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.HasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new T___UserNotification(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new T___UserNotification(drst);                  
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

                  
        public virtual string GetFillSQL() => UserNotification__NO__BINARY___SQL_FILL_QUERY;
                  
                  
                  
#endregion                  
                  
                  




        public static int AddNewDefault(Int32 pUserID){

            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramTitle = new DataColumnParameter(defTitle, defTitle.DefaultValue);
                DataColumnParameter paramQuickNote = new DataColumnParameter(defQuickNote, defQuickNote.DefaultValue);
                DataColumnParameter paramDescription = new DataColumnParameter(defDescription, defDescription.DefaultValue);
                DataColumnParameter paramIconClass = new DataColumnParameter(defIconClass, defIconClass.DefaultValue);
                DataColumnParameter paramHeadingColorClass = new DataColumnParameter(defHeadingColorClass, defHeadingColorClass.DefaultValue);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue);
                DataColumnParameter paramReadAt = new DataColumnParameter(defReadAt, defReadAt.DefaultValue);
                DataColumnParameter paramIdentifier = new DataColumnParameter(defIdentifier, defIdentifier.DefaultValue);
                DataColumnParameter paramTargetURL = new DataColumnParameter(defTargetURL, defTargetURL.DefaultValue);


                DBConnectInterface.GetDBConn().DbExec(
                     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,                paramID.getSQLQuotedValueForAdd(),
                paramUserID.getSQLQuotedValueForAdd(),
                paramTitle.getSQLQuotedValueForAdd(),
                paramQuickNote.getSQLQuotedValueForAdd(),
                paramDescription.getSQLQuotedValueForAdd(),
                paramIconClass.getSQLQuotedValueForAdd(),
                paramHeadingColorClass.getSQLQuotedValueForAdd(),
                paramCreatedAt.getSQLQuotedValueForAdd(),
                paramReadAt.getSQLQuotedValueForAdd(),
                paramIdentifier.getSQLQuotedValueForAdd(),
                paramTargetURL.getSQLQuotedValueForAdd()  ), true);




                  
                return EInt.valueOf(paramID.Value);                   
            }catch (Exception){                   
                throw;                   
            }                   
        }                   


        public static int AddWithID(Int32 pUserID,
String pTitle,
DateTime pCreatedAt,
String pTargetURL,
Object pQuickNote = null,
Object pDescription = null,
Object pIconClass = null,
Object pHeadingColorClass = null,
Object pReadAt = null,
Object pIdentifier = null){


            try{

                DataColumnParameter paramID = new DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME));
                DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
                DataColumnParameter paramTitle = new DataColumnParameter(defTitle, pTitle);
                DataColumnParameter paramQuickNote = new DataColumnParameter(defQuickNote, pQuickNote);
                DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
                DataColumnParameter paramIconClass = new DataColumnParameter(defIconClass, pIconClass);
                DataColumnParameter paramHeadingColorClass = new DataColumnParameter(defHeadingColorClass, pHeadingColorClass);
                DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
                DataColumnParameter paramReadAt = new DataColumnParameter(defReadAt, pReadAt);
                DataColumnParameter paramIdentifier = new DataColumnParameter(defIdentifier, pIdentifier);
                DataColumnParameter paramTargetURL = new DataColumnParameter(defTargetURL, pTargetURL);


                DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramQuickNote.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramIconClass.getSQLQuotedValueForAdd(),
paramHeadingColorClass.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramReadAt.getSQLQuotedValueForAdd(),
paramIdentifier.getSQLQuotedValueForAdd(),
paramTargetURL.getSQLQuotedValueForAdd()  ), true);




                return EInt.valueOf(paramID.Value);                                     
            }catch (Exception){                                     
                throw;                                     
            }                         
       }                         


        public static int  AddWithParseID(Int32 pParseID ,Int32 pUserID,
String pTitle,
DateTime pCreatedAt,
String pTargetURL,
Object pQuickNote = null,
Object pDescription = null,
Object pIconClass = null,
Object pHeadingColorClass = null,
Object pReadAt = null,
Object pIdentifier = null){

        try{

 DataColumnParameter paramID = new DataColumnParameter(defID, pParseID );
DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramTitle = new DataColumnParameter(defTitle, pTitle);
DataColumnParameter paramQuickNote = new DataColumnParameter(defQuickNote, pQuickNote);
DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
DataColumnParameter paramIconClass = new DataColumnParameter(defIconClass, pIconClass);
DataColumnParameter paramHeadingColorClass = new DataColumnParameter(defHeadingColorClass, pHeadingColorClass);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramReadAt = new DataColumnParameter(defReadAt, pReadAt);
DataColumnParameter paramIdentifier = new DataColumnParameter(defIdentifier, pIdentifier);
DataColumnParameter paramTargetURL = new DataColumnParameter(defTargetURL, pTargetURL);


DBConnectInterface.GetDBConn().DbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramQuickNote.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramIconClass.getSQLQuotedValueForAdd(),
paramHeadingColorClass.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramReadAt.getSQLQuotedValueForAdd(),
paramIdentifier.getSQLQuotedValueForAdd(),
paramTargetURL.getSQLQuotedValueForAdd()  ), true);




            return EInt.valueOf(paramID.Value); 

}catch (Exception){
throw; 
}
}



/// <summary> 
/// You can not save image with this method 
/// </summary> 
/// <returns>Boolean</returns> /// <remarks></remarks> 
        public static bool Add(Int32 pUserID,
String pTitle,
DateTime pCreatedAt,
String pTargetURL,
Object pQuickNote= null,
Object pDescription= null,
Object pIconClass= null,
Object pHeadingColorClass= null,
Object pReadAt= null,
Object pIdentifier= null){

        try{

DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
DataColumnParameter paramTitle = new DataColumnParameter(defTitle, pTitle);
DataColumnParameter paramQuickNote = new DataColumnParameter(defQuickNote, pQuickNote);
DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
DataColumnParameter paramIconClass = new DataColumnParameter(defIconClass, pIconClass);
DataColumnParameter paramHeadingColorClass = new DataColumnParameter(defHeadingColorClass, pHeadingColorClass);
DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
DataColumnParameter paramReadAt = new DataColumnParameter(defReadAt, pReadAt);
DataColumnParameter paramIdentifier = new DataColumnParameter(defIdentifier, pIdentifier);
DataColumnParameter paramTargetURL = new DataColumnParameter(defTargetURL, pTargetURL);


return DBConnectInterface.GetDBConn().DbExec(
     String.Format("INSERT INTO {0}([UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramUserID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramQuickNote.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramIconClass.getSQLQuotedValueForAdd(),
paramHeadingColorClass.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramReadAt.getSQLQuotedValueForAdd(),
paramIdentifier.getSQLQuotedValueForAdd(),
paramTargetURL.getSQLQuotedValueForAdd()  ), true);


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
Object pUserID = null,
Object pTitle = null,
Object pCreatedAt = null,
Object pTargetURL = null,
Object pQuickNote = null,
Object pDescription = null,
Object pIconClass = null,
Object pHeadingColorClass = null,
Object pReadAt = null,
Object pIdentifier = null){

try{


 DataColumnParameter paramID = new DataColumnParameter(defID, pID);
 DataColumnParameter paramUserID = new DataColumnParameter(defUserID, pUserID);
 DataColumnParameter paramTitle = new DataColumnParameter(defTitle, pTitle);
 DataColumnParameter paramQuickNote = new DataColumnParameter(defQuickNote, pQuickNote);
 DataColumnParameter paramDescription = new DataColumnParameter(defDescription, pDescription);
 DataColumnParameter paramIconClass = new DataColumnParameter(defIconClass, pIconClass);
 DataColumnParameter paramHeadingColorClass = new DataColumnParameter(defHeadingColorClass, pHeadingColorClass);
 DataColumnParameter paramCreatedAt = new DataColumnParameter(defCreatedAt, pCreatedAt);
 DataColumnParameter paramReadAt = new DataColumnParameter(defReadAt, pReadAt);
 DataColumnParameter paramIdentifier = new DataColumnParameter(defIdentifier, pIdentifier);
 DataColumnParameter paramTargetURL = new DataColumnParameter(defTargetURL, pTargetURL);


DBConnectInterface.GetDBConn().DbExec(
     String.Format("UPDATE {0} SET [UserID]={2},[Title]={3},[QuickNote]={4},[Description]={5},[IconClass]={6},[HeadingColorClass]={7},[CreatedAt]={8},[ReadAt]={9},[Identifier]={10},[TargetURL]={11} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramUserID.getSQLQuotedValueForUpdate(),
paramTitle.getSQLQuotedValueForUpdate(),
paramQuickNote.getSQLQuotedValueForUpdate(),
paramDescription.getSQLQuotedValueForUpdate(),
paramIconClass.getSQLQuotedValueForUpdate(),
paramHeadingColorClass.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramReadAt.getSQLQuotedValueForUpdate(),
paramIdentifier.getSQLQuotedValueForUpdate(),
paramTargetURL.getSQLQuotedValueForUpdate()  ), true);


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
