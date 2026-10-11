
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Example: runtime_secret
    /// </summary>
    public enum InventorySecretVersionType
    {
        /// <summary>
        ///
        /// </summary>
        BuildSecret,
        /// <summary>
        ///
        /// </summary>
        EnvironmentVariable,
        /// <summary>
        ///
        /// </summary>
        RuntimeSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InventorySecretVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InventorySecretVersionType value)
        {
            return value switch
            {
                InventorySecretVersionType.BuildSecret => "build_secret",
                InventorySecretVersionType.EnvironmentVariable => "environment_variable",
                InventorySecretVersionType.RuntimeSecret => "runtime_secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InventorySecretVersionType? ToEnum(string value)
        {
            return value switch
            {
                "build_secret" => InventorySecretVersionType.BuildSecret,
                "environment_variable" => InventorySecretVersionType.EnvironmentVariable,
                "runtime_secret" => InventorySecretVersionType.RuntimeSecret,
                _ => null,
            };
        }
    }
}