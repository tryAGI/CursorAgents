
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListModelsResponse
    {
        /// <summary>
        /// Recommended set of explicit model IDs you can pass to the `model.id` field on POST /v1/agents.<br/>
        /// Example: [composer-2, gpt-5.5, claude-4.6-sonnet-thinking]
        /// </summary>
        /// <example>[composer-2, gpt-5.5, claude-4.6-sonnet-thinking]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Recommended set of explicit model IDs you can pass to the `model.id` field on POST /v1/agents.<br/>
        /// Example: [composer-2, gpt-5.5, claude-4.6-sonnet-thinking]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListModelsResponse(
            global::System.Collections.Generic.IList<string> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsResponse" /> class.
        /// </summary>
        public ListModelsResponse()
        {
        }
    }
}