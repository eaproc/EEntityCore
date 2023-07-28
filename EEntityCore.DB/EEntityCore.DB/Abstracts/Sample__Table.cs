using System;
using System.Collections.Generic;
using System.Data;

namespace EEntityCore.DB.Abstracts
{


    /// <summary>
    /// Copy this Template and adjust as you want. You can remove some of the constructors or add to it
    /// </summary>
    /// <remarks></remarks>
    public class Sample__Table : SimpleTablePlugIn
    {



        #region Constructors

        /// <summary>
        /// UNKNOWN ACCESS
        /// </summary>
        /// <param name="TableName"></param>
        /// <remarks></remarks>
        public Sample__Table() : base()
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
        public Sample__Table(All__DBs DBConn) : base(DBConn)
        {
        }

        /// <summary>
        /// Full Access. This will load data with dbconn
        /// </summary>
        /// <param name="DBConn"></param>
        /// <param name="pTableName"></param>
        /// <param name="pTargettedRowID">Only works if the table contains a column named ID</param>
        /// <remarks></remarks>
        public Sample__Table(All__DBs DBConn, long pTargettedRowID) : base(DBConn, pTargettedRowID: pTargettedRowID)
        {
        }

        /// <summary>
        /// Full Access. This will load data with dbconn
        /// </summary>
        /// <param name="pDBConn"></param>
        /// <param name="pTableName"></param>
        /// <param name="pSQL">Load table with your own SQL</param>
        /// <remarks></remarks>
        public Sample__Table(All__DBs pDBConn, string pSQL) : base(pDBConn, pSQL)
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
        public Sample__Table(All__DBs pDBConn, string pSQL, long pTargettedRowID) : base(pDBConn, pSQL, pTargettedRowID)
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
        public Sample__Table(DataRowCollection pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)
        {
        }

        /// <summary>
        /// Partial Access
        /// </summary>
        /// <param name="pTableRows"></param>
        /// <param name="pTargettedRowID"></param>
        /// <remarks></remarks>
        public Sample__Table(IEnumerable<DataRow> pTableRows) : base(pTableRows, DO__NOTEap_TARGET__ANY_ROWID)
        {
        }

        /// <summary>
        /// Partial Access
        /// </summary>
        /// <param name="pTableRows"></param>
        /// <param name="pTargettedRowID"></param>
        /// <remarks></remarks>
        public Sample__Table(IEnumerable<DataRow> pTableRows, long pTargettedRowID) : base(pTableRows, pTargettedRowID)
        {
        }

        /// <summary>
        /// Partial Access
        /// </summary>
        /// <param name="DBConn"></param>
        /// <param name="FullTable"></param>
        /// <param name="TargettedRowID"></param>
        /// <remarks></remarks>
        public Sample__Table(DataTable FullTable, long pTargettedRowID) : base(FullTable, pTargettedRowID)
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
        public Sample__Table(DataRow TargettedRow) : base(TargettedRow)
        {
        }

        #endregion


        #endregion



        #region Properties


        public override string TableName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion



        #region Methods

        public static bool DeleteRow(All__DBs pDBConn, long pID)
        {
            return DeleteRow(pDBConn, pID, pTableName: "SampleTable");
        }

        #endregion



    }
}