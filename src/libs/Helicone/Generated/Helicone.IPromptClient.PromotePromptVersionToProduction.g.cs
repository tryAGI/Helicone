#nullable enable

namespace Helicone
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultPromptVersionResultString> PromotePromptVersionToProductionAsync(
            string promptVersionId,

            global::Helicone.PromotePromptVersionToProductionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="previousProductionVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultPromptVersionResultString> PromotePromptVersionToProductionAsync(
            string promptVersionId,
            string previousProductionVersionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}