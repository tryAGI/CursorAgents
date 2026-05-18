#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Create an agent<br/>
        /// Create a Cloud Agent and immediately enqueue its initial run.<br/>
        /// The response contains both the durable `agent` and the initial<br/>
        /// `run`.
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
        /// Create an agent<br/>
        /// Create a Cloud Agent and immediately enqueue its initial run.<br/>
        /// The response contains both the durable `agent` and the initial<br/>
        /// `run`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.CreateAgentResponse>> CreateAgentAsResponseAsync(

            global::CursorAgents.CreateAgentRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent<br/>
        /// Create a Cloud Agent and immediately enqueue its initial run.<br/>
        /// The response contains both the durable `agent` and the initial<br/>
        /// `run`.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="env"></param>
        /// <param name="repos">
        /// Repository configuration. Mutually exclusive with a named cloud environment. Omit both `repos` and `env` to start a no-repo agent.
        /// </param>
        /// <param name="branchName">
        /// Custom branch name for the agent to create.<br/>
        /// Example: feature/add-readme
        /// </param>
        /// <param name="autoGenerateBranch">
        /// Whether to create a new branch (true) or push to an existing head branch (false). Only applies when `repos[0].prUrl` is provided.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="autoCreatePR">
        /// Whether Cursor should open a pull request when the run completes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="skipReviewerRequest">
        /// Whether to skip requesting the user as a reviewer when Cursor opens a PR. Only applies when `autoCreatePR` is true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="envVars">
        /// Session-scoped environment variables for the cloud agent. Values are encrypted at rest, injected into the agent's shell, and deleted with the agent. Names must be non-empty, 1024 bytes or less, and cannot start with `CURSOR_`. Values must be non-empty and 4096 bytes or less.
        /// </param>
        /// <param name="mode">
        /// Initial conversation mode for the agent's first run.<br/>
        /// Default Value: agent
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateAgentResponse> CreateAgentAsync(
            global::CursorAgents.CreateAgentRequestPrompt prompt,
            global::CursorAgents.ModelRef? model = default,
            global::CursorAgents.AgentEnv? env = default,
            global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? repos = default,
            string? branchName = default,
            bool? autoGenerateBranch = default,
            bool? autoCreatePR = default,
            bool? skipReviewerRequest = default,
            global::System.Collections.Generic.Dictionary<string, string>? envVars = default,
            global::CursorAgents.AgentMode? mode = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}