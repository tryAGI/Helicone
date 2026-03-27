
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialPropertiesV3ToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Helicone.PartialTextOperators? Key { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Helicone.PartialTextOperators? Value { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public global::Helicone.PartialTextOperators? OrganizationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPropertiesV3ToOperators" /> class.
        /// </summary>
        /// <param name="key">
        /// Make all properties in T optional
        /// </param>
        /// <param name="value">
        /// Make all properties in T optional
        /// </param>
        /// <param name="organizationId">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialPropertiesV3ToOperators(
            global::Helicone.PartialTextOperators? key,
            global::Helicone.PartialTextOperators? value,
            global::Helicone.PartialTextOperators? organizationId)
        {
            this.Key = key;
            this.Value = value;
            this.OrganizationId = organizationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPropertiesV3ToOperators" /> class.
        /// </summary>
        public PartialPropertiesV3ToOperators()
        {
        }
    }
}