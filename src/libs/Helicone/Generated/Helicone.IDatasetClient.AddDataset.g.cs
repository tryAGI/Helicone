#nullable enable

namespace Helicone
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultDatasetIdStringString> AddDatasetAsync(

            global::Helicone.NewDatasetParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="requestIds"></param>
        /// <param name="datasetType"></param>
        /// <param name="meta"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultDatasetIdStringString> AddDatasetAsync(
            string datasetName,
            global::System.Collections.Generic.IList<string> requestIds,
            global::Helicone.NewDatasetParamsDatasetType datasetType,
            global::Helicone.DatasetMetadata? meta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}