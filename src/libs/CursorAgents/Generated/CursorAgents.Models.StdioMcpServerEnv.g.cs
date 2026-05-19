
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Environment variables passed to the stdio MCP server inside the VM.<br/>
    /// Example: {"GITHUB_TOKEN":"ghp_..."}
    /// </summary>
    public sealed partial class StdioMcpServerEnv
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}