
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
            typeof(global::CursorAgents.JsonConverters.AgentSummaryStatusJsonConverter),

            typeof(global::CursorAgents.JsonConverters.AgentSummaryStatusNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.RunStatusJsonConverter),

            typeof(global::CursorAgents.JsonConverters.RunStatusNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.AgentJsonConverter),

            typeof(global::CursorAgents.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ImageDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ModelRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RepoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentEnv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentSummaryStatus), TypeInfoPropertyName = "AgentSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Agent), TypeInfoPropertyName = "Agent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Run))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RunStatus), TypeInfoPropertyName = "RunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentRequestPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateRunRequestPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.AgentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.Run>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.IdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Artifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListArtifactsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.DownloadArtifactResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ApiKeyInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Repository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListRepositoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.Repository>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ErrorError1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.RepoConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.AgentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Run>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Repository>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}