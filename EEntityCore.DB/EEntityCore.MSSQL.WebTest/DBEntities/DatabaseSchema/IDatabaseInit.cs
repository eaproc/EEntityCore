using EEntityCore.DB.MSSQL;
using EEntityCore.DB.MSSQL.Interfaces;
using System;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema
{
    public interface IDatabaseInit: ISQLServerDBPointer, ISQLServerDBCredential
    {
    }
}