
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Provider key as returned to API callers. The secret values are masked and<br/>
    /// can never be used to call the provider (INC-710).
    /// </summary>
    public sealed partial class MaskedProviderKey
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderKeyName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cuid")]
        public string? Cuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_key_masked")]
        public string? ProviderKeyMasked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_secret_key_masked")]
        public string? ProviderSecretKeyMasked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskedProviderKey" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orgId"></param>
        /// <param name="providerName"></param>
        /// <param name="providerKeyName"></param>
        /// <param name="cuid"></param>
        /// <param name="providerKeyMasked"></param>
        /// <param name="providerSecretKeyMasked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MaskedProviderKey(
            string id,
            string orgId,
            string providerName,
            string providerKeyName,
            string? cuid,
            string? providerKeyMasked,
            string? providerSecretKeyMasked)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.ProviderKeyName = providerKeyName ?? throw new global::System.ArgumentNullException(nameof(providerKeyName));
            this.Cuid = cuid;
            this.ProviderKeyMasked = providerKeyMasked;
            this.ProviderSecretKeyMasked = providerSecretKeyMasked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskedProviderKey" /> class.
        /// </summary>
        public MaskedProviderKey()
        {
        }

    }
}