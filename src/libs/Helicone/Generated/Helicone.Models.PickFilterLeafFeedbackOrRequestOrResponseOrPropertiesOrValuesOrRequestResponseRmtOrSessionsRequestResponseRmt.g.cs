
#nullable enable

namespace Helicone
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? Values { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::Helicone.PartialFeedbackTableToOperators? Feedback { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::Helicone.PartialRequestTableToOperators? Request { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::Helicone.PartialResponseTableToOperators? Response { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? Properties { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_response_rmt")]
        public global::Helicone.PartialRequestResponseRMTToOperators? RequestResponseRmt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions_request_response_rmt")]
        public global::Helicone.PartialSessionsRequestResponseRMTToOperators? SessionsRequestResponseRmt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="feedback">
        /// Make all properties in T optional
        /// </param>
        /// <param name="request">
        /// Make all properties in T optional
        /// </param>
        /// <param name="response">
        /// Make all properties in T optional
        /// </param>
        /// <param name="properties"></param>
        /// <param name="requestResponseRmt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionsRequestResponseRmt">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt(
            global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? values,
            global::Helicone.PartialFeedbackTableToOperators? feedback,
            global::Helicone.PartialRequestTableToOperators? request,
            global::Helicone.PartialResponseTableToOperators? response,
            global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? properties,
            global::Helicone.PartialRequestResponseRMTToOperators? requestResponseRmt,
            global::Helicone.PartialSessionsRequestResponseRMTToOperators? sessionsRequestResponseRmt)
        {
            this.Values = values;
            this.Feedback = feedback;
            this.Request = request;
            this.Response = response;
            this.Properties = properties;
            this.RequestResponseRmt = requestResponseRmt;
            this.SessionsRequestResponseRmt = sessionsRequestResponseRmt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt" /> class.
        /// </summary>
        public PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt()
        {
        }

    }
}