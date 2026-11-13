
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectAppearance
    {
        /// <summary>
        /// Icon name of 1 to 64 letters, numbers, or hyphens.<br/>
        /// Example: rocket
        /// </summary>
        /// <example>rocket</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Icon color.<br/>
        /// Example: blue
        /// </summary>
        /// <example>blue</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.ProjectAppearanceColorJsonConverter))]
        public global::CursorAgents.ProjectAppearanceColor? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAppearance" /> class.
        /// </summary>
        /// <param name="icon">
        /// Icon name of 1 to 64 letters, numbers, or hyphens.<br/>
        /// Example: rocket
        /// </param>
        /// <param name="color">
        /// Icon color.<br/>
        /// Example: blue
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectAppearance(
            string? icon,
            global::CursorAgents.ProjectAppearanceColor? color)
        {
            this.Icon = icon;
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAppearance" /> class.
        /// </summary>
        public ProjectAppearance()
        {
        }

    }
}