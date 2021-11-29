
namespace EEntityCore.DB.MSSQL.Schemas
{
    public interface ISQLServerDBCredential
    {
        int ServerPort();
        string ServerIPAddressOrName();
        string DBUserPassword();
        string DBUserName();
        string DBName();
    }
}