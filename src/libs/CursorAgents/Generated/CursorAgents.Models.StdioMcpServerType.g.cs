
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Stdio MCP server. Defaults to `stdio` when `command` is provided.<br/>
    /// Example: stdio
    /// </summary>
    public enum StdioMcpServerType
    {
        /// <summary>
        ///
        /// </summary>
        Stdio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StdioMcpServerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StdioMcpServerType value)
        {
            return value switch
            {
                StdioMcpServerType.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StdioMcpServerType? ToEnum(string value)
        {
            return value switch
            {
                "stdio" => StdioMcpServerType.Stdio,
                _ => null,
            };
        }
    }
}