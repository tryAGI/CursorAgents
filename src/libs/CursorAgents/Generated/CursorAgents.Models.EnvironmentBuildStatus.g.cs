
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Build status. A skipped build found nothing to rebuild.
    /// </summary>
    public enum EnvironmentBuildStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentBuildStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentBuildStatus value)
        {
            return value switch
            {
                EnvironmentBuildStatus.Cancelled => "CANCELLED",
                EnvironmentBuildStatus.Failed => "FAILED",
                EnvironmentBuildStatus.InProgress => "IN_PROGRESS",
                EnvironmentBuildStatus.Skipped => "SKIPPED",
                EnvironmentBuildStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentBuildStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => EnvironmentBuildStatus.Cancelled,
                "FAILED" => EnvironmentBuildStatus.Failed,
                "IN_PROGRESS" => EnvironmentBuildStatus.InProgress,
                "SKIPPED" => EnvironmentBuildStatus.Skipped,
                "SUCCEEDED" => EnvironmentBuildStatus.Succeeded,
                _ => null,
            };
        }
    }
}