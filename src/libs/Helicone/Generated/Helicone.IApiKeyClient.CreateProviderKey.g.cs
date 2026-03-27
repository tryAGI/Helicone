#nullable enable

namespace Helicone
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>> CreateProviderKeyAsync(

            global::Helicone.CreateProviderKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="byokEnabled"></param>
        /// <param name="providerKeyName"></param>
        /// <param name="providerSecretKey"></param>
        /// <param name="providerKey"></param>
        /// <param name="providerName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>> CreateProviderKeyAsync(
            global::System.Collections.Generic.Dictionary<string, string> config,
            bool byokEnabled,
            string providerKeyName,
            string providerKey,
            string providerName,
            string? providerSecretKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}