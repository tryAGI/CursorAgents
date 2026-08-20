
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
            typeof(global::CursorAgents.JsonConverters.AgentEnvTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.AgentEnvTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.StdioMcpServerTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.StdioMcpServerTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.RemoteMcpServerTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.RemoteMcpServerTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.AgentSummaryStatusJsonConverter),

            typeof(global::CursorAgents.JsonConverters.AgentSummaryStatusNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.RunStatusJsonConverter),

            typeof(global::CursorAgents.JsonConverters.RunStatusNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.RunStreamToolCallDataStatusJsonConverter),

            typeof(global::CursorAgents.JsonConverters.RunStreamToolCallDataStatusNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.RunStreamToolCallEventEventJsonConverter),

            typeof(global::CursorAgents.JsonConverters.RunStreamToolCallEventEventNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.CustomSubagentModelJsonConverter),

            typeof(global::CursorAgents.JsonConverters.CustomSubagentModelNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.AgentModeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.AgentModeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.McpServerJsonConverter),

            typeof(global::CursorAgents.JsonConverters.AgentJsonConverter),

            typeof(global::CursorAgents.JsonConverters.JsonValueJsonConverter),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.CustomSubagentModel?, string, global::CursorAgents.ModelRef>),

            typeof(global::CursorAgents.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ImageDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ModelRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.ModelRefParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ModelRefParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RepoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentEnv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentEnvType), TypeInfoPropertyName = "AgentEnvType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.McpAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.StdioMcpServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.StdioMcpServerType), TypeInfoPropertyName = "StdioMcpServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RemoteMcpServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RemoteMcpServerType), TypeInfoPropertyName = "RemoteMcpServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.McpServer), TypeInfoPropertyName = "McpServer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentSummaryStatus), TypeInfoPropertyName = "AgentSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Agent), TypeInfoPropertyName = "Agent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.CustomSubagent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CustomSubagent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RunGitBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RunGit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.RunGitBranch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Run))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RunStatus), TypeInfoPropertyName = "RunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RunStreamToolCallTruncation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.JsonValue), TypeInfoPropertyName = "JsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RunStreamToolCallData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RunStreamToolCallDataStatus), TypeInfoPropertyName = "RunStreamToolCallDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RunStreamToolCallEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RunStreamToolCallEventEvent), TypeInfoPropertyName = "RunStreamToolCallEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.OneOf<global::CursorAgents.CustomSubagentModel?, string, global::CursorAgents.ModelRef>), TypeInfoPropertyName = "OneOfCustomSubagentModelStringModelRef2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CustomSubagentModel), TypeInfoPropertyName = "CustomSubagentModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateAgentRequestPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.McpServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentMode), TypeInfoPropertyName = "AgentMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.UsageTokenUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.RunUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AgentUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.RunUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ApiKeyInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ModelParameterValueDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ModelParameterDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.ModelParameterValueDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ModelVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.ModelVariantParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ModelVariantParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ModelListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.ModelParameterDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.ModelVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.ModelListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Repository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListRepositoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.Repository>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateSubTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateSubTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ErrorError1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelRefParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.RepoConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.CustomSubagent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.RunGitBranch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.McpServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.AgentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Run>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.RunUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelParameterValueDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelVariantParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelParameterDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Repository>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}