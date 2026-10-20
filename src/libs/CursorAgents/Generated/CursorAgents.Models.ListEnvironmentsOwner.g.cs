
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public enum ListEnvironmentsOwner
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
    public static class ListEnvironmentsOwnerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEnvironmentsOwner value)
        {
            return value switch
            {
                ListEnvironmentsOwner.Personal => "personal",
                ListEnvironmentsOwner.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEnvironmentsOwner? ToEnum(string value)
        {
            return value switch
            {
                "personal" => ListEnvironmentsOwner.Personal,
                "team" => ListEnvironmentsOwner.Team,
                _ => null,
            };
        }
    }
}