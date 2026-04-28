
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRunRequestPrompt
    {
        /// <summary>
        /// Follow-up instruction text.<br/>
        /// Example: Also add troubleshooting steps
        /// </summary>
        /// <example>Also add troubleshooting steps</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Optional base64-encoded images. Maximum 5 images, 15 MB each.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::CursorAgents.Image>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunRequestPrompt" /> class.
        /// </summary>
        /// <param name="text">
        /// Follow-up instruction text.<br/>
        /// Example: Also add troubleshooting steps
        /// </param>
        /// <param name="images">
        /// Optional base64-encoded images. Maximum 5 images, 15 MB each.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRunRequestPrompt(
            string text,
            global::System.Collections.Generic.IList<global::CursorAgents.Image>? images)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunRequestPrompt" /> class.
        /// </summary>
        public CreateRunRequestPrompt()
        {
        }
    }
}