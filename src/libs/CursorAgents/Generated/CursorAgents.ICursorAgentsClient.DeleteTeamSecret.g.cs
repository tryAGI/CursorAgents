#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Delete a team secret<br/>
        /// Delete one version of a secret from the team the API key works in. This action is irreversible. With `?id=`, the request deletes that version. Without `?id=`, a name with one version has it deleted, a name with no version returns `404 secret_not_found`, and a name with several versions returns `409 secret_name_ambiguous` and deletes nothing. `{name}` must match a listed name exactly, letter case included. Every type can be deleted, Build Secrets included. See https://cursor.com/docs/cloud-agent/api/endpoints#delete-a-team-secret.
        /// </summary>
        /// <param name="id">
        /// Example: secv_Ub4rJ7nD2kX9qM5wL1sE8Q
        /// </param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.DeleteSecretResponse> DeleteTeamSecretAsync(
            string name,
            string? id = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a team secret<br/>
        /// Delete one version of a secret from the team the API key works in. This action is irreversible. With `?id=`, the request deletes that version. Without `?id=`, a name with one version has it deleted, a name with no version returns `404 secret_not_found`, and a name with several versions returns `409 secret_name_ambiguous` and deletes nothing. `{name}` must match a listed name exactly, letter case included. Every type can be deleted, Build Secrets included. See https://cursor.com/docs/cloud-agent/api/endpoints#delete-a-team-secret.
        /// </summary>
        /// <param name="id">
        /// Example: secv_Ub4rJ7nD2kX9qM5wL1sE8Q
        /// </param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.DeleteSecretResponse>> DeleteTeamSecretAsResponseAsync(
            string name,
            string? id = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}