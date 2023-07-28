using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace EEntityCore.DB.MSSQL.Exceptions
{
    /// <summary>
    /// Just convert immediate class into message
    /// </summary>
    public class QueryException<T> : Exception where T : Exception, ISerializableException
    {
        public QueryException(T serializable) : base(message: JsonSerializer.Serialize((object)serializable.ToDynamicClass(), new JsonSerializerOptions() { WriteIndented = true }), innerException: serializable)
        {}
    }
}