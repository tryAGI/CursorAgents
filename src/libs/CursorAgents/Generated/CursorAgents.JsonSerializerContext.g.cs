
#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
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

            typeof(global::CursorAgents.JsonConverters.EnvironmentOwnerJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentOwnerNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.CreateEnvironmentRequestOwnerJsonConverter),

            typeof(global::CursorAgents.JsonConverters.CreateEnvironmentRequestOwnerNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentBuildFailureTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentBuildFailureTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentBuildStatusJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentBuildStatusNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentBuildTriggerJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentBuildTriggerNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentActiveBuildDiscriminatorTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentActiveBuildDiscriminatorTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentActiveBuildFromBuildTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentActiveBuildFromBuildTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentActiveBuildFromUniversalImageTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentActiveBuildFromUniversalImageTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentHistoryEventKindJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentHistoryEventKindNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentHistoryEventSourceJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentHistoryEventSourceNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.SecretVersionTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.SecretVersionTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.SecretInventoryOwnerTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.SecretInventoryOwnerTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.InventorySecretVersionTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.InventorySecretVersionTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.SetSecretRequestTypeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.SetSecretRequestTypeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.SecretNameAmbiguousErrorErrorCodeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.SecretNameAmbiguousErrorErrorCodeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.ListSecretsScopeJsonConverter),

            typeof(global::CursorAgents.JsonConverters.ListSecretsScopeNullableJsonConverter),

            typeof(global::CursorAgents.JsonConverters.McpServerJsonConverter),

            typeof(global::CursorAgents.JsonConverters.AgentJsonConverter),

            typeof(global::CursorAgents.JsonConverters.JsonValueJsonConverter),

            typeof(global::CursorAgents.JsonConverters.CreateEnvironmentResponseJsonConverter),

            typeof(global::CursorAgents.JsonConverters.GetEnvironmentResponseJsonConverter),

            typeof(global::CursorAgents.JsonConverters.EnvironmentActiveBuildJsonConverter),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.CustomSubagentModel?, string, global::CursorAgents.ModelRef>),

            typeof(global::CursorAgents.JsonConverters.AllOfJsonConverter<global::CursorAgents.Environment, global::CursorAgents.ListEnvironmentsResponseItem>),

            typeof(global::CursorAgents.JsonConverters.AllOfJsonConverter<global::CursorAgents.SecretVersion, object>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.SecretNameAmbiguousError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.SecretNameAmbiguousError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.OneOfJsonConverter<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>),

            typeof(global::CursorAgents.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentRepo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentRepoFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Environment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentOwner), TypeInfoPropertyName = "EnvironmentOwner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentRepo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateEnvironmentResponse), TypeInfoPropertyName = "CreateEnvironmentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetEnvironmentResponse), TypeInfoPropertyName = "GetEnvironmentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.GetEnvironmentResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListEnvironmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.AllOf<global::CursorAgents.Environment, global::CursorAgents.ListEnvironmentsResponseItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AllOf<global::CursorAgents.Environment, global::CursorAgents.ListEnvironmentsResponseItem>), TypeInfoPropertyName = "AllOfEnvironmentListEnvironmentsResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListEnvironmentsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateEnvironmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateEnvironmentRequestOwner), TypeInfoPropertyName = "CreateEnvironmentRequestOwner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.UpdateEnvironmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentBuildFailure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentBuildFailureType), TypeInfoPropertyName = "EnvironmentBuildFailureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentBuildStatus), TypeInfoPropertyName = "EnvironmentBuildStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentBuildTrigger), TypeInfoPropertyName = "EnvironmentBuildTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListEnvironmentBuildsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentActiveBuild), TypeInfoPropertyName = "EnvironmentActiveBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentActiveBuildFromBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentActiveBuildFromUniversalImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentActiveBuildDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentActiveBuildDiscriminatorType), TypeInfoPropertyName = "EnvironmentActiveBuildDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentActiveBuildFromBuildType), TypeInfoPropertyName = "EnvironmentActiveBuildFromBuildType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentActiveBuildFromUniversalImageType), TypeInfoPropertyName = "EnvironmentActiveBuildFromUniversalImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentHistoryEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentHistoryEventKind), TypeInfoPropertyName = "EnvironmentHistoryEventKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.EnvironmentHistoryEventSource), TypeInfoPropertyName = "EnvironmentHistoryEventSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListEnvironmentHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentHistoryEvent>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SecretVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SecretVersionType), TypeInfoPropertyName = "SecretVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Repository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListSecretsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.AllOf<global::CursorAgents.SecretVersion, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AllOf<global::CursorAgents.SecretVersion, object>), TypeInfoPropertyName = "AllOfSecretVersionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SecretInventoryOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SecretInventoryOwnerType), TypeInfoPropertyName = "SecretInventoryOwnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SecretInventoryOwnerUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.InventorySecretVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.InventorySecretVersionType), TypeInfoPropertyName = "InventorySecretVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListSecretInventoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.InventorySecretVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListRepositoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.Repository>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SetSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SetSecretRequestType), TypeInfoPropertyName = "SetSecretRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SecretVersionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SecretNameAmbiguousError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SecretNameAmbiguousErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.SecretNameAmbiguousErrorErrorCode), TypeInfoPropertyName = "SecretNameAmbiguousErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CursorAgents.SecretVersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateSubTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.DeleteSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.CreateSubTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.AuthenticationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ErrorError1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.ListSecretsScope), TypeInfoPropertyName = "ListSecretsScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.OneOf<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>), TypeInfoPropertyName = "OneOfAuthenticationErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CursorAgents.OneOf<global::CursorAgents.SecretNameAmbiguousError, global::CursorAgents.Error>), TypeInfoPropertyName = "OneOfSecretNameAmbiguousErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelRefParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.RepoConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.CustomSubagent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.RunGitBranch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.McpServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.AgentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Run>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.RunUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.EnvironmentRepo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.AllOf<global::CursorAgents.Environment, global::CursorAgents.ListEnvironmentsResponseItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.EnvironmentBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.EnvironmentHistoryEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelParameterValueDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelVariantParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelParameterDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.ModelListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.AllOf<global::CursorAgents.SecretVersion, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.InventorySecretVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.Repository>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CursorAgents.SecretVersionSummary>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}