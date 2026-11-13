#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Stream an agent<br/>
        /// Stream Server-Sent Events for an agent across all of its runs.<br/>
        /// Unlike the run stream, the stream stays open when a run ends and<br/>
        /// carries runs the caller didn't start. It closes when the client<br/>
        /// disconnects or the agent is archived. Event types are the run<br/>
        /// stream's, except:<br/>
        /// - `status` carries `{ agentId, status }`: the status of the<br/>
        ///   agent's current run. A status change, including `FINISHED`,<br/>
        ///   doesn't close the stream.<br/>
        /// - There is no `result` event.<br/>
        /// For a Project coordinator, each message it sends is one<br/>
        /// `assistant` event with the whole message, and its working notes<br/>
        /// and `send_message` tool calls are left out.<br/>
        /// Without a cursor, the stream starts where the agent's newest run<br/>
        /// started. Resume with the `Last-Event-ID` header, or the<br/>
        /// `lastEventId` query parameter for clients that can't set headers;<br/>
        /// an ID this agent's stream didn't send returns<br/>
        /// `400 invalid_last_event_id`. Cursor closes open streams when it<br/>
        /// deploys, with no final event; reconnect with `Last-Event-ID`.<br/>
        /// When the agent is archived, the stream sends `status` with<br/>
        /// `CANCELLED`, then `done`. Responses include the<br/>
        /// `X-Cursor-Stream-Retention-Seconds` header; a `Last-Event-ID`<br/>
        /// older than the retention window returns `410 stream_expired`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="lastEventId"></param>
        /// <param name="lastEventId2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> StreamAgentAsync(
            string id,
            string? lastEventId = default,
            string? lastEventId2 = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}