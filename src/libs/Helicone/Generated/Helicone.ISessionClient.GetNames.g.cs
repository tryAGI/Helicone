#nullable enable

namespace Helicone
{
    public partial interface ISessionClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultSessionNameResultArrayString> GetNamesAsync(

            global::Helicone.SessionNameQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameContains"></param>
        /// <param name="timezoneDifference"></param>
        /// <param name="pSize"></param>
        /// <param name="useInterquartile"></param>
        /// <param name="timeFilter"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultSessionNameResultArrayString> GetNamesAsync(
            string nameContains,
            double timezoneDifference,
            global::Helicone.SessionNameQueryParamsPSize? pSize = default,
            bool? useInterquartile = default,
            global::Helicone.TimeFilterMs? timeFilter = default,
            global::Helicone.SessionFilterNode? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}