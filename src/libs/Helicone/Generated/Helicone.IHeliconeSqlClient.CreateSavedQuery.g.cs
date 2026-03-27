#nullable enable

namespace Helicone
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Create saved query<br/>
        /// Create a new saved query
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultHqlSavedQueryArrayString> CreateSavedQueryAsync(

            global::Helicone.CreateSavedQueryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create saved query<br/>
        /// Create a new saved query
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sql"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultHqlSavedQueryArrayString> CreateSavedQueryAsync(
            string name,
            string sql,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}