
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpAuth
    {
        /// <summary>
        /// OAuth client ID for the MCP server.<br/>
        /// Example: client-id
        /// </summary>
        /// <example>client-id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("CLIENT_ID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// OAuth client secret for the MCP server.<br/>
        /// Example: client-secret
        /// </summary>
        /// <example>client-secret</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("CLIENT_SECRET")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// OAuth scopes to request for the MCP server.<br/>
        /// Example: [file_content:read]
        /// </summary>
        /// <example>[file_content:read]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpAuth" /> class.
        /// </summary>
        /// <param name="clientId">
        /// OAuth client ID for the MCP server.<br/>
        /// Example: client-id
        /// </param>
        /// <param name="clientSecret">
        /// OAuth client secret for the MCP server.<br/>
        /// Example: client-secret
        /// </param>
        /// <param name="scopes">
        /// OAuth scopes to request for the MCP server.<br/>
        /// Example: [file_content:read]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpAuth(
            string clientId,
            string? clientSecret,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpAuth" /> class.
        /// </summary>
        public McpAuth()
        {
        }

    }
}