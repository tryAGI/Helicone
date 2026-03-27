
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialUserMetricsToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::Helicone.PartialTextOperators? UserId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active")]
        public global::Helicone.PartialTimestampOperators? LastActive { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        public global::Helicone.PartialNumberOperators? TotalRequests { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_for")]
        public global::Helicone.PartialNumberOperators? ActiveFor { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_requests_per_day_active")]
        public global::Helicone.PartialNumberOperators? AverageRequestsPerDayActive { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_tokens_per_request")]
        public global::Helicone.PartialNumberOperators? AverageTokensPerRequest { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_completion_tokens")]
        public global::Helicone.PartialNumberOperators? TotalCompletionTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_prompt_tokens")]
        public global::Helicone.PartialNumberOperators? TotalPromptTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public global::Helicone.PartialNumberOperators? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialUserMetricsToOperators" /> class.
        /// </summary>
        /// <param name="userId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="lastActive">
        /// Make all properties in T optional
        /// </param>
        /// <param name="totalRequests">
        /// Make all properties in T optional
        /// </param>
        /// <param name="activeFor">
        /// Make all properties in T optional
        /// </param>
        /// <param name="averageRequestsPerDayActive">
        /// Make all properties in T optional
        /// </param>
        /// <param name="averageTokensPerRequest">
        /// Make all properties in T optional
        /// </param>
        /// <param name="totalCompletionTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="totalPromptTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="cost">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialUserMetricsToOperators(
            global::Helicone.PartialTextOperators? userId,
            global::Helicone.PartialTimestampOperators? lastActive,
            global::Helicone.PartialNumberOperators? totalRequests,
            global::Helicone.PartialNumberOperators? activeFor,
            global::Helicone.PartialNumberOperators? averageRequestsPerDayActive,
            global::Helicone.PartialNumberOperators? averageTokensPerRequest,
            global::Helicone.PartialNumberOperators? totalCompletionTokens,
            global::Helicone.PartialNumberOperators? totalPromptTokens,
            global::Helicone.PartialNumberOperators? cost)
        {
            this.UserId = userId;
            this.LastActive = lastActive;
            this.TotalRequests = totalRequests;
            this.ActiveFor = activeFor;
            this.AverageRequestsPerDayActive = averageRequestsPerDayActive;
            this.AverageTokensPerRequest = averageTokensPerRequest;
            this.TotalCompletionTokens = totalCompletionTokens;
            this.TotalPromptTokens = totalPromptTokens;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialUserMetricsToOperators" /> class.
        /// </summary>
        public PartialUserMetricsToOperators()
        {
        }
    }
}