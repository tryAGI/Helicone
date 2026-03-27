#nullable enable

namespace Helicone
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// Get the full prompt body (messages, tools, etc.) for a specific prompt version.
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultPrompt2025Version91PromptBody93String> GetPrompt2025VersionBodyAsync(
            string promptVersionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}