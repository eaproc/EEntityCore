
namespace EEntityCore.DB.Schemas.SQLServerSchema
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