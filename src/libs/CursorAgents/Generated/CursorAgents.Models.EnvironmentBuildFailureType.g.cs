
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// `INSTALL_FAILED` when the `install` command failed, or `TERMINAL_FAILURE` for other failures.
    /// </summary>
    public enum EnvironmentBuildFailureType
    {
        /// <summary>
        ///
        /// </summary>
        InstallFailed,
        /// <summary>
        ///
        /// </summary>
        TerminalFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentBuildFailureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentBuildFailureType value)
        {
            return value switch
            {
                EnvironmentBuildFailureType.InstallFailed => "INSTALL_FAILED",
                EnvironmentBuildFailureType.TerminalFailure => "TERMINAL_FAILURE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentBuildFailureType? ToEnum(string value)
        {
            return value switch
            {
                "INSTALL_FAILED" => EnvironmentBuildFailureType.InstallFailed,
                "TERMINAL_FAILURE" => EnvironmentBuildFailureType.TerminalFailure,
                _ => null,
            };
        }
    }
}