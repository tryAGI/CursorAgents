
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public enum SteerRunResponseDiscriminatorDelivery
    {
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Steered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SteerRunResponseDiscriminatorDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SteerRunResponseDiscriminatorDelivery value)
        {
            return value switch
            {
                SteerRunResponseDiscriminatorDelivery.Queued => "queued",
                SteerRunResponseDiscriminatorDelivery.Steered => "steered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SteerRunResponseDiscriminatorDelivery? ToEnum(string value)
        {
            return value switch
            {
                "queued" => SteerRunResponseDiscriminatorDelivery.Queued,
                "steered" => SteerRunResponseDiscriminatorDelivery.Steered,
                _ => null,
            };
        }
    }
}