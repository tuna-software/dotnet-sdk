namespace Tuna.Client;


public class Payments : BaseClient
{
    private static readonly Uri s_uriInitPci = new("https://token.tunagateway.com/api/integrations/pci/init");
    private static readonly Uri s_uriStatus = new(ClientConnection.TUNA_ADDRESS + "Payment/Status");
    private static readonly Uri s_uriStatusPoll = new(ClientConnection.TUNA_ADDRESS + "Payment/StatusPoll");

    internal Payments(ClientConnection connection) : base(connection)
    {
    }

    /// <summary>
    /// Allow payments in PCI mode ie sending the card and cvv
    /// </summary>
    /// <param name="request">Init Request with an orden and payment description</param>
    /// <param name="trace">Optional, if passed the request/response plain messages and httpcode will be set in the object </param>
    /// <param name="configuration">Optional configuraion specific to this call</param>
    /// <returns></returns>
    public Task<InitResponse?> InitPci(InitRequest request, Trace? trace = null, RequestConfiguration? configuration = null)
    {
        return SendPostAsync<InitRequest, InitResponse>(s_uriInitPci, request, trace, configuration);
    }

    public Task<StatusResponse?> Status(StatusRequest request, Trace? trace = null, RequestConfiguration? configuration = null)
    {
        return SendPostAsync<StatusRequest, StatusResponse>(s_uriStatus, request, trace, configuration);
    }

    public Task<StatusPollResponse?> StatusPoll(StatusRequest request, Trace? trace = null, RequestConfiguration? configuration = null)
    {
        return SendPostAsync<StatusRequest, StatusPollResponse>(s_uriStatusPoll, request, trace, configuration);
    }
}