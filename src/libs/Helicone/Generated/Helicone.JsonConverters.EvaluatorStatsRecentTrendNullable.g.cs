#nullable enable

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public sealed class EvaluatorStatsRecentTrendNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.EvaluatorStatsRecentTrend?>
    {
        /// <inheritdoc />
        public override global::Helicone.EvaluatorStatsRecentTrend? Read(
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
                        return global::Helicone.EvaluatorStatsRecentTrendExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Helicone.EvaluatorStatsRecentTrend)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Helicone.EvaluatorStatsRecentTrend?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.EvaluatorStatsRecentTrend? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Helicone.EvaluatorStatsRecentTrendExtensions.ToValueString(value.Value));
            }
        }
    }
}
