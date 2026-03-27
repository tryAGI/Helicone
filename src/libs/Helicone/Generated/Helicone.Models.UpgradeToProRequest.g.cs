
#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpgradeToProRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addons")]
        public global::Helicone.UpgradeToProRequestAddons? Addons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seats")]
        public double? Seats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Helicone.JsonConverters.UpgradeToProRequestUiModeJsonConverter))]
        public global::Helicone.UpgradeToProRequestUiMode? UiMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeToProRequest" /> class.
        /// </summary>
        /// <param name="addons"></param>
        /// <param name="seats"></param>
        /// <param name="uiMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpgradeToProRequest(
            global::Helicone.UpgradeToProRequestAddons? addons,
            double? seats,
            global::Helicone.UpgradeToProRequestUiMode? uiMode)
        {
            this.Addons = addons;
            this.Seats = seats;
            this.UiMode = uiMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeToProRequest" /> class.
        /// </summary>
        public UpgradeToProRequest()
        {
        }
    }
}