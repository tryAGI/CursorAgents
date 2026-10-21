#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Delete a personal secret<br/>
        /// Delete one version of a personal secret of the user the API key acts for. This action is irreversible. With `?id=`, the request deletes that version. Without `?id=`, a name with one version has it deleted, a name with no version returns `404 secret_not_found`, and a name with several versions returns `409 secret_name_ambiguous` and deletes nothing. `{name}` must match a listed name exactly, letter case included. See https://cursor.com/docs/cloud-agent/api/endpoints#delete-a-personal-secret.
        /// </summary>
        /// <param name="id">
        /// Example: secv_Pk6nV3yH8rT1wQ4zM9cX2b
        /// </param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.DeleteSecretResponse> DeletePersonalSecretAsync(
            string name,
            string? id = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a personal secret<br/>
        /// Delete one version of a personal secret of the user the API key acts for. This action is irreversible. With `?id=`, the request deletes that version. Without `?id=`, a name with one version has it deleted, a name with no version returns `404 secret_not_found`, and a name with several versions returns `409 secret_name_ambiguous` and deletes nothing. `{name}` must match a listed name exactly, letter case included. See https://cursor.com/docs/cloud-agent/api/endpoints#delete-a-personal-secret.
        /// </summary>
        /// <param name="id">
        /// Example: secv_Pk6nV3yH8rT1wQ4zM9cX2b
        /// </param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.DeleteSecretResponse>> DeletePersonalSecretAsResponseAsync(
            string name,
            string? id = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}