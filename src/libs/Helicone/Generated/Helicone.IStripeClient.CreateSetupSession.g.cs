#nullable enable

namespace Helicone
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.CreateSetupSessionResponse> CreateSetupSessionAsync(

            global::Helicone.CreateSetupSessionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.CreateSetupSessionResponse> CreateSetupSessionAsync(
            string? returnUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}