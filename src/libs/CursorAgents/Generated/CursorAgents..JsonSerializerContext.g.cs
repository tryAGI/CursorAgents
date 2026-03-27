
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::CursorAgents.JsonConverters.CreateAgentResponseStatusJsonConverter),

            typeof(global::CursorAgents.JsonConverters.CreateAgentResponseStatusNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.ListAgentsResponseAgentStatusJsonConverter),

            typeof(global::CursorAgents.JsonConverters.ListAgentsResponseAgentStatusNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.GetAgentResponseStatusJsonConverter),

            typeof(global::CursorAgents.JsonConverters.GetAgentResponseStatusNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.GetAgentConversationResponseMessageTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.GetAgentConversationResponseMessageTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ImageDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentRequestPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentRequestSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentRequestTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentRequestWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ErrorError1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Artifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListArtifactsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetArtifactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AddFollowupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AddFollowupRequestPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentResponseSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentResponseTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.ListAgentsResponseAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListAgentsResponseAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListAgentsResponseAgentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListAgentsResponseAgentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListAgentsResponseAgentTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetAgentResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetAgentResponseSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetAgentResponseTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.DeleteAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AddFollowupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.StopAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetAgentConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.GetAgentConversationResponseMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetAgentConversationResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetAgentConversationResponseMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetMeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListRepositoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.ListRepositoriesResponseRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListRepositoriesResponseRepositorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ListAgentsResponseAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.GetAgentConversationResponseMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ListRepositoriesResponseRepositorie>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}