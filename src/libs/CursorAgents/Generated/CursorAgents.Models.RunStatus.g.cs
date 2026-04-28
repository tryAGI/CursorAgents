
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Current run status.
    /// </summary>
    public enum RunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Creating,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Finished,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStatus value)
        {
            return value switch
            {
                RunStatus.Cancelled => "CANCELLED",
                RunStatus.Creating => "CREATING",
                RunStatus.Error => "ERROR",
                RunStatus.Expired => "EXPIRED",
                RunStatus.Finished => "FINISHED",
                RunStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => RunStatus.Cancelled,
                "CREATING" => RunStatus.Creating,
                "ERROR" => RunStatus.Error,
                "EXPIRED" => RunStatus.Expired,
                "FINISHED" => RunStatus.Finished,
                "RUNNING" => RunStatus.Running,
                _ => null,
            };
        }
    }
}