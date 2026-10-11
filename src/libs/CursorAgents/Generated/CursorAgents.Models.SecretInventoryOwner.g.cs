
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Who holds a secret version: `team` for the team the API key works<br/>
    /// in, `user` for a user's personal secrets, or `environment` for an<br/>
    /// environment's secrets.
    /// </summary>
    public sealed partial class SecretInventoryOwner
    {
        /// <summary>
        /// Example: environment
        /// </summary>
        /// <example>environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.SecretInventoryOwnerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.SecretInventoryOwnerType Type { get; set; }

        /// <summary>
        /// The environment, for an `environment` owner.<br/>
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </summary>
        /// <example>8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentId")]
        public global::System.Guid? EnvironmentId { get; set; }

        /// <summary>
        /// The user who owns the secrets, for a `user` owner and a personal<br/>
        /// environment. Absent for the team and its environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::CursorAgents.SecretInventoryOwnerUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretInventoryOwner" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: environment
        /// </param>
        /// <param name="environmentId">
        /// The environment, for an `environment` owner.<br/>
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="user">
        /// The user who owns the secrets, for a `user` owner and a personal<br/>
        /// environment. Absent for the team and its environments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretInventoryOwner(
            global::CursorAgents.SecretInventoryOwnerType type,
            global::System.Guid? environmentId,
            global::CursorAgents.SecretInventoryOwnerUser? user)
        {
            this.Type = type;
            this.EnvironmentId = environmentId;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretInventoryOwner" /> class.
        /// </summary>
        public SecretInventoryOwner()
        {
        }

    }
}