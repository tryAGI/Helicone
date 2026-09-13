
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelsToCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TokenMetricStats?), TypeInfoPropertyName = "NullableTokenMetricStats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelArrayString?), TypeInfoPropertyName = "NullableResultModelArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.TimeSeriesMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelGeographicTtftItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelGeographicLatencyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelsToCompare>))]
    internal sealed partial class ComparisonSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComparisonSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ComparisonSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ComparisonSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.TokenMetricStatsJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultModelArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.UnixTimestampJsonConverter());
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
                    0 => new ComparisonSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}