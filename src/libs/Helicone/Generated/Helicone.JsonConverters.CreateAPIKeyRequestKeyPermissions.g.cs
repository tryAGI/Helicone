#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAPIKeyRequestKeyPermissionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.CreateAPIKeyRequestKeyPermissions>
    {
        /// <inheritdoc />
        public override global::Helicone.CreateAPIKeyRequestKeyPermissions Read(
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
                        return global::Helicone.CreateAPIKeyRequestKeyPermissionsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.CreateAPIKeyRequestKeyPermissions)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.CreateAPIKeyRequestKeyPermissions);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.CreateAPIKeyRequestKeyPermissions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Helicone.CreateAPIKeyRequestKeyPermissionsExtensions.ToValueString(value));
        }
    }
}
