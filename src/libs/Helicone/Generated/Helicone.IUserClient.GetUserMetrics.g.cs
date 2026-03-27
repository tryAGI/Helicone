#nullable enable

namespace Helicone
{
    public partial interface IUserClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString> GetUserMetricsAsync(

            global::Helicone.UserMetricsQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="timeFilter"></param>
        /// <param name="timeZoneDifferenceMinutes"></param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString> GetUserMetricsAsync(
            global::Helicone.UserFilterNode filter,
            double offset,
            double limit,
            global::Helicone.UserMetricsQueryParamsTimeFilter? timeFilter = default,
            double? timeZoneDifferenceMinutes = default,
            global::Helicone.SortLeafUsers? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}