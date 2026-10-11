
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// `personal` for an environment that belongs to one user, or `team` for an environment shared with the team.
    /// </summary>
    public enum EnvironmentOwner
    {
        /// <summary>
        ///
        /// </summary>
        Personal,
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentOwnerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentOwner value)
        {
            return value switch
            {
                EnvironmentOwner.Personal => "personal",
                EnvironmentOwner.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentOwner? ToEnum(string value)
        {
            return value switch
            {
                "personal" => EnvironmentOwner.Personal,
                "team" => EnvironmentOwner.Team,
                _ => null,
            };
        }
    }
}