
#nullable enable

namespace Helicone
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialJobToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::Helicone.PartialTextOperators? Id { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::Helicone.PartialTextOperators? Name { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::Helicone.PartialTextOperators? Description { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Helicone.PartialTextOperators? Status { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::Helicone.PartialTimestampOperators? CreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::Helicone.PartialTimestampOperators? UpdatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public global::Helicone.PartialNumberOperators? TimeoutSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_properties")]
        public global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? CustomProperties { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public global::Helicone.PartialTextOperators? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialJobToOperators" /> class.
        /// </summary>
        /// <param name="id">
        /// Make all properties in T optional
        /// </param>
        /// <param name="name">
        /// Make all properties in T optional
        /// </param>
        /// <param name="description">
        /// Make all properties in T optional
        /// </param>
        /// <param name="status">
        /// Make all properties in T optional
        /// </param>
        /// <param name="createdAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="updatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="timeoutSeconds">
        /// Make all properties in T optional
        /// </param>
        /// <param name="customProperties"></param>
        /// <param name="orgId">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialJobToOperators(
            global::Helicone.PartialTextOperators? id,
            global::Helicone.PartialTextOperators? name,
            global::Helicone.PartialTextOperators? description,
            global::Helicone.PartialTextOperators? status,
            global::Helicone.PartialTimestampOperators? createdAt,
            global::Helicone.PartialTimestampOperators? updatedAt,
            global::Helicone.PartialNumberOperators? timeoutSeconds,
            global::System.Collections.Generic.Dictionary<string, global::Helicone.PartialTextOperators>? customProperties,
            global::Helicone.PartialTextOperators? orgId)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TimeoutSeconds = timeoutSeconds;
            this.CustomProperties = customProperties;
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialJobToOperators" /> class.
        /// </summary>
        public PartialJobToOperators()
        {
        }
    }
}