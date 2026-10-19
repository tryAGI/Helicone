#nullable enable

namespace Helicone
{
    public partial interface IPiClient
    {
        /// <summary>
        /// Links a device session (created by POST /v1/public/pi/session) to the<br/>
        /// signed-in organization. Requires a signed-in owner or admin; only<br/>
        /// server-issued, unexpired, not-yet-linked session ids are accepted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultStringString> AddSessionAsync(

            global::Helicone.AddSessionRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Links a device session (created by POST /v1/public/pi/session) to the<br/>
        /// signed-in organization. Requires a signed-in owner or admin; only<br/>
        /// server-issued, unexpired, not-yet-linked session ids are accepted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AutoSDKHttpResponse<global::Helicone.ResultStringString>> AddSessionAsResponseAsync(

            global::Helicone.AddSessionRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Links a device session (created by POST /v1/public/pi/session) to the<br/>
        /// signed-in organization. Requires a signed-in owner or admin; only<br/>
        /// server-issued, unexpired, not-yet-linked session ids are accepted.
        /// </summary>
        /// <param name="sessionUUID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultStringString> AddSessionAsync(
            string sessionUUID,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}