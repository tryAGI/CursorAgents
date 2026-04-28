
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyInfo
    {
        /// <summary>
        /// Example: Production API Key
        /// </summary>
        /// <example>Production API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Example: developer@example.com
        /// </summary>
        /// <example>developer@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userEmail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyInfo" /> class.
        /// </summary>
        /// <param name="apiKeyName">
        /// Example: Production API Key
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="userEmail">
        /// Example: developer@example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyInfo(
            string apiKeyName,
            global::System.DateTime createdAt,
            string userEmail)
        {
            this.ApiKeyName = apiKeyName ?? throw new global::System.ArgumentNullException(nameof(apiKeyName));
            this.CreatedAt = createdAt;
            this.UserEmail = userEmail ?? throw new global::System.ArgumentNullException(nameof(userEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyInfo" /> class.
        /// </summary>
        public ApiKeyInfo()
        {
        }
    }
}