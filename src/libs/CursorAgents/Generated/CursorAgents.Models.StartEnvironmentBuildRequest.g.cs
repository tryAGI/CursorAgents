
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Send no body, or `{}`, for a non-draft build of every repository's default branch.
    /// </summary>
    public sealed partial class StartEnvironmentBuildRequest
    {
        /// <summary>
        /// `true` for a draft build, which agents don't start from until it's activated. A non-draft build is what agents start from once it succeeds.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// Branches to build instead of the default branches. Repositories without an entry build their default branch, and a ref that names the default branch counts as no entry. Any other branch requires `draft` set to `true`; without it, and for a repository that isn't in the environment or a second ref for the same repository, the request returns `400 validation_error`. Cursor doesn't check that the branch exists, so a missing branch fails the build, not the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refs")]
        public global::System.Collections.Generic.IList<global::CursorAgents.StartEnvironmentBuildRef>? Refs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartEnvironmentBuildRequest" /> class.
        /// </summary>
        /// <param name="draft">
        /// `true` for a draft build, which agents don't start from until it's activated. A non-draft build is what agents start from once it succeeds.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="refs">
        /// Branches to build instead of the default branches. Repositories without an entry build their default branch, and a ref that names the default branch counts as no entry. Any other branch requires `draft` set to `true`; without it, and for a repository that isn't in the environment or a second ref for the same repository, the request returns `400 validation_error`. Cursor doesn't check that the branch exists, so a missing branch fails the build, not the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartEnvironmentBuildRequest(
            bool? draft,
            global::System.Collections.Generic.IList<global::CursorAgents.StartEnvironmentBuildRef>? refs)
        {
            this.Draft = draft;
            this.Refs = refs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartEnvironmentBuildRequest" /> class.
        /// </summary>
        public StartEnvironmentBuildRequest()
        {
        }

    }
}