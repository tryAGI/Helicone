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
        global::System.Threading.Tasks.Task<global::Helicone.ResultEvaluatorResultString> CreateEvaluatorAsync(

            global::Helicone.CreateEvaluatorParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scoringType"></param>
        /// <param name="llmTemplate"></param>
        /// <param name="name"></param>
        /// <param name="codeTemplate"></param>
        /// <param name="lastMileConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultEvaluatorResultString> CreateEvaluatorAsync(
            string scoringType,
            string name,
            object? llmTemplate = default,
            object? codeTemplate = default,
            object? lastMileConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}