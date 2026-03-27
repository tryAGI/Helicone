#nullable enable

namespace Helicone
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultInAppThreadString> UpsertThreadMessageAsync(
            string sessionId,

            global::Helicone.UpsertThreadMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="metadata"></param>
        /// <param name="messages"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultInAppThreadString> UpsertThreadMessageAsync(
            string sessionId,
            global::Helicone.UpsertThreadMessageRequestMetadata metadata,
            global::System.Collections.Generic.IList<object> messages,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}