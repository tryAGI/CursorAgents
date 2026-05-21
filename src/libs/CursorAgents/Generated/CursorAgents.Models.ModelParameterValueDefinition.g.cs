
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelParameterValueDefinition
    {
        /// <summary>
        /// Permitted value for the parameter.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Human-readable label for the value.<br/>
        /// Example: Fast
        /// </summary>
        /// <example>Fast</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParameterValueDefinition" /> class.
        /// </summary>
        /// <param name="value">
        /// Permitted value for the parameter.<br/>
        /// Example: true
        /// </param>
        /// <param name="displayName">
        /// Human-readable label for the value.<br/>
        /// Example: Fast
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelParameterValueDefinition(
            string value,
            string? displayName)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParameterValueDefinition" /> class.
        /// </summary>
        public ModelParameterValueDefinition()
        {
        }

    }
}