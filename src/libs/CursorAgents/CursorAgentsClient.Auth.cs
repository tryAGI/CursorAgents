using System.Net.Http.Headers;

namespace CursorAgents;

public partial class CursorAgentsClient
{
#pragma warning disable CA1822 // Mark members as static
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        // The Cursor Cloud Agents API uses Basic Authentication with the API key
        // as the username and an empty password. The OpenAPI spec declares bearer auth,
        // so we convert the Bearer token to Basic auth here.
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { Length: > 0 } apiKey })
        {
            var basicValue = global::System.Convert.ToBase64String(
                global::System.Text.Encoding.UTF8.GetBytes($"{apiKey}:"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", basicValue);
        }
    }
#pragma warning restore CA1822 // Mark members as static
}
