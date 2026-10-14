#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Get an environment<br/>
        /// Retrieve a saved environment and its latest saved configuration. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.GetEnvironmentResponse> GetEnvironmentAsync(
            global::System.Guid id,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an environment<br/>
        /// Retrieve a saved environment and its latest saved configuration. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.GetEnvironmentResponse>> GetEnvironmentAsResponseAsync(
            global::System.Guid id,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}