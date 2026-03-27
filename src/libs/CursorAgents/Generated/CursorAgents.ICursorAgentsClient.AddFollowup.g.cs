#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Add followup<br/>
        /// Add a followup instruction to an existing cloud agent
        /// </summary>
        /// <param name="id">
        /// Example: bc_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AddFollowupResponse> AddFollowupAsync(
            string id,

            global::CursorAgents.AddFollowupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add followup<br/>
        /// Add a followup instruction to an existing cloud agent
        /// </summary>
        /// <param name="id">
        /// Example: bc_abc123
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.AddFollowupResponse> AddFollowupAsync(
            string id,
            global::CursorAgents.AddFollowupRequestPrompt prompt,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}