namespace Tuna.Client;

public delegate HttpRequestMessage HttpRequestMessageFactory(HttpMethod method, string requestUriString);

/// <summary>
/// Configuration class for TunaClient
/// </summary>
public class TunaClientConfiguration
{
    /// <summary>
    /// Allows cutomization of HttpRequestMessage creation
    /// </summary>
    public HttpRequestMessageFactory HttpRequestMessageFactory { get; set; }

    /// <summary>
    /// Allows a customized HttpClient 
    /// </summary>
    public Connection? Connection { get; set; }

    public TunaClientConfiguration()
    {
        HttpRequestMessageFactory = (method, requestUriString) => new HttpRequestMessage(method, requestUriString);
    }


}