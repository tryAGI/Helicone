#nullable enable

namespace Helicone
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task LogTraceAsync(

            global::Helicone.OTELTrace request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceSpans"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task LogTraceAsync(
            global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpan> resourceSpans,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}