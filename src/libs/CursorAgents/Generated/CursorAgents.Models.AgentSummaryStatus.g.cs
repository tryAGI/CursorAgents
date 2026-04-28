
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Agent lifecycle state. Execution status lives on runs.
    /// </summary>
    public enum AgentSummaryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSummaryStatus value)
        {
            return value switch
            {
                AgentSummaryStatus.Active => "ACTIVE",
                AgentSummaryStatus.Archived => "ARCHIVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => AgentSummaryStatus.Active,
                "ARCHIVED" => AgentSummaryStatus.Archived,
                _ => null,
            };
        }
    }
}