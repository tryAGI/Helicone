
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialTablesAndViews
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metrics")]
        public global::Helicone.PartialUserMetricsToOperators? UserMetrics { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_api_keys")]
        public global::Helicone.PartialUserApiKeysTableToOperators? UserApiKeys { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::Helicone.PartialResponseTableToOperators? Response { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::Helicone.PartialRequestTableToOperators? Request { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::Helicone.PartialFeedbackTableToOperators? Feedback { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties_table")]
        public global::Helicone.PartialPropertiesTableToOperators? PropertiesTable { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_v2")]
        public global::Helicone.PartialPromptToOperators? PromptV2 { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts_versions")]
        public global::Helicone.PartialPromptVersionsToOperators? PromptsVersions { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment")]
        public global::Helicone.PartialExperimentToOperators? Experiment { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_hypothesis_run")]
        public global::Helicone.PartialExperimentHypothesisRunToOperator? ExperimentHypothesisRun { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_value")]
        public global::Helicone.PartialScoreValueToOperator? ScoreValue { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_response_log")]
        public global::Helicone.PartialRequestResponseLogToOperators? RequestResponseLog { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_response_rmt")]
        public global::Helicone.PartialRequestResponseRMTToOperators? RequestResponseRmt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions_request_response_rmt")]
        public global::Helicone.PartialSessionsRequestResponseRMTToOperators? SessionsRequestResponseRmt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_view")]
        public global::Helicone.PartialUserViewToOperators? UsersView { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties_v3")]
        public global::Helicone.PartialPropertiesV3ToOperators? PropertiesV3 { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_with_response_v1")]
        public global::Helicone.PartialPropertyWithResponseV1ToOperators? PropertyWithResponseV1 { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public global::Helicone.PartialJobToOperators? Job { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_node")]
        public global::Helicone.PartialNodesToOperators? JobNode { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_metrics")]
        public global::Helicone.PartialCacheMetricsTableToOperators? CacheMetrics { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_log")]
        public global::Helicone.PartialRateLimitTableToOperators? RateLimitLog { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_properties")]
        public global::Helicone.PartialOrganizationPropertiesToOperators? OrganizationProperties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTablesAndViews" /> class.
        /// </summary>
        /// <param name="userMetrics">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userApiKeys">
        /// Make all properties in T optional
        /// </param>
        /// <param name="response">
        /// Make all properties in T optional
        /// </param>
        /// <param name="request">
        /// Make all properties in T optional
        /// </param>
        /// <param name="feedback">
        /// Make all properties in T optional
        /// </param>
        /// <param name="propertiesTable">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptV2">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptsVersions">
        /// Make all properties in T optional
        /// </param>
        /// <param name="experiment">
        /// Make all properties in T optional
        /// </param>
        /// <param name="experimentHypothesisRun">
        /// Make all properties in T optional
        /// </param>
        /// <param name="scoreValue">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestResponseLog">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestResponseRmt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionsRequestResponseRmt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="usersView">
        /// Make all properties in T optional
        /// </param>
        /// <param name="propertiesV3">
        /// Make all properties in T optional
        /// </param>
        /// <param name="propertyWithResponseV1">
        /// Make all properties in T optional
        /// </param>
        /// <param name="job">
        /// Make all properties in T optional
        /// </param>
        /// <param name="jobNode">
        /// Make all properties in T optional
        /// </param>
        /// <param name="cacheMetrics">
        /// Make all properties in T optional
        /// </param>
        /// <param name="rateLimitLog">
        /// Make all properties in T optional
        /// </param>
        /// <param name="organizationProperties">
        /// Make all properties in T optional
        /// </param>
        /// <param name="properties"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialTablesAndViews(
            global::Helicone.PartialUserMetricsToOperators? userMetrics,
            global::Helicone.PartialUserApiKeysTableToOperators? userApiKeys,
            global::Helicone.PartialResponseTableToOperators? response,
            global::Helicone.PartialRequestTableToOperators? request,
            global::Helicone.PartialFeedbackTableToOperators? feedback,
            global::Helicone.PartialPropertiesTableToOperators? propertiesTable,
            global::Helicone.PartialPromptToOperators? promptV2,
            global::Helicone.PartialPromptVersionsToOperators? promptsVersions,
            global::Helicone.PartialExperimentToOperators? experiment,
            global::Helicone.PartialExperimentHypothesisRunToOperator? experimentHypothesisRun,
            global::Helicone.PartialScoreValueToOperator? scoreValue,
            global::Helicone.PartialRequestResponseLogToOperators? requestResponseLog,
            global::Helicone.PartialRequestResponseRMTToOperators? requestResponseRmt,
            global::Helicone.PartialSessionsRequestResponseRMTToOperators? sessionsRequestResponseRmt,
            global::Helicone.PartialUserViewToOperators? usersView,
            global::Helicone.PartialPropertiesV3ToOperators? propertiesV3,
            global::Helicone.PartialPropertyWithResponseV1ToOperators? propertyWithResponseV1,
            global::Helicone.PartialJobToOperators? job,
            global::Helicone.PartialNodesToOperators? jobNode,
            global::Helicone.PartialCacheMetricsTableToOperators? cacheMetrics,
            global::Helicone.PartialRateLimitTableToOperators? rateLimitLog,
            global::Helicone.PartialOrganizationPropertiesToOperators? organizationProperties,
            global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? properties,
            global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? values)
        {
            this.UserMetrics = userMetrics;
            this.UserApiKeys = userApiKeys;
            this.Response = response;
            this.Request = request;
            this.Feedback = feedback;
            this.PropertiesTable = propertiesTable;
            this.PromptV2 = promptV2;
            this.PromptsVersions = promptsVersions;
            this.Experiment = experiment;
            this.ExperimentHypothesisRun = experimentHypothesisRun;
            this.ScoreValue = scoreValue;
            this.RequestResponseLog = requestResponseLog;
            this.RequestResponseRmt = requestResponseRmt;
            this.SessionsRequestResponseRmt = sessionsRequestResponseRmt;
            this.UsersView = usersView;
            this.PropertiesV3 = propertiesV3;
            this.PropertyWithResponseV1 = propertyWithResponseV1;
            this.Job = job;
            this.JobNode = jobNode;
            this.CacheMetrics = cacheMetrics;
            this.RateLimitLog = rateLimitLog;
            this.OrganizationProperties = organizationProperties;
            this.Properties = properties;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTablesAndViews" /> class.
        /// </summary>
        public PartialTablesAndViews()
        {
        }
    }
}