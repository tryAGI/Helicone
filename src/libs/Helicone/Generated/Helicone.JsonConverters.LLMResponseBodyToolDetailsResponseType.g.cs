#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class LLMResponseBodyToolDetailsResponseTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.LLMResponseBodyToolDetailsResponseType>
    {
        /// <inheritdoc />
        public override global::Helicone.LLMResponseBodyToolDetailsResponseType Read(
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
                        return global::Helicone.LLMResponseBodyToolDetailsResponseTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.LLMResponseBodyToolDetailsResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.LLMResponseBodyToolDetailsResponseType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.LLMResponseBodyToolDetailsResponseType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Helicone.LLMResponseBodyToolDetailsResponseTypeExtensions.ToValueString(value));
        }
    }
}
