
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// The user who owns the secrets, for a `user` owner and a personal<br/>
    /// environment. Absent for the team and its environments.
    /// </summary>
    public sealed partial class SecretInventoryOwnerUser
    {
        /// <summary>
        /// The user's email, or `null` when the user has none on file.<br/>
        /// Example: ada@acme.com
        /// </summary>
        /// <example>ada@acme.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretInventoryOwnerUser" /> class.
        /// </summary>
        /// <param name="email">
        /// The user's email, or `null` when the user has none on file.<br/>
        /// Example: ada@acme.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretInventoryOwnerUser(
            string? email)
        {
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretInventoryOwnerUser" /> class.
        /// </summary>
        public SecretInventoryOwnerUser()
        {
        }

    }
}