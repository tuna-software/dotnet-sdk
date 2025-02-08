using System.Net;

namespace Tuna.Client;

/// <summary>
/// Wrapper arround HttpClient
/// Allows fine tuning http processing stack
/// </summary>
public class Connection : IDisposable
{
    internal static Connection SingletonConnection = new();

    internal HttpClient Http;

    private int _disposed = 0;

    public Connection(ConnectionConfiguration? configuration = null)
    {
        configuration ??= new ConnectionConfiguration();

        //TODO: Improve configuration, receive as options + keep alive
        var httpClientHandler = new SocketsHttpHandler
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            MaxConnectionsPerServer = 1024,
            PooledConnectionLifetime = TimeSpan.FromMinutes(5),
            ConnectTimeout = TimeSpan.FromSeconds(15)
        };

        if (configuration.WebProxy != null)
        {
            httpClientHandler.UseProxy = true;
            httpClientHandler.Proxy = configuration.WebProxy;
        }

        Http = new HttpClient(httpClientHandler, false);
        Http.Timeout = configuration.Timeout;
    }

    public void Dispose()
    {
        var disp = Interlocked.CompareExchange(ref _disposed, 1, 0);
        if (disp == 0)
            return;

        Http.Dispose();
    }
}
