
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentEnv
    {
        /// <summary>
        /// Execution environment type. `cloud` uses Cursor-hosted VMs; `pool` and `machine` route to self-hosted workers.<br/>
        /// Example: cloud
        /// </summary>
        /// <example>cloud</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.AgentEnvTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.AgentEnvType Type { get; set; }

        /// <summary>
        /// Named Cursor-hosted environment, self-hosted pool, or self-hosted machine name. For `type: pool`, this is the pool name (defaults to `default` when omitted). Unknown pool names return `400`. Omit `repos` with `type: pool` to target a repo-less pool.<br/>
        /// Example: Release workspace
        /// </summary>
        /// <example>Release workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEnv" /> class.
        /// </summary>
        /// <param name="type">
        /// Execution environment type. `cloud` uses Cursor-hosted VMs; `pool` and `machine` route to self-hosted workers.<br/>
        /// Example: cloud
        /// </param>
        /// <param name="name">
        /// Named Cursor-hosted environment, self-hosted pool, or self-hosted machine name. For `type: pool`, this is the pool name (defaults to `default` when omitted). Unknown pool names return `400`. Omit `repos` with `type: pool` to target a repo-less pool.<br/>
        /// Example: Release workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentEnv(
            global::CursorAgents.AgentEnvType type,
            string? name)
        {
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEnv" /> class.
        /// </summary>
        public AgentEnv()
        {
        }

    }
}