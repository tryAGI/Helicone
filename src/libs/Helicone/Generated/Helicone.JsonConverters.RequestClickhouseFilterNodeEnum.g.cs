#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestClickhouseFilterNodeEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.RequestClickhouseFilterNodeEnum>
    {
        /// <inheritdoc />
        public override global::Helicone.RequestClickhouseFilterNodeEnum Read(
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
                        return global::Helicone.RequestClickhouseFilterNodeEnumExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.RequestClickhouseFilterNodeEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.RequestClickhouseFilterNodeEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.RequestClickhouseFilterNodeEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Helicone.RequestClickhouseFilterNodeEnumExtensions.ToValueString(value));
        }
    }
}
