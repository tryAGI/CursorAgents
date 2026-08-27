
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunStreamToolCallData
    {
        /// <summary>
        /// Stable identifier for one tool invocation across updates.<br/>
        /// Example: call-1
        /// </summary>
        /// <example>call-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Public tool name, such as `read_file`, `run_terminal_cmd`, or `mcp`.<br/>
        /// Example: read_file
        /// </summary>
        /// <example>read_file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tool invocation lifecycle status.<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.RunStreamToolCallDataStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.RunStreamToolCallDataStatus Status { get; set; }

        /// <summary>
        /// Tool-specific JSON arguments, when available.<br/>
        /// Example: {"path":"README.md"}
        /// </summary>
        /// <example>{"path":"README.md"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.JsonValueJsonConverter))]
        public global::CursorAgents.JsonValue? Args { get; set; }

        /// <summary>
        /// Tool-specific JSON result, when available.<br/>
        /// Example: {"success":{"content":"# Project","totalLines":1,"fileSize":9,"path":"README.md"}}
        /// </summary>
        /// <example>{"success":{"content":"# Project","totalLines":1,"fileSize":9,"path":"README.md"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.JsonValueJsonConverter))]
        public global::CursorAgents.JsonValue? Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        public global::CursorAgents.RunStreamToolCallTruncation? Truncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamToolCallData" /> class.
        /// </summary>
        /// <param name="callId">
        /// Stable identifier for one tool invocation across updates.<br/>
        /// Example: call-1
        /// </param>
        /// <param name="name">
        /// Public tool name, such as `read_file`, `run_terminal_cmd`, or `mcp`.<br/>
        /// Example: read_file
        /// </param>
        /// <param name="status">
        /// Tool invocation lifecycle status.<br/>
        /// Example: completed
        /// </param>
        /// <param name="args">
        /// Tool-specific JSON arguments, when available.<br/>
        /// Example: {"path":"README.md"}
        /// </param>
        /// <param name="result">
        /// Tool-specific JSON result, when available.<br/>
        /// Example: {"success":{"content":"# Project","totalLines":1,"fileSize":9,"path":"README.md"}}
        /// </param>
        /// <param name="truncated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStreamToolCallData(
            string callId,
            string name,
            global::CursorAgents.RunStreamToolCallDataStatus status,
            global::CursorAgents.JsonValue? args,
            global::CursorAgents.JsonValue? result,
            global::CursorAgents.RunStreamToolCallTruncation? truncated)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Args = args;
            this.Result = result;
            this.Truncated = truncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamToolCallData" /> class.
        /// </summary>
        public RunStreamToolCallData()
        {
        }

    }
}