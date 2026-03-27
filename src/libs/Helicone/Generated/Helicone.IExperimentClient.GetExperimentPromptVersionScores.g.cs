#nullable enable

namespace Helicone
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Helicone.ResultRecordStringScoreV2String> GetExperimentPromptVersionScoresAsync(
            string experimentId,
            string promptVersionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}