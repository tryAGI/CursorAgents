
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Session-scoped environment variables for the cloud agent.<br/>
    /// Values are encrypted at rest, injected into the agent's<br/>
    /// shell, and deleted with the agent. Names must be non-empty,<br/>
    /// 255 bytes or less, and cannot start with `CURSOR_`. Values<br/>
    /// must be non-empty and 4096 bytes or less. Cannot be<br/>
    /// combined with a client-supplied `agentId`.<br/>
    /// Beta: `envVars` is rolling out. If it isn't enabled for<br/>
    /// your account yet, the field is silently ignored on create<br/>
    /// rather than failing the request — verify the values are<br/>
    /// present on a first run before relying on them in<br/>
    /// production.
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