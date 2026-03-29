
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2025VersionPromptBodyMessageToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallTypeJsonConverter))]
        public global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.Prompt2025VersionPromptBodyMessageToolCallFunction Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyMessageToolCall" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prompt2025VersionPromptBodyMessageToolCall(
            global::Helicone.Prompt2025VersionPromptBodyMessageToolCallFunction function,
            string id,
            global::Helicone.Prompt2025VersionPromptBodyMessageToolCallType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyMessageToolCall" /> class.
        /// </summary>
        public Prompt2025VersionPromptBodyMessageToolCall()
        {
        }
    }
}