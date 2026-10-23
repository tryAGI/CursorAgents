
#nullable enable

namespace CursorAgents
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
    public enum SteerRunResponseDelivery
    {
        /// <summary>
        /// no
        /// </summary>
        Queued,
        /// <summary>
        /// the agent's running turn accepted the prompt and
        /// </summary>
        Steered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SteerRunResponseDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SteerRunResponseDelivery value)
        {
            return value switch
            {
                SteerRunResponseDelivery.Queued => "queued",
                SteerRunResponseDelivery.Steered => "steered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SteerRunResponseDelivery? ToEnum(string value)
        {
            return value switch
            {
                "queued" => SteerRunResponseDelivery.Queued,
                "steered" => SteerRunResponseDelivery.Steered,
                _ => null,
            };
        }
    }
}