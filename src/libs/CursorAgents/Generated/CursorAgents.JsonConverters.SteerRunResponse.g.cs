#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace CursorAgents.JsonConverters
{
    /// <inheritdoc />
    public class SteerRunResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CursorAgents.SteerRunResponse>
    {
        /// <inheritdoc />
        public override global::CursorAgents.SteerRunResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.SteerRunResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.SteerRunResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CursorAgents.SteerRunResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::CursorAgents.SteeredRunResponse? steered = default;
            if (discriminator?.Delivery == global::CursorAgents.SteerRunResponseDiscriminatorDelivery.Steered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.SteeredRunResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.SteeredRunResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CursorAgents.SteeredRunResponse)}");
                steered = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::CursorAgents.QueuedRunResponse? queued = default;
            if (discriminator?.Delivery == global::CursorAgents.SteerRunResponseDiscriminatorDelivery.Queued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.QueuedRunResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.QueuedRunResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CursorAgents.QueuedRunResponse)}");
                queued = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::CursorAgents.SteerRunResponse(
                discriminator?.Delivery,
                steered,

                queued
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CursorAgents.SteerRunResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSteered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.SteeredRunResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.SteeredRunResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.SteeredRunResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSteered(), typeInfo);
            }
            else if (value.IsQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CursorAgents.QueuedRunResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CursorAgents.QueuedRunResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CursorAgents.QueuedRunResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickQueued(), typeInfo);
            }
        }
    }
}