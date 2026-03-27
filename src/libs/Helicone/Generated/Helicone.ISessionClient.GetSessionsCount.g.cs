#nullable enable

namespace Helicone
{
    public partial interface ISessionClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultSessionsAggregateMetricsString> GetSessionsCountAsync(

            global::Helicone.SessionQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <param name="timeFilter"></param>
        /// <param name="nameEquals"></param>
        /// <param name="timezoneDifference"></param>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultSessionsAggregateMetricsString> GetSessionsCountAsync(
            string search,
            global::Helicone.SessionQueryParamsTimeFilter timeFilter,
            double timezoneDifference,
            global::Helicone.SessionFilterNode filter,
            string? nameEquals = default,
            double? offset = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}