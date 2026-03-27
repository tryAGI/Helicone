
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialUserViewToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_user_id")]
        public global::Helicone.PartialTextOperators? UserUserId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_active_for")]
        public global::Helicone.PartialNumberOperators? UserActiveFor { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_first_active")]
        public global::Helicone.PartialTimestampOperatorsTyped? UserFirstActive { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_last_active")]
        public global::Helicone.PartialTimestampOperatorsTyped? UserLastActive { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_total_requests")]
        public global::Helicone.PartialNumberOperators? UserTotalRequests { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_average_requests_per_day_active")]
        public global::Helicone.PartialNumberOperators? UserAverageRequestsPerDayActive { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_average_tokens_per_request")]
        public global::Helicone.PartialNumberOperators? UserAverageTokensPerRequest { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_total_completion_tokens")]
        public global::Helicone.PartialNumberOperators? UserTotalCompletionTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_total_prompt_tokens")]
        public global::Helicone.PartialNumberOperators? UserTotalPromptTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_cost")]
        public global::Helicone.PartialNumberOperators? UserCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialUserViewToOperators" /> class.
        /// </summary>
        /// <param name="userUserId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userActiveFor">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userFirstActive">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userLastActive">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userTotalRequests">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userAverageRequestsPerDayActive">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userAverageTokensPerRequest">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userTotalCompletionTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userTotalPromptTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userCost">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialUserViewToOperators(
            global::Helicone.PartialTextOperators? userUserId,
            global::Helicone.PartialNumberOperators? userActiveFor,
            global::Helicone.PartialTimestampOperatorsTyped? userFirstActive,
            global::Helicone.PartialTimestampOperatorsTyped? userLastActive,
            global::Helicone.PartialNumberOperators? userTotalRequests,
            global::Helicone.PartialNumberOperators? userAverageRequestsPerDayActive,
            global::Helicone.PartialNumberOperators? userAverageTokensPerRequest,
            global::Helicone.PartialNumberOperators? userTotalCompletionTokens,
            global::Helicone.PartialNumberOperators? userTotalPromptTokens,
            global::Helicone.PartialNumberOperators? userCost)
        {
            this.UserUserId = userUserId;
            this.UserActiveFor = userActiveFor;
            this.UserFirstActive = userFirstActive;
            this.UserLastActive = userLastActive;
            this.UserTotalRequests = userTotalRequests;
            this.UserAverageRequestsPerDayActive = userAverageRequestsPerDayActive;
            this.UserAverageTokensPerRequest = userAverageTokensPerRequest;
            this.UserTotalCompletionTokens = userTotalCompletionTokens;
            this.UserTotalPromptTokens = userTotalPromptTokens;
            this.UserCost = userCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialUserViewToOperators" /> class.
        /// </summary>
        public PartialUserViewToOperators()
        {
        }
    }
}