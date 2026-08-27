
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunStreamToolCallEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.RunStreamToolCallEventEventJsonConverter))]
        public global::CursorAgents.RunStreamToolCallEventEvent Event { get; set; }

        /// <summary>
        /// Opaque SSE event id passed back via `Last-Event-ID` to resume the stream. Do not parse — the format is implementation-defined.<br/>
        /// Example: 1713033006000-0
        /// </summary>
        /// <example>1713033006000-0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.RunStreamToolCallData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamToolCallEvent" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="event"></param>
        /// <param name="id">
        /// Opaque SSE event id passed back via `Last-Event-ID` to resume the stream. Do not parse — the format is implementation-defined.<br/>
        /// Example: 1713033006000-0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStreamToolCallEvent(
            global::CursorAgents.RunStreamToolCallData data,
            global::CursorAgents.RunStreamToolCallEventEvent @event,
            string? id)
        {
            this.Event = @event;
            this.Id = id;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamToolCallEvent" /> class.
        /// </summary>
        public RunStreamToolCallEvent()
        {
        }

    }
}