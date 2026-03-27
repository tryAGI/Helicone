#nullable enable

namespace Helicone
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultProviderMetricArrayString> GetProvidersAsync(

            global::Helicone.ProviderQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="timeFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultProviderMetricArrayString> GetProvidersAsync(
            global::Helicone.FilterNode filter,
            double offset,
            double limit,
            global::Helicone.ProviderQueryParamsTimeFilter timeFilter,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}