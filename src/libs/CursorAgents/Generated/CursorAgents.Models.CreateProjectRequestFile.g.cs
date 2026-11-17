
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Send exactly one of `content` and `contentBase64`.
    /// </summary>
    public sealed partial class CreateProjectRequestFile
    {
        /// <summary>
        /// Where the file goes in the store. At most 512 UTF-8 bytes, and unique within the request. Blank paths (empty or only whitespace) are refused, as are paths that start or end with `/`, have an empty, `.`, or `..` segment, or contain a backslash or control character. Cursor reserves the top-level `inbox/` and `artifacts/` folders and any folder or file name starting with `.cursor`, so paths there are refused too.<br/>
        /// Example: docs/brief.md
        /// </summary>
        /// <example>docs/brief.md</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The file's text, stored as UTF-8.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The file's bytes, base64-encoded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentBase64")]
        public byte[]? ContentBase64 { get; set; }

        /// <summary>
        /// The file's media type. Defaults to `text/plain; charset=utf-8` for `content` and `application/octet-stream` for `contentBase64`.<br/>
        /// Example: text/markdown
        /// </summary>
        /// <example>text/markdown</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestFile" /> class.
        /// </summary>
        /// <param name="path">
        /// Where the file goes in the store. At most 512 UTF-8 bytes, and unique within the request. Blank paths (empty or only whitespace) are refused, as are paths that start or end with `/`, have an empty, `.`, or `..` segment, or contain a backslash or control character. Cursor reserves the top-level `inbox/` and `artifacts/` folders and any folder or file name starting with `.cursor`, so paths there are refused too.<br/>
        /// Example: docs/brief.md
        /// </param>
        /// <param name="content">
        /// The file's text, stored as UTF-8.
        /// </param>
        /// <param name="contentBase64">
        /// The file's bytes, base64-encoded.
        /// </param>
        /// <param name="mimeType">
        /// The file's media type. Defaults to `text/plain; charset=utf-8` for `content` and `application/octet-stream` for `contentBase64`.<br/>
        /// Example: text/markdown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectRequestFile(
            string path,
            string? content,
            byte[]? contentBase64,
            string? mimeType)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Content = content;
            this.ContentBase64 = contentBase64;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestFile" /> class.
        /// </summary>
        public CreateProjectRequestFile()
        {
        }

    }
}