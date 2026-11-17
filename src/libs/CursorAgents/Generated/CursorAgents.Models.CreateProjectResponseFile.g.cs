
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectResponseFile
    {
        /// <summary>
        /// Example: docs/brief.md
        /// </summary>
        /// <example>docs/brief.md</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The file's size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// The stored file's ETag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseFile" /> class.
        /// </summary>
        /// <param name="path">
        /// Example: docs/brief.md
        /// </param>
        /// <param name="sizeBytes">
        /// The file's size in bytes.
        /// </param>
        /// <param name="etag">
        /// The stored file's ETag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponseFile(
            string path,
            long sizeBytes,
            string etag)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.SizeBytes = sizeBytes;
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseFile" /> class.
        /// </summary>
        public CreateProjectResponseFile()
        {
        }

    }
}