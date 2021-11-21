using System.Collections.Generic;

namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema
{
    public interface IDataColumnDefinitionsHolder
    {
        Dictionary<string, DatabaseSchema.DataColumnDefinition> getDefinitions();
    }
}