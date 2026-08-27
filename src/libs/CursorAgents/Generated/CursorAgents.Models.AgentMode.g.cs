
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Conversation mode. `plan` explores and drafts a plan before coding; `agent` implements changes directly. On follow-up runs, omit to keep the conversation's current mode; set explicitly to switch modes for that run.
    /// </summary>
    public enum AgentMode
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Plan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentMode value)
        {
            return value switch
            {
                AgentMode.Agent => "agent",
                AgentMode.Plan => "plan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentMode? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AgentMode.Agent,
                "plan" => AgentMode.Plan,
                _ => null,
            };
        }
    }
}