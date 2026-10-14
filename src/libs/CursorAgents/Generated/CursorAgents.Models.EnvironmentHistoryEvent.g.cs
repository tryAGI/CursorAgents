
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnvironmentHistoryEvent
    {
        /// <summary>
        /// Unique event identifier.<br/>
        /// Example: 3b7e1f2a-9c4d-4e8b-a1f6-5d2c8e9b0a17
        /// </summary>
        /// <example>3b7e1f2a-9c4d-4e8b-a1f6-5d2c8e9b0a17</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When the change was made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.EnvironmentHistoryEventKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.EnvironmentHistoryEventKind Kind { get; set; }

        /// <summary>
        /// The event's summary, as the History tab shows it.<br/>
        /// Example: Team environment updated
        /// </summary>
        /// <example>Team environment updated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The event's details, as the History tab shows them.<br/>
        /// Example: Install script changed.
        /// </summary>
        /// <example>Install script changed.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Where the change came from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.EnvironmentHistoryEventSourceJsonConverter))]
        public global::CursorAgents.EnvironmentHistoryEventSource? Source { get; set; }

        /// <summary>
        /// `true` for the event that saved the environment's current configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Current { get; set; }

        /// <summary>
        /// The `environment.json` the event saved, as a JSON-encoded string.<br/>
        /// Example: {"install": "pnpm install", "start": "sudo service docker start"}
        /// </summary>
        /// <example>{"install": "pnpm install", "start": "sudo service docker start"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentJson")]
        public string? EnvironmentJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentHistoryEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique event identifier.<br/>
        /// Example: 3b7e1f2a-9c4d-4e8b-a1f6-5d2c8e9b0a17
        /// </param>
        /// <param name="createdAt">
        /// When the change was made.
        /// </param>
        /// <param name="kind"></param>
        /// <param name="title">
        /// The event's summary, as the History tab shows it.<br/>
        /// Example: Team environment updated
        /// </param>
        /// <param name="description">
        /// The event's details, as the History tab shows them.<br/>
        /// Example: Install script changed.
        /// </param>
        /// <param name="current">
        /// `true` for the event that saved the environment's current configuration.
        /// </param>
        /// <param name="source">
        /// Where the change came from.
        /// </param>
        /// <param name="environmentJson">
        /// The `environment.json` the event saved, as a JSON-encoded string.<br/>
        /// Example: {"install": "pnpm install", "start": "sudo service docker start"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentHistoryEvent(
            string id,
            global::System.DateTime createdAt,
            global::CursorAgents.EnvironmentHistoryEventKind kind,
            string title,
            string description,
            bool current,
            global::CursorAgents.EnvironmentHistoryEventSource? source,
            string? environmentJson)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Kind = kind;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Source = source;
            this.Current = current;
            this.EnvironmentJson = environmentJson;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentHistoryEvent" /> class.
        /// </summary>
        public EnvironmentHistoryEvent()
        {
        }

    }
}