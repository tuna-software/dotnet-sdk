namespace Tuna.Client;

public class Payments : BaseClient
{
    internal Payments(ClientConnection connection) : base(connection)
    {
    }

    public async Task<InitResponse?> InitPci(InitRequest request, Trace? trace = null, RequestConfiguration? configuration = null)
    {
        var requestUriString = "https://token.tunagateway.com/api/integrations/pci/init";

        return await SendPostAsync<InitRequest, InitResponse>(requestUriString, request, trace, configuration).ConfigureAwait(false);
    }
}