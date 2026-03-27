
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseLastMileConfigForm
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.DataEntryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.DataEntry Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.DataEntryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.DataEntry Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseLastMileConfigForm" /> class.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseLastMileConfigForm(
            global::Helicone.DataEntry output,
            global::Helicone.DataEntry input,
            string name)
        {
            this.Output = output;
            this.Input = input;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseLastMileConfigForm" /> class.
        /// </summary>
        public BaseLastMileConfigForm()
        {
        }
    }
}