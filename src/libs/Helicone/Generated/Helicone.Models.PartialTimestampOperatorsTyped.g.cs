
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialTimestampOperatorsTyped
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gte")]
        public global::System.DateTime? Gte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lte")]
        public global::System.DateTime? Lte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lt")]
        public global::System.DateTime? Lt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gt")]
        public global::System.DateTime? Gt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eq")]
        public global::System.DateTime? Eq { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTimestampOperatorsTyped" /> class.
        /// </summary>
        /// <param name="gte"></param>
        /// <param name="lte"></param>
        /// <param name="lt"></param>
        /// <param name="gt"></param>
        /// <param name="eq"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialTimestampOperatorsTyped(
            global::System.DateTime? gte,
            global::System.DateTime? lte,
            global::System.DateTime? lt,
            global::System.DateTime? gt,
            global::System.DateTime? eq)
        {
            this.Gte = gte;
            this.Lte = lte;
            this.Lt = lt;
            this.Gt = gt;
            this.Eq = eq;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTimestampOperatorsTyped" /> class.
        /// </summary>
        public PartialTimestampOperatorsTyped()
        {
        }
    }
}