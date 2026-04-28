
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSummary
    {
        /// <summary>
        /// Unique agent identifier.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>bc-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Auto-derived agent name.<br/>
        /// Example: Add README with setup instructions
        /// </summary>
        /// <example>Add README with setup instructions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Agent lifecycle state. Execution status lives on runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.AgentSummaryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.AgentSummaryStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.AgentEnv Env { get; set; }

        /// <summary>
        /// URL to view the agent in Cursor Web.<br/>
        /// Example: https://cursor.com/agents?id=bc-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>https://cursor.com/agents?id=bc-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// When the agent was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the agent was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// ID of the most recent run on this agent, if any.<br/>
        /// Example: run-00000000-0000-0000-0000-000000000001
        /// </summary>
        /// <example>run-00000000-0000-0000-0000-000000000001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestRunId")]
        public string? LatestRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique agent identifier.<br/>
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="name">
        /// Auto-derived agent name.<br/>
        /// Example: Add README with setup instructions
        /// </param>
        /// <param name="status">
        /// Agent lifecycle state. Execution status lives on runs.
        /// </param>
        /// <param name="env"></param>
        /// <param name="url">
        /// URL to view the agent in Cursor Web.<br/>
        /// Example: https://cursor.com/agents?id=bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="createdAt">
        /// When the agent was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the agent was last updated.
        /// </param>
        /// <param name="latestRunId">
        /// ID of the most recent run on this agent, if any.<br/>
        /// Example: run-00000000-0000-0000-0000-000000000001
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSummary(
            string id,
            string name,
            global::CursorAgents.AgentSummaryStatus status,
            global::CursorAgents.AgentEnv env,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? latestRunId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LatestRunId = latestRunId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSummary" /> class.
        /// </summary>
        public AgentSummary()
        {
        }
    }
}