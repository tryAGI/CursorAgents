
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListEnvironmentsResponseItem
    {
        /// <summary>
        /// The file in a repository that an environment reads its configuration from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoFile")]
        public global::CursorAgents.EnvironmentRepoFile? RepoFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvironmentsResponseItem" /> class.
        /// </summary>
        /// <param name="repoFile">
        /// The file in a repository that an environment reads its configuration from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEnvironmentsResponseItem(
            global::CursorAgents.EnvironmentRepoFile? repoFile)
        {
            this.RepoFile = repoFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEnvironmentsResponseItem" /> class.
        /// </summary>
        public ListEnvironmentsResponseItem()
        {
        }

    }
}