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
        global::System.Threading.Tasks.Task<global::Helicone.AutoTopoffSettings> UpdateAutoTopoffSettingsAsync(

            global::Helicone.UpdateAutoTopoffSettingsRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="thresholdCents"></param>
        /// <param name="topoffAmountCents"></param>
        /// <param name="stripePaymentMethodId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AutoTopoffSettings> UpdateAutoTopoffSettingsAsync(
            bool enabled,
            double thresholdCents,
            double topoffAmountCents,
            string stripePaymentMethodId,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}