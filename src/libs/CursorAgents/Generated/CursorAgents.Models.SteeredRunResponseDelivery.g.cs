
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// The agent's running turn accepted the prompt.
    /// </summary>
    public enum SteeredRunResponseDelivery
    {
        /// <summary>
        ///
        /// </summary>
        Steered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SteeredRunResponseDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SteeredRunResponseDelivery value)
        {
            return value switch
            {
                SteeredRunResponseDelivery.Steered => "steered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SteeredRunResponseDelivery? ToEnum(string value)
        {
            return value switch
            {
                "steered" => SteeredRunResponseDelivery.Steered,
                _ => null,
            };
        }
    }
}