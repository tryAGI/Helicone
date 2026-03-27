#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class Prompt2025VersionPromptBodyToolTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.Prompt2025VersionPromptBodyToolType?>
    {
        /// <inheritdoc />
        public override global::Helicone.Prompt2025VersionPromptBodyToolType? Read(
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
                        return global::Helicone.Prompt2025VersionPromptBodyToolTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.Prompt2025VersionPromptBodyToolType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.Prompt2025VersionPromptBodyToolType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.Prompt2025VersionPromptBodyToolType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Helicone.Prompt2025VersionPromptBodyToolTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
