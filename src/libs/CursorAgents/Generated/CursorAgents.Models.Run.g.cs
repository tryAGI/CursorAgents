
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Run
    {
        /// <summary>
        /// Unique run identifier.<br/>
        /// Example: run-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>run-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the agent this run belongs to.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>bc-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Current run status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.RunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.RunStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Wall-clock duration of the run in milliseconds. Populated once the run reaches a terminal status (`FINISHED`, `ERROR`, `CANCELLED`, `EXPIRED`).<br/>
        /// Example: 12357
        /// </summary>
        /// <example>12357</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Final assistant reply text. Populated once the run terminates.<br/>
        /// Example: Added README.md with installation instructions.
        /// </summary>
        /// <example>Added README.md with installation instructions.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// The agent's pushed branches and PRs. Populated once the agent has pushed at least one branch. Per-agent state, not per-run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git")]
        public global::CursorAgents.RunGit? Git { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique run identifier.<br/>
        /// Example: run-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="agentId">
        /// ID of the agent this run belongs to.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="status">
        /// Current run status.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="durationMs">
        /// Wall-clock duration of the run in milliseconds. Populated once the run reaches a terminal status (`FINISHED`, `ERROR`, `CANCELLED`, `EXPIRED`).<br/>
        /// Example: 12357
        /// </param>
        /// <param name="result">
        /// Final assistant reply text. Populated once the run terminates.<br/>
        /// Example: Added README.md with installation instructions.
        /// </param>
        /// <param name="git">
        /// The agent's pushed branches and PRs. Populated once the agent has pushed at least one branch. Per-agent state, not per-run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Run(
            string id,
            string agentId,
            global::CursorAgents.RunStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int? durationMs,
            string? result,
            global::CursorAgents.RunGit? git)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DurationMs = durationMs;
            this.Result = result;
            this.Git = git;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        public Run()
        {
        }

    }
}