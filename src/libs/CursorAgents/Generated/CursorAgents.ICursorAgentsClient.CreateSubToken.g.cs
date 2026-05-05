#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Create a user-scoped worker token<br/>
        /// Create a short-lived access token for an active team member.<br/>
        /// This endpoint requires an agent-scoped team service account<br/>
        /// API key. Use the returned token to start a My Machines worker<br/>
        /// that runs as the requested user. The caller must be an<br/>
        /// unfederated service account API key (federated user sessions<br/>
        /// cannot mint sub-tokens).
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
        /// Create a user-scoped worker token<br/>
        /// Create a short-lived access token for an active team member.<br/>
        /// This endpoint requires an agent-scoped team service account<br/>
        /// API key. Use the returned token to start a My Machines worker<br/>
        /// that runs as the requested user. The caller must be an<br/>
        /// unfederated service account API key (federated user sessions<br/>
        /// cannot mint sub-tokens).
        /// </summary>
        /// <param name="forUserEmail">
        /// Email address of the active team member. Matched case-insensitively. Mutually exclusive with `forUserId`.<br/>
        /// Example: alice@company.com
        /// </param>
        /// <param name="forUserId">
        /// Numeric Cursor user ID of the active team member. Mutually exclusive with `forUserEmail`.<br/>
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