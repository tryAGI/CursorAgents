#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Archive a Project<br/>
        /// Archive a Project. Archived Projects remain readable but cannot be updated until unarchived. Only the Project's owner can archive it; anyone else gets `403 owner_required`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.IdResponse> ArchiveProjectAsync(
            string id,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive a Project<br/>
        /// Archive a Project. Archived Projects remain readable but cannot be updated until unarchived. Only the Project's owner can archive it; anyone else gets `403 owner_required`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.IdResponse>> ArchiveProjectAsResponseAsync(
            string id,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}