#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Get an environment build<br/>
        /// Retrieve one of an environment's builds. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`, and a build ID that isn't one of the environment's builds returns `404 build_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="buildId">
        /// Unique build identifier, in the form `bld-YYYYMMDD-&lt;uuid&gt;`.<br/>
        /// Example: bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.EnvironmentBuild> GetEnvironmentBuildAsync(
            global::System.Guid id,
            string buildId,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an environment build<br/>
        /// Retrieve one of an environment's builds. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`, and a build ID that isn't one of the environment's builds returns `404 build_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="buildId">
        /// Unique build identifier, in the form `bld-YYYYMMDD-&lt;uuid&gt;`.<br/>
        /// Example: bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.EnvironmentBuild>> GetEnvironmentBuildAsResponseAsync(
            global::System.Guid id,
            string buildId,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}