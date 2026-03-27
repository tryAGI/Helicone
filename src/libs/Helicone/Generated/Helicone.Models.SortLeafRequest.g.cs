
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SortLeafRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("random")]
        public bool? Random { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? CacheCreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? LastActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? BodyModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_cached")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? IsCached { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? RequestPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_text")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? ResponseText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.SortDirection>? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.SortDirection>? Values { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_to_first_token")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter))]
        public global::Helicone.SortDirection? TimeToFirstToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SortLeafRequest" /> class.
        /// </summary>
        /// <param name="random"></param>
        /// <param name="createdAt"></param>
        /// <param name="cacheCreatedAt"></param>
        /// <param name="latency"></param>
        /// <param name="lastActive"></param>
        /// <param name="totalTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="userId"></param>
        /// <param name="bodyModel"></param>
        /// <param name="isCached"></param>
        /// <param name="requestPrompt"></param>
        /// <param name="responseText"></param>
        /// <param name="properties"></param>
        /// <param name="values"></param>
        /// <param name="cost"></param>
        /// <param name="timeToFirstToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SortLeafRequest(
            bool? random,
            global::Helicone.SortDirection? createdAt,
            global::Helicone.SortDirection? cacheCreatedAt,
            global::Helicone.SortDirection? latency,
            global::Helicone.SortDirection? lastActive,
            global::Helicone.SortDirection? totalTokens,
            global::Helicone.SortDirection? completionTokens,
            global::Helicone.SortDirection? promptTokens,
            global::Helicone.SortDirection? userId,
            global::Helicone.SortDirection? bodyModel,
            global::Helicone.SortDirection? isCached,
            global::Helicone.SortDirection? requestPrompt,
            global::Helicone.SortDirection? responseText,
            global::System.Collections.Generic.Dictionary<string, global::Helicone.SortDirection>? properties,
            global::System.Collections.Generic.Dictionary<string, global::Helicone.SortDirection>? values,
            global::Helicone.SortDirection? cost,
            global::Helicone.SortDirection? timeToFirstToken)
        {
            this.Random = random;
            this.CreatedAt = createdAt;
            this.CacheCreatedAt = cacheCreatedAt;
            this.Latency = latency;
            this.LastActive = lastActive;
            this.TotalTokens = totalTokens;
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.UserId = userId;
            this.BodyModel = bodyModel;
            this.IsCached = isCached;
            this.RequestPrompt = requestPrompt;
            this.ResponseText = responseText;
            this.Properties = properties;
            this.Values = values;
            this.Cost = cost;
            this.TimeToFirstToken = timeToFirstToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortLeafRequest" /> class.
        /// </summary>
        public SortLeafRequest()
        {
        }
    }
}