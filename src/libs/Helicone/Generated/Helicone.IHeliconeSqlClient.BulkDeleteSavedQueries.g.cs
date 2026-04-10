#nullable enable

namespace Helicone
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Bulk delete saved queries<br/>
        /// Delete multiple saved queries at once
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultVoidString> BulkDeleteSavedQueriesAsync(

            global::Helicone.BulkDeleteSavedQueriesRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete saved queries<br/>
        /// Delete multiple saved queries at once
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultVoidString> BulkDeleteSavedQueriesAsync(
            global::System.Collections.Generic.IList<string> ids,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}