
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExperimentsOldRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::Helicone.IncludeExperimentKeys? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.ExperimentFilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.ExperimentFilterNode Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExperimentsOldRequest" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="include"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetExperimentsOldRequest(
            global::Helicone.ExperimentFilterNode filter,
            global::Helicone.IncludeExperimentKeys? include)
        {
            this.Include = include;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExperimentsOldRequest" /> class.
        /// </summary>
        public GetExperimentsOldRequest()
        {
        }
    }
}