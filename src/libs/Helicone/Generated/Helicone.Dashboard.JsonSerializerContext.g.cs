
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTextOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialNumberOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialBooleanOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTimestampOperatorsTyped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestResponseRMTToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestResponseRMTToOperatorsPropertyKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafRequestResponseRmt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterNode), TypeInfoPropertyName = "RequestClickhouseFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterNodeEnum), TypeInfoPropertyName = "RequestClickhouseFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterBranchOperator), TypeInfoPropertyName = "RequestClickhouseFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeIncrement), TypeInfoPropertyName = "TimeIncrement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataOverTimeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DataOverTimeRequestTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString), TypeInfoPropertyName = "ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterNode?), TypeInfoPropertyName = "NullableRequestClickhouseFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterNodeEnum?), TypeInfoPropertyName = "NullableRequestClickhouseFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RequestClickhouseFilterBranchOperator?), TypeInfoPropertyName = "NullableRequestClickhouseFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.TimeIncrement?), TypeInfoPropertyName = "NullableTimeIncrement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString?), TypeInfoPropertyName = "NullableResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayDataItem>))]
    internal sealed partial class DashboardSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DashboardSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DashboardSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DashboardSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.RequestClickhouseFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayStringJsonConverter());
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
                    typeToConvert == typeof(global::Helicone.RequestClickhouseFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.RequestClickhouseFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.RequestClickhouseFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.RequestClickhouseFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.TimeIncrement)

                    || typeToConvert == typeof(global::Helicone.TimeIncrement?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Helicone.RequestClickhouseFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.RequestClickhouseFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestClickhouseFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.RequestClickhouseFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestClickhouseFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.RequestClickhouseFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.RequestClickhouseFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.RequestClickhouseFilterBranchOperatorNullableJsonConverter();
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
                    0 => new DashboardSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}