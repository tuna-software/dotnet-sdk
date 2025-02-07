namespace Tuna.Client;


public class Payments : BaseClient
{
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
    public async Task<InitResponse?> InitPci(InitRequest request, Trace? trace = null, RequestConfiguration? configuration = null)
    {
        var requestUriString = "https://token.tunagateway.com/api/integrations/pci/init";

        return await SendPostAsync<InitRequest, InitResponse>(requestUriString, request, trace, configuration).ConfigureAwait(false);
    }
}