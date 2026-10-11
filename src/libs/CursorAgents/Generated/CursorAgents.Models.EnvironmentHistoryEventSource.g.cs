
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Where the change came from.
    /// </summary>
    public enum EnvironmentHistoryEventSource
    {
        /// <summary>
        ///
        /// </summary>
        AgentRun,
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Dashboard,
        /// <summary>
        ///
        /// </summary>
        RepoFile,
        /// <summary>
        ///
        /// </summary>
        RequestOverride,
        /// <summary>
        ///
        /// </summary>
        Restore,
        /// <summary>
        ///
        /// </summary>
        SetupFlow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentHistoryEventSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentHistoryEventSource value)
        {
            return value switch
            {
                EnvironmentHistoryEventSource.AgentRun => "agent_run",
                EnvironmentHistoryEventSource.Api => "api",
                EnvironmentHistoryEventSource.Dashboard => "dashboard",
                EnvironmentHistoryEventSource.RepoFile => "repo_file",
                EnvironmentHistoryEventSource.RequestOverride => "request_override",
                EnvironmentHistoryEventSource.Restore => "restore",
                EnvironmentHistoryEventSource.SetupFlow => "setup_flow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentHistoryEventSource? ToEnum(string value)
        {
            return value switch
            {
                "agent_run" => EnvironmentHistoryEventSource.AgentRun,
                "api" => EnvironmentHistoryEventSource.Api,
                "dashboard" => EnvironmentHistoryEventSource.Dashboard,
                "repo_file" => EnvironmentHistoryEventSource.RepoFile,
                "request_override" => EnvironmentHistoryEventSource.RequestOverride,
                "restore" => EnvironmentHistoryEventSource.Restore,
                "setup_flow" => EnvironmentHistoryEventSource.SetupFlow,
                _ => null,
            };
        }
    }
}