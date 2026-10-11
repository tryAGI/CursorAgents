
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnvironmentBuild
    {
        /// <summary>
        /// Unique build identifier, in the form `bld-YYYYMMDD-&lt;uuid&gt;`.<br/>
        /// Example: bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f
        /// </summary>
        /// <example>bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the environment the build belongs to.<br/>
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </summary>
        /// <example>8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EnvironmentId { get; set; }

        /// <summary>
        /// Build status. A skipped build found nothing to rebuild.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.EnvironmentBuildStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.EnvironmentBuildStatus Status { get; set; }

        /// <summary>
        /// What started the build. `RECURRING` for a scheduled build, `CONFIG_CHANGE` after a configuration or secrets change, or `MANUAL` for one started on request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CursorAgents.JsonConverters.EnvironmentBuildTriggerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.EnvironmentBuildTrigger Trigger { get; set; }

        /// <summary>
        /// `true` for a draft build. Agents don't start from a draft build until it's activated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Draft { get; set; }

        /// <summary>
        /// Why a failed build failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        public global::CursorAgents.EnvironmentBuildFailure? Failure { get; set; }

        /// <summary>
        /// When the build was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the build was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// When the build finished. Omitted while it's in progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentBuild" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique build identifier, in the form `bld-YYYYMMDD-&lt;uuid&gt;`.<br/>
        /// Example: bld-20260930-3c59dc04-8a1d-4b6e-9f2a-7e5d1c0b9a8f
        /// </param>
        /// <param name="environmentId">
        /// ID of the environment the build belongs to.<br/>
        /// Example: 8f14e45f-ceea-4e6b-9c3a-1d2e3f4a5b6c
        /// </param>
        /// <param name="status">
        /// Build status. A skipped build found nothing to rebuild.
        /// </param>
        /// <param name="trigger">
        /// What started the build. `RECURRING` for a scheduled build, `CONFIG_CHANGE` after a configuration or secrets change, or `MANUAL` for one started on request.
        /// </param>
        /// <param name="draft">
        /// `true` for a draft build. Agents don't start from a draft build until it's activated.
        /// </param>
        /// <param name="createdAt">
        /// When the build was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the build was last updated.
        /// </param>
        /// <param name="failure">
        /// Why a failed build failed.
        /// </param>
        /// <param name="completedAt">
        /// When the build finished. Omitted while it's in progress.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentBuild(
            string id,
            global::System.Guid environmentId,
            global::CursorAgents.EnvironmentBuildStatus status,
            global::CursorAgents.EnvironmentBuildTrigger trigger,
            bool draft,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::CursorAgents.EnvironmentBuildFailure? failure,
            global::System.DateTime? completedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EnvironmentId = environmentId;
            this.Status = status;
            this.Trigger = trigger;
            this.Draft = draft;
            this.Failure = failure;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentBuild" /> class.
        /// </summary>
        public EnvironmentBuild()
        {
        }

    }
}