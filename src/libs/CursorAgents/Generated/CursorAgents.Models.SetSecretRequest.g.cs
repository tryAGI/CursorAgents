
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetSecretRequest
    {
        /// <summary>
        /// The secret's value, 1 to 4,096 bytes of UTF-8 text. No<br/>
        /// response or error message includes it.<br/>
        /// Example: npm_example_token
        /// </summary>
        /// <example>npm_example_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// A new version defaults to `runtime_secret`. A change without<br/>
        /// `type` keeps the version's type. Build Secrets can't be set<br/>
        /// through the API yet.<br/>
        /// Example: runtime_secret
        /// </summary>
        /// <example>runtime_secret</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.SetSecretRequestTypeJsonConverter))]
        public global::CursorAgents.SetSecretRequestType? Type { get; set; }

        /// <summary>
        /// The only repositories that get this version, such as<br/>
        /// `acme/api`, `https://github.com/acme/api.git`, or<br/>
        /// `gitlab.com/group/subgroup/project`. An empty array, or<br/>
        /// omitting `repos` on a new version, gives it every repository.<br/>
        /// A change without `repos` keeps the version's repositories.<br/>
        /// Example: [github.com/acme/api]
        /// </summary>
        /// <example>[github.com/acme/api]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        public global::System.Collections.Generic.IList<string>? Repos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetSecretRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetSecretRequest(
            string value,
            global::CursorAgents.SetSecretRequestType? type,
            global::System.Collections.Generic.IList<string>? repos)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
            this.Repos = repos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetSecretRequest" /> class.
        /// </summary>
        public SetSecretRequest()
        {
        }

    }
}