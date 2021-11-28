
namespace EEntityCore.DB.MSSQL.Interfaces
{

    /// <summary>
    /// Mainly for pointing to a Specific Server Instance
    /// </summary>
    /// <remarks></remarks>
    public partial interface ISQLServerDBPointer
    {

        /// <summary>
        /// Gets a new instance of SQL Server Connection
        /// </summary>
        /// <returns></returns>
        Server GetDBConn();
    }
}