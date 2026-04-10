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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultNullString> UpdateExperimentCellAsync(
            string experimentTableId,

            global::Helicone.UpdateExperimentCellRequest request,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="updateInputs"></param>
        /// <param name="metadata"></param>
        /// <param name="value"></param>
        /// <param name="status"></param>
        /// <param name="cellId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultNullString> UpdateExperimentCellAsync(
            string experimentTableId,
            string cellId,
            bool? updateInputs = default,
            string? metadata = default,
            string? value = default,
            string? status = default,
            global::Helicone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}