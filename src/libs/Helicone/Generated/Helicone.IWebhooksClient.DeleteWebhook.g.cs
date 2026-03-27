#nullable enable

namespace Helicone
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultNullString> DeleteWebhookAsync(
            string webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}