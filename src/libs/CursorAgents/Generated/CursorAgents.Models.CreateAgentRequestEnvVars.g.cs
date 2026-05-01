
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Session-scoped environment variables for the cloud agent. Values are encrypted at rest, injected into the agent's shell, and deleted with the agent. Names must be non-empty, 1024 bytes or less, and cannot start with `CURSOR_`. Values must be non-empty and 4096 bytes or less.
    /// </summary>
    public sealed partial class CreateAgentRequestEnvVars
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}