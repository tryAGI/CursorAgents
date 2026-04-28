
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentVariant2
    {
        /// <summary>
        /// Repository configuration. v1 currently supports one entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        public global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? Repos { get; set; }

        /// <summary>
        /// Branch the agent works on.<br/>
        /// Example: cursor/add-readme
        /// </summary>
        /// <example>cursor/add-readme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchName")]
        public string? BranchName { get; set; }

        /// <summary>
        /// Whether the branch was auto-generated.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoGenerateBranch")]
        public bool? AutoGenerateBranch { get; set; }

        /// <summary>
        /// Whether Cursor opens a pull request when the run completes.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoCreatePR")]
        public bool? AutoCreatePR { get; set; }

        /// <summary>
        /// Whether to skip requesting the user as a reviewer when Cursor opens a PR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipReviewerRequest")]
        public bool? SkipReviewerRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVariant2" /> class.
        /// </summary>
        /// <param name="repos">
        /// Repository configuration. v1 currently supports one entry.
        /// </param>
        /// <param name="branchName">
        /// Branch the agent works on.<br/>
        /// Example: cursor/add-readme
        /// </param>
        /// <param name="autoGenerateBranch">
        /// Whether the branch was auto-generated.<br/>
        /// Example: true
        /// </param>
        /// <param name="autoCreatePR">
        /// Whether Cursor opens a pull request when the run completes.<br/>
        /// Example: true
        /// </param>
        /// <param name="skipReviewerRequest">
        /// Whether to skip requesting the user as a reviewer when Cursor opens a PR.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVariant2(
            global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? repos,
            string? branchName,
            bool? autoGenerateBranch,
            bool? autoCreatePR,
            bool? skipReviewerRequest)
        {
            this.Repos = repos;
            this.BranchName = branchName;
            this.AutoGenerateBranch = autoGenerateBranch;
            this.AutoCreatePR = autoCreatePR;
            this.SkipReviewerRequest = skipReviewerRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVariant2" /> class.
        /// </summary>
        public AgentVariant2()
        {
        }
    }
}