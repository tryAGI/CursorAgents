
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelParameterDefinition
    {
        /// <summary>
        /// Parameter identifier. Pass as `model.params[].id`.<br/>
        /// Example: fast
        /// </summary>
        /// <example>fast</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable label for the parameter.<br/>
        /// Example: Fast
        /// </summary>
        /// <example>Fast</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Permitted values for this parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.ModelParameterValueDefinition> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParameterDefinition" /> class.
        /// </summary>
        /// <param name="id">
        /// Parameter identifier. Pass as `model.params[].id`.<br/>
        /// Example: fast
        /// </param>
        /// <param name="values">
        /// Permitted values for this parameter.
        /// </param>
        /// <param name="displayName">
        /// Human-readable label for the parameter.<br/>
        /// Example: Fast
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelParameterDefinition(
            string id,
            global::System.Collections.Generic.IList<global::CursorAgents.ModelParameterValueDefinition> values,
            string? displayName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParameterDefinition" /> class.
        /// </summary>
        public ModelParameterDefinition()
        {
        }

    }
}