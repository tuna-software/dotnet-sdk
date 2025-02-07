using System.Net;

namespace Tuna.Client;

public class Connection : IDisposable
{
    internal static Connection SingletonConnection = new Connection(); 
    
    internal HttpClient Http;

    private bool _disposed = false;

    public Connection(ConnectionConfiguration? Configuration = null)
    {
        Configuration ??= new ConnectionConfiguration();

        //TODO: Improve configuration, receive as options + keep alive
        var httpClientHandler = new SocketsHttpHandler
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            MaxConnectionsPerServer = 1024,
            PooledConnectionLifetime = TimeSpan.FromMinutes(5),
            ConnectTimeout = TimeSpan.FromSeconds(15)
        };

        if (Configuration.WebProxy != null)
        {
            httpClientHandler.UseProxy = true;
            httpClientHandler.Proxy = Configuration.WebProxy;
        }

        Http = new HttpClient(httpClientHandler, false);
        Http.Timeout = Configuration.Timeout;
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        Http.Dispose();
        _disposed = true;
    }
}
