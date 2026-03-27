#nullable enable

namespace Helicone
{
    public partial interface IDashboardClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString> GetScoresOverTimeAsync(

            global::Helicone.DataOverTimeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="userFilter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString> GetScoresOverTimeAsync(
            global::Helicone.DataOverTimeRequestTimeFilter timeFilter,
            global::Helicone.RequestClickhouseFilterNode userFilter,
            global::Helicone.TimeIncrement dbIncrement,
            double timeZoneDifference,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}