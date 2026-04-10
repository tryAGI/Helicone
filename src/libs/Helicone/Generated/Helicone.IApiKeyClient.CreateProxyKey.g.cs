#nullable enable

namespace Helicone
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>> CreateProxyKeyAsync(

            global::Helicone.CreateProxyKeyRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="proxyKeyName"></param>
        /// <param name="providerKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>> CreateProxyKeyAsync(
            string proxyKeyName,
            string providerKeyId,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}