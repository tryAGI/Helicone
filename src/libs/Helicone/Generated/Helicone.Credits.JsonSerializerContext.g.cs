
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreditBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessCreditBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCreditBalanceResponseString), TypeInfoPropertyName = "ResultCreditBalanceResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PurchasedCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PaginatedPurchasedCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PurchasedCredits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPaginatedPurchasedCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPaginatedPurchasedCreditsString), TypeInfoPropertyName = "ResultPaginatedPurchasedCreditsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTotalSpendNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessTotalSpendNumberData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTotalSpendNumberString), TypeInfoPropertyName = "ResultTotalSpendNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelSpend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ModelSpendPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SpendBreakdownResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ModelSpend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.SpendBreakdownResponseTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessSpendBreakdownResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSpendBreakdownResponseString), TypeInfoPropertyName = "ResultSpendBreakdownResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.PTBInvoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessPTBInvoiceArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.PTBInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPTBInvoiceArrayString), TypeInfoPropertyName = "ResultPTBInvoiceArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.OrgDiscount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessOrgDiscountArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.OrgDiscount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOrgDiscountArrayString), TypeInfoPropertyName = "ResultOrgDiscountArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetSpendBreakdownTimeRange), TypeInfoPropertyName = "GetSpendBreakdownTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultCreditBalanceResponseString?), TypeInfoPropertyName = "NullableResultCreditBalanceResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPaginatedPurchasedCreditsString?), TypeInfoPropertyName = "NullableResultPaginatedPurchasedCreditsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultTotalSpendNumberString?), TypeInfoPropertyName = "NullableResultTotalSpendNumberString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSpendBreakdownResponseString?), TypeInfoPropertyName = "NullableResultSpendBreakdownResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultPTBInvoiceArrayString?), TypeInfoPropertyName = "NullableResultPTBInvoiceArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultOrgDiscountArrayString?), TypeInfoPropertyName = "NullableResultOrgDiscountArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetSpendBreakdownTimeRange?), TypeInfoPropertyName = "NullableGetSpendBreakdownTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PurchasedCredits>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ModelSpend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.PTBInvoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.OrgDiscount>))]
    internal sealed partial class CreditsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreditsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CreditsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CreditsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultCreditBalanceResponseStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPaginatedPurchasedCreditsStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultTotalSpendNumberStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultSpendBreakdownResponseStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultPTBInvoiceArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultOrgDiscountArrayStringJsonConverter());
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
                    typeToConvert == typeof(global::Helicone.GetSpendBreakdownTimeRange)

                    || typeToConvert == typeof(global::Helicone.GetSpendBreakdownTimeRange?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Helicone.GetSpendBreakdownTimeRange))
                {
                    return new global::Helicone.JsonConverters.GetSpendBreakdownTimeRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.GetSpendBreakdownTimeRange?))
                {
                    return new global::Helicone.JsonConverters.GetSpendBreakdownTimeRangeNullableJsonConverter();
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
                    0 => new CreditsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}