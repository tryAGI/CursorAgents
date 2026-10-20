#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// List environment builds<br/>
        /// List an environment's builds, newest first. Filter them by status or creation time. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="status"></param>
        /// <param name="createdAfter">
        /// Example: 2026-09-29T00:00:00Z
        /// </param>
        /// <param name="createdBefore">
        /// Example: 2026-10-01T00:00:00Z
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.ListEnvironmentBuildsResponse> ListEnvironmentBuildsAsync(
            global::System.Guid id,
            global::CursorAgents.ListEnvironmentBuildsStatus? status = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            int? limit = default,
            string? cursor = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List environment builds<br/>
        /// List an environment's builds, newest first. Filter them by status or creation time. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="status"></param>
        /// <param name="createdAfter">
        /// Example: 2026-09-29T00:00:00Z
        /// </param>
        /// <param name="createdBefore">
        /// Example: 2026-10-01T00:00:00Z
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.ListEnvironmentBuildsResponse>> ListEnvironmentBuildsAsResponseAsync(
            global::System.Guid id,
            global::CursorAgents.ListEnvironmentBuildsStatus? status = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            int? limit = default,
            string? cursor = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}