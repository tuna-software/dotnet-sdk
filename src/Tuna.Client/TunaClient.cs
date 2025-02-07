namespace Tuna.Client;
/// <summary>
/// Main integration class
/// </summary>
public class TunaClient
{
    private readonly ClientConnection _connection;

    /// <summary>
    /// TunaClient constructor
    /// </summary>
    /// <param name="account">Account id ex: foo-bar</param>
    /// <param name="appToken">Account app token (normaly a guid)</param>
    /// <param name="config">Optional configuration</param>
    public TunaClient(string account, string appToken, TunaClientConfiguration? config = null)
    {
        config ??= new TunaClientConfiguration();

        var credentials = new Credentials() { Account = account, AppToken = appToken };

        _connection = new ClientConnection(
                credentials,
                config.Connection ?? Connection.SingletonConnection,
                config.HttpRequestMessageFactory
        );

        Payments = new Payments(_connection);

    }


    public Payments Payments { get; internal set; }

}