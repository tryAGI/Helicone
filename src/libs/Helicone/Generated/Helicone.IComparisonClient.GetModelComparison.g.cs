#nullable enable

namespace Helicone
{
    public partial interface IComparisonClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultModelArrayString> GetModelComparisonAsync(

            global::System.Collections.Generic.IList<global::Helicone.ModelsToCompare> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}