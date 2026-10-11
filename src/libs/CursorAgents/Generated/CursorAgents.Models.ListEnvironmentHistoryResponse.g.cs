
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListEnvironmentHistoryResponse
    {
        /// <summary>
        /// History events, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentHistoryEvent> Items { get; set; }

        /// <summary>
        /// Cursor for fetching the next page of results. Omitted (not `null`) when there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvironmentHistoryResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// History events, newest first.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page of results. Omitted (not `null`) when there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEnvironmentHistoryResponse(
            global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentHistoryEvent> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvironmentHistoryResponse" /> class.
        /// </summary>
        public ListEnvironmentHistoryResponse()
        {
        }

    }
}