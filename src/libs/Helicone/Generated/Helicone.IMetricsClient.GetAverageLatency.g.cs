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
        global::System.Threading.Tasks.Task<global::Helicone.ResultNumberString> GetAverageLatencyAsync(

            global::Helicone.MetricsFilterBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultNumberString> GetAverageLatencyAsync(
            global::Helicone.FilterNode filter,
            global::Helicone.MetricsFilterBodyTimeFilter timeFilter,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}