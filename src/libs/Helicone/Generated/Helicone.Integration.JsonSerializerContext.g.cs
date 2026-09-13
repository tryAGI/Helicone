
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringString), TypeInfoPropertyName = "ResultIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Json), TypeInfoPropertyName = "Json2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.Json?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Json?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.IntegrationCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Integration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArrayIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.Integration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayIntegrationString), TypeInfoPropertyName = "ResultArrayIntegrationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.IntegrationUpdateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIntegrationString), TypeInfoPropertyName = "ResultIntegrationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArrayIdStringNameString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessArrayIdStringNameStringDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessArrayIdStringNameStringDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayIdStringNameStringString), TypeInfoPropertyName = "ResultArrayIdStringNameStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringString), TypeInfoPropertyName = "ResultStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TestStripeMeterEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultNullString?), TypeInfoPropertyName = "NullableResultNullString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringString?), TypeInfoPropertyName = "NullableResultIdStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.Json?), TypeInfoPropertyName = "NullableJson2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayIntegrationString?), TypeInfoPropertyName = "NullableResultArrayIntegrationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIntegrationString?), TypeInfoPropertyName = "NullableResultIntegrationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultArrayIdStringNameStringString?), TypeInfoPropertyName = "NullableResultArrayIdStringNameStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultStringString?), TypeInfoPropertyName = "NullableResultStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Json?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.Integration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessArrayIdStringNameStringDataItem>))]
    internal sealed partial class IntegrationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IntegrationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static IntegrationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private IntegrationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.JsonJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultArrayIntegrationStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultIntegrationStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultArrayIdStringNameStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultStringStringJsonConverter());
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
                    0 => new IntegrationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}