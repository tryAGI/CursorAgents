
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvironmentActiveBuildFromBuildType
    {
        /// <summary>
        ///
        /// </summary>
        Build,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentActiveBuildFromBuildTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentActiveBuildFromBuildType value)
        {
            return value switch
            {
                EnvironmentActiveBuildFromBuildType.Build => "build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentActiveBuildFromBuildType? ToEnum(string value)
        {
            return value switch
            {
                "build" => EnvironmentActiveBuildFromBuildType.Build,
                _ => null,
            };
        }
    }
}