
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RecordStringAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString), TypeInfoPropertyName = "ResultNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<double?, bool?>), TypeInfoPropertyName = "AnyOfDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNumberString), TypeInfoPropertyName = "ResultNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTextOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialNumberOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTimestampOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialBooleanOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialFeedbackTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialResponseTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTimestampOperatorsTyped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.MessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageAnnotationType), TypeInfoPropertyName = "MessageAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MessageType), TypeInfoPropertyName = "MessageType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.FunctionCall>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<string>, string>), TypeInfoPropertyName = "AnyOfIListStringString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetRequestsByIdsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FeedbackRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PutPropertyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString?), TypeInfoPropertyName = "NullableResultNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<double?, bool?>?), TypeInfoPropertyName = "NullableAnyOfDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNumberString?), TypeInfoPropertyName = "NullableResultNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<string>, string>?), TypeInfoPropertyName = "NullableAnyOfIListStringString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.MessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.FunctionCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Response>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.HeliconeRequest>))]
    internal sealed partial class RequestSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RequestSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RequestSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Helicone.JsonConverters.ResultNullStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultNumberStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.RequestFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ProviderJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHeliconeRequestArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHeliconeRequestStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHeliconeRequestAssetStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.MessageRole?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Helicone.RequestFilterNodeEnum)

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

                    || typeToConvert == typeof(global::Helicone.LLMResponseBodyToolDetailsResponseType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new RequestSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}