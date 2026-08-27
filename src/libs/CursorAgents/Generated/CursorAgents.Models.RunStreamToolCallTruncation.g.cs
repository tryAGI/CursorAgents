
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunStreamToolCallTruncation
    {
        /// <summary>
        /// Present and true when the tool arguments were too large to include in the stream.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public bool? Args { get; set; }

        /// <summary>
        /// Present and true when the tool result was too large to include in the stream.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamToolCallTruncation" /> class.
        /// </summary>
        /// <param name="args">
        /// Present and true when the tool arguments were too large to include in the stream.<br/>
        /// Example: true
        /// </param>
        /// <param name="result">
        /// Present and true when the tool result was too large to include in the stream.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStreamToolCallTruncation(
            bool? args,
            bool? result)
        {
            this.Args = args;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamToolCallTruncation" /> class.
        /// </summary>
        public RunStreamToolCallTruncation()
        {
        }

    }
}