#nullable enable

namespace Helicone
{
    public partial interface IEvaluatorClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultEvaluatorScoreString> TestLLMEvaluatorAsync(

            global::Helicone.TestLLMEvaluatorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluatorName"></param>
        /// <param name="testInput"></param>
        /// <param name="evaluatorConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultEvaluatorScoreString> TestLLMEvaluatorAsync(
            string evaluatorName,
            global::Helicone.TestInput testInput,
            global::Helicone.EvaluatorConfig evaluatorConfig,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}