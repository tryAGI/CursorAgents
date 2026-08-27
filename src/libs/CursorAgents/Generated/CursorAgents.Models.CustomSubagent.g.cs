
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomSubagent
    {
        /// <summary>
        /// Subagent name. Must be unique within `customSubagents` and cannot collide with built-ins (for example, `explore`, `shell`, `debug`, `computerUse`, `cursorGuide`).<br/>
        /// Example: frontend-reviewer
        /// </summary>
        /// <example>frontend-reviewer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Short summary used by the main agent to decide when to delegate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// System prompt the subagent receives when invoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.CustomSubagentModel?, string, global::CursorAgents.ModelRef>))]
        public global::CursorAgents.OneOf<global::CursorAgents.CustomSubagentModel?, string, global::CursorAgents.ModelRef>? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSubagent" /> class.
        /// </summary>
        /// <param name="name">
        /// Subagent name. Must be unique within `customSubagents` and cannot collide with built-ins (for example, `explore`, `shell`, `debug`, `computerUse`, `cursorGuide`).<br/>
        /// Example: frontend-reviewer
        /// </param>
        /// <param name="description">
        /// Short summary used by the main agent to decide when to delegate.
        /// </param>
        /// <param name="prompt">
        /// System prompt the subagent receives when invoked.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomSubagent(
            string name,
            string description,
            string prompt,
            global::CursorAgents.OneOf<global::CursorAgents.CustomSubagentModel?, string, global::CursorAgents.ModelRef>? model)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSubagent" /> class.
        /// </summary>
        public CustomSubagent()
        {
        }

    }
}