
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// No running turn could take the prompt, so it becomes the<br/>
    /// agent's next follow-up. That includes a steer that lands just<br/>
    /// after the agent's run changed. A `queued` response never<br/>
    /// includes `runId`.
    /// </summary>
    public enum QueuedRunResponseDelivery
    {
        /// <summary>
        ///
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueuedRunResponseDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueuedRunResponseDelivery value)
        {
            return value switch
            {
                QueuedRunResponseDelivery.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueuedRunResponseDelivery? ToEnum(string value)
        {
            return value switch
            {
                "queued" => QueuedRunResponseDelivery.Queued,
                _ => null,
            };
        }
    }
}