
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Helicone.JsonConverters.DataEntryVariant1TypeJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant1TypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant2TypeJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant2TypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant3ContentJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant3ContentNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant3TypeJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant3TypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant4ContentJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant4ContentNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant4TypeJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryVariant4TypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant1TypeJsonConverter),

            typeof(global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant1TypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant2TypeJsonConverter),

            typeof(global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant2TypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.EvaluatorStatsRecentTrendJsonConverter),

            typeof(global::Helicone.JsonConverters.EvaluatorStatsRecentTrendNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestMessageToolCallTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestMessageToolCallTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestToolTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestToolTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnumFunctionTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnumFunctionTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnum2JsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnum2NullableJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestReasoningEffortJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestReasoningEffortNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestVerbosityJsonConverter),

            typeof(global::Helicone.JsonConverters.OpenAIChatRequestVerbosityNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolChoiceFunctionTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolChoiceFunctionTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.PromptsFilterNodeEnumJsonConverter),

            typeof(global::Helicone.JsonConverters.PromptsFilterNodeEnumNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.PromptsFilterBranchOperatorJsonConverter),

            typeof(global::Helicone.JsonConverters.PromptsFilterBranchOperatorNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.PromptVersionsFilterNodeEnumJsonConverter),

            typeof(global::Helicone.JsonConverters.PromptVersionsFilterNodeEnumNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.PromptVersionsFilterBranchOperatorJsonConverter),

            typeof(global::Helicone.JsonConverters.PromptVersionsFilterBranchOperatorNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.UpgradeToProRequestUiModeJsonConverter),

            typeof(global::Helicone.JsonConverters.UpgradeToProRequestUiModeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.UpgradeToTeamBundleRequestUiModeJsonConverter),

            typeof(global::Helicone.JsonConverters.UpgradeToTeamBundleRequestUiModeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.RequestFilterNodeEnumJsonConverter),

            typeof(global::Helicone.JsonConverters.RequestFilterNodeEnumNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.RequestFilterBranchOperatorJsonConverter),

            typeof(global::Helicone.JsonConverters.RequestFilterBranchOperatorNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.SortDirectionJsonConverter),

            typeof(global::Helicone.JsonConverters.SortDirectionNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ProviderNameJsonConverter),

            typeof(global::Helicone.JsonConverters.ProviderNameNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ModelProviderNameJsonConverter),

            typeof(global::Helicone.JsonConverters.ModelProviderNameNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ProviderEnumJsonConverter),

            typeof(global::Helicone.JsonConverters.ProviderEnumNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.LlmTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.LlmTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.MessageAnnotationTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.MessageAnnotationTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.MessageTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.MessageTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.MessageRoleJsonConverter),

            typeof(global::Helicone.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.MessageType2JsonConverter),

            typeof(global::Helicone.JsonConverters.MessageType2NullableJsonConverter),

            typeof(global::Helicone.JsonConverters.HeliconeEventToolTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.HeliconeEventToolTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.HeliconeEventVectorDBTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.HeliconeEventVectorDBTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.HeliconeEventVectorDBOperationJsonConverter),

            typeof(global::Helicone.JsonConverters.HeliconeEventVectorDBOperationNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.HeliconeEventDataTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.HeliconeEventDataTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMRequestBodyReasoningEffortJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMRequestBodyReasoningEffortNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMRequestBodyVerbosityJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMRequestBodyVerbosityNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMRequestBodyToolChoiceTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMRequestBodyToolChoiceTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ResponseTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.ResponseTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ResponseRoleJsonConverter),

            typeof(global::Helicone.JsonConverters.ResponseRoleNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ResponseType2JsonConverter),

            typeof(global::Helicone.JsonConverters.ResponseType2NullableJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMResponseBodyDataDetailsResponseTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMResponseBodyDataDetailsResponseTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMResponseBodyVectorDBDetailsResponseTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMResponseBodyVectorDBDetailsResponseTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMResponseBodyToolDetailsResponseTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.LLMResponseBodyToolDetailsResponseTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.UserFilterNodeEnumJsonConverter),

            typeof(global::Helicone.JsonConverters.UserFilterNodeEnumNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.UserFilterBranchOperatorJsonConverter),

            typeof(global::Helicone.JsonConverters.UserFilterBranchOperatorNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.PSizeJsonConverter),

            typeof(global::Helicone.JsonConverters.PSizeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.StatsTimeFrameJsonConverter),

            typeof(global::Helicone.JsonConverters.StatsTimeFrameNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.SessionFilterNodeEnumJsonConverter),

            typeof(global::Helicone.JsonConverters.SessionFilterNodeEnumNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.SessionFilterBranchOperatorJsonConverter),

            typeof(global::Helicone.JsonConverters.SessionFilterBranchOperatorNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.SessionNameQueryParamsPSizeJsonConverter),

            typeof(global::Helicone.JsonConverters.SessionNameQueryParamsPSizeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.SessionMetricsQueryParamsPSizeJsonConverter),

            typeof(global::Helicone.JsonConverters.SessionMetricsQueryParamsPSizeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.TimeFrameJsonConverter),

            typeof(global::Helicone.JsonConverters.TimeFrameNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.FilterNodeEnum2JsonConverter),

            typeof(global::Helicone.JsonConverters.FilterNodeEnum2NullableJsonConverter),

            typeof(global::Helicone.JsonConverters.FilterBranchOperatorJsonConverter),

            typeof(global::Helicone.JsonConverters.FilterBranchOperatorNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.RequestClickhouseFilterNodeEnumJsonConverter),

            typeof(global::Helicone.JsonConverters.RequestClickhouseFilterNodeEnumNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.RequestClickhouseFilterBranchOperatorJsonConverter),

            typeof(global::Helicone.JsonConverters.RequestClickhouseFilterBranchOperatorNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.TimeIncrementJsonConverter),

            typeof(global::Helicone.JsonConverters.TimeIncrementNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionMessageAnnotationTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionMessageAnnotationTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionMessageFunctionToolCallTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionMessageFunctionToolCallTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionMessageCustomToolCallTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionMessageCustomToolCallTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionMessageRoleJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionObjectJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionObjectNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionServiceTierJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionServiceTierNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.AuthorNameJsonConverter),

            typeof(global::Helicone.JsonConverters.AuthorNameNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.StandardParameterJsonConverter),

            typeof(global::Helicone.JsonConverters.StandardParameterNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.PluginIdJsonConverter),

            typeof(global::Helicone.JsonConverters.PluginIdNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.BodyMappingTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.BodyMappingTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ResponseFormatJsonConverter),

            typeof(global::Helicone.JsonConverters.ResponseFormatNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ModelProviderConfigQuantizationJsonConverter),

            typeof(global::Helicone.JsonConverters.ModelProviderConfigQuantizationNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.InputModalityJsonConverter),

            typeof(global::Helicone.JsonConverters.InputModalityNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.OutputModalityJsonConverter),

            typeof(global::Helicone.JsonConverters.OutputModalityNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ModelCapabilityJsonConverter),

            typeof(global::Helicone.JsonConverters.ModelCapabilityNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.OAIModelObjectJsonConverter),

            typeof(global::Helicone.JsonConverters.OAIModelObjectNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.OAIModelsResponseObjectJsonConverter),

            typeof(global::Helicone.JsonConverters.OAIModelsResponseObjectNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ExperimentFilterNodeEnumJsonConverter),

            typeof(global::Helicone.JsonConverters.ExperimentFilterNodeEnumNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ExperimentFilterBranchOperatorJsonConverter),

            typeof(global::Helicone.JsonConverters.ExperimentFilterBranchOperatorNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.NewDatasetParamsDatasetTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.NewDatasetParamsDatasetTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.DatasetFilterNodeEnumJsonConverter),

            typeof(global::Helicone.JsonConverters.DatasetFilterNodeEnumNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.DatasetFilterBranchOperatorJsonConverter),

            typeof(global::Helicone.JsonConverters.DatasetFilterBranchOperatorNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.EvalFilterNodeEnumJsonConverter),

            typeof(global::Helicone.JsonConverters.EvalFilterNodeEnumNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.EvalFilterBranchOperatorJsonConverter),

            typeof(global::Helicone.JsonConverters.EvalFilterBranchOperatorNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.CreateAPIKeyRequestKeyPermissionsJsonConverter),

            typeof(global::Helicone.JsonConverters.CreateAPIKeyRequestKeyPermissionsNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.TrackShareRequestPlatformJsonConverter),

            typeof(global::Helicone.JsonConverters.TrackShareRequestPlatformNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.CreateNewExperimentHypothesisRequestStatusJsonConverter),

            typeof(global::Helicone.JsonConverters.CreateNewExperimentHypothesisRequestStatusNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.AddOnsProductTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.AddOnsProductTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.DeleteAddOnsProductTypeJsonConverter),

            typeof(global::Helicone.JsonConverters.DeleteAddOnsProductTypeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.GetSpendBreakdownTimeRangeJsonConverter),

            typeof(global::Helicone.JsonConverters.GetSpendBreakdownTimeRangeNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameJsonConverter),

            typeof(global::Helicone.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameNullableJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultIdStringProviderNameStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultEvaluatorResultStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultEvaluatorResultArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultNullStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultEvaluatorExperimentArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultOnlineEvaluatorByEvaluatorIdArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultOutputStringTracesStringArrayStatusCode63NumberStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultEvaluatorScoreStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultScoreNumberInputStringOutputStringGroundTruth63StringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.DataEntryJsonConverter),

            typeof(global::Helicone.JsonConverters.LastMileConfigFormJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultEvaluatorStatsStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPrompt2025StringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultStringArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPrompt2025InputStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPromptCreateResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultIdStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultNumberStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPrompt2025ArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPrompt2025VersionStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPrompt2025VersionArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPromptVersionCountsStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPrompt2025Version91PromptBody93StringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHasPromptsBooleanStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPromptsResultArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.PromptsFilterNodeJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPromptResultStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultCreatePromptResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultMetadataRecordStringAnyStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPromptVersionResultStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPromptInputRecordArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPromptVersionResultArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.PromptVersionsFilterNodeJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPromptVersionResultCompiledStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPromptVersionResultFilledStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultExperimentIdStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultExperimentV2ArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultExtendedExperimentDataStringJsonConverter),

            typeof(global::Helicone.JsonConverters.JsonJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultExperimentV2PromptVersionArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultBooleanStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultRecordStringScoreV2StringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultScoreV2OrNullStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultArrayIntegrationStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultIntegrationStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultArrayIdStringNameStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.RequestFilterNodeJsonConverter),

            typeof(global::Helicone.JsonConverters.ProviderJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHeliconeRequestArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHeliconeRequestStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHeliconeRequestAssetStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultWrappedStatsStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHasDataBooleanStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultSuccessBooleanMessageStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultIsOnWaitlistBooleanStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultCountNumberStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultSuccessBooleanNewPosition63NumberMessageStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultDecryptedProviderKeyArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultDecryptedProviderKeyStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.UserFilterNodeJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultModelUsageResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultMarketShareResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultProviderUsageResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultAuthorStatsResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultProviderStatsResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultModelStatsResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultSessionResultArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.SessionFilterNodeJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultSessionsAggregateMetricsStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultSessionNameResultArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultSessionMetricsStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultStringOrNullStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultProviderMetricsArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultProviderMetricsStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultProviderMetricArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.FilterNodeJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.RequestClickhouseFilterNodeJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPropertyArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultValueStringCostNumberArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultValueStringCountNumberArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ChatCompletionMessageToolCallJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultChatCompletionOrContentStringReasoningStringCallsAnyStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultApiKeyStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultCostNumberCreatedAtTruncStringArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultModelRegistryResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.TokenMetricStatsJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultModelArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultTokensPerRequestStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultRequestsOverTimeArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultCostOverTimeArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultTokensOverTimeArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultLatencyOverTimeArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultTimeToFirstTokenOverTimeArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultUsersOverTimeArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultThreatsOverTimeArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultErrorOverTimeArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultModelMetricArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultCountryDataArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultQuantilesArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultUnsafeBooleanStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultClickHouseTableSchemaArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultExecuteSqlResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultArrayHqlSavedQueryStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHqlSavedQueryOrNullStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultVoidStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHqlSavedQueryArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHqlSavedQueryStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultTableIdStringExperimentIdStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultExperimentTableStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultExperimentTableSimplifiedStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultExperimentTableSimplifiedArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHypothesisIdStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultRunsCountNumberScoresRecordStringScoreStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultExperimentArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ExperimentFilterNodeJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultDatasetIdStringStringJsonConverter),

            typeof(global::Helicone.JsonConverters.DatasetFilterNodeJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultDatasetResultArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHeliconeDatasetRowArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultHeliconeDatasetArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultEvalArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.EvalFilterNodeJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultScoreDistributionArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultCreditBalanceResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPaginatedPurchasedCreditsStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultTotalSpendNumberStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultSpendBreakdownResponseStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultPTBInvoiceArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultOrgDiscountArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultInAppThreadStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultSuccessBooleanStringJsonConverter),

            typeof(global::Helicone.JsonConverters.ResultThreadSummaryArrayStringJsonConverter),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.LastMileConfigFormVariant2Variant1, global::Helicone.LastMileConfigFormVariant2Variant2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.OpenAIChatRequestFunctionCall>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.Prompt2025VersionPromptBodyToolChoice>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, string>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.MessageRole?>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>),

            typeof(global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ChatCompletion, global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, string>),

            typeof(global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.DataOverTimeRequest, global::Helicone.GetPropertiesOverTimeRequest2>),

            typeof(global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest2>),

            typeof(global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultSuccessUnknown, global::Helicone.ResultErrorUnknown>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ValidationResult, object>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.HidePropertyResponse2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.RestorePropertyResponse2>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessUnknown>),

            typeof(global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorUnknown, global::Helicone.ResultSuccessAny>),

            typeof(global::Helicone.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProviderKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DecryptedProviderKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderKeyRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringProviderNameString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringProviderNameStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringProviderNameStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateProviderKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvaluatorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorResultString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateEvaluatorParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvaluatorResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvaluatorResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorResultArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateEvaluatorParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvaluatorExperimentArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvaluatorExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorExperimentArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OnlineEvaluatorByEvaluatorId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessOnlineEvaluatorByEvaluatorIdArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OnlineEvaluatorByEvaluatorId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOnlineEvaluatorByEvaluatorIdArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateOnlineEvaluatorParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessOutputStringTracesStringArrayStatusCode63Number))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOutputStringTracesStringArrayStatusCode63NumberString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestInputInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<double?, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvaluatorScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorScoreString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63StringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreNumberInputStringOutputStringGroundTruth63StringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant3Content))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant3Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant4Content))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant4Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.BaseLastMileConfigForm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigForm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.LastMileConfigFormVariant2Variant1, global::Helicone.LastMileConfigFormVariant2Variant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigFormVariant2Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigFormVariant2Variant1Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigFormVariant2Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigFormVariant2Variant2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorStatsRecentTrend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvaluatorStatsScoreDistributionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorStatsScoreDistributionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvaluatorStatsTimeSeriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorStatsTimeSeriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvaluatorStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorStatsString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025String))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025InputString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptCreateResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageContentVariant2ItemImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestReasoningEffort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestVerbosity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.OpenAIChatRequestFunctionCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNumberString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025Array))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025ArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2ItemImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.Prompt2025VersionPromptBodyToolChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025VersionString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025VersionArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025Version>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025VersionArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionCountsString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025Version91PromptBody93))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025Version91PromptBody93String))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHasPromptsBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHasPromptsBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHasPromptsBooleanString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptsResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PromptsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptsResultArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTextOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPromptToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafPromptV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterNodeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterBranchOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptResultString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreatePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCreatePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCreatePromptResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessMetadataRecordStringAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessMetadataRecordStringAnyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultMetadataRecordStringAnyString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptEditSubversionLabelParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptEditSubversionTemplateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptCreateSubversionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptInputRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptInputRecordArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PromptInputRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptInputRecordArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PromptVersionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialNumberOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPromptVersionsToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafPromptsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterNodeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterBranchOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionResultCompiled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionResultCompiled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultCompiledString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersiosQueryParamsCompiled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionResultFilled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionResultFilled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultFilledString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentIdStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentV2Array))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentV2ArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentV2Output))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentV2Row))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentV2Output>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExtendedExperimentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentV2Row>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExtendedExperimentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExtendedExperimentDataString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateNewPromptVersionForExperimentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Json))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.Json?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Json>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentV2PromptVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentV2PromptVersionArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentV2PromptVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentV2PromptVersionArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultBooleanString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ScoreV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<double?, global::System.DateTime?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.ScoreV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRecordStringScoreV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRecordStringScoreV2String))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreV2OrNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreV2OrNullString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateCloudGatewayCheckoutSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToProRequestAddons))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToProRequestUiMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToTeamBundleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToTeamBundleRequestUiMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMUsageTotalCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PaymentIntentRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.StripePaymentIntentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PaymentIntentRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AutoTopoffSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateAutoTopoffSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PaymentMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateSetupSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DailyUsageDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UsageStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UsageStatsResponseBillingPeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UsageStatsResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.DailyUsageDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UsageStatsResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.IntegrationCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Integration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArrayIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Integration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayIntegrationString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.IntegrationUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIntegrationString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArrayIdStringNameString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessArrayIdStringNameStringDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArrayIdStringNameStringDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayIdStringNameStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestStripeMeterEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialResponseTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTimestampOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialBooleanOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialFeedbackTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTimestampOperatorsTyped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestResponseRMTToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestResponseRMTToOperatorsPropertyKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialSessionsRequestResponseRMTToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterNodeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterBranchOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SortDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SortLeafRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.SortDirection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LlmType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FunctionCall2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.MessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageAnnotationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.FunctionCall2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.MessageRole?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventVectorDB))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventVectorDBType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventVectorDBOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventVectorDBFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventDataType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyReasoningEffort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyVerbosity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyToolChoiceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Response>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyDataDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyDataDetailsResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyDataDetailsResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyToolDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyToolDetailsResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyToolDetailsResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LlmSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHeliconeRequestArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HeliconeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeRequestArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHeliconeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeRequestString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeRequestAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHeliconeRequestAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeRequestAssetString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ScoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ConversationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MostExpensiveRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MostExpensiveRequestConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ConversationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.WrappedStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.WrappedStatsTopProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.WrappedStatsTopProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.WrappedStatsTopModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.WrappedStatsTopModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.WrappedStatsTotalTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessWrappedStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultWrappedStatsString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHasDataBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHasDataBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHasDataBooleanString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUnknown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorUnknown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.WebhookData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBooleanMessageString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBooleanMessageStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBooleanMessageStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIsOnWaitlistBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIsOnWaitlistBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIsOnWaitlistBooleanString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCountNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCountNumberData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCountNumberString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBooleanNewPosition63NumberMessageStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AddVaultKeyParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessDecryptedProviderKeyArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.DecryptedProviderKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDecryptedProviderKeyArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessDecryptedProviderKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDecryptedProviderKeyString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HistogramRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HistogramRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialUserViewToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterNodeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterBranchOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserMetricsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.UserMetricsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SortLeafUsers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserMetricsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserMetricsQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ValidationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TypedProviderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TypedProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TypedTiming))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TypedAsyncLogModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpanSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpanSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpanSpanStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttributeValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpanScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanResourceAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanResourceAttribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanResourceAttributeValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SendTestRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SendTestRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelUsageTimeSeriesDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelUsageLeaderboardEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelUsageTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelUsageLeaderboardEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessModelUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelUsageResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.StatsTimeFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AuthorTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MarketShareTimeSeriesDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.AuthorTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MarketShareLeaderboardEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MarketShareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.MarketShareTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.MarketShareLeaderboardEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessMarketShareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultMarketShareResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderUsageTimeSeriesDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderUsageLeaderboardEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderUsageTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderUsageLeaderboardEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessProviderUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderUsageResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AuthorStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessAuthorStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultAuthorStatsResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessProviderStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderStatsResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelStatsTimeSeriesDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelStatsTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessModelStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelStatsResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSessionResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.SessionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionResultArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterNodeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterBranchOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionsAggregateMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSessionsAggregateMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionsAggregateMetricsString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionNameResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSessionNameResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.SessionNameResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionNameResultArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFilterMs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionNameQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionNameQueryParamsPSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AverageRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionMetricsAverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.AverageRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSessionMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionMetricsString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionMetricsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionMetricsQueryParamsPSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessStringOrNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringOrNullString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeSeriesDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderMetricsMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.TimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessProviderMetricsArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricsArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessProviderMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricsString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessProviderMetricArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialUserMetricsToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialUserApiKeysTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPropertiesTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialExperimentToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialExperimentHypothesisRunToOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialScoreValueToOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestResponseLogToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPropertiesV3ToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPropertyWithResponseV1ToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialJobToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialNodesToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialCacheMetricsTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRateLimitTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialOrganizationPropertiesToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTablesAndViews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterNodeEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterBranchOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafRequestResponseRmt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterNodeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterBranchOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeIncrement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataOverTimeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataOverTimeRequestTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Property))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPropertyArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Property>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPropertyArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUnknownArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessValueStringCostNumberArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessValueStringCostNumberArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessValueStringCostNumberArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultValueStringCostNumberArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFilterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFilterRequestTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessValueStringCountNumberArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessValueStringCountNumberArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessValueStringCountNumberArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultValueStringCountNumberArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionTokenLogprobTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageAnnotationURLCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageAnnotationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageFunctionToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageFunctionToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageFunctionToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageCustomToolCallCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageCustomToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageCustomToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ChatCompletionMessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionChoiceFinishReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CompletionUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CompletionUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionServiceTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ChatCompletion, global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultChatCompletionOrContentStringReasoningStringCallsAnyString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCostNumberCreatedAtTruncStringArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AuthorName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.StandardParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PluginId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RateLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModalityPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelPricingCacheMultipliers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.BodyMappingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EndpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelPricing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.EndpointConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.StandardParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PluginId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderConfigQuantization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserEndpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SimplifiedModalityPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SimplifiedPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.SimplifiedPricing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.InputModality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OutputModality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelRegistryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryResponseFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelCapability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelRegistryResponseFiltersProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryResponseFiltersProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessModelRegistryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelRegistryResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OAIModelObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OAIModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OAIModelsResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OAIModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TokenMetricStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TokenMetricStatsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeSeriesMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelTimeSeriesData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.TimeSeriesMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRequestStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelGeographicTtftItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelGeographicTtftItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelGeographicLatencyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelGeographicLatencyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelCosts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessModelArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelsToCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsFilterBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsFilterBodyTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TokensPerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTokensPerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTokensPerRequestString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestsOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRequestsOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.RequestsOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRequestsOverTimeArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsOverTimeBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsOverTimeBodyTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CostOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCostOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.CostOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCostOverTimeArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TokensOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTokensOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.TokensOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTokensOverTimeArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LatencyOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessLatencyOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.LatencyOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultLatencyOverTimeArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeToFirstTokenOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTimeToFirstTokenOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.TimeToFirstTokenOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTimeToFirstTokenOverTimeArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UsersOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUsersOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.UsersOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUsersOverTimeArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ThreatsOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessThreatsOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ThreatsOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultThreatsOverTimeArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ErrorOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessErrorOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ErrorOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorOverTimeArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestCountBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessModelMetricArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelMetricArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelMetricsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelMetricsBodyTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CountryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCountryDataArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.CountryData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCountryDataArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CountryMetricsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CountryMetricsBodyTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Quantiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessQuantilesArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Quantiles>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultQuantilesArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.QuantilesBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.QuantilesBodyTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUnsafeBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUnsafeBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUnsafeBooleanString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ClickHouseTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ClickHouseTableSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ClickHouseTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessClickHouseTableSchemaArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ClickHouseTableSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultClickHouseTableSchemaArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExecuteSqlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExecuteSqlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExecuteSqlResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExecuteSqlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HqlSavedQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArrayHqlSavedQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HqlSavedQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayHqlSavedQueryString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHqlSavedQueryOrNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHqlSavedQueryOrNullString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessVoid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultVoidString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.BulkDeleteSavedQueriesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHqlSavedQueryArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHqlSavedQueryArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateSavedQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHqlSavedQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHqlSavedQueryString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTableIdStringExperimentIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTableIdStringExperimentIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTableIdStringExperimentIdStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentTableParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentTableColumnCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentTableColumnCell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentTableString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentTableSimplified))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentTableSimplifiedColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentTableSimplifiedColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentTableSimplified))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentTableSimplifiedString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentTableSimplifiedArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentTableSimplified>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentTableSimplifiedArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.NewExperimentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHypothesisIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHypothesisIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHypothesisIdStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Score2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.Score2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRunsCountNumberScoresRecordStringScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRunsCountNumberScoresRecordStringScoreData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRunsCountNumberScoresRecordStringScoreString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseObj))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestObj))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentDatasetRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentDatasetRowInputRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentScoresDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentScoresHypothesis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Experiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentDatasetRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentHypothese>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentHypothese))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentHypotheseRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentHypotheseRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentHypotheseParentPromptVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentHypothesePromptVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterNodeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterBranchOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.IncludeExperimentKeys))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessDatasetIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessDatasetIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDatasetIdStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.NewDatasetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.NewDatasetParamsDatasetType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafRequestOrPromptsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterNodeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterBranchOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RandomDatasetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessDatasetResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.DatasetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDatasetResultArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeDatasetMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.NewHeliconeDatasetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MutateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeDatasetRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHeliconeDatasetRowArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HeliconeDatasetRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeDatasetRowArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHeliconeDatasetArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HeliconeDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeDatasetArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Eval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvalOverTimeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalOverTimeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvalAverageOverTimeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalAverageOverTimeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvalArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Eval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvalArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterNodeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterBranchOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ScoreDistribution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ScoreDistributionDistributionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ScoreDistributionDistributionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreDistributionArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ScoreDistribution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreDistributionArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CustomerUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Customer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreditBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCreditBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCreditBalanceResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PurchasedCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PaginatedPurchasedCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PurchasedCredits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPaginatedPurchasedCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPaginatedPurchasedCreditsString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTotalSpendNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTotalSpendNumberData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTotalSpendNumberString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelSpend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelSpendPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SpendBreakdownResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelSpend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SpendBreakdownResponseTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSpendBreakdownResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSpendBreakdownResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PTBInvoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPTBInvoiceArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PTBInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPTBInvoiceArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OrgDiscount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessOrgDiscountArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OrgDiscount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOrgDiscountArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.InAppThread))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessInAppThread))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultInAppThreadString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBooleanString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ThreadSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessThreadSummaryArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ThreadSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultThreadSummaryArrayString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProxyKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateAPIKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestPythonEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestLLMEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestLastMileEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RenamePrompt2025Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdatePrompt2025TagsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreatePrompt2025Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdatePrompt2025Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SetPromptVersionEnvironmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RemoveEnvironmentFromVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPrompts2025Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPrompt2025VersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPrompt2025EnvironmentVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPrompt2025VersionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPrompt2025ProductionVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPrompt2025TotalVersionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPrompt2025VersionRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPrompt2025EnvironmentVersionRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPrompt2025ProductionVersionRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreatePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdatePromptUserDefinedIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromotePromptVersionToProductionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetInputsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateNewExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AddManualRowToExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AddManualRowsToExperimentBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteExperimentTableRowsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentTableRowBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.CreateExperimentTableRowBatchRequestRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentTableRowBatchRequestRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateExperimentTableRowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RunHypothesisRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetRequestsByIdsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FeedbackRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PutPropertyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AddToWaitlistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TrackShareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TrackShareRequestPlatform))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetUserMetricsOverviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateSessionFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateSessionTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.DataOverTimeRequest, global::Helicone.GetPropertiesOverTimeRequest2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPropertiesOverTimeRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HidePropertyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RestorePropertyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SearchPropertiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GenerateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestsThroughHeliconeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AddSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelsToCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetSecurityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateNewEmptyExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentCellRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateExperimentCellRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentColumnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentTableRowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentTableRowWithCellsBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.CreateExperimentTableRowWithCellsBatchRequestRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentTableRowWithCellsBatchRequestRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.CreateExperimentTableRowWithCellsBatchRequestRowCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentTableRowWithCellsBatchRequestRowCell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateExperimentMetaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateNewExperimentHypothesisRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateNewExperimentHypothesisRequestStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentEvaluatorOldRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetExperimentsOldRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetDatasetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.InsertDatasetRowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateDatasetRowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MutateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.QueryHeliconeDatasetRowsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.QueryHeliconeDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateHeliconeDatasetRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AddEvalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateAlertBannerActiveRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GenerateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpsertThreadMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpsertThreadMessageRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SearchDocsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AddOnsProductType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteAddOnsProductType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetSpendBreakdownTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetProviderKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProviderKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProviderKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetProviderKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProxyKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProxyKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteAPIKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteAPIKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateAPIKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateAPIKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateCloudGatewayCheckoutSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PreviewInvoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.LLMUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PreviewInvoiceResponseDiscount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PreviewInvoiceResponseDiscountCoupon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PreviewInvoiceResponseLines))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PreviewInvoiceResponseLinesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PreviewInvoiceResponseLinesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.GetSubscriptionResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetSubscriptionResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetSubscriptionResponseItemPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetSubscriptionResponseItemPriceProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DisableAutoTopoffResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PaymentMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateSetupSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RemovePaymentMethodResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultSuccessUnknown, global::Helicone.ResultErrorUnknown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ValidationResult, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.HidePropertyResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HidePropertyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HidePropertyResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.RestorePropertyResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RestorePropertyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RestorePropertyResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessUnknown>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorUnknown, global::Helicone.ResultSuccessAny>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Customer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.EvaluatorResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.EvaluatorExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OnlineEvaluatorByEvaluatorId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.EvaluatorStatsScoreDistributionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.EvaluatorStatsTimeSeriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025Version>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PromptsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PromptInputRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PromptVersionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentV2Output>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentV2Row>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Json>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentV2PromptVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PaymentIntentRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.DailyUsageDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Integration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessArrayIdStringNameStringDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.MessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.FunctionCall2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Response>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.HeliconeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ConversationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.WrappedStatsTopProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.WrappedStatsTopModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.DecryptedProviderKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.HistogramRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.UserMetricsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanScopeSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanScopeSpanSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanResourceAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelUsageTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelUsageLeaderboardEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.AuthorTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.MarketShareTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.MarketShareLeaderboardEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ProviderTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ProviderUsageTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ProviderUsageLeaderboardEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelStatsTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.SessionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.SessionNameResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.AverageRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.TimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ProviderMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ProviderMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Property>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessValueStringCostNumberArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessValueStringCountNumberArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ChatCompletionMessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelPricing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.StandardParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PluginId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.SimplifiedPricing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelRegistryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelCapability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelRegistryResponseFiltersProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OAIModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.TimeSeriesMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelGeographicTtftItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelGeographicLatencyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.RequestsOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.CostOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.TokensOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.LatencyOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.TimeToFirstTokenOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.UsersOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ThreatsOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ErrorOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.CountryData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Quantiles>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ClickHouseTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ClickHouseTableSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.HqlSavedQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentTableColumnCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentTableSimplifiedColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentTableSimplified>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentDatasetRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentHypothese>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ExperimentHypotheseRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.DatasetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.HeliconeDatasetRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.HeliconeDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.EvalOverTimeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.EvalAverageOverTimeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Eval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ScoreDistributionDistributionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ScoreDistribution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PurchasedCredits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelSpend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PTBInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OrgDiscount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ThreadSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.CreateExperimentTableRowBatchRequestRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelsToCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.CreateExperimentTableRowWithCellsBatchRequestRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.CreateExperimentTableRowWithCellsBatchRequestRowCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.List<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ProviderKeyRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.LLMUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PreviewInvoiceResponseLinesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.GetSubscriptionResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PaymentMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Customer>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}