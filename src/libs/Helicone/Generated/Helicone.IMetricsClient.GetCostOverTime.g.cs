#nullable enable

namespace Helicone
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultCostOverTimeArrayString> GetCostOverTimeAsync(

            global::Helicone.MetricsOverTimeBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="filter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultCostOverTimeArrayString> GetCostOverTimeAsync(
            global::Helicone.MetricsOverTimeBodyTimeFilter timeFilter,
            global::Helicone.FilterNode filter,
            double timeZoneDifference,
            global::Helicone.TimeIncrement? dbIncrement = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}