#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Create A User-Scoped Worker Token<br/>
        /// Create a one-hour user-scoped token for a My Machines worker to run as an<br/>
        /// active team member. Requires an agent-scoped team service account<br/>
        /// API key. User-scoped tokens can't mint other user-scoped tokens.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateSubTokenResponse> CreateSubTokenAsync(

            global::CursorAgents.CreateSubTokenRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A User-Scoped Worker Token<br/>
        /// Create a one-hour user-scoped token for a My Machines worker to run as an<br/>
        /// active team member. Requires an agent-scoped team service account<br/>
        /// API key. User-scoped tokens can't mint other user-scoped tokens.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.CreateSubTokenResponse>> CreateSubTokenAsResponseAsync(

            global::CursorAgents.CreateSubTokenRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A User-Scoped Worker Token<br/>
        /// Create a one-hour user-scoped token for a My Machines worker to run as an<br/>
        /// active team member. Requires an agent-scoped team service account<br/>
        /// API key. User-scoped tokens can't mint other user-scoped tokens.
        /// </summary>
        /// <param name="forUserEmail">
        /// Active team member email. Case-insensitive. Mutually exclusive with `forUserId`.<br/>
        /// Example: alice@company.com
        /// </param>
        /// <param name="forUserId">
        /// Active team member's numeric Cursor user ID. Mutually exclusive with `forUserEmail`.<br/>
        /// Example: 42
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateSubTokenResponse> CreateSubTokenAsync(
            string? forUserEmail = default,
            int? forUserId = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}