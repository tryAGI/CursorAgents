
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ImageDimension? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.Image? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ModelRef? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.ModelRefParam>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ModelRefParam? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RepoConfig? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.AgentEnv? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.AgentEnvType? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.McpAuth? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.StdioMcpServer? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.StdioMcpServerType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RemoteMcpServer? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RemoteMcpServerType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.McpServer? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.AgentSummary? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.AgentSummaryStatus? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.Agent? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.AgentVariant2? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.RepoConfig>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.CustomSubagent>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CustomSubagent? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RunGitBranch? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RunGit? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.RunGitBranch>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.Run? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RunStatus? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RunStreamToolCallTruncation? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.JsonValue? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RunStreamToolCallData? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RunStreamToolCallDataStatus? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RunStreamToolCallEvent? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RunStreamToolCallEventEvent? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.OneOf<global::CursorAgents.CustomSubagentModel?, string, global::CursorAgents.ModelRef>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CustomSubagentModel? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CreateAgentRequest? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CreateAgentRequestPrompt? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.Image>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.McpServer>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.AgentMode? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CreateRunRequest? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.FollowupRunRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SteerRunRequest? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RunPrompt? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SteerRunRequestDelivery? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CreateAgentResponse? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CreateRunResponse? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SteerRunResponse? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SteeredRunResponse? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.QueuedRunResponse? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SteerRunResponseDiscriminator? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SteerRunResponseDiscriminatorDelivery? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SteeredRunResponseDelivery? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.QueuedRunResponseDelivery? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListAgentsResponse? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.AgentSummary>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListRunsResponse? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.Run>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.IdResponse? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.Artifact? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListArtifactsResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.Artifact>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.DownloadArtifactResponse? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.UsageTokenUsage? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.RunUsage? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.AgentUsageResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.RunUsage>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentRepo? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentRepoFile? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuildSettings? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuildSettingsPullLatestCode? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.UpdateEnvironmentBuildSettings? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.UpdateEnvironmentBuildSettingsPullLatestCode? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.Environment? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentOwner? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentRepo>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CreateEnvironmentResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.GetEnvironmentResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.GetEnvironmentResponseVariant2? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListEnvironmentsResponse? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.AllOf<global::CursorAgents.Environment, global::CursorAgents.ListEnvironmentsResponseItem>>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.AllOf<global::CursorAgents.Environment, global::CursorAgents.ListEnvironmentsResponseItem>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListEnvironmentsResponseItem? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CreateEnvironmentRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CreateEnvironmentRequestOwner? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.UpdateEnvironmentRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.StartEnvironmentBuildRequest? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.StartEnvironmentBuildRef>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.StartEnvironmentBuildRef? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.StartEnvironmentBuildResponse? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuildFailure? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuildFailureType? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuildRequestedRef? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuildRepoCommit? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuild? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuildStatus? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuildTrigger? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuildSource? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentBuildRequestedRef>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentBuildRepoCommit>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentBuildSnapshotState? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListEnvironmentBuildsResponse? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentBuild>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentActiveBuild? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentActiveBuildFromBuild? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentActiveBuildFromUniversalImage? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentActiveBuildDiscriminator? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentActiveBuildDiscriminatorType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentActiveBuildFromBuildType? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentActiveBuildFromUniversalImageType? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentHistoryEvent? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentHistoryEventKind? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentHistoryEventSource? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListEnvironmentHistoryResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.EnvironmentHistoryEvent>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ApiKeyInfo? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ModelParameterValueDefinition? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ModelParameterDefinition? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.ModelParameterValueDefinition>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ModelVariant? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.ModelVariantParam>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ModelVariantParam? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ModelListItem? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.ModelParameterDefinition>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.ModelVariant>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListModelsResponse? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.ModelListItem>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SecretVersion? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SecretVersionType? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.Repository? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListSecretsResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.AllOf<global::CursorAgents.SecretVersion, object>>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.AllOf<global::CursorAgents.SecretVersion, object>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SecretInventoryOwner? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SecretInventoryOwnerType? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SecretInventoryOwnerUser? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.InventorySecretVersion? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.InventorySecretVersionType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListSecretInventoryResponse? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.InventorySecretVersion>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListRepositoriesResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.Repository>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SetSecretRequest? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SetSecretRequestType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SecretVersionSummary? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SecretNameAmbiguousError? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SecretNameAmbiguousErrorError? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SecretNameAmbiguousErrorErrorCode? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CursorAgents.SecretVersionSummary>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CreateSubTokenRequest? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.DeleteSecretResponse? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.CreateSubTokenResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.AuthenticationError? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.Error? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ErrorError1? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListEnvironmentsOwner? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListEnvironmentBuildsStatus? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.ListSecretsScope? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.OneOf<global::CursorAgents.AuthenticationError, global::CursorAgents.Error>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.OneOf<global::CursorAgents.SecretNameAmbiguousError, global::CursorAgents.Error>? Type169 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.ModelRefParam>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.RepoConfig>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.CustomSubagent>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.RunGitBranch>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.Image>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.McpServer>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.AgentSummary>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.Run>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.Artifact>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.RunUsage>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.EnvironmentRepo>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.AllOf<global::CursorAgents.Environment, global::CursorAgents.ListEnvironmentsResponseItem>>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.StartEnvironmentBuildRef>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.EnvironmentBuildRequestedRef>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.EnvironmentBuildRepoCommit>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.EnvironmentBuild>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.EnvironmentHistoryEvent>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.ModelParameterValueDefinition>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.ModelVariantParam>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.ModelParameterDefinition>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.ModelVariant>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.ModelListItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.AllOf<global::CursorAgents.SecretVersion, object>>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.InventorySecretVersion>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.Repository>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CursorAgents.SecretVersionSummary>? ListType27 { get; set; }
    }
}