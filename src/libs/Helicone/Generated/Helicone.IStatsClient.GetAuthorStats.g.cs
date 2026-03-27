#nullable enable

namespace Helicone
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// Get statistics for a specific model author.<br/>
        /// Returns time series data and a leaderboard of top models by that author.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="timeframe"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultAuthorStatsResponseString> GetAuthorStatsAsync(
            string author,
            global::Helicone.StatsTimeFrame? timeframe = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}