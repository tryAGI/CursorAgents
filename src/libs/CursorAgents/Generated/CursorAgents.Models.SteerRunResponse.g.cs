
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SteerRunResponse
    {
        /// <summary>
        /// `steered`: the agent's running turn accepted the prompt and<br/>
        /// takes it at its next safe step. If that turn ends first, the<br/>
        /// prompt starts the agent's next run instead. `queued`: no<br/>
        /// running turn could take the prompt, so it becomes the agent's<br/>
        /// next follow-up. Neither response includes a run ID or any<br/>
        /// other ID to match the prompt to a run.<br/>
        /// Example: steered
        /// </summary>
        /// <example>steered</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.SteerRunResponseDeliveryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.SteerRunResponseDelivery Delivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SteerRunResponse" /> class.
        /// </summary>
        /// <param name="delivery">
        /// `steered`: the agent's running turn accepted the prompt and<br/>
        /// takes it at its next safe step. If that turn ends first, the<br/>
        /// prompt starts the agent's next run instead. `queued`: no<br/>
        /// running turn could take the prompt, so it becomes the agent's<br/>
        /// next follow-up. Neither response includes a run ID or any<br/>
        /// other ID to match the prompt to a run.<br/>
        /// Example: steered
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SteerRunResponse(
            global::CursorAgents.SteerRunResponseDelivery delivery)
        {
            this.Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SteerRunResponse" /> class.
        /// </summary>
        public SteerRunResponse()
        {
        }

    }
}