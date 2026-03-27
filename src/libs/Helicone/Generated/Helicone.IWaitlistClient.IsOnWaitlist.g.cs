#nullable enable

namespace Helicone
{
    public partial interface IWaitlistClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="feature"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultIsOnWaitlistBooleanString> IsOnWaitlistAsync(
            string email,
            string feature,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}