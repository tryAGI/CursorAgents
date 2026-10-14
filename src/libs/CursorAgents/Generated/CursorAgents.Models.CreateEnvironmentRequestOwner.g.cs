
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// `personal` creates an environment for the API key's user, and `team` creates one for the team.
    /// </summary>
    public enum CreateEnvironmentRequestOwner
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
    public static class CreateEnvironmentRequestOwnerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnvironmentRequestOwner value)
        {
            return value switch
            {
                CreateEnvironmentRequestOwner.Personal => "personal",
                CreateEnvironmentRequestOwner.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEnvironmentRequestOwner? ToEnum(string value)
        {
            return value switch
            {
                "personal" => CreateEnvironmentRequestOwner.Personal,
                "team" => CreateEnvironmentRequestOwner.Team,
                _ => null,
            };
        }
    }
}