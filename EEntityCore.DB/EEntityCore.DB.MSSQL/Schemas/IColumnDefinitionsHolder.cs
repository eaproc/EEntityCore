using System.Collections.Generic;

namespace EEntityCore.DB.MSSQL.Schemas
{
    public interface IDataColumnDefinitionsHolder
    {
        Dictionary<string, DataColumnDefinition> GetDefinitions();
    }
}