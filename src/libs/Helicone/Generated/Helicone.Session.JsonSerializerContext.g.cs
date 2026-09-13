
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessNull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString), TypeInfoPropertyName = "ResultNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTextOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialNumberOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialBooleanOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTimestampOperatorsTyped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestResponseRMTToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestResponseRMTToOperatorsPropertyKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialSessionsRequestResponseRMTToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HistogramRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HistogramRow>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateSessionFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateSessionTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString?), TypeInfoPropertyName = "NullableResultNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.HistogramRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.SessionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.SessionNameResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.AverageRow>))]
    internal sealed partial class SessionSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SessionSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SessionSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSessionResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.SessionFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSessionsAggregateMetricsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSessionNameResultArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSessionMetricsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultStringOrNullStringJsonConverter());
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
                    typeToConvert == typeof(global::Helicone.SessionFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.SessionFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.SessionFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.SessionFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.SessionNameQueryParamsPSize)

                    || typeToConvert == typeof(global::Helicone.SessionNameQueryParamsPSize?)

                    || typeToConvert == typeof(global::Helicone.SessionMetricsQueryParamsPSize)

                    || typeToConvert == typeof(global::Helicone.SessionMetricsQueryParamsPSize?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new SessionSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}