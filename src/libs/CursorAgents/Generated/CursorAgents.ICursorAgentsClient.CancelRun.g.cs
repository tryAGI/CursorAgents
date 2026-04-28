#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Cancel a run<br/>
        /// Cancel the active run for an agent. Cancellation is terminal —<br/>
        /// the run transitions to `CANCELLED`. Cancelling a run that is<br/>
        /// already terminal or was never active returns<br/>
        /// `409 run_not_cancellable`. To continue the conversation,<br/>
        /// create a new run on the same agent.
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
        global::System.Threading.Tasks.Task<global::CursorAgents.IdResponse> CancelRunAsync(
            string id,
            string runId,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}