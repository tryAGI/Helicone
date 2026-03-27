#nullable enable

namespace Helicone
{
    public partial interface IPropertyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultValueStringCountNumberArrayString> GetTopRequestsAsync(
            string propertyKey,

            global::Helicone.TimeFilterRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyKey"></param>
        /// <param name="timeFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultValueStringCountNumberArrayString> GetTopRequestsAsync(
            string propertyKey,
            global::Helicone.TimeFilterRequestTimeFilter timeFilter,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}