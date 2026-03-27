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
        global::System.Threading.Tasks.Task<global::Helicone.ResultMetadataRecordStringAnyString> EditPromptVersionLabelAsync(
            string promptVersionId,

            global::Helicone.PromptEditSubversionLabelParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="label"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultMetadataRecordStringAnyString> EditPromptVersionLabelAsync(
            string promptVersionId,
            string label,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}