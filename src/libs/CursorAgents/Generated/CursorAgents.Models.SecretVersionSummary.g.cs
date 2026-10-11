
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretVersionSummary
    {
        /// <summary>
        /// The version's `id`. Pass it as `?id=` to pick this version.<br/>
        /// Example: secv_3qKx9mT2bV7nR1cW5yZ8aQ
        /// </summary>
        /// <example>secv_3qKx9mT2bV7nR1cW5yZ8aQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The only repositories that get this version.<br/>
        /// Example: [github.com/acme/api]
        /// </summary>
        /// <example>[github.com/acme/api]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Repos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretVersionSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The version's `id`. Pass it as `?id=` to pick this version.<br/>
        /// Example: secv_3qKx9mT2bV7nR1cW5yZ8aQ
        /// </param>
        /// <param name="repos">
        /// The only repositories that get this version.<br/>
        /// Example: [github.com/acme/api]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretVersionSummary(
            string id,
            global::System.Collections.Generic.IList<string> repos)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Repos = repos ?? throw new global::System.ArgumentNullException(nameof(repos));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretVersionSummary" /> class.
        /// </summary>
        public SecretVersionSummary()
        {
        }

    }
}