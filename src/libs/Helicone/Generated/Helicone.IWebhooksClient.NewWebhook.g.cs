#nullable enable

namespace Helicone
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.ResultSuccessUnknown, global::Helicone.ResultErrorUnknown>> NewWebhookAsync(

            global::Helicone.WebhookData request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="config">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="includeData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.AnyOf<global::Helicone.ResultSuccessUnknown, global::Helicone.ResultErrorUnknown>> NewWebhookAsync(
            string destination,
            object config,
            bool? includeData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}