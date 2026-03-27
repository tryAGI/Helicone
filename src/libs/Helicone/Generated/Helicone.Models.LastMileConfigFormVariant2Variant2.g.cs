
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LastMileConfigFormVariant2Variant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groundTruth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.DataEntryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.DataEntry GroundTruth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.LastMileConfigFormVariant2Variant2TypeJsonConverter))]
        public global::Helicone.LastMileConfigFormVariant2Variant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LastMileConfigFormVariant2Variant2" /> class.
        /// </summary>
        /// <param name="groundTruth"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LastMileConfigFormVariant2Variant2(
            global::Helicone.DataEntry groundTruth,
            global::Helicone.LastMileConfigFormVariant2Variant2Type type)
        {
            this.GroundTruth = groundTruth;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LastMileConfigFormVariant2Variant2" /> class.
        /// </summary>
        public LastMileConfigFormVariant2Variant2()
        {
        }
    }
}