
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// `when_stale` (the default) or `never`. Setting the legacy `always` returns `400 validation_error`. To move an environment off `always`, send `when_stale` with `stalenessThresholdHours`.
    /// </summary>
    public enum UpdateEnvironmentBuildSettingsPullLatestCode
    {
        /// <summary>
        ///
        /// </summary>
        Never,
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        ///
        /// </summary>
        WhenStale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateEnvironmentBuildSettingsPullLatestCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateEnvironmentBuildSettingsPullLatestCode value)
        {
            return value switch
            {
                UpdateEnvironmentBuildSettingsPullLatestCode.Never => "never",
                UpdateEnvironmentBuildSettingsPullLatestCode.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                UpdateEnvironmentBuildSettingsPullLatestCode.WhenStale => "when_stale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateEnvironmentBuildSettingsPullLatestCode? ToEnum(string value)
        {
            return value switch
            {
                "never" => UpdateEnvironmentBuildSettingsPullLatestCode.Never,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => UpdateEnvironmentBuildSettingsPullLatestCode.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "when_stale" => UpdateEnvironmentBuildSettingsPullLatestCode.WhenStale,
                _ => null,
            };
        }
    }
}