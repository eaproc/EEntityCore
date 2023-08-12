namespace EEntityCore.DB.MSSQL
{
    public struct QueryTimeReport
    {
        public QueryTimeReport (string sql, bool succeeded = true, long elapsedMilliseconds = 0, string connectionString = null)
        {
            SQL = sql;
            Succeeded = succeeded;
            ElapsedMilliseconds = elapsedMilliseconds;
            ConnectionString = connectionString;
        }

        public long ElapsedMilliseconds;
        public string SQL;
        public string ConnectionString;
        public bool Succeeded;

        public override string ToString()
        {
            return $"SQL:\t\t {SQL}\n" +
                $"Connection:\t {ConnectionString}\n" +
                $"Time (ms):\t {ElapsedMilliseconds}\n" +
                $"Succeeded:\t {Succeeded}";
        }
    }
}
