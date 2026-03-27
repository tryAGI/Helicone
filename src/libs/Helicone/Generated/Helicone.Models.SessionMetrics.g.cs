
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Helicone.HistogramRow> SessionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Helicone.HistogramRow> SessionDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Helicone.HistogramRow> SessionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.SessionMetricsAverage Average { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetrics" /> class.
        /// </summary>
        /// <param name="sessionCount"></param>
        /// <param name="sessionDuration"></param>
        /// <param name="sessionCost"></param>
        /// <param name="average"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionMetrics(
            global::System.Collections.Generic.IList<global::Helicone.HistogramRow> sessionCount,
            global::System.Collections.Generic.IList<global::Helicone.HistogramRow> sessionDuration,
            global::System.Collections.Generic.IList<global::Helicone.HistogramRow> sessionCost,
            global::Helicone.SessionMetricsAverage average)
        {
            this.SessionCount = sessionCount ?? throw new global::System.ArgumentNullException(nameof(sessionCount));
            this.SessionDuration = sessionDuration ?? throw new global::System.ArgumentNullException(nameof(sessionDuration));
            this.SessionCost = sessionCost ?? throw new global::System.ArgumentNullException(nameof(sessionCost));
            this.Average = average ?? throw new global::System.ArgumentNullException(nameof(average));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetrics" /> class.
        /// </summary>
        public SessionMetrics()
        {
        }
    }
}