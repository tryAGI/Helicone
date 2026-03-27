#nullable enable

namespace Helicone
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultHypothesisIdStringString> CreateNewExperimentHypothesisAsync(

            global::Helicone.CreateNewExperimentHypothesisRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="providerKeyId"></param>
        /// <param name="promptVersion"></param>
        /// <param name="model"></param>
        /// <param name="experimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultHypothesisIdStringString> CreateNewExperimentHypothesisAsync(
            global::Helicone.CreateNewExperimentHypothesisRequestStatus status,
            string providerKeyId,
            string promptVersion,
            string model,
            string experimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}