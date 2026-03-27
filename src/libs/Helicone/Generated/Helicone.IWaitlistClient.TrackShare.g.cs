#nullable enable

namespace Helicone
{
    public partial interface IWaitlistClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultSuccessBooleanNewPosition63NumberMessageStringString> TrackShareAsync(

            global::Helicone.TrackShareRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="feature"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultSuccessBooleanNewPosition63NumberMessageStringString> TrackShareAsync(
            global::Helicone.TrackShareRequestPlatform platform,
            string feature,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}