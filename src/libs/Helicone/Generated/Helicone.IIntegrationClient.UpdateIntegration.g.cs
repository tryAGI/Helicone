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
        global::System.Threading.Tasks.Task<global::Helicone.ResultNullString> UpdateIntegrationAsync(
            string integrationId,

            global::Helicone.IntegrationUpdateParams request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="integrationName"></param>
        /// <param name="settings"></param>
        /// <param name="active"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultNullString> UpdateIntegrationAsync(
            string integrationId,
            string? integrationName = default,
            global::Helicone.Json? settings = default,
            bool? active = default,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}