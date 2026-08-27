
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunUsage
    {
        /// <summary>
        /// Run identifier.<br/>
        /// Example: run-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>run-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Internal usage identifier for the run. Omitted when the run has no recorded usage yet.<br/>
        /// Example: 00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageUuid")]
        public string? UsageUuid { get; set; }

        /// <summary>
        /// Token usage for this run. Runs without recorded usage report zeros across all fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.UsageTokenUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunUsage" /> class.
        /// </summary>
        /// <param name="id">
        /// Run identifier.<br/>
        /// Example: run-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="usage">
        /// Token usage for this run. Runs without recorded usage report zeros across all fields.
        /// </param>
        /// <param name="usageUuid">
        /// Internal usage identifier for the run. Omitted when the run has no recorded usage yet.<br/>
        /// Example: 00000000-0000-0000-0000-000000000001
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunUsage(
            string id,
            global::CursorAgents.UsageTokenUsage usage,
            string? usageUuid)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UsageUuid = usageUuid;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunUsage" /> class.
        /// </summary>
        public RunUsage()
        {
        }

    }
}