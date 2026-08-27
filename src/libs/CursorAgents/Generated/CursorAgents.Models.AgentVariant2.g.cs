
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentVariant2
    {
        /// <summary>
        /// Repository configuration. Empty for no-repo agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        public global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? Repos { get; set; }

        /// <summary>
        /// When `false` (the default), Cursor pushes commits to a new auto-generated branch. When `true`, commits land on the existing head branch.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workOnCurrentBranch")]
        public bool? WorkOnCurrentBranch { get; set; }

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
        /// Custom subagents defined at create time. Omitted when none were provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customSubagents")]
        public global::System.Collections.Generic.IList<global::CursorAgents.CustomSubagent>? CustomSubagents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVariant2" /> class.
        /// </summary>
        /// <param name="repos">
        /// Repository configuration. Empty for no-repo agents.
        /// </param>
        /// <param name="workOnCurrentBranch">
        /// When `false` (the default), Cursor pushes commits to a new auto-generated branch. When `true`, commits land on the existing head branch.<br/>
        /// Example: false
        /// </param>
        /// <param name="autoCreatePR">
        /// Whether Cursor opens a pull request when the run completes.<br/>
        /// Example: true
        /// </param>
        /// <param name="skipReviewerRequest">
        /// Whether to skip requesting the user as a reviewer when Cursor opens a PR.
        /// </param>
        /// <param name="customSubagents">
        /// Custom subagents defined at create time. Omitted when none were provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVariant2(
            global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? repos,
            bool? workOnCurrentBranch,
            bool? autoCreatePR,
            bool? skipReviewerRequest,
            global::System.Collections.Generic.IList<global::CursorAgents.CustomSubagent>? customSubagents)
        {
            this.Repos = repos;
            this.WorkOnCurrentBranch = workOnCurrentBranch;
            this.AutoCreatePR = autoCreatePR;
            this.SkipReviewerRequest = skipReviewerRequest;
            this.CustomSubagents = customSubagents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVariant2" /> class.
        /// </summary>
        public AgentVariant2()
        {
        }

    }
}