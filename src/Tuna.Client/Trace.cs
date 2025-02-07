using System.Net;

namespace Tuna.Client;

public class Trace
{
    public string? Request { get; set; }
    public string? Response { get; set; }
    public HttpStatusCode HttpStatusCode { get; set; }
}
