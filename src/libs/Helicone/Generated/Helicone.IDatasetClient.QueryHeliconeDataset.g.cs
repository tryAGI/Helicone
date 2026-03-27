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
        global::System.Threading.Tasks.Task<global::Helicone.ResultHeliconeDatasetArrayString> QueryHeliconeDatasetAsync(

            global::Helicone.QueryHeliconeDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultHeliconeDatasetArrayString> QueryHeliconeDatasetAsync(
            global::System.Collections.Generic.IList<string>? datasetIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}