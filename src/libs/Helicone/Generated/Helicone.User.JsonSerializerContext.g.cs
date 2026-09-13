
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTextOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialNumberOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialBooleanOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialTimestampOperatorsTyped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestResponseRMTToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialRequestResponseRMTToOperatorsPropertyKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SortDirection), TypeInfoPropertyName = "SortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.HistogramRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessRequestCountHistogramRowArrayUserCostHistogramRowArrayData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.HistogramRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString), TypeInfoPropertyName = "ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PartialUserViewToOperators))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterNode), TypeInfoPropertyName = "UserFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterNodeEnum), TypeInfoPropertyName = "UserFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterBranchOperator), TypeInfoPropertyName = "UserFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PSize), TypeInfoPropertyName = "PSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserMetricsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.UserMetricsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString), TypeInfoPropertyName = "ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SortLeafUsers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserMetricsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserMetricsQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString), TypeInfoPropertyName = "ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserQueryParamsTimeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetUserMetricsOverviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SortDirection?), TypeInfoPropertyName = "NullableSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString?), TypeInfoPropertyName = "NullableResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterNode?), TypeInfoPropertyName = "NullableUserFilterNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterNodeEnum?), TypeInfoPropertyName = "NullableUserFilterNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UserFilterBranchOperator?), TypeInfoPropertyName = "NullableUserFilterBranchOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PSize?), TypeInfoPropertyName = "NullablePSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString?), TypeInfoPropertyName = "NullableResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString?), TypeInfoPropertyName = "NullableResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.HistogramRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.UserMetricsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem>))]
    internal sealed partial class UserSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UserSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UserSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.UserFilterNodeJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayStringJsonConverter());
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
                    typeToConvert == typeof(global::Helicone.SortDirection)

                    || typeToConvert == typeof(global::Helicone.SortDirection?)

                    || typeToConvert == typeof(global::Helicone.UserFilterNodeEnum)

                    || typeToConvert == typeof(global::Helicone.UserFilterNodeEnum?)

                    || typeToConvert == typeof(global::Helicone.UserFilterBranchOperator)

                    || typeToConvert == typeof(global::Helicone.UserFilterBranchOperator?)

                    || typeToConvert == typeof(global::Helicone.PSize)

                    || typeToConvert == typeof(global::Helicone.PSize?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Helicone.SortDirection))
                {
                    return new global::Helicone.JsonConverters.SortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.SortDirection?))
                {
                    return new global::Helicone.JsonConverters.SortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UserFilterNodeEnum))
                {
                    return new global::Helicone.JsonConverters.UserFilterNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UserFilterNodeEnum?))
                {
                    return new global::Helicone.JsonConverters.UserFilterNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UserFilterBranchOperator))
                {
                    return new global::Helicone.JsonConverters.UserFilterBranchOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.UserFilterBranchOperator?))
                {
                    return new global::Helicone.JsonConverters.UserFilterBranchOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PSize))
                {
                    return new global::Helicone.JsonConverters.PSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.PSize?))
                {
                    return new global::Helicone.JsonConverters.PSizeNullableJsonConverter();
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
                    0 => new UserSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}