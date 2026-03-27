#nullable enable

namespace Helicone
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="providerKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>> GetProviderKeyAsync(
            string providerKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}