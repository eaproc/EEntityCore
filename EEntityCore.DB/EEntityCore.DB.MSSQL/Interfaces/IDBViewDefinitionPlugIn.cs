using System.Collections.Generic;

namespace EEntityCore.DB.MSSQL.Interfaces
{
    public interface IDBViewDefinitionPlugIn
    {


        /// <summary>
        /// Return the names of tables this view depend on
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        List<string> GetReferencedTableNames();
        string GetViewName();
        string GetFillSQL();
    }
}