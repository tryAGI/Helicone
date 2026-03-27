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
        global::System.Threading.Tasks.Task<string> UpgradeExistingCustomerToTeamBundleAsync(

            global::Helicone.UpgradeToTeamBundleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpgradeExistingCustomerToTeamBundleAsync(
            global::Helicone.UpgradeToTeamBundleRequestUiMode? uiMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}