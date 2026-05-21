
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSubTokenResponse
    {
        /// <summary>
        /// Short-lived access token scoped to the requested user. Pass this to the worker with --auth-token or write it to the file used by --auth-token-file.<br/>
        /// Example: eyJ...
        /// </summary>
        /// <example>eyJ...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// When the access token expires (1 hour after mint).<br/>
        /// Example: 2026-04-24T19:00:00.000Z
        /// </summary>
        /// <example>2026-04-24T19:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Numeric ID of the resolved team member.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// Numeric ID of the service account's team.<br/>
        /// Example: 456
        /// </summary>
        /// <example>456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubTokenResponse" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// Short-lived access token scoped to the requested user. Pass this to the worker with --auth-token or write it to the file used by --auth-token-file.<br/>
        /// Example: eyJ...
        /// </param>
        /// <param name="expiresAt">
        /// When the access token expires (1 hour after mint).<br/>
        /// Example: 2026-04-24T19:00:00.000Z
        /// </param>
        /// <param name="userId">
        /// Numeric ID of the resolved team member.<br/>
        /// Example: 42
        /// </param>
        /// <param name="teamId">
        /// Numeric ID of the service account's team.<br/>
        /// Example: 456
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSubTokenResponse(
            string accessToken,
            global::System.DateTime expiresAt,
            int userId,
            int teamId)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.ExpiresAt = expiresAt;
            this.UserId = userId;
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubTokenResponse" /> class.
        /// </summary>
        public CreateSubTokenResponse()
        {
        }

    }
}