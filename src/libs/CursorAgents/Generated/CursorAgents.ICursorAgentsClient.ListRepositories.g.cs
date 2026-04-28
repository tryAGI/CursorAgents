#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// List GitHub repositories<br/>
        /// List GitHub repositories accessible to the authenticated user<br/>
        /// through Cursor's GitHub App installation. This endpoint has<br/>
        /// very strict rate limits (1 request per user per minute, 30<br/>
        /// per user per hour) and can take tens of seconds to respond<br/>
        /// for users with access to many repositories. Cache responses<br/>
        /// aggressively and handle this information not being available<br/>
        /// gracefully.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.ListRepositoriesResponse> ListRepositoriesAsync(
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}