#nullable enable

namespace Helicone
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Get database schema<br/>
        /// Get ClickHouse schema (tables and columns)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultClickHouseTableSchemaArrayString> GetClickHouseSchemaAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}