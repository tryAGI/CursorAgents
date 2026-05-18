
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::CursorAgents.AgentEnv? Env { get; set; }

        /// <summary>
        /// Repository configuration. Mutually exclusive with a named cloud environment. Omit both `repos` and `env` to start a no-repo agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        public global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? Repos { get; set; }

        /// <summary>
        /// Custom branch name for the agent to create.<br/>
        /// Example: feature/add-readme
        /// </summary>
        /// <example>feature/add-readme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchName")]
        public string? BranchName { get; set; }

        /// <summary>
        /// Whether to create a new branch (true) or push to an existing head branch (false). Only applies when `repos[0].prUrl` is provided.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoGenerateBranch")]
        public bool? AutoGenerateBranch { get; set; }

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
        /// Session-scoped environment variables for the cloud agent. Values are encrypted at rest, injected into the agent's shell, and deleted with the agent. Names must be non-empty, 1024 bytes or less, and cannot start with `CURSOR_`. Values must be non-empty and 4096 bytes or less.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envVars")]
        public global::System.Collections.Generic.Dictionary<string, string>? EnvVars { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRequest(
            global::CursorAgents.CreateAgentRequestPrompt prompt,
            global::CursorAgents.ModelRef? model,
            global::CursorAgents.AgentEnv? env,
            global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? repos,
            string? branchName,
            bool? autoGenerateBranch,
            bool? autoCreatePR,
            bool? skipReviewerRequest,
            global::System.Collections.Generic.Dictionary<string, string>? envVars,
            global::CursorAgents.AgentMode? mode)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.Env = env;
            this.Repos = repos;
            this.BranchName = branchName;
            this.AutoGenerateBranch = autoGenerateBranch;
            this.AutoCreatePR = autoCreatePR;
            this.SkipReviewerRequest = skipReviewerRequest;
            this.EnvVars = envVars;
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