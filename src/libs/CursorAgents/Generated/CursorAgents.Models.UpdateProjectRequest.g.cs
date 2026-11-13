
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Send at least one of `name` or `appearance`.
    /// </summary>
    public sealed partial class UpdateProjectRequest
    {
        /// <summary>
        /// New display name.<br/>
        /// Example: Payments migration, phase 2
        /// </summary>
        /// <example>Payments migration, phase 2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New `icon`, `color`, or both. Send one field to change it and keep the other. A Project without an appearance needs both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appearance")]
        public global::CursorAgents.ProjectAppearance? Appearance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New display name.<br/>
        /// Example: Payments migration, phase 2
        /// </param>
        /// <param name="appearance">
        /// New `icon`, `color`, or both. Send one field to change it and keep the other. A Project without an appearance needs both.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequest(
            string? name,
            global::CursorAgents.ProjectAppearance? appearance)
        {
            this.Name = name;
            this.Appearance = appearance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        public UpdateProjectRequest()
        {
        }

    }
}