using ELibrary.Standard.VB.Types;
using System.Data;

namespace EEntityCore.DB.Interfaces
{

    /// <summary>
    /// Indicates the DB can perform basic database operations
    /// </summary>
    public interface IAll__DBs
    {

        // Make saving date and time an interface and saving binaries

        /// <summary>
        /// Test if DB is ok [Using Default/No Parameters]
        /// </summary>
        /// <remarks></remarks>
        bool PingDB();


        /// <summary>
        /// Indicate if Connection will be successful using the current parameters
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        bool CanConnect();


        /// <summary>
        /// execute()
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        int DbExec(string SQL);


        /// <summary>
        /// executeQuery()
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        DataSet GetRS(string SQL);




        /// <summary>
        /// Executes an SQL File containing SQL Statements
        /// </summary>
        /// <param name="SQLFileName">SQL File containing SQL Statements</param>
        /// <param name="TerminateOnError">If One Statement in the file yields error. The process will break if set to true</param>
        /// <param name="StatementDelimiter">The delimiter use to identify the end of each sql statement. not case sensitive</param>
        /// <returns></returns>
        /// <remarks></remarks>
        bool ExecuteSQLFile(string SQLFileName, bool TerminateOnError = false, string StatementDelimiter = "GO;");

        string GetSQLDateTimeFormat(NullableDateTime _DateTime);
    }
}