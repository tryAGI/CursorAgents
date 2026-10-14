#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Update an environment<br/>
        /// Rename an environment, replace its configuration, or both. A request with both fields applies them together, so either both change or neither does. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateEnvironmentAsync(
            global::System.Guid id,

            global::CursorAgents.UpdateEnvironmentRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an environment<br/>
        /// Rename an environment, replace its configuration, or both. A request with both fields applies them together, so either both change or neither does. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse> UpdateEnvironmentAsResponseAsync(
            global::System.Guid id,

            global::CursorAgents.UpdateEnvironmentRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an environment<br/>
        /// Rename an environment, replace its configuration, or both. A request with both fields applies them together, so either both change or neither does. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="name">
        /// New display name. It must differ from the names of the owner's other environments; a name the owner already uses returns `409 environment_name_conflict`.<br/>
        /// Example: Web app (staging)
        /// </param>
        /// <param name="environmentJson">
        /// Replacement `environment.json`, as a JSON-encoded string, using the same schema as a `.cursor/environment.json` file. It replaces the whole configuration. An invalid configuration returns `400 validation_error`.<br/>
        /// Example: {"install": "pnpm install --frozen-lockfile", "start": "sudo service docker start"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateEnvironmentAsync(
            global::System.Guid id,
            string? name = default,
            string? environmentJson = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}