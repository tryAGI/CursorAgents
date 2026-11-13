
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.Project Project { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CursorAgents.Run Run { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponse" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="run"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponse(
            global::CursorAgents.Project project,
            global::CursorAgents.Run run)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Run = run ?? throw new global::System.ArgumentNullException(nameof(run));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponse" /> class.
        /// </summary>
        public CreateProjectResponse()
        {
        }

    }
}