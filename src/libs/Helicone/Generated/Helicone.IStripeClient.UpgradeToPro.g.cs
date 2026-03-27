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
        global::System.Threading.Tasks.Task<string> UpgradeToProAsync(

            global::Helicone.UpgradeToProRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="addons"></param>
        /// <param name="seats"></param>
        /// <param name="uiMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpgradeToProAsync(
            global::Helicone.UpgradeToProRequestAddons? addons = default,
            double? seats = default,
            global::Helicone.UpgradeToProRequestUiMode? uiMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}