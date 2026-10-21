
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StartEnvironmentBuildResponse
    {
        /// <summary>
        /// Unique build identifier, in the form `bld-YYYYMMDD-&lt;uuid&gt;`.<br/>
        /// Example: bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f
        /// </summary>
        /// <example>bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Environment ID.<br/>
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </summary>
        /// <example>8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EnvironmentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartEnvironmentBuildResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique build identifier, in the form `bld-YYYYMMDD-&lt;uuid&gt;`.<br/>
        /// Example: bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f
        /// </param>
        /// <param name="environmentId">
        /// Environment ID.<br/>
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartEnvironmentBuildResponse(
            string id,
            global::System.Guid environmentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EnvironmentId = environmentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartEnvironmentBuildResponse" /> class.
        /// </summary>
        public StartEnvironmentBuildResponse()
        {
        }

    }
}