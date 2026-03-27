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
        global::System.Threading.Tasks.Task<global::Helicone.ResultScoreNumberInputStringOutputStringGroundTruth63StringString> TestLastMileEvaluatorAsync(

            global::Helicone.TestLastMileEvaluatorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="testInput"></param>
        /// <param name="config"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultScoreNumberInputStringOutputStringGroundTruth63StringString> TestLastMileEvaluatorAsync(
            global::Helicone.TestInput testInput,
            global::Helicone.LastMileConfigForm config,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}