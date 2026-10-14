
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// One version of a Cloud Agents secret. A name can have several<br/>
    /// versions in one environment or team, each for repositories the<br/>
    /// others don't cover. Responses never include a secret's value.
    /// </summary>
    public sealed partial class SecretVersion
    {
        /// <summary>
        /// Opaque version ID. A version keeps its `id` through changes to<br/>
        /// its value, type, or repositories. Always present in lists; a<br/>
        /// `201` from a `PUT` leaves it out when the new version isn't<br/>
        /// readable yet.<br/>
        /// Example: secv_3qKx9mT2bV7nR1cW5yZ8aQ
        /// </summary>
        /// <example>secv_3qKx9mT2bV7nR1cW5yZ8aQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Environment variable name agents see.<br/>
        /// Example: NPM_TOKEN
        /// </summary>
        /// <example>NPM_TOKEN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// `runtime_secret` for a Runtime Secret, `environment_variable`<br/>
        /// for an Environment Variable, or `build_secret` for a Build<br/>
        /// Secret, which only the Docker build gets.<br/>
        /// Example: runtime_secret
        /// </summary>
        /// <example>runtime_secret</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.SecretVersionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.SecretVersionType Type { get; set; }

        /// <summary>
        /// The only repositories that get this version, lowercase and<br/>
        /// sorted, with repository URLs reduced to `host/owner/repo`.<br/>
        /// Empty when every repository gets it.<br/>
        /// Example: [github.com/acme/api]
        /// </summary>
        /// <example>[github.com/acme/api]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Repos { get; set; }

        /// <summary>
        /// When the version was created. Always present in lists; a<br/>
        /// `201` from a `PUT` leaves it out when the new version isn't<br/>
        /// readable yet.<br/>
        /// Example: 2026-10-01T09:15:42.000Z
        /// </summary>
        /// <example>2026-10-01T09:15:42.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretVersion" /> class.
        /// </summary>
        /// <param name="name">
        /// Environment variable name agents see.<br/>
        /// Example: NPM_TOKEN
        /// </param>
        /// <param name="type">
        /// `runtime_secret` for a Runtime Secret, `environment_variable`<br/>
        /// for an Environment Variable, or `build_secret` for a Build<br/>
        /// Secret, which only the Docker build gets.<br/>
        /// Example: runtime_secret
        /// </param>
        /// <param name="repos">
        /// The only repositories that get this version, lowercase and<br/>
        /// sorted, with repository URLs reduced to `host/owner/repo`.<br/>
        /// Empty when every repository gets it.<br/>
        /// Example: [github.com/acme/api]
        /// </param>
        /// <param name="id">
        /// Opaque version ID. A version keeps its `id` through changes to<br/>
        /// its value, type, or repositories. Always present in lists; a<br/>
        /// `201` from a `PUT` leaves it out when the new version isn't<br/>
        /// readable yet.<br/>
        /// Example: secv_3qKx9mT2bV7nR1cW5yZ8aQ
        /// </param>
        /// <param name="createdAt">
        /// When the version was created. Always present in lists; a<br/>
        /// `201` from a `PUT` leaves it out when the new version isn't<br/>
        /// readable yet.<br/>
        /// Example: 2026-10-01T09:15:42.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretVersion(
            string name,
            global::CursorAgents.SecretVersionType type,
            global::System.Collections.Generic.IList<string> repos,
            string? id,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Repos = repos ?? throw new global::System.ArgumentNullException(nameof(repos));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretVersion" /> class.
        /// </summary>
        public SecretVersion()
        {
        }

    }
}