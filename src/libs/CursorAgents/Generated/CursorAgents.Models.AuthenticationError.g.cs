
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Body of a `401` response when the API key fails authentication.
    /// </summary>
    public sealed partial class AuthenticationError
    {
        /// <summary>
        /// Error category, such as `error`.<br/>
        /// Example: error
        /// </summary>
        /// <example>error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable error message.<br/>
        /// Example: Invalid User API Key
        /// </summary>
        /// <example>Invalid User API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationError" /> class.
        /// </summary>
        /// <param name="code">
        /// Error category, such as `error`.<br/>
        /// Example: error
        /// </param>
        /// <param name="message">
        /// Human-readable error message.<br/>
        /// Example: Invalid User API Key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationError(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationError" /> class.
        /// </summary>
        public AuthenticationError()
        {
        }

    }
}