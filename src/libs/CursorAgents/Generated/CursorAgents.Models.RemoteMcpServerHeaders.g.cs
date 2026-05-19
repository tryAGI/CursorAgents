
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Headers Cursor sends with every request to the remote MCP server.<br/>
    /// Example: {"Authorization":"Bearer lin_api_..."}
    /// </summary>
    public sealed partial class RemoteMcpServerHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}