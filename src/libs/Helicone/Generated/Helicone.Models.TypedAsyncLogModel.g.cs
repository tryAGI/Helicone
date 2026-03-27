
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TypedAsyncLogModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerRequest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.TypedProviderRequest ProviderRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerResponse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.TypedProviderResponse ProviderResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timing")]
        public global::Helicone.TypedTiming? Timing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.ProviderJsonConverter))]
        public global::Helicone.Provider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedAsyncLogModel" /> class.
        /// </summary>
        /// <param name="providerRequest"></param>
        /// <param name="providerResponse"></param>
        /// <param name="timing"></param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypedAsyncLogModel(
            global::Helicone.TypedProviderRequest providerRequest,
            global::Helicone.TypedProviderResponse providerResponse,
            global::Helicone.TypedTiming? timing,
            global::Helicone.Provider? provider)
        {
            this.ProviderRequest = providerRequest ?? throw new global::System.ArgumentNullException(nameof(providerRequest));
            this.ProviderResponse = providerResponse ?? throw new global::System.ArgumentNullException(nameof(providerResponse));
            this.Timing = timing;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedAsyncLogModel" /> class.
        /// </summary>
        public TypedAsyncLogModel()
        {
        }
    }
}