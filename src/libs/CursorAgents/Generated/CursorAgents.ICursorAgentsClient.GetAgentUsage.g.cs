#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Get agent usage<br/>
        /// Retrieve token usage for an agent, broken down per run.<br/>
        /// `totalUsage` sums input, output, and cache token counts across<br/>
        /// every run on the agent, and `runs` lists the same breakdown for<br/>
        /// each run. Token usage mirrors the `tokenUsage` shape on the team<br/>
        /// usage events endpoint.<br/>
        /// This endpoint is in early access. When it isn't enabled for the<br/>
        /// account it returns `403 feature_unavailable`. An unknown `runId`<br/>
        /// returns `404 run_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="runId">
        /// Example: run-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AgentUsageResponse> GetAgentUsageAsync(
            string id,
            string? runId = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get agent usage<br/>
        /// Retrieve token usage for an agent, broken down per run.<br/>
        /// `totalUsage` sums input, output, and cache token counts across<br/>
        /// every run on the agent, and `runs` lists the same breakdown for<br/>
        /// each run. Token usage mirrors the `tokenUsage` shape on the team<br/>
        /// usage events endpoint.<br/>
        /// This endpoint is in early access. When it isn't enabled for the<br/>
        /// account it returns `403 feature_unavailable`. An unknown `runId`<br/>
        /// returns `404 run_not_found`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="runId">
        /// Example: run-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.AgentUsageResponse>> GetAgentUsageAsResponseAsync(
            string id,
            string? runId = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}