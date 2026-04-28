
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentsResponse
    {
        /// <summary>
        /// Agents, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.AgentSummary> Items { get; set; }

        /// <summary>
        /// Cursor for fetching the next page of results, or null when there are no more.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000002
        /// </summary>
        /// <example>bc-00000000-0000-0000-0000-000000000002</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Agents, newest first.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page of results, or null when there are no more.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000002
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentsResponse(
            global::System.Collections.Generic.IList<global::CursorAgents.AgentSummary> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponse" /> class.
        /// </summary>
        public ListAgentsResponse()
        {
        }
    }
}