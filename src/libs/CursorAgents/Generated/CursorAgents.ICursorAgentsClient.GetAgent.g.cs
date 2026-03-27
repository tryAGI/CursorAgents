#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Agent status<br/>
        /// Retrieve the current status and results of a cloud agent
        /// </summary>
        /// <param name="id">
        /// Example: bc_abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.GetAgentResponse> GetAgentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}