#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Delete an agent<br/>
        /// Delete a cloud agent. This action is permanent and cannot be undone.
        /// </summary>
        /// <param name="id">
        /// Example: bc_abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.DeleteAgentResponse> DeleteAgentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}