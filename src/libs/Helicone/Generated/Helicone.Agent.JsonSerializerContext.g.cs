
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringString), TypeInfoPropertyName = "ResultStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<string>, string>), TypeInfoPropertyName = "AnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>), TypeInfoPropertyName = "AllOfOpenAIChatRequestGenerateRequest42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GenerateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpsertThreadMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpsertThreadMessageRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SearchDocsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringString?), TypeInfoPropertyName = "NullableResultStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<string>, string>?), TypeInfoPropertyName = "NullableAnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageToolCallType?), TypeInfoPropertyName = "NullableOpenAIChatRequestMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>?), TypeInfoPropertyName = "NullableAnyOfStringIListOpenAIChatRequestMessageContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolType?), TypeInfoPropertyName = "NullableOpenAIChatRequestToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>?), TypeInfoPropertyName = "NullableAnyOfOpenAIChatRequestToolChoiceEnumOpenAIChatRequestToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType?), TypeInfoPropertyName = "NullableOpenAIChatRequestToolChoiceEnumFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum2?), TypeInfoPropertyName = "NullableOpenAIChatRequestToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestReasoningEffort?), TypeInfoPropertyName = "NullableOpenAIChatRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestVerbosity?), TypeInfoPropertyName = "NullableOpenAIChatRequestVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.OpenAIChatRequestFunctionCall>?), TypeInfoPropertyName = "NullableAnyOfStringOpenAIChatRequestFunctionCall2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultInAppThreadString?), TypeInfoPropertyName = "NullableResultInAppThreadString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessBooleanString?), TypeInfoPropertyName = "NullableResultSuccessBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultThreadSummaryArrayString?), TypeInfoPropertyName = "NullableResultThreadSummaryArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>?), TypeInfoPropertyName = "NullableAllOfOpenAIChatRequestGenerateRequest42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ChatCompletionMessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ThreadSummary>))]
    internal sealed partial class AgentSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ChatCompletionMessageToolCallJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultChatCompletionOrContentStringReasoningStringCallsAnyStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultInAppThreadStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSuccessBooleanStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultThreadSummaryArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.OpenAIChatRequestFunctionCall>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ChatCompletion, global::Helicone.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData>());
            options.Converters.Add(new global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.OpenAIChatRequest, global::Helicone.GenerateRequest4>());
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
                    typeToConvert == typeof(global::Helicone.OpenAIChatRequestMessageToolCallType)

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

                    || typeToConvert == typeof(global::Helicone.ChatCompletionServiceTier?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new AgentSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}