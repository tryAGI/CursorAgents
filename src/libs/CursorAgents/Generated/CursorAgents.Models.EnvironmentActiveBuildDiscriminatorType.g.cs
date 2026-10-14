
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvironmentActiveBuildDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Build,
        /// <summary>
        ///
        /// </summary>
        UniversalImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentActiveBuildDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentActiveBuildDiscriminatorType value)
        {
            return value switch
            {
                EnvironmentActiveBuildDiscriminatorType.Build => "build",
                EnvironmentActiveBuildDiscriminatorType.UniversalImage => "universal_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentActiveBuildDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "build" => EnvironmentActiveBuildDiscriminatorType.Build,
                "universal_image" => EnvironmentActiveBuildDiscriminatorType.UniversalImage,
                _ => null,
            };
        }
    }
}