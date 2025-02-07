namespace Tuna.Client;

public delegate HttpRequestMessage HttpRequestMessageFactory(HttpMethod method, string requestUriString);

public class TunaClientConfiguration
{
    public HttpRequestMessageFactory HttpRequestMessageFactory { get; set; }

    public TunaClientConfiguration()
    {
        HttpRequestMessageFactory = (method, requestUriString) => new HttpRequestMessage(method, requestUriString);
    }

    public Connection? Connection {get; set;}
   
}