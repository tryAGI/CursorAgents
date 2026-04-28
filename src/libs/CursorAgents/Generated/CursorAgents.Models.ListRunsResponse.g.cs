
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListRunsResponse
    {
        /// <summary>
        /// Runs for this agent, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.Run> Items { get; set; }

        /// <summary>
        /// Cursor for fetching the next page of results, or null when there are no more.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRunsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Runs for this agent, newest first.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page of results, or null when there are no more.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListRunsResponse(
            global::System.Collections.Generic.IList<global::CursorAgents.Run> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRunsResponse" /> class.
        /// </summary>
        public ListRunsResponse()
        {
        }
    }
}