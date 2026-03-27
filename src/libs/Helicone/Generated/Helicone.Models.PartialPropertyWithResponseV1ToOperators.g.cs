
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialPropertyWithResponseV1ToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_key")]
        public global::Helicone.PartialTextOperators? PropertyKey { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_value")]
        public global::Helicone.PartialTextOperators? PropertyValue { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_created_at")]
        public global::Helicone.PartialTimestampOperatorsTyped? RequestCreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public global::Helicone.PartialTextOperators? OrganizationId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threat")]
        public global::Helicone.PartialBooleanOperators? Threat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPropertyWithResponseV1ToOperators" /> class.
        /// </summary>
        /// <param name="propertyKey">
        /// Make all properties in T optional
        /// </param>
        /// <param name="propertyValue">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestCreatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="organizationId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="threat">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialPropertyWithResponseV1ToOperators(
            global::Helicone.PartialTextOperators? propertyKey,
            global::Helicone.PartialTextOperators? propertyValue,
            global::Helicone.PartialTimestampOperatorsTyped? requestCreatedAt,
            global::Helicone.PartialTextOperators? organizationId,
            global::Helicone.PartialBooleanOperators? threat)
        {
            this.PropertyKey = propertyKey;
            this.PropertyValue = propertyValue;
            this.RequestCreatedAt = requestCreatedAt;
            this.OrganizationId = organizationId;
            this.Threat = threat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPropertyWithResponseV1ToOperators" /> class.
        /// </summary>
        public PartialPropertyWithResponseV1ToOperators()
        {
        }
    }
}