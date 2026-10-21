#nullable enable

namespace CursorAgents.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnvironmentBuildSettingsPullLatestCodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CursorAgents.EnvironmentBuildSettingsPullLatestCode>
    {
        /// <inheritdoc />
        public override global::CursorAgents.EnvironmentBuildSettingsPullLatestCode Read(
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
                        return global::CursorAgents.EnvironmentBuildSettingsPullLatestCodeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CursorAgents.EnvironmentBuildSettingsPullLatestCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CursorAgents.EnvironmentBuildSettingsPullLatestCode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CursorAgents.EnvironmentBuildSettingsPullLatestCode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::CursorAgents.EnvironmentBuildSettingsPullLatestCodeExtensions.ToValueString(value));
        }
    }
}
