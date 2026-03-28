#nullable enable

namespace Helicone
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultTableIdStringExperimentIdStringString> CreateNewExperimentTableAsync(

            global::Helicone.CreateExperimentTableParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="experimentMetadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="promptVersionId"></param>
        /// <param name="newHeliconeTemplate"></param>
        /// <param name="isMajorVersion"></param>
        /// <param name="promptSubversionMetadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="experimentTableMetadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultTableIdStringExperimentIdStringString> CreateNewExperimentTableAsync(
            string datasetId,
            global::Helicone.RecordStringAny experimentMetadata,
            string promptVersionId,
            string newHeliconeTemplate,
            bool isMajorVersion,
            global::Helicone.RecordStringAny promptSubversionMetadata,
            global::Helicone.RecordStringAny? experimentTableMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}