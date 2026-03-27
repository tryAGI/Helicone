#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionMessageToolCallJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.ChatCompletionMessageToolCall>
    {
        /// <inheritdoc />
        public override global::Helicone.ChatCompletionMessageToolCall Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("function")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("custom")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Helicone.ChatCompletionMessageFunctionToolCall? function = default;
            global::Helicone.ChatCompletionMessageCustomToolCall? custom = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Helicone.ChatCompletionMessageFunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Helicone.ChatCompletionMessageFunctionToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Helicone.ChatCompletionMessageFunctionToolCall).Name}");
                        function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Helicone.ChatCompletionMessageCustomToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Helicone.ChatCompletionMessageCustomToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Helicone.ChatCompletionMessageCustomToolCall).Name}");
                        custom = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (function == null && custom == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Helicone.ChatCompletionMessageFunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Helicone.ChatCompletionMessageFunctionToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Helicone.ChatCompletionMessageFunctionToolCall).Name}");
                    function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Helicone.ChatCompletionMessageCustomToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Helicone.ChatCompletionMessageCustomToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Helicone.ChatCompletionMessageCustomToolCall).Name}");
                    custom = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Helicone.ChatCompletionMessageToolCall(
                function,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.ChatCompletionMessageToolCall value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Helicone.ChatCompletionMessageFunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Helicone.ChatCompletionMessageFunctionToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Helicone.ChatCompletionMessageFunctionToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Helicone.ChatCompletionMessageCustomToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Helicone.ChatCompletionMessageCustomToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Helicone.ChatCompletionMessageCustomToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom, typeInfo);
            }
        }
    }
}