
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorString))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialUserViewToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialUserMetricsToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialUserApiKeysTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPropertiesTableToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPromptToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialPromptVersionsToOperators))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeIncrement), TypeInfoPropertyName = "TimeIncrement2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNumberString?), TypeInfoPropertyName = "NullableResultNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterNode?), TypeInfoPropertyName = "NullableFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterNodeEnum2?), TypeInfoPropertyName = "NullableFilterNodeEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.FilterBranchOperator?), TypeInfoPropertyName = "NullableFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeIncrement?), TypeInfoPropertyName = "NullableTimeIncrement2")]
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
    internal sealed partial class MetricsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MetricsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MetricsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MetricsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultNumberStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.FilterNodeJsonConverter());
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
                    typeToConvert == typeof(global::Helicone.FilterNodeEnum2)

                    || typeToConvert == typeof(global::Helicone.FilterNodeEnum2?)

                    || typeToConvert == typeof(global::Helicone.FilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.FilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.TimeIncrement)

                    || typeToConvert == typeof(global::Helicone.TimeIncrement?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::Helicone.TimeIncrement))
                {
                    return new global::Helicone.JsonConverters.TimeIncrementJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.TimeIncrement?))
                {
                    return new global::Helicone.JsonConverters.TimeIncrementNullableJsonConverter();
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
                    0 => new MetricsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}