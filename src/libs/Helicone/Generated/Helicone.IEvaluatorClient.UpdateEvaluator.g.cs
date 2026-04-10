#nullable enable

namespace Helicone
{
    public partial interface IEvaluatorClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultEvaluatorResultString> UpdateEvaluatorAsync(
            string evaluatorId,

            global::Helicone.UpdateEvaluatorParams request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="scoringType"></param>
        /// <param name="llmTemplate"></param>
        /// <param name="codeTemplate"></param>
        /// <param name="name"></param>
        /// <param name="lastMileConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultEvaluatorResultString> UpdateEvaluatorAsync(
            string evaluatorId,
            string? scoringType = default,
            object? llmTemplate = default,
            object? codeTemplate = default,
            string? name = default,
            object? lastMileConfig = default,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}