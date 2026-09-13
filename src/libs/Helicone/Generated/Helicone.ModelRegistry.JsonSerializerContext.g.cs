
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderName), TypeInfoPropertyName = "ModelProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AuthorName), TypeInfoPropertyName = "AuthorName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.StandardParameter), TypeInfoPropertyName = "StandardParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PluginId), TypeInfoPropertyName = "PluginId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RateLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModalityPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelPricingCacheMultipliers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.BodyMappingType), TypeInfoPropertyName = "BodyMappingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.EndpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelPricing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.EndpointConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseFormat), TypeInfoPropertyName = "ResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.StandardParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PluginId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderConfigQuantization), TypeInfoPropertyName = "ModelProviderConfigQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserEndpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SimplifiedModalityPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SimplifiedPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.SimplifiedPricing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.InputModality), TypeInfoPropertyName = "InputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OutputModality), TypeInfoPropertyName = "OutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelCapability), TypeInfoPropertyName = "ModelCapability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelRegistryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryResponseFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelCapability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelRegistryResponseFiltersProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelRegistryResponseFiltersProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessModelRegistryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelRegistryResponseString), TypeInfoPropertyName = "ResultModelRegistryResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderName?), TypeInfoPropertyName = "NullableModelProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AuthorName?), TypeInfoPropertyName = "NullableAuthorName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.StandardParameter?), TypeInfoPropertyName = "NullableStandardParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PluginId?), TypeInfoPropertyName = "NullablePluginId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.BodyMappingType?), TypeInfoPropertyName = "NullableBodyMappingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResponseFormat?), TypeInfoPropertyName = "NullableResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderConfigQuantization?), TypeInfoPropertyName = "NullableModelProviderConfigQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.InputModality?), TypeInfoPropertyName = "NullableInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OutputModality?), TypeInfoPropertyName = "NullableOutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelCapability?), TypeInfoPropertyName = "NullableModelCapability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultModelRegistryResponseString?), TypeInfoPropertyName = "NullableResultModelRegistryResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelPricing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.StandardParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PluginId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.SimplifiedPricing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelRegistryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelCapability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelRegistryResponseFiltersProvider>))]
    internal sealed partial class ModelRegistrySourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelRegistrySourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ModelRegistrySourceGenerationContext Default { get; } = new(DefaultOptions);

        private ModelRegistrySourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultModelRegistryResponseStringJsonConverter());
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
                    typeToConvert == typeof(global::Helicone.ModelProviderName)

                    || typeToConvert == typeof(global::Helicone.ModelProviderName?)

                    || typeToConvert == typeof(global::Helicone.AuthorName)

                    || typeToConvert == typeof(global::Helicone.AuthorName?)

                    || typeToConvert == typeof(global::Helicone.StandardParameter)

                    || typeToConvert == typeof(global::Helicone.StandardParameter?)

                    || typeToConvert == typeof(global::Helicone.PluginId)

                    || typeToConvert == typeof(global::Helicone.PluginId?)

                    || typeToConvert == typeof(global::Helicone.BodyMappingType)

                    || typeToConvert == typeof(global::Helicone.BodyMappingType?)

                    || typeToConvert == typeof(global::Helicone.ResponseFormat)

                    || typeToConvert == typeof(global::Helicone.ResponseFormat?)

                    || typeToConvert == typeof(global::Helicone.ModelProviderConfigQuantization)

                    || typeToConvert == typeof(global::Helicone.ModelProviderConfigQuantization?)

                    || typeToConvert == typeof(global::Helicone.InputModality)

                    || typeToConvert == typeof(global::Helicone.InputModality?)

                    || typeToConvert == typeof(global::Helicone.OutputModality)

                    || typeToConvert == typeof(global::Helicone.OutputModality?)

                    || typeToConvert == typeof(global::Helicone.ModelCapability)

                    || typeToConvert == typeof(global::Helicone.ModelCapability?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Helicone.ModelProviderName))
                {
                    return new global::Helicone.JsonConverters.ModelProviderNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelProviderName?))
                {
                    return new global::Helicone.JsonConverters.ModelProviderNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.AuthorName))
                {
                    return new global::Helicone.JsonConverters.AuthorNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.AuthorName?))
                {
                    return new global::Helicone.JsonConverters.AuthorNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.StandardParameter))
                {
                    return new global::Helicone.JsonConverters.StandardParameterJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.StandardParameter?))
                {
                    return new global::Helicone.JsonConverters.StandardParameterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PluginId))
                {
                    return new global::Helicone.JsonConverters.PluginIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PluginId?))
                {
                    return new global::Helicone.JsonConverters.PluginIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.BodyMappingType))
                {
                    return new global::Helicone.JsonConverters.BodyMappingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.BodyMappingType?))
                {
                    return new global::Helicone.JsonConverters.BodyMappingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ResponseFormat))
                {
                    return new global::Helicone.JsonConverters.ResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ResponseFormat?))
                {
                    return new global::Helicone.JsonConverters.ResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelProviderConfigQuantization))
                {
                    return new global::Helicone.JsonConverters.ModelProviderConfigQuantizationJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelProviderConfigQuantization?))
                {
                    return new global::Helicone.JsonConverters.ModelProviderConfigQuantizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.InputModality))
                {
                    return new global::Helicone.JsonConverters.InputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.InputModality?))
                {
                    return new global::Helicone.JsonConverters.InputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OutputModality))
                {
                    return new global::Helicone.JsonConverters.OutputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.OutputModality?))
                {
                    return new global::Helicone.JsonConverters.OutputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelCapability))
                {
                    return new global::Helicone.JsonConverters.ModelCapabilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.ModelCapability?))
                {
                    return new global::Helicone.JsonConverters.ModelCapabilityNullableJsonConverter();
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
                    0 => new ModelRegistrySourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}