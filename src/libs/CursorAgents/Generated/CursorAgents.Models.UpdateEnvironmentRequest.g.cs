
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Send `name`, `environmentJson`, or both. A request with both applies them together, so either both change or neither does.
    /// </summary>
    public sealed partial class UpdateEnvironmentRequest
    {
        /// <summary>
        /// New display name. It must differ from the names of the owner's other environments; a name the owner already uses returns `409 environment_name_conflict`.<br/>
        /// Example: Web app (staging)
        /// </summary>
        /// <example>Web app (staging)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Replacement `environment.json`, as a JSON-encoded string, using the same schema as a `.cursor/environment.json` file. It replaces the whole configuration. An invalid configuration returns `400 validation_error`.<br/>
        /// Example: {"install": "pnpm install --frozen-lockfile", "start": "sudo service docker start"}
        /// </summary>
        /// <example>{"install": "pnpm install --frozen-lockfile", "start": "sudo service docker start"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentJson")]
        public string? EnvironmentJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New display name. It must differ from the names of the owner's other environments; a name the owner already uses returns `409 environment_name_conflict`.<br/>
        /// Example: Web app (staging)
        /// </param>
        /// <param name="environmentJson">
        /// Replacement `environment.json`, as a JSON-encoded string, using the same schema as a `.cursor/environment.json` file. It replaces the whole configuration. An invalid configuration returns `400 validation_error`.<br/>
        /// Example: {"install": "pnpm install --frozen-lockfile", "start": "sudo service docker start"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnvironmentRequest(
            string? name,
            string? environmentJson)
        {
            this.Name = name;
            this.EnvironmentJson = environmentJson;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentRequest" /> class.
        /// </summary>
        public UpdateEnvironmentRequest()
        {
        }

    }
}