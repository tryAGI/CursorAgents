#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace CursorAgents.JsonConverters
{
    /// <inheritdoc />
    public class CreateRunRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CursorAgents.CreateRunRequest>
    {
        /// <inheritdoc />
        public override global::CursorAgents.CreateRunRequest Read(
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
            if (__jsonProps.Contains("envVars")) __score0++;
            if (__jsonProps.Contains("mcpServers")) __score0++;
            if (__jsonProps.Contains("mode")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("model.id")) __score0++;
            if (__jsonProps.Contains("model.params")) __score0++;
            if (__jsonProps.Contains("prompt")) __score0++;
            if (__jsonProps.Contains("prompt.images")) __score0++;
            if (__jsonProps.Contains("prompt.text")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("delivery")) __score1++;
            if (__jsonProps.Contains("prompt")) __score1++;
            if (__jsonProps.Contains("prompt.images")) __score1++;
            if (__jsonProps.Contains("prompt.text")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::CursorAgents.FollowupRunRequest? followup = default;
            global::CursorAgents.SteerRunRequest? steer = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.FollowupRunRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.FollowupRunRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.FollowupRunRequest).Name}");
                        followup = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.SteerRunRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.SteerRunRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.SteerRunRequest).Name}");
                        steer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (followup == null && steer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.FollowupRunRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.FollowupRunRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.FollowupRunRequest).Name}");
                    followup = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (followup == null && steer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.SteerRunRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.SteerRunRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.SteerRunRequest).Name}");
                    steer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::CursorAgents.CreateRunRequest(
                followup,

                steer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CursorAgents.CreateRunRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFollowup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.FollowupRunRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.FollowupRunRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.FollowupRunRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFollowup(), typeInfo);
            }
            else if (value.IsSteer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.SteerRunRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.SteerRunRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.SteerRunRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSteer(), typeInfo);
            }
        }
    }
}