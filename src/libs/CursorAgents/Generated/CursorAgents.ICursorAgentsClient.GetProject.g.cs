#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Get a Project<br/>
        /// Retrieve durable metadata for a Project. The ID of your own coordinator in a Project you joined also works as `id`. A Project you can't see returns `404 project_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.Project> GetProjectAsync(
            string id,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Project<br/>
        /// Retrieve durable metadata for a Project. The ID of your own coordinator in a Project you joined also works as `id`. A Project you can't see returns `404 project_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.Project>> GetProjectAsResponseAsync(
            string id,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}