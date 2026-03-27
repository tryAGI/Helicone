#nullable enable

namespace Helicone
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultInAppThreadString> EscalateThreadAsync(
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}