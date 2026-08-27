
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Tool invocation lifecycle status.<br/>
    /// Example: completed
    /// </summary>
    public enum RunStreamToolCallDataStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamToolCallDataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamToolCallDataStatus value)
        {
            return value switch
            {
                RunStreamToolCallDataStatus.Completed => "completed",
                RunStreamToolCallDataStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamToolCallDataStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RunStreamToolCallDataStatus.Completed,
                "running" => RunStreamToolCallDataStatus.Running,
                _ => null,
            };
        }
    }
}