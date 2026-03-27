
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestLastMileEvaluatorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testInput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.TestInput TestInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.LastMileConfigFormJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.LastMileConfigForm Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLastMileEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="testInput"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestLastMileEvaluatorRequest(
            global::Helicone.TestInput testInput,
            global::Helicone.LastMileConfigForm config)
        {
            this.TestInput = testInput ?? throw new global::System.ArgumentNullException(nameof(testInput));
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLastMileEvaluatorRequest" /> class.
        /// </summary>
        public TestLastMileEvaluatorRequest()
        {
        }
    }
}