#nullable enable

namespace Helicone
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<double> DeleteAddOnsAsync(
            global::Helicone.DeleteAddOnsProductType productType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}