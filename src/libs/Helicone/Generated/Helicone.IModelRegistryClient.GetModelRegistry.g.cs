#nullable enable

namespace Helicone
{
    public partial interface IModelRegistryClient
    {
        /// <summary>
        /// Returns a comprehensive list of all AI models with their configurations, pricing, and capabilities<br/>
        /// Get all available models from the registry
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultModelRegistryResponseString> GetModelRegistryAsync(
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}