
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringString), TypeInfoPropertyName = "ResultIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNumberString), TypeInfoPropertyName = "ResultNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<string>, string>), TypeInfoPropertyName = "AnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RecordStringUnknown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringArrayString), TypeInfoPropertyName = "ResultStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025String), TypeInfoPropertyName = "ResultPrompt2025String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Prompt2025Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025InputString), TypeInfoPropertyName = "ResultPrompt2025InputString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptCreateResponseString), TypeInfoPropertyName = "ResultPromptCreateResponseString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPrompt2025Array))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Prompt2025>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025ArrayString), TypeInfoPropertyName = "ResultPrompt2025ArrayString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString?), TypeInfoPropertyName = "NullableResultNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringString?), TypeInfoPropertyName = "NullableResultIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNumberString?), TypeInfoPropertyName = "NullableResultNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<string>, string>?), TypeInfoPropertyName = "NullableAnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringArrayString?), TypeInfoPropertyName = "NullableResultStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025String?), TypeInfoPropertyName = "NullableResultPrompt2025String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPrompt2025InputString?), TypeInfoPropertyName = "NullableResultPrompt2025InputString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptCreateResponseString?), TypeInfoPropertyName = "NullableResultPromptCreateResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestMessageToolCallType?), TypeInfoPropertyName = "NullableOpenAIChatRequestMessageToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>?), TypeInfoPropertyName = "NullableAnyOfStringIListOpenAIChatRequestMessageContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolType?), TypeInfoPropertyName = "NullableOpenAIChatRequestToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>?), TypeInfoPropertyName = "NullableAnyOfOpenAIChatRequestToolChoiceEnumOpenAIChatRequestToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType?), TypeInfoPropertyName = "NullableOpenAIChatRequestToolChoiceEnumFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestToolChoiceEnum2?), TypeInfoPropertyName = "NullableOpenAIChatRequestToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestReasoningEffort?), TypeInfoPropertyName = "NullableOpenAIChatRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OpenAIChatRequestVerbosity?), TypeInfoPropertyName = "NullableOpenAIChatRequestVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::Helicone.OpenAIChatRequestFunctionCall>?), TypeInfoPropertyName = "NullableAnyOfStringOpenAIChatRequestFunctionCall2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OpenAIChatRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<string, global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025VersionPromptBodyTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Prompt2025Version>))]
    internal sealed partial class Prompt2025SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Prompt2025SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static Prompt2025SourceGenerationContext Default { get; } = new(DefaultOptions);

        private Prompt2025SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultIdStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultNumberStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultStringArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025StringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025InputStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptCreateResponseStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025ArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025VersionStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025VersionArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptVersionCountsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPrompt2025Version91PromptBody93StringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Helicone.OpenAIChatRequestMessageContentVariant2Item>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.OpenAIChatRequestToolChoiceEnum, global::Helicone.OpenAIChatRequestToolChoiceEnum2?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.OpenAIChatRequestFunctionCall>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Helicone.Prompt2025VersionPromptBodyMessageContentVariant2Item>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::Helicone.Prompt2025VersionPromptBodyToolChoice>());
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

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType?)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolType)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolType?)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType)

                    || typeToConvert == typeof(global::Helicone.Prompt2025VersionPromptBodyToolChoiceFunctionType?);
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
                    0 => new Prompt2025SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}