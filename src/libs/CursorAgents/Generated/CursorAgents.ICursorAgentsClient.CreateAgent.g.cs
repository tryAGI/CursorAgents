#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Launch an agent<br/>
        /// Start a new cloud agent to work on your repository
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateAgentResponse> CreateAgentAsync(

            global::CursorAgents.CreateAgentRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Launch an agent<br/>
        /// Start a new cloud agent to work on your repository
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="model">
        /// Set to an explicit model ID for launch requests, or use "default" to use the configured default model. When omitted, Cursor resolves your user default model, then your team default model, then a system default.<br/>
        /// Example: claude-4-sonnet
        /// </param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="webhook"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateAgentResponse> CreateAgentAsync(
            global::CursorAgents.CreateAgentRequestPrompt prompt,
            global::CursorAgents.CreateAgentRequestSource source,
            string? model = default,
            global::CursorAgents.CreateAgentRequestTarget? target = default,
            global::CursorAgents.CreateAgentRequestWebhook? webhook = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}