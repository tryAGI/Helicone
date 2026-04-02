
#nullable enable

namespace Helicone
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class HeliconeClient : global::Helicone.IHeliconeClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.helicone.ai/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Helicone.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Helicone.JsonConverters.DataEntryVariant1TypeJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant1TypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant2TypeJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant2TypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant3ContentJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant3ContentNullableJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant3TypeJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant3TypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant4ContentJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant4ContentNullableJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant4TypeJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryVariant4TypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant1TypeJsonConverter(),
                    new global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant1TypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant2TypeJsonConverter(),
                    new global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant2TypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.EvaluatorStatsRecentTrendJsonConverter(),
                    new global::Helicone.JsonConverters.EvaluatorStatsRecentTrendNullableJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestMessageToolCallTypeJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestMessageToolCallTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestToolTypeJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestToolTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnumFunctionTypeJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnumFunctionTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnum2JsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnum2NullableJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestReasoningEffortJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestReasoningEffortNullableJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestVerbosityJsonConverter(),
                    new global::Helicone.JsonConverters.OpenAIChatRequestVerbosityNullableJsonConverter(),
                    new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallTypeJsonConverter(),
                    new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolTypeJsonConverter(),
                    new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolChoiceFunctionTypeJsonConverter(),
                    new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolChoiceFunctionTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.PromptsFilterNodeEnumJsonConverter(),
                    new global::Helicone.JsonConverters.PromptsFilterNodeEnumNullableJsonConverter(),
                    new global::Helicone.JsonConverters.PromptsFilterBranchOperatorJsonConverter(),
                    new global::Helicone.JsonConverters.PromptsFilterBranchOperatorNullableJsonConverter(),
                    new global::Helicone.JsonConverters.PromptVersionsFilterNodeEnumJsonConverter(),
                    new global::Helicone.JsonConverters.PromptVersionsFilterNodeEnumNullableJsonConverter(),
                    new global::Helicone.JsonConverters.PromptVersionsFilterBranchOperatorJsonConverter(),
                    new global::Helicone.JsonConverters.PromptVersionsFilterBranchOperatorNullableJsonConverter(),
                    new global::Helicone.JsonConverters.UpgradeToProRequestUiModeJsonConverter(),
                    new global::Helicone.JsonConverters.UpgradeToProRequestUiModeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.UpgradeToTeamBundleRequestUiModeJsonConverter(),
                    new global::Helicone.JsonConverters.UpgradeToTeamBundleRequestUiModeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.RequestFilterNodeEnumJsonConverter(),
                    new global::Helicone.JsonConverters.RequestFilterNodeEnumNullableJsonConverter(),
                    new global::Helicone.JsonConverters.RequestFilterBranchOperatorJsonConverter(),
                    new global::Helicone.JsonConverters.RequestFilterBranchOperatorNullableJsonConverter(),
                    new global::Helicone.JsonConverters.SortDirectionJsonConverter(),
                    new global::Helicone.JsonConverters.SortDirectionNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ProviderNameJsonConverter(),
                    new global::Helicone.JsonConverters.ProviderNameNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ModelProviderNameJsonConverter(),
                    new global::Helicone.JsonConverters.ModelProviderNameNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ProviderEnumJsonConverter(),
                    new global::Helicone.JsonConverters.ProviderEnumNullableJsonConverter(),
                    new global::Helicone.JsonConverters.LlmTypeJsonConverter(),
                    new global::Helicone.JsonConverters.LlmTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.MessageAnnotationTypeJsonConverter(),
                    new global::Helicone.JsonConverters.MessageAnnotationTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.MessageTypeJsonConverter(),
                    new global::Helicone.JsonConverters.MessageTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.MessageRoleJsonConverter(),
                    new global::Helicone.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::Helicone.JsonConverters.MessageType2JsonConverter(),
                    new global::Helicone.JsonConverters.MessageType2NullableJsonConverter(),
                    new global::Helicone.JsonConverters.HeliconeEventToolTypeJsonConverter(),
                    new global::Helicone.JsonConverters.HeliconeEventToolTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.HeliconeEventVectorDBTypeJsonConverter(),
                    new global::Helicone.JsonConverters.HeliconeEventVectorDBTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.HeliconeEventVectorDBOperationJsonConverter(),
                    new global::Helicone.JsonConverters.HeliconeEventVectorDBOperationNullableJsonConverter(),
                    new global::Helicone.JsonConverters.HeliconeEventDataTypeJsonConverter(),
                    new global::Helicone.JsonConverters.HeliconeEventDataTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.LLMRequestBodyReasoningEffortJsonConverter(),
                    new global::Helicone.JsonConverters.LLMRequestBodyReasoningEffortNullableJsonConverter(),
                    new global::Helicone.JsonConverters.LLMRequestBodyVerbosityJsonConverter(),
                    new global::Helicone.JsonConverters.LLMRequestBodyVerbosityNullableJsonConverter(),
                    new global::Helicone.JsonConverters.LLMRequestBodyToolChoiceTypeJsonConverter(),
                    new global::Helicone.JsonConverters.LLMRequestBodyToolChoiceTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ResponseTypeJsonConverter(),
                    new global::Helicone.JsonConverters.ResponseTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ResponseRoleJsonConverter(),
                    new global::Helicone.JsonConverters.ResponseRoleNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ResponseType2JsonConverter(),
                    new global::Helicone.JsonConverters.ResponseType2NullableJsonConverter(),
                    new global::Helicone.JsonConverters.LLMResponseBodyDataDetailsResponseTypeJsonConverter(),
                    new global::Helicone.JsonConverters.LLMResponseBodyDataDetailsResponseTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.LLMResponseBodyVectorDBDetailsResponseTypeJsonConverter(),
                    new global::Helicone.JsonConverters.LLMResponseBodyVectorDBDetailsResponseTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.LLMResponseBodyToolDetailsResponseTypeJsonConverter(),
                    new global::Helicone.JsonConverters.LLMResponseBodyToolDetailsResponseTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.UserFilterNodeEnumJsonConverter(),
                    new global::Helicone.JsonConverters.UserFilterNodeEnumNullableJsonConverter(),
                    new global::Helicone.JsonConverters.UserFilterBranchOperatorJsonConverter(),
                    new global::Helicone.JsonConverters.UserFilterBranchOperatorNullableJsonConverter(),
                    new global::Helicone.JsonConverters.PSizeJsonConverter(),
                    new global::Helicone.JsonConverters.PSizeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.StatsTimeFrameJsonConverter(),
                    new global::Helicone.JsonConverters.StatsTimeFrameNullableJsonConverter(),
                    new global::Helicone.JsonConverters.SessionFilterNodeEnumJsonConverter(),
                    new global::Helicone.JsonConverters.SessionFilterNodeEnumNullableJsonConverter(),
                    new global::Helicone.JsonConverters.SessionFilterBranchOperatorJsonConverter(),
                    new global::Helicone.JsonConverters.SessionFilterBranchOperatorNullableJsonConverter(),
                    new global::Helicone.JsonConverters.SessionNameQueryParamsPSizeJsonConverter(),
                    new global::Helicone.JsonConverters.SessionNameQueryParamsPSizeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.SessionMetricsQueryParamsPSizeJsonConverter(),
                    new global::Helicone.JsonConverters.SessionMetricsQueryParamsPSizeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.TimeFrameJsonConverter(),
                    new global::Helicone.JsonConverters.TimeFrameNullableJsonConverter(),
                    new global::Helicone.JsonConverters.FilterNodeEnum2JsonConverter(),
                    new global::Helicone.JsonConverters.FilterNodeEnum2NullableJsonConverter(),
                    new global::Helicone.JsonConverters.FilterBranchOperatorJsonConverter(),
                    new global::Helicone.JsonConverters.FilterBranchOperatorNullableJsonConverter(),
                    new global::Helicone.JsonConverters.RequestClickhouseFilterNodeEnumJsonConverter(),
                    new global::Helicone.JsonConverters.RequestClickhouseFilterNodeEnumNullableJsonConverter(),
                    new global::Helicone.JsonConverters.RequestClickhouseFilterBranchOperatorJsonConverter(),
                    new global::Helicone.JsonConverters.RequestClickhouseFilterBranchOperatorNullableJsonConverter(),
                    new global::Helicone.JsonConverters.TimeIncrementJsonConverter(),
                    new global::Helicone.JsonConverters.TimeIncrementNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionMessageAnnotationTypeJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionMessageAnnotationTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionMessageFunctionToolCallTypeJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionMessageFunctionToolCallTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionMessageCustomToolCallTypeJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionMessageCustomToolCallTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionMessageRoleJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionObjectJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionObjectNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionServiceTierJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionServiceTierNullableJsonConverter(),
                    new global::Helicone.JsonConverters.AuthorNameJsonConverter(),
                    new global::Helicone.JsonConverters.AuthorNameNullableJsonConverter(),
                    new global::Helicone.JsonConverters.StandardParameterJsonConverter(),
                    new global::Helicone.JsonConverters.StandardParameterNullableJsonConverter(),
                    new global::Helicone.JsonConverters.PluginIdJsonConverter(),
                    new global::Helicone.JsonConverters.PluginIdNullableJsonConverter(),
                    new global::Helicone.JsonConverters.BodyMappingTypeJsonConverter(),
                    new global::Helicone.JsonConverters.BodyMappingTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ResponseFormatJsonConverter(),
                    new global::Helicone.JsonConverters.ResponseFormatNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ModelProviderConfigQuantizationJsonConverter(),
                    new global::Helicone.JsonConverters.ModelProviderConfigQuantizationNullableJsonConverter(),
                    new global::Helicone.JsonConverters.InputModalityJsonConverter(),
                    new global::Helicone.JsonConverters.InputModalityNullableJsonConverter(),
                    new global::Helicone.JsonConverters.OutputModalityJsonConverter(),
                    new global::Helicone.JsonConverters.OutputModalityNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ModelCapabilityJsonConverter(),
                    new global::Helicone.JsonConverters.ModelCapabilityNullableJsonConverter(),
                    new global::Helicone.JsonConverters.OAIModelObjectJsonConverter(),
                    new global::Helicone.JsonConverters.OAIModelObjectNullableJsonConverter(),
                    new global::Helicone.JsonConverters.OAIModelsResponseObjectJsonConverter(),
                    new global::Helicone.JsonConverters.OAIModelsResponseObjectNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ExperimentFilterNodeEnumJsonConverter(),
                    new global::Helicone.JsonConverters.ExperimentFilterNodeEnumNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ExperimentFilterBranchOperatorJsonConverter(),
                    new global::Helicone.JsonConverters.ExperimentFilterBranchOperatorNullableJsonConverter(),
                    new global::Helicone.JsonConverters.NewDatasetParamsDatasetTypeJsonConverter(),
                    new global::Helicone.JsonConverters.NewDatasetParamsDatasetTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.DatasetFilterNodeEnumJsonConverter(),
                    new global::Helicone.JsonConverters.DatasetFilterNodeEnumNullableJsonConverter(),
                    new global::Helicone.JsonConverters.DatasetFilterBranchOperatorJsonConverter(),
                    new global::Helicone.JsonConverters.DatasetFilterBranchOperatorNullableJsonConverter(),
                    new global::Helicone.JsonConverters.EvalFilterNodeEnumJsonConverter(),
                    new global::Helicone.JsonConverters.EvalFilterNodeEnumNullableJsonConverter(),
                    new global::Helicone.JsonConverters.EvalFilterBranchOperatorJsonConverter(),
                    new global::Helicone.JsonConverters.EvalFilterBranchOperatorNullableJsonConverter(),
                    new global::Helicone.JsonConverters.CreateAPIKeyRequestKeyPermissionsJsonConverter(),
                    new global::Helicone.JsonConverters.CreateAPIKeyRequestKeyPermissionsNullableJsonConverter(),
                    new global::Helicone.JsonConverters.TrackShareRequestPlatformJsonConverter(),
                    new global::Helicone.JsonConverters.TrackShareRequestPlatformNullableJsonConverter(),
                    new global::Helicone.JsonConverters.CreateNewExperimentHypothesisRequestStatusJsonConverter(),
                    new global::Helicone.JsonConverters.CreateNewExperimentHypothesisRequestStatusNullableJsonConverter(),
                    new global::Helicone.JsonConverters.AddOnsProductTypeJsonConverter(),
                    new global::Helicone.JsonConverters.AddOnsProductTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.DeleteAddOnsProductTypeJsonConverter(),
                    new global::Helicone.JsonConverters.DeleteAddOnsProductTypeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.GetSpendBreakdownTimeRangeJsonConverter(),
                    new global::Helicone.JsonConverters.GetSpendBreakdownTimeRangeNullableJsonConverter(),
                    new global::Helicone.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameJsonConverter(),
                    new global::Helicone.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameNullableJsonConverter(),
                    new global::Helicone.JsonConverters.ResultIdStringProviderNameStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultEvaluatorResultStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultEvaluatorResultArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultNullStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultEvaluatorExperimentArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultOnlineEvaluatorByEvaluatorIdArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultOutputStringTracesStringArrayStatusCode63NumberStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultEvaluatorScoreStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultScoreNumberInputStringOutputStringGroundTruth63StringStringJsonConverter(),
                    new global::Helicone.JsonConverters.DataEntryJsonConverter(),
                    new global::Helicone.JsonConverters.LastMileConfigFormJsonConverter(),
                    new global::Helicone.JsonConverters.ResultEvaluatorStatsStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPrompt2025StringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultStringArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPrompt2025InputStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPromptCreateResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultIdStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultNumberStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPrompt2025ArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPrompt2025VersionStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPrompt2025VersionArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPromptVersionCountsStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPrompt2025Version91PromptBody93StringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHasPromptsBooleanStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPromptsResultArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.PromptsFilterNodeJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPromptResultStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultCreatePromptResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultMetadataRecordStringAnyStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPromptVersionResultStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPromptInputRecordArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPromptVersionResultArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.PromptVersionsFilterNodeJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPromptVersionResultCompiledStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPromptVersionResultFilledStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultExperimentIdStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultExperimentV2ArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultExtendedExperimentDataStringJsonConverter(),
                    new global::Helicone.JsonConverters.JsonJsonConverter(),
                    new global::Helicone.JsonConverters.ResultExperimentV2PromptVersionArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultBooleanStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultRecordStringScoreV2StringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultScoreV2OrNullStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultArrayIntegrationStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultIntegrationStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultArrayIdStringNameStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.RequestFilterNodeJsonConverter(),
                    new global::Helicone.JsonConverters.ProviderJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHeliconeRequestArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHeliconeRequestStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHeliconeRequestAssetStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultWrappedStatsStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHasDataBooleanStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultSuccessBooleanMessageStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultIsOnWaitlistBooleanStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultCountNumberStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultSuccessBooleanNewPosition63NumberMessageStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultDecryptedProviderKeyArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultDecryptedProviderKeyStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.UserFilterNodeJsonConverter(),
                    new global::Helicone.JsonConverters.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultModelUsageResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultMarketShareResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultProviderUsageResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultAuthorStatsResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultProviderStatsResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultModelStatsResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultSessionResultArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.SessionFilterNodeJsonConverter(),
                    new global::Helicone.JsonConverters.ResultSessionsAggregateMetricsStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultSessionNameResultArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultSessionMetricsStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultStringOrNullStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultProviderMetricsArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultProviderMetricsStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultProviderMetricArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.FilterNodeJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.RequestClickhouseFilterNodeJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPropertyArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultValueStringCostNumberArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultValueStringCountNumberArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ChatCompletionMessageToolCallJsonConverter(),
                    new global::Helicone.JsonConverters.ResultChatCompletionOrContentStringReasoningStringCallsAnyStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultApiKeyStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultCostNumberCreatedAtTruncStringArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultModelRegistryResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.TokenMetricStatsJsonConverter(),
                    new global::Helicone.JsonConverters.ResultModelArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultTokensPerRequestStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultRequestsOverTimeArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultCostOverTimeArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultTokensOverTimeArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultLatencyOverTimeArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultTimeToFirstTokenOverTimeArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultUsersOverTimeArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultThreatsOverTimeArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultErrorOverTimeArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultModelMetricArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultCountryDataArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultQuantilesArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultUnsafeBooleanStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultClickHouseTableSchemaArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultExecuteSqlResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultArrayHqlSavedQueryStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHqlSavedQueryOrNullStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultVoidStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHqlSavedQueryArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHqlSavedQueryStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultTableIdStringExperimentIdStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultExperimentTableStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultExperimentTableSimplifiedStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultExperimentTableSimplifiedArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHypothesisIdStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultRunsCountNumberScoresRecordStringScoreStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultExperimentArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ExperimentFilterNodeJsonConverter(),
                    new global::Helicone.JsonConverters.ResultDatasetIdStringStringJsonConverter(),
                    new global::Helicone.JsonConverters.DatasetFilterNodeJsonConverter(),
                    new global::Helicone.JsonConverters.ResultDatasetResultArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHeliconeDatasetRowArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultHeliconeDatasetArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultEvalArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.EvalFilterNodeJsonConverter(),
                    new global::Helicone.JsonConverters.ResultScoreDistributionArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultCreditBalanceResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPaginatedPurchasedCreditsStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultTotalSpendNumberStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultSpendBreakdownResponseStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultPTBInvoiceArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultOrgDiscountArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultInAppThreadStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultSuccessBooleanStringJsonConverter(),
                    new global::Helicone.JsonConverters.ResultThreadSummaryArrayStringJsonConverter(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.LastMileConfigFormVariant2Variant1, global::Helicone.LastMileConfigFormVariant2Variant2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.OpenAIChatRequestFunctionCall>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.Prompt2025VersionPromptBodyToolChoice>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, string>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.MessageRole?>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>(),
                    new global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ChatCompletion, global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, string>(),
                    new global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.DataOverTimeRequest, global::Helicone.GetPropertiesOverTimeRequest2>(),
                    new global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest2>(),
                    new global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultSuccessUnknown, global::Helicone.ResultErrorUnknown>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ValidationResult, object>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.HidePropertyResponse2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.RestorePropertyResponse2>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessUnknown>(),
                    new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorUnknown, global::Helicone.ResultSuccessAny>(),
                    new global::Helicone.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AdminAlertBannerClient AdminAlertBanner => new AdminAlertBannerClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentClient Agent => new AgentClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeyClient ApiKey => new ApiKeyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ComparisonClient Comparison => new ComparisonClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CreditsClient Credits => new CreditsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CustomerClient Customer => new CustomerClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DashboardClient Dashboard => new DashboardClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetClient Dataset => new DatasetClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvalsClient Evals => new EvalsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvaluatorClient Evaluator => new EvaluatorClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExperimentClient Experiment => new ExperimentClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public HeliconeSqlClient HeliconeSql => new HeliconeSqlClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public IntegrationClient Integration => new IntegrationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics => new MetricsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelRegistryClient ModelRegistry => new ModelRegistryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PiClient Pi => new PiClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundClient Playground => new PlaygroundClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt => new PromptClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Prompt2025Client Prompt2025 => new Prompt2025Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Prompt2025V2Client Prompt2025V2 => new Prompt2025V2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PropertyClient Property => new PropertyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProvidersClient Providers => new ProvidersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RequestClient Request => new RequestClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SecurityClient Security => new SecurityClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SessionClient Session => new SessionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StatsClient Stats => new StatsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StatusClient Status => new StatusClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StripeClient Stripe => new StripeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TestClient Test => new TestClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TraceClient Trace => new TraceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UserClient User => new UserClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VaultClient Vault => new VaultClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WaitlistClient Waitlist => new WaitlistClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WrappedClient Wrapped => new WrappedClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the HeliconeClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public HeliconeClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Helicone.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Helicone.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}