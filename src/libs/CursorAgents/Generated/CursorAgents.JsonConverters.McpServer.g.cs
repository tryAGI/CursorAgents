#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace CursorAgents.JsonConverters
{
    /// <inheritdoc />
    public class McpServerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CursorAgents.McpServer>
    {
        /// <inheritdoc />
        public override global::CursorAgents.McpServer Read(
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
            if (__jsonProps.Contains("args")) __score0++;
            if (__jsonProps.Contains("command")) __score0++;
            if (__jsonProps.Contains("env")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("auth")) __score1++;
            if (__jsonProps.Contains("auth.CLIENT_ID")) __score1++;
            if (__jsonProps.Contains("auth.CLIENT_SECRET")) __score1++;
            if (__jsonProps.Contains("auth.scopes")) __score1++;
            if (__jsonProps.Contains("headers")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::CursorAgents.StdioMcpServer? stdio = default;
            global::CursorAgents.RemoteMcpServer? remote = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.StdioMcpServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.StdioMcpServer> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.StdioMcpServer).Name}");
                        stdio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.RemoteMcpServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.RemoteMcpServer> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.RemoteMcpServer).Name}");
                        remote = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (stdio == null && remote == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.StdioMcpServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.StdioMcpServer> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.StdioMcpServer).Name}");
                    stdio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (stdio == null && remote == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.RemoteMcpServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.RemoteMcpServer> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.RemoteMcpServer).Name}");
                    remote = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::CursorAgents.McpServer(
                stdio,

                remote
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CursorAgents.McpServer value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.StdioMcpServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.StdioMcpServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.StdioMcpServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stdio!, typeInfo);
            }
            else if (value.IsRemote)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.RemoteMcpServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.RemoteMcpServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.RemoteMcpServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Remote!, typeInfo);
            }
        }
    }
}