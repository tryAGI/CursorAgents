
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelRef
    {
        /// <summary>
        /// Explicit model ID returned by GET /v1/models. Omit `model` from the request to use the configured default.<br/>
        /// Example: composer-2
        /// </summary>
        /// <example>composer-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Per-model parameters such as reasoning effort or max mode. Use only parameters supported by the selected model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<global::CursorAgents.ModelRefParam>? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRef" /> class.
        /// </summary>
        /// <param name="id">
        /// Explicit model ID returned by GET /v1/models. Omit `model` from the request to use the configured default.<br/>
        /// Example: composer-2
        /// </param>
        /// <param name="params">
        /// Per-model parameters such as reasoning effort or max mode. Use only parameters supported by the selected model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelRef(
            string id,
            global::System.Collections.Generic.IList<global::CursorAgents.ModelRefParam>? @params)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRef" /> class.
        /// </summary>
        public ModelRef()
        {
        }

    }
}