#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Start an environment build<br/>
        /// Start a build of the environment. Access follows PATCH /v1/environments/{id}, except that a draft build on a team environment needs only read access, and API keys limited to certain repositories are refused. Such a key, or a user-scoped token it minted, gets `404 environment_not_found` when the environment has no repositories or any repository outside the limit, and `403 key_not_supported` otherwise. A team service account API key with no repository limit can start builds of its own team's environments. It needs the `agent` scope, and the team setting that limits environment edits to admins doesn't limit it. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`. Reading the new build right away can briefly return `404`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.StartEnvironmentBuildResponse> StartEnvironmentBuildAsync(
            global::System.Guid id,

            global::CursorAgents.StartEnvironmentBuildRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an environment build<br/>
        /// Start a build of the environment. Access follows PATCH /v1/environments/{id}, except that a draft build on a team environment needs only read access, and API keys limited to certain repositories are refused. Such a key, or a user-scoped token it minted, gets `404 environment_not_found` when the environment has no repositories or any repository outside the limit, and `403 key_not_supported` otherwise. A team service account API key with no repository limit can start builds of its own team's environments. It needs the `agent` scope, and the team setting that limits environment edits to admins doesn't limit it. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`. Reading the new build right away can briefly return `404`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.StartEnvironmentBuildResponse>> StartEnvironmentBuildAsResponseAsync(
            global::System.Guid id,

            global::CursorAgents.StartEnvironmentBuildRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an environment build<br/>
        /// Start a build of the environment. Access follows PATCH /v1/environments/{id}, except that a draft build on a team environment needs only read access, and API keys limited to certain repositories are refused. Such a key, or a user-scoped token it minted, gets `404 environment_not_found` when the environment has no repositories or any repository outside the limit, and `403 key_not_supported` otherwise. A team service account API key with no repository limit can start builds of its own team's environments. It needs the `agent` scope, and the team setting that limits environment edits to admins doesn't limit it. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`. Reading the new build right away can briefly return `404`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="draft">
        /// `true` for a draft build, which agents don't start from until it's activated. A non-draft build is what agents start from once it succeeds.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="refs">
        /// Branches to build instead of the default branches. Repositories without an entry build their default branch, and a ref that names the default branch counts as no entry. Any other branch requires `draft` set to `true`; without it, and for a repository that isn't in the environment or a second ref for the same repository, the request returns `400 validation_error`. Cursor doesn't check that the branch exists, so a missing branch fails the build, not the request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.StartEnvironmentBuildResponse> StartEnvironmentBuildAsync(
            global::System.Guid id,
            bool? draft = default,
            global::System.Collections.Generic.IList<global::CursorAgents.StartEnvironmentBuildRef>? refs = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}