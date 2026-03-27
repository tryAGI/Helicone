
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public global::Helicone.Endpoint? Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsPtb")]
        public bool? SupportsPtb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.SimplifiedPricing Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingTiers")]
        public global::System.Collections.Generic.IList<global::Helicone.SimplifiedPricing>? PricingTiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEndpoint" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="providerSlug"></param>
        /// <param name="endpoint"></param>
        /// <param name="supportsPtb"></param>
        /// <param name="pricing"></param>
        /// <param name="pricingTiers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelEndpoint(
            string provider,
            string providerSlug,
            global::Helicone.SimplifiedPricing pricing,
            global::Helicone.Endpoint? endpoint,
            bool? supportsPtb,
            global::System.Collections.Generic.IList<global::Helicone.SimplifiedPricing>? pricingTiers)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ProviderSlug = providerSlug ?? throw new global::System.ArgumentNullException(nameof(providerSlug));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.Endpoint = endpoint;
            this.SupportsPtb = supportsPtb;
            this.PricingTiers = pricingTiers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEndpoint" /> class.
        /// </summary>
        public ModelEndpoint()
        {
        }
    }
}