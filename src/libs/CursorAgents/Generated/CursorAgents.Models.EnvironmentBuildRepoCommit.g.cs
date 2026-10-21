
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// The commit a build checked out for one repository.
    /// </summary>
    public sealed partial class EnvironmentBuildRepoCommit
    {
        /// <summary>
        /// Repository URL.<br/>
        /// Example: https://github.com/your-org/your-web-app
        /// </summary>
        /// <example>https://github.com/your-org/your-web-app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoUrl { get; set; }

        /// <summary>
        /// SHA of the commit the build checked out.<br/>
        /// Example: 06b7d943cd0e7ea353ca932d5cdea8987b8e8105
        /// </summary>
        /// <example>06b7d943cd0e7ea353ca932d5cdea8987b8e8105</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitSha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitSha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentBuildRepoCommit" /> class.
        /// </summary>
        /// <param name="repoUrl">
        /// Repository URL.<br/>
        /// Example: https://github.com/your-org/your-web-app
        /// </param>
        /// <param name="commitSha">
        /// SHA of the commit the build checked out.<br/>
        /// Example: 06b7d943cd0e7ea353ca932d5cdea8987b8e8105
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentBuildRepoCommit(
            string repoUrl,
            string commitSha)
        {
            this.RepoUrl = repoUrl ?? throw new global::System.ArgumentNullException(nameof(repoUrl));
            this.CommitSha = commitSha ?? throw new global::System.ArgumentNullException(nameof(commitSha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentBuildRepoCommit" /> class.
        /// </summary>
        public EnvironmentBuildRepoCommit()
        {
        }

    }
}