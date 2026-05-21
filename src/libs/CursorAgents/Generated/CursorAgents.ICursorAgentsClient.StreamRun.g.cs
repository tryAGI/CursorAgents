#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Stream a run<br/>
        /// Stream Server-Sent Events for one run. Event types are<br/>
        /// `status`, `assistant`, `thinking`, `tool_call`,<br/>
        /// `interaction_update`, `heartbeat`, `result`, `error`, and<br/>
        /// `done`.<br/>
        /// - `status` carries `{ runId, status }`. It has no `id` line<br/>
        ///   and is replayed at the top of every reconnect.<br/>
        /// - `result` carries `{ runId, status, text?, durationMs?,<br/>
        ///   git? }`; `text` is the final assistant reply, `durationMs`<br/>
        ///   the wall-clock duration, and `git` mirrors `Run.git`.<br/>
        /// - `interaction_update` carries the richer SDK-shape update<br/>
        ///   used by the TypeScript SDK and is emitted alongside the<br/>
        ///   simplified events that share the same event id. Use this if<br/>
        ///   you want the full SDK stream; otherwise handle the simplified<br/>
        ///   events and ignore it.<br/>
        /// Reconnect with the `Last-Event-ID` header to resume after a<br/>
        /// disconnect; the event ID must belong to the requested run<br/>
        /// otherwise the endpoint returns `400 invalid_last_event_id`.<br/>
        /// Responses include the `X-Cursor-Stream-Retention-Seconds`<br/>
        /// header; after the retention window the endpoint may return<br/>
        /// `410 stream_expired`. `tool_call` event data uses the<br/>
        /// `RunStreamToolCallData` schema.
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