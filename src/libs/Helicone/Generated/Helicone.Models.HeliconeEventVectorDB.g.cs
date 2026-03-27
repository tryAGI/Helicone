
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeliconeEventVectorDB
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.HeliconeEventVectorDBTypeJsonConverter))]
        public global::Helicone.HeliconeEventVectorDBType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.HeliconeEventVectorDBOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.HeliconeEventVectorDBOperation Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        public global::System.Collections.Generic.IList<double>? Vector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public double? TopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Helicone.HeliconeEventVectorDBFilter? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("databaseName")]
        public string? DatabaseName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeEventVectorDB" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="operation"></param>
        /// <param name="text"></param>
        /// <param name="vector"></param>
        /// <param name="topK"></param>
        /// <param name="filter"></param>
        /// <param name="databaseName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeliconeEventVectorDB(
            global::Helicone.HeliconeEventVectorDBOperation operation,
            global::Helicone.HeliconeEventVectorDBType type,
            string? text,
            global::System.Collections.Generic.IList<double>? vector,
            double? topK,
            global::Helicone.HeliconeEventVectorDBFilter? filter,
            string? databaseName)
        {
            this.Operation = operation;
            this.Type = type;
            this.Text = text;
            this.Vector = vector;
            this.TopK = topK;
            this.Filter = filter;
            this.DatabaseName = databaseName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeEventVectorDB" /> class.
        /// </summary>
        public HeliconeEventVectorDB()
        {
        }
    }
}