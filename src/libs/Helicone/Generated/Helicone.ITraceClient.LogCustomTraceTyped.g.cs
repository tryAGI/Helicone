#nullable enable

namespace Helicone
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.ValidationResult, object>> LogCustomTraceTypedAsync(

            global::Helicone.TypedAsyncLogModel request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="providerRequest"></param>
        /// <param name="providerResponse"></param>
        /// <param name="timing"></param>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.ValidationResult, object>> LogCustomTraceTypedAsync(
            global::Helicone.TypedProviderRequest providerRequest,
            global::Helicone.TypedProviderResponse providerResponse,
            global::Helicone.TypedTiming? timing = default,
            global::Helicone.Provider? provider = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}