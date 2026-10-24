
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SteeredRunResponse
    {
        /// <summary>
        /// The agent's running turn accepted the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.SteeredRunResponseDeliveryJsonConverter))]
        public global::CursorAgents.SteeredRunResponseDelivery Delivery { get; set; }

        /// <summary>
        /// The run that accepted the steer, which was running when the API<br/>
        /// got it. The prompt reaches that run at its next safe step unless<br/>
        /// the run ends first, in which case the prompt starts the agent's<br/>
        /// next run. Omitted when the agent had no active run.<br/>
        /// Example: run-00000000-0000-0000-0000-000000000002
        /// </summary>
        /// <example>run-00000000-0000-0000-0000-000000000002</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runId")]
        public string? RunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SteeredRunResponse" /> class.
        /// </summary>
        /// <param name="delivery">
        /// The agent's running turn accepted the prompt.
        /// </param>
        /// <param name="runId">
        /// The run that accepted the steer, which was running when the API<br/>
        /// got it. The prompt reaches that run at its next safe step unless<br/>
        /// the run ends first, in which case the prompt starts the agent's<br/>
        /// next run. Omitted when the agent had no active run.<br/>
        /// Example: run-00000000-0000-0000-0000-000000000002
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SteeredRunResponse(
            global::CursorAgents.SteeredRunResponseDelivery delivery,
            string? runId)
        {
            this.Delivery = delivery;
            this.RunId = runId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SteeredRunResponse" /> class.
        /// </summary>
        public SteeredRunResponse()
        {
        }

    }
}