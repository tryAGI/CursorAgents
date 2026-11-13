
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListProjectAgentsResponse
    {
        /// <summary>
        /// Agents your coordinator in the Project started, newest first, up to its 1,000 newest. Agents you can't read are left out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.Agent> Items { get; set; }

        /// <summary>
        /// Cursor for fetching the next page of results. Omitted (not `null`) when there are no more pages.<br/>
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
        /// Initializes a new instance of the <see cref="ListProjectAgentsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Agents your coordinator in the Project started, newest first, up to its 1,000 newest. Agents you can't read are left out.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page of results. Omitted (not `null`) when there are no more pages.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000002
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectAgentsResponse(
            global::System.Collections.Generic.IList<global::CursorAgents.Agent> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAgentsResponse" /> class.
        /// </summary>
        public ListProjectAgentsResponse()
        {
        }

    }
}