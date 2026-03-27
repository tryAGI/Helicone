
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSubscriptionResponseItemPrice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public global::Helicone.GetSubscriptionResponseItemPriceProduct? Product { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponseItemPrice" /> class.
        /// </summary>
        /// <param name="product"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSubscriptionResponseItemPrice(
            global::Helicone.GetSubscriptionResponseItemPriceProduct? product)
        {
            this.Product = product;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponseItemPrice" /> class.
        /// </summary>
        public GetSubscriptionResponseItemPrice()
        {
        }
    }
}