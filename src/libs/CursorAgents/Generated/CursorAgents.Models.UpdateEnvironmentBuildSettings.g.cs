
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// New values for any of the build settings GET /v1/environments/{id} returns. Fields you leave out stay unchanged, and `null` resets a field to its default.
    /// </summary>
    public sealed partial class UpdateEnvironmentBuildSettings
    {
        /// <summary>
        /// `when_stale` (the default) or `never`. Setting the legacy `always` returns `400 validation_error`. To move an environment off `always`, send `when_stale` with `stalenessThresholdHours`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pullLatestCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.UpdateEnvironmentBuildSettingsPullLatestCodeJsonConverter))]
        public global::CursorAgents.UpdateEnvironmentBuildSettingsPullLatestCode? PullLatestCode { get; set; }

        /// <summary>
        /// Hours before the active build counts as stale. Default 24.<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stalenessThresholdHours")]
        public int? StalenessThresholdHours { get; set; }

        /// <summary>
        /// Minutes a build's install step can run. Default 90.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("installTimeoutMinutes")]
        public int? InstallTimeoutMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentBuildSettings" /> class.
        /// </summary>
        /// <param name="pullLatestCode">
        /// `when_stale` (the default) or `never`. Setting the legacy `always` returns `400 validation_error`. To move an environment off `always`, send `when_stale` with `stalenessThresholdHours`.
        /// </param>
        /// <param name="stalenessThresholdHours">
        /// Hours before the active build counts as stale. Default 24.<br/>
        /// Example: 12
        /// </param>
        /// <param name="installTimeoutMinutes">
        /// Minutes a build's install step can run. Default 90.<br/>
        /// Example: 120
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnvironmentBuildSettings(
            global::CursorAgents.UpdateEnvironmentBuildSettingsPullLatestCode? pullLatestCode,
            int? stalenessThresholdHours,
            int? installTimeoutMinutes)
        {
            this.PullLatestCode = pullLatestCode;
            this.StalenessThresholdHours = stalenessThresholdHours;
            this.InstallTimeoutMinutes = installTimeoutMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentBuildSettings" /> class.
        /// </summary>
        public UpdateEnvironmentBuildSettings()
        {
        }

    }
}