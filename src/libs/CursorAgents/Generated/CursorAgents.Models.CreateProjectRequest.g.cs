
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectRequest
    {
        /// <summary>
        /// The coordinator's first message. When omitted, the coordinator opens the Project with a greeting and waits for your first message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::CursorAgents.CreateProjectRequestPrompt? Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::CursorAgents.ModelRef? Model { get; set; }

        /// <summary>
        /// Display name for the Project.<br/>
        /// Example: Payments migration
        /// </summary>
        /// <example>Payments migration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional client-supplied Project identifier in `bc-&lt;uuid&gt;` form. Re-POSTing the same `projectId` returns `409 project_id_conflict` instead of creating a duplicate. A Project's ID is also its coordinator agent's ID, so an ID that any agent already uses returns the same error. Cannot be combined with `files`; omit `projectId` so the server mints one when you send files.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>bc-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::CursorAgents.AgentEnv? Env { get; set; }

        /// <summary>
        /// Repository configuration, with the same rules as in `CreateAgentRequest`. Mutually exclusive with a named cloud environment. Omit both `repos` and `env` (or pass `repos: []`) to start a no-repo Project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        public global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? Repos { get; set; }

        /// <summary>
        /// The Project's icon and color. Send both `icon` and `color`, or leave `appearance` out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appearance")]
        public global::CursorAgents.ProjectAppearance? Appearance { get; set; }

        /// <summary>
        /// Files to write into the Project's shared context before the<br/>
        /// coordinator's first run. The coordinator and every other agent<br/>
        /// in the Project can read them. At most 256 KiB each and 2 MiB in<br/>
        /// total. Cannot be combined with a client-supplied `projectId`;<br/>
        /// omit `projectId` so the server mints one when you send files.<br/>
        /// Beta: `files` is rolling out. If it isn't enabled for your<br/>
        /// account yet, a request with `files` returns<br/>
        /// `400 files_not_supported`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::CursorAgents.CreateProjectRequestFile>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The coordinator's first message. When omitted, the coordinator opens the Project with a greeting and waits for your first message.
        /// </param>
        /// <param name="model"></param>
        /// <param name="name">
        /// Display name for the Project.<br/>
        /// Example: Payments migration
        /// </param>
        /// <param name="projectId">
        /// Optional client-supplied Project identifier in `bc-&lt;uuid&gt;` form. Re-POSTing the same `projectId` returns `409 project_id_conflict` instead of creating a duplicate. A Project's ID is also its coordinator agent's ID, so an ID that any agent already uses returns the same error. Cannot be combined with `files`; omit `projectId` so the server mints one when you send files.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="env"></param>
        /// <param name="repos">
        /// Repository configuration, with the same rules as in `CreateAgentRequest`. Mutually exclusive with a named cloud environment. Omit both `repos` and `env` (or pass `repos: []`) to start a no-repo Project.
        /// </param>
        /// <param name="appearance">
        /// The Project's icon and color. Send both `icon` and `color`, or leave `appearance` out.
        /// </param>
        /// <param name="files">
        /// Files to write into the Project's shared context before the<br/>
        /// coordinator's first run. The coordinator and every other agent<br/>
        /// in the Project can read them. At most 256 KiB each and 2 MiB in<br/>
        /// total. Cannot be combined with a client-supplied `projectId`;<br/>
        /// omit `projectId` so the server mints one when you send files.<br/>
        /// Beta: `files` is rolling out. If it isn't enabled for your<br/>
        /// account yet, a request with `files` returns<br/>
        /// `400 files_not_supported`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectRequest(
            global::CursorAgents.CreateProjectRequestPrompt? prompt,
            global::CursorAgents.ModelRef? model,
            string? name,
            string? projectId,
            global::CursorAgents.AgentEnv? env,
            global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? repos,
            global::CursorAgents.ProjectAppearance? appearance,
            global::System.Collections.Generic.IList<global::CursorAgents.CreateProjectRequestFile>? files)
        {
            this.Prompt = prompt;
            this.Model = model;
            this.Name = name;
            this.ProjectId = projectId;
            this.Env = env;
            this.Repos = repos;
            this.Appearance = appearance;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequest" /> class.
        /// </summary>
        public CreateProjectRequest()
        {
        }

    }
}