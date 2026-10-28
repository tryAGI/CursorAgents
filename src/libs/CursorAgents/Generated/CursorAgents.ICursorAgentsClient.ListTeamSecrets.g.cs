#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// List team secrets<br/>
        /// List the Cloud Agents secrets of the team the API key works in, one<br/>
        /// item per version. No item includes a value.<br/>
        /// Without `limit` or `cursor`, the response holds every version,<br/>
        /// sorted by name, then repos, then creation time, and `nextCursor`<br/>
        /// is `null`. Send either parameter to page through the versions in<br/>
        /// secret-version creation order, and pass each page's `nextCursor`<br/>
        /// back as `cursor` until it's `null`. Cursors use the same format as<br/>
        /// GET /v1/secrets, so for the same team, a cursor from<br/>
        /// `GET /v1/secrets?scope=team` continues here, and the reverse. Pass<br/>
        /// `nextCursor` back only to the same team's list: cursors aren't tied<br/>
        /// to a team, caller, scope, or filters, so another list's cursor can<br/>
        /// silently skip versions or end the list early.<br/>
        /// Any team member can list, as can the team's service account API<br/>
        /// keys. An API key limited to certain repositories gets<br/>
        /// `403 repository_access`, because team secrets reach every<br/>
        /// repository.<br/>
        /// See https://cursor.com/docs/cloud-agent/api/endpoints#list-team-secrets.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.ListTeamSecretsResponse> ListTeamSecretsAsync(
            int? limit = default,
            string? cursor = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List team secrets<br/>
        /// List the Cloud Agents secrets of the team the API key works in, one<br/>
        /// item per version. No item includes a value.<br/>
        /// Without `limit` or `cursor`, the response holds every version,<br/>
        /// sorted by name, then repos, then creation time, and `nextCursor`<br/>
        /// is `null`. Send either parameter to page through the versions in<br/>
        /// secret-version creation order, and pass each page's `nextCursor`<br/>
        /// back as `cursor` until it's `null`. Cursors use the same format as<br/>
        /// GET /v1/secrets, so for the same team, a cursor from<br/>
        /// `GET /v1/secrets?scope=team` continues here, and the reverse. Pass<br/>
        /// `nextCursor` back only to the same team's list: cursors aren't tied<br/>
        /// to a team, caller, scope, or filters, so another list's cursor can<br/>
        /// silently skip versions or end the list early.<br/>
        /// Any team member can list, as can the team's service account API<br/>
        /// keys. An API key limited to certain repositories gets<br/>
        /// `403 repository_access`, because team secrets reach every<br/>
        /// repository.<br/>
        /// See https://cursor.com/docs/cloud-agent/api/endpoints#list-team-secrets.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.ListTeamSecretsResponse>> ListTeamSecretsAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}