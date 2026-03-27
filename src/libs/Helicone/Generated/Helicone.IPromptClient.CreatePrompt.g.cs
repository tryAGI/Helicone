#nullable enable

namespace Helicone
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultCreatePromptResponseString> CreatePromptAsync(

            global::Helicone.CreatePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="userDefinedId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultCreatePromptResponseString> CreatePromptAsync(
            object metadata,
            object prompt,
            string userDefinedId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}