#nullable enable

namespace CursorAgents.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateEnvironmentBuildSettingsPullLatestCodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CursorAgents.UpdateEnvironmentBuildSettingsPullLatestCode>
    {
        /// <inheritdoc />
        public override global::CursorAgents.UpdateEnvironmentBuildSettingsPullLatestCode Read(
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
                        return global::CursorAgents.UpdateEnvironmentBuildSettingsPullLatestCodeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CursorAgents.UpdateEnvironmentBuildSettingsPullLatestCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CursorAgents.UpdateEnvironmentBuildSettingsPullLatestCode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CursorAgents.UpdateEnvironmentBuildSettingsPullLatestCode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::CursorAgents.UpdateEnvironmentBuildSettingsPullLatestCodeExtensions.ToValueString(value));
        }
    }
}
