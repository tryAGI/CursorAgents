
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// What started the build. `RECURRING` for a scheduled build, `CONFIG_CHANGE` after a configuration or secrets change, or `MANUAL` for one started on request.
    /// </summary>
    public enum EnvironmentBuildTrigger
    {
        /// <summary>
        ///
        /// </summary>
        ConfigChange,
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        Recurring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentBuildTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentBuildTrigger value)
        {
            return value switch
            {
                EnvironmentBuildTrigger.ConfigChange => "CONFIG_CHANGE",
                EnvironmentBuildTrigger.Manual => "MANUAL",
                EnvironmentBuildTrigger.Recurring => "RECURRING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentBuildTrigger? ToEnum(string value)
        {
            return value switch
            {
                "CONFIG_CHANGE" => EnvironmentBuildTrigger.ConfigChange,
                "MANUAL" => EnvironmentBuildTrigger.Manual,
                "RECURRING" => EnvironmentBuildTrigger.Recurring,
                _ => null,
            };
        }
    }
}