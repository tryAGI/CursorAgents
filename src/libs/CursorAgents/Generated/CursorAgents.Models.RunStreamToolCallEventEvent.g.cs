
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStreamToolCallEventEvent
    {
        /// <summary>
        /// 
        /// </summary>
        ToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamToolCallEventEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamToolCallEventEvent value)
        {
            return value switch
            {
                RunStreamToolCallEventEvent.ToolCall => "tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamToolCallEventEvent? ToEnum(string value)
        {
            return value switch
            {
                "tool_call" => RunStreamToolCallEventEvent.ToolCall,
                _ => null,
            };
        }
    }
}