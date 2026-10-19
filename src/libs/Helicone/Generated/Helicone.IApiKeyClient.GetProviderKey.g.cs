#nullable enable

namespace Helicone
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// Returns provider key metadata with the secret values MASKED. Plaintext<br/>
        /// provider keys are never returned over HTTP (INC-710). Requires a signed-in<br/>
        /// organization owner or admin; Helicone API keys are rejected.
        /// </summary>
        /// <param name="providerKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.MaskedProviderKey, global::Helicone.GetProviderKeyResponse2>> GetProviderKeyAsync(
            string providerKeyId,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns provider key metadata with the secret values MASKED. Plaintext<br/>
        /// provider keys are never returned over HTTP (INC-710). Requires a signed-in<br/>
        /// organization owner or admin; Helicone API keys are rejected.
        /// </summary>
        /// <param name="providerKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AutoSDKHttpResponse<global::Helicone.AnyOf<global::Helicone.MaskedProviderKey, global::Helicone.GetProviderKeyResponse2>>> GetProviderKeyAsResponseAsync(
            string providerKeyId,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}