#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace CursorAgents.JsonConverters
{
    /// <inheritdoc />
    public class EnvironmentActiveBuildJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CursorAgents.EnvironmentActiveBuild>
    {
        /// <inheritdoc />
        public override global::CursorAgents.EnvironmentActiveBuild Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.EnvironmentActiveBuildDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.EnvironmentActiveBuildDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CursorAgents.EnvironmentActiveBuildDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::CursorAgents.EnvironmentActiveBuildFromBuild? build = default;
            if (discriminator?.Type == global::CursorAgents.EnvironmentActiveBuildDiscriminatorType.Build)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.EnvironmentActiveBuildFromBuild), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.EnvironmentActiveBuildFromBuild> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CursorAgents.EnvironmentActiveBuildFromBuild)}");
                build = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::CursorAgents.EnvironmentActiveBuildFromUniversalImage? universalImage = default;
            if (discriminator?.Type == global::CursorAgents.EnvironmentActiveBuildDiscriminatorType.UniversalImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.EnvironmentActiveBuildFromUniversalImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.EnvironmentActiveBuildFromUniversalImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CursorAgents.EnvironmentActiveBuildFromUniversalImage)}");
                universalImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::CursorAgents.EnvironmentActiveBuild(
                discriminator?.Type,
                build,

                universalImage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CursorAgents.EnvironmentActiveBuild value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBuild)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.EnvironmentActiveBuildFromBuild), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.EnvironmentActiveBuildFromBuild?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.EnvironmentActiveBuildFromBuild).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBuild(), typeInfo);
            }
            else if (value.IsUniversalImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.EnvironmentActiveBuildFromUniversalImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.EnvironmentActiveBuildFromUniversalImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.EnvironmentActiveBuildFromUniversalImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUniversalImage(), typeInfo);
            }
        }
    }
}