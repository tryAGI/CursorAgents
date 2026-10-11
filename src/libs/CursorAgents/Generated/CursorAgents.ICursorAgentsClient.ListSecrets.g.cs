#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// List secrets<br/>
        /// List every Cloud Agents secret the API key can list, one item per<br/>
        /// version, with the owner that holds it. No item includes a value.<br/>
        /// Without `scope` or `environmentId`, the list includes the team's<br/>
        /// secrets and the user's personal secrets for an API key with no<br/>
        /// repository limit, and the secrets of the environments the key can<br/>
        /// list. A team admin using their own user API key without `repo` also<br/>
        /// gets the other members' personal secrets and their personal<br/>
        /// environments' secrets, with their `repos`.<br/>
        /// Keep paging until `nextCursor` is `null`, and send the same filters<br/>
        /// with each `cursor`.<br/>
        /// See https://cursor.com/docs/cloud-agent/api/endpoints#list-secrets.
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="environmentId">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="name">
        /// Example: NPM_TOKEN
        /// </param>
        /// <param name="repo">
        /// Example: github.com/acme/api
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.ListSecretInventoryResponse> ListSecretsAsync(
            global::CursorAgents.ListSecretsScope? scope = default,
            global::System.Guid? environmentId = default,
            string? name = default,
            string? repo = default,
            int? limit = default,
            string? cursor = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List secrets<br/>
        /// List every Cloud Agents secret the API key can list, one item per<br/>
        /// version, with the owner that holds it. No item includes a value.<br/>
        /// Without `scope` or `environmentId`, the list includes the team's<br/>
        /// secrets and the user's personal secrets for an API key with no<br/>
        /// repository limit, and the secrets of the environments the key can<br/>
        /// list. A team admin using their own user API key without `repo` also<br/>
        /// gets the other members' personal secrets and their personal<br/>
        /// environments' secrets, with their `repos`.<br/>
        /// Keep paging until `nextCursor` is `null`, and send the same filters<br/>
        /// with each `cursor`.<br/>
        /// See https://cursor.com/docs/cloud-agent/api/endpoints#list-secrets.
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="environmentId">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="name">
        /// Example: NPM_TOKEN
        /// </param>
        /// <param name="repo">
        /// Example: github.com/acme/api
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.ListSecretInventoryResponse>> ListSecretsAsResponseAsync(
            global::CursorAgents.ListSecretsScope? scope = default,
            global::System.Guid? environmentId = default,
            string? name = default,
            string? repo = default,
            int? limit = default,
            string? cursor = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}