#nullable enable

namespace Helicone
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultPrompt2025VersionArrayString> GetPrompt2025VersionsAsync(

            global::Helicone.GetPrompt2025VersionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="majorVersion"></param>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultPrompt2025VersionArrayString> GetPrompt2025VersionsAsync(
            string promptId,
            double? majorVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}