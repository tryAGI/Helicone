
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMResponseBodyVectorDBDetailsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.LLMResponseBodyVectorDBDetailsResponseTypeJsonConverter))]
        public global::Helicone.LLMResponseBodyVectorDBDetailsResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.LLMResponseBodyVectorDBDetailsResponseMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actualSimilarity")]
        public double? ActualSimilarity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarityThreshold")]
        public double? SimilarityThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyVectorDBDetailsResponse" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="message"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="actualSimilarity"></param>
        /// <param name="similarityThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMResponseBodyVectorDBDetailsResponse(
            global::Helicone.LLMResponseBodyVectorDBDetailsResponseMetadata metadata,
            string message,
            string status,
            global::Helicone.LLMResponseBodyVectorDBDetailsResponseType type,
            double? actualSimilarity,
            double? similarityThreshold)
        {
            this.Type = type;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ActualSimilarity = actualSimilarity;
            this.SimilarityThreshold = similarityThreshold;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyVectorDBDetailsResponse" /> class.
        /// </summary>
        public LLMResponseBodyVectorDBDetailsResponse()
        {
        }
    }
}