
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialFeedbackTableToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::Helicone.PartialNumberOperators? Id { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::Helicone.PartialTimestampOperators? CreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public global::Helicone.PartialBooleanOperators? Rating { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public global::Helicone.PartialTextOperators? ResponseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialFeedbackTableToOperators" /> class.
        /// </summary>
        /// <param name="id">
        /// Make all properties in T optional
        /// </param>
        /// <param name="createdAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="rating">
        /// Make all properties in T optional
        /// </param>
        /// <param name="responseId">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialFeedbackTableToOperators(
            global::Helicone.PartialNumberOperators? id,
            global::Helicone.PartialTimestampOperators? createdAt,
            global::Helicone.PartialBooleanOperators? rating,
            global::Helicone.PartialTextOperators? responseId)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Rating = rating;
            this.ResponseId = responseId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialFeedbackTableToOperators" /> class.
        /// </summary>
        public PartialFeedbackTableToOperators()
        {
        }
    }
}