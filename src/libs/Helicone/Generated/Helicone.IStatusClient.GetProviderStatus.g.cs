#nullable enable

namespace Helicone
{
    public partial interface IStatusClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="timeFrame"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultProviderMetricsString> GetProviderStatusAsync(
            string provider,
            global::Helicone.TimeFrame timeFrame,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}