
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// The branch, tag, or commit a build was asked to use for one repository.
    /// </summary>
    public sealed partial class EnvironmentBuildRequestedRef
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
        /// Branch, tag, or commit SHA the build was asked to use instead of the repository's default branch.<br/>
        /// Example: feature/new-checkout
        /// </summary>
        /// <example>feature/new-checkout</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentBuildRequestedRef" /> class.
        /// </summary>
        /// <param name="repoUrl">
        /// Repository URL.<br/>
        /// Example: https://github.com/your-org/your-web-app
        /// </param>
        /// <param name="ref">
        /// Branch, tag, or commit SHA the build was asked to use instead of the repository's default branch.<br/>
        /// Example: feature/new-checkout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentBuildRequestedRef(
            string repoUrl,
            string @ref)
        {
            this.RepoUrl = repoUrl ?? throw new global::System.ArgumentNullException(nameof(repoUrl));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentBuildRequestedRef" /> class.
        /// </summary>
        public EnvironmentBuildRequestedRef()
        {
        }

    }
}