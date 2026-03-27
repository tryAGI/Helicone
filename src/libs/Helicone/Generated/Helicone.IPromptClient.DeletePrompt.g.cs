#nullable enable

namespace Helicone
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePromptAsync(
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}