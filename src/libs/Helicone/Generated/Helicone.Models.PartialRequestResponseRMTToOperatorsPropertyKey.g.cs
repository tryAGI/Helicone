
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartialRequestResponseRMTToOperatorsPropertyKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public new required string Equals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestResponseRMTToOperatorsPropertyKey" /> class.
        /// </summary>
        /// <param name="equals"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRequestResponseRMTToOperatorsPropertyKey(
            string equals)
        {
            this.Equals = equals ?? throw new global::System.ArgumentNullException(nameof(equals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestResponseRMTToOperatorsPropertyKey" /> class.
        /// </summary>
        public PartialRequestResponseRMTToOperatorsPropertyKey()
        {
        }
    }
}