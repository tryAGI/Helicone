
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestPythonEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestLLMEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestLastMileEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorResultString?), TypeInfoPropertyName = "NullableResultEvaluatorResultString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultEvaluatorResultArrayString?), TypeInfoPropertyName = "NullableResultEvaluatorResultArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString?), TypeInfoPropertyName = "NullableResultNullString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.EvaluatorResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OnlineEvaluatorByEvaluatorId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.EvaluatorStatsScoreDistributionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.EvaluatorStatsTimeSeriesDataItem>))]
    internal sealed partial class EvaluatorSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EvaluatorSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EvaluatorSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultEvaluatorResultStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultEvaluatorResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultNullStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultOnlineEvaluatorByEvaluatorIdArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultOutputStringTracesStringArrayStatusCode63NumberStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultEvaluatorScoreStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultScoreNumberInputStringOutputStringGroundTruth63StringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.DataEntryJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.LastMileConfigFormJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultEvaluatorStatsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.LastMileConfigFormVariant2Variant1, global::Helicone.LastMileConfigFormVariant2Variant2>());
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

                    || typeToConvert == typeof(global::Helicone.EvaluatorStatsRecentTrend?);
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
                    0 => new EvaluatorSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}