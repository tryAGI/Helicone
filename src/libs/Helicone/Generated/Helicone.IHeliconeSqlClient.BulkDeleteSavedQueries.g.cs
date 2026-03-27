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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultVoidString> BulkDeleteSavedQueriesAsync(

            global::Helicone.BulkDeleteSavedQueriesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete saved queries<br/>
        /// Delete multiple saved queries at once
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultVoidString> BulkDeleteSavedQueriesAsync(
            global::System.Collections.Generic.IList<string> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}