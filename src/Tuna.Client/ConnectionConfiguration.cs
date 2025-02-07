using System.Net;

namespace Tuna.Client;

public class ConnectionConfiguration
{
    public IWebProxy? WebProxy { get; set; }

    public TimeSpan Timeout { get; set; }

    public ConnectionConfiguration()
    {
        Timeout = TimeSpan.FromSeconds(45);
    }
}