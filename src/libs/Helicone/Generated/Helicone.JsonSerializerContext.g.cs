
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArray), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_c61c916e4634eed4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem>), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_3dc749edd663c095")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_4cfba64094b5bdd5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayString), TypeInfoPropertyName = "ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrgan_cf349a6cf523295d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayString?), TypeInfoPropertyName = "ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrgan_ff3f6ffbba0c1639")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem>), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_8e953b8e000805f0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProviderKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DecryptedProviderKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RecordStringAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderKeyRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringProviderNameString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringProviderNameStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringProviderNameStringString), TypeInfoPropertyName = "ResultIdStringProviderNameStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateProviderKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvaluatorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorResultString), TypeInfoPropertyName = "ResultEvaluatorResultString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateEvaluatorParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvaluatorResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvaluatorResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorResultArrayString), TypeInfoPropertyName = "ResultEvaluatorResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateEvaluatorParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString), TypeInfoPropertyName = "ResultNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvaluatorExperimentArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvaluatorExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorExperimentArrayString), TypeInfoPropertyName = "ResultEvaluatorExperimentArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OnlineEvaluatorByEvaluatorId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessOnlineEvaluatorByEvaluatorIdArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OnlineEvaluatorByEvaluatorId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOnlineEvaluatorByEvaluatorIdArrayString), TypeInfoPropertyName = "ResultOnlineEvaluatorByEvaluatorIdArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateOnlineEvaluatorParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessOutputStringTracesStringArrayStatusCode63Number))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOutputStringTracesStringArrayStatusCode63NumberString), TypeInfoPropertyName = "ResultOutputStringTracesStringArrayStatusCode63NumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestInputInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<double?, bool?>), TypeInfoPropertyName = "AnyOfDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvaluatorScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorScoreString), TypeInfoPropertyName = "ResultEvaluatorScoreString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63StringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreNumberInputStringOutputStringGroundTruth63StringString), TypeInfoPropertyName = "ResultScoreNumberInputStringOutputStringGroundTruth63StringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntry), TypeInfoPropertyName = "DataEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant1Type), TypeInfoPropertyName = "DataEntryVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant2Type), TypeInfoPropertyName = "DataEntryVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant3Content), TypeInfoPropertyName = "DataEntryVariant3Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant3Type), TypeInfoPropertyName = "DataEntryVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant4Content), TypeInfoPropertyName = "DataEntryVariant4Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant4Type), TypeInfoPropertyName = "DataEntryVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.BaseLastMileConfigForm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigForm), TypeInfoPropertyName = "LastMileConfigForm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.LastMileConfigFormVariant2Variant1, global::Helicone.LastMileConfigFormVariant2Variant2>), TypeInfoPropertyName = "AnyOfLastMileConfigFormVariant2Variant1LastMileConfigFormVariant2Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigFormVariant2Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigFormVariant2Variant1Type), TypeInfoPropertyName = "LastMileConfigFormVariant2Variant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigFormVariant2Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigFormVariant2Variant2Type), TypeInfoPropertyName = "LastMileConfigFormVariant2Variant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorStatsRecentTrend), TypeInfoPropertyName = "EvaluatorStatsRecentTrend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvaluatorStatsScoreDistributionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorStatsScoreDistributionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvaluatorStatsTimeSeriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorStatsTimeSeriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvaluatorStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorStatsString), TypeInfoPropertyName = "ResultEvaluatorStatsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025String), TypeInfoPropertyName = "ResultPrompt2025String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringArrayString), TypeInfoPropertyName = "ResultStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025InputString), TypeInfoPropertyName = "ResultPrompt2025InputString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptCreateResponseString), TypeInfoPropertyName = "ResultPromptCreateResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageToolCallType), TypeInfoPropertyName = "OpenAIChatRequestMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>), TypeInfoPropertyName = "AnyOfStringIListOpenAIChatRequestMessageContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageContentVariant2ItemImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<string>, string>), TypeInfoPropertyName = "AnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolType), TypeInfoPropertyName = "OpenAIChatRequestToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>), TypeInfoPropertyName = "AnyOfOpenAIChatRequestToolChoiceEnumOpenAIChatRequestToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType), TypeInfoPropertyName = "OpenAIChatRequestToolChoiceEnumFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum2), TypeInfoPropertyName = "OpenAIChatRequestToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestReasoningEffort), TypeInfoPropertyName = "OpenAIChatRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestVerbosity), TypeInfoPropertyName = "OpenAIChatRequestVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.OpenAIChatRequestFunctionCall>), TypeInfoPropertyName = "AnyOfStringOpenAIChatRequestFunctionCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringString), TypeInfoPropertyName = "ResultIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNumberString), TypeInfoPropertyName = "ResultNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025Array))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025ArrayString), TypeInfoPropertyName = "ResultPrompt2025ArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RecordStringUnknown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType), TypeInfoPropertyName = "Prompt2025VersionPromptBodyMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>), TypeInfoPropertyName = "AnyOfStringIListPrompt2025VersionPromptBodyMessageContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2ItemImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolType), TypeInfoPropertyName = "Prompt2025VersionPromptBodyToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.Prompt2025VersionPromptBodyToolChoice>), TypeInfoPropertyName = "AnyOfStringPrompt2025VersionPromptBodyToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType), TypeInfoPropertyName = "Prompt2025VersionPromptBodyToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025VersionString), TypeInfoPropertyName = "ResultPrompt2025VersionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025VersionArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025Version>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025VersionArrayString), TypeInfoPropertyName = "ResultPrompt2025VersionArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionCountsString), TypeInfoPropertyName = "ResultPromptVersionCountsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025Version91PromptBody93))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025Version91PromptBody93String), TypeInfoPropertyName = "ResultPrompt2025Version91PromptBody93String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHasPromptsBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHasPromptsBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHasPromptsBooleanString), TypeInfoPropertyName = "ResultHasPromptsBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptsResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PromptsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptsResultArrayString), TypeInfoPropertyName = "ResultPromptsResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTextOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPromptToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafPromptV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterNode), TypeInfoPropertyName = "PromptsFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterNodeEnum), TypeInfoPropertyName = "PromptsFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterBranchOperator), TypeInfoPropertyName = "PromptsFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptResultString), TypeInfoPropertyName = "ResultPromptResultString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreatePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCreatePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCreatePromptResponseString), TypeInfoPropertyName = "ResultCreatePromptResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessMetadataRecordStringAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessMetadataRecordStringAnyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultMetadataRecordStringAnyString), TypeInfoPropertyName = "ResultMetadataRecordStringAnyString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptEditSubversionLabelParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptEditSubversionTemplateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultString), TypeInfoPropertyName = "ResultPromptVersionResultString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptCreateSubversionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptInputRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptInputRecordArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PromptInputRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptInputRecordArrayString), TypeInfoPropertyName = "ResultPromptInputRecordArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayString), TypeInfoPropertyName = "ResultIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PromptVersionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultArrayString), TypeInfoPropertyName = "ResultPromptVersionResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialNumberOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPromptVersionsToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafPromptsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterNode), TypeInfoPropertyName = "PromptVersionsFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterNodeEnum), TypeInfoPropertyName = "PromptVersionsFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterBranchOperator), TypeInfoPropertyName = "PromptVersionsFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionResultCompiled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionResultCompiled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultCompiledString), TypeInfoPropertyName = "ResultPromptVersionResultCompiledString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersiosQueryParamsCompiled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionResultFilled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionResultFilled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultFilledString), TypeInfoPropertyName = "ResultPromptVersionResultFilledString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentIdStringString), TypeInfoPropertyName = "ResultExperimentIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentV2Array))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentV2ArrayString), TypeInfoPropertyName = "ResultExperimentV2ArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentV2Output))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentV2Row))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentV2Output>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExtendedExperimentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentV2Row>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExtendedExperimentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExtendedExperimentDataString), TypeInfoPropertyName = "ResultExtendedExperimentDataString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateNewPromptVersionForExperimentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Json), TypeInfoPropertyName = "Json2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.Json?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Json?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentV2PromptVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentV2PromptVersionArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentV2PromptVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentV2PromptVersionArrayString), TypeInfoPropertyName = "ResultExperimentV2PromptVersionArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringString), TypeInfoPropertyName = "ResultStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultBooleanString), TypeInfoPropertyName = "ResultBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ScoreV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<double?, global::System.DateTime?, string>), TypeInfoPropertyName = "AnyOfDoubleDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.ScoreV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRecordStringScoreV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRecordStringScoreV2String), TypeInfoPropertyName = "ResultRecordStringScoreV2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreV2OrNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreV2OrNullString), TypeInfoPropertyName = "ResultScoreV2OrNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateCloudGatewayCheckoutSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToProRequestAddons))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToProRequestUiMode), TypeInfoPropertyName = "UpgradeToProRequestUiMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToTeamBundleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToTeamBundleRequestUiMode), TypeInfoPropertyName = "UpgradeToTeamBundleRequestUiMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayIntegrationString), TypeInfoPropertyName = "ResultArrayIntegrationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.IntegrationUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIntegrationString), TypeInfoPropertyName = "ResultIntegrationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArrayIdStringNameString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessArrayIdStringNameStringDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArrayIdStringNameStringDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayIdStringNameStringString), TypeInfoPropertyName = "ResultArrayIdStringNameStringString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterNode), TypeInfoPropertyName = "RequestFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterNodeEnum), TypeInfoPropertyName = "RequestFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterBranchOperator), TypeInfoPropertyName = "RequestFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SortDirection), TypeInfoPropertyName = "SortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SortLeafRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.SortDirection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderName), TypeInfoPropertyName = "ProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderName), TypeInfoPropertyName = "ModelProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Provider), TypeInfoPropertyName = "Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderEnum), TypeInfoPropertyName = "ProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LlmType), TypeInfoPropertyName = "LlmType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FunctionCall2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.MessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageAnnotationType), TypeInfoPropertyName = "MessageAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageType), TypeInfoPropertyName = "MessageType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.FunctionCall2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.MessageRole?>), TypeInfoPropertyName = "AnyOfStringMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageRole), TypeInfoPropertyName = "MessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageType2), TypeInfoPropertyName = "MessageType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventToolType), TypeInfoPropertyName = "HeliconeEventToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventVectorDB))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventVectorDBType), TypeInfoPropertyName = "HeliconeEventVectorDBType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventVectorDBOperation), TypeInfoPropertyName = "HeliconeEventVectorDBOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventVectorDBFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventDataType), TypeInfoPropertyName = "HeliconeEventDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyReasoningEffort), TypeInfoPropertyName = "LLMRequestBodyReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyVerbosity), TypeInfoPropertyName = "LLMRequestBodyVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyToolChoiceType), TypeInfoPropertyName = "LLMRequestBodyToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Response>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseType), TypeInfoPropertyName = "ResponseType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseRole), TypeInfoPropertyName = "ResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseType2), TypeInfoPropertyName = "ResponseType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyDataDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyDataDetailsResponseType), TypeInfoPropertyName = "LLMResponseBodyDataDetailsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyDataDetailsResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponseType), TypeInfoPropertyName = "LLMResponseBodyVectorDBDetailsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyToolDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyToolDetailsResponseType), TypeInfoPropertyName = "LLMResponseBodyToolDetailsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyToolDetailsResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LlmSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHeliconeRequestArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HeliconeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeRequestArrayString), TypeInfoPropertyName = "ResultHeliconeRequestArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHeliconeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeRequestString), TypeInfoPropertyName = "ResultHeliconeRequestString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullString), TypeInfoPropertyName = "ResultInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeRequestAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHeliconeRequestAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeRequestAssetString), TypeInfoPropertyName = "ResultHeliconeRequestAssetString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RecordStringNumberOrBooleanOrUndefined))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultWrappedStatsString), TypeInfoPropertyName = "ResultWrappedStatsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHasDataBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHasDataBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHasDataBooleanString), TypeInfoPropertyName = "ResultHasDataBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUnknown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorUnknown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.WebhookData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayString), TypeInfoPropertyName = "ResultIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBooleanMessageString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBooleanMessageStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBooleanMessageStringString), TypeInfoPropertyName = "ResultSuccessBooleanMessageStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AddVaultKeyParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessDecryptedProviderKeyArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.DecryptedProviderKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDecryptedProviderKeyArrayString), TypeInfoPropertyName = "ResultDecryptedProviderKeyArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessDecryptedProviderKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDecryptedProviderKeyString), TypeInfoPropertyName = "ResultDecryptedProviderKeyString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HistogramRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HistogramRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString), TypeInfoPropertyName = "ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialUserViewToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterNode), TypeInfoPropertyName = "UserFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterNodeEnum), TypeInfoPropertyName = "UserFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterBranchOperator), TypeInfoPropertyName = "UserFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PSize), TypeInfoPropertyName = "PSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserMetricsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.UserMetricsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString), TypeInfoPropertyName = "ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SortLeafUsers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserMetricsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserMetricsQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString), TypeInfoPropertyName = "ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSessionResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.SessionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionResultArrayString), TypeInfoPropertyName = "ResultSessionResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterNode), TypeInfoPropertyName = "SessionFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterNodeEnum), TypeInfoPropertyName = "SessionFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterBranchOperator), TypeInfoPropertyName = "SessionFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionsAggregateMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSessionsAggregateMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionsAggregateMetricsString), TypeInfoPropertyName = "ResultSessionsAggregateMetricsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionNameResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSessionNameResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.SessionNameResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionNameResultArrayString), TypeInfoPropertyName = "ResultSessionNameResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFilterMs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionNameQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionNameQueryParamsPSize), TypeInfoPropertyName = "SessionNameQueryParamsPSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AverageRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionMetricsAverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.AverageRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSessionMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionMetricsString), TypeInfoPropertyName = "ResultSessionMetricsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionMetricsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionMetricsQueryParamsPSize), TypeInfoPropertyName = "SessionMetricsQueryParamsPSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessStringOrNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringOrNullString), TypeInfoPropertyName = "ResultStringOrNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeSeriesDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>), TypeInfoPropertyName = "AllOfMetricsDataProviderMetricsMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderMetricsMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.TimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessProviderMetricsArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricsArrayString), TypeInfoPropertyName = "ResultProviderMetricsArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessProviderMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricsString), TypeInfoPropertyName = "ResultProviderMetricsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFrame), TypeInfoPropertyName = "TimeFrame2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessProviderMetricArray))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArray), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_c61c916e4634eed4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem>), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_3dc749edd663c095")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_4cfba64094b5bdd5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayString), TypeInfoPropertyName = "ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrgan_cf349a6cf523295d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayString?), TypeInfoPropertyName = "ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrgan_ff3f6ffbba0c1639")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem>), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_8e953b8e000805f0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricArrayString), TypeInfoPropertyName = "ResultProviderMetricArrayString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterNode), TypeInfoPropertyName = "FilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterNodeEnum2), TypeInfoPropertyName = "FilterNodeEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterBranchOperator), TypeInfoPropertyName = "FilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayString), TypeInfoPropertyName = "ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafRequestResponseRmt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterNode), TypeInfoPropertyName = "RequestClickhouseFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterNodeEnum), TypeInfoPropertyName = "RequestClickhouseFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterBranchOperator), TypeInfoPropertyName = "RequestClickhouseFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeIncrement), TypeInfoPropertyName = "TimeIncrement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataOverTimeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataOverTimeRequestTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Property))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPropertyArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Property>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPropertyArrayString), TypeInfoPropertyName = "ResultPropertyArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUnknownArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessValueStringCostNumberArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessValueStringCostNumberArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessValueStringCostNumberArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultValueStringCostNumberArrayString), TypeInfoPropertyName = "ResultValueStringCostNumberArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFilterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFilterRequestTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessValueStringCountNumberArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessValueStringCountNumberArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessValueStringCountNumberArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultValueStringCountNumberArrayString), TypeInfoPropertyName = "ResultValueStringCountNumberArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionTokenLogprobTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageAnnotationURLCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageAnnotationType), TypeInfoPropertyName = "ChatCompletionMessageAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageFunctionToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageFunctionToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageFunctionToolCallType), TypeInfoPropertyName = "ChatCompletionMessageFunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageCustomToolCallCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageCustomToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageCustomToolCallType), TypeInfoPropertyName = "ChatCompletionMessageCustomToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageToolCall), TypeInfoPropertyName = "ChatCompletionMessageToolCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageRole), TypeInfoPropertyName = "ChatCompletionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ChatCompletionMessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionChoiceFinishReason), TypeInfoPropertyName = "ChatCompletionChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CompletionUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CompletionUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionObject), TypeInfoPropertyName = "ChatCompletionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionServiceTier), TypeInfoPropertyName = "ChatCompletionServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ChatCompletion, global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData>), TypeInfoPropertyName = "AnyOfChatCompletionResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultChatCompletionOrContentStringReasoningStringCallsAnyString), TypeInfoPropertyName = "ResultChatCompletionOrContentStringReasoningStringCallsAnyString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyStringString), TypeInfoPropertyName = "ResultApiKeyStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCostNumberCreatedAtTruncStringArrayString), TypeInfoPropertyName = "ResultCostNumberCreatedAtTruncStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AuthorName), TypeInfoPropertyName = "AuthorName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.StandardParameter), TypeInfoPropertyName = "StandardParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PluginId), TypeInfoPropertyName = "PluginId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RateLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModalityPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelPricingCacheMultipliers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.BodyMappingType), TypeInfoPropertyName = "BodyMappingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EndpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelPricing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.EndpointConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseFormat), TypeInfoPropertyName = "ResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.StandardParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PluginId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderConfigQuantization), TypeInfoPropertyName = "ModelProviderConfigQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserEndpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SimplifiedModalityPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SimplifiedPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.SimplifiedPricing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.InputModality), TypeInfoPropertyName = "InputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OutputModality), TypeInfoPropertyName = "OutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelCapability), TypeInfoPropertyName = "ModelCapability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelRegistryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryResponseFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelCapability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelRegistryResponseFiltersProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryResponseFiltersProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessModelRegistryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelRegistryResponseString), TypeInfoPropertyName = "ResultModelRegistryResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OAIModelObject), TypeInfoPropertyName = "OAIModelObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OAIModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OAIModelsResponseObject), TypeInfoPropertyName = "OAIModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OAIModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TokenMetricStats), TypeInfoPropertyName = "TokenMetricStats2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelArrayString), TypeInfoPropertyName = "ResultModelArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelsToCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsFilterBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsFilterBodyTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TokensPerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTokensPerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTokensPerRequestString), TypeInfoPropertyName = "ResultTokensPerRequestString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestsOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRequestsOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.RequestsOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRequestsOverTimeArrayString), TypeInfoPropertyName = "ResultRequestsOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsOverTimeBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsOverTimeBodyTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CostOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCostOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.CostOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCostOverTimeArrayString), TypeInfoPropertyName = "ResultCostOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TokensOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTokensOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.TokensOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTokensOverTimeArrayString), TypeInfoPropertyName = "ResultTokensOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LatencyOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessLatencyOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.LatencyOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultLatencyOverTimeArrayString), TypeInfoPropertyName = "ResultLatencyOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeToFirstTokenOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTimeToFirstTokenOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.TimeToFirstTokenOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTimeToFirstTokenOverTimeArrayString), TypeInfoPropertyName = "ResultTimeToFirstTokenOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UsersOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUsersOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.UsersOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUsersOverTimeArrayString), TypeInfoPropertyName = "ResultUsersOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ThreatsOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessThreatsOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ThreatsOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultThreatsOverTimeArrayString), TypeInfoPropertyName = "ResultThreatsOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ErrorOverTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessErrorOverTimeArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ErrorOverTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorOverTimeArrayString), TypeInfoPropertyName = "ResultErrorOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestCountBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessModelMetricArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelMetricArrayString), TypeInfoPropertyName = "ResultModelMetricArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelMetricsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelMetricsBodyTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CountryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCountryDataArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.CountryData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCountryDataArrayString), TypeInfoPropertyName = "ResultCountryDataArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CountryMetricsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CountryMetricsBodyTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Quantiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessQuantilesArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Quantiles>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultQuantilesArrayString), TypeInfoPropertyName = "ResultQuantilesArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.QuantilesBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.QuantilesBodyTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUnsafeBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUnsafeBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUnsafeBooleanString), TypeInfoPropertyName = "ResultUnsafeBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ClickHouseTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ClickHouseTableSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ClickHouseTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessClickHouseTableSchemaArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ClickHouseTableSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultClickHouseTableSchemaArrayString), TypeInfoPropertyName = "ResultClickHouseTableSchemaArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExecuteSqlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.RecordStringAny>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExecuteSqlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExecuteSqlResponseString), TypeInfoPropertyName = "ResultExecuteSqlResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExecuteSqlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HqlSavedQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArrayHqlSavedQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HqlSavedQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayHqlSavedQueryString), TypeInfoPropertyName = "ResultArrayHqlSavedQueryString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHqlSavedQueryOrNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHqlSavedQueryOrNullString), TypeInfoPropertyName = "ResultHqlSavedQueryOrNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessVoid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultVoidString), TypeInfoPropertyName = "ResultVoidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.BulkDeleteSavedQueriesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHqlSavedQueryArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHqlSavedQueryArrayString), TypeInfoPropertyName = "ResultHqlSavedQueryArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateSavedQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHqlSavedQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHqlSavedQueryString), TypeInfoPropertyName = "ResultHqlSavedQueryString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTableIdStringExperimentIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTableIdStringExperimentIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTableIdStringExperimentIdStringString), TypeInfoPropertyName = "ResultTableIdStringExperimentIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateExperimentTableParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentTableColumnCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentTableColumnCell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentTableString), TypeInfoPropertyName = "ResultExperimentTableString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentTableSimplified))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentTableSimplifiedColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentTableSimplifiedColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentTableSimplified))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentTableSimplifiedString), TypeInfoPropertyName = "ResultExperimentTableSimplifiedString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessExperimentTableSimplifiedArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ExperimentTableSimplified>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentTableSimplifiedArrayString), TypeInfoPropertyName = "ResultExperimentTableSimplifiedArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.NewExperimentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHypothesisIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHypothesisIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHypothesisIdStringString), TypeInfoPropertyName = "ResultHypothesisIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Score2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.Score2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRunsCountNumberScoresRecordStringScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRunsCountNumberScoresRecordStringScoreData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRunsCountNumberScoresRecordStringScoreString), TypeInfoPropertyName = "ResultRunsCountNumberScoresRecordStringScoreString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentArrayString), TypeInfoPropertyName = "ResultExperimentArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterNode), TypeInfoPropertyName = "ExperimentFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterNodeEnum), TypeInfoPropertyName = "ExperimentFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterBranchOperator), TypeInfoPropertyName = "ExperimentFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.IncludeExperimentKeys))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessDatasetIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessDatasetIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDatasetIdStringString), TypeInfoPropertyName = "ResultDatasetIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.NewDatasetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.NewDatasetParamsDatasetType), TypeInfoPropertyName = "NewDatasetParamsDatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafRequestOrPromptsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterNode), TypeInfoPropertyName = "DatasetFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterNodeEnum), TypeInfoPropertyName = "DatasetFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterBranchOperator), TypeInfoPropertyName = "DatasetFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RandomDatasetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessDatasetResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.DatasetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDatasetResultArrayString), TypeInfoPropertyName = "ResultDatasetResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayString), TypeInfoPropertyName = "ResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeDatasetMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.NewHeliconeDatasetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MutateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeDatasetRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHeliconeDatasetRowArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HeliconeDatasetRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeDatasetRowArrayString), TypeInfoPropertyName = "ResultHeliconeDatasetRowArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHeliconeDatasetArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HeliconeDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeDatasetArrayString), TypeInfoPropertyName = "ResultHeliconeDatasetArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Eval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvalOverTimeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalOverTimeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.EvalAverageOverTimeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalAverageOverTimeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessEvalArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Eval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvalArrayString), TypeInfoPropertyName = "ResultEvalArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterNode), TypeInfoPropertyName = "EvalFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterNodeEnum), TypeInfoPropertyName = "EvalFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterBranchOperator), TypeInfoPropertyName = "EvalFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ScoreDistribution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ScoreDistributionDistributionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ScoreDistributionDistributionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreDistributionArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ScoreDistribution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreDistributionArrayString), TypeInfoPropertyName = "ResultScoreDistributionArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString), TypeInfoPropertyName = "ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CustomerUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Customer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreditBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCreditBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCreditBalanceResponseString), TypeInfoPropertyName = "ResultCreditBalanceResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PurchasedCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PaginatedPurchasedCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PurchasedCredits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPaginatedPurchasedCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPaginatedPurchasedCreditsString), TypeInfoPropertyName = "ResultPaginatedPurchasedCreditsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTotalSpendNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTotalSpendNumberData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTotalSpendNumberString), TypeInfoPropertyName = "ResultTotalSpendNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelSpend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelSpendPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SpendBreakdownResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelSpend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SpendBreakdownResponseTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSpendBreakdownResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSpendBreakdownResponseString), TypeInfoPropertyName = "ResultSpendBreakdownResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PTBInvoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPTBInvoiceArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PTBInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPTBInvoiceArrayString), TypeInfoPropertyName = "ResultPTBInvoiceArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OrgDiscount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessOrgDiscountArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OrgDiscount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOrgDiscountArrayString), TypeInfoPropertyName = "ResultOrgDiscountArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.InAppThread))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessInAppThread))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultInAppThreadString), TypeInfoPropertyName = "ResultInAppThreadString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSuccessBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBooleanString), TypeInfoPropertyName = "ResultSuccessBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ThreadSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessThreadSummaryArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ThreadSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultThreadSummaryArrayString), TypeInfoPropertyName = "ResultThreadSummaryArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions), TypeInfoPropertyName = "CreateAPIKeyRequestKeyPermissions2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetUserMetricsOverviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateSessionFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateSessionTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.DataOverTimeRequest, global::Helicone.GetPropertiesOverTimeRequest2>), TypeInfoPropertyName = "AllOfDataOverTimeRequestGetPropertiesOverTimeRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetPropertiesOverTimeRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HidePropertyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RestorePropertyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SearchPropertiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest2>), TypeInfoPropertyName = "AllOfOpenAIChatRequestGenerateRequest22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateNewExperimentHypothesisRequestStatus), TypeInfoPropertyName = "CreateNewExperimentHypothesisRequestStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>), TypeInfoPropertyName = "AllOfOpenAIChatRequestGenerateRequest42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GenerateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpsertThreadMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpsertThreadMessageRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SearchDocsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AddOnsProductType), TypeInfoPropertyName = "AddOnsProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteAddOnsProductType), TypeInfoPropertyName = "DeleteAddOnsProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetSpendBreakdownTimeRange), TypeInfoPropertyName = "GetSpendBreakdownTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfDeleteProviderKeyResponseVariant1DeleteProviderKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName), TypeInfoPropertyName = "DeleteProviderKeyResponseVariant1ProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>), TypeInfoPropertyName = "AnyOfDecryptedProviderKeyGetProviderKeyResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetProviderKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfCreateProviderKeyResponseVariant1CreateProviderKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProviderKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProviderKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>), TypeInfoPropertyName = "AnyOfIListProviderKeyRowGetProviderKeysResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetProviderKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfCreateAPIKeyResponseVariant1CreateAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfCreateProxyKeyResponseVariant1CreateProxyKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProxyKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProxyKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfDeleteAPIKeyResponseVariant1DeleteAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteAPIKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteAPIKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfUpdateAPIKeyResponseVariant1UpdateAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateAPIKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateAPIKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateCloudGatewayCheckoutSessionResponse))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArray), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_c61c916e4634eed4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem>), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_3dc749edd663c095")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_4cfba64094b5bdd5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayString), TypeInfoPropertyName = "ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrgan_cf349a6cf523295d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayString?), TypeInfoPropertyName = "ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrgan_ff3f6ffbba0c1639")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem>), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_8e953b8e000805f0")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultSuccessUnknown, global::Helicone.ResultErrorUnknown>), TypeInfoPropertyName = "AnyOfResultSuccessUnknownResultErrorUnknown2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ValidationResult, object>), TypeInfoPropertyName = "AnyOfValidationResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.HidePropertyResponse2>), TypeInfoPropertyName = "AnyOfResultErrorStringResultSuccessStringResultSuccessUnknownArrayHidePropertyResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HidePropertyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HidePropertyResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.RestorePropertyResponse2>), TypeInfoPropertyName = "AnyOfResultErrorStringResultSuccessStringResultSuccessUnknownArrayRestorePropertyResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RestorePropertyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RestorePropertyResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessUnknown>), TypeInfoPropertyName = "AnyOfResultErrorStringResultSuccessUnknown2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorUnknown, global::Helicone.ResultSuccessAny>), TypeInfoPropertyName = "AnyOfResultErrorUnknownResultSuccessAny2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Customer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringProviderNameStringString?), TypeInfoPropertyName = "NullableResultIdStringProviderNameStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorResultString?), TypeInfoPropertyName = "NullableResultEvaluatorResultString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorResultArrayString?), TypeInfoPropertyName = "NullableResultEvaluatorResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString?), TypeInfoPropertyName = "NullableResultNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorExperimentArrayString?), TypeInfoPropertyName = "NullableResultEvaluatorExperimentArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOnlineEvaluatorByEvaluatorIdArrayString?), TypeInfoPropertyName = "NullableResultOnlineEvaluatorByEvaluatorIdArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOutputStringTracesStringArrayStatusCode63NumberString?), TypeInfoPropertyName = "NullableResultOutputStringTracesStringArrayStatusCode63NumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<double?, bool?>?), TypeInfoPropertyName = "NullableAnyOfDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorScoreString?), TypeInfoPropertyName = "NullableResultEvaluatorScoreString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreNumberInputStringOutputStringGroundTruth63StringString?), TypeInfoPropertyName = "NullableResultScoreNumberInputStringOutputStringGroundTruth63StringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntry?), TypeInfoPropertyName = "NullableDataEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant1Type?), TypeInfoPropertyName = "NullableDataEntryVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant2Type?), TypeInfoPropertyName = "NullableDataEntryVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant3Content?), TypeInfoPropertyName = "NullableDataEntryVariant3Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant3Type?), TypeInfoPropertyName = "NullableDataEntryVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant4Content?), TypeInfoPropertyName = "NullableDataEntryVariant4Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataEntryVariant4Type?), TypeInfoPropertyName = "NullableDataEntryVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigForm?), TypeInfoPropertyName = "NullableLastMileConfigForm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.LastMileConfigFormVariant2Variant1, global::Helicone.LastMileConfigFormVariant2Variant2>?), TypeInfoPropertyName = "NullableAnyOfLastMileConfigFormVariant2Variant1LastMileConfigFormVariant2Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigFormVariant2Variant1Type?), TypeInfoPropertyName = "NullableLastMileConfigFormVariant2Variant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LastMileConfigFormVariant2Variant2Type?), TypeInfoPropertyName = "NullableLastMileConfigFormVariant2Variant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvaluatorStatsRecentTrend?), TypeInfoPropertyName = "NullableEvaluatorStatsRecentTrend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorStatsString?), TypeInfoPropertyName = "NullableResultEvaluatorStatsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025String?), TypeInfoPropertyName = "NullableResultPrompt2025String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringArrayString?), TypeInfoPropertyName = "NullableResultStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025InputString?), TypeInfoPropertyName = "NullableResultPrompt2025InputString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptCreateResponseString?), TypeInfoPropertyName = "NullableResultPromptCreateResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageToolCallType?), TypeInfoPropertyName = "NullableOpenAIChatRequestMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>?), TypeInfoPropertyName = "NullableAnyOfStringIListOpenAIChatRequestMessageContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<string>, string>?), TypeInfoPropertyName = "NullableAnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolType?), TypeInfoPropertyName = "NullableOpenAIChatRequestToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>?), TypeInfoPropertyName = "NullableAnyOfOpenAIChatRequestToolChoiceEnumOpenAIChatRequestToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType?), TypeInfoPropertyName = "NullableOpenAIChatRequestToolChoiceEnumFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum2?), TypeInfoPropertyName = "NullableOpenAIChatRequestToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestReasoningEffort?), TypeInfoPropertyName = "NullableOpenAIChatRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestVerbosity?), TypeInfoPropertyName = "NullableOpenAIChatRequestVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.OpenAIChatRequestFunctionCall>?), TypeInfoPropertyName = "NullableAnyOfStringOpenAIChatRequestFunctionCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringString?), TypeInfoPropertyName = "NullableResultIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNumberString?), TypeInfoPropertyName = "NullableResultNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025ArrayString?), TypeInfoPropertyName = "NullableResultPrompt2025ArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType?), TypeInfoPropertyName = "NullablePrompt2025VersionPromptBodyMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>?), TypeInfoPropertyName = "NullableAnyOfStringIListPrompt2025VersionPromptBodyMessageContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolType?), TypeInfoPropertyName = "NullablePrompt2025VersionPromptBodyToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.Prompt2025VersionPromptBodyToolChoice>?), TypeInfoPropertyName = "NullableAnyOfStringPrompt2025VersionPromptBodyToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType?), TypeInfoPropertyName = "NullablePrompt2025VersionPromptBodyToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025VersionString?), TypeInfoPropertyName = "NullableResultPrompt2025VersionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025VersionArrayString?), TypeInfoPropertyName = "NullableResultPrompt2025VersionArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionCountsString?), TypeInfoPropertyName = "NullableResultPromptVersionCountsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025Version91PromptBody93String?), TypeInfoPropertyName = "NullableResultPrompt2025Version91PromptBody93String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHasPromptsBooleanString?), TypeInfoPropertyName = "NullableResultHasPromptsBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptsResultArrayString?), TypeInfoPropertyName = "NullableResultPromptsResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterNode?), TypeInfoPropertyName = "NullablePromptsFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterNodeEnum?), TypeInfoPropertyName = "NullablePromptsFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsFilterBranchOperator?), TypeInfoPropertyName = "NullablePromptsFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptResultString?), TypeInfoPropertyName = "NullableResultPromptResultString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCreatePromptResponseString?), TypeInfoPropertyName = "NullableResultCreatePromptResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultMetadataRecordStringAnyString?), TypeInfoPropertyName = "NullableResultMetadataRecordStringAnyString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultString?), TypeInfoPropertyName = "NullableResultPromptVersionResultString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptInputRecordArrayString?), TypeInfoPropertyName = "NullableResultPromptInputRecordArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayString?), TypeInfoPropertyName = "NullableResultIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultArrayString?), TypeInfoPropertyName = "NullableResultPromptVersionResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterNode?), TypeInfoPropertyName = "NullablePromptVersionsFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterNodeEnum?), TypeInfoPropertyName = "NullablePromptVersionsFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterBranchOperator?), TypeInfoPropertyName = "NullablePromptVersionsFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultCompiledString?), TypeInfoPropertyName = "NullableResultPromptVersionResultCompiledString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultFilledString?), TypeInfoPropertyName = "NullableResultPromptVersionResultFilledString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentIdStringString?), TypeInfoPropertyName = "NullableResultExperimentIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentV2ArrayString?), TypeInfoPropertyName = "NullableResultExperimentV2ArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExtendedExperimentDataString?), TypeInfoPropertyName = "NullableResultExtendedExperimentDataString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Json?), TypeInfoPropertyName = "NullableJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentV2PromptVersionArrayString?), TypeInfoPropertyName = "NullableResultExperimentV2PromptVersionArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringString?), TypeInfoPropertyName = "NullableResultStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultBooleanString?), TypeInfoPropertyName = "NullableResultBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<double?, global::System.DateTime?, string>?), TypeInfoPropertyName = "NullableAnyOfDoubleDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRecordStringScoreV2String?), TypeInfoPropertyName = "NullableResultRecordStringScoreV2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreV2OrNullString?), TypeInfoPropertyName = "NullableResultScoreV2OrNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToProRequestUiMode?), TypeInfoPropertyName = "NullableUpgradeToProRequestUiMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpgradeToTeamBundleRequestUiMode?), TypeInfoPropertyName = "NullableUpgradeToTeamBundleRequestUiMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayIntegrationString?), TypeInfoPropertyName = "NullableResultArrayIntegrationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIntegrationString?), TypeInfoPropertyName = "NullableResultIntegrationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayIdStringNameStringString?), TypeInfoPropertyName = "NullableResultArrayIdStringNameStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterNode?), TypeInfoPropertyName = "NullableRequestFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterNodeEnum?), TypeInfoPropertyName = "NullableRequestFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestFilterBranchOperator?), TypeInfoPropertyName = "NullableRequestFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SortDirection?), TypeInfoPropertyName = "NullableSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderName?), TypeInfoPropertyName = "NullableProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderName?), TypeInfoPropertyName = "NullableModelProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Provider?), TypeInfoPropertyName = "NullableProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderEnum?), TypeInfoPropertyName = "NullableProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LlmType?), TypeInfoPropertyName = "NullableLlmType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageAnnotationType?), TypeInfoPropertyName = "NullableMessageAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageType?), TypeInfoPropertyName = "NullableMessageType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.MessageRole?>?), TypeInfoPropertyName = "NullableAnyOfStringMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageRole?), TypeInfoPropertyName = "NullableMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageType2?), TypeInfoPropertyName = "NullableMessageType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventToolType?), TypeInfoPropertyName = "NullableHeliconeEventToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventVectorDBType?), TypeInfoPropertyName = "NullableHeliconeEventVectorDBType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventVectorDBOperation?), TypeInfoPropertyName = "NullableHeliconeEventVectorDBOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HeliconeEventDataType?), TypeInfoPropertyName = "NullableHeliconeEventDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyReasoningEffort?), TypeInfoPropertyName = "NullableLLMRequestBodyReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyVerbosity?), TypeInfoPropertyName = "NullableLLMRequestBodyVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMRequestBodyToolChoiceType?), TypeInfoPropertyName = "NullableLLMRequestBodyToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseType?), TypeInfoPropertyName = "NullableResponseType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseRole?), TypeInfoPropertyName = "NullableResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseType2?), TypeInfoPropertyName = "NullableResponseType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyDataDetailsResponseType?), TypeInfoPropertyName = "NullableLLMResponseBodyDataDetailsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponseType?), TypeInfoPropertyName = "NullableLLMResponseBodyVectorDBDetailsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.LLMResponseBodyToolDetailsResponseType?), TypeInfoPropertyName = "NullableLLMResponseBodyToolDetailsResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeRequestArrayString?), TypeInfoPropertyName = "NullableResultHeliconeRequestArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeRequestString?), TypeInfoPropertyName = "NullableResultHeliconeRequestString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullString?), TypeInfoPropertyName = "NullableResultInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeRequestAssetString?), TypeInfoPropertyName = "NullableResultHeliconeRequestAssetString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultWrappedStatsString?), TypeInfoPropertyName = "NullableResultWrappedStatsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHasDataBooleanString?), TypeInfoPropertyName = "NullableResultHasDataBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayString?), TypeInfoPropertyName = "NullableResultIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBooleanMessageStringString?), TypeInfoPropertyName = "NullableResultSuccessBooleanMessageStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDecryptedProviderKeyArrayString?), TypeInfoPropertyName = "NullableResultDecryptedProviderKeyArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDecryptedProviderKeyString?), TypeInfoPropertyName = "NullableResultDecryptedProviderKeyString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString?), TypeInfoPropertyName = "NullableResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterNode?), TypeInfoPropertyName = "NullableUserFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterNodeEnum?), TypeInfoPropertyName = "NullableUserFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterBranchOperator?), TypeInfoPropertyName = "NullableUserFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PSize?), TypeInfoPropertyName = "NullablePSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString?), TypeInfoPropertyName = "NullableResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString?), TypeInfoPropertyName = "NullableResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionResultArrayString?), TypeInfoPropertyName = "NullableResultSessionResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterNode?), TypeInfoPropertyName = "NullableSessionFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterNodeEnum?), TypeInfoPropertyName = "NullableSessionFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionFilterBranchOperator?), TypeInfoPropertyName = "NullableSessionFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionsAggregateMetricsString?), TypeInfoPropertyName = "NullableResultSessionsAggregateMetricsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionNameResultArrayString?), TypeInfoPropertyName = "NullableResultSessionNameResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionNameQueryParamsPSize?), TypeInfoPropertyName = "NullableSessionNameQueryParamsPSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSessionMetricsString?), TypeInfoPropertyName = "NullableResultSessionMetricsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SessionMetricsQueryParamsPSize?), TypeInfoPropertyName = "NullableSessionMetricsQueryParamsPSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringOrNullString?), TypeInfoPropertyName = "NullableResultStringOrNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>?), TypeInfoPropertyName = "NullableAllOfMetricsDataProviderMetricsMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricsArrayString?), TypeInfoPropertyName = "NullableResultProviderMetricsArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricsString?), TypeInfoPropertyName = "NullableResultProviderMetricsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFrame?), TypeInfoPropertyName = "NullableTimeFrame2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricArrayString?), TypeInfoPropertyName = "NullableResultProviderMetricArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterNode?), TypeInfoPropertyName = "NullableFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterNodeEnum2?), TypeInfoPropertyName = "NullableFilterNodeEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterBranchOperator?), TypeInfoPropertyName = "NullableFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayString?), TypeInfoPropertyName = "NullableResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterNode?), TypeInfoPropertyName = "NullableRequestClickhouseFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterNodeEnum?), TypeInfoPropertyName = "NullableRequestClickhouseFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterBranchOperator?), TypeInfoPropertyName = "NullableRequestClickhouseFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeIncrement?), TypeInfoPropertyName = "NullableTimeIncrement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPropertyArrayString?), TypeInfoPropertyName = "NullableResultPropertyArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultValueStringCostNumberArrayString?), TypeInfoPropertyName = "NullableResultValueStringCostNumberArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultValueStringCountNumberArrayString?), TypeInfoPropertyName = "NullableResultValueStringCountNumberArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageAnnotationType?), TypeInfoPropertyName = "NullableChatCompletionMessageAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageFunctionToolCallType?), TypeInfoPropertyName = "NullableChatCompletionMessageFunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageCustomToolCallType?), TypeInfoPropertyName = "NullableChatCompletionMessageCustomToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageToolCall?), TypeInfoPropertyName = "NullableChatCompletionMessageToolCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionMessageRole?), TypeInfoPropertyName = "NullableChatCompletionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionChoiceFinishReason?), TypeInfoPropertyName = "NullableChatCompletionChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionObject?), TypeInfoPropertyName = "NullableChatCompletionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ChatCompletionServiceTier?), TypeInfoPropertyName = "NullableChatCompletionServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ChatCompletion, global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData>?), TypeInfoPropertyName = "NullableAnyOfChatCompletionResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultChatCompletionOrContentStringReasoningStringCallsAnyString?), TypeInfoPropertyName = "NullableResultChatCompletionOrContentStringReasoningStringCallsAnyString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyStringString?), TypeInfoPropertyName = "NullableResultApiKeyStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCostNumberCreatedAtTruncStringArrayString?), TypeInfoPropertyName = "NullableResultCostNumberCreatedAtTruncStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AuthorName?), TypeInfoPropertyName = "NullableAuthorName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.StandardParameter?), TypeInfoPropertyName = "NullableStandardParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PluginId?), TypeInfoPropertyName = "NullablePluginId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.BodyMappingType?), TypeInfoPropertyName = "NullableBodyMappingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseFormat?), TypeInfoPropertyName = "NullableResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderConfigQuantization?), TypeInfoPropertyName = "NullableModelProviderConfigQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.InputModality?), TypeInfoPropertyName = "NullableInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OutputModality?), TypeInfoPropertyName = "NullableOutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelCapability?), TypeInfoPropertyName = "NullableModelCapability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelRegistryResponseString?), TypeInfoPropertyName = "NullableResultModelRegistryResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OAIModelObject?), TypeInfoPropertyName = "NullableOAIModelObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OAIModelsResponseObject?), TypeInfoPropertyName = "NullableOAIModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TokenMetricStats?), TypeInfoPropertyName = "NullableTokenMetricStats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelArrayString?), TypeInfoPropertyName = "NullableResultModelArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTokensPerRequestString?), TypeInfoPropertyName = "NullableResultTokensPerRequestString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRequestsOverTimeArrayString?), TypeInfoPropertyName = "NullableResultRequestsOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCostOverTimeArrayString?), TypeInfoPropertyName = "NullableResultCostOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTokensOverTimeArrayString?), TypeInfoPropertyName = "NullableResultTokensOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultLatencyOverTimeArrayString?), TypeInfoPropertyName = "NullableResultLatencyOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTimeToFirstTokenOverTimeArrayString?), TypeInfoPropertyName = "NullableResultTimeToFirstTokenOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUsersOverTimeArrayString?), TypeInfoPropertyName = "NullableResultUsersOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultThreatsOverTimeArrayString?), TypeInfoPropertyName = "NullableResultThreatsOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorOverTimeArrayString?), TypeInfoPropertyName = "NullableResultErrorOverTimeArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelMetricArrayString?), TypeInfoPropertyName = "NullableResultModelMetricArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCountryDataArrayString?), TypeInfoPropertyName = "NullableResultCountryDataArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultQuantilesArrayString?), TypeInfoPropertyName = "NullableResultQuantilesArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUnsafeBooleanString?), TypeInfoPropertyName = "NullableResultUnsafeBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultClickHouseTableSchemaArrayString?), TypeInfoPropertyName = "NullableResultClickHouseTableSchemaArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExecuteSqlResponseString?), TypeInfoPropertyName = "NullableResultExecuteSqlResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayHqlSavedQueryString?), TypeInfoPropertyName = "NullableResultArrayHqlSavedQueryString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHqlSavedQueryOrNullString?), TypeInfoPropertyName = "NullableResultHqlSavedQueryOrNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultVoidString?), TypeInfoPropertyName = "NullableResultVoidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHqlSavedQueryArrayString?), TypeInfoPropertyName = "NullableResultHqlSavedQueryArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHqlSavedQueryString?), TypeInfoPropertyName = "NullableResultHqlSavedQueryString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTableIdStringExperimentIdStringString?), TypeInfoPropertyName = "NullableResultTableIdStringExperimentIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentTableString?), TypeInfoPropertyName = "NullableResultExperimentTableString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentTableSimplifiedString?), TypeInfoPropertyName = "NullableResultExperimentTableSimplifiedString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentTableSimplifiedArrayString?), TypeInfoPropertyName = "NullableResultExperimentTableSimplifiedArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHypothesisIdStringString?), TypeInfoPropertyName = "NullableResultHypothesisIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRunsCountNumberScoresRecordStringScoreString?), TypeInfoPropertyName = "NullableResultRunsCountNumberScoresRecordStringScoreString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultExperimentArrayString?), TypeInfoPropertyName = "NullableResultExperimentArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterNode?), TypeInfoPropertyName = "NullableExperimentFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterNodeEnum?), TypeInfoPropertyName = "NullableExperimentFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ExperimentFilterBranchOperator?), TypeInfoPropertyName = "NullableExperimentFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDatasetIdStringString?), TypeInfoPropertyName = "NullableResultDatasetIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.NewDatasetParamsDatasetType?), TypeInfoPropertyName = "NullableNewDatasetParamsDatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterNode?), TypeInfoPropertyName = "NullableDatasetFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterNodeEnum?), TypeInfoPropertyName = "NullableDatasetFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DatasetFilterBranchOperator?), TypeInfoPropertyName = "NullableDatasetFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultDatasetResultArrayString?), TypeInfoPropertyName = "NullableResultDatasetResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayString?), TypeInfoPropertyName = "NullableResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeDatasetRowArrayString?), TypeInfoPropertyName = "NullableResultHeliconeDatasetRowArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHeliconeDatasetArrayString?), TypeInfoPropertyName = "NullableResultHeliconeDatasetArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvalArrayString?), TypeInfoPropertyName = "NullableResultEvalArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterNode?), TypeInfoPropertyName = "NullableEvalFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterNodeEnum?), TypeInfoPropertyName = "NullableEvalFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EvalFilterBranchOperator?), TypeInfoPropertyName = "NullableEvalFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreDistributionArrayString?), TypeInfoPropertyName = "NullableResultScoreDistributionArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString?), TypeInfoPropertyName = "NullableResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCreditBalanceResponseString?), TypeInfoPropertyName = "NullableResultCreditBalanceResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPaginatedPurchasedCreditsString?), TypeInfoPropertyName = "NullableResultPaginatedPurchasedCreditsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTotalSpendNumberString?), TypeInfoPropertyName = "NullableResultTotalSpendNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSpendBreakdownResponseString?), TypeInfoPropertyName = "NullableResultSpendBreakdownResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPTBInvoiceArrayString?), TypeInfoPropertyName = "NullableResultPTBInvoiceArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOrgDiscountArrayString?), TypeInfoPropertyName = "NullableResultOrgDiscountArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultInAppThreadString?), TypeInfoPropertyName = "NullableResultInAppThreadString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBooleanString?), TypeInfoPropertyName = "NullableResultSuccessBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultThreadSummaryArrayString?), TypeInfoPropertyName = "NullableResultThreadSummaryArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions?), TypeInfoPropertyName = "NullableCreateAPIKeyRequestKeyPermissions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.DataOverTimeRequest, global::Helicone.GetPropertiesOverTimeRequest2>?), TypeInfoPropertyName = "NullableAllOfDataOverTimeRequestGetPropertiesOverTimeRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest2>?), TypeInfoPropertyName = "NullableAllOfOpenAIChatRequestGenerateRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateNewExperimentHypothesisRequestStatus?), TypeInfoPropertyName = "NullableCreateNewExperimentHypothesisRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>?), TypeInfoPropertyName = "NullableAllOfOpenAIChatRequestGenerateRequest42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AddOnsProductType?), TypeInfoPropertyName = "NullableAddOnsProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteAddOnsProductType?), TypeInfoPropertyName = "NullableDeleteAddOnsProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetSpendBreakdownTimeRange?), TypeInfoPropertyName = "NullableGetSpendBreakdownTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfDeleteProviderKeyResponseVariant1DeleteProviderKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName?), TypeInfoPropertyName = "NullableDeleteProviderKeyResponseVariant1ProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>?), TypeInfoPropertyName = "NullableAnyOfDecryptedProviderKeyGetProviderKeyResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateProviderKeyResponseVariant1CreateProviderKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>?), TypeInfoPropertyName = "NullableAnyOfIListProviderKeyRowGetProviderKeysResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateAPIKeyResponseVariant1CreateAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateProxyKeyResponseVariant1CreateProxyKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfDeleteAPIKeyResponseVariant1DeleteAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfUpdateAPIKeyResponseVariant1UpdateAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultSuccessUnknown, global::Helicone.ResultErrorUnknown>?), TypeInfoPropertyName = "NullableAnyOfResultSuccessUnknownResultErrorUnknown2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ValidationResult, object>?), TypeInfoPropertyName = "NullableAnyOfValidationResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.HidePropertyResponse2>?), TypeInfoPropertyName = "NullableAnyOfResultErrorStringResultSuccessStringResultSuccessUnknownArrayHidePropertyResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.RestorePropertyResponse2>?), TypeInfoPropertyName = "NullableAnyOfResultErrorStringResultSuccessStringResultSuccessUnknownArrayRestorePropertyResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessUnknown>?), TypeInfoPropertyName = "NullableAnyOfResultErrorStringResultSuccessUnknown2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ResultErrorUnknown, global::Helicone.ResultSuccessAny>?), TypeInfoPropertyName = "NullableAnyOfResultErrorUnknownResultSuccessAny2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Json?>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.RecordStringAny>))]
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
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Helicone.JsonConverters.ResultIdStringProviderNameStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultEvaluatorResultStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultEvaluatorResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultNullStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultEvaluatorExperimentArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultOnlineEvaluatorByEvaluatorIdArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultOutputStringTracesStringArrayStatusCode63NumberStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultEvaluatorScoreStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultScoreNumberInputStringOutputStringGroundTruth63StringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.DataEntryJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.LastMileConfigFormJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultEvaluatorStatsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025StringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultStringArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025InputStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptCreateResponseStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultIdStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultNumberStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025ArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025VersionStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025VersionArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptVersionCountsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025Version91PromptBody93StringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHasPromptsBooleanStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptsResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.PromptsFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptResultStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultCreatePromptResponseStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultMetadataRecordStringAnyStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptVersionResultStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptInputRecordArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptVersionResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.PromptVersionsFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptVersionResultCompiledStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptVersionResultFilledStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultExperimentIdStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultExperimentV2ArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultExtendedExperimentDataStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.JsonJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultExperimentV2PromptVersionArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultBooleanStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultRecordStringScoreV2StringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultScoreV2OrNullStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultArrayIntegrationStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultIntegrationStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultArrayIdStringNameStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.RequestFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ProviderJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHeliconeRequestArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHeliconeRequestStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHeliconeRequestAssetStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultWrappedStatsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHasDataBooleanStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSuccessBooleanMessageStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultDecryptedProviderKeyArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultDecryptedProviderKeyStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.UserFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSessionResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.SessionFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSessionsAggregateMetricsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSessionNameResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSessionMetricsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultStringOrNullStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultProviderMetricsArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultProviderMetricsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultProviderMetricArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.FilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.RequestClickhouseFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPropertyArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultValueStringCostNumberArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultValueStringCountNumberArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ChatCompletionMessageToolCallJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultChatCompletionOrContentStringReasoningStringCallsAnyStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultApiKeyStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultCostNumberCreatedAtTruncStringArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultModelRegistryResponseStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.TokenMetricStatsJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultModelArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultTokensPerRequestStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultRequestsOverTimeArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultCostOverTimeArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultTokensOverTimeArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultLatencyOverTimeArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultTimeToFirstTokenOverTimeArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultUsersOverTimeArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultThreatsOverTimeArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultErrorOverTimeArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultModelMetricArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultCountryDataArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultQuantilesArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultUnsafeBooleanStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultClickHouseTableSchemaArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultExecuteSqlResponseStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultArrayHqlSavedQueryStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHqlSavedQueryOrNullStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultVoidStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHqlSavedQueryArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHqlSavedQueryStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultTableIdStringExperimentIdStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultExperimentTableStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultExperimentTableSimplifiedStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultExperimentTableSimplifiedArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHypothesisIdStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultRunsCountNumberScoresRecordStringScoreStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultExperimentArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ExperimentFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultDatasetIdStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.DatasetFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultDatasetResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHeliconeDatasetRowArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHeliconeDatasetArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultEvalArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.EvalFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultScoreDistributionArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultCreditBalanceResponseStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPaginatedPurchasedCreditsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultTotalSpendNumberStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSpendBreakdownResponseStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPTBInvoiceArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultOrgDiscountArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultInAppThreadStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSuccessBooleanStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultThreadSummaryArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.LastMileConfigFormVariant2Variant1, global::Helicone.LastMileConfigFormVariant2Variant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.OpenAIChatRequestFunctionCall>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.Prompt2025VersionPromptBodyToolChoice>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.MessageRole?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ChatCompletion, global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.DataOverTimeRequest, global::Helicone.GetPropertiesOverTimeRequest2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultSuccessUnknown, global::Helicone.ResultErrorUnknown>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ValidationResult, object>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.HidePropertyResponse2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.RestorePropertyResponse2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessUnknown>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ResultErrorUnknown, global::Helicone.ResultSuccessAny>());
            options.Converters.Add(new global::Helicone.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Helicone.DataEntryVariant1Type)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant1Type?)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant2Type)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant2Type?)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant3Content)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant3Content?)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant3Type)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant3Type?)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant4Content)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant4Content?)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant4Type)

                    || typeToConvert == typeof(global::Helicone.DataEntryVariant4Type?)

                    || typeToConvert == typeof(global::Helicone.LastMileConfigFormVariant2Variant1Type)

                    || typeToConvert == typeof(global::Helicone.LastMileConfigFormVariant2Variant1Type?)

                    || typeToConvert == typeof(global::Helicone.LastMileConfigFormVariant2Variant2Type)

                    || typeToConvert == typeof(global::Helicone.LastMileConfigFormVariant2Variant2Type?)

                    || typeToConvert == typeof(global::Helicone.EvaluatorStatsRecentTrend)

                    || typeToConvert == typeof(global::Helicone.EvaluatorStatsRecentTrend?)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestMessageToolCallType)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestMessageToolCallType?)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolType)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolType?)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType?)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum2)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum2?)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestReasoningEffort)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestReasoningEffort?)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestVerbosity)

                    || typeToConvert == typeof(global::Helicone.OpenAIChatRequestVerbosity?)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType?)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolType)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolType?)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::Helicone.PromptsFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.PromptsFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.PromptsFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.PromptsFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.PromptVersionsFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.PromptVersionsFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.PromptVersionsFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.PromptVersionsFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.UpgradeToProRequestUiMode)

                    || typeToConvert == typeof(global::Helicone.UpgradeToProRequestUiMode?)

                    || typeToConvert == typeof(global::Helicone.UpgradeToTeamBundleRequestUiMode)

                    || typeToConvert == typeof(global::Helicone.UpgradeToTeamBundleRequestUiMode?)

                    || typeToConvert == typeof(global::Helicone.RequestFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.RequestFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.RequestFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.RequestFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.SortDirection)

                    || typeToConvert == typeof(global::Helicone.SortDirection?)

                    || typeToConvert == typeof(global::Helicone.ProviderName)

                    || typeToConvert == typeof(global::Helicone.ProviderName?)

                    || typeToConvert == typeof(global::Helicone.ModelProviderName)

                    || typeToConvert == typeof(global::Helicone.ModelProviderName?)

                    || typeToConvert == typeof(global::Helicone.ProviderEnum)

                    || typeToConvert == typeof(global::Helicone.ProviderEnum?)

                    || typeToConvert == typeof(global::Helicone.LlmType)

                    || typeToConvert == typeof(global::Helicone.LlmType?)

                    || typeToConvert == typeof(global::Helicone.MessageAnnotationType)

                    || typeToConvert == typeof(global::Helicone.MessageAnnotationType?)

                    || typeToConvert == typeof(global::Helicone.MessageType)

                    || typeToConvert == typeof(global::Helicone.MessageType?)

                    || typeToConvert == typeof(global::Helicone.MessageRole)

                    || typeToConvert == typeof(global::Helicone.MessageRole?)

                    || typeToConvert == typeof(global::Helicone.MessageType2)

                    || typeToConvert == typeof(global::Helicone.MessageType2?)

                    || typeToConvert == typeof(global::Helicone.HeliconeEventToolType)

                    || typeToConvert == typeof(global::Helicone.HeliconeEventToolType?)

                    || typeToConvert == typeof(global::Helicone.HeliconeEventVectorDBType)

                    || typeToConvert == typeof(global::Helicone.HeliconeEventVectorDBType?)

                    || typeToConvert == typeof(global::Helicone.HeliconeEventVectorDBOperation)

                    || typeToConvert == typeof(global::Helicone.HeliconeEventVectorDBOperation?)

                    || typeToConvert == typeof(global::Helicone.HeliconeEventDataType)

                    || typeToConvert == typeof(global::Helicone.HeliconeEventDataType?)

                    || typeToConvert == typeof(global::Helicone.LLMRequestBodyReasoningEffort)

                    || typeToConvert == typeof(global::Helicone.LLMRequestBodyReasoningEffort?)

                    || typeToConvert == typeof(global::Helicone.LLMRequestBodyVerbosity)

                    || typeToConvert == typeof(global::Helicone.LLMRequestBodyVerbosity?)

                    || typeToConvert == typeof(global::Helicone.LLMRequestBodyToolChoiceType)

                    || typeToConvert == typeof(global::Helicone.LLMRequestBodyToolChoiceType?)

                    || typeToConvert == typeof(global::Helicone.ResponseType)

                    || typeToConvert == typeof(global::Helicone.ResponseType?)

                    || typeToConvert == typeof(global::Helicone.ResponseRole)

                    || typeToConvert == typeof(global::Helicone.ResponseRole?)

                    || typeToConvert == typeof(global::Helicone.ResponseType2)

                    || typeToConvert == typeof(global::Helicone.ResponseType2?)

                    || typeToConvert == typeof(global::Helicone.LLMResponseBodyDataDetailsResponseType)

                    || typeToConvert == typeof(global::Helicone.LLMResponseBodyDataDetailsResponseType?)

                    || typeToConvert == typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponseType)

                    || typeToConvert == typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponseType?)

                    || typeToConvert == typeof(global::Helicone.LLMResponseBodyToolDetailsResponseType)

                    || typeToConvert == typeof(global::Helicone.LLMResponseBodyToolDetailsResponseType?)

                    || typeToConvert == typeof(global::Helicone.UserFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.UserFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.UserFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.UserFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.PSize)

                    || typeToConvert == typeof(global::Helicone.PSize?)

                    || typeToConvert == typeof(global::Helicone.SessionFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.SessionFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.SessionFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.SessionFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.SessionNameQueryParamsPSize)

                    || typeToConvert == typeof(global::Helicone.SessionNameQueryParamsPSize?)

                    || typeToConvert == typeof(global::Helicone.SessionMetricsQueryParamsPSize)

                    || typeToConvert == typeof(global::Helicone.SessionMetricsQueryParamsPSize?)

                    || typeToConvert == typeof(global::Helicone.TimeFrame)

                    || typeToConvert == typeof(global::Helicone.TimeFrame?)

                    || typeToConvert == typeof(global::Helicone.FilterNodeEnum2)

                    || typeToConvert == typeof(global::Helicone.FilterNodeEnum2?)

                    || typeToConvert == typeof(global::Helicone.FilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.FilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.RequestClickhouseFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.RequestClickhouseFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.RequestClickhouseFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.RequestClickhouseFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.TimeIncrement)

                    || typeToConvert == typeof(global::Helicone.TimeIncrement?)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionMessageAnnotationType)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionMessageAnnotationType?)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionMessageFunctionToolCallType)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionMessageFunctionToolCallType?)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionMessageCustomToolCallType)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionMessageCustomToolCallType?)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionMessageRole)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionMessageRole?)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionChoiceFinishReason)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionChoiceFinishReason?)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionObject)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionObject?)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionServiceTier)

                    || typeToConvert == typeof(global::Helicone.ChatCompletionServiceTier?)

                    || typeToConvert == typeof(global::Helicone.AuthorName)

                    || typeToConvert == typeof(global::Helicone.AuthorName?)

                    || typeToConvert == typeof(global::Helicone.StandardParameter)

                    || typeToConvert == typeof(global::Helicone.StandardParameter?)

                    || typeToConvert == typeof(global::Helicone.PluginId)

                    || typeToConvert == typeof(global::Helicone.PluginId?)

                    || typeToConvert == typeof(global::Helicone.BodyMappingType)

                    || typeToConvert == typeof(global::Helicone.BodyMappingType?)

                    || typeToConvert == typeof(global::Helicone.ResponseFormat)

                    || typeToConvert == typeof(global::Helicone.ResponseFormat?)

                    || typeToConvert == typeof(global::Helicone.ModelProviderConfigQuantization)

                    || typeToConvert == typeof(global::Helicone.ModelProviderConfigQuantization?)

                    || typeToConvert == typeof(global::Helicone.InputModality)

                    || typeToConvert == typeof(global::Helicone.InputModality?)

                    || typeToConvert == typeof(global::Helicone.OutputModality)

                    || typeToConvert == typeof(global::Helicone.OutputModality?)

                    || typeToConvert == typeof(global::Helicone.ModelCapability)

                    || typeToConvert == typeof(global::Helicone.ModelCapability?)

                    || typeToConvert == typeof(global::Helicone.OAIModelObject)

                    || typeToConvert == typeof(global::Helicone.OAIModelObject?)

                    || typeToConvert == typeof(global::Helicone.OAIModelsResponseObject)

                    || typeToConvert == typeof(global::Helicone.OAIModelsResponseObject?)

                    || typeToConvert == typeof(global::Helicone.ExperimentFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.ExperimentFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.ExperimentFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.ExperimentFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.NewDatasetParamsDatasetType)

                    || typeToConvert == typeof(global::Helicone.NewDatasetParamsDatasetType?)

                    || typeToConvert == typeof(global::Helicone.DatasetFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.DatasetFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.DatasetFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.DatasetFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.EvalFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.EvalFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.EvalFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.EvalFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions)

                    || typeToConvert == typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions?)

                    || typeToConvert == typeof(global::Helicone.CreateNewExperimentHypothesisRequestStatus)

                    || typeToConvert == typeof(global::Helicone.CreateNewExperimentHypothesisRequestStatus?)

                    || typeToConvert == typeof(global::Helicone.AddOnsProductType)

                    || typeToConvert == typeof(global::Helicone.AddOnsProductType?)

                    || typeToConvert == typeof(global::Helicone.DeleteAddOnsProductType)

                    || typeToConvert == typeof(global::Helicone.DeleteAddOnsProductType?)

                    || typeToConvert == typeof(global::Helicone.GetSpendBreakdownTimeRange)

                    || typeToConvert == typeof(global::Helicone.GetSpendBreakdownTimeRange?)

                    || typeToConvert == typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName)

                    || typeToConvert == typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Helicone.DataEntryVariant1Type))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant1Type?))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant2Type))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant2Type?))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant3Content))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant3ContentJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant3Content?))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant3ContentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant3Type))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant3Type?))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant4Content))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant4ContentJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant4Content?))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant4ContentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant4Type))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DataEntryVariant4Type?))
                {
                    return new global::Helicone.JsonConverters.DataEntryVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LastMileConfigFormVariant2Variant1Type))
                {
                    return new global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LastMileConfigFormVariant2Variant1Type?))
                {
                    return new global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LastMileConfigFormVariant2Variant2Type))
                {
                    return new global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LastMileConfigFormVariant2Variant2Type?))
                {
                    return new global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.EvaluatorStatsRecentTrend))
                {
                    return new global::Helicone.JsonConverters.EvaluatorStatsRecentTrendJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.EvaluatorStatsRecentTrend?))
                {
                    return new global::Helicone.JsonConverters.EvaluatorStatsRecentTrendNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestMessageToolCallType))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestMessageToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestMessageToolCallType?))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestMessageToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolType))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolType?))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnumFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType?))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnumFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum2))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnum2JsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum2?))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestToolChoiceEnum2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestReasoningEffort))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestReasoningEffort?))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestVerbosity))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OpenAIChatRequestVerbosity?))
                {
                    return new global::Helicone.JsonConverters.OpenAIChatRequestVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType))
                {
                    return new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType?))
                {
                    return new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolType))
                {
                    return new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolType?))
                {
                    return new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType))
                {
                    return new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType?))
                {
                    return new global::Helicone.JsonConverters.Prompt2025VersionPromptBodyToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PromptsFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.PromptsFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PromptsFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.PromptsFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PromptsFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.PromptsFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PromptsFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.PromptsFilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PromptVersionsFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.PromptVersionsFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PromptVersionsFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.PromptVersionsFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PromptVersionsFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.PromptVersionsFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PromptVersionsFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.PromptVersionsFilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UpgradeToProRequestUiMode))
                {
                    return new global::Helicone.JsonConverters.UpgradeToProRequestUiModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UpgradeToProRequestUiMode?))
                {
                    return new global::Helicone.JsonConverters.UpgradeToProRequestUiModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UpgradeToTeamBundleRequestUiMode))
                {
                    return new global::Helicone.JsonConverters.UpgradeToTeamBundleRequestUiModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UpgradeToTeamBundleRequestUiMode?))
                {
                    return new global::Helicone.JsonConverters.UpgradeToTeamBundleRequestUiModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.RequestFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.RequestFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.RequestFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.RequestFilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SortDirection))
                {
                    return new global::Helicone.JsonConverters.SortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SortDirection?))
                {
                    return new global::Helicone.JsonConverters.SortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ProviderName))
                {
                    return new global::Helicone.JsonConverters.ProviderNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ProviderName?))
                {
                    return new global::Helicone.JsonConverters.ProviderNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelProviderName))
                {
                    return new global::Helicone.JsonConverters.ModelProviderNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelProviderName?))
                {
                    return new global::Helicone.JsonConverters.ModelProviderNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ProviderEnum))
                {
                    return new global::Helicone.JsonConverters.ProviderEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ProviderEnum?))
                {
                    return new global::Helicone.JsonConverters.ProviderEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LlmType))
                {
                    return new global::Helicone.JsonConverters.LlmTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LlmType?))
                {
                    return new global::Helicone.JsonConverters.LlmTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.MessageAnnotationType))
                {
                    return new global::Helicone.JsonConverters.MessageAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.MessageAnnotationType?))
                {
                    return new global::Helicone.JsonConverters.MessageAnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.MessageType))
                {
                    return new global::Helicone.JsonConverters.MessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.MessageType?))
                {
                    return new global::Helicone.JsonConverters.MessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.MessageRole))
                {
                    return new global::Helicone.JsonConverters.MessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.MessageRole?))
                {
                    return new global::Helicone.JsonConverters.MessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.MessageType2))
                {
                    return new global::Helicone.JsonConverters.MessageType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.MessageType2?))
                {
                    return new global::Helicone.JsonConverters.MessageType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.HeliconeEventToolType))
                {
                    return new global::Helicone.JsonConverters.HeliconeEventToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.HeliconeEventToolType?))
                {
                    return new global::Helicone.JsonConverters.HeliconeEventToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.HeliconeEventVectorDBType))
                {
                    return new global::Helicone.JsonConverters.HeliconeEventVectorDBTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.HeliconeEventVectorDBType?))
                {
                    return new global::Helicone.JsonConverters.HeliconeEventVectorDBTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.HeliconeEventVectorDBOperation))
                {
                    return new global::Helicone.JsonConverters.HeliconeEventVectorDBOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.HeliconeEventVectorDBOperation?))
                {
                    return new global::Helicone.JsonConverters.HeliconeEventVectorDBOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.HeliconeEventDataType))
                {
                    return new global::Helicone.JsonConverters.HeliconeEventDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.HeliconeEventDataType?))
                {
                    return new global::Helicone.JsonConverters.HeliconeEventDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMRequestBodyReasoningEffort))
                {
                    return new global::Helicone.JsonConverters.LLMRequestBodyReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMRequestBodyReasoningEffort?))
                {
                    return new global::Helicone.JsonConverters.LLMRequestBodyReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMRequestBodyVerbosity))
                {
                    return new global::Helicone.JsonConverters.LLMRequestBodyVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMRequestBodyVerbosity?))
                {
                    return new global::Helicone.JsonConverters.LLMRequestBodyVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMRequestBodyToolChoiceType))
                {
                    return new global::Helicone.JsonConverters.LLMRequestBodyToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMRequestBodyToolChoiceType?))
                {
                    return new global::Helicone.JsonConverters.LLMRequestBodyToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ResponseType))
                {
                    return new global::Helicone.JsonConverters.ResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ResponseType?))
                {
                    return new global::Helicone.JsonConverters.ResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ResponseRole))
                {
                    return new global::Helicone.JsonConverters.ResponseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ResponseRole?))
                {
                    return new global::Helicone.JsonConverters.ResponseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ResponseType2))
                {
                    return new global::Helicone.JsonConverters.ResponseType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ResponseType2?))
                {
                    return new global::Helicone.JsonConverters.ResponseType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMResponseBodyDataDetailsResponseType))
                {
                    return new global::Helicone.JsonConverters.LLMResponseBodyDataDetailsResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMResponseBodyDataDetailsResponseType?))
                {
                    return new global::Helicone.JsonConverters.LLMResponseBodyDataDetailsResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponseType))
                {
                    return new global::Helicone.JsonConverters.LLMResponseBodyVectorDBDetailsResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMResponseBodyVectorDBDetailsResponseType?))
                {
                    return new global::Helicone.JsonConverters.LLMResponseBodyVectorDBDetailsResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMResponseBodyToolDetailsResponseType))
                {
                    return new global::Helicone.JsonConverters.LLMResponseBodyToolDetailsResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.LLMResponseBodyToolDetailsResponseType?))
                {
                    return new global::Helicone.JsonConverters.LLMResponseBodyToolDetailsResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UserFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.UserFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UserFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.UserFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UserFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.UserFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UserFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.UserFilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PSize))
                {
                    return new global::Helicone.JsonConverters.PSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PSize?))
                {
                    return new global::Helicone.JsonConverters.PSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SessionFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.SessionFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SessionFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.SessionFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SessionFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.SessionFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SessionFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.SessionFilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SessionNameQueryParamsPSize))
                {
                    return new global::Helicone.JsonConverters.SessionNameQueryParamsPSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SessionNameQueryParamsPSize?))
                {
                    return new global::Helicone.JsonConverters.SessionNameQueryParamsPSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SessionMetricsQueryParamsPSize))
                {
                    return new global::Helicone.JsonConverters.SessionMetricsQueryParamsPSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SessionMetricsQueryParamsPSize?))
                {
                    return new global::Helicone.JsonConverters.SessionMetricsQueryParamsPSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.TimeFrame))
                {
                    return new global::Helicone.JsonConverters.TimeFrameJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.TimeFrame?))
                {
                    return new global::Helicone.JsonConverters.TimeFrameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.FilterNodeEnum2))
                {
                    return new global::Helicone.JsonConverters.FilterNodeEnum2JsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.FilterNodeEnum2?))
                {
                    return new global::Helicone.JsonConverters.FilterNodeEnum2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.FilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.FilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.FilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.FilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestClickhouseFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.RequestClickhouseFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestClickhouseFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.RequestClickhouseFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestClickhouseFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.RequestClickhouseFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestClickhouseFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.RequestClickhouseFilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.TimeIncrement))
                {
                    return new global::Helicone.JsonConverters.TimeIncrementJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.TimeIncrement?))
                {
                    return new global::Helicone.JsonConverters.TimeIncrementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionMessageAnnotationType))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionMessageAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionMessageAnnotationType?))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionMessageAnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionMessageFunctionToolCallType))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionMessageFunctionToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionMessageFunctionToolCallType?))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionMessageFunctionToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionMessageCustomToolCallType))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionMessageCustomToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionMessageCustomToolCallType?))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionMessageCustomToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionMessageRole))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionMessageRole?))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionChoiceFinishReason))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionChoiceFinishReason?))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionObject))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionObject?))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionServiceTier))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ChatCompletionServiceTier?))
                {
                    return new global::Helicone.JsonConverters.ChatCompletionServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.AuthorName))
                {
                    return new global::Helicone.JsonConverters.AuthorNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.AuthorName?))
                {
                    return new global::Helicone.JsonConverters.AuthorNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.StandardParameter))
                {
                    return new global::Helicone.JsonConverters.StandardParameterJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.StandardParameter?))
                {
                    return new global::Helicone.JsonConverters.StandardParameterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PluginId))
                {
                    return new global::Helicone.JsonConverters.PluginIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PluginId?))
                {
                    return new global::Helicone.JsonConverters.PluginIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.BodyMappingType))
                {
                    return new global::Helicone.JsonConverters.BodyMappingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.BodyMappingType?))
                {
                    return new global::Helicone.JsonConverters.BodyMappingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ResponseFormat))
                {
                    return new global::Helicone.JsonConverters.ResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ResponseFormat?))
                {
                    return new global::Helicone.JsonConverters.ResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelProviderConfigQuantization))
                {
                    return new global::Helicone.JsonConverters.ModelProviderConfigQuantizationJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelProviderConfigQuantization?))
                {
                    return new global::Helicone.JsonConverters.ModelProviderConfigQuantizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.InputModality))
                {
                    return new global::Helicone.JsonConverters.InputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.InputModality?))
                {
                    return new global::Helicone.JsonConverters.InputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OutputModality))
                {
                    return new global::Helicone.JsonConverters.OutputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OutputModality?))
                {
                    return new global::Helicone.JsonConverters.OutputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelCapability))
                {
                    return new global::Helicone.JsonConverters.ModelCapabilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelCapability?))
                {
                    return new global::Helicone.JsonConverters.ModelCapabilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OAIModelObject))
                {
                    return new global::Helicone.JsonConverters.OAIModelObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OAIModelObject?))
                {
                    return new global::Helicone.JsonConverters.OAIModelObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OAIModelsResponseObject))
                {
                    return new global::Helicone.JsonConverters.OAIModelsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OAIModelsResponseObject?))
                {
                    return new global::Helicone.JsonConverters.OAIModelsResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ExperimentFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.ExperimentFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ExperimentFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.ExperimentFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ExperimentFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.ExperimentFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ExperimentFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.ExperimentFilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.NewDatasetParamsDatasetType))
                {
                    return new global::Helicone.JsonConverters.NewDatasetParamsDatasetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.NewDatasetParamsDatasetType?))
                {
                    return new global::Helicone.JsonConverters.NewDatasetParamsDatasetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DatasetFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.DatasetFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DatasetFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.DatasetFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DatasetFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.DatasetFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DatasetFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.DatasetFilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.EvalFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.EvalFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.EvalFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.EvalFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.EvalFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.EvalFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.EvalFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.EvalFilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions))
                {
                    return new global::Helicone.JsonConverters.CreateAPIKeyRequestKeyPermissionsJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions?))
                {
                    return new global::Helicone.JsonConverters.CreateAPIKeyRequestKeyPermissionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.CreateNewExperimentHypothesisRequestStatus))
                {
                    return new global::Helicone.JsonConverters.CreateNewExperimentHypothesisRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.CreateNewExperimentHypothesisRequestStatus?))
                {
                    return new global::Helicone.JsonConverters.CreateNewExperimentHypothesisRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.AddOnsProductType))
                {
                    return new global::Helicone.JsonConverters.AddOnsProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.AddOnsProductType?))
                {
                    return new global::Helicone.JsonConverters.AddOnsProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DeleteAddOnsProductType))
                {
                    return new global::Helicone.JsonConverters.DeleteAddOnsProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DeleteAddOnsProductType?))
                {
                    return new global::Helicone.JsonConverters.DeleteAddOnsProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.GetSpendBreakdownTimeRange))
                {
                    return new global::Helicone.JsonConverters.GetSpendBreakdownTimeRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.GetSpendBreakdownTimeRange?))
                {
                    return new global::Helicone.JsonConverters.GetSpendBreakdownTimeRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName))
                {
                    return new global::Helicone.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName?))
                {
                    return new global::Helicone.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}