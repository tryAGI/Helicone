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
                        function = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.ChatCompletionMessageFunctionToolCall>(__rawJson, options);
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
                        custom = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.ChatCompletionMessageCustomToolCall>(__rawJson, options);
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
                    function = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.ChatCompletionMessageFunctionToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    custom = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.ChatCompletionMessageCustomToolCall>(__rawJson, options);
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

            if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::Helicone.ChatCompletionMessageFunctionToolCall), options);
            }
            else if (value.IsCustom)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom, typeof(global::Helicone.ChatCompletionMessageCustomToolCall), options);
            }
        }
    }
}