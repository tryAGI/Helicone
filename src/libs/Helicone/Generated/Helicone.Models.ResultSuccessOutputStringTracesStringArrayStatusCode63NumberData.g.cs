
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Traces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData" /> class.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="traces"></param>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData(
            global::System.Collections.Generic.IList<string> traces,
            string output,
            double? statusCode)
        {
            this.Traces = traces ?? throw new global::System.ArgumentNullException(nameof(traces));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData" /> class.
        /// </summary>
        public ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData()
        {
        }
    }
}