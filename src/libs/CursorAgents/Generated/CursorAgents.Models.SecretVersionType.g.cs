
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// `runtime_secret` for a Runtime Secret, `environment_variable`<br/>
    /// for an Environment Variable, or `build_secret` for a Build<br/>
    /// Secret, which only the Docker build gets.<br/>
    /// Example: runtime_secret
    /// </summary>
    public enum SecretVersionType
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
    public static class SecretVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretVersionType value)
        {
            return value switch
            {
                SecretVersionType.BuildSecret => "build_secret",
                SecretVersionType.EnvironmentVariable => "environment_variable",
                SecretVersionType.RuntimeSecret => "runtime_secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretVersionType? ToEnum(string value)
        {
            return value switch
            {
                "build_secret" => SecretVersionType.BuildSecret,
                "environment_variable" => SecretVersionType.EnvironmentVariable,
                "runtime_secret" => SecretVersionType.RuntimeSecret,
                _ => null,
            };
        }
    }
}