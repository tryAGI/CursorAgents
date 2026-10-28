
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListTeamSecretsResponse
    {
        /// <summary>
        /// The team's secret versions on this page. Without `limit` or<br/>
        /// `cursor`, every version, sorted by name, then repos, then<br/>
        /// creation time. Paged requests return versions in secret-version<br/>
        /// creation order. A name with versions for different repositories<br/>
        /// appears once per version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.AllOf<global::CursorAgents.SecretVersion, object>> Items { get; set; }

        /// <summary>
        /// Cursor for the next page, or `null` after the last page. Always<br/>
        /// `null` without `limit` or `cursor`.<br/>
        /// Example: Tg9xR2pLbW5vcFFyc3R1dnd4eXo0NTY3ODkwYWJjZGVmZ2hp
        /// </summary>
        /// <example>Tg9xR2pLbW5vcFFyc3R1dnd4eXo0NTY3ODkwYWJjZGVmZ2hp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTeamSecretsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// The team's secret versions on this page. Without `limit` or<br/>
        /// `cursor`, every version, sorted by name, then repos, then<br/>
        /// creation time. Paged requests return versions in secret-version<br/>
        /// creation order. A name with versions for different repositories<br/>
        /// appears once per version.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page, or `null` after the last page. Always<br/>
        /// `null` without `limit` or `cursor`.<br/>
        /// Example: Tg9xR2pLbW5vcFFyc3R1dnd4eXo0NTY3ODkwYWJjZGVmZ2hp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTeamSecretsResponse(
            global::System.Collections.Generic.IList<global::CursorAgents.AllOf<global::CursorAgents.SecretVersion, object>> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTeamSecretsResponse" /> class.
        /// </summary>
        public ListTeamSecretsResponse()
        {
        }

    }
}