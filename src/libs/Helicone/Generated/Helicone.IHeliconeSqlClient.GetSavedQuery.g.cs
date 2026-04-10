#nullable enable

namespace Helicone
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Get saved query<br/>
        /// Get a specific saved query by ID
        /// </summary>
        /// <param name="queryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultHqlSavedQueryOrNullString> GetSavedQueryAsync(
            string queryId,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}