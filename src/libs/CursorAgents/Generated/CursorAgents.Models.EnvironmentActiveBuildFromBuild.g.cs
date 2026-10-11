
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// The agent starts from one of the environment's builds.
    /// </summary>
    public sealed partial class EnvironmentActiveBuildFromBuild
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.EnvironmentActiveBuildFromBuildTypeJsonConverter))]
        public global::CursorAgents.EnvironmentActiveBuildFromBuildType Type { get; set; }

        /// <summary>
        /// Unique build identifier, in the form `bld-YYYYMMDD-&lt;uuid&gt;`.<br/>
        /// Example: bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f
        /// </summary>
        /// <example>bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuildId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentActiveBuildFromBuild" /> class.
        /// </summary>
        /// <param name="buildId">
        /// Unique build identifier, in the form `bld-YYYYMMDD-&lt;uuid&gt;`.<br/>
        /// Example: bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentActiveBuildFromBuild(
            string buildId,
            global::CursorAgents.EnvironmentActiveBuildFromBuildType type)
        {
            this.Type = type;
            this.BuildId = buildId ?? throw new global::System.ArgumentNullException(nameof(buildId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentActiveBuildFromBuild" /> class.
        /// </summary>
        public EnvironmentActiveBuildFromBuild()
        {
        }

    }
}