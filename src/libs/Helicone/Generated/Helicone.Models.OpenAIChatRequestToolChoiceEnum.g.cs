
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIChatRequestToolChoiceEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::Helicone.OpenAIChatRequestToolChoiceEnumFunction? Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestToolChoiceEnum" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIChatRequestToolChoiceEnum(
            string type,
            global::Helicone.OpenAIChatRequestToolChoiceEnumFunction? function)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestToolChoiceEnum" /> class.
        /// </summary>
        public OpenAIChatRequestToolChoiceEnum()
        {
        }
    }
}