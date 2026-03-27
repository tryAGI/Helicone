#nullable enable

namespace Helicone
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultUnsafeBooleanString> GetSecurityAsync(

            global::Helicone.GetSecurityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="advanced"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultUnsafeBooleanString> GetSecurityAsync(
            string text,
            bool advanced,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}