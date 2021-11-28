// '
// 'Dependencies
// '    dllFunctionsNet.dll


// REM Make PrepareStringForDatabaseInsertOrUpdate Run on all execute on database and executeQuery
// REM With this you dont have to worry about apostrophe



using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CODERiT.Logger.Standard.VB;
using EEntityCore.DB.Interfaces;
using ELibrary.Standard.VB;
using ELibrary.Standard.VB.Objects;
using ELibrary.Standard.VB.Types;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic

// Imports prjLogger

namespace EEntityCore.DB.Abstracts
{

    /// <summary>
    /// This is an abstract class for SQL Compliant Databases
    /// </summary>
    /// <remarks></remarks>
    public abstract partial class All__DBs : IAll__DBs
    {

        // REM There is no point of adding friend since this class will always be inherited
        // REM The good point of adding protected is descendants can just use the variable without adding the class name
        /// <summary>
        /// I make this Public so that user can redirect the logger
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public static Log1 Logger { get; set; } = new Log1(typeof(All__DBs)).Load(Log1.Modes.FILE, true);


        /// <summary>
        /// 0 = Path [C:\], 1= VersionNumber: in Integers [1,2,3,4,5]
        /// </summary>
        /// <remarks>REM   "{0}\DBUpgrades\SQL_Upgrade_{1}.sql"</remarks>
        public const string SQL_UPGRADE_FILES_LOCATION = @"{0}\DBUpgrades\SQL_Upgrade_{1}.sql";

        #region Enums
        /// <summary>
        /// Defines Database ConnectionState
        /// </summary>
        /// <remarks></remarks>
        public enum DBConnectionState
        {
            Disconnected,
            Connected,
            Unknown
        }
        #endregion



        #region Duplicate Entry Controllers


        /// <summary>
        /// Get the next Auto ID for the table provided using the unique column IDHolderColumn
        /// </summary>
        /// <param name="TableName">The name of the table</param>
        /// <param name="IDHolderColumn">A numeric column, preferrable a long</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public long GETNewID(string TableName, string IDHolderColumn = "ID")
        {
            var GenNumber = default(long);
            try
            {
                var dts = GetRS(string.Format("Select {0} From {1} Order By {0} Desc", IDHolderColumn, TableName));
                if (IsDataSetValid(dts))
                {
                    GenNumber = ELong.ValueOf(dts.Tables[0].Rows[0][0].ToString());
                }
            }
            catch (Exception )
            {
            }

            GenNumber += 1L;
            const long MAX_RECORD = 999999999L;
            if (GenNumber > MAX_RECORD)
            {
                Logger.Log("Sorry you have exceed the Maximum Record Capacity " + "Built for this Software" + Constants.vbCrLf + "Therefore, Auto Generate ID can't function!!!");
            }
            else
            {
                return GenNumber;
            }

            return 0L;
        }


        #endregion




        #region Inserting Record

        #endregion



        /// <summary>
        /// Return yes ONLY IF dataset contains any row.
        /// </summary>
        /// <param name="ds">Dataset to evaluate</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool IsDataSetValid(DataSet ds)
        {
            try
            {
                if (!Information.IsNothing(ds))
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }

        /// <summary>
        /// Return yes ONLY IF dataset contains any row.
        /// </summary>
        /// <param name="ds">Dataset to evaluate</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool IsDataSetValid(IEnumerable<DataRow> ds)
        {
            try
            {
                if (!Information.IsNothing(ds))
                {
                    if (ds.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }


        /// <summary>
        /// Checks if two tables are absolutely equal
        /// </summary>
        /// <param name="Table1"></param>
        /// <param name="Table2"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool AreTableEqual(DataTable Table1, DataTable Table2)
        {
            if (Table1 is null | Table2 is null)
                return false;
            if (Table1.Rows.Count > Table2.Rows.Count)
                return false;
            if (Table1.Columns.Count > Table2.Columns.Count)
                return false;
            int index = 0;
            foreach (DataRow dRow in Table1.Rows)
            {
                if (!dRow.ItemArray.SequenceEqual(Table2.Rows[index].ItemArray))
                    return false;
                index += 1;
            }

            return true;
        }

        /// <summary>
        /// Since All SQL has issues with apostrophe(') in a string, we will correct that before inserting or updating
        /// </summary>
        /// <param name="strString">The string to Lock on Apostrophe</param>
        /// <returns></returns>
        /// <remarks>NOTE: Target Should be the string in the parameters not the syntax like a='{0}' should already be done</remarks>
        public static string PrepareStringForDatabaseInsertOrUpdate(string strString)
        {
            return Strings.Replace(strString, "'", "''");
        }


        #region Results Conversions

        public partial struct ConversionDB<T>
        {
            /// <summary>
            /// Returns All the Values in the specified Column as One Dimensional Array
            /// </summary>
            /// <param name="DataSetRows">Rows Contain the values</param>
            /// <returns></returns>
            /// <remarks></remarks>
            public static T[] ConvertColumnValuesToArray(DataRowCollection DataSetRows, short ColIndex = 0)
            {
                try
                {
                    var Col = new T[DataSetRows.Count];
                    short IncreamentCount = 0;
                    foreach (DataRow dRow in DataSetRows)
                    {
                        Col[IncreamentCount] = (T)dRow[ColIndex];
                        IncreamentCount += 1;
                    }

                    return Col;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Convert a whole column to String
        /// </summary>
        /// <param name="DataSetRows"></param>
        /// <param name="ColIndex"></param>
        /// <param name="Delimiter"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string ConvertColumnValuesToString(DataRowCollection DataSetRows, short ColIndex = 0, string Delimiter = ",")
        {
            try
            {
                string result = Constants.vbNullString;
                foreach (DataRow dRow in DataSetRows)
                {
                    result += EStrings.ValueOf(dRow[ColIndex]);
                    if (DataSetRows.IndexOf(dRow) != DataSetRows.Count - 1)
                        result += Delimiter;
                }

                return result;
            }
            catch (Exception )
            {
                return Constants.vbNullString;
            }
        }

        #endregion



        #region Saving Date And Time [General]


        /// <summary>
        /// Gets A Formatted DateTime... NB: It is already packed like '{0}'
        /// </summary>
        /// <param name="_DateTime"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public abstract string GetSQLDateTimeFormat(NullableDateTime _DateTime);



        /// <summary>
        /// Returns Date Format [07/22/2013]. NB: It is already packed like '{0}'
        /// </summary>
        /// <param name="_Date"></param>
        /// <returns></returns>
        /// <remarks>NB: It is already packed</remarks>
        public abstract string GetSQLDateFormat(NullableDateTime _Date);

        /// <summary>
        /// Returns Time Format [01:45:58 AM]. NB: It is already packed like '{0}'
        /// </summary>
        /// <param name="_Time"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public abstract string GetSQLTimeFormat(NullableDateTime _Time);


        #endregion


        #region Saving Image to Database



        #endregion


        #region Test DB


        /// <summary>
        /// Test if DB is ok. Must always be silent check or default if no silent.
        /// </summary>
        /// <remarks></remarks>
        public abstract bool PingDB();
        // ''We dont need the result
        // ''basTestMYSQLServerConnection.getRS("Select * From Customers")

        // 'End Sub

        /// <summary>
        /// Indicate if Connection will be successful using the current parameters
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public abstract bool CanConnect();


        #endregion


        /// <summary>
        /// Executes an SQL File containing SQL Statements
        /// </summary>
        /// <param name="SQLFileName">SQL File containing SQL Statements</param>
        /// <param name="TerminateOnError">If One Statement in the file yields error. The process will break if set to true</param>
        /// <param name="StatementDelimiter">The delimiter use to identify the end of each sql statement. not case sensitive</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public abstract bool ExecuteSQLFile(string SQLFileName, bool TerminateOnError = false, string StatementDelimiter = "GO;");

        /// <summary>
        /// execute()
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public abstract int DbExec(string SQL);

        /// <summary>
        /// Makes sure the apostrophe issue is corrected in the strings. 
        /// NB: For your original SQL Query you should use \' for apostrophe
        /// </summary>
        /// <param name="SQL">Name=\'Fred's Computer\'</param>
        /// <param name="Address_Apostrophe_Issue">Confirmed this is encoded SQL String</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual int DbExec(string SQL, bool Address_Apostrophe_Issue)
        {
            if (!Address_Apostrophe_Issue)
                return DbExec(SQL);
            SQL = GetHandledSQLApostrophe__Issue(SQL);
            return DbExec(SQL);
        }


        /// <summary>
        /// If you used this [  "\'" ] in your SQL statement. it will help you address the ' to double and return back the SQL ready for insert
        /// </summary>
        /// <param name="pSQL"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string GetHandledSQLApostrophe__Issue(string pSQL)
        {
            pSQL = Strings.Replace(pSQL, @"\'", "[*===*]"); // REM Keep Original Apostrophe Encoded
            pSQL = PrepareStringForDatabaseInsertOrUpdate(pSQL);
            pSQL = Strings.Replace(pSQL, "[*===*]", "'");  // REM Return Original Apostrophe Encoded
            return pSQL;
        }


        /// <summary>
        /// executeQuery()
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public abstract DataSet GetRS(string SQL);


        /// <summary>
        /// Makes sure the apostrophe issue is corrected in the strings. 
        /// NB: For your original SQL Query you should use \' for apostrophe
        /// </summary>
        /// <param name="SQL">Name=\'Fred's Computer\'</param>
        /// <param name="Address_Apostrophe_Issue">Confirmed this is encoded SQL String</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataSet getRS(string SQL, bool Address_Apostrophe_Issue)
        {
            if (!Address_Apostrophe_Issue)
                return GetRS(SQL);
            SQL = Strings.Replace(SQL, @"\'", "[*===*]"); // REM Keep Original Apostrophe Encoded
            SQL = PrepareStringForDatabaseInsertOrUpdate(SQL);
            SQL = Strings.Replace(SQL, "[*===*]", "'");  // REM Return Original Apostrophe Encoded
            return GetRS(SQL);
        }


        #region Filling Datasets and DataTables


        /// <summary>
        /// Fill All Data For Table
        /// </summary>
        /// <param name="OneTable"></param>
        /// <remarks></remarks>
        public abstract bool FillMyTable(ref DataTable OneTable);


        /// <summary>
        /// Fill All Data For Table
        /// </summary>
        /// <param name="OneTable"></param>
        /// <remarks></remarks>
        public abstract bool FillMyTable(string SQL, ref DataTable OneTable);



        /// <summary>
        /// Fill All Data For Tables in this Hard-Coded dataset
        /// </summary>
        /// <param name="MyDataSet"></param>
        /// <remarks></remarks>
        public abstract bool FillMyTables(ref DataSet MyDataSet);


        #endregion


        #region Connection State



        // ' ''' <summary>
        // ' ''' This is set by thread keep tracking.. Works only if you use keep tracking method
        // ' ''' </summary>
        // ' ''' <value></value>
        // ' ''' <returns></returns>
        // ' ''' <remarks></remarks>
        // 'Public MustOverride ReadOnly Property Threaded_ConnectionState As DBConnectionState


        // ' ''' <summary>
        // ' ''' This is set everytime the getConnection Method is called
        // ' ''' </summary>
        // ' ''' <value></value>
        // ' ''' <returns></returns>
        // ' ''' <remarks></remarks>
        // 'Public MustOverride ReadOnly Property NoThread_ConnectionState As DBConnectionState


        #endregion



    }
}