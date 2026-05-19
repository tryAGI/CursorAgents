
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Remote MCP transport. Defaults to `http` when `url` is provided.<br/>
    /// Example: http
    /// </summary>
    public enum RemoteMcpServerType
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
        /// <summary>
        /// 
        /// </summary>
        Sse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoteMcpServerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoteMcpServerType value)
        {
            return value switch
            {
                RemoteMcpServerType.Http => "http",
                RemoteMcpServerType.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoteMcpServerType? ToEnum(string value)
        {
            return value switch
            {
                "http" => RemoteMcpServerType.Http,
                "sse" => RemoteMcpServerType.Sse,
                _ => null,
            };
        }
    }
}