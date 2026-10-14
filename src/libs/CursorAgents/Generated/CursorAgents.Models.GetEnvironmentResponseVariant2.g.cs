
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetEnvironmentResponseVariant2
    {
        /// <summary>
        /// The file in a repository that an environment reads its configuration from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoFile")]
        public global::CursorAgents.EnvironmentRepoFile? RepoFile { get; set; }

        /// <summary>
        /// The environment's latest saved configuration, its `environment.json`, as a JSON-encoded string.<br/>
        /// Example: {"install": "pnpm install", "start": "sudo service docker start"}
        /// </summary>
        /// <example>{"install": "pnpm install", "start": "sudo service docker start"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentJson")]
        public string? EnvironmentJson { get; set; }

        /// <summary>
        /// ID of the latest saved environment version. Omitted when no version has been saved.<br/>
        /// Example: c9f0f895-fb98-4b91-8f3e-2a1b0c9d8e7f
        /// </summary>
        /// <example>c9f0f895-fb98-4b91-8f3e-2a1b0c9d8e7f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEnvironmentResponseVariant2" /> class.
        /// </summary>
        /// <param name="repoFile">
        /// The file in a repository that an environment reads its configuration from.
        /// </param>
        /// <param name="environmentJson">
        /// The environment's latest saved configuration, its `environment.json`, as a JSON-encoded string.<br/>
        /// Example: {"install": "pnpm install", "start": "sudo service docker start"}
        /// </param>
        /// <param name="versionId">
        /// ID of the latest saved environment version. Omitted when no version has been saved.<br/>
        /// Example: c9f0f895-fb98-4b91-8f3e-2a1b0c9d8e7f
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEnvironmentResponseVariant2(
            global::CursorAgents.EnvironmentRepoFile? repoFile,
            string? environmentJson,
            string? versionId)
        {
            this.RepoFile = repoFile;
            this.EnvironmentJson = environmentJson;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEnvironmentResponseVariant2" /> class.
        /// </summary>
        public GetEnvironmentResponseVariant2()
        {
        }

    }
}