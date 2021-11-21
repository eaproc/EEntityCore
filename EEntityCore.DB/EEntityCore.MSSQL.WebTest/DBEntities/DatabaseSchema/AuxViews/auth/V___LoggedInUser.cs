using System;                  
using System.Collections.Generic;                  
using System.Data;                  
using System.Linq;                  
using EEntityCore.DB.Abstracts;                  
using EEntityCore.DB.MSSQL.Interfaces;                  
using ELibrary.Standard.VB.Objects;                  
using ELibrary.Standard.VB.Types;                  
using static EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxViews.auth                  
{                  

    public class V___LoggedInUser : Sample__Table, IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  
    {                  
                  
#region Constructors                  
                  
                  
       static V___LoggedInUser()                  
        {                  
          ColumnDefns = new Dictionary<string, DataColumnDefinition>();                  
          defID = new DataColumnDefinition(TableColumnNames.ID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defUsername = new DataColumnDefinition(TableColumnNames.Username.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPersonID = new DataColumnDefinition(TableColumnNames.PersonID.ToString(), typeof(Int32),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defRememberToken = new DataColumnDefinition(TableColumnNames.RememberToken.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFirstName = new DataColumnDefinition(TableColumnNames.FirstName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defLastName = new DataColumnDefinition(TableColumnNames.LastName.ToString(), typeof(String),false, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifiedMobileNumber = new DataColumnDefinition(TableColumnNames.VerifiedMobileNumber.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defVerifiedEmail = new DataColumnDefinition(TableColumnNames.VerifiedEmail.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defPictureFileName = new DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);
          defFullName = new DataColumnDefinition(TableColumnNames.FullName.ToString(), typeof(String),true, null,DataColumnDefinition.ConstraintTypes.UNKNOWN);


          ColumnDefns.Add(defID.ColumnName, defID); 
          ColumnDefns.Add(defUsername.ColumnName, defUsername); 
          ColumnDefns.Add(defPersonID.ColumnName, defPersonID); 
          ColumnDefns.Add(defRememberToken.ColumnName, defRememberToken); 
          ColumnDefns.Add(defFirstName.ColumnName, defFirstName); 
          ColumnDefns.Add(defLastName.ColumnName, defLastName); 
          ColumnDefns.Add(defVerifiedMobileNumber.ColumnName, defVerifiedMobileNumber); 
          ColumnDefns.Add(defVerifiedEmail.ColumnName, defVerifiedEmail); 
          ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName); 
          ColumnDefns.Add(defFullName.ColumnName, defFullName); 
            ReferencedTableNames = new List<string>();                  
            ReferencedTableNames.Add("auth.Users");                  
            ReferencedTableNames.Add("auth.UserVerifiedContact");                  
            ReferencedTableNames.Add("common.Person");                  

          }


                  
        public V___LoggedInUser() : base(TABLE_NAME)                  
        {                  
        }                  


                  
                  
        #region Full Access                  
                  
        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided                                    
                  
        /// <summary>                                    
        /// FULL ACCESS. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="TableName"></param>                                    
        /// <remarks></remarks>                  
        public V___LoggedInUser(All__DBs DBConn, string TableName) : base(DBConn, TableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                                    
        /// <remarks></remarks>                  
        public V___LoggedInUser(All__DBs DBConn, string pTableName, long pTargettedRowID) : base(DBConn, pTableName, pTargettedRowID: pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public V___LoggedInUser(All__DBs pDBConn, string pTableName, string pSQL) : base(pDBConn, pTableName, pSQL)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Full Access. This will load data with dbconn                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableName"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <param name="pSQL">Load table with your own SQL</param>                                    
        /// <remarks></remarks>                  
        public V___LoggedInUser(All__DBs pDBConn, string pTableName, string pSQL, long pTargettedRowID) : base(pDBConn, pTableName, pSQL, pTargettedRowID)                  
        {                  
        }                  
                  
        #endregion                  
                  
                  
        #region Partial Access                  
                  
        // Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work                                    
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___LoggedInUser(DataRowCollection pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="pDBConn"></param>                                    
        /// <param name="pTableRows"></param>                                    
        /// <param name="pTargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___LoggedInUser(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName, All__DBs pDBConn) : base(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Partial Access                                    
        /// </summary>                                    
        /// <param name="DBConn"></param>                                    
        /// <param name="FullTable"></param>                                    
        /// <param name="TargettedRowID"></param>                                    
        /// <remarks></remarks>                  
        public V___LoggedInUser(DataTable FullTable, int TargettedRowID, string TableName, All__DBs DBConn) : base(FullTable, TargettedRowID, TableName, DBConn)                  
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
        public V___LoggedInUser(DataRow TargettedRow) : base(TargettedRow)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___LoggedInUser(IEnumerable<DataRow> pTableRows) : base(pTableRows)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___LoggedInUser(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___LoggedInUser(IEnumerable<DataRow> pTableRows, long pTargettedRowID, string pTableName) : base(pTableRows, pTargettedRowID, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___LoggedInUser(DataTable FullTable, string pTableName) : base(FullTable, pTableName)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___LoggedInUser(DataTable FullTable, string pTableName, long pTargettedRowID) : base(FullTable, pTableName, pTargettedRowID)                  
        {                  
        }                  
                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <remarks></remarks>                  
        public V___LoggedInUser(DataRowCollection pDataRows, string pTableName) : base(pDataRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access                                    
        /// </summary>                                    
        /// <param name="pTableRows"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___LoggedInUser(IEnumerable<DataRow> pTableRows, string pTableName) : base(pTableRows, pTableName)                  
        {                  
        }                  
                  
        /// <summary>                                    
        /// Shallow Access. Should always target this passed in                                    
        /// </summary>                                    
        /// <param name="pTargettedRow"></param>                                    
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        public V___LoggedInUser(DataRow pTargettedRow, string pTableName) : base(pTargettedRow, pTableName)                  
        {                  
        }                  
                  
                  
        #endregion                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
#endregion                  
                  
                  
                  
#region Consts and Enums                  

       public const string TABLE_NAME = "auth.LoggedInUser";
       public const string LoggedInUser__NO__BINARY___SQL_FILL_QUERY = "SELECT [ID], [Username], [PersonID], [RememberToken], [FirstName], [LastName], [VerifiedMobileNumber], [VerifiedEmail], [PictureFileName], [FullName] FROM LoggedInUser";
       public const string LoggedInUser__ALL_COLUMNS___SQL_FILL_QUERY = "SELECT [ID], [Username], [PersonID], [RememberToken], [FirstName], [LastName], [VerifiedMobileNumber], [VerifiedEmail], [PictureFileName], [FullName] FROM LoggedInUser";


       public enum TableColumnNames
       {

           ID,
           Username,
           PersonID,
           RememberToken,
           FirstName,
           LastName,
           VerifiedMobileNumber,
           VerifiedEmail,
           PictureFileName,
           FullName
       } 


 #endregion 


 #region Properties 

        private static List<string> ReferencedTableNames;                  

       private static Dictionary<string, DataColumnDefinition> ColumnDefns; 

       public static readonly DataColumnDefinition defID;
       public static readonly DataColumnDefinition defUsername;
       public static readonly DataColumnDefinition defPersonID;
       public static readonly DataColumnDefinition defRememberToken;
       public static readonly DataColumnDefinition defFirstName;
       public static readonly DataColumnDefinition defLastName;
       public static readonly DataColumnDefinition defVerifiedMobileNumber;
       public static readonly DataColumnDefinition defVerifiedEmail;
       public static readonly DataColumnDefinition defPictureFileName;
       public static readonly DataColumnDefinition defFullName;

       public String Username {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.Username.ToString()]);
           }
       }


       public Int32 PersonID {
           get{ 
               if (!this.isValidRow) return 0;                          
               return EInt.valueOf(this.TargettedRow[TableColumnNames.PersonID.ToString()]);
           }
       }


       public String RememberToken {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.RememberToken.ToString()]);
           }
       }


       public String FirstName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FirstName.ToString()]);
           }
       }


       public String LastName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.LastName.ToString()]);
           }
       }


       public String VerifiedMobileNumber {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.VerifiedMobileNumber.ToString()]);
           }
       }


       public String VerifiedEmail {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.VerifiedEmail.ToString()]);
           }
       }


       public String PictureFileName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.PictureFileName.ToString()]);
           }
       }


       public String FullName {
           get{ 
               if (!this.isValidRow) return String.Empty;                          
               return EStrings.valueOf(this.TargettedRow[TableColumnNames.FullName.ToString()]);
           }
       }


#endregion

#region Methods                  
                  
                  
                  
        /// <summary>                                                       
        /// Returns Empty class on failure                                                       
        /// </summary>                                                       
        /// <returns></returns>                                                       
        /// <remarks></remarks>                  
        public V___LoggedInUser getFirstRow()                  
        {                  
            if (this.hasRows())                  
                return new V___LoggedInUser(this.AllRows.ToArray()[0]);                  
            return null;                  
        }                  
                  
        public static V___LoggedInUser getFullTable()                  
        {                  
            return new V___LoggedInUser(DatabaseInit.DBConnectInterface.GetDBConn(), TABLE_NAME);                  
        }                  
                  
        public static V___LoggedInUser getRowWhereIDUsingSQL(int pID)                  
        {                  
            return new V___LoggedInUser(DBConnectInterface.GetDBConn(), TABLE_NAME, string.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, (object)pID)).getFirstRow();                  
        }                  
                  
        public V___LoggedInUser getRowWhereID(int pID)                  
        {                  
            return new V___LoggedInUser(this.RawTable, TABLE_NAME, pID);                  
        }                  
                  
        private bool IsAllRowEqual(V___LoggedInUser pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.hasRows())                  
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
                  
        private bool IsAnyRowEqual(V___LoggedInUser pRow, params DataColumnParameter[] pParams)                  
        {                  
            try                  
            {                  
                if (!this.hasRows())                  
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
        public V___LoggedInUser getAllRowsEquals(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAllRowEqual(new V___LoggedInUser(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___LoggedInUser(drst.CopyToDataTable(), TABLE_NAME);                  
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
        public V___LoggedInUser getAllRowsAny(params DataColumnParameter[] pParams)                  
        {                  
            if (pParams is null || pParams.Count() == 0 || !this.hasRows())                  
                return this;                  
            try                  
            {                  
                IEnumerable<DataRow> drst = from dr in this.AllRows                  
                                            where IsAnyRowEqual(new V___LoggedInUser(dr), pParams)                  
                                            select dr;                  
                if (drst is object && drst.Count() > 0)                  
                    return new V___LoggedInUser(drst.CopyToDataTable(), TABLE_NAME);                  
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
                if (!this.isTargettedRowValid())                  
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

                  
    public List<string> getReferencedTableNames()                  
    {                  
        return ReferencedTableNames;                  
    }                  
                  
    public string getViewName()                  
    {                  
        return TABLE_NAME;                  
    }                  

                  
                  
#endregion                  
                  
                  



   }


}
