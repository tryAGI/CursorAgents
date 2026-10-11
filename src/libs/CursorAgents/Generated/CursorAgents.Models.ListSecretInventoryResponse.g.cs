
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListSecretInventoryResponse
    {
        /// <summary>
        /// Secret versions with their owners, not sorted by name. Other<br/>
        /// members' versions come after the rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.InventorySecretVersion> Items { get; set; }

        /// <summary>
        /// Cursor for the next page, or `null` on the last page. A page can<br/>
        /// hold fewer than `limit` items, or none, and still have one.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSecretInventoryResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Secret versions with their owners, not sorted by name. Other<br/>
        /// members' versions come after the rest.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page, or `null` on the last page. A page can<br/>
        /// hold fewer than `limit` items, or none, and still have one.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSecretInventoryResponse(
            global::System.Collections.Generic.IList<global::CursorAgents.InventorySecretVersion> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSecretInventoryResponse" /> class.
        /// </summary>
        public ListSecretInventoryResponse()
        {
        }

    }
}