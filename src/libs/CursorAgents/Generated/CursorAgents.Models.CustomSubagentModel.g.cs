
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Use the parent agent's model selection.
    /// </summary>
    public enum CustomSubagentModel
    {
        /// <summary>
        ///
        /// </summary>
        Inherit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomSubagentModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomSubagentModel value)
        {
            return value switch
            {
                CustomSubagentModel.Inherit => "inherit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomSubagentModel? ToEnum(string value)
        {
            return value switch
            {
                "inherit" => CustomSubagentModel.Inherit,
                _ => null,
            };
        }
    }
}