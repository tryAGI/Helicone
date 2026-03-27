
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SortLeafUsers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_for")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? ActiveFor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_active")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? FirstActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? LastActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? TotalRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_requests_per_day_active")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? AverageRequestsPerDayActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_tokens_per_request")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? AverageTokensPerRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? TotalPromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_completion_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? TotalCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limited_count")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? RateLimitedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SortLeafUsers" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="activeFor"></param>
        /// <param name="firstActive"></param>
        /// <param name="lastActive"></param>
        /// <param name="totalRequests"></param>
        /// <param name="averageRequestsPerDayActive"></param>
        /// <param name="averageTokensPerRequest"></param>
        /// <param name="totalPromptTokens"></param>
        /// <param name="totalCompletionTokens"></param>
        /// <param name="cost"></param>
        /// <param name="rateLimitedCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SortLeafUsers(
            global::Helicone.SortDirection? id,
            global::Helicone.SortDirection? userId,
            global::Helicone.SortDirection? activeFor,
            global::Helicone.SortDirection? firstActive,
            global::Helicone.SortDirection? lastActive,
            global::Helicone.SortDirection? totalRequests,
            global::Helicone.SortDirection? averageRequestsPerDayActive,
            global::Helicone.SortDirection? averageTokensPerRequest,
            global::Helicone.SortDirection? totalPromptTokens,
            global::Helicone.SortDirection? totalCompletionTokens,
            global::Helicone.SortDirection? cost,
            global::Helicone.SortDirection? rateLimitedCount)
        {
            this.Id = id;
            this.UserId = userId;
            this.ActiveFor = activeFor;
            this.FirstActive = firstActive;
            this.LastActive = lastActive;
            this.TotalRequests = totalRequests;
            this.AverageRequestsPerDayActive = averageRequestsPerDayActive;
            this.AverageTokensPerRequest = averageTokensPerRequest;
            this.TotalPromptTokens = totalPromptTokens;
            this.TotalCompletionTokens = totalCompletionTokens;
            this.Cost = cost;
            this.RateLimitedCount = rateLimitedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortLeafUsers" /> class.
        /// </summary>
        public SortLeafUsers()
        {
        }
    }
}