
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
        public global::Helicone.MaskedProviderKey? Type4 { get; set; }
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
        public global::Helicone.DecryptedProviderKey? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessDecryptedProviderKeyArray? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.DecryptedProviderKey>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultDecryptedProviderKeyArrayString? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessDecryptedProviderKey? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultDecryptedProviderKeyString? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HistogramRow? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArray? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.HistogramRow>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialUserViewToOperators? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserFilterNode? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserFilterBranch? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserFilterNodeEnum? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserFilterBranchOperator? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PSize? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserMetricsResult? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.UserMetricsResult>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SortLeafUsers? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserMetricsQueryParams? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserMetricsQueryParamsTimeFilter? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserQueryParams? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserQueryParamsTimeFilter? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ValidationError? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ValidationResult? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ValidationError>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RecordStringUnknown? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TypedProviderRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TypedProviderResponse? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TypedTiming? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TypedAsyncLogModel? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTrace? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpan>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpan? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpan>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpan? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpanSpan>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpanSpan? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpanSpanStatus? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttributeValue? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanScopeSpanScope? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanResource? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanResourceAttribute>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanResourceAttribute? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanResourceAttributeValue? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValue? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SendTestRequestResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SendTestRequestRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionResult? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSessionResultArray? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.SessionResult>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSessionResultArrayString? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionFilterNode? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionFilterBranch? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionFilterNodeEnum? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionFilterBranchOperator? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionQueryParams? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionQueryParamsTimeFilter? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionsAggregateMetrics? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSessionsAggregateMetrics? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSessionsAggregateMetricsString? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionNameResult? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSessionNameResultArray? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.SessionNameResult>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSessionNameResultArrayString? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeFilterMs? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionNameQueryParams? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionNameQueryParamsPSize? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AverageRow? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionMetrics? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionMetricsAverage? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.AverageRow>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSessionMetrics? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSessionMetricsString? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionMetricsQueryParams? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SessionMetricsQueryParamsPSize? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessStringOrNull? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultStringOrNullString? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricsData? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeSeriesDataPoint? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderMetrics? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AllOf<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderMetricsMetrics? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.TimeSeriesDataPoint>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessProviderMetricsArray? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ProviderMetrics>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultProviderMetricsArrayString? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessProviderMetrics? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultProviderMetricsString? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeFrame? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderMetric? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessProviderMetricArray? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ProviderMetric>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultProviderMetricArrayString? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialUserMetricsToOperators? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialUserApiKeysTableToOperators? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialPropertiesTableToOperators? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialPromptToOperators? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialPromptVersionsToOperators? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialExperimentToOperators? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialExperimentHypothesisRunToOperator? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialScoreValueToOperator? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialRequestResponseLogToOperators? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialPropertiesV3ToOperators? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialPropertyWithResponseV1ToOperators? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialJobToOperators? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialNodesToOperators? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialCacheMetricsTableToOperators? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialRateLimitTableToOperators? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialOrganizationPropertiesToOperators? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PartialTablesAndViews? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FilterNode? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FilterBranch? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FilterNodeEnum2? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FilterBranchOperator? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderQueryParams? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ProviderQueryParamsTimeFilter? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArray? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayString? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafRequestResponseRmt? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestClickhouseFilterNode? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestClickhouseFilterBranch? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestClickhouseFilterNodeEnum? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestClickhouseFilterBranchOperator? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeIncrement? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataOverTimeRequest? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DataOverTimeRequestTimeFilter? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Property? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPropertyArray? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Property>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPropertyArrayString? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUnknownArray? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessStringArray? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultStringArrayString? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessValueStringCostNumberArray? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessValueStringCostNumberArrayDataItem>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessValueStringCostNumberArrayDataItem? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultValueStringCostNumberArrayString? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeFilterRequest? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeFilterRequestTimeFilter? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessValueStringCountNumberArray? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessValueStringCountNumberArrayDataItem>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessValueStringCountNumberArrayDataItem? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultValueStringCountNumberArrayString? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025String? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025Input? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025Input? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025InputString? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptCreateResponse? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptCreateResponse? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptCreateResponseString? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequest? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessage>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessage? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageToolCall>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessageToolCall? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessageToolCallType? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessageToolCallFunction? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessageContentVariant2Item? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestMessageContentVariant2ItemImageUrl? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestTool>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestTool? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolFunction? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolType? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolChoiceEnum? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolChoiceEnumFunction? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestToolChoiceEnum2? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestReasoningEffort? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestVerbosity? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestResponseFormat? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::Helicone.OpenAIChatRequestFunctionCall>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OpenAIChatRequestFunctionCall? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025Array? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025ArrayString? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBody? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessage>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessage? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageToolCall>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessageToolCall? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessageToolCallFunction? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2ItemImageUrl? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyTool>? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyTool? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyToolFunction? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyToolType? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<string, global::Helicone.Prompt2025VersionPromptBodyToolChoice>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyToolChoice? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunction? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Prompt2025Version? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025Version? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025VersionString? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025VersionArray? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Prompt2025Version>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025VersionArrayString? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionCounts? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptVersionCounts? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptVersionCountsString? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPrompt2025Version91PromptBody93? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPrompt2025Version91PromptBody93String? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHasPromptsBoolean? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHasPromptsBooleanData? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHasPromptsBooleanString? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsResult? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptsResultArray? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PromptsResult>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptsResultArrayString? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafPromptV2? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsFilterNode? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsFilterBranch? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsFilterNodeEnum? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsFilterBranchOperator? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptsQueryParams? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptResult? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptResult? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptResultString? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptQueryParams? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptQueryParamsTimeFilter? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreatePromptResponse? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCreatePromptResponse? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCreatePromptResponseString? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessMetadataRecordStringAny? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessMetadataRecordStringAnyData? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultMetadataRecordStringAnyString? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptEditSubversionLabelParams? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptEditSubversionTemplateParams? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionResult? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptVersionResult? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptVersionResultString? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptCreateSubversionParams? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptInputRecord? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptInputRecordArray? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PromptInputRecord>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptInputRecordArrayString? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptVersionResultArray? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PromptVersionResult>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptVersionResultArrayString? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafPromptsVersions? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsFilterNode? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsFilterBranch? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsFilterNodeEnum? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsFilterBranchOperator? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsQueryParams? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionResultCompiled? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptVersionResultCompiled? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptVersionResultCompiledString? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersiosQueryParamsCompiled? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionResultFilled? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPromptVersionResultFilled? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPromptVersionResultFilledString? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionTokenLogprobTopLogprob? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionTokenLogprob? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ChatCompletionTokenLogprobTopLogprob>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionChoiceLogprobs? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ChatCompletionTokenLogprob>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageAnnotationURLCitation? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageAnnotation? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageAnnotationType? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionAudio? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageFunctionCall? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageFunctionToolCallFunction? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageFunctionToolCall? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageFunctionToolCallType? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageCustomToolCallCustom? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageCustomToolCall? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageCustomToolCallType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageToolCall? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessage? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionMessageRole? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ChatCompletionMessageAnnotation>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ChatCompletionMessageToolCall>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionChoice? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionChoiceFinishReason? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CompletionUsageCompletionTokensDetails? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CompletionUsagePromptTokensDetails? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CompletionUsage? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletion? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ChatCompletionChoice>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionObject? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ChatCompletionServiceTier? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAny? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ChatCompletion, global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultChatCompletionOrContentStringReasoningStringCallsAnyString? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessBoolean? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultBooleanString? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSessionUUIDString? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSessionUUIDStringData? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSessionUUIDStringString? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessApiKeyString? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessApiKeyStringData? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultApiKeyStringString? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArray? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCostNumberCreatedAtTruncStringArrayString? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AuthorName? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.StandardParameter? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PluginId? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RateLimits? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModalityPricing? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelPricing? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelPricingCacheMultipliers? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.BodyMappingType? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EndpointConfig? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelPricing>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.EndpointConfig>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResponseFormat? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelProviderConfig? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.StandardParameter>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PluginId>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelProviderConfigQuantization? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UserEndpointConfig? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Endpoint? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SimplifiedModalityPricing? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SimplifiedPricing? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelEndpoint? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.SimplifiedPricing>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.InputModality? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OutputModality? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelRegistryItem? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelEndpoint>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.InputModality>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OutputModality>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelCapability? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelRegistryResponse? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelRegistryItem>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelRegistryResponseFilters? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelCapability>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelRegistryResponseFiltersProvider>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelRegistryResponseFiltersProvider? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessModelRegistryResponse? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultModelRegistryResponseString? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OAIModel? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OAIModelObject? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OAIModelsResponse? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OAIModelsResponseObject? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OAIModel>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricStats? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TokenMetricStats? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TokenMetricStatsVariant2? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeSeriesMetric? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Model? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelTimeSeriesData? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.TimeSeriesMetric>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelRequestStatus? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelGeographicTtftItem>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelGeographicTtftItem? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelGeographicLatencyItem>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelGeographicLatencyItem? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelFeedback? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelCosts? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessModelArray? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Model>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultModelArrayString? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelsToCompare? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricsFilterBody? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricsFilterBodyTimeFilter? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TokensPerRequest? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessTokensPerRequest? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultTokensPerRequestString? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestsOverTime? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessRequestsOverTimeArray? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.RequestsOverTime>? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultRequestsOverTimeArrayString? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricsOverTimeBody? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MetricsOverTimeBodyTimeFilter? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CostOverTime? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCostOverTimeArray? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.CostOverTime>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCostOverTimeArrayString? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TokensOverTime? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessTokensOverTimeArray? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.TokensOverTime>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultTokensOverTimeArrayString? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.LatencyOverTime? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessLatencyOverTimeArray? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.LatencyOverTime>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultLatencyOverTimeArrayString? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TimeToFirstTokenOverTime? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessTimeToFirstTokenOverTimeArray? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.TimeToFirstTokenOverTime>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultTimeToFirstTokenOverTimeArrayString? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UsersOverTime? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUsersOverTimeArray? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.UsersOverTime>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultUsersOverTimeArrayString? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ThreatsOverTime? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessThreatsOverTimeArray? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ThreatsOverTime>? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultThreatsOverTimeArrayString? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ErrorOverTime? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessErrorOverTimeArray? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ErrorOverTime>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultErrorOverTimeArrayString? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestCountBody? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelMetric? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessModelMetricArray? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelMetric>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultModelMetricArrayString? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelMetricsBody? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelMetricsBodyTimeFilter? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CountryData? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCountryDataArray? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.CountryData>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCountryDataArrayString? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CountryMetricsBody? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CountryMetricsBodyTimeFilter? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Quantiles? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessQuantilesArray? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Quantiles>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultQuantilesArrayString? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.QuantilesBody? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.QuantilesBodyTimeFilter? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUnsafeBoolean? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUnsafeBooleanData? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultUnsafeBooleanString? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ClickHouseTableColumn? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ClickHouseTableSchema? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ClickHouseTableColumn>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessClickHouseTableSchemaArray? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ClickHouseTableSchema>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultClickHouseTableSchemaArrayString? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ExecuteSqlResponse? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.RecordStringAny>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessExecuteSqlResponse? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultExecuteSqlResponseString? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ExecuteSqlRequest? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HqlSavedQuery? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessArrayHqlSavedQuery? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.HqlSavedQuery>? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultArrayHqlSavedQueryString? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHqlSavedQueryOrNull? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHqlSavedQueryOrNullString? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessVoid? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultVoidString? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.BulkDeleteSavedQueriesRequest? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHqlSavedQueryArray? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHqlSavedQueryArrayString? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateSavedQueryRequest? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHqlSavedQuery? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHqlSavedQueryString? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessDatasetIdString? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessDatasetIdStringData? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultDatasetIdStringString? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeDatasetMetadata? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.NewHeliconeDatasetParams? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.MutateParams? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeDatasetRow? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHeliconeDatasetRowArray? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.HeliconeDatasetRow>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHeliconeDatasetRowArrayString? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HeliconeDataset? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessHeliconeDatasetArray? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.HeliconeDataset>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultHeliconeDatasetArrayString? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessAny? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Eval? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.EvalOverTimeItem>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalOverTimeItem? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.EvalAverageOverTimeItem>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalAverageOverTimeItem? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessEvalArray? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Eval>? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultEvalArrayString? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalFilterNode? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalFilterBranch? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalFilterNodeEnum? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalFilterBranchOperator? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalQueryParams? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.EvalQueryParamsTimeFilter? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ScoreDistribution? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ScoreDistributionDistributionItem>? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ScoreDistributionDistributionItem? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessScoreDistributionArray? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ScoreDistribution>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultScoreDistributionArrayString? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem>? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CustomerUsage? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.Customer? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreditBalanceResponse? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessCreditBalanceResponse? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultCreditBalanceResponseString? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PurchasedCredits? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PaginatedPurchasedCredits? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PurchasedCredits>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPaginatedPurchasedCredits? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPaginatedPurchasedCreditsString? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessTotalSpendNumber? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessTotalSpendNumberData? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultTotalSpendNumberString? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelSpend? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ModelSpendPricing? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SpendBreakdownResponse? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelSpend>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SpendBreakdownResponseTimeRange? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSpendBreakdownResponse? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSpendBreakdownResponseString? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PTBInvoice? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessPTBInvoiceArray? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PTBInvoice>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultPTBInvoiceArrayString? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.OrgDiscount? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessOrgDiscountArray? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.OrgDiscount>? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultOrgDiscountArrayString? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.InAppThread? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessInAppThread? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultInAppThreadString? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSuccessBoolean? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessSuccessBooleanData? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessBooleanString? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ThreadSummary? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessThreadSummaryArray? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ThreadSummary>? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultThreadSummaryArrayString? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateAPIKeyRequest? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateAPIKeyRequestKeyPermissions? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProxyKeyRequest? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateAPIKeyRequest? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TestPythonEvaluatorRequest? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TestLLMEvaluatorRequest? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.TestLastMileEvaluatorRequest? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetRequestsByIdsRequest? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.FeedbackRequestRequest? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PutPropertyRequest? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateKeyRequest? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetUserMetricsOverviewRequest? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateSessionFeedbackRequest? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateSessionTagRequest? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AllOf<global::Helicone.DataOverTimeRequest, global::Helicone.GetPropertiesOverTimeRequest2>? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPropertiesOverTimeRequest2? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HidePropertyRequest? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RestorePropertyRequest? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SearchPropertiesRequest? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RenamePrompt2025Request? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdatePrompt2025TagsRequest? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreatePrompt2025Request? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdatePrompt2025Request? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SetPromptVersionEnvironmentRequest? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RemoveEnvironmentFromVersionRequest? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompts2025Request? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025VersionRequest? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025EnvironmentVersionRequest? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025VersionsRequest? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025ProductionVersionRequest? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025TotalVersionsRequest? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025VersionRequest2? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025EnvironmentVersionRequest2? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetPrompt2025ProductionVersionRequest2? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreatePromptRequest? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdatePromptUserDefinedIdRequest? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromotePromptVersionToProductionRequest? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetInputsRequest? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest2>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GenerateRequest2? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RequestsThroughHeliconeRequest? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetApiKeyRequest? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AddSessionRequest? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ModelsToCompare>? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSecurityRequest? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.QueryHeliconeDatasetRowsRequest? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.QueryHeliconeDatasetRequest? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateHeliconeDatasetRequestRequest? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AddEvalRequest? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GenerateRequest4? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpsertThreadMessageRequest? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpsertThreadMessageRequestMetadata? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.SearchDocsRequest? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSpendBreakdownTimeRange? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DeleteProviderKeyResponseVariant1? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DeleteProviderKeyResponseVariant1ProviderName? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DeleteProviderKeyResponseVariant2? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.MaskedProviderKey, global::Helicone.GetProviderKeyResponse2>? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetProviderKeyResponse2? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProviderKeyResponseVariant1? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProviderKeyResponseVariant2? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetProviderKeysResponse2? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateAPIKeyResponseVariant1? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateAPIKeyResponseVariant2? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProxyKeyResponseVariant1? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateProxyKeyResponseVariant2? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DeleteAPIKeyResponseVariant1? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DeleteAPIKeyResponseVariant2? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateAPIKeyResponseVariant1? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.UpdateAPIKeyResponseVariant2? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateCloudGatewayCheckoutSessionResponse? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PreviewInvoiceResponse? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.LLMUsage>? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PreviewInvoiceResponseDiscount? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PreviewInvoiceResponseDiscountCoupon? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PreviewInvoiceResponseLines? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PreviewInvoiceResponseLinesDataItem>? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PreviewInvoiceResponseLinesDataItem? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSubscriptionResponse? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.GetSubscriptionResponseItem>? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSubscriptionResponseItem? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSubscriptionResponseItemPrice? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.GetSubscriptionResponseItemPriceProduct? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.DisableAutoTopoffResponse? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.PaymentMethod>? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.CreateSetupSessionResponse? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RemovePaymentMethodResponse? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ResultSuccessUnknown, global::Helicone.ResultErrorUnknown>? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ValidationResult, object>? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.HidePropertyResponse2>? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HidePropertyResponse2? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.HidePropertyResponseData? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ResultErrorString, global::Helicone.ResultSuccessString, global::Helicone.ResultSuccessUnknownArray, global::Helicone.RestorePropertyResponse2>? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RestorePropertyResponse2? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.RestorePropertyResponseData? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Helicone.AnyOf<global::Helicone.ResultErrorUnknown, global::Helicone.ResultSuccessAny>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Helicone.Customer>? Type875 { get; set; }

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