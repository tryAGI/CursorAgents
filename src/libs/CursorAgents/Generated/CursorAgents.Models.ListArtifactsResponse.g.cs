
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListArtifactsResponse
    {
        /// <summary>
        /// Artifacts produced by the agent. Returns at most 100 artifacts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.Artifact> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListArtifactsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Artifacts produced by the agent. Returns at most 100 artifacts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListArtifactsResponse(
            global::System.Collections.Generic.IList<global::CursorAgents.Artifact> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListArtifactsResponse" /> class.
        /// </summary>
        public ListArtifactsResponse()
        {
        }
    }
}