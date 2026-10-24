#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Send a follow-up or steer<br/>
        /// Send a follow-up prompt to an existing active agent. Without<br/>
        /// `delivery`, the prompt starts a new run that uses the agent's<br/>
        /// current conversation and workspace state, and only one run can<br/>
        /// be active per agent at a time. With `delivery: steer`, the<br/>
        /// agent's running turn takes the prompt when it can, and otherwise<br/>
        /// the prompt becomes the agent's next follow-up. On success, a<br/>
        /// steer returns `202` with no run object. `delivery` says what<br/>
        /// happened, and a `steered` response can include `runId`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateRunResponse> CreateRunAsync(
            string id,

            global::CursorAgents.CreateRunRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send a follow-up or steer<br/>
        /// Send a follow-up prompt to an existing active agent. Without<br/>
        /// `delivery`, the prompt starts a new run that uses the agent's<br/>
        /// current conversation and workspace state, and only one run can<br/>
        /// be active per agent at a time. With `delivery: steer`, the<br/>
        /// agent's running turn takes the prompt when it can, and otherwise<br/>
        /// the prompt becomes the agent's next follow-up. On success, a<br/>
        /// steer returns `202` with no run object. `delivery` says what<br/>
        /// happened, and a `steered` response can include `runId`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.CreateRunResponse>> CreateRunAsResponseAsync(
            string id,

            global::CursorAgents.CreateRunRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send a follow-up or steer<br/>
        /// Send a follow-up prompt to an existing active agent. Without<br/>
        /// `delivery`, the prompt starts a new run that uses the agent's<br/>
        /// current conversation and workspace state, and only one run can<br/>
        /// be active per agent at a time. With `delivery: steer`, the<br/>
        /// agent's running turn takes the prompt when it can, and otherwise<br/>
        /// the prompt becomes the agent's next follow-up. On success, a<br/>
        /// steer returns `202` with no run object. `delivery` says what<br/>
        /// happened, and a `steered` response can include `runId`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateRunResponse> CreateRunAsync(
            string id,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}