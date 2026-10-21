
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Where the build was started from. `SYSTEM` (Cursor on its own), `WEBSITE` (the dashboard), `API`, or `AGENT` (a cloud agent).
    /// </summary>
    public enum EnvironmentBuildSource
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        Website,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentBuildSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentBuildSource value)
        {
            return value switch
            {
                EnvironmentBuildSource.Agent => "AGENT",
                EnvironmentBuildSource.Api => "API",
                EnvironmentBuildSource.System => "SYSTEM",
                EnvironmentBuildSource.Website => "WEBSITE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentBuildSource? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => EnvironmentBuildSource.Agent,
                "API" => EnvironmentBuildSource.Api,
                "SYSTEM" => EnvironmentBuildSource.System,
                "WEBSITE" => EnvironmentBuildSource.Website,
                _ => null,
            };
        }
    }
}