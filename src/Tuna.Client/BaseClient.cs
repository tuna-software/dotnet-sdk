using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace Tuna.Client;

public class BaseClient
{
    public const string HDRAPPTOKEN = "x-tuna-apptoken";
    public const string HDRACCOUNT = "x-tuna-account";

    private static readonly MediaTypeHeaderValue s_mediaTypeHeaderValue = MediaTypeHeaderValue.Parse("application/json");
    private static readonly JsonSerializerOptions s_jsonSerializerOptions = new() { };

    internal ClientConnection _connection;

    internal BaseClient(ClientConnection connection)
    {
        _connection = connection;
    }

    internal async Task<TResponse?> SendPostAsync<TRequest, TResponse>(Uri requestUri, TRequest request, Trace? trace, RequestConfiguration? configuration)
    {
        using var httpRequest = _connection.MessageFactory(HttpMethod.Post, requestUri);

        _ = httpRequest.Headers.TryAddWithoutValidation(HDRAPPTOKEN, _connection.Credentials.AppToken);
        _ = httpRequest.Headers.TryAddWithoutValidation(HDRACCOUNT, _connection.Credentials.Account);

        if (trace == null)
        {
            httpRequest.Content = JsonContent.Create(request, options: s_jsonSerializerOptions);
        }
        else
        {
            trace.Request = JsonSerializer.Serialize(request);

            httpRequest.Content = new StringContent(trace.Request, s_mediaTypeHeaderValue);
        }

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

            if (trace != null)
            {
                trace.Response = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                trace.HttpStatusCode = response.StatusCode;

                if (string.IsNullOrWhiteSpace(trace.Response))
                    return default;

                return JsonSerializer.Deserialize<TResponse>(trace.Response);
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<TResponse>().ConfigureAwait(false);
            }
        }
        finally
        {
            response?.Dispose();
        }
    }
}