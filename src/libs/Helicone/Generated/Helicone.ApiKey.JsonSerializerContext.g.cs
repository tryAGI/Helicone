
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArray), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_c61c916e4634eed4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem>), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_3dc749edd663c095")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_4cfba64094b5bdd5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayString), TypeInfoPropertyName = "ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrgan_cf349a6cf523295d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayString?), TypeInfoPropertyName = "ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrgan_ff3f6ffbba0c1639")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayDataItem>), TypeInfoPropertyName = "ResultSuccessApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStri_8e953b8e000805f0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProviderKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DecryptedProviderKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.RecordStringAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ProviderKeyRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringProviderNameString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultSuccessIdStringProviderNameStringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultErrorString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringProviderNameStringString), TypeInfoPropertyName = "ResultIdStringProviderNameStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateProviderKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions), TypeInfoPropertyName = "CreateAPIKeyRequestKeyPermissions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProxyKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateAPIKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfDeleteProviderKeyResponseVariant1DeleteProviderKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName), TypeInfoPropertyName = "DeleteProviderKeyResponseVariant1ProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>), TypeInfoPropertyName = "AnyOfDecryptedProviderKeyGetProviderKeyResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetProviderKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfCreateProviderKeyResponseVariant1CreateProviderKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProviderKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProviderKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>), TypeInfoPropertyName = "AnyOfIListProviderKeyRowGetProviderKeysResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.GetProviderKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfCreateAPIKeyResponseVariant1CreateAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfCreateProxyKeyResponseVariant1CreateProxyKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProxyKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateProxyKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfDeleteAPIKeyResponseVariant1DeleteAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteAPIKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteAPIKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>), TypeInfoPropertyName = "AnyOfUpdateAPIKeyResponseVariant1UpdateAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateAPIKeyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.UpdateAPIKeyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.ResultIdStringProviderNameStringString?), TypeInfoPropertyName = "NullableResultIdStringProviderNameStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions?), TypeInfoPropertyName = "NullableCreateAPIKeyRequestKeyPermissions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfDeleteProviderKeyResponseVariant1DeleteProviderKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName?), TypeInfoPropertyName = "NullableDeleteProviderKeyResponseVariant1ProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>?), TypeInfoPropertyName = "NullableAnyOfDecryptedProviderKeyGetProviderKeyResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateProviderKeyResponseVariant1CreateProviderKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>?), TypeInfoPropertyName = "NullableAnyOfIListProviderKeyRowGetProviderKeysResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateAPIKeyResponseVariant1CreateAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreateProxyKeyResponseVariant1CreateProxyKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfDeleteAPIKeyResponseVariant1DeleteAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfUpdateAPIKeyResponseVariant1UpdateAPIKeyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Helicone.AnyOf<global::System.Collections.Generic.List<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Helicone.ProviderKeyRow>))]
    internal sealed partial class ApiKeySourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiKeySourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ApiKeySourceGenerationContext Default { get; } = new(DefaultOptions);

        private ApiKeySourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Helicone.JsonConverters.ResultIdStringProviderNameStringStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.ResultApiKeyHashStringApiKeyNameStringCreatedAtStringGovernanceBooleanIdNumberKeyPermissionsStringOrganizationIdStringSoftDeleteBooleanTempKeyBooleanUpdatedAtStringUserIdStringArrayStringJsonConverter());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DeleteProviderKeyResponseVariant1, global::Helicone.DeleteProviderKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DecryptedProviderKey, global::Helicone.GetProviderKeyResponse2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateProviderKeyResponseVariant1, global::Helicone.CreateProviderKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Helicone.ProviderKeyRow>, global::Helicone.GetProviderKeysResponse2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateAPIKeyResponseVariant1, global::Helicone.CreateAPIKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.CreateProxyKeyResponseVariant1, global::Helicone.CreateProxyKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.DeleteAPIKeyResponseVariant1, global::Helicone.DeleteAPIKeyResponseVariant2>());
            options.Converters.Add(new global::Helicone.JsonConverters.AnyOfJsonConverter<global::Helicone.UpdateAPIKeyResponseVariant1, global::Helicone.UpdateAPIKeyResponseVariant2>());
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
                    typeToConvert == typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions)

                    || typeToConvert == typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions?)

                    || typeToConvert == typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName)

                    || typeToConvert == typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions))
                {
                    return new global::Helicone.JsonConverters.CreateAPIKeyRequestKeyPermissionsJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.CreateAPIKeyRequestKeyPermissions?))
                {
                    return new global::Helicone.JsonConverters.CreateAPIKeyRequestKeyPermissionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName))
                {
                    return new global::Helicone.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Helicone.DeleteProviderKeyResponseVariant1ProviderName?))
                {
                    return new global::Helicone.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameNullableJsonConverter();
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
                    0 => new ApiKeySourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}