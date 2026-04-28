#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Stream a run<br/>
        /// Stream Server-Sent Events for one run. Event types include<br/>
        /// `status`, `assistant`, `thinking`, `tool_call`, `heartbeat`,<br/>
        /// `result`, `error`, and `done`. Reconnect with the<br/>
        /// `Last-Event-ID` header to resume after a disconnect; the event<br/>
        /// ID must belong to the requested run. Responses include the<br/>
        /// `X-Cursor-Stream-Retention-Seconds` header. After the<br/>
        /// retention window the endpoint may return `410 stream_expired`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="runId">
        /// Example: run-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="lastEventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> StreamRunAsync(
            string id,
            string runId,
            string? lastEventId = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}