
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTextOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialNumberOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPromptToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPromptVersionsToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHasPromptsBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessHasPromptsBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultHasPromptsBooleanString), TypeInfoPropertyName = "ResultHasPromptsBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptsResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PromptsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptsResultArrayString), TypeInfoPropertyName = "ResultPromptsResultArrayString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPromptVersionResultArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PromptVersionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultArrayString), TypeInfoPropertyName = "ResultPromptVersionResultArrayString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreatePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdatePromptUserDefinedIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromotePromptVersionToProductionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetInputsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString?), TypeInfoPropertyName = "NullableResultNullString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultArrayString?), TypeInfoPropertyName = "NullableResultPromptVersionResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterNode?), TypeInfoPropertyName = "NullablePromptVersionsFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterNodeEnum?), TypeInfoPropertyName = "NullablePromptVersionsFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PromptVersionsFilterBranchOperator?), TypeInfoPropertyName = "NullablePromptVersionsFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultCompiledString?), TypeInfoPropertyName = "NullableResultPromptVersionResultCompiledString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPromptVersionResultFilledString?), TypeInfoPropertyName = "NullableResultPromptVersionResultFilledString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PromptsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PromptInputRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PromptVersionResult>))]
    internal sealed partial class PromptSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PromptSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PromptSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultHasPromptsBooleanStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptsResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.PromptsFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptResultStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultCreatePromptResponseStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultMetadataRecordStringAnyStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptVersionResultStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptInputRecordArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptVersionResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.PromptVersionsFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptVersionResultCompiledStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPromptVersionResultFilledStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
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
                    typeToConvert == typeof(global::Helicone.PromptsFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.PromptsFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.PromptsFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.PromptsFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.PromptVersionsFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.PromptVersionsFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.PromptVersionsFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.PromptVersionsFilterBranchOperator?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new PromptSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}