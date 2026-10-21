
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// State of the build's snapshot. Omitted if the build didn't create a snapshot.
    /// </summary>
    public enum EnvironmentBuildSnapshotState
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Deleted,
        /// <summary>
        ///
        /// </summary>
        ReapRequested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentBuildSnapshotStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentBuildSnapshotState value)
        {
            return value switch
            {
                EnvironmentBuildSnapshotState.Active => "ACTIVE",
                EnvironmentBuildSnapshotState.Deleted => "DELETED",
                EnvironmentBuildSnapshotState.ReapRequested => "REAP_REQUESTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentBuildSnapshotState? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => EnvironmentBuildSnapshotState.Active,
                "DELETED" => EnvironmentBuildSnapshotState.Deleted,
                "REAP_REQUESTED" => EnvironmentBuildSnapshotState.ReapRequested,
                _ => null,
            };
        }
    }
}