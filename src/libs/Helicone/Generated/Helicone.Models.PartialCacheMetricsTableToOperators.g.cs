
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialCacheMetricsTableToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public global::Helicone.PartialTextOperators? OrganizationId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public global::Helicone.PartialTextOperators? RequestId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::Helicone.PartialTimestampOperatorsTyped? Date { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hour")]
        public global::Helicone.PartialNumberOperators? Hour { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Helicone.PartialTextOperators? Model { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_hit_count")]
        public global::Helicone.PartialNumberOperators? CacheHitCount { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_latency_ms")]
        public global::Helicone.PartialNumberOperators? SavedLatencyMs { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_completion_tokens")]
        public global::Helicone.PartialNumberOperators? SavedCompletionTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_prompt_tokens")]
        public global::Helicone.PartialNumberOperators? SavedPromptTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_completion_audio_tokens")]
        public global::Helicone.PartialNumberOperators? SavedCompletionAudioTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_prompt_audio_tokens")]
        public global::Helicone.PartialNumberOperators? SavedPromptAudioTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_prompt_cache_write_tokens")]
        public global::Helicone.PartialNumberOperators? SavedPromptCacheWriteTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_prompt_cache_read_tokens")]
        public global::Helicone.PartialNumberOperators? SavedPromptCacheReadTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_hit")]
        public global::Helicone.PartialTimestampOperatorsTyped? FirstHit { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_hit")]
        public global::Helicone.PartialTimestampOperatorsTyped? LastHit { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body")]
        public global::Helicone.PartialTextOperators? RequestBody { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_body")]
        public global::Helicone.PartialTextOperators? ResponseBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialCacheMetricsTableToOperators" /> class.
        /// </summary>
        /// <param name="organizationId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="date">
        /// Make all properties in T optional
        /// </param>
        /// <param name="hour">
        /// Make all properties in T optional
        /// </param>
        /// <param name="model">
        /// Make all properties in T optional
        /// </param>
        /// <param name="cacheHitCount">
        /// Make all properties in T optional
        /// </param>
        /// <param name="savedLatencyMs">
        /// Make all properties in T optional
        /// </param>
        /// <param name="savedCompletionTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="savedPromptTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="savedCompletionAudioTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="savedPromptAudioTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="savedPromptCacheWriteTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="savedPromptCacheReadTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="firstHit">
        /// Make all properties in T optional
        /// </param>
        /// <param name="lastHit">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestBody">
        /// Make all properties in T optional
        /// </param>
        /// <param name="responseBody">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialCacheMetricsTableToOperators(
            global::Helicone.PartialTextOperators? organizationId,
            global::Helicone.PartialTextOperators? requestId,
            global::Helicone.PartialTimestampOperatorsTyped? date,
            global::Helicone.PartialNumberOperators? hour,
            global::Helicone.PartialTextOperators? model,
            global::Helicone.PartialNumberOperators? cacheHitCount,
            global::Helicone.PartialNumberOperators? savedLatencyMs,
            global::Helicone.PartialNumberOperators? savedCompletionTokens,
            global::Helicone.PartialNumberOperators? savedPromptTokens,
            global::Helicone.PartialNumberOperators? savedCompletionAudioTokens,
            global::Helicone.PartialNumberOperators? savedPromptAudioTokens,
            global::Helicone.PartialNumberOperators? savedPromptCacheWriteTokens,
            global::Helicone.PartialNumberOperators? savedPromptCacheReadTokens,
            global::Helicone.PartialTimestampOperatorsTyped? firstHit,
            global::Helicone.PartialTimestampOperatorsTyped? lastHit,
            global::Helicone.PartialTextOperators? requestBody,
            global::Helicone.PartialTextOperators? responseBody)
        {
            this.OrganizationId = organizationId;
            this.RequestId = requestId;
            this.Date = date;
            this.Hour = hour;
            this.Model = model;
            this.CacheHitCount = cacheHitCount;
            this.SavedLatencyMs = savedLatencyMs;
            this.SavedCompletionTokens = savedCompletionTokens;
            this.SavedPromptTokens = savedPromptTokens;
            this.SavedCompletionAudioTokens = savedCompletionAudioTokens;
            this.SavedPromptAudioTokens = savedPromptAudioTokens;
            this.SavedPromptCacheWriteTokens = savedPromptCacheWriteTokens;
            this.SavedPromptCacheReadTokens = savedPromptCacheReadTokens;
            this.FirstHit = firstHit;
            this.LastHit = lastHit;
            this.RequestBody = requestBody;
            this.ResponseBody = responseBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialCacheMetricsTableToOperators" /> class.
        /// </summary>
        public PartialCacheMetricsTableToOperators()
        {
        }
    }
}