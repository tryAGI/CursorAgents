
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretNameAmbiguousErrorError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.SecretNameAmbiguousErrorErrorCodeJsonConverter))]
        public global::CursorAgents.SecretNameAmbiguousErrorErrorCode Code { get; set; }

        /// <summary>
        /// Example: NPM_TOKEN has 2 versions, each for different repos. Pass the id of one as ?id= to pick it.
        /// </summary>
        /// <example>NPM_TOKEN has 2 versions, each for different repos. Pass the id of one as ?id= to pick it.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Every version of the name, in list order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.SecretVersionSummary> Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretNameAmbiguousErrorError" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: NPM_TOKEN has 2 versions, each for different repos. Pass the id of one as ?id= to pick it.
        /// </param>
        /// <param name="versions">
        /// Every version of the name, in list order.
        /// </param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretNameAmbiguousErrorError(
            string message,
            global::System.Collections.Generic.IList<global::CursorAgents.SecretVersionSummary> versions,
            global::CursorAgents.SecretNameAmbiguousErrorErrorCode code)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretNameAmbiguousErrorError" /> class.
        /// </summary>
        public SecretNameAmbiguousErrorError()
        {
        }

    }
}