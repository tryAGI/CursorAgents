
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Specify exactly one of `forUserEmail` or `forUserId` to identify the active team member the worker should run as.
    /// </summary>
    public sealed partial class CreateSubTokenRequest
    {
        /// <summary>
        /// Email address of the active team member. Matched case-insensitively. Mutually exclusive with `forUserId`.<br/>
        /// Example: alice@company.com
        /// </summary>
        /// <example>alice@company.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("forUserEmail")]
        public string? ForUserEmail { get; set; }

        /// <summary>
        /// Numeric Cursor user ID of the active team member. Mutually exclusive with `forUserEmail`.<br/>
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
        /// Email address of the active team member. Matched case-insensitively. Mutually exclusive with `forUserId`.<br/>
        /// Example: alice@company.com
        /// </param>
        /// <param name="forUserId">
        /// Numeric Cursor user ID of the active team member. Mutually exclusive with `forUserEmail`.<br/>
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