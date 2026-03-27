#nullable enable

namespace Helicone
{
    public partial interface IPlaygroundClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultBooleanString> GetRequestsThroughHeliconeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}