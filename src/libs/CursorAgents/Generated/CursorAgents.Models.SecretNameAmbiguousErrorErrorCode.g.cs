
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public enum SecretNameAmbiguousErrorErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        SecretNameAmbiguous,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretNameAmbiguousErrorErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretNameAmbiguousErrorErrorCode value)
        {
            return value switch
            {
                SecretNameAmbiguousErrorErrorCode.SecretNameAmbiguous => "secret_name_ambiguous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretNameAmbiguousErrorErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "secret_name_ambiguous" => SecretNameAmbiguousErrorErrorCode.SecretNameAmbiguous,
                _ => null,
            };
        }
    }
}