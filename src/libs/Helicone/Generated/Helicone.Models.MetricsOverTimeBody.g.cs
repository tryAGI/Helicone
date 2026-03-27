
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricsOverTimeBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeFilter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.MetricsOverTimeBodyTimeFilter TimeFilter { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsOverTimeBody" /> class.
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="filter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricsOverTimeBody(
            global::Helicone.MetricsOverTimeBodyTimeFilter timeFilter,
            global::Helicone.FilterNode filter,
            double timeZoneDifference,
            global::Helicone.TimeIncrement? dbIncrement)
        {
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
            this.Filter = filter;
            this.TimeZoneDifference = timeZoneDifference;
            this.DbIncrement = dbIncrement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsOverTimeBody" /> class.
        /// </summary>
        public MetricsOverTimeBody()
        {
        }
    }
}