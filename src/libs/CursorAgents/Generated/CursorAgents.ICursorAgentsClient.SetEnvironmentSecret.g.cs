#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Set an environment secret<br/>
        /// Create an environment secret, rotate its value, or change its type or repositories. With `?id=`, the request changes that version. Without `?id=`, a name with no version gets one (`201`), a name with one version has it changed in place (`200`), and a name with several versions returns `409 secret_name_ambiguous`. A `PUT` never adds a second version to a name that has one, and an omitted `type` or `repos` keeps the current one. Build Secrets can't be set or changed through the API yet. See https://cursor.com/docs/cloud-agent/api/endpoints#set-an-environment-secret.
        /// </summary>
        /// <param name="id">
        /// Example: secv_3qKx9mT2bV7nR1cW5yZ8aQ
        /// </param>
        /// <param name="id2"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.SecretVersion> SetEnvironmentSecretAsync(
            string id2,
            string name,

            global::CursorAgents.SetSecretRequest request,
            string? id = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set an environment secret<br/>
        /// Create an environment secret, rotate its value, or change its type or repositories. With `?id=`, the request changes that version. Without `?id=`, a name with no version gets one (`201`), a name with one version has it changed in place (`200`), and a name with several versions returns `409 secret_name_ambiguous`. A `PUT` never adds a second version to a name that has one, and an omitted `type` or `repos` keeps the current one. Build Secrets can't be set or changed through the API yet. See https://cursor.com/docs/cloud-agent/api/endpoints#set-an-environment-secret.
        /// </summary>
        /// <param name="id">
        /// Example: secv_3qKx9mT2bV7nR1cW5yZ8aQ
        /// </param>
        /// <param name="id2"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.SecretVersion>> SetEnvironmentSecretAsResponseAsync(
            string id2,
            string name,

            global::CursorAgents.SetSecretRequest request,
            string? id = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set an environment secret<br/>
        /// Create an environment secret, rotate its value, or change its type or repositories. With `?id=`, the request changes that version. Without `?id=`, a name with no version gets one (`201`), a name with one version has it changed in place (`200`), and a name with several versions returns `409 secret_name_ambiguous`. A `PUT` never adds a second version to a name that has one, and an omitted `type` or `repos` keeps the current one. Build Secrets can't be set or changed through the API yet. See https://cursor.com/docs/cloud-agent/api/endpoints#set-an-environment-secret.
        /// </summary>
        /// <param name="id">
        /// Example: secv_3qKx9mT2bV7nR1cW5yZ8aQ
        /// </param>
        /// <param name="id2"></param>
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
        global::System.Threading.Tasks.Task<global::CursorAgents.SecretVersion> SetEnvironmentSecretAsync(
            string id2,
            string name,
            string value,
            string? id = default,
            global::CursorAgents.SetSecretRequestType? type = default,
            global::System.Collections.Generic.IList<string>? repos = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}