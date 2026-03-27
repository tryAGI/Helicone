#nullable enable

namespace Helicone
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.ResultErrorUnknown, global::Helicone.ResultSuccessAny>> UpdateHeliconeDatasetRequestAsync(
            string datasetId,
            string requestId,

            global::Helicone.UpdateHeliconeDatasetRequestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="requestId"></param>
        /// <param name="responseBody"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.ResultErrorUnknown, global::Helicone.ResultSuccessAny>> UpdateHeliconeDatasetRequestAsync(
            string datasetId,
            string requestId,
            global::Helicone.Json? responseBody = default,
            global::Helicone.Json? requestBody = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}