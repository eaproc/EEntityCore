
using EEntityCore.DB.Interfaces;

namespace EEntityCore.DB.Schemas.SQLServerSchema
{

    /// <summary>
    /// Mainly for pointing to a Specific Server Instance
    /// </summary>
    /// <remarks></remarks>
    public interface ISQLServerDBPointer
    {

        /// <summary>
        /// Gets a new instance of SQL Server Connection
        /// </summary>
        /// <returns></returns>
        IAll__DBs GetAllDBConn();
    }
}