
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.CreateAgentRequestPrompt Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::CursorAgents.ModelRef? Model { get; set; }

        /// <summary>
        /// Display name for the agent. Auto-derived from the prompt when omitted.<br/>
        /// Example: Add README with setup instructions
        /// </summary>
        /// <example>Add README with setup instructions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional client-supplied agent identifier in `bc-&lt;uuid&gt;` form. Re-POSTing the same `agentId` returns `409 agent_id_conflict` instead of creating a duplicate. Cannot be combined with `envVars`; omit `agentId` so the server mints one when you need session secrets.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>bc-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public string? AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::CursorAgents.AgentEnv? Env { get; set; }

        /// <summary>
        /// Repository configuration. Mutually exclusive with a named cloud environment. Omit both `repos` and `env` (or pass `repos: []`) to start a no-repo agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        public global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? Repos { get; set; }

        /// <summary>
        /// When `false` (the default), Cursor pushes commits to a new<br/>
        /// auto-generated branch (`cursor/...`) based on<br/>
        /// `repos[0].startingRef` (or the PR base ref when `prUrl`<br/>
        /// is set). When `true`, Cursor pushes directly to that<br/>
        /// starting ref — for a non-PR create, that's the branch you<br/>
        /// passed in `startingRef`; for a `prUrl` create, that's the<br/>
        /// PR's head branch.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workOnCurrentBranch")]
        public bool? WorkOnCurrentBranch { get; set; }

        /// <summary>
        /// Whether Cursor should open a pull request when the run completes.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoCreatePR")]
        public bool? AutoCreatePR { get; set; }

        /// <summary>
        /// Whether to skip requesting the user as a reviewer when Cursor opens a PR. Only applies when `autoCreatePR` is true.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipReviewerRequest")]
        public bool? SkipReviewerRequest { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envVars")]
        public global::System.Collections.Generic.Dictionary<string, string>? EnvVars { get; set; }

        /// <summary>
        /// Inline MCP server definitions available to the initial run. Remote servers support `headers` or OAuth `auth`; stdio servers run inside the cloud agent VM and can receive `env`. Server names must be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServers")]
        public global::System.Collections.Generic.IList<global::CursorAgents.McpServer>? McpServers { get; set; }

        /// <summary>
        /// Custom subagents the main agent can delegate to. Names must be unique and not collide with built-ins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customSubagents")]
        public global::System.Collections.Generic.IList<global::CursorAgents.CustomSubagent>? CustomSubagents { get; set; }

        /// <summary>
        /// Initial conversation mode for the agent's first run.<br/>
        /// Default Value: agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.AgentModeJsonConverter))]
        public global::CursorAgents.AgentMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRequest(
            global::CursorAgents.CreateAgentRequestPrompt prompt,
            global::CursorAgents.ModelRef? model,
            string? name,
            string? agentId,
            global::CursorAgents.AgentEnv? env,
            global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? repos,
            bool? workOnCurrentBranch,
            bool? autoCreatePR,
            bool? skipReviewerRequest,
            global::System.Collections.Generic.Dictionary<string, string>? envVars,
            global::System.Collections.Generic.IList<global::CursorAgents.McpServer>? mcpServers,
            global::System.Collections.Generic.IList<global::CursorAgents.CustomSubagent>? customSubagents,
            global::CursorAgents.AgentMode? mode)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.Name = name;
            this.AgentId = agentId;
            this.Env = env;
            this.Repos = repos;
            this.WorkOnCurrentBranch = workOnCurrentBranch;
            this.AutoCreatePR = autoCreatePR;
            this.SkipReviewerRequest = skipReviewerRequest;
            this.EnvVars = envVars;
            this.McpServers = mcpServers;
            this.CustomSubagents = customSubagents;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        public CreateAgentRequest()
        {
        }

    }
}