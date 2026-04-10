#nullable enable

namespace Helicone
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultScoreDistributionArrayString> QueryScoreDistributionsAsync(

            global::Helicone.EvalQueryParams request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultScoreDistributionArrayString> QueryScoreDistributionsAsync(
            global::Helicone.EvalFilterNode filter,
            global::Helicone.EvalQueryParamsTimeFilter timeFilter,
            double? offset = default,
            double? limit = default,
            double? timeZoneDifference = default,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}