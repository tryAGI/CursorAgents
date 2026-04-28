
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRunResponse
    {
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
        /// Initializes a new instance of the <see cref="CreateRunResponse" /> class.
        /// </summary>
        /// <param name="run"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRunResponse(
            global::CursorAgents.Run run)
        {
            this.Run = run ?? throw new global::System.ArgumentNullException(nameof(run));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunResponse" /> class.
        /// </summary>
        public CreateRunResponse()
        {
        }
    }
}