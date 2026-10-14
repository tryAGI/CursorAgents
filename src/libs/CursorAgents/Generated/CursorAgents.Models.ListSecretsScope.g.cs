
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public enum ListSecretsScope
    {
        /// <summary>
        ///
        /// </summary>
        Environment,
        /// <summary>
        ///
        /// </summary>
        Members,
        /// <summary>
        ///
        /// </summary>
        Team,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListSecretsScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSecretsScope value)
        {
            return value switch
            {
                ListSecretsScope.Environment => "environment",
                ListSecretsScope.Members => "members",
                ListSecretsScope.Team => "team",
                ListSecretsScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSecretsScope? ToEnum(string value)
        {
            return value switch
            {
                "environment" => ListSecretsScope.Environment,
                "members" => ListSecretsScope.Members,
                "team" => ListSecretsScope.Team,
                "user" => ListSecretsScope.User,
                _ => null,
            };
        }
    }
}