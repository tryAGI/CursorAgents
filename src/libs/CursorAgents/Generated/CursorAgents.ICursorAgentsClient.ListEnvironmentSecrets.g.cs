#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// List environment secrets<br/>
        /// List an environment's Cloud Agents secrets, one item per version,<br/>
        /// sorted by name. No item includes a value. The list isn't paginated<br/>
        /// yet, so `nextCursor` is always `null`.<br/>
        /// A service account API key can list its team's environments, and<br/>
        /// a user API key or user-scoped token its user's personal<br/>
        /// environments too. An API key limited to certain repositories can<br/>
        /// list only environments whose repositories all sit inside its<br/>
        /// limit. Every other environment returns `404 environment_not_found`.<br/>
        /// See https://cursor.com/docs/cloud-agent/api/endpoints#list-environment-secrets.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.ListSecretsResponse> ListEnvironmentSecretsAsync(
            global::System.Guid id,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List environment secrets<br/>
        /// List an environment's Cloud Agents secrets, one item per version,<br/>
        /// sorted by name. No item includes a value. The list isn't paginated<br/>
        /// yet, so `nextCursor` is always `null`.<br/>
        /// A service account API key can list its team's environments, and<br/>
        /// a user API key or user-scoped token its user's personal<br/>
        /// environments too. An API key limited to certain repositories can<br/>
        /// list only environments whose repositories all sit inside its<br/>
        /// limit. Every other environment returns `404 environment_not_found`.<br/>
        /// See https://cursor.com/docs/cloud-agent/api/endpoints#list-environment-secrets.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.ListSecretsResponse>> ListEnvironmentSecretsAsResponseAsync(
            global::System.Guid id,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}