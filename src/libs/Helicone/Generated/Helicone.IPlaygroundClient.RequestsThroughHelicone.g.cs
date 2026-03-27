#nullable enable

namespace Helicone
{
    public partial interface IPlaygroundClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultStringString> RequestsThroughHeliconeAsync(

            global::Helicone.RequestsThroughHeliconeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestsThroughHelicone"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultStringString> RequestsThroughHeliconeAsync(
            bool requestsThroughHelicone,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}