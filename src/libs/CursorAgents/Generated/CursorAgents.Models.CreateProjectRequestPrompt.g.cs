
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// The coordinator's first message. When omitted, the coordinator opens the Project with a greeting and waits for your first message.
    /// </summary>
    public sealed partial class CreateProjectRequestPrompt
    {
        /// <summary>
        /// Task instruction for the coordinator.<br/>
        /// Example: Move checkout from the legacy payments client to the new one
        /// </summary>
        /// <example>Move checkout from the legacy payments client to the new one</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Image inputs. Each entry must provide either `data` (with required `mimeType`) or `url`. Maximum 5 images, 15 MB each.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::CursorAgents.Image>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestPrompt" /> class.
        /// </summary>
        /// <param name="text">
        /// Task instruction for the coordinator.<br/>
        /// Example: Move checkout from the legacy payments client to the new one
        /// </param>
        /// <param name="images">
        /// Image inputs. Each entry must provide either `data` (with required `mimeType`) or `url`. Maximum 5 images, 15 MB each.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectRequestPrompt(
            string text,
            global::System.Collections.Generic.IList<global::CursorAgents.Image>? images)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestPrompt" /> class.
        /// </summary>
        public CreateProjectRequestPrompt()
        {
        }

    }
}