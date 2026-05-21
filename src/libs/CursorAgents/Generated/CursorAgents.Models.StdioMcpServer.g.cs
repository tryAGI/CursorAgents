
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StdioMcpServer
    {
        /// <summary>
        /// MCP server name exposed to the agent.<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Stdio MCP server. Defaults to `stdio` when `command` is provided.<br/>
        /// Example: stdio
        /// </summary>
        /// <example>stdio</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.StdioMcpServerTypeJsonConverter))]
        public global::CursorAgents.StdioMcpServerType? Type { get; set; }

        /// <summary>
        /// Command to start inside the cloud agent VM.<br/>
        /// Example: npx
        /// </summary>
        /// <example>npx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        /// Command arguments.<br/>
        /// Example: [-y, @modelcontextprotocol/server-github]
        /// </summary>
        /// <example>[-y, @modelcontextprotocol/server-github]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// Environment variables passed to the stdio MCP server inside the VM.<br/>
        /// Example: {"GITHUB_TOKEN":"ghp_..."}
        /// </summary>
        /// <example>{"GITHUB_TOKEN":"ghp_..."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StdioMcpServer" /> class.
        /// </summary>
        /// <param name="name">
        /// MCP server name exposed to the agent.<br/>
        /// Example: github
        /// </param>
        /// <param name="command">
        /// Command to start inside the cloud agent VM.<br/>
        /// Example: npx
        /// </param>
        /// <param name="type">
        /// Stdio MCP server. Defaults to `stdio` when `command` is provided.<br/>
        /// Example: stdio
        /// </param>
        /// <param name="args">
        /// Command arguments.<br/>
        /// Example: [-y, @modelcontextprotocol/server-github]
        /// </param>
        /// <param name="env">
        /// Environment variables passed to the stdio MCP server inside the VM.<br/>
        /// Example: {"GITHUB_TOKEN":"ghp_..."}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StdioMcpServer(
            string name,
            string command,
            global::CursorAgents.StdioMcpServerType? type,
            global::System.Collections.Generic.IList<string>? args,
            global::System.Collections.Generic.Dictionary<string, string>? env)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Args = args;
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StdioMcpServer" /> class.
        /// </summary>
        public StdioMcpServer()
        {
        }

    }
}