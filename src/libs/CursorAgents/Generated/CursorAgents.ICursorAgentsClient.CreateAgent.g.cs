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
        /// <param name="name">
        /// Display name for the agent. Auto-derived from the prompt when omitted.<br/>
        /// Example: Add README with setup instructions
        /// </param>
        /// <param name="agentId">
        /// Optional client-supplied agent identifier in `bc-&lt;uuid&gt;` form. Re-POSTing the same `agentId` returns `409 agent_id_conflict` instead of creating a duplicate. Cannot be combined with `envVars`; omit `agentId` so the server mints one when you need session secrets.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="env"></param>
        /// <param name="repos">
        /// Repository configuration. Mutually exclusive with a named cloud environment. Omit both `repos` and `env` (or pass `repos: []`) to start a no-repo agent.
        /// </param>
        /// <param name="workOnCurrentBranch">
        /// When `false` (the default), Cursor pushes commits to a new<br/>
        /// auto-generated branch (`cursor/...`) based on<br/>
        /// `repos[0].startingRef` (or the PR base ref when `prUrl`<br/>
        /// is set). When `true`, Cursor pushes directly to that<br/>
        /// starting ref — for a non-PR create, that's the branch you<br/>
        /// passed in `startingRef`; for a `prUrl` create, that's the<br/>
        /// PR's head branch.<br/>
        /// Default Value: false
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
        /// Session-scoped environment variables for the cloud agent.<br/>
        /// Values are encrypted at rest, injected into the agent's<br/>
        /// shell, and deleted with the agent. Names must be non-empty,<br/>
        /// 255 bytes or less, and cannot start with `CURSOR_`. Values<br/>
        /// must be non-empty and 4096 bytes or less. Cannot be<br/>
        /// combined with a client-supplied `agentId`.<br/>
        /// Beta: `envVars` is rolling out. If it isn't enabled for<br/>
        /// your account yet, the field is silently ignored on create<br/>
        /// rather than failing the request — verify the values are<br/>
        /// present on a first run before relying on them in<br/>
        /// production.
        /// </param>
        /// <param name="mcpServers">
        /// Inline MCP server definitions available to the initial run. Remote servers support `headers` or OAuth `auth`; stdio servers run inside the cloud agent VM and can receive `env`. Server names must be unique.
        /// </param>
        /// <param name="customSubagents">
        /// Custom subagents the main agent can delegate to. Names must be unique and not collide with built-ins.
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
            string? name = default,
            string? agentId = default,
            global::CursorAgents.AgentEnv? env = default,
            global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? repos = default,
            bool? workOnCurrentBranch = default,
            bool? autoCreatePR = default,
            bool? skipReviewerRequest = default,
            global::System.Collections.Generic.Dictionary<string, string>? envVars = default,
            global::System.Collections.Generic.IList<global::CursorAgents.McpServer>? mcpServers = default,
            global::System.Collections.Generic.IList<global::CursorAgents.CustomSubagent>? customSubagents = default,
            global::CursorAgents.AgentMode? mode = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}