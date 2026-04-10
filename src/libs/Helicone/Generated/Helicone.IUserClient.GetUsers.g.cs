#nullable enable

namespace Helicone
{
    public partial interface IUserClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString> GetUsersAsync(

            global::Helicone.UserQueryParams request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="timeFilter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString> GetUsersAsync(
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::Helicone.UserQueryParamsTimeFilter? timeFilter = default,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}