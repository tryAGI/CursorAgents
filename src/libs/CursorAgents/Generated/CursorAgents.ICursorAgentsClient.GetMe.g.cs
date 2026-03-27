#nullable enable

namespace CursorAgents
{
    public partial interface ICursorAgentsClient
    {
        /// <summary>
        /// API key info<br/>
        /// Retrieve information about the API key being used for authentication
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CursorAgents.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CursorAgents.GetMeResponse> GetMeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}