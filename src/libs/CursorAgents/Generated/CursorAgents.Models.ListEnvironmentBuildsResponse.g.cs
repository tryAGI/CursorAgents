
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListEnvironmentBuildsResponse
    {
        /// <summary>
        /// Up to 10 builds for this environment, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentBuild> Items { get; set; }

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
        /// Initializes a new instance of the <see cref="ListEnvironmentBuildsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Up to 10 builds for this environment, newest first.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page of results. Omitted (not `null`) when there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEnvironmentBuildsResponse(
            global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentBuild> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvironmentBuildsResponse" /> class.
        /// </summary>
        public ListEnvironmentBuildsResponse()
        {
        }

    }
}