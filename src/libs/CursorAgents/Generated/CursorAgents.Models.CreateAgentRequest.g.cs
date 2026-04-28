
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.CreateAgentRequestPrompt Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::CursorAgents.ModelRef? Model { get; set; }

        /// <summary>
        /// Repository configuration. v1 currently supports one entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig> Repos { get; set; }

        /// <summary>
        /// Custom branch name for the agent to create.<br/>
        /// Example: feature/add-readme
        /// </summary>
        /// <example>feature/add-readme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchName")]
        public string? BranchName { get; set; }

        /// <summary>
        /// Whether to create a new branch (true) or push to an existing head branch (false). Only applies when `repos[0].prUrl` is provided.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoGenerateBranch")]
        public bool? AutoGenerateBranch { get; set; }

        /// <summary>
        /// Whether Cursor should open a pull request when the run completes.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoCreatePR")]
        public bool? AutoCreatePR { get; set; }

        /// <summary>
        /// Whether to skip requesting the user as a reviewer when Cursor opens a PR. Only applies when `autoCreatePR` is true.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipReviewerRequest")]
        public bool? SkipReviewerRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="repos">
        /// Repository configuration. v1 currently supports one entry.
        /// </param>
        /// <param name="model"></param>
        /// <param name="branchName">
        /// Custom branch name for the agent to create.<br/>
        /// Example: feature/add-readme
        /// </param>
        /// <param name="autoGenerateBranch">
        /// Whether to create a new branch (true) or push to an existing head branch (false). Only applies when `repos[0].prUrl` is provided.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="autoCreatePR">
        /// Whether Cursor should open a pull request when the run completes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="skipReviewerRequest">
        /// Whether to skip requesting the user as a reviewer when Cursor opens a PR. Only applies when `autoCreatePR` is true.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRequest(
            global::CursorAgents.CreateAgentRequestPrompt prompt,
            global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig> repos,
            global::CursorAgents.ModelRef? model,
            string? branchName,
            bool? autoGenerateBranch,
            bool? autoCreatePR,
            bool? skipReviewerRequest)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.Repos = repos ?? throw new global::System.ArgumentNullException(nameof(repos));
            this.BranchName = branchName;
            this.AutoGenerateBranch = autoGenerateBranch;
            this.AutoCreatePR = autoCreatePR;
            this.SkipReviewerRequest = skipReviewerRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        public CreateAgentRequest()
        {
        }
    }
}