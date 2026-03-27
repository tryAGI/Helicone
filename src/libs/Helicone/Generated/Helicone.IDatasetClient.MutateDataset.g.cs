#nullable enable

namespace Helicone
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultArrayString> MutateDatasetAsync(
            string datasetId,

            global::Helicone.MutateDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="removeRequests"></param>
        /// <param name="addRequests"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultArrayString> MutateDatasetAsync(
            string datasetId,
            global::System.Collections.Generic.IList<string> removeRequests,
            global::System.Collections.Generic.IList<string> addRequests,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}