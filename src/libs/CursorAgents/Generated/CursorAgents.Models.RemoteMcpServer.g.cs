
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoteMcpServer
    {
        /// <summary>
        /// MCP server name exposed to the agent.<br/>
        /// Example: linear
        /// </summary>
        /// <example>linear</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Remote MCP transport. Defaults to `http` when `url` is provided.<br/>
        /// Example: http
        /// </summary>
        /// <example>http</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.RemoteMcpServerTypeJsonConverter))]
        public global::CursorAgents.RemoteMcpServerType? Type { get; set; }

        /// <summary>
        /// HTTP or HTTPS URL for the remote MCP server. Userinfo in the URL is not allowed.<br/>
        /// Example: https://mcp.linear.app/sse
        /// </summary>
        /// <example>https://mcp.linear.app/sse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Headers Cursor sends with every request to the remote MCP server.<br/>
        /// Example: {"Authorization":"Bearer lin_api_..."}
        /// </summary>
        /// <example>{"Authorization":"Bearer lin_api_..."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::CursorAgents.McpAuth? Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteMcpServer" /> class.
        /// </summary>
        /// <param name="name">
        /// MCP server name exposed to the agent.<br/>
        /// Example: linear
        /// </param>
        /// <param name="url">
        /// HTTP or HTTPS URL for the remote MCP server. Userinfo in the URL is not allowed.<br/>
        /// Example: https://mcp.linear.app/sse
        /// </param>
        /// <param name="type">
        /// Remote MCP transport. Defaults to `http` when `url` is provided.<br/>
        /// Example: http
        /// </param>
        /// <param name="headers">
        /// Headers Cursor sends with every request to the remote MCP server.<br/>
        /// Example: {"Authorization":"Bearer lin_api_..."}
        /// </param>
        /// <param name="auth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoteMcpServer(
            string name,
            string url,
            global::CursorAgents.RemoteMcpServerType? type,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::CursorAgents.McpAuth? auth)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteMcpServer" /> class.
        /// </summary>
        public RemoteMcpServer()
        {
        }

    }
}