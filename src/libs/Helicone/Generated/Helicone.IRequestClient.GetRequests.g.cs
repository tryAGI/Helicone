#nullable enable

namespace Helicone
{
    public partial interface IRequestClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultHeliconeRequestArrayString> GetRequestsAsync(

            global::Helicone.RequestQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="sort"></param>
        /// <param name="isCached"></param>
        /// <param name="includeInputs"></param>
        /// <param name="isPartOfExperiment"></param>
        /// <param name="isScored"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultHeliconeRequestArrayString> GetRequestsAsync(
            global::Helicone.RequestFilterNode filter,
            double? offset = default,
            double? limit = default,
            global::Helicone.SortLeafRequest? sort = default,
            bool? isCached = default,
            bool? includeInputs = default,
            bool? isPartOfExperiment = default,
            bool? isScored = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}