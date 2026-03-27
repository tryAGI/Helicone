
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialSessionsRequestResponseRMTToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_session_id")]
        public global::Helicone.PartialTextOperators? SessionSessionId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_session_name")]
        public global::Helicone.PartialTextOperators? SessionSessionName { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_total_cost")]
        public global::Helicone.PartialNumberOperators? SessionTotalCost { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_total_tokens")]
        public global::Helicone.PartialNumberOperators? SessionTotalTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_prompt_tokens")]
        public global::Helicone.PartialNumberOperators? SessionPromptTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_completion_tokens")]
        public global::Helicone.PartialNumberOperators? SessionCompletionTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_total_requests")]
        public global::Helicone.PartialNumberOperators? SessionTotalRequests { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_created_at")]
        public global::Helicone.PartialTimestampOperatorsTyped? SessionCreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_latest_request_created_at")]
        public global::Helicone.PartialTimestampOperatorsTyped? SessionLatestRequestCreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_tag")]
        public global::Helicone.PartialTextOperators? SessionTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSessionsRequestResponseRMTToOperators" /> class.
        /// </summary>
        /// <param name="sessionSessionId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionSessionName">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionTotalCost">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionTotalTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionPromptTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionCompletionTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionTotalRequests">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionCreatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionLatestRequestCreatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionTag">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialSessionsRequestResponseRMTToOperators(
            global::Helicone.PartialTextOperators? sessionSessionId,
            global::Helicone.PartialTextOperators? sessionSessionName,
            global::Helicone.PartialNumberOperators? sessionTotalCost,
            global::Helicone.PartialNumberOperators? sessionTotalTokens,
            global::Helicone.PartialNumberOperators? sessionPromptTokens,
            global::Helicone.PartialNumberOperators? sessionCompletionTokens,
            global::Helicone.PartialNumberOperators? sessionTotalRequests,
            global::Helicone.PartialTimestampOperatorsTyped? sessionCreatedAt,
            global::Helicone.PartialTimestampOperatorsTyped? sessionLatestRequestCreatedAt,
            global::Helicone.PartialTextOperators? sessionTag)
        {
            this.SessionSessionId = sessionSessionId;
            this.SessionSessionName = sessionSessionName;
            this.SessionTotalCost = sessionTotalCost;
            this.SessionTotalTokens = sessionTotalTokens;
            this.SessionPromptTokens = sessionPromptTokens;
            this.SessionCompletionTokens = sessionCompletionTokens;
            this.SessionTotalRequests = sessionTotalRequests;
            this.SessionCreatedAt = sessionCreatedAt;
            this.SessionLatestRequestCreatedAt = sessionLatestRequestCreatedAt;
            this.SessionTag = sessionTag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSessionsRequestResponseRMTToOperators" /> class.
        /// </summary>
        public PartialSessionsRequestResponseRMTToOperators()
        {
        }
    }
}