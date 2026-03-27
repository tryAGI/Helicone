#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class NewDatasetParamsDatasetTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.NewDatasetParamsDatasetType?>
    {
        /// <inheritdoc />
        public override global::Helicone.NewDatasetParamsDatasetType? Read(
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
                        return global::Helicone.NewDatasetParamsDatasetTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.NewDatasetParamsDatasetType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.NewDatasetParamsDatasetType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.NewDatasetParamsDatasetType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Helicone.NewDatasetParamsDatasetTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
