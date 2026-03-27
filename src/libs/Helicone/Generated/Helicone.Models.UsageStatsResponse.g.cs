
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageStatsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPeriod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.UsageStatsResponseBillingPeriod BillingPeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.UsageStatsResponseUsage Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Helicone.DailyUsageDataPoint> DailyData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Helicone.UsageStatsResponseEstimatedCost EstimatedCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponse" /> class.
        /// </summary>
        /// <param name="billingPeriod"></param>
        /// <param name="usage"></param>
        /// <param name="dailyData"></param>
        /// <param name="estimatedCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageStatsResponse(
            global::Helicone.UsageStatsResponseBillingPeriod billingPeriod,
            global::Helicone.UsageStatsResponseUsage usage,
            global::System.Collections.Generic.IList<global::Helicone.DailyUsageDataPoint> dailyData,
            global::Helicone.UsageStatsResponseEstimatedCost estimatedCost)
        {
            this.BillingPeriod = billingPeriod ?? throw new global::System.ArgumentNullException(nameof(billingPeriod));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.DailyData = dailyData ?? throw new global::System.ArgumentNullException(nameof(dailyData));
            this.EstimatedCost = estimatedCost ?? throw new global::System.ArgumentNullException(nameof(estimatedCost));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponse" /> class.
        /// </summary>
        public UsageStatsResponse()
        {
        }
    }
}