
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Whether agents that start on the default branch pull its latest code. `when_stale`, the default, pulls when the active build is older than `stalenessThresholdHours`. `never` uses the commit the build recorded. `always` is a legacy value you can read but not set.
    /// </summary>
    public enum EnvironmentBuildSettingsPullLatestCode
    {
        /// <summary>
        ///
        /// </summary>
        Always,
        /// <summary>
        ///
        /// </summary>
        Never,
        /// <summary>
        ///
        /// </summary>
        WhenStale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentBuildSettingsPullLatestCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentBuildSettingsPullLatestCode value)
        {
            return value switch
            {
                EnvironmentBuildSettingsPullLatestCode.Always => "always",
                EnvironmentBuildSettingsPullLatestCode.Never => "never",
                EnvironmentBuildSettingsPullLatestCode.WhenStale => "when_stale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentBuildSettingsPullLatestCode? ToEnum(string value)
        {
            return value switch
            {
                "always" => EnvironmentBuildSettingsPullLatestCode.Always,
                "never" => EnvironmentBuildSettingsPullLatestCode.Never,
                "when_stale" => EnvironmentBuildSettingsPullLatestCode.WhenStale,
                _ => null,
            };
        }
    }
}