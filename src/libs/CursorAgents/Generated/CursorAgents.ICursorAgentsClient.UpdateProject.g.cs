#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Update a Project<br/>
        /// Rename a Project, change its appearance, or both. Only the Project's owner can update it; anyone else gets `403 owner_required`. An archived Project returns `409 project_archived`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateProjectAsync(
            string id,

            global::CursorAgents.UpdateProjectRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Project<br/>
        /// Rename a Project, change its appearance, or both. Only the Project's owner can update it; anyone else gets `403 owner_required`. An archived Project returns `409 project_archived`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse> UpdateProjectAsResponseAsync(
            string id,

            global::CursorAgents.UpdateProjectRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Project<br/>
        /// Rename a Project, change its appearance, or both. Only the Project's owner can update it; anyone else gets `403 owner_required`. An archived Project returns `409 project_archived`.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="name">
        /// New display name.<br/>
        /// Example: Payments migration, phase 2
        /// </param>
        /// <param name="appearance">
        /// New `icon`, `color`, or both. Send one field to change it and keep the other. A Project without an appearance needs both.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateProjectAsync(
            string id,
            string? name = default,
            global::CursorAgents.ProjectAppearance? appearance = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}