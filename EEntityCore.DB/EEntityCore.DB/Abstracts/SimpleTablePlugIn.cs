using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using static EEntityCore.DB.Abstracts.All__DBs;
using ELibrary.Standard.VB.Objects;
using Microsoft.VisualBasic;

namespace EEntityCore.DB.Abstracts
{


    /// <summary>
    /// Simple Table with target row capability. Entity Template for Generators
    /// </summary>
    /// <remarks></remarks>
    public abstract class SimpleTablePlugIn
    {

        #region Enums & Consts

        public enum RecordAccessibility
        {
            /// <summary>
            /// Access table with SQL QUERIES and target record. reloadable with DBConn Valid
            /// </summary>
            /// <remarks></remarks>
            FULL_ACCESS,
            /// <summary>
            /// Access table and target record via direct record (DataRow(s)). reloadable if dbConn is valid
            /// </summary>
            /// <remarks></remarks>
            PARTIAL_ACCESS,
            // '' ''' <summary>
            // '' ''' Access table and target record via direcet record. reloadable
            // '' ''' </summary>
            // '' ''' <remarks></remarks>
            // ''PARTIAL_RELOADABLE_ACCESS
            // '' ''' <summary>
            // '' ''' Access table and target record. NOT reloadable [Cached]
            // '' ''' </summary>
            // '' ''' <remarks></remarks>
            // ''PARTIAL_FIXED_ACCESS
            /// <summary>
            /// Access target record only. NOT reloadable. No DBConn
            /// </summary>
            /// <remarks></remarks>
            SHALLOW_ACCESS,

            /// <summary>
            /// Signifies EMPTY UNDECIDED CLASS
            /// </summary>
            /// <remarks></remarks>
            UNKNOWN
        }

        public const int DO__NOT____TARGET__ANY_ROWID = 0;

        #endregion

        #region Contructors

        public SimpleTablePlugIn()
        {
            _OpenAccessFor = RecordAccessibility.UNKNOWN;
        }


        #region Full Access

        // Full Access means initial data is loaded directly from database, so DBConn MUST be provided

        /// <summary>
        /// FULL ACCESS. This will load data with dbconn
        /// </summary>
        /// <param name="DBConn"></param>
        /// <param name="TableName"></param>
        /// <remarks></remarks>
        public SimpleTablePlugIn(All__DBs DBConn) : this(DBConn, DO__NOT____TARGET__ANY_ROWID)
        {
        }

        /// <summary>
        /// Full Access. This will load data with dbconn
        /// </summary>
        /// <param name="DBConn"></param>
        /// <param name="pTableName"></param>
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>
        /// <remarks></remarks>
        public SimpleTablePlugIn(All__DBs DBConn, long pTargettedRowID)
        {
            _OpenAccessFor = RecordAccessibility.FULL_ACCESS;
            _____DbConn = DBConn;

            // REM try load first time
            ReloadClass("SELECT * FROM " + TableName);

            // REM If no error then me.LoadID
            LoadID(pTargettedRowID);
        }

        /// <summary>
        /// Full Access. This will load data with dbconn
        /// </summary>
        /// <param name="pDBConn"></param>
        /// <param name="pTableName"></param>
        /// <param name="pSQL">Load table with your own SQL</param>
        /// <remarks></remarks>
        public SimpleTablePlugIn(All__DBs pDBConn, string pSQL) : this(pDBConn, pSQL, DO__NOT____TARGET__ANY_ROWID)
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
        public SimpleTablePlugIn(All__DBs pDBConn, string pSQL, long pTargettedRowID)
        {
            _OpenAccessFor = RecordAccessibility.FULL_ACCESS;
            _____DbConn = pDBConn;

            // REM try load first time
            ReloadClass(pSQL);

            // REM If no error then me.LoadID
            LoadID(pTargettedRowID);
        }

        #endregion


        #region Partial Access

        // Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work
        // Also can have more than one row
        /// <summary>
        /// Partial Access
        /// </summary>
        /// <param name="pTableRows"></param>
        /// <param name="pTargettedRowID"></param>
        /// <remarks></remarks>
        public SimpleTablePlugIn(DataRowCollection pTableRows, long pTargettedRowID) : this(pTableRows: pTableRows.Cast<DataRow>(), pTargettedRowID: pTargettedRowID)
        {
        }


        /// <summary>
        /// Partial Access
        /// </summary>
        /// <param name="pTableRows"></param>
        /// <param name="pTargettedRowID"></param>
        /// <remarks></remarks>
        public SimpleTablePlugIn(IEnumerable<DataRow> pTableRows) : this(pTableRows, DO__NOT____TARGET__ANY_ROWID)
        {
        }


        /// <summary>
        /// Partial Access
        /// </summary>
        /// <param name="pTableRows"></param>
        /// <param name="pTargettedRowID"></param>
        /// <remarks></remarks>
        public SimpleTablePlugIn(IEnumerable<DataRow> pTableRows, long pTargettedRowID)
        {
            _OpenAccessFor = RecordAccessibility.PARTIAL_ACCESS;
            if (pTableRows is object && pTableRows.Count() > 0)
            {
                try
                {
                    LoadFromRows(pTableRows);
                    if (pTargettedRowID != DO__NOT____TARGET__ANY_ROWID)
                        LoadID(pTargettedRowID);
                }
                catch (Exception ex)
                {
                    Logger.Print("Error Converting from IEnumerable(of datarow) to Table", ex);
                }
            }
        }

        /// <summary>
        /// Partial Access
        /// </summary>
        /// <param name="FullTable"></param>
        /// <param name="pTargettedRowID"></param>
        /// <remarks></remarks>
        public SimpleTablePlugIn(DataTable FullTable, long pTargettedRowID)
        {
            _OpenAccessFor = RecordAccessibility.PARTIAL_ACCESS;

            // Incase there is empty table
            ___RawTable = FullTable;
            if (FullTable is object && FullTable.Rows.Count > 0)
            {
                LoadID(pTargettedRowID);
            }
        }


        #endregion


        #region Shallow Access
        // In the real definition, shallow reference partial. Just that it means partial with no DBConn
        // Shallow is always one row
        /// <summary>
        /// Shallow Access. Should always target this passed in
        /// </summary>
        /// <param name="TargettedRow"></param>
        /// <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>
        public SimpleTablePlugIn(DataRow TargettedRow) : this(new DataRow[] { TargettedRow }, pTargettedRowID: DO__NOT____TARGET__ANY_ROWID)
        {
            _OpenAccessFor = RecordAccessibility.SHALLOW_ACCESS;
            if (HasRows())
                TargettedRow_Cached = AllRows.ElementAtOrDefault(0);
        }

        #endregion



        #endregion

        #region Properties

        /// <summary>
        /// Note: your table must have the column name ID for you to call this
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual long ID
        {
            get
            {
                if (!IsTargettedRowValid)
                    return 0L;
                return ELong.ValueOf(TargettedRow[NumericPrimaryKeyName]);
            }
        }

        public virtual string NumericPrimaryKeyName
        {
            get
            {
                return "ID";
            }
        }

        protected string LastSQL_Passed = string.Empty;

        /// <summary>
        /// Database Connection
        /// </summary>
        /// <remarks></remarks>
        private All__DBs _____DbConn;

        public All__DBs DBConn
        {
            get
            {
                return _____DbConn;
            }
        }

        /// <summary>
        /// Only checks if numeric primary key column name is returned by this class not its physical presence in the current data rows
        /// </summary>
        /// <returns></returns>
        public bool HasNumericPrimaryKeyColumn
        {
            get
            {
                return (EStrings.ValueOf(NumericPrimaryKeyName) ?? "") != (string.Empty ?? "");
            }
        }


        /// <summary>
        /// it is reloadable if db con is valid
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool IsDBConnValid
        {
            get
            {
                return _____DbConn is object;
            }
        }

        public abstract string TableName { get; }
        private DataTable ___RawTable { get; set; }
        /// <summary>
        /// It should always contain data. if there is data at all
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable RawTable
        {
            get
            {
                return ___RawTable;
            }
        }



        /// <summary>
        /// For Full Access and Partial. Only for caching selected row
        /// </summary>
        /// <remarks></remarks>
        private DataRow TargettedRow_Cached = null;

        /// <summary>
        /// Use this always to receive property. TargettedRow_Cached
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual DataRow TargettedRow
        {
            get
            {
                return TargettedRow_Cached;
            }
        }

        private RecordAccessibility _OpenAccessFor;

        public RecordAccessibility OpenAccessFor
        {
            get
            {
                return _OpenAccessFor;
            }
            // Set(ByVal value As RecordAccessibility)
            // Me._OpenAccessFor = value
            // End Set
        }


        /// <summary>
        /// It always returns the enumerated table
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public IEnumerable<DataRow> AllRows
        {
            get
            {
                if (RawTable is null || RawTable.Rows.Count == 0)
                    return null;
                return from d in RawTable.AsEnumerable()
                       select d;
            }
        }

        public int RowCount
        {
            get
            {
                if (HasRows())
                    return AllRows.Count();
                return 0;
            }
        }

        #endregion


        #region Methods


        internal T LoadGeneric<T>(DataRow pDataRow) where T : SimpleTablePlugIn, new()
        {
            LoadFromRows(new DataRow[] { pDataRow });
            if (HasRows())
                TargettedRow_Cached = AllRows.ElementAtOrDefault(0);
            _OpenAccessFor = RecordAccessibility.SHALLOW_ACCESS;
            return (T)this;
        }

        private void LoadFromRows(IEnumerable<DataRow> pTableRows)
        {
            try
            {
                ___RawTable = pTableRows.CopyToDataTable();
            }
            catch (Exception ex)
            {
                Logger.Print("Error Converting Rows to Table", ex);
            }
        }


        /// <summary>
        /// Select from the pool of rows loaded the column with ID=pval
        /// </summary>
        /// <param name="pTargettedRowID"></param>
        /// <remarks></remarks>
        public void LoadID(long pTargettedRowID)
        {
            try
            {
                TargettedRow_Cached = null;
                if (IsTableValid() && pTargettedRowID != DO__NOT____TARGET__ANY_ROWID && HasNumericPrimaryKeyColumn && RawTable.Columns.Contains(NumericPrimaryKeyName))
                {
                    var pMatch = from d in AllRows
                                 where ELong.ValueOf(d[NumericPrimaryKeyName]) == pTargettedRowID
                                 select d;
                    if (pMatch.Count() > 0)
                        TargettedRow_Cached = pMatch.ElementAtOrDefault(0);
                }
            }
            catch (Exception ex)
            {
                Logger.Print("Selecting ID: " + pTargettedRowID, ex);
            }
        }


        /// <summary>
        /// Checks if the Table is valid. In other contains any rows
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        protected virtual bool IsTableValid()
        {
            return HasRows();
        }

        public bool IsTargettedRowValid
        {
            get
            {
                return TargettedRow is object;
            }
        }


        /// <summary>
        /// Use this only if you have valid Connection
        /// </summary>
        /// <remarks></remarks>
        public void ReloadClass_usingLast_Passed_SQL()
        {
            ReloadClass(LastSQL_Passed);
        }


        /// <summary>
        /// Reloads the class with your supplied SQL or else uses SELECT * FROM TABLE. Throws exception. Reloads class and retarget class
        /// </summary>
        /// <param name="SQL">This sql is used to load the class if provided else it will select all from the table</param>
        /// <remarks></remarks>
        public virtual void ReloadClass(string SQL = Constants.vbNullString)
        {
            ___RawTable = null;
            TargettedRow_Cached = null;
            long pLastID = ID;
            if (DBConn is null)
                return;

            DataSet ds;
            if (string.IsNullOrEmpty(SQL) || SQL.Equals(string.Empty))
            {
                ds = DBConn.GetRS("SELECT * FROM " + TableName);
            }
            else
            {
                ds = DBConn.GetRS(SQL);
            }

            if (IsDataSetValid(ds))
            {
                ___RawTable = ds.Tables[0];
            }

            // Retarget if possible
            if (pLastID != DO__NOT____TARGET__ANY_ROWID)
                LoadID(pLastID);
        }

        public virtual bool HasRows()
        {
            if (RawTable is null)
                return false;
            return RawTable.Rows.Count > 0;
        }



        /// <summary>
        /// Deletes a row using an id. *Already functional. if DBConn is valid
        /// </summary>
        /// <param name="pID"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual bool DeleteRow(long pID)
        {
            if (DBConn is null)
                throw new Exception("DbConn was not set for this class. Class Load Status: " + OpenAccessFor.ToString());
            return DeleteRow(pID: pID, pDBConn: DBConn, pTableName: TableName);
        }

        /// <summary>
        /// Deletes a row using an id. *Already functional. Only if dbConn is Available
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual bool DeleteRow()
        {
            return DeleteRow(ID);
        }

        public static bool DeleteRow(All__DBs pDBConn, long pID, string pTableName)
        {
            try
            {
                if (pDBConn is null)
                    throw new Exception("DbConn Is NOT VALID: ");
                return pDBConn.DbExec(string.Format("DELETE FROM {0} WHERE ID={1} ", pTableName, pID)) >= 1;
            }
            catch (Exception )
            {
                throw;
            }

        }


        #endregion






    }
}