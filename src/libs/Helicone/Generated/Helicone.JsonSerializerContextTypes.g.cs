
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Helicone
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProviderKeyRequest? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DecryptedProviderKey? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RecordStringAny? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderKeyRow? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessIdStringProviderNameString? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessIdStringProviderNameStringData? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultErrorString? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultIdStringProviderNameStringString? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateProviderKeyRequest? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvaluatorResult? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessEvaluatorResult? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultEvaluatorResultString? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateEvaluatorParams? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessEvaluatorResultArray? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.EvaluatorResult>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultEvaluatorResultArrayString? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateEvaluatorParams? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessNull? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultNullString? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OnlineEvaluatorByEvaluatorId? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessOnlineEvaluatorByEvaluatorIdArray? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OnlineEvaluatorByEvaluatorId>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultOnlineEvaluatorByEvaluatorIdArrayString? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateOnlineEvaluatorParams? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessOutputStringTracesStringArrayStatusCode63Number? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessOutputStringTracesStringArrayStatusCode63NumberData? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultOutputStringTracesStringArrayStatusCode63NumberString? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TestInput? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TestInputInputs? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvaluatorScore? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<double?, bool?>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessEvaluatorScore? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultEvaluatorScoreString? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvaluatorConfig? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63StringData? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultScoreNumberInputStringOutputStringGroundTruth63StringString? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntry? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntryVariant1? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntryVariant1Type? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntryVariant2? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntryVariant2Type? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntryVariant3? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntryVariant3Content? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntryVariant3Type? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntryVariant4? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntryVariant4Content? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataEntryVariant4Type? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.BaseLastMileConfigForm? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LastMileConfigForm? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.LastMileConfigFormVariant2Variant1, global::Helicone.LastMileConfigFormVariant2Variant2>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LastMileConfigFormVariant2Variant1? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LastMileConfigFormVariant2Variant1Type? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LastMileConfigFormVariant2Variant2? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LastMileConfigFormVariant2Variant2Type? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvaluatorStats? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvaluatorStatsRecentTrend? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.EvaluatorStatsScoreDistributionItem>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvaluatorStatsScoreDistributionItem? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.EvaluatorStatsTimeSeriesDataItem>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvaluatorStatsTimeSeriesDataItem? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessEvaluatorStats? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultEvaluatorStatsString? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateCloudGatewayCheckoutSessionRequest? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMUsage? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMUsageTotalCost? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PaymentIntentRecord? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.StripePaymentIntentsResponse? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PaymentIntentRecord>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AutoTopoffSettings? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateAutoTopoffSettingsRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PaymentMethod? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateSetupSessionRequest? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DailyUsageDataPoint? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UsageStatsResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UsageStatsResponseBillingPeriod? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UsageStatsResponseUsage? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.DailyUsageDataPoint>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UsageStatsResponseEstimatedCost? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessIdString? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessIdStringData? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultIdStringString? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Json? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.Json?>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Json?>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.IntegrationCreateParams? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Integration? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessArrayIntegration? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Integration>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultArrayIntegrationString? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.IntegrationUpdateParams? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessIntegration? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultIntegrationString? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessArrayIdStringNameString? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessArrayIdStringNameStringDataItem>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessArrayIdStringNameStringDataItem? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultArrayIdStringNameStringString? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessString? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultStringString? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TestStripeMeterEventRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessNumber? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultNumberString? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialTextOperators? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialNumberOperators? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialTimestampOperators? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialBooleanOperators? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialFeedbackTableToOperators? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialRequestTableToOperators? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialResponseTableToOperators? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialTimestampOperatorsTyped? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialRequestResponseRMTToOperators? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialRequestResponseRMTToOperatorsPropertyKey? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialSessionsRequestResponseRMTToOperators? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestFilterNode? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestFilterBranch? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestFilterNodeEnum? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestFilterBranchOperator? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SortDirection? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SortLeafRequest? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.SortDirection>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestQueryParams? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderName? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelProviderName? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Provider? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderEnum? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LlmType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FunctionCall? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Message? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.MessageAnnotation>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MessageAnnotation? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MessageAnnotationType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Message>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MessageType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.FunctionCall>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::Helicone.MessageRole?>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MessageRole? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MessageType2? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Tool? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeEventTool? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeEventToolType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeEventVectorDB? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeEventVectorDBType? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeEventVectorDBOperation? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeEventVectorDBFilter? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeEventData? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeEventDataType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMRequestBody? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMRequestBodyReasoningEffort? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMRequestBodyVerbosity? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Tool>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMRequestBodyToolChoice? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMRequestBodyToolChoiceType? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMRequestBodyResponseFormat? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Response? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Response>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResponseType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResponseRole? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResponseType2? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBody? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBodyDataDetailsResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBodyDataDetailsResponseType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBodyDataDetailsResponseMetadata? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBodyVectorDBDetailsResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBodyVectorDBDetailsResponseType? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBodyVectorDBDetailsResponseMetadata? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBodyToolDetailsResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBodyToolDetailsResponseType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBodyToolDetailsResponseMetadata? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LLMResponseBodyError? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LlmSchema? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeRequest? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHeliconeRequestArray? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.HeliconeRequest>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHeliconeRequestArrayString? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHeliconeRequest? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHeliconeRequestString? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNull? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullString? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeRequestAsset? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHeliconeRequestAsset? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHeliconeRequestAssetString? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RecordStringNumberOrBooleanOrUndefined? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ScoreRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ConversationMessage? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MostExpensiveRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MostExpensiveRequestConversation? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ConversationMessage>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.WrappedStats? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.WrappedStatsTopProvider>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.WrappedStatsTopProvider? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.WrappedStatsTopModel>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.WrappedStatsTopModel? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.WrappedStatsTotalTokens? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessWrappedStats? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultWrappedStatsString? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHasDataBoolean? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHasDataBooleanData? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHasDataBooleanString? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUnknown? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultErrorUnknown? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.WebhookData? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArray? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayString? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSuccessBooleanMessageString? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSuccessBooleanMessageStringData? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessBooleanMessageStringString? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AddVaultKeyParams? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessDecryptedProviderKeyArray? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.DecryptedProviderKey>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultDecryptedProviderKeyArrayString? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessDecryptedProviderKey? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultDecryptedProviderKeyString? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HistogramRow? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArray? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.HistogramRow>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialUserViewToOperators? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserFilterNode? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserFilterBranch? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserFilterNodeEnum? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserFilterBranchOperator? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PSize? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserMetricsResult? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.UserMetricsResult>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SortLeafUsers? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserMetricsQueryParams? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserMetricsQueryParamsTimeFilter? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserQueryParams? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserQueryParamsTimeFilter? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ValidationError? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ValidationResult? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ValidationError>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RecordStringUnknown? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TypedProviderRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TypedProviderResponse? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TypedTiming? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TypedAsyncLogModel? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTrace? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpan>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpan? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpan>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpan? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpanSpan>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpanSpan? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpanSpanStatus? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttributeValue? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpanScope? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanResource? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanResourceAttribute>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanResourceAttribute? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanResourceAttributeValue? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValue? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SendTestRequestResponse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SendTestRequestRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionResult? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSessionResultArray? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.SessionResult>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSessionResultArrayString? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionFilterNode? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionFilterBranch? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionFilterNodeEnum? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionFilterBranchOperator? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionQueryParams? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionQueryParamsTimeFilter? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionsAggregateMetrics? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSessionsAggregateMetrics? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSessionsAggregateMetricsString? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionNameResult? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSessionNameResultArray? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.SessionNameResult>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSessionNameResultArrayString? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeFilterMs? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionNameQueryParams? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionNameQueryParamsPSize? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AverageRow? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionMetrics? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionMetricsAverage? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.AverageRow>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSessionMetrics? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSessionMetricsString? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionMetricsQueryParams? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionMetricsQueryParamsPSize? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessStringOrNull? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultStringOrNullString? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricsData? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeSeriesDataPoint? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderMetrics? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AllOf<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderMetricsMetrics? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.TimeSeriesDataPoint>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessProviderMetricsArray? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ProviderMetrics>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultProviderMetricsArrayString? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessProviderMetrics? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultProviderMetricsString? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeFrame? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderMetric? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessProviderMetricArray? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ProviderMetric>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultProviderMetricArrayString? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialUserMetricsToOperators? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialUserApiKeysTableToOperators? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialPropertiesTableToOperators? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialPromptToOperators? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialPromptVersionsToOperators? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialExperimentToOperators? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialExperimentHypothesisRunToOperator? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialScoreValueToOperator? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialRequestResponseLogToOperators? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialPropertiesV3ToOperators? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialPropertyWithResponseV1ToOperators? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialJobToOperators? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialNodesToOperators? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialCacheMetricsTableToOperators? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialRateLimitTableToOperators? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialOrganizationPropertiesToOperators? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialTablesAndViews? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FilterNode? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FilterBranch? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FilterNodeEnum2? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FilterBranchOperator? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderQueryParams? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderQueryParamsTimeFilter? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArray? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayString? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafRequestResponseRmt? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestClickhouseFilterNode? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestClickhouseFilterBranch? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestClickhouseFilterNodeEnum? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestClickhouseFilterBranchOperator? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeIncrement? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataOverTimeRequest? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataOverTimeRequestTimeFilter? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Property? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPropertyArray? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Property>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPropertyArrayString? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUnknownArray? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessStringArray? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultStringArrayString? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessValueStringCostNumberArray? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessValueStringCostNumberArrayDataItem>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessValueStringCostNumberArrayDataItem? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultValueStringCostNumberArrayString? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeFilterRequest? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeFilterRequestTimeFilter? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessValueStringCountNumberArray? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessValueStringCountNumberArrayDataItem>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessValueStringCountNumberArrayDataItem? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultValueStringCountNumberArrayString? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025String? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025Input? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025Input? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025InputString? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptCreateResponse? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptCreateResponse? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptCreateResponseString? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequest? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessage>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessage? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageToolCall>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessageToolCall? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessageToolCallType? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessageToolCallFunction? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessageContentVariant2Item? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessageContentVariant2ItemImageUrl? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestTool>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestTool? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolFunction? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolChoiceEnum? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolChoiceEnumFunction? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolChoiceEnum2? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestReasoningEffort? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestVerbosity? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestResponseFormat? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::Helicone.OpenAIChatRequestFunctionCall>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestFunctionCall? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025Array? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025ArrayString? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBody? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessage>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessage? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageToolCall>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessageToolCall? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessageToolCallFunction? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2ItemImageUrl? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyTool>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyTool? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyToolFunction? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyToolType? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::Helicone.Prompt2025VersionPromptBodyToolChoice>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyToolChoice? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunction? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025Version? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025Version? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025VersionString? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025VersionArray? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025Version>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025VersionArrayString? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionCounts? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptVersionCounts? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptVersionCountsString? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025Version91PromptBody93? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025Version91PromptBody93String? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHasPromptsBoolean? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHasPromptsBooleanData? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHasPromptsBooleanString? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsResult? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptsResultArray? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PromptsResult>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptsResultArrayString? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafPromptV2? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsFilterNode? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsFilterBranch? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsFilterNodeEnum? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsFilterBranchOperator? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsQueryParams? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptResult? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptResult? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptResultString? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptQueryParams? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptQueryParamsTimeFilter? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreatePromptResponse? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCreatePromptResponse? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCreatePromptResponseString? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessMetadataRecordStringAny? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessMetadataRecordStringAnyData? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultMetadataRecordStringAnyString? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptEditSubversionLabelParams? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptEditSubversionTemplateParams? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionResult? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptVersionResult? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptVersionResultString? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptCreateSubversionParams? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptInputRecord? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptInputRecordArray? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PromptInputRecord>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptInputRecordArrayString? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptVersionResultArray? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PromptVersionResult>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptVersionResultArrayString? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafPromptsVersions? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsFilterNode? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsFilterBranch? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsFilterNodeEnum? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsFilterBranchOperator? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsQueryParams? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionResultCompiled? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptVersionResultCompiled? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptVersionResultCompiledString? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersiosQueryParamsCompiled? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionResultFilled? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptVersionResultFilled? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptVersionResultFilledString? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionTokenLogprobTopLogprob? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionTokenLogprob? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ChatCompletionTokenLogprobTopLogprob>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionChoiceLogprobs? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ChatCompletionTokenLogprob>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageAnnotationURLCitation? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageAnnotation? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageAnnotationType? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionAudio? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageFunctionCall? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageFunctionToolCallFunction? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageFunctionToolCall? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageFunctionToolCallType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageCustomToolCallCustom? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageCustomToolCall? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageCustomToolCallType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageToolCall? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessage? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageRole? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ChatCompletionMessageAnnotation>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ChatCompletionMessageToolCall>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionChoice? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionChoiceFinishReason? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CompletionUsageCompletionTokensDetails? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CompletionUsagePromptTokensDetails? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CompletionUsage? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletion? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ChatCompletionChoice>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionObject? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionServiceTier? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAny? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ChatCompletion, global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultChatCompletionOrContentStringReasoningStringCallsAnyString? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessBoolean? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultBooleanString? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessApiKeyString? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessApiKeyStringData? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultApiKeyStringString? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArray? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCostNumberCreatedAtTruncStringArrayString? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AuthorName? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.StandardParameter? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PluginId? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RateLimits? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModalityPricing? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelPricing? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelPricingCacheMultipliers? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.BodyMappingType? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EndpointConfig? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelPricing>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.EndpointConfig>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResponseFormat? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelProviderConfig? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.StandardParameter>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PluginId>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelProviderConfigQuantization? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserEndpointConfig? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Endpoint? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SimplifiedModalityPricing? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SimplifiedPricing? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelEndpoint? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.SimplifiedPricing>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.InputModality? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OutputModality? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelRegistryItem? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelEndpoint>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.InputModality>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OutputModality>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelCapability? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelRegistryResponse? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelRegistryItem>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelRegistryResponseFilters? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelCapability>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelRegistryResponseFiltersProvider>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelRegistryResponseFiltersProvider? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessModelRegistryResponse? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultModelRegistryResponseString? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OAIModel? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OAIModelObject? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OAIModelsResponse? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OAIModelsResponseObject? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OAIModel>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricStats? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TokenMetricStats? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TokenMetricStatsVariant2? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeSeriesMetric? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Model? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelTimeSeriesData? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.TimeSeriesMetric>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelRequestStatus? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelGeographicTtftItem>? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelGeographicTtftItem? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelGeographicLatencyItem>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelGeographicLatencyItem? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelFeedback? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelCosts? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessModelArray? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Model>? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultModelArrayString? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelsToCompare? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricsFilterBody? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricsFilterBodyTimeFilter? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TokensPerRequest? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessTokensPerRequest? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultTokensPerRequestString? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestsOverTime? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessRequestsOverTimeArray? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.RequestsOverTime>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultRequestsOverTimeArrayString? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricsOverTimeBody? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricsOverTimeBodyTimeFilter? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CostOverTime? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCostOverTimeArray? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.CostOverTime>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCostOverTimeArrayString? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TokensOverTime? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessTokensOverTimeArray? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.TokensOverTime>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultTokensOverTimeArrayString? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LatencyOverTime? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessLatencyOverTimeArray? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.LatencyOverTime>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultLatencyOverTimeArrayString? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeToFirstTokenOverTime? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessTimeToFirstTokenOverTimeArray? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.TimeToFirstTokenOverTime>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultTimeToFirstTokenOverTimeArrayString? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UsersOverTime? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUsersOverTimeArray? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.UsersOverTime>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultUsersOverTimeArrayString? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ThreatsOverTime? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessThreatsOverTimeArray? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ThreatsOverTime>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultThreatsOverTimeArrayString? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ErrorOverTime? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessErrorOverTimeArray? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ErrorOverTime>? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultErrorOverTimeArrayString? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestCountBody? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelMetric? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessModelMetricArray? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelMetric>? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultModelMetricArrayString? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelMetricsBody? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelMetricsBodyTimeFilter? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CountryData? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCountryDataArray? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.CountryData>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCountryDataArrayString? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CountryMetricsBody? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CountryMetricsBodyTimeFilter? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Quantiles? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessQuantilesArray? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Quantiles>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultQuantilesArrayString? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.QuantilesBody? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.QuantilesBodyTimeFilter? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUnsafeBoolean? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUnsafeBooleanData? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultUnsafeBooleanString? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ClickHouseTableColumn? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ClickHouseTableSchema? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ClickHouseTableColumn>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessClickHouseTableSchemaArray? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ClickHouseTableSchema>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultClickHouseTableSchemaArrayString? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ExecuteSqlResponse? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.RecordStringAny>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessExecuteSqlResponse? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultExecuteSqlResponseString? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ExecuteSqlRequest? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HqlSavedQuery? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessArrayHqlSavedQuery? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.HqlSavedQuery>? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultArrayHqlSavedQueryString? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHqlSavedQueryOrNull? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHqlSavedQueryOrNullString? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessVoid? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultVoidString? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.BulkDeleteSavedQueriesRequest? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHqlSavedQueryArray? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHqlSavedQueryArrayString? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateSavedQueryRequest? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHqlSavedQuery? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHqlSavedQueryString? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessDatasetIdString? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessDatasetIdStringData? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultDatasetIdStringString? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeDatasetMetadata? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.NewHeliconeDatasetParams? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MutateParams? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeDatasetRow? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHeliconeDatasetRowArray? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.HeliconeDatasetRow>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHeliconeDatasetRowArrayString? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeDataset? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHeliconeDatasetArray? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.HeliconeDataset>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHeliconeDatasetArrayString? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessAny? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Eval? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.EvalOverTimeItem>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalOverTimeItem? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.EvalAverageOverTimeItem>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalAverageOverTimeItem? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessEvalArray? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Eval>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultEvalArrayString? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalFilterNode? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalFilterBranch? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalFilterNodeEnum? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalFilterBranchOperator? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalQueryParams? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalQueryParamsTimeFilter? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ScoreDistribution? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ScoreDistributionDistributionItem>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ScoreDistributionDistributionItem? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessScoreDistributionArray? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ScoreDistribution>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultScoreDistributionArrayString? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CustomerUsage? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Customer? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreditBalanceResponse? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCreditBalanceResponse? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCreditBalanceResponseString? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PurchasedCredits? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PaginatedPurchasedCredits? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PurchasedCredits>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPaginatedPurchasedCredits? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPaginatedPurchasedCreditsString? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessTotalSpendNumber? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessTotalSpendNumberData? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultTotalSpendNumberString? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelSpend? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelSpendPricing? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SpendBreakdownResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelSpend>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SpendBreakdownResponseTimeRange? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSpendBreakdownResponse? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSpendBreakdownResponseString? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PTBInvoice? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPTBInvoiceArray? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PTBInvoice>? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPTBInvoiceArrayString? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OrgDiscount? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessOrgDiscountArray? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OrgDiscount>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultOrgDiscountArrayString? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.InAppThread? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessInAppThread? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultInAppThreadString? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSuccessBoolean? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSuccessBooleanData? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessBooleanString? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ThreadSummary? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessThreadSummaryArray? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ThreadSummary>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultThreadSummaryArrayString? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateAPIKeyRequest? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateAPIKeyRequestKeyPermissions? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProxyKeyRequest? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateAPIKeyRequest? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TestPythonEvaluatorRequest? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TestLLMEvaluatorRequest? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TestLastMileEvaluatorRequest? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetRequestsByIdsRequest? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FeedbackRequestRequest? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PutPropertyRequest? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateKeyRequest? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetUserMetricsOverviewRequest? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateSessionFeedbackRequest? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateSessionTagRequest? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AllOf<global::Helicone.DataOverTimeRequest, global::Helicone.GetPropertiesOverTimeRequest2>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPropertiesOverTimeRequest2? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HidePropertyRequest? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RestorePropertyRequest? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SearchPropertiesRequest? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RenamePrompt2025Request? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdatePrompt2025TagsRequest? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreatePrompt2025Request? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdatePrompt2025Request? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SetPromptVersionEnvironmentRequest? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RemoveEnvironmentFromVersionRequest? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompts2025Request? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025VersionRequest? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025EnvironmentVersionRequest? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025VersionsRequest? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025ProductionVersionRequest? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025TotalVersionsRequest? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025VersionRequest2? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025EnvironmentVersionRequest2? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025ProductionVersionRequest2? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreatePromptRequest? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdatePromptUserDefinedIdRequest? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromotePromptVersionToProductionRequest? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetInputsRequest? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest2>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GenerateRequest2? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestsThroughHeliconeRequest? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetApiKeyRequest? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AddSessionRequest? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelsToCompare>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSecurityRequest? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.QueryHeliconeDatasetRowsRequest? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.QueryHeliconeDatasetRequest? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateHeliconeDatasetRequestRequest? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AddEvalRequest? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GenerateRequest4? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpsertThreadMessageRequest? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpsertThreadMessageRequestMetadata? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SearchDocsRequest? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSpendBreakdownTimeRange? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DeleteProviderKeyResponseVariant1? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DeleteProviderKeyResponseVariant1ProviderName? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DeleteProviderKeyResponseVariant2? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetProviderKeyResponse2? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProviderKeyResponseVariant1? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProviderKeyResponseVariant2? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetProviderKeysResponse2? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateAPIKeyResponseVariant1? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateAPIKeyResponseVariant2? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProxyKeyResponseVariant1? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProxyKeyResponseVariant2? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DeleteAPIKeyResponseVariant1? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DeleteAPIKeyResponseVariant2? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateAPIKeyResponseVariant1? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateAPIKeyResponseVariant2? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateCloudGatewayCheckoutSessionResponse? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PreviewInvoiceResponse? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.LLMUsage>? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PreviewInvoiceResponseDiscount? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PreviewInvoiceResponseDiscountCoupon? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PreviewInvoiceResponseLines? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PreviewInvoiceResponseLinesDataItem>? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PreviewInvoiceResponseLinesDataItem? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSubscriptionResponse? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.GetSubscriptionResponseItem>? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSubscriptionResponseItem? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSubscriptionResponseItemPrice? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSubscriptionResponseItemPriceProduct? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DisableAutoTopoffResponse? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PaymentMethod>? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateSetupSessionResponse? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RemovePaymentMethodResponse? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ResultSuccessUnknown, global::Helicone.ResultErrorUnknown>? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ValidationResult, object>? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.HidePropertyResponse2>? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HidePropertyResponse2? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HidePropertyResponseData? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.RestorePropertyResponse2>? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RestorePropertyResponse2? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RestorePropertyResponseData? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ResultErrorUnknown, global::Helicone.ResultSuccessAny>? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Customer>? Type871 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.EvaluatorResult>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OnlineEvaluatorByEvaluatorId>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.EvaluatorStatsScoreDistributionItem>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.EvaluatorStatsTimeSeriesDataItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.PaymentIntentRecord>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.DailyUsageDataPoint>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Json?>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Integration>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ResultSuccessArrayIdStringNameStringDataItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.MessageAnnotation>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Message>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.FunctionCall>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Tool>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Response>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.HeliconeRequest>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ConversationMessage>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.WrappedStatsTopProvider>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.WrappedStatsTopModel>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.DecryptedProviderKey>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.HistogramRow>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.UserMetricsResult>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ValidationError>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpan>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanScopeSpan>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanScopeSpanSpan>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanResourceAttribute>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.SessionResult>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.SessionNameResult>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.AverageRow>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.TimeSeriesDataPoint>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ProviderMetrics>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ProviderMetric>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Property>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ResultSuccessValueStringCostNumberArrayDataItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ResultSuccessValueStringCountNumberArrayDataItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessage>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageToolCall>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestTool>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Prompt2025>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessage>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessageToolCall>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyTool>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Prompt2025Version>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.PromptsResult>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.PromptInputRecord>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.PromptVersionResult>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ChatCompletionTokenLogprobTopLogprob>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ChatCompletionTokenLogprob>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ChatCompletionMessageAnnotation>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ChatCompletionMessageToolCall>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ChatCompletionChoice>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ModelPricing>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.StandardParameter>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.PluginId>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.SimplifiedPricing>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ModelEndpoint>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.InputModality>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OutputModality>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ModelRegistryItem>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ModelCapability>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ModelRegistryResponseFiltersProvider>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OAIModel>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.TimeSeriesMetric>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ModelGeographicTtftItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ModelGeographicLatencyItem>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Model>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.RequestsOverTime>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.CostOverTime>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.TokensOverTime>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.LatencyOverTime>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.TimeToFirstTokenOverTime>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.UsersOverTime>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ThreatsOverTime>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ErrorOverTime>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ModelMetric>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.CountryData>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Quantiles>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ClickHouseTableColumn>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ClickHouseTableSchema>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.RecordStringAny>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.HqlSavedQuery>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.HeliconeDatasetRow>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.HeliconeDataset>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.EvalOverTimeItem>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.EvalAverageOverTimeItem>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Eval>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ScoreDistributionDistributionItem>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ScoreDistribution>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.PurchasedCredits>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ModelSpend>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.PTBInvoice>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.OrgDiscount>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ThreadSummary>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ModelsToCompare>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::System.Collections.Generic.List<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.ProviderKeyRow>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.LLMUsage>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.PreviewInvoiceResponseLinesDataItem>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.GetSubscriptionResponseItem>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.PaymentMethod>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Helicone.Customer>? ListType116 { get; set; }
    }
}