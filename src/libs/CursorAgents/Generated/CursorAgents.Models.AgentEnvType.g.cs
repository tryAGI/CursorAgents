
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Execution environment type. `cloud` uses Cursor-hosted VMs; `pool` and `machine` route to self-hosted workers.<br/>
    /// Example: cloud
    /// </summary>
    public enum AgentEnvType
    {
        /// <summary>
        /// 
        /// </summary>
        Cloud,
        /// <summary>
        /// 
        /// </summary>
        Machine,
        /// <summary>
        /// 
        /// </summary>
        Pool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentEnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentEnvType value)
        {
            return value switch
            {
                AgentEnvType.Cloud => "cloud",
                AgentEnvType.Machine => "machine",
                AgentEnvType.Pool => "pool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentEnvType? ToEnum(string value)
        {
            return value switch
            {
                "cloud" => AgentEnvType.Cloud,
                "machine" => AgentEnvType.Machine,
                "pool" => AgentEnvType.Pool,
                _ => null,
            };
        }
    }
}