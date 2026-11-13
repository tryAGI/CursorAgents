
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Project lifecycle state. `ARCHIVED` when the Project was archived or its owner's coordinator was stopped.
    /// </summary>
    public enum ProjectStatus
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
    public static class ProjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectStatus value)
        {
            return value switch
            {
                ProjectStatus.Active => "ACTIVE",
                ProjectStatus.Archived => "ARCHIVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ProjectStatus.Active,
                "ARCHIVED" => ProjectStatus.Archived,
                _ => null,
            };
        }
    }
}