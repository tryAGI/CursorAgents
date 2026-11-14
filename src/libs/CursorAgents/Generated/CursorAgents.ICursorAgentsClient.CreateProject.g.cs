#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Create a Project<br/>
        /// Create a Project and immediately enqueue its initial run, which<br/>
        /// starts the Project's coordinator agent. With a `prompt`, that run<br/>
        /// works on your prompt. The response contains<br/>
        /// both the durable `project` and the initial `run`. Requires a<br/>
        /// user API key; a service account API key returns<br/>
        /// `403 user_required`. To message the coordinator, send a<br/>
        /// follow-up to `project.coordinatorAgentId` with<br/>
        /// POST /v1/agents/{id}/runs, and read its replies with<br/>
        /// GET /v1/agents/{id}/stream.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateProjectResponse> CreateProjectAsync(

            global::CursorAgents.CreateProjectRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Project<br/>
        /// Create a Project and immediately enqueue its initial run, which<br/>
        /// starts the Project's coordinator agent. With a `prompt`, that run<br/>
        /// works on your prompt. The response contains<br/>
        /// both the durable `project` and the initial `run`. Requires a<br/>
        /// user API key; a service account API key returns<br/>
        /// `403 user_required`. To message the coordinator, send a<br/>
        /// follow-up to `project.coordinatorAgentId` with<br/>
        /// POST /v1/agents/{id}/runs, and read its replies with<br/>
        /// GET /v1/agents/{id}/stream.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AutoSDKHttpResponse<global::CursorAgents.CreateProjectResponse>> CreateProjectAsResponseAsync(

            global::CursorAgents.CreateProjectRequest request,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Project<br/>
        /// Create a Project and immediately enqueue its initial run, which<br/>
        /// starts the Project's coordinator agent. With a `prompt`, that run<br/>
        /// works on your prompt. The response contains<br/>
        /// both the durable `project` and the initial `run`. Requires a<br/>
        /// user API key; a service account API key returns<br/>
        /// `403 user_required`. To message the coordinator, send a<br/>
        /// follow-up to `project.coordinatorAgentId` with<br/>
        /// POST /v1/agents/{id}/runs, and read its replies with<br/>
        /// GET /v1/agents/{id}/stream.
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
        /// Optional client-supplied Project identifier in `bc-&lt;uuid&gt;` form. Re-POSTing the same `projectId` returns `409 project_id_conflict` instead of creating a duplicate. A Project's ID is also its coordinator agent's ID, so an ID that any agent already uses returns the same error.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="env"></param>
        /// <param name="repos">
        /// Repository configuration, with the same rules as in `CreateAgentRequest`. Mutually exclusive with a named cloud environment. Omit both `repos` and `env` (or pass `repos: []`) to start a no-repo Project.
        /// </param>
        /// <param name="appearance">
        /// The Project's icon and color. Send both `icon` and `color`, or leave `appearance` out.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.CreateProjectResponse> CreateProjectAsync(
            global::CursorAgents.CreateProjectRequestPrompt? prompt = default,
            global::CursorAgents.ModelRef? model = default,
            string? name = default,
            string? projectId = default,
            global::CursorAgents.AgentEnv? env = default,
            global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? repos = default,
            global::CursorAgents.ProjectAppearance? appearance = default,
            global::CursorAgents.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}