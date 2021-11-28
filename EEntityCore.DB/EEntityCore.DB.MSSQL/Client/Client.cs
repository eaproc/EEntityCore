using System;
using EEntityCore.DB.MSSQL.Exceptions;

namespace EEntityCore.DB.MSSQL
{

    /// <summary>
/// Advances SQL Server Local To Network Opearations
/// </summary>
/// <remarks></remarks>
    public class Client : Server
    {


        // REM there are some function available in Client that shouldnt be

        #region Properties



        public string GetConnectionString()
        {
            return string.Format("Data Source={0},{1};Integrated Security=False;Initial Catalog={2};TrustServerCertificate=True;User ID={3};Password={4};", 
                SQLServerAddress, SQLServerPort, CurrentDBInUse, SQLServerUserName, SQLServerPassword);
        }


        #endregion

        #region Constructors

        /// <summary>
    /// Initialize Class With Necessary Parameters. It tries to connect immediately on constructor
    /// </summary>
    /// <param name="sAddress">IP or Name of Host PC on Network full instance name. like db.ciu.edu or 192.163.334.222\sqlexpress2014</param>
    /// <param name="sUserName"></param>
    /// <param name="sPassword"></param>
    /// <remarks></remarks>
        public Client(string sAddress, int sPort, string sUserName, string sPassword, string sDatabase) : base(sDatabase)
        {
            __SQLServerAddress = sAddress;
            __SQLServerUserName = sUserName;
            __SQLServerPassword = sPassword;
            __SQLServerPort = sPort;
        }






        #endregion



        /// <summary>
    /// Using SQL Default Path 
    /// </summary>
    /// <returns></returns>
    /// <remarks></remarks>
        public override Microsoft.Data.SqlClient.SqlConnection GetSQLConnection()
        {
            Microsoft.Data.SqlClient.SqlConnection sCon;
            try
            {
                // 'sCon = New SqlClient.SqlConnection(
                // '    "Data Source=" & svrServer & ";Initial Catalog=" & dbName &
                // '    ";Integrated Security=True;User ID=" & strUser & ";Password=" & strPassword)


                sCon = new Microsoft.Data.SqlClient.SqlConnection(GetConnectionString());
                sCon.Open();
            }

            // sCon.Close()

            catch (Exception ex)
            {
                throw new SQLServerConnectionException("Error Connecting to MS SQL Server From Client", GetConnectionString(), ex);
            }

            return sCon;
        }



    //    /// <summary>
    ///// Get my base instance
    ///// </summary>
    ///// <returns></returns>
    ///// <remarks></remarks>
    //    public Server getBase()
    //    {

    //        // REM I don't know if this is going to work for this kind of instance because the base needs
    //        // REM to refer to getConnection of this class
    //        return getClass();
    //    }

        public override bool ExecuteSQLFile(string SQLFileName, bool TerminateOnError = false, string StatementDelimiter = "GO;")
        {
            throw new NotImplementedException();
        }
    }
}