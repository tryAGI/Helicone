#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public class PromptsFilterNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.PromptsFilterNode>
    {
        /// <inheritdoc />
        public override global::Helicone.PromptsFilterNode Read(
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
            if (__jsonProps.Contains("prompt_v2")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("left")) __score1++;
            if (__jsonProps.Contains("operator")) __score1++;
            if (__jsonProps.Contains("right")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Helicone.PickFilterLeafPromptV2? pickLeafPromptV2 = default;
            global::Helicone.PromptsFilterBranch? branch = default;
            global::Helicone.PromptsFilterNodeEnum? @enum = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        pickLeafPromptV2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.PickFilterLeafPromptV2>(__rawJson, options);
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
                        branch = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.PromptsFilterBranch>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.PromptsFilterNodeEnum>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pickLeafPromptV2 == null && branch == null && @enum == null)
            {
                try
                {
                    pickLeafPromptV2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.PickFilterLeafPromptV2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    branch = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.PromptsFilterBranch>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    @enum = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.PromptsFilterNodeEnum>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Helicone.PromptsFilterNode(
                pickLeafPromptV2,

                branch,

                @enum
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.PromptsFilterNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPickLeafPromptV2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeafPromptV2, typeof(global::Helicone.PickFilterLeafPromptV2), options);
            }
            else if (value.IsBranch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Branch, typeof(global::Helicone.PromptsFilterBranch), options);
            }
            else if (value.IsEnum)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum, typeof(global::Helicone.PromptsFilterNodeEnum), options);
            }
        }
    }
}