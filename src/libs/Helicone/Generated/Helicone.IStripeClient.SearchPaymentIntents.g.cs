#nullable enable

namespace Helicone
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchKind"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.StripePaymentIntentsResponse> SearchPaymentIntentsAsync(
            string searchKind,
            double? limit = default,
            string? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}