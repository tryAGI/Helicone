#nullable enable

namespace Helicone
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultNullString> CreateExperimentTableRowWithCellsBatchAsync(
            string experimentTableId,

            global::Helicone.CreateExperimentTableRowWithCellsBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="rows"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultNullString> CreateExperimentTableRowWithCellsBatchAsync(
            string experimentTableId,
            global::System.Collections.Generic.IList<global::Helicone.CreateExperimentTableRowWithCellsBatchRequestRow> rows,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}