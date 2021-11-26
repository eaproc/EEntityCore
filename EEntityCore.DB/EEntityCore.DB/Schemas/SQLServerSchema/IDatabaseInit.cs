using System;

namespace EEntityCore.DB.Schemas.SQLServerSchema
{
    public interface IDatabaseInit: ISQLServerDBCredential, ISQLServerDBPointer
    {
        IDatabaseInit GetDatabaseInit();
    }
}