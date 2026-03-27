#nullable enable

namespace Helicone
{
    public partial interface IModelRegistryClient
    {
        /// <summary>
        /// Returns a comprehensive list of all AI models with their configurations, pricing, and capabilities<br/>
        /// Get all available models from the registry
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultModelRegistryResponseString> GetModelRegistryAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}