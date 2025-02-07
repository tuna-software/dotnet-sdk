
namespace Tuna.Client;

internal class ClientConnection
{
    public static string TUNA_ADDRESS = "https://engine.tunagateway.com/api/";

    public Connection Connection { get; set; }

    public Credentials Credentials { get; set; }

    public HttpRequestMessageFactory MessageFactory { get; set; }

    public ClientConnection(Credentials credentials, Connection connection, HttpRequestMessageFactory messageFactory)
    {
        Connection = connection;
        Credentials = credentials;
        MessageFactory = messageFactory;
    }
}