
namespace EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema
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