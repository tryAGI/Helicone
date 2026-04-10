#nullable enable

namespace Helicone
{
    public partial interface IIntegrationClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultStringString> TestStripeMeterEventAsync(
            string integrationId,

            global::Helicone.TestStripeMeterEventRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="eventName"></param>
        /// <param name="customerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultStringString> TestStripeMeterEventAsync(
            string integrationId,
            string eventName,
            string customerId,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}