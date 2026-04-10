#nullable enable

namespace Helicone
{
    public partial interface IPropertyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.RestorePropertyResponse2>> RestorePropertyAsync(

            global::Helicone.RestorePropertyRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.RestorePropertyResponse2>> RestorePropertyAsync(
            string key,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}