
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListEnvironmentsResponse
    {
        /// <summary>
        /// Environments, most recently updated first. List items omit `environmentJson` and `versionId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.AllOf<global::CursorAgents.Environment, global::CursorAgents.ListEnvironmentsResponseItem>> Items { get; set; }

        /// <summary>
        /// Cursor for fetching the next page of results. A page can hold fewer items than `limit`, so keep paging until it's absent. Omitted (not `null`) when there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvironmentsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Environments, most recently updated first. List items omit `environmentJson` and `versionId`.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page of results. A page can hold fewer items than `limit`, so keep paging until it's absent. Omitted (not `null`) when there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEnvironmentsResponse(
            global::System.Collections.Generic.IList<global::CursorAgents.AllOf<global::CursorAgents.Environment, global::CursorAgents.ListEnvironmentsResponseItem>> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvironmentsResponse" /> class.
        /// </summary>
        public ListEnvironmentsResponse()
        {
        }

    }
}