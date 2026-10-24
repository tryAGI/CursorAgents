
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueuedRunResponse
    {
        /// <summary>
        /// No running turn could take the prompt, so it becomes the<br/>
        /// agent's next follow-up. That includes a steer that lands just<br/>
        /// after the agent's run changed. A `queued` response never<br/>
        /// includes `runId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.QueuedRunResponseDeliveryJsonConverter))]
        public global::CursorAgents.QueuedRunResponseDelivery Delivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedRunResponse" /> class.
        /// </summary>
        /// <param name="delivery">
        /// No running turn could take the prompt, so it becomes the<br/>
        /// agent's next follow-up. That includes a steer that lands just<br/>
        /// after the agent's run changed. A `queued` response never<br/>
        /// includes `runId`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueuedRunResponse(
            global::CursorAgents.QueuedRunResponseDelivery delivery)
        {
            this.Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedRunResponse" /> class.
        /// </summary>
        public QueuedRunResponse()
        {
        }

    }
}