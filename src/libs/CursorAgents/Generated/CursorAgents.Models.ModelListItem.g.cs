
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelListItem
    {
        /// <summary>
        /// Pass this value as `model.id` when creating an agent.<br/>
        /// Example: composer-2
        /// </summary>
        /// <example>composer-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable model name.<br/>
        /// Example: Composer 2
        /// </summary>
        /// <example>Composer 2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Alternate IDs that resolve to the same model.<br/>
        /// Example: [composer-latest, composer]
        /// </summary>
        /// <example>[composer-latest, composer]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Per-model parameter definitions, when the model accepts parameters. Use these to populate `model.params`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::CursorAgents.ModelParameterDefinition>? Parameters { get; set; }

        /// <summary>
        /// Concrete `id`+`params` combinations the model accepts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        public global::System.Collections.Generic.IList<global::CursorAgents.ModelVariant>? Variants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelListItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Pass this value as `model.id` when creating an agent.<br/>
        /// Example: composer-2
        /// </param>
        /// <param name="displayName">
        /// Human-readable model name.<br/>
        /// Example: Composer 2
        /// </param>
        /// <param name="description"></param>
        /// <param name="aliases">
        /// Alternate IDs that resolve to the same model.<br/>
        /// Example: [composer-latest, composer]
        /// </param>
        /// <param name="parameters">
        /// Per-model parameter definitions, when the model accepts parameters. Use these to populate `model.params`.
        /// </param>
        /// <param name="variants">
        /// Concrete `id`+`params` combinations the model accepts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelListItem(
            string id,
            string displayName,
            string? description,
            global::System.Collections.Generic.IList<string>? aliases,
            global::System.Collections.Generic.IList<global::CursorAgents.ModelParameterDefinition>? parameters,
            global::System.Collections.Generic.IList<global::CursorAgents.ModelVariant>? variants)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description;
            this.Aliases = aliases;
            this.Parameters = parameters;
            this.Variants = variants;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelListItem" /> class.
        /// </summary>
        public ModelListItem()
        {
        }

    }
}