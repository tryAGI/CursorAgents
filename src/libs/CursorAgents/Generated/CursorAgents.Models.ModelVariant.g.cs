
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelVariant
    {
        /// <summary>
        /// Concrete parameter values that, combined with the parent model `id`, form a valid model selection. May be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.ModelVariantParam> Params { get; set; }

        /// <summary>
        /// Human-readable label for this variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// True for the variant Cursor selects when the user picks this model without explicit `params`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVariant" /> class.
        /// </summary>
        /// <param name="params">
        /// Concrete parameter values that, combined with the parent model `id`, form a valid model selection. May be empty.
        /// </param>
        /// <param name="displayName">
        /// Human-readable label for this variant.
        /// </param>
        /// <param name="description"></param>
        /// <param name="isDefault">
        /// True for the variant Cursor selects when the user picks this model without explicit `params`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelVariant(
            global::System.Collections.Generic.IList<global::CursorAgents.ModelVariantParam> @params,
            string displayName,
            string? description,
            bool? isDefault)
        {
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVariant" /> class.
        /// </summary>
        public ModelVariant()
        {
        }

    }
}