#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Update an environment<br/>
        /// Rename an environment, replace its configuration, replace its repositories, or any combination. A request applies every field it sends together, so either all of them change or none do. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`.
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
        /// Rename an environment, replace its configuration, replace its repositories, or any combination. A request applies every field it sends together, so either all of them change or none do. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`.
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
        /// Rename an environment, replace its configuration, replace its repositories, or any combination. A request applies every field it sends together, so either all of them change or none do. An environment that doesn't exist or isn't visible to the API key returns `404 environment_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="name">
        /// New display name. It must differ from the names of the owner's other environments; a name the owner already uses returns `409 environment_name_conflict`.<br/>
        /// Example: Web app (staging)
        /// </param>
        /// <param name="environmentJson">
        /// Replacement `environment.json`, as a JSON-encoded string, using the same schema as a `.cursor/environment.json` file. It replaces the whole configuration. An invalid configuration returns `400 validation_error`. If the environment reads its configuration from a file in its only repository, the request returns `409 repo_file_environment_locked`.<br/>
        /// Example: {"install": "pnpm install --frozen-lockfile", "start": "sudo service docker start"}
        /// </param>
        /// <param name="repos">
        /// The environment's full list of repositories, replacing the<br/>
        /// current list. It follows the same rules as `repos` on<br/>
        /// POST /v1/environments. Send `environmentJson` with it, because a<br/>
        /// repository change saves the whole configuration; `repos` without<br/>
        /// `environmentJson` returns `400 validation_error`. To keep the<br/>
        /// current configuration, send the `environmentJson` from<br/>
        /// GET /v1/environments/{id}.<br/>
        /// Only environments with two or more repositories can change them,<br/>
        /// and they must keep at least two. Sending the current list<br/>
        /// unchanged doesn't count as a change. Otherwise an environment<br/>
        /// without repositories, a single-repository environment, or a list<br/>
        /// with fewer than two returns `409 environment_repo_edit_blocked`.<br/>
        /// When the environment reads its configuration from a repository<br/>
        /// file (`repoFile` on GET /v1/environments/{id}), the file stays the<br/>
        /// configuration source. The list must keep the `repoFile.url`<br/>
        /// repository, or the request returns `409 repo_file_repo_removed`.<br/>
        /// Repositories are compared by identity, so a trailing `.git` or<br/>
        /// slash, a missing scheme, a leading `www.`, or GitHub letter case<br/>
        /// still match. When the list names that repository in several forms,<br/>
        /// the first entry is kept and the others dropped. For Bitbucket<br/>
        /// Server, send the URL GET returns. An environment whose<br/>
        /// only repository holds its configuration file returns<br/>
        /// `409 repo_file_environment_locked` for any `repos`. Stored<br/>
        /// repositories Cursor can't read return<br/>
        /// `400 stored_repos_unreadable`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateEnvironmentAsync(
            global::System.Guid id,
            string? name = default,
            string? environmentJson = default,
            global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentRepo>? repos = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}