
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialRequestTableToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::Helicone.PartialTextOperators? Prompt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::Helicone.PartialTimestampOperators? CreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::Helicone.PartialTextOperators? UserId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_hash")]
        public global::Helicone.PartialTextOperators? AuthHash { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public global::Helicone.PartialTextOperators? OrgId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::Helicone.PartialTextOperators? Id { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public global::Helicone.PartialTextOperators? NodeId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Helicone.PartialTextOperators? Model { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelOverride")]
        public global::Helicone.PartialTextOperators? ModelOverride { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public global::Helicone.PartialTextOperators? Path { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public global::Helicone.PartialTextOperators? CountryCode { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public global::Helicone.PartialTextOperators? PromptId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestTableToOperators" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="createdAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="authHash">
        /// Make all properties in T optional
        /// </param>
        /// <param name="orgId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="id">
        /// Make all properties in T optional
        /// </param>
        /// <param name="nodeId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="model">
        /// Make all properties in T optional
        /// </param>
        /// <param name="modelOverride">
        /// Make all properties in T optional
        /// </param>
        /// <param name="path">
        /// Make all properties in T optional
        /// </param>
        /// <param name="countryCode">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptId">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRequestTableToOperators(
            global::Helicone.PartialTextOperators? prompt,
            global::Helicone.PartialTimestampOperators? createdAt,
            global::Helicone.PartialTextOperators? userId,
            global::Helicone.PartialTextOperators? authHash,
            global::Helicone.PartialTextOperators? orgId,
            global::Helicone.PartialTextOperators? id,
            global::Helicone.PartialTextOperators? nodeId,
            global::Helicone.PartialTextOperators? model,
            global::Helicone.PartialTextOperators? modelOverride,
            global::Helicone.PartialTextOperators? path,
            global::Helicone.PartialTextOperators? countryCode,
            global::Helicone.PartialTextOperators? promptId)
        {
            this.Prompt = prompt;
            this.CreatedAt = createdAt;
            this.UserId = userId;
            this.AuthHash = authHash;
            this.OrgId = orgId;
            this.Id = id;
            this.NodeId = nodeId;
            this.Model = model;
            this.ModelOverride = modelOverride;
            this.Path = path;
            this.CountryCode = countryCode;
            this.PromptId = promptId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestTableToOperators" /> class.
        /// </summary>
        public PartialRequestTableToOperators()
        {
        }
    }
}