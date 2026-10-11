#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// List team secrets<br/>
        /// List the Cloud Agents secrets of the team the API key works in, one<br/>
        /// item per version, sorted by name. No item includes a value. The<br/>
        /// list isn't paginated yet, so `nextCursor` is always `null`.<br/>
        /// Any team member can list, as can the team's service account API<br/>
        /// keys. An API key limited to certain repositories gets<br/>
        /// `403 repository_access`, because team secrets reach every<br/>
        /// repository.<br/>
        /// See https://cursor.com/docs/cloud-agent/api/endpoints#list-team-secrets.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.ListSecretsResponse> ListTeamSecretsAsync(
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List team secrets<br/>
        /// List the Cloud Agents secrets of the team the API key works in, one<br/>
        /// item per version, sorted by name. No item includes a value. The<br/>
        /// list isn't paginated yet, so `nextCursor` is always `null`.<br/>
        /// Any team member can list, as can the team's service account API<br/>
        /// keys. An API key limited to certain repositories gets<br/>
        /// `403 repository_access`, because team secrets reach every<br/>
        /// repository.<br/>
        /// See https://cursor.com/docs/cloud-agent/api/endpoints#list-team-secrets.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.ListSecretsResponse>> ListTeamSecretsAsResponseAsync(
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}