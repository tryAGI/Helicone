#nullable enable

namespace Helicone
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessUnknown>> UpdateExperimentMetaAsync(

            global::Helicone.UpdateExperimentMetaRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="meta">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="experimentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessUnknown>> UpdateExperimentMetaAsync(
            global::System.Collections.Generic.Dictionary<string, string> meta,
            string experimentId,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}