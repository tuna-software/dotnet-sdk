namespace Tuna.Client;

public class TunaClient
{
    private readonly ClientConnection _connection;


    public TunaClient(string Account, string AppToken, TunaClientConfiguration? config = null)
    {
        config ??= new TunaClientConfiguration();

        var credentials = new Credentials() { Account = Account, AppToken = AppToken };

        _connection = new ClientConnection(
                credentials,
                config.Connection ?? Connection.SingletonConnection,
                config.HttpRequestMessageFactory
        );

        Payments = new Payments(_connection);

    }


    public Payments Payments { get; internal set; }

}