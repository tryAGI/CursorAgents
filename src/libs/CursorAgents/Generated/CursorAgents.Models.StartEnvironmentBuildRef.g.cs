
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StartEnvironmentBuildRef
    {
        /// <summary>
        /// One of the environment's repositories.<br/>
        /// Example: https://github.com/your-org/your-web-app
        /// </summary>
        /// <example>https://github.com/your-org/your-web-app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoUrl { get; set; }

        /// <summary>
        /// Branch name to build the repository from.<br/>
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
        /// Initializes a new instance of the <see cref="StartEnvironmentBuildRef" /> class.
        /// </summary>
        /// <param name="repoUrl">
        /// One of the environment's repositories.<br/>
        /// Example: https://github.com/your-org/your-web-app
        /// </param>
        /// <param name="ref">
        /// Branch name to build the repository from.<br/>
        /// Example: feature/new-checkout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartEnvironmentBuildRef(
            string repoUrl,
            string @ref)
        {
            this.RepoUrl = repoUrl ?? throw new global::System.ArgumentNullException(nameof(repoUrl));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartEnvironmentBuildRef" /> class.
        /// </summary>
        public StartEnvironmentBuildRef()
        {
        }

    }
}