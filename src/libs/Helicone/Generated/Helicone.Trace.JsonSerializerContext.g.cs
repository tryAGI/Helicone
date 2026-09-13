
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderName), TypeInfoPropertyName = "ProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderName), TypeInfoPropertyName = "ModelProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Provider), TypeInfoPropertyName = "Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderEnum), TypeInfoPropertyName = "ProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ValidationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RecordStringUnknown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TypedProviderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TypedProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TypedTiming))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TypedAsyncLogModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpanSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpanSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpanSpanStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttributeValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanScopeSpanScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanResourceAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanResourceAttribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanResourceAttributeValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ValidationResult, object>), TypeInfoPropertyName = "AnyOfValidationResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderName?), TypeInfoPropertyName = "NullableProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelProviderName?), TypeInfoPropertyName = "NullableModelProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Provider?), TypeInfoPropertyName = "NullableProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderEnum?), TypeInfoPropertyName = "NullableProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.ValidationResult, object>?), TypeInfoPropertyName = "NullableAnyOfValidationResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanScopeSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanScopeSpanSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanScopeSpanSpanAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanResourceAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OTELTraceResourceSpanResourceAttributeValueArrayValueValue>))]
    internal sealed partial class TraceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TraceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TraceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TraceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ProviderJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.ValidationResult, object>());
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
                    typeToConvert == typeof(global::Helicone.ProviderName)

                    || typeToConvert == typeof(global::Helicone.ProviderName?)

                    || typeToConvert == typeof(global::Helicone.ModelProviderName)

                    || typeToConvert == typeof(global::Helicone.ModelProviderName?)

                    || typeToConvert == typeof(global::Helicone.ProviderEnum)

                    || typeToConvert == typeof(global::Helicone.ProviderEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new TraceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}