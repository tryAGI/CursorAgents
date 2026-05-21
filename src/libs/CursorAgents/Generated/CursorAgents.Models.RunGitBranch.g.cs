
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunGitBranch
    {
        /// <summary>
        /// Repository URL the agent pushed to. Returned without the scheme (for example, `github.com/your-org/your-repo`).<br/>
        /// Example: github.com/your-org/your-repo
        /// </summary>
        /// <example>github.com/your-org/your-repo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoUrl { get; set; }

        /// <summary>
        /// Branch name the agent pushed.<br/>
        /// Example: cursor/add-readme-a1b2
        /// </summary>
        /// <example>cursor/add-readme-a1b2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Pull request URL, when Cursor opened a PR.<br/>
        /// Example: https://github.com/your-org/your-repo/pull/123
        /// </summary>
        /// <example>https://github.com/your-org/your-repo/pull/123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prUrl")]
        public string? PrUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGitBranch" /> class.
        /// </summary>
        /// <param name="repoUrl">
        /// Repository URL the agent pushed to. Returned without the scheme (for example, `github.com/your-org/your-repo`).<br/>
        /// Example: github.com/your-org/your-repo
        /// </param>
        /// <param name="branch">
        /// Branch name the agent pushed.<br/>
        /// Example: cursor/add-readme-a1b2
        /// </param>
        /// <param name="prUrl">
        /// Pull request URL, when Cursor opened a PR.<br/>
        /// Example: https://github.com/your-org/your-repo/pull/123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunGitBranch(
            string repoUrl,
            string? branch,
            string? prUrl)
        {
            this.RepoUrl = repoUrl ?? throw new global::System.ArgumentNullException(nameof(repoUrl));
            this.Branch = branch;
            this.PrUrl = prUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGitBranch" /> class.
        /// </summary>
        public RunGitBranch()
        {
        }

    }
}