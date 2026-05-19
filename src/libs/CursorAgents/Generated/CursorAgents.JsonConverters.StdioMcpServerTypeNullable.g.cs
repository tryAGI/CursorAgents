#nullable enable

namespace CursorAgents.JsonConverters
{
    /// <inheritdoc />
    public sealed class StdioMcpServerTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CursorAgents.StdioMcpServerType?>
    {
        /// <inheritdoc />
        public override global::CursorAgents.StdioMcpServerType? Read(
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
                        return global::CursorAgents.StdioMcpServerTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CursorAgents.StdioMcpServerType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CursorAgents.StdioMcpServerType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CursorAgents.StdioMcpServerType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::CursorAgents.StdioMcpServerTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
