
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageTokenUsage
    {
        /// <summary>
        /// Input tokens consumed.<br/>
        /// Example: 6320
        /// </summary>
        /// <example>6320</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Output tokens generated.<br/>
        /// Example: 1450
        /// </summary>
        /// <example>1450</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Tokens written to cache.<br/>
        /// Example: 7100
        /// </summary>
        /// <example>7100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheWriteTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheWriteTokens { get; set; }

        /// <summary>
        /// Tokens read from cache.<br/>
        /// Example: 21300
        /// </summary>
        /// <example>21300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheReadTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheReadTokens { get; set; }

        /// <summary>
        /// Sum of the four token counts above.<br/>
        /// Example: 36170
        /// </summary>
        /// <example>36170</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTokenUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Input tokens consumed.<br/>
        /// Example: 6320
        /// </param>
        /// <param name="outputTokens">
        /// Output tokens generated.<br/>
        /// Example: 1450
        /// </param>
        /// <param name="cacheWriteTokens">
        /// Tokens written to cache.<br/>
        /// Example: 7100
        /// </param>
        /// <param name="cacheReadTokens">
        /// Tokens read from cache.<br/>
        /// Example: 21300
        /// </param>
        /// <param name="totalTokens">
        /// Sum of the four token counts above.<br/>
        /// Example: 36170
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageTokenUsage(
            int inputTokens,
            int outputTokens,
            int cacheWriteTokens,
            int cacheReadTokens,
            int totalTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheWriteTokens = cacheWriteTokens;
            this.CacheReadTokens = cacheReadTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTokenUsage" /> class.
        /// </summary>
        public UsageTokenUsage()
        {
        }

    }
}