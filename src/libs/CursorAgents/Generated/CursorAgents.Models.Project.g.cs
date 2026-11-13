
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// Unique Project identifier. It's also the ID of the owner's coordinator agent.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>bc-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name. Omitted when no name has been set.<br/>
        /// Example: Payments migration
        /// </summary>
        /// <example>Payments migration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Project lifecycle state. `ARCHIVED` when the Project was archived or its owner's coordinator was stopped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.ProjectStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.ProjectStatus Status { get; set; }

        /// <summary>
        /// The Project's icon and color. Omitted when the Project has none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appearance")]
        public global::CursorAgents.ProjectAppearance? Appearance { get; set; }

        /// <summary>
        /// Your own coordinator agent in the Project. The Project's `id` when you own it, or the coordinator Cursor started when you joined. Omitted when you joined the Project and your coordinator there was archived or stopped.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>bc-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinatorAgentId")]
        public string? CoordinatorAgentId { get; set; }

        /// <summary>
        /// When the Project was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the Project was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// URL to view the Project in Cursor Web.<br/>
        /// Example: https://cursor.com/agents/bc-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>https://cursor.com/agents/bc-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique Project identifier. It's also the ID of the owner's coordinator agent.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="status">
        /// Project lifecycle state. `ARCHIVED` when the Project was archived or its owner's coordinator was stopped.
        /// </param>
        /// <param name="createdAt">
        /// When the Project was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the Project was last updated.
        /// </param>
        /// <param name="url">
        /// URL to view the Project in Cursor Web.<br/>
        /// Example: https://cursor.com/agents/bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="name">
        /// Display name. Omitted when no name has been set.<br/>
        /// Example: Payments migration
        /// </param>
        /// <param name="appearance">
        /// The Project's icon and color. Omitted when the Project has none.
        /// </param>
        /// <param name="coordinatorAgentId">
        /// Your own coordinator agent in the Project. The Project's `id` when you own it, or the coordinator Cursor started when you joined. Omitted when you joined the Project and your coordinator there was archived or stopped.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Project(
            string id,
            global::CursorAgents.ProjectStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string url,
            string? name,
            global::CursorAgents.ProjectAppearance? appearance,
            string? coordinatorAgentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Status = status;
            this.Appearance = appearance;
            this.CoordinatorAgentId = coordinatorAgentId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }

    }
}