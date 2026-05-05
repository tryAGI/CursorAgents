
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Provide exactly one active team member identifier.
    /// </summary>
    public sealed partial class CreateSubTokenRequest
    {
        /// <summary>
        /// Active team member email. Case-insensitive. Mutually exclusive with `forUserId`.<br/>
        /// Example: alice@company.com
        /// </summary>
        /// <example>alice@company.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("forUserEmail")]
        public string? ForUserEmail { get; set; }

        /// <summary>
        /// Active team member's numeric Cursor user ID. Mutually exclusive with `forUserEmail`.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("forUserId")]
        public int? ForUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubTokenRequest" /> class.
        /// </summary>
        /// <param name="forUserEmail">
        /// Active team member email. Case-insensitive. Mutually exclusive with `forUserId`.<br/>
        /// Example: alice@company.com
        /// </param>
        /// <param name="forUserId">
        /// Active team member's numeric Cursor user ID. Mutually exclusive with `forUserEmail`.<br/>
        /// Example: 42
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSubTokenRequest(
            string? forUserEmail,
            int? forUserId)
        {
            this.ForUserEmail = forUserEmail;
            this.ForUserId = forUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubTokenRequest" /> class.
        /// </summary>
        public CreateSubTokenRequest()
        {
        }
    }
}