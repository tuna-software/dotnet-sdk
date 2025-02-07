using System.Net;

namespace Tuna.Client;

public class Trace
{
    public string? RequestString { get; set; }
    public string? ResponseString { get; set; }
    public HttpStatusCode HttpStatusCode { get; set; }
}
