#nullable enable

namespace Helicone
{
    public partial interface ITestClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.SendTestRequestResponse> SendTestRequestAsync(

            global::Helicone.SendTestRequestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.SendTestRequestResponse> SendTestRequestAsync(
            string apiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}