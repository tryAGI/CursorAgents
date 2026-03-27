#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// Stop an agent<br/>
        /// Stop a running cloud agent. This pauses the agent's execution without deleting it. Stopped agents cannot be resumed.
        /// </summary>
        /// <param name="id">
        /// Example: bc_abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.StopAgentResponse> StopAgentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}