#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Set a personal secret<br/>
        /// Create a personal secret for the user the API key acts for, rotate its value, or change its type or repositories. With `?id=`, the request changes that version. Without `?id=`, a name with no version gets one (`201`), a name with one version has it changed in place (`200`), and a name with several versions returns `409 secret_name_ambiguous`. A `PUT` never adds a second version to a name that has one, and an omitted `type` or `repos` keeps the current one. Build Secrets can't be set or changed; either returns `400 validation_error`. `DELETE` can remove one. See https://cursor.com/docs/cloud-agent/api/endpoints#set-a-personal-secret.
        /// </summary>
        /// <param name="id">
        /// Example: secv_Pk6nV3yH8rT1wQ4zM9cX2b
        /// </param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.SecretVersion> SetPersonalSecretAsync(
            string name,

            global::CursorAgents.SetSecretRequest request,
            string? id = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a personal secret<br/>
        /// Create a personal secret for the user the API key acts for, rotate its value, or change its type or repositories. With `?id=`, the request changes that version. Without `?id=`, a name with no version gets one (`201`), a name with one version has it changed in place (`200`), and a name with several versions returns `409 secret_name_ambiguous`. A `PUT` never adds a second version to a name that has one, and an omitted `type` or `repos` keeps the current one. Build Secrets can't be set or changed; either returns `400 validation_error`. `DELETE` can remove one. See https://cursor.com/docs/cloud-agent/api/endpoints#set-a-personal-secret.
        /// </summary>
        /// <param name="id">
        /// Example: secv_Pk6nV3yH8rT1wQ4zM9cX2b
        /// </param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.SecretVersion>> SetPersonalSecretAsResponseAsync(
            string name,

            global::CursorAgents.SetSecretRequest request,
            string? id = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a personal secret<br/>
        /// Create a personal secret for the user the API key acts for, rotate its value, or change its type or repositories. With `?id=`, the request changes that version. Without `?id=`, a name with no version gets one (`201`), a name with one version has it changed in place (`200`), and a name with several versions returns `409 secret_name_ambiguous`. A `PUT` never adds a second version to a name that has one, and an omitted `type` or `repos` keeps the current one. Build Secrets can't be set or changed; either returns `400 validation_error`. `DELETE` can remove one. See https://cursor.com/docs/cloud-agent/api/endpoints#set-a-personal-secret.
        /// </summary>
        /// <param name="id">
        /// Example: secv_Pk6nV3yH8rT1wQ4zM9cX2b
        /// </param>
        /// <param name="name"></param>
        /// <param name="value">
        /// The secret's value, 1 to 4,096 bytes of UTF-8 text. No<br/>
        /// response or error message includes it.<br/>
        /// Example: npm_example_token
        /// </param>
        /// <param name="type">
        /// A new version defaults to `runtime_secret`. A change without<br/>
        /// `type` keeps the version's type. Build Secrets can't be set<br/>
        /// through the API yet.<br/>
        /// Example: runtime_secret
        /// </param>
        /// <param name="repos">
        /// The only repositories that get this version, such as<br/>
        /// `acme/api`, `https://github.com/acme/api.git`, or<br/>
        /// `gitlab.com/group/subgroup/project`. An empty array, or<br/>
        /// omitting `repos` on a new version, gives it every repository.<br/>
        /// A change without `repos` keeps the version's repositories.<br/>
        /// Example: [github.com/acme/api]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.SecretVersion> SetPersonalSecretAsync(
            string name,
            string value,
            string? id = default,
            global::CursorAgents.SetSecretRequestType? type = default,
            global::System.Collections.Generic.IList<string>? repos = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}