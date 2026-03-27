#nullable enable

namespace Helicone
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Download query results as CSV<br/>
        /// Execute a SQL query and download results as CSV
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultStringString> DownloadCsvAsync(

            global::Helicone.ExecuteSqlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download query results as CSV<br/>
        /// Execute a SQL query and download results as CSV
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultStringString> DownloadCsvAsync(
            string sql,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}