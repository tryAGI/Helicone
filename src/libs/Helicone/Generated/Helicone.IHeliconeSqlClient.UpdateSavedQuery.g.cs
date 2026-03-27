#nullable enable

namespace Helicone
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Update saved query<br/>
        /// Update an existing saved query
        /// </summary>
        /// <param name="queryId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultHqlSavedQueryString> UpdateSavedQueryAsync(
            string queryId,

            global::Helicone.CreateSavedQueryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update saved query<br/>
        /// Update an existing saved query
        /// </summary>
        /// <param name="queryId"></param>
        /// <param name="name"></param>
        /// <param name="sql"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultHqlSavedQueryString> UpdateSavedQueryAsync(
            string queryId,
            string name,
            string sql,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}