
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// A steer sends the prompt into the agent's running turn instead of<br/>
    /// starting a new run, and returns `202` with a `SteerRunResponse`.<br/>
    /// It requires `prompt` and `delivery` and accepts no other top-level<br/>
    /// fields. Any other field, such as `model`, `mcpServers`, `envVars`,<br/>
    /// or `mode`, returns `400 validation_error` with a message that<br/>
    /// names the fields, such as<br/>
    /// `"model" is not allowed with delivery "steer"` or<br/>
    /// `"model", "mode" are not allowed with delivery "steer"`.
    /// </summary>
    public sealed partial class SteerRunRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.RunPrompt Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.SteerRunRequestDeliveryJsonConverter))]
        public global::CursorAgents.SteerRunRequestDelivery Delivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SteerRunRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="delivery"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SteerRunRequest(
            global::CursorAgents.RunPrompt prompt,
            global::CursorAgents.SteerRunRequestDelivery delivery)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SteerRunRequest" /> class.
        /// </summary>
        public SteerRunRequest()
        {
        }

    }
}