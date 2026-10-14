
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// A secret version with the owner that holds it. Responses never<br/>
    /// include a secret's value.
    /// </summary>
    public sealed partial class InventorySecretVersion
    {
        /// <summary>
        /// The version ID its owner's own list shows.<br/>
        /// Example: secv_3qKx9mT2bV7nR1cW5yZ8aQ
        /// </summary>
        /// <example>secv_3qKx9mT2bV7nR1cW5yZ8aQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Environment variable name agents see.<br/>
        /// Example: NPM_TOKEN
        /// </summary>
        /// <example>NPM_TOKEN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: runtime_secret
        /// </summary>
        /// <example>runtime_secret</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.InventorySecretVersionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.InventorySecretVersionType Type { get; set; }

        /// <summary>
        /// The only repositories that get this version, or empty when every<br/>
        /// repository gets it. Every version has it, including other<br/>
        /// members' versions in a team admin's list.<br/>
        /// Example: [github.com/acme/api]
        /// </summary>
        /// <example>[github.com/acme/api]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Repos { get; set; }

        /// <summary>
        /// When the version was created.<br/>
        /// Example: 2026-10-01T09:15:42.000Z
        /// </summary>
        /// <example>2026-10-01T09:15:42.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Who holds a secret version: `team` for the team the API key works<br/>
        /// in, `user` for a user's personal secrets, or `environment` for an<br/>
        /// environment's secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.SecretInventoryOwner Owner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySecretVersion" /> class.
        /// </summary>
        /// <param name="id">
        /// The version ID its owner's own list shows.<br/>
        /// Example: secv_3qKx9mT2bV7nR1cW5yZ8aQ
        /// </param>
        /// <param name="name">
        /// Environment variable name agents see.<br/>
        /// Example: NPM_TOKEN
        /// </param>
        /// <param name="type">
        /// Example: runtime_secret
        /// </param>
        /// <param name="repos">
        /// The only repositories that get this version, or empty when every<br/>
        /// repository gets it. Every version has it, including other<br/>
        /// members' versions in a team admin's list.<br/>
        /// Example: [github.com/acme/api]
        /// </param>
        /// <param name="createdAt">
        /// When the version was created.<br/>
        /// Example: 2026-10-01T09:15:42.000Z
        /// </param>
        /// <param name="owner">
        /// Who holds a secret version: `team` for the team the API key works<br/>
        /// in, `user` for a user's personal secrets, or `environment` for an<br/>
        /// environment's secrets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InventorySecretVersion(
            string id,
            string name,
            global::CursorAgents.InventorySecretVersionType type,
            global::System.Collections.Generic.IList<string> repos,
            global::System.DateTime createdAt,
            global::CursorAgents.SecretInventoryOwner owner)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Repos = repos ?? throw new global::System.ArgumentNullException(nameof(repos));
            this.CreatedAt = createdAt;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySecretVersion" /> class.
        /// </summary>
        public InventorySecretVersion()
        {
        }

    }
}