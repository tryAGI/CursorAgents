#nullable enable

namespace CursorAgents.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnvironmentActiveBuildFromUniversalImageTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CursorAgents.EnvironmentActiveBuildFromUniversalImageType>
    {
        /// <inheritdoc />
        public override global::CursorAgents.EnvironmentActiveBuildFromUniversalImageType Read(
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
                        return global::CursorAgents.EnvironmentActiveBuildFromUniversalImageTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CursorAgents.EnvironmentActiveBuildFromUniversalImageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CursorAgents.EnvironmentActiveBuildFromUniversalImageType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CursorAgents.EnvironmentActiveBuildFromUniversalImageType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::CursorAgents.EnvironmentActiveBuildFromUniversalImageTypeExtensions.ToValueString(value));
        }
    }
}
