#nullable enable

namespace Helicone
{
    public partial interface IEvaluatorClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="onlineEvaluatorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultNullString> DeleteOnlineEvaluatorAsync(
            string evaluatorId,
            string onlineEvaluatorId,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}