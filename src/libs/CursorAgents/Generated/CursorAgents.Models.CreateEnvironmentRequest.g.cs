
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateEnvironmentRequest
    {
        /// <summary>
        /// `personal` creates an environment for the API key's user, and `team` creates one for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.CreateEnvironmentRequestOwnerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.CreateEnvironmentRequestOwner Owner { get; set; }

        /// <summary>
        /// Display name. It must differ from the names of the owner's other environments; a name the owner already uses returns `409 environment_name_conflict`.<br/>
        /// Example: Web app
        /// </summary>
        /// <example>Web app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Repositories for the environment, or an empty array for an environment without repositories. Cursor must be able to reach each one through your source control integration; otherwise the request returns `400 repository_access`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentRepo> Repos { get; set; }

        /// <summary>
        /// The environment's `environment.json`, as a JSON-encoded string, using the same schema as a `.cursor/environment.json` file. An invalid configuration returns `400 validation_error`.<br/>
        /// Example: {"install": "pnpm install", "start": "sudo service docker start"}
        /// </summary>
        /// <example>{"install": "pnpm install", "start": "sudo service docker start"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentJson")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequest" /> class.
        /// </summary>
        /// <param name="owner">
        /// `personal` creates an environment for the API key's user, and `team` creates one for the team.
        /// </param>
        /// <param name="name">
        /// Display name. It must differ from the names of the owner's other environments; a name the owner already uses returns `409 environment_name_conflict`.<br/>
        /// Example: Web app
        /// </param>
        /// <param name="repos">
        /// Repositories for the environment, or an empty array for an environment without repositories. Cursor must be able to reach each one through your source control integration; otherwise the request returns `400 repository_access`.
        /// </param>
        /// <param name="environmentJson">
        /// The environment's `environment.json`, as a JSON-encoded string, using the same schema as a `.cursor/environment.json` file. An invalid configuration returns `400 validation_error`.<br/>
        /// Example: {"install": "pnpm install", "start": "sudo service docker start"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEnvironmentRequest(
            global::CursorAgents.CreateEnvironmentRequestOwner owner,
            string name,
            global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentRepo> repos,
            string environmentJson)
        {
            this.Owner = owner;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Repos = repos ?? throw new global::System.ArgumentNullException(nameof(repos));
            this.EnvironmentJson = environmentJson ?? throw new global::System.ArgumentNullException(nameof(environmentJson));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequest" /> class.
        /// </summary>
        public CreateEnvironmentRequest()
        {
        }

    }
}