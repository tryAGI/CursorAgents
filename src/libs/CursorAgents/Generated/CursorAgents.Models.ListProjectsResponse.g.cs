
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListProjectsResponse
    {
        /// <summary>
        /// Projects you own or have joined, newest first by when your own coordinator in each one started. A page can hold fewer than `limit` Projects, or none, while `nextCursor` is still set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.Project> Items { get; set; }

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
        /// Initializes a new instance of the <see cref="ListProjectsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Projects you own or have joined, newest first by when your own coordinator in each one started. A page can hold fewer than `limit` Projects, or none, while `nextCursor` is still set.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page of results. Omitted (not `null`) when there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectsResponse(
            global::System.Collections.Generic.IList<global::CursorAgents.Project> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectsResponse" /> class.
        /// </summary>
        public ListProjectsResponse()
        {
        }

    }
}