#nullable enable

namespace CursorAgents.JsonConverters
{
    /// <inheritdoc />
    public sealed class RunStreamToolCallEventEventNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CursorAgents.RunStreamToolCallEventEvent?>
    {
        /// <inheritdoc />
        public override global::CursorAgents.RunStreamToolCallEventEvent? Read(
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
                        return global::CursorAgents.RunStreamToolCallEventEventExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CursorAgents.RunStreamToolCallEventEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CursorAgents.RunStreamToolCallEventEvent?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CursorAgents.RunStreamToolCallEventEvent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::CursorAgents.RunStreamToolCallEventEventExtensions.ToValueString(value.Value));
            }
        }
    }
}
