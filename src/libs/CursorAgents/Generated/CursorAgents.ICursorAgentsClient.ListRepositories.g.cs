#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// List GitHub repositories<br/>
        /// Retrieve a list of GitHub repositories accessible to the authenticated user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.ListRepositoriesResponse> ListRepositoriesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}