
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SteerRunResponseDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.SteerRunResponseDiscriminatorDeliveryJsonConverter))]
        public global::CursorAgents.SteerRunResponseDiscriminatorDelivery? Delivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SteerRunResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="delivery"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SteerRunResponseDiscriminator(
            global::CursorAgents.SteerRunResponseDiscriminatorDelivery? delivery)
        {
            this.Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SteerRunResponseDiscriminator" /> class.
        /// </summary>
        public SteerRunResponseDiscriminator()
        {
        }

    }
}