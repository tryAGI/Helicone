
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateHeliconeDatasetRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseBody")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.JsonJsonConverter))]
        public global::Helicone.Json? ResponseBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestBody")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.JsonJsonConverter))]
        public global::Helicone.Json? RequestBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHeliconeDatasetRequestRequest" /> class.
        /// </summary>
        /// <param name="responseBody"></param>
        /// <param name="requestBody"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateHeliconeDatasetRequestRequest(
            global::Helicone.Json? responseBody,
            global::Helicone.Json? requestBody)
        {
            this.ResponseBody = responseBody;
            this.RequestBody = requestBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHeliconeDatasetRequestRequest" /> class.
        /// </summary>
        public UpdateHeliconeDatasetRequestRequest()
        {
        }
    }
}