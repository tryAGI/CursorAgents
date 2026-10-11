
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvironmentHistoryEventKind
    {
        /// <summary>
        ///
        /// </summary>
        Backfilled,
        /// <summary>
        ///
        /// </summary>
        Changed,
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Deleted,
        /// <summary>
        ///
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentHistoryEventKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentHistoryEventKind value)
        {
            return value switch
            {
                EnvironmentHistoryEventKind.Backfilled => "backfilled",
                EnvironmentHistoryEventKind.Changed => "changed",
                EnvironmentHistoryEventKind.Created => "created",
                EnvironmentHistoryEventKind.Deleted => "deleted",
                EnvironmentHistoryEventKind.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentHistoryEventKind? ToEnum(string value)
        {
            return value switch
            {
                "backfilled" => EnvironmentHistoryEventKind.Backfilled,
                "changed" => EnvironmentHistoryEventKind.Changed,
                "created" => EnvironmentHistoryEventKind.Created,
                "deleted" => EnvironmentHistoryEventKind.Deleted,
                "updated" => EnvironmentHistoryEventKind.Updated,
                _ => null,
            };
        }
    }
}