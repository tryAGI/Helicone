#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenAIChatRequestMessageToolCallTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.OpenAIChatRequestMessageToolCallType?>
    {
        /// <inheritdoc />
        public override global::Helicone.OpenAIChatRequestMessageToolCallType? Read(
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
                        return global::Helicone.OpenAIChatRequestMessageToolCallTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.OpenAIChatRequestMessageToolCallType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.OpenAIChatRequestMessageToolCallType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.OpenAIChatRequestMessageToolCallType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Helicone.OpenAIChatRequestMessageToolCallTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
