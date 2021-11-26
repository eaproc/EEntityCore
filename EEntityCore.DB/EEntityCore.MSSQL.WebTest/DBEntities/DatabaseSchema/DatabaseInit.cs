using EEntityCore.DB.Interfaces;
using EEntityCore.DB.MSSQL;
using EEntityCore.DB.Schemas.SQLServerSchema;
using System;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema
{

    /// <summary>
    /// Make sure you initialize this in your app as DatabaseInit.DBConnectInterface = new DatabaseInit(mode). This class only points to your connection. You can override it
    /// DatabaseInit.DBConnectInterface = new DatabaseInit("SalesSCADWARE", "sa", "netEPRO@2017", 51391, @"localhost\SQLSERVER2016");
    /// </summary>
    /// <remarks></remarks>
    public class DatabaseInit : IDatabaseInit
    {

        #region Constructors

        /// <summary>
        /// Just for pointer access
        /// </summary>
        public DatabaseInit()
        {

        }

        /// <summary>
        /// Create Default. NOTE: Server name is not required for FULL_SERVER MODE.
        /// </summary>
        /// <param name="pServerName">with intance name if any like PC\sqlexpress for client modes but for server mode [ Just the SQL Server InstanceName like sqlserver2014 ]</param>
        /// <param name="pDatabaseName">This is very important. the name of the database you are connecting to like [Master]</param>
        /// <param name="pUserName">this is not needed for server mode if server is not allowing clients connection</param>
        /// <param name="pUserPassword">this is not needed for server mode if server is not allowing clients connection</param>
        /// <param name="pPort">this is not needed for server mode if server is not allowing clients connection</param>
        /// <remarks></remarks>
        public DatabaseInit(string pDatabaseName, string pUserName = "", string pUserPassword = "", int pPort = 1433, string pServerName = "")
        {
            ServerName = pServerName;
            UserName = pUserName;
            UserPassword = pUserPassword;
            DatabaseName = pDatabaseName;
            Port = pPort;
        }


        #endregion



        #region Properties

        //private DatabaseSchema.IDatabaseInit Parent;

        /// <summary>
        /// You are responsible for initializing this
        /// </summary>
        /// <remarks></remarks>
        public static DatabaseInit DBConnectInterface;


        private readonly string ServerName;
        private readonly string DatabaseName;
        private readonly string UserName;
        private readonly string UserPassword;
        private readonly int Port;


        #endregion



        #region Methods

        public IDatabaseInit GetDatabaseInit()
        {
            return DBConnectInterface;
        }

        /// <summary>
        /// Returns new connection on each call
        /// </summary>
        /// <returns></returns>
        public Server GetDBConn()
        {
            return (Server)this.GetAllDBConn();
        }

        public IAll__DBs GetAllDBConn()
        {
            return new Client(ServerIPAddressOrName(), ServerPort(), DBUserName(), DBUserPassword(), DBName());
        }

        public string DBName()
        {
            return DatabaseName;
        }

        public string DBUserName()
        {
            return UserName;
        }

        public string DBUserPassword()
        {
            return UserPassword;
        }

        public string ServerIPAddressOrName()
        {
            return ServerName;
        }

        public int ServerPort()
        {
            return Port;
        }




        #endregion


    }
}