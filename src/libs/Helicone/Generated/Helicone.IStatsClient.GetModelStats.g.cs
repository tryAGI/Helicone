#nullable enable

namespace Helicone
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// Get usage statistics for a specific model.<br/>
        /// Returns time series data showing token usage over time.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="timeframe"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultModelStatsResponseString> GetModelStatsAsync(
            string model,
            global::Helicone.StatsTimeFrame? timeframe = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}