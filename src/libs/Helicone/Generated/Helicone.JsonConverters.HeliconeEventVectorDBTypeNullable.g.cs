#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class HeliconeEventVectorDBTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.HeliconeEventVectorDBType?>
    {
        /// <inheritdoc />
        public override global::Helicone.HeliconeEventVectorDBType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Helicone.HeliconeEventVectorDBTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.HeliconeEventVectorDBType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.HeliconeEventVectorDBType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.HeliconeEventVectorDBType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Helicone.HeliconeEventVectorDBTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
