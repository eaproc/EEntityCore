
/// <summary>
/// Allows Remote Client to manage tables and Versioning with snapshots
/// </summary>
/// <remarks></remarks>
using System;

namespace EEntityCore.DB.MSSQL
{
    public class ConfigurableClient : Client
    {


        #region Properties




        #endregion




        #region Constructors

        /// <summary>
    /// Initialize Class With Necessary Parameters. It tries to connect immediately on constructor. Allows Remote Client to manage tables and Versioning with snapshots
    /// </summary>
    /// <param name="sAddress">IP or Name of Host PC on Network full instance name. like db.ciu.edu or 192.163.334.222\sqlexpress2014</param>
    /// <param name="sUserName"></param>
    /// <param name="sPassword"></param>
    /// <param name="TargetCurrentDatabaseVersion">The version this database should be in</param>
    /// <remarks></remarks>
        public ConfigurableClient(string sAddress, int sPort, string sUserName, string sPassword, string sDatabase, double TargetCurrentDatabaseVersion = 0.0d, bool pSetSnaphot = true) : base(sAddress, sPort, sUserName, sPassword, sDatabase)
        {
            if (!CanConnect(true))
                throw new Exceptions.SQLServerConnectionException(getConnectionString());
            if (!IsTableCreatedOnDatabase("DBInfo"))
            {
                if (!createVersionTable_on_DB(DatabaseName))
                    throw new Exception("Error Creating DBVersion Table!");
            }

            if (pSetSnaphot)
            {
                if (!setAllowSnapshotOnDatabase(true))
                    throw new Exception("Error setting ALlow_Snapshot On");
            }

            double pCurVersion = FetchDBVersion();
            if (pCurVersion < TargetCurrentDatabaseVersion)
            {
                if (!UpgradeDatabase(TargetCurrentDatabaseVersion, pCurVersion))
                    throw new Exception("Error Upgrading Database");
            }
        }






        #endregion




    }
}