#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Helicone.JsonConverters
{
    /// <inheritdoc />
    public class RequestFilterNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Helicone.RequestFilterNode>
    {
        /// <inheritdoc />
        public override global::Helicone.RequestFilterNode Read(
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
            if (__jsonProps.Contains("feedback")) __score0++;
            if (__jsonProps.Contains("properties")) __score0++;
            if (__jsonProps.Contains("request")) __score0++;
            if (__jsonProps.Contains("request_response_rmt")) __score0++;
            if (__jsonProps.Contains("response")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt")) __score0++;
            if (__jsonProps.Contains("values")) __score0++;
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

            global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt? pickLeafFeedbackOrResponsePropertiesValuesRmtSessions = default;
            global::Helicone.RequestFilterBranch? branch = default;
            global::Helicone.RequestFilterNodeEnum? @enum = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        pickLeafFeedbackOrResponsePropertiesValuesRmtSessions = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt>(__rawJson, options);
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
                        branch = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.RequestFilterBranch>(__rawJson, options);
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
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.RequestFilterNodeEnum>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pickLeafFeedbackOrResponsePropertiesValuesRmtSessions == null && branch == null && @enum == null)
            {
                try
                {
                    pickLeafFeedbackOrResponsePropertiesValuesRmtSessions = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    branch = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.RequestFilterBranch>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    @enum = global::System.Text.Json.JsonSerializer.Deserialize<global::Helicone.RequestFilterNodeEnum>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Helicone.RequestFilterNode(
                pickLeafFeedbackOrResponsePropertiesValuesRmtSessions,

                branch,

                @enum
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Helicone.RequestFilterNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPickLeafFeedbackOrResponsePropertiesValuesRmtSessions)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeafFeedbackOrResponsePropertiesValuesRmtSessions, typeof(global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt), options);
            }
            else if (value.IsBranch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Branch, typeof(global::Helicone.RequestFilterBranch), options);
            }
            else if (value.IsEnum)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum, typeof(global::Helicone.RequestFilterNodeEnum), options);
            }
        }
    }
}