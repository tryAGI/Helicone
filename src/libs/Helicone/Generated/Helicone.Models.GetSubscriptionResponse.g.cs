
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSubscriptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Helicone.GetSubscriptionResponseItem> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_end")]
        public double? TrialEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_period_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentPeriodStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_period_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentPeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_at_period_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="trialEnd"></param>
        /// <param name="id"></param>
        /// <param name="currentPeriodStart"></param>
        /// <param name="currentPeriodEnd"></param>
        /// <param name="cancelAtPeriodEnd"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSubscriptionResponse(
            global::System.Collections.Generic.IList<global::Helicone.GetSubscriptionResponseItem> items,
            string id,
            double currentPeriodStart,
            double currentPeriodEnd,
            bool cancelAtPeriodEnd,
            string status,
            double? trialEnd)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CurrentPeriodStart = currentPeriodStart;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.TrialEnd = trialEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponse" /> class.
        /// </summary>
        public GetSubscriptionResponse()
        {
        }
    }
}