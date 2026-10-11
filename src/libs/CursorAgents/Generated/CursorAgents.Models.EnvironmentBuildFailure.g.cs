
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Why a failed build failed.
    /// </summary>
    public sealed partial class EnvironmentBuildFailure
    {
        /// <summary>
        /// `INSTALL_FAILED` when the `install` command failed, or `TERMINAL_FAILURE` for other failures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.EnvironmentBuildFailureTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.EnvironmentBuildFailureType Type { get; set; }

        /// <summary>
        /// Machine-readable cause of the failure, when there is one.<br/>
        /// Example: environment_json_invalid
        /// </summary>
        /// <example>environment_json_invalid</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentBuildFailure" /> class.
        /// </summary>
        /// <param name="type">
        /// `INSTALL_FAILED` when the `install` command failed, or `TERMINAL_FAILURE` for other failures.
        /// </param>
        /// <param name="code">
        /// Machine-readable cause of the failure, when there is one.<br/>
        /// Example: environment_json_invalid
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentBuildFailure(
            global::CursorAgents.EnvironmentBuildFailureType type,
            string? code)
        {
            this.Type = type;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentBuildFailure" /> class.
        /// </summary>
        public EnvironmentBuildFailure()
        {
        }

    }
}