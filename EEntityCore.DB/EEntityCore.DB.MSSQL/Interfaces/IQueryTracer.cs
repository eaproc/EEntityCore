namespace EEntityCore.DB.MSSQL.Interfaces
{
    public interface IQueryTracer
    {
        void TraceSqlQuery(params QueryTimeReport[] timeReports);
    }
}
