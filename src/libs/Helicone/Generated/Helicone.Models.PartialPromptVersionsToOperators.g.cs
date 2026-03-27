
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialPromptVersionsToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minor_version")]
        public global::Helicone.PartialNumberOperators? MinorVersion { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_version")]
        public global::Helicone.PartialNumberOperators? MajorVersion { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::Helicone.PartialTextOperators? Id { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_v2")]
        public global::Helicone.PartialTextOperators? PromptV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPromptVersionsToOperators" /> class.
        /// </summary>
        /// <param name="minorVersion">
        /// Make all properties in T optional
        /// </param>
        /// <param name="majorVersion">
        /// Make all properties in T optional
        /// </param>
        /// <param name="id">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptV2">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialPromptVersionsToOperators(
            global::Helicone.PartialNumberOperators? minorVersion,
            global::Helicone.PartialNumberOperators? majorVersion,
            global::Helicone.PartialTextOperators? id,
            global::Helicone.PartialTextOperators? promptV2)
        {
            this.MinorVersion = minorVersion;
            this.MajorVersion = majorVersion;
            this.Id = id;
            this.PromptV2 = promptV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPromptVersionsToOperators" /> class.
        /// </summary>
        public PartialPromptVersionsToOperators()
        {
        }
    }
}