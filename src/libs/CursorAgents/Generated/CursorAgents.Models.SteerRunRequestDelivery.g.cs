
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public enum SteerRunRequestDelivery
    {
        /// <summary>
        ///
        /// </summary>
        Steer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SteerRunRequestDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SteerRunRequestDelivery value)
        {
            return value switch
            {
                SteerRunRequestDelivery.Steer => "steer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SteerRunRequestDelivery? ToEnum(string value)
        {
            return value switch
            {
                "steer" => SteerRunRequestDelivery.Steer,
                _ => null,
            };
        }
    }
}