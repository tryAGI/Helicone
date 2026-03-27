#nullable enable

namespace Helicone
{
    public partial interface IAdminAlertBannerClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultVoidString> UpdateAlertBannerActiveAsync(

            global::Helicone.UpdateAlertBannerActiveRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="active"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultVoidString> UpdateAlertBannerActiveAsync(
            bool active,
            double id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}