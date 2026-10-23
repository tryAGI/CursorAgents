
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// An ordinary follow-up. It starts a new run and returns `201`, or<br/>
    /// returns `409 agent_busy` while another run is active.
    /// </summary>
    public sealed partial class FollowupRunRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.RunPrompt Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::CursorAgents.ModelRef? Model { get; set; }

        /// <summary>
        /// Inline MCP server definitions for this follow-up run. When provided, these definitions replace any create-time inline MCP servers for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServers")]
        public global::System.Collections.Generic.IList<global::CursorAgents.McpServer>? McpServers { get; set; }

        /// <summary>
        /// Environment variables for this follow-up run only, applied<br/>
        /// while it executes. Names and values follow the same rules as<br/>
        /// `envVars` in `CreateAgentRequest`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envVars")]
        public global::System.Collections.Generic.Dictionary<string, string>? EnvVars { get; set; }

        /// <summary>
        /// Conversation mode. `plan` explores and drafts a plan before coding; `agent` implements changes directly. On follow-up runs, omit to keep the conversation's current mode; set explicitly to switch modes for that run.
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
        /// Initializes a new instance of the <see cref="FollowupRunRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="mcpServers">
        /// Inline MCP server definitions for this follow-up run. When provided, these definitions replace any create-time inline MCP servers for this run.
        /// </param>
        /// <param name="envVars">
        /// Environment variables for this follow-up run only, applied<br/>
        /// while it executes. Names and values follow the same rules as<br/>
        /// `envVars` in `CreateAgentRequest`.
        /// </param>
        /// <param name="mode">
        /// Conversation mode. `plan` explores and drafts a plan before coding; `agent` implements changes directly. On follow-up runs, omit to keep the conversation's current mode; set explicitly to switch modes for that run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FollowupRunRequest(
            global::CursorAgents.RunPrompt prompt,
            global::CursorAgents.ModelRef? model,
            global::System.Collections.Generic.IList<global::CursorAgents.McpServer>? mcpServers,
            global::System.Collections.Generic.Dictionary<string, string>? envVars,
            global::CursorAgents.AgentMode? mode)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.McpServers = mcpServers;
            this.EnvVars = envVars;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowupRunRequest" /> class.
        /// </summary>
        public FollowupRunRequest()
        {
        }

    }
}