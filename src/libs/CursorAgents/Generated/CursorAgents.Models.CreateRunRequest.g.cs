
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRunRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.CreateRunRequestPrompt Prompt { get; set; }

        /// <summary>
        /// Inline MCP server definitions for this follow-up run. When provided, these definitions replace any create-time inline MCP servers for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServers")]
        public global::System.Collections.Generic.IList<global::CursorAgents.McpServer>? McpServers { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateRunRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="mcpServers">
        /// Inline MCP server definitions for this follow-up run. When provided, these definitions replace any create-time inline MCP servers for this run.
        /// </param>
        /// <param name="mode">
        /// Conversation mode. `plan` explores and drafts a plan before coding; `agent` implements changes directly. On follow-up runs, omit to keep the conversation's current mode; set explicitly to switch modes for that run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRunRequest(
            global::CursorAgents.CreateRunRequestPrompt prompt,
            global::System.Collections.Generic.IList<global::CursorAgents.McpServer>? mcpServers,
            global::CursorAgents.AgentMode? mode)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.McpServers = mcpServers;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunRequest" /> class.
        /// </summary>
        public CreateRunRequest()
        {
        }

    }
}