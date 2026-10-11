
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvironmentActiveBuildFromUniversalImageType
    {
        /// <summary>
        ///
        /// </summary>
        UniversalImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentActiveBuildFromUniversalImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentActiveBuildFromUniversalImageType value)
        {
            return value switch
            {
                EnvironmentActiveBuildFromUniversalImageType.UniversalImage => "universal_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentActiveBuildFromUniversalImageType? ToEnum(string value)
        {
            return value switch
            {
                "universal_image" => EnvironmentActiveBuildFromUniversalImageType.UniversalImage,
                _ => null,
            };
        }
    }
}