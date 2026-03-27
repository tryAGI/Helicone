#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenAIChatRequestToolChoiceEnumFunctionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType>
    {
        /// <inheritdoc />
        public override global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType Read(
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
                        return global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Helicone.OpenAIChatRequestToolChoiceEnumFunctionTypeExtensions.ToValueString(value));
        }
    }
}
