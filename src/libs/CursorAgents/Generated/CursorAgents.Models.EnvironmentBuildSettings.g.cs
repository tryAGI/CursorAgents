
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// The environment's build settings. Whether agents pull the latest code when they start, and how long a build's install step can run.
    /// </summary>
    public sealed partial class EnvironmentBuildSettings
    {
        /// <summary>
        /// Whether agents that start on the default branch pull its latest code. `when_stale`, the default, pulls when the active build is older than `stalenessThresholdHours`. `never` uses the commit the build recorded. `always` is a legacy value you can read but not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pullLatestCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.EnvironmentBuildSettingsPullLatestCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.EnvironmentBuildSettingsPullLatestCode PullLatestCode { get; set; }

        /// <summary>
        /// Hours before the active build counts as stale. `0` pulls on every start. `null` means the default, 24.<br/>
        /// Example: 24
        /// </summary>
        /// <example>24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stalenessThresholdHours")]
        public int? StalenessThresholdHours { get; set; }

        /// <summary>
        /// Minutes a build's install step can run. `null` means the default, 90.<br/>
        /// Example: 90
        /// </summary>
        /// <example>90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("installTimeoutMinutes")]
        public int? InstallTimeoutMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentBuildSettings" /> class.
        /// </summary>
        /// <param name="pullLatestCode">
        /// Whether agents that start on the default branch pull its latest code. `when_stale`, the default, pulls when the active build is older than `stalenessThresholdHours`. `never` uses the commit the build recorded. `always` is a legacy value you can read but not set.
        /// </param>
        /// <param name="stalenessThresholdHours">
        /// Hours before the active build counts as stale. `0` pulls on every start. `null` means the default, 24.<br/>
        /// Example: 24
        /// </param>
        /// <param name="installTimeoutMinutes">
        /// Minutes a build's install step can run. `null` means the default, 90.<br/>
        /// Example: 90
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentBuildSettings(
            global::CursorAgents.EnvironmentBuildSettingsPullLatestCode pullLatestCode,
            int? stalenessThresholdHours,
            int? installTimeoutMinutes)
        {
            this.PullLatestCode = pullLatestCode;
            this.StalenessThresholdHours = stalenessThresholdHours;
            this.InstallTimeoutMinutes = installTimeoutMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentBuildSettings" /> class.
        /// </summary>
        public EnvironmentBuildSettings()
        {
        }

    }
}