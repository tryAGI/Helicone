#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public class TokenMetricStatsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.TokenMetricStats>
    {
        /// <inheritdoc />
        public override global::Helicone.TokenMetricStats Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Helicone.MetricStats? metricStats = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Helicone.MetricStats), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Helicone.MetricStats> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Helicone.MetricStats).Name}");
                metricStats = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Helicone.TokenMetricStatsVariant2? tokenMetricStatsVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Helicone.TokenMetricStatsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Helicone.TokenMetricStatsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Helicone.TokenMetricStatsVariant2).Name}");
                tokenMetricStatsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Helicone.TokenMetricStats(
                metricStats,

                tokenMetricStatsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.TokenMetricStats value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsMetricStats)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Helicone.MetricStats), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Helicone.MetricStats?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Helicone.MetricStats).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.MetricStats!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsTokenMetricStatsVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Helicone.TokenMetricStatsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Helicone.TokenMetricStatsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Helicone.TokenMetricStatsVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.TokenMetricStatsVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}