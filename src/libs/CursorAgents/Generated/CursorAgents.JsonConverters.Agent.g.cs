#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace CursorAgents.JsonConverters
{
    /// <inheritdoc />
    public class AgentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CursorAgents.Agent>
    {
        /// <inheritdoc />
        public override global::CursorAgents.Agent Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("env")) __score0++;
            if (__jsonProps.Contains("env.type")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("latestRunId")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("updatedAt")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("autoCreatePR")) __score1++;
            if (__jsonProps.Contains("autoGenerateBranch")) __score1++;
            if (__jsonProps.Contains("branchName")) __score1++;
            if (__jsonProps.Contains("repos")) __score1++;
            if (__jsonProps.Contains("skipReviewerRequest")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::CursorAgents.AgentSummary? summary = default;
            global::CursorAgents.AgentVariant2? agentVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.AgentSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.AgentSummary> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.AgentSummary).Name}");
                        summary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.AgentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.AgentVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.AgentVariant2).Name}");
                        agentVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (summary == null && agentVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.AgentSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.AgentSummary> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.AgentSummary).Name}");
                    summary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.AgentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.AgentVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.AgentVariant2).Name}");
                    agentVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::CursorAgents.Agent(
                summary,

                agentVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CursorAgents.Agent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.AgentSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.AgentSummary?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.AgentSummary).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Summary!, typeInfo);
            }
            else if (value.IsAgentVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.AgentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.AgentVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.AgentVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentVariant2!, typeInfo);
            }
        }
    }
}