#nullable enable

namespace Helicone
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultNullString> AddManualRowsToExperimentBatchAsync(
            string experimentId,

            global::Helicone.AddManualRowsToExperimentBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="inputs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultNullString> AddManualRowsToExperimentBatchAsync(
            string experimentId,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> inputs,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}