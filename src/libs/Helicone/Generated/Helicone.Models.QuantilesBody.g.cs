
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuantilesBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.FilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.FilterNode Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeFilter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.QuantilesBodyTimeFilter TimeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbIncrement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.TimeIncrementJsonConverter))]
        public global::Helicone.TimeIncrement? DbIncrement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeZoneDifference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimeZoneDifference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantilesBody" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="metric"></param>
        /// <param name="dbIncrement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantilesBody(
            global::Helicone.FilterNode filter,
            global::Helicone.QuantilesBodyTimeFilter timeFilter,
            double timeZoneDifference,
            string metric,
            global::Helicone.TimeIncrement? dbIncrement)
        {
            this.Filter = filter;
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
            this.DbIncrement = dbIncrement;
            this.TimeZoneDifference = timeZoneDifference;
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantilesBody" /> class.
        /// </summary>
        public QuantilesBody()
        {
        }
    }
}