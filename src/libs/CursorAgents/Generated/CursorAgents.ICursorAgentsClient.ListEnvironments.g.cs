#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// List environments<br/>
        /// List the saved environments the API key can access, most recently<br/>
        /// updated first: the user's personal environments and the team's<br/>
        /// environments. Team admins don't see members' personal environments<br/>
        /// here.<br/>
        /// Team admins and service account API keys see every team<br/>
        /// environment. Other callers see a team environment only when they<br/>
        /// can access all of its repositories. When those checks run out of<br/>
        /// time, a response can leave out team environments it hasn't<br/>
        /// verified yet, or stop before the end of the list; they show up in<br/>
        /// later requests. A service account API key limited to specific<br/>
        /// repositories, and user-scoped tokens minted with it, only list<br/>
        /// environments that have repositories, all within that limit. Drafts<br/>
        /// and deleted environments aren't included.<br/>
        /// An environment that changes during a walk moves to the front, so a<br/>
        /// later page can leave it out and repeat another. List items omit<br/>
        /// `environmentJson` and `versionId`; call GET /v1/environments/{id}<br/>
        /// to load an environment's configuration.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.ListEnvironmentsResponse> ListEnvironmentsAsync(
            int? limit = default,
            string? cursor = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List environments<br/>
        /// List the saved environments the API key can access, most recently<br/>
        /// updated first: the user's personal environments and the team's<br/>
        /// environments. Team admins don't see members' personal environments<br/>
        /// here.<br/>
        /// Team admins and service account API keys see every team<br/>
        /// environment. Other callers see a team environment only when they<br/>
        /// can access all of its repositories. When those checks run out of<br/>
        /// time, a response can leave out team environments it hasn't<br/>
        /// verified yet, or stop before the end of the list; they show up in<br/>
        /// later requests. A service account API key limited to specific<br/>
        /// repositories, and user-scoped tokens minted with it, only list<br/>
        /// environments that have repositories, all within that limit. Drafts<br/>
        /// and deleted environments aren't included.<br/>
        /// An environment that changes during a walk moves to the front, so a<br/>
        /// later page can leave it out and repeat another. List items omit<br/>
        /// `environmentJson` and `versionId`; call GET /v1/environments/{id}<br/>
        /// to load an environment's configuration.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.ListEnvironmentsResponse>> ListEnvironmentsAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}