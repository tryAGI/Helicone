#nullable enable

namespace Helicone
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpgradeExistingCustomerAsync(

            global::Helicone.UpgradeToProRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="addons"></param>
        /// <param name="seats"></param>
        /// <param name="uiMode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpgradeExistingCustomerAsync(
            global::Helicone.UpgradeToProRequestAddons? addons = default,
            double? seats = default,
            global::Helicone.UpgradeToProRequestUiMode? uiMode = default,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}