
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiKeyInfo
    {
        /// <summary>
        /// Display name of the API key.<br/>
        /// Example: Production API Key
        /// </summary>
        /// <example>Production API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyName { get; set; }

        /// <summary>
        /// When the API key was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Numeric Cursor user ID of the API key's owner. Omitted for service-account / team API keys, which aren't tied to a specific user.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public int? UserId { get; set; }

        /// <summary>
        /// Email of the API key's owner. Omitted for service-account / team API keys.<br/>
        /// Example: developer@example.com
        /// </summary>
        /// <example>developer@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userEmail")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// First name of the API key's owner, when populated.<br/>
        /// Example: Alex
        /// </summary>
        /// <example>Alex</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFirstName")]
        public string? UserFirstName { get; set; }

        /// <summary>
        /// Last name of the API key's owner, when populated.<br/>
        /// Example: Rivera
        /// </summary>
        /// <example>Rivera</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userLastName")]
        public string? UserLastName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyInfo" /> class.
        /// </summary>
        /// <param name="apiKeyName">
        /// Display name of the API key.<br/>
        /// Example: Production API Key
        /// </param>
        /// <param name="createdAt">
        /// When the API key was created.
        /// </param>
        /// <param name="userId">
        /// Numeric Cursor user ID of the API key's owner. Omitted for service-account / team API keys, which aren't tied to a specific user.<br/>
        /// Example: 42
        /// </param>
        /// <param name="userEmail">
        /// Email of the API key's owner. Omitted for service-account / team API keys.<br/>
        /// Example: developer@example.com
        /// </param>
        /// <param name="userFirstName">
        /// First name of the API key's owner, when populated.<br/>
        /// Example: Alex
        /// </param>
        /// <param name="userLastName">
        /// Last name of the API key's owner, when populated.<br/>
        /// Example: Rivera
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyInfo(
            string apiKeyName,
            global::System.DateTime createdAt,
            int? userId,
            string? userEmail,
            string? userFirstName,
            string? userLastName)
        {
            this.ApiKeyName = apiKeyName ?? throw new global::System.ArgumentNullException(nameof(apiKeyName));
            this.CreatedAt = createdAt;
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.UserFirstName = userFirstName;
            this.UserLastName = userLastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyInfo" /> class.
        /// </summary>
        public ApiKeyInfo()
        {
        }

    }
}