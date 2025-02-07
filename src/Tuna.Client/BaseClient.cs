using System.Net.Http.Headers;

namespace Tuna.Client;

public class BaseClient
{
    public const string HDRAPPTOKEN = "x-tuna-apptoken";
    public const string HDRACCOUNT = "x-tuna-account";

    internal ClientConnection _connection;

    internal BaseClient(ClientConnection connection)
    {
        _connection = connection;
    }

    internal async Task<TResponse?> SendPostAsync<TRequest, TResponse>(string requestUriString, TRequest request, Trace? trace, RequestConfiguration? configuration)
    {
        using var httpRequest = _connection.MessageFactory(HttpMethod.Post, requestUriString);

        httpRequest.Headers.Add(HDRAPPTOKEN, _connection.Credentials.AppToken);
        httpRequest.Headers.Add(HDRACCOUNT, _connection.Credentials.Account);

        var reqString = System.Text.Json.JsonSerializer.Serialize(request);

        if (trace != null) trace.RequestString = reqString;

        httpRequest.Content = new StringContent(reqString, MediaTypeHeaderValue.Parse("application/json"));

        HttpResponseMessage? response = null;

        try
        {
            if (configuration?.Timeout != null && configuration.Timeout > TimeSpan.Zero)
            {
                using (var ct = new CancellationTokenSource(configuration.Timeout.Value))
                {
                    response = await _connection.Connection.Http.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead, ct.Token).ConfigureAwait(false);
                }
            }
            else
            {
                response = await _connection.Connection.Http.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
            }

            if (trace != null) trace.HttpStatusCode = response.StatusCode;

            var rspString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (trace != null) trace.ResponseString = rspString;

            return System.Text.Json.JsonSerializer.Deserialize<TResponse>(rspString);
        }
        finally
        {
            if (response != null)
                response.Dispose();        
        }
    }
}