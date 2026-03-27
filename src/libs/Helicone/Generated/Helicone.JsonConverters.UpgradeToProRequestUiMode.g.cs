#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpgradeToProRequestUiModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.UpgradeToProRequestUiMode>
    {
        /// <inheritdoc />
        public override global::Helicone.UpgradeToProRequestUiMode Read(
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
                        return global::Helicone.UpgradeToProRequestUiModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.UpgradeToProRequestUiMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.UpgradeToProRequestUiMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.UpgradeToProRequestUiMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Helicone.UpgradeToProRequestUiModeExtensions.ToValueString(value));
        }
    }
}
