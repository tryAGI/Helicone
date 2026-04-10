#nullable enable

namespace Helicone
{
    public partial interface IDashboardClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString> GetScoresOverTimeAsync(

            global::Helicone.DataOverTimeRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="userFilter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString> GetScoresOverTimeAsync(
            global::Helicone.DataOverTimeRequestTimeFilter timeFilter,
            global::Helicone.RequestClickhouseFilterNode userFilter,
            global::Helicone.TimeIncrement dbIncrement,
            double timeZoneDifference,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}