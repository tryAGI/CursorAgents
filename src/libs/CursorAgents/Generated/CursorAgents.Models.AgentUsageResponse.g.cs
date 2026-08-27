
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentUsageResponse
    {
        /// <summary>
        /// Token usage summed across the returned runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.UsageTokenUsage TotalUsage { get; set; }

        /// <summary>
        /// Per-run usage, one entry per run (or a single entry when `runId` is set).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.RunUsage> Runs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUsageResponse" /> class.
        /// </summary>
        /// <param name="totalUsage">
        /// Token usage summed across the returned runs.
        /// </param>
        /// <param name="runs">
        /// Per-run usage, one entry per run (or a single entry when `runId` is set).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentUsageResponse(
            global::CursorAgents.UsageTokenUsage totalUsage,
            global::System.Collections.Generic.IList<global::CursorAgents.RunUsage> runs)
        {
            this.TotalUsage = totalUsage ?? throw new global::System.ArgumentNullException(nameof(totalUsage));
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUsageResponse" /> class.
        /// </summary>
        public AgentUsageResponse()
        {
        }

    }
}