
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// The file in a repository that an environment reads its configuration from.
    /// </summary>
    public sealed partial class EnvironmentRepoFile
    {
        /// <summary>
        /// URL of the repository that holds the configuration file.<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </summary>
        /// <example>https://github.com/your-org/your-repo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Path of the configuration file in the repository.<br/>
        /// Example: .cursor/environment.json
        /// </summary>
        /// <example>.cursor/environment.json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentRepoFile" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the repository that holds the configuration file.<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </param>
        /// <param name="path">
        /// Path of the configuration file in the repository.<br/>
        /// Example: .cursor/environment.json
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentRepoFile(
            string url,
            string path)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentRepoFile" /> class.
        /// </summary>
        public EnvironmentRepoFile()
        {
        }

    }
}