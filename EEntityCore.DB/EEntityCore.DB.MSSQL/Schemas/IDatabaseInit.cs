using System;

namespace EEntityCore.DB.MSSQL.Schemas
{
    public interface IDatabaseInit: ISQLServerDBCredential
    {
        IDatabaseInit GetDatabaseInit();
        MsSQLDB GetDBConn();
    }
}