#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenAIChatRequestVerbosityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.OpenAIChatRequestVerbosity?>
    {
        /// <inheritdoc />
        public override global::Helicone.OpenAIChatRequestVerbosity? Read(
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
                        return global::Helicone.OpenAIChatRequestVerbosityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.OpenAIChatRequestVerbosity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.OpenAIChatRequestVerbosity?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.OpenAIChatRequestVerbosity? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Helicone.OpenAIChatRequestVerbosityExtensions.ToValueString(value.Value));
            }
        }
    }
}
