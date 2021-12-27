using System;

namespace EEntityCore.DB.MSSQL.Schemas
{
    public interface IDatabaseInit
    {
        //IDatabaseInit GetDatabaseInit();
        MsSQLDB GetDBConn();
    }
}