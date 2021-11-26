using System.Collections.Generic;

namespace EEntityCore.DB.Schemas.SQLServerSchema
{
    public interface IDataColumnDefinitionsHolder
    {
        Dictionary<string, DataColumnDefinition> GetDefinitions();
    }
}