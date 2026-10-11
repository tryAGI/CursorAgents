
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Environment
    {
        /// <summary>
        /// Unique environment identifier.<br/>
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </summary>
        /// <example>8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Display name. Omitted when the environment has no name.<br/>
        /// Example: Web app
        /// </summary>
        /// <example>Web app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// `personal` for an environment that belongs to one user, or `team` for an environment shared with the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.EnvironmentOwnerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.EnvironmentOwner Owner { get; set; }

        /// <summary>
        /// Repositories in the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentRepo> Repos { get; set; }

        /// <summary>
        /// When the environment was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the environment was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique environment identifier.<br/>
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="owner">
        /// `personal` for an environment that belongs to one user, or `team` for an environment shared with the team.
        /// </param>
        /// <param name="repos">
        /// Repositories in the environment.
        /// </param>
        /// <param name="createdAt">
        /// When the environment was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the environment was last updated.
        /// </param>
        /// <param name="name">
        /// Display name. Omitted when the environment has no name.<br/>
        /// Example: Web app
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Environment(
            global::System.Guid id,
            global::CursorAgents.EnvironmentOwner owner,
            global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentRepo> repos,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name)
        {
            this.Id = id;
            this.Name = name;
            this.Owner = owner;
            this.Repos = repos ?? throw new global::System.ArgumentNullException(nameof(repos));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        public Environment()
        {
        }

    }
}