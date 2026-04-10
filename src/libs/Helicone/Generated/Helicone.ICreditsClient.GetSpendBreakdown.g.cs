#nullable enable

namespace Helicone
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeRange"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultSpendBreakdownResponseString> GetSpendBreakdownAsync(
            global::Helicone.GetSpendBreakdownTimeRange? timeRange = default,
            string? startDate = default,
            string? endDate = default,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}