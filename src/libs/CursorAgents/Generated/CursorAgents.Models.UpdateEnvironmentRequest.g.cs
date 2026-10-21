
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Send `name`, `environmentJson`, `repos`, or any combination. `repos` requires `environmentJson`. A request applies every field it sends together, so either all of them change or none do. Send `buildSettings` on its own; a request that also sends `name`, `environmentJson`, or `repos` returns `400 validation_error`.
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
        /// Replacement `environment.json`, as a JSON-encoded string, using the same schema as a `.cursor/environment.json` file. It replaces the whole configuration. An invalid configuration returns `400 validation_error`. If the environment reads its configuration from a file in its only repository, the request returns `409 repo_file_environment_locked`.<br/>
        /// Example: {"install": "pnpm install --frozen-lockfile", "start": "sudo service docker start"}
        /// </summary>
        /// <example>{"install": "pnpm install --frozen-lockfile", "start": "sudo service docker start"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentJson")]
        public string? EnvironmentJson { get; set; }

        /// <summary>
        /// The environment's full list of repositories, replacing the<br/>
        /// current list. It follows the same rules as `repos` on<br/>
        /// POST /v1/environments. Send `environmentJson` with it, because a<br/>
        /// repository change saves the whole configuration; `repos` without<br/>
        /// `environmentJson` returns `400 validation_error`. To keep the<br/>
        /// current configuration, send the `environmentJson` from<br/>
        /// GET /v1/environments/{id}.<br/>
        /// Only environments with two or more repositories can change them,<br/>
        /// and they must keep at least two. Sending the current list<br/>
        /// unchanged doesn't count as a change. Otherwise an environment<br/>
        /// without repositories, a single-repository environment, or a list<br/>
        /// with fewer than two returns `409 environment_repo_edit_blocked`.<br/>
        /// When the environment reads its configuration from a repository<br/>
        /// file (`repoFile` on GET /v1/environments/{id}), the file stays the<br/>
        /// configuration source. The list must keep the `repoFile.url`<br/>
        /// repository, or the request returns `409 repo_file_repo_removed`.<br/>
        /// Repositories are compared by identity, so a trailing `.git` or<br/>
        /// slash, a missing scheme, a leading `www.`, or GitHub letter case<br/>
        /// still match. When the list names that repository in several forms,<br/>
        /// the first entry is kept and the others dropped. For Bitbucket<br/>
        /// Server, send the URL GET returns. An environment whose<br/>
        /// only repository holds its configuration file returns<br/>
        /// `409 repo_file_environment_locked` for any `repos`. Stored<br/>
        /// repositories Cursor can't read return<br/>
        /// `400 stored_repos_unreadable`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        public global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentRepo>? Repos { get; set; }

        /// <summary>
        /// New values for any of the build settings GET /v1/environments/{id} returns. Fields you leave out stay unchanged, and `null` resets a field to its default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildSettings")]
        public global::CursorAgents.UpdateEnvironmentBuildSettings? BuildSettings { get; set; }

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
        /// Replacement `environment.json`, as a JSON-encoded string, using the same schema as a `.cursor/environment.json` file. It replaces the whole configuration. An invalid configuration returns `400 validation_error`. If the environment reads its configuration from a file in its only repository, the request returns `409 repo_file_environment_locked`.<br/>
        /// Example: {"install": "pnpm install --frozen-lockfile", "start": "sudo service docker start"}
        /// </param>
        /// <param name="repos">
        /// The environment's full list of repositories, replacing the<br/>
        /// current list. It follows the same rules as `repos` on<br/>
        /// POST /v1/environments. Send `environmentJson` with it, because a<br/>
        /// repository change saves the whole configuration; `repos` without<br/>
        /// `environmentJson` returns `400 validation_error`. To keep the<br/>
        /// current configuration, send the `environmentJson` from<br/>
        /// GET /v1/environments/{id}.<br/>
        /// Only environments with two or more repositories can change them,<br/>
        /// and they must keep at least two. Sending the current list<br/>
        /// unchanged doesn't count as a change. Otherwise an environment<br/>
        /// without repositories, a single-repository environment, or a list<br/>
        /// with fewer than two returns `409 environment_repo_edit_blocked`.<br/>
        /// When the environment reads its configuration from a repository<br/>
        /// file (`repoFile` on GET /v1/environments/{id}), the file stays the<br/>
        /// configuration source. The list must keep the `repoFile.url`<br/>
        /// repository, or the request returns `409 repo_file_repo_removed`.<br/>
        /// Repositories are compared by identity, so a trailing `.git` or<br/>
        /// slash, a missing scheme, a leading `www.`, or GitHub letter case<br/>
        /// still match. When the list names that repository in several forms,<br/>
        /// the first entry is kept and the others dropped. For Bitbucket<br/>
        /// Server, send the URL GET returns. An environment whose<br/>
        /// only repository holds its configuration file returns<br/>
        /// `409 repo_file_environment_locked` for any `repos`. Stored<br/>
        /// repositories Cursor can't read return<br/>
        /// `400 stored_repos_unreadable`.
        /// </param>
        /// <param name="buildSettings">
        /// New values for any of the build settings GET /v1/environments/{id} returns. Fields you leave out stay unchanged, and `null` resets a field to its default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnvironmentRequest(
            string? name,
            string? environmentJson,
            global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentRepo>? repos,
            global::CursorAgents.UpdateEnvironmentBuildSettings? buildSettings)
        {
            this.Name = name;
            this.EnvironmentJson = environmentJson;
            this.Repos = repos;
            this.BuildSettings = buildSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentRequest" /> class.
        /// </summary>
        public UpdateEnvironmentRequest()
        {
        }

    }
}