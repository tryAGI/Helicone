#nullable enable

namespace Helicone
{
    public partial interface IUserClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString> GetUserMetricsOverviewAsync(

            global::Helicone.GetUserMetricsOverviewRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="useInterquartile"></param>
        /// <param name="pSize"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString> GetUserMetricsOverviewAsync(
            bool useInterquartile,
            global::Helicone.PSize pSize,
            global::Helicone.UserFilterNode filter,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}