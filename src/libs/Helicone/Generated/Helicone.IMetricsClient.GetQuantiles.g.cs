#nullable enable

namespace Helicone
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultQuantilesArrayString> GetQuantilesAsync(

            global::Helicone.QuantilesBody request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="metric"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultQuantilesArrayString> GetQuantilesAsync(
            global::Helicone.FilterNode filter,
            global::Helicone.QuantilesBodyTimeFilter timeFilter,
            double timeZoneDifference,
            string metric,
            global::Helicone.TimeIncrement? dbIncrement = default,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}