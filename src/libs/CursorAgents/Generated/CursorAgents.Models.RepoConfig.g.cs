
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepoConfig
    {
        /// <summary>
        /// GitHub repository URL. Required unless `prUrl` is provided.<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </summary>
        /// <example>https://github.com/your-org/your-repo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Branch, tag, or commit hash to use as the starting point.<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startingRef")]
        public string? StartingRef { get; set; }

        /// <summary>
        /// GitHub pull request URL. When provided, the agent works on this PR's repository and branches; `url` and `startingRef` are ignored.<br/>
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
        /// Initializes a new instance of the <see cref="RepoConfig" /> class.
        /// </summary>
        /// <param name="url">
        /// GitHub repository URL. Required unless `prUrl` is provided.<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </param>
        /// <param name="startingRef">
        /// Branch, tag, or commit hash to use as the starting point.<br/>
        /// Example: main
        /// </param>
        /// <param name="prUrl">
        /// GitHub pull request URL. When provided, the agent works on this PR's repository and branches; `url` and `startingRef` are ignored.<br/>
        /// Example: https://github.com/your-org/your-repo/pull/123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepoConfig(
            string? url,
            string? startingRef,
            string? prUrl)
        {
            this.Url = url;
            this.StartingRef = startingRef;
            this.PrUrl = prUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoConfig" /> class.
        /// </summary>
        public RepoConfig()
        {
        }
    }
}