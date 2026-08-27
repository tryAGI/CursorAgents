
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ErrorError1
    {
        /// <summary>
        /// Machine-readable error code. Possible values include<br/>
        /// `unauthorized`, `api_key_not_found`, `plan_required`,<br/>
        /// `role_forbidden`, `feature_unavailable`,<br/>
        /// `integration_not_connected`, `validation_error`,<br/>
        /// `missing_body`, `invalid_model`, `invalid_branch_name`,<br/>
        /// `repository_required`, `repository_access`,<br/>
        /// `pr_resolution_failed`, `artifact_not_found`,<br/>
        /// `service_account_required`, `agent_not_found`,<br/>
        /// `run_not_found`, `agent_busy`, `agent_archived`,<br/>
        /// `agent_id_conflict`, `run_not_cancellable`,<br/>
        /// `rate_limit_exceeded`, `usage_limit_exceeded`,<br/>
        /// `stream_expired`, `stream_unavailable`,<br/>
        /// `invalid_last_event_id`, `client_cancelled`,<br/>
        /// `not_implemented`, `upstream_error`, and<br/>
        /// `internal_error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Optional follow-up link. Populated for codes like `integration_not_connected`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("helpUrl")]
        public string? HelpUrl { get; set; }

        /// <summary>
        /// Optional provider identifier. Populated for codes like `integration_not_connected`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError1" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable error code. Possible values include<br/>
        /// `unauthorized`, `api_key_not_found`, `plan_required`,<br/>
        /// `role_forbidden`, `feature_unavailable`,<br/>
        /// `integration_not_connected`, `validation_error`,<br/>
        /// `missing_body`, `invalid_model`, `invalid_branch_name`,<br/>
        /// `repository_required`, `repository_access`,<br/>
        /// `pr_resolution_failed`, `artifact_not_found`,<br/>
        /// `service_account_required`, `agent_not_found`,<br/>
        /// `run_not_found`, `agent_busy`, `agent_archived`,<br/>
        /// `agent_id_conflict`, `run_not_cancellable`,<br/>
        /// `rate_limit_exceeded`, `usage_limit_exceeded`,<br/>
        /// `stream_expired`, `stream_unavailable`,<br/>
        /// `invalid_last_event_id`, `client_cancelled`,<br/>
        /// `not_implemented`, `upstream_error`, and<br/>
        /// `internal_error`.
        /// </param>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="helpUrl">
        /// Optional follow-up link. Populated for codes like `integration_not_connected`.
        /// </param>
        /// <param name="provider">
        /// Optional provider identifier. Populated for codes like `integration_not_connected`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorError1(
            string code,
            string message,
            string? helpUrl,
            string? provider)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.HelpUrl = helpUrl;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError1" /> class.
        /// </summary>
        public ErrorError1()
        {
        }

    }
}