
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.MetricsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeSeriesDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>), TypeInfoPropertyName = "AllOfMetricsDataProviderMetricsMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderMetricsMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.TimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessProviderMetricsArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricsArrayString), TypeInfoPropertyName = "ResultProviderMetricsArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessProviderMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricsString), TypeInfoPropertyName = "ResultProviderMetricsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFrame), TypeInfoPropertyName = "TimeFrame2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AllOf<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>?), TypeInfoPropertyName = "NullableAllOfMetricsDataProviderMetricsMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricsArrayString?), TypeInfoPropertyName = "NullableResultProviderMetricsArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultProviderMetricsString?), TypeInfoPropertyName = "NullableResultProviderMetricsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeFrame?), TypeInfoPropertyName = "NullableTimeFrame2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.TimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ProviderMetrics>))]
    internal sealed partial class StatusSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StatusSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StatusSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StatusSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultProviderMetricsArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultProviderMetricsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AllOfJsonConverter<global::Helicone.MetricsData, global::Helicone.ProviderMetricsMetrics>());
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
                    typeToConvert == typeof(global::Helicone.TimeFrame)

                    || typeToConvert == typeof(global::Helicone.TimeFrame?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Helicone.TimeFrame))
                {
                    return new global::Helicone.JsonConverters.TimeFrameJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.TimeFrame?))
                {
                    return new global::Helicone.JsonConverters.TimeFrameNullableJsonConverter();
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
                    0 => new StatusSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}