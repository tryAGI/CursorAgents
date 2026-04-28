#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Download an artifact<br/>
        /// Retrieve a temporary 15-minute presigned S3 URL for an<br/>
        /// artifact. The `path` query parameter must be a relative path<br/>
        /// under `artifacts/` returned by GET /v1/agents/{id}/artifacts.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="path">
        /// Example: artifacts/screenshot.png
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.DownloadArtifactResponse> DownloadArtifactAsync(
            string id,
            string path,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}