
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public enum ListEnvironmentBuildsStatus
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
    public static class ListEnvironmentBuildsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEnvironmentBuildsStatus value)
        {
            return value switch
            {
                ListEnvironmentBuildsStatus.Cancelled => "CANCELLED",
                ListEnvironmentBuildsStatus.Failed => "FAILED",
                ListEnvironmentBuildsStatus.InProgress => "IN_PROGRESS",
                ListEnvironmentBuildsStatus.Skipped => "SKIPPED",
                ListEnvironmentBuildsStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEnvironmentBuildsStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListEnvironmentBuildsStatus.Cancelled,
                "FAILED" => ListEnvironmentBuildsStatus.Failed,
                "IN_PROGRESS" => ListEnvironmentBuildsStatus.InProgress,
                "SKIPPED" => ListEnvironmentBuildsStatus.Skipped,
                "SUCCEEDED" => ListEnvironmentBuildsStatus.Succeeded,
                _ => null,
            };
        }
    }
}