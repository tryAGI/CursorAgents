
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Environment variables for this follow-up run only, applied<br/>
    /// while it executes. Names and values follow the same rules as<br/>
    /// `envVars` in `CreateAgentRequest`.
    /// </summary>
    public sealed partial class FollowupRunRequestEnvVars
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}