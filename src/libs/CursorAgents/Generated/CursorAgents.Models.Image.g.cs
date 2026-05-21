
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// An image input. Provide exactly one of `data` or `url`. When<br/>
    /// `data` is provided, `mimeType` is required. When `url` is<br/>
    /// provided, Cursor fetches the image and `mimeType` must be<br/>
    /// omitted.
    /// </summary>
    public sealed partial class Image
    {
        /// <summary>
        /// Base64 encoded image bytes (max 15 MB). Mutually exclusive with `url`.<br/>
        /// Example: iVBORw0KGgoAAAANSUhEUgAA...
        /// </summary>
        /// <example>iVBORw0KGgoAAAANSUhEUgAA...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// HTTP or HTTPS URL Cursor fetches. Mutually exclusive with `data`.<br/>
        /// Example: https://example.com/screenshot.png
        /// </summary>
        /// <example>https://example.com/screenshot.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// MIME type of the image bytes. Required when `data` is provided; must be omitted when `url` is provided. Supported types are `image/png`, `image/jpeg`, `image/gif`, and `image/webp`.<br/>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public global::CursorAgents.ImageDimension? Dimension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64 encoded image bytes (max 15 MB). Mutually exclusive with `url`.<br/>
        /// Example: iVBORw0KGgoAAAANSUhEUgAA...
        /// </param>
        /// <param name="url">
        /// HTTP or HTTPS URL Cursor fetches. Mutually exclusive with `data`.<br/>
        /// Example: https://example.com/screenshot.png
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the image bytes. Required when `data` is provided; must be omitted when `url` is provided. Supported types are `image/png`, `image/jpeg`, `image/gif`, and `image/webp`.<br/>
        /// Example: image/png
        /// </param>
        /// <param name="dimension"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Image(
            string? data,
            string? url,
            string? mimeType,
            global::CursorAgents.ImageDimension? dimension)
        {
            this.Data = data;
            this.Url = url;
            this.MimeType = mimeType;
            this.Dimension = dimension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
        {
        }

    }
}