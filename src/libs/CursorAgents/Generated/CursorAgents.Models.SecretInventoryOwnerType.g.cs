
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Example: environment
    /// </summary>
    public enum SecretInventoryOwnerType
    {
        /// <summary>
        ///
        /// </summary>
        Environment,
        /// <summary>
        ///
        /// </summary>
        Team,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretInventoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretInventoryOwnerType value)
        {
            return value switch
            {
                SecretInventoryOwnerType.Environment => "environment",
                SecretInventoryOwnerType.Team => "team",
                SecretInventoryOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretInventoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "environment" => SecretInventoryOwnerType.Environment,
                "team" => SecretInventoryOwnerType.Team,
                "user" => SecretInventoryOwnerType.User,
                _ => null,
            };
        }
    }
}