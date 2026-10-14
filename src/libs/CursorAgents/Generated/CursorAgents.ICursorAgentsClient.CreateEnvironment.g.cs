#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Create an environment<br/>
        /// Create a saved environment. The `201` response is the new environment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateEnvironmentResponse> CreateEnvironmentAsync(

            global::CursorAgents.CreateEnvironmentRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an environment<br/>
        /// Create a saved environment. The `201` response is the new environment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.CreateEnvironmentResponse>> CreateEnvironmentAsResponseAsync(

            global::CursorAgents.CreateEnvironmentRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an environment<br/>
        /// Create a saved environment. The `201` response is the new environment.
        /// </summary>
        /// <param name="owner">
        /// `personal` creates an environment for the API key's user, and `team` creates one for the team.
        /// </param>
        /// <param name="name">
        /// Display name. It must differ from the names of the owner's other environments; a name the owner already uses returns `409 environment_name_conflict`.<br/>
        /// Example: Web app
        /// </param>
        /// <param name="repos">
        /// Repositories for the environment, or an empty array for an environment without repositories. Cursor must be able to reach each one through your source control integration; otherwise the request returns `400 repository_access`.
        /// </param>
        /// <param name="environmentJson">
        /// The environment's `environment.json`, as a JSON-encoded string, using the same schema as a `.cursor/environment.json` file. An invalid configuration returns `400 validation_error`.<br/>
        /// Example: {"install": "pnpm install", "start": "sudo service docker start"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateEnvironmentResponse> CreateEnvironmentAsync(
            global::CursorAgents.CreateEnvironmentRequestOwner owner,
            string name,
            global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentRepo> repos,
            string environmentJson,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}