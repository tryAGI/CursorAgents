
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// A new version defaults to `runtime_secret`. A change without<br/>
    /// `type` keeps the version's type. Build Secrets can't be set<br/>
    /// through the API yet.<br/>
    /// Example: runtime_secret
    /// </summary>
    public enum SetSecretRequestType
    {
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
    public static class SetSecretRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetSecretRequestType value)
        {
            return value switch
            {
                SetSecretRequestType.EnvironmentVariable => "environment_variable",
                SetSecretRequestType.RuntimeSecret => "runtime_secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetSecretRequestType? ToEnum(string value)
        {
            return value switch
            {
                "environment_variable" => SetSecretRequestType.EnvironmentVariable,
                "runtime_secret" => SetSecretRequestType.RuntimeSecret,
                _ => null,
            };
        }
    }
}