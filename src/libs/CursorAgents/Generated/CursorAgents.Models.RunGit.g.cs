
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// The agent's current pushed branches and pull requests. This is<br/>
    /// per-agent state — every run on the same agent returns the same<br/>
    /// `git` snapshot rather than only that run's contributions. Use<br/>
    /// the agent's `latestRunId` or the SSE stream to attribute work<br/>
    /// to a specific run.
    /// </summary>
    public sealed partial class RunGit
    {
        /// <summary>
        /// Branches the agent has pushed. Stacked agents return one entry per branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.RunGitBranch> Branches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGit" /> class.
        /// </summary>
        /// <param name="branches">
        /// Branches the agent has pushed. Stacked agents return one entry per branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunGit(
            global::System.Collections.Generic.IList<global::CursorAgents.RunGitBranch> branches)
        {
            this.Branches = branches ?? throw new global::System.ArgumentNullException(nameof(branches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGit" /> class.
        /// </summary>
        public RunGit()
        {
        }

    }
}