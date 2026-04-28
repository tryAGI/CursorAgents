
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownloadArtifactResponse
    {
        /// <summary>
        /// Temporary 15-minute presigned S3 URL for downloading the artifact.<br/>
        /// Example: https://cloud-agent-artifacts.s3.us-east-1.amazonaws.com/...
        /// </summary>
        /// <example>https://cloud-agent-artifacts.s3.us-east-1.amazonaws.com/...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// When the presigned URL expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadArtifactResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// Temporary 15-minute presigned S3 URL for downloading the artifact.<br/>
        /// Example: https://cloud-agent-artifacts.s3.us-east-1.amazonaws.com/...
        /// </param>
        /// <param name="expiresAt">
        /// When the presigned URL expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownloadArtifactResponse(
            string url,
            global::System.DateTime expiresAt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadArtifactResponse" /> class.
        /// </summary>
        public DownloadArtifactResponse()
        {
        }
    }
}