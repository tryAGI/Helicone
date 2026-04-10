#nullable enable

namespace Helicone
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>> UpdateAPIKeyAsync(
            double apiKeyId,

            global::Helicone.UpdateAPIKeyRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="apiKeyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>> UpdateAPIKeyAsync(
            double apiKeyId,
            string apiKeyName,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}