#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace CursorAgents;

/// <summary>
/// Extensions for using CursorAgentsClient as MEAI tools with any IChatClient.
/// </summary>
public static class CursorAgentsToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that launches a cloud coding agent
    /// on a specified GitHub repository.
    /// </summary>
    /// <param name="client">The CursorAgents client to use.</param>
    /// <param name="autoCreatePr">Whether to automatically create a pull request when the agent completes (default: true).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateAgentTool(
        this CursorAgentsClient client,
        bool autoCreatePr = true)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, string repository, string? branch, string? targetBranch, CancellationToken cancellationToken) =>
            {
                var response = await client.CreateAgentAsync(
                    prompt: new CreateAgentRequestPrompt
                    {
                        Text = prompt,
                    },
                    source: new CreateAgentRequestSource
                    {
                        Repository = repository,
                        Ref = branch,
                    },
                    target: new CreateAgentRequestTarget
                    {
                        AutoCreatePr = autoCreatePr,
                        BranchName = targetBranch,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreateAgentResponse(response);
            },
            name: "CreateCodingAgent",
            description: "Launches an AI coding agent to work autonomously on a GitHub repository. The agent reads the codebase, makes changes, and optionally creates a pull request. Requires a prompt describing the task, the repository URL, and optionally a source branch and target branch name.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all cloud agents
    /// for the authenticated user.
    /// </summary>
    /// <param name="client">The CursorAgents client to use.</param>
    /// <param name="limit">Maximum number of agents to return (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListAgentsTool(
        this CursorAgentsClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.ListAgentsAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatListAgentsResponse(response);
            },
            name: "ListCodingAgents",
            description: "Lists all cloud coding agents for the authenticated user, including their current status (CREATING, RUNNING, FINISHED, ERROR, EXPIRED), repository, branch, and summary of work done.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status
    /// and details of a specific cloud agent.
    /// </summary>
    /// <param name="client">The CursorAgents client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetAgentTool(this CursorAgentsClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string agentId, CancellationToken cancellationToken) =>
            {
                var response = await client.GetAgentAsync(
                    id: agentId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatGetAgentResponse(response);
            },
            name: "GetCodingAgentStatus",
            description: "Retrieves the current status and details of a specific cloud coding agent by its ID. Returns the agent's name, status, source repository, target branch, PR URL, and a summary of work completed.");
    }

    private static string FormatCreateAgentResponse(CreateAgentResponse response)
    {
        var parts = new List<string>
        {
            $"Agent created successfully.",
            $"ID: {response.Id}",
            $"Name: {response.Name}",
            $"Status: {response.Status}",
            $"Created: {response.CreatedAt:u}",
        };

        if (response.Target.BranchName is { Length: > 0 } branch)
        {
            parts.Add($"Branch: {branch}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatListAgentsResponse(ListAgentsResponse response)
    {
        var parts = new List<string>();

        if (response.Agents is { Count: 0 })
        {
            return "No agents found.";
        }

        parts.Add($"Found {response.Agents.Count} agent(s):");

        foreach (var agent in response.Agents)
        {
            var entry = $"- [{agent.Status.ToValueString()}] {agent.Name} (ID: {agent.Id})";

            if (agent.Source.Repository is { Length: > 0 } repo)
            {
                entry += $" — {repo}";
            }

            if (agent.Summary is { Length: > 0 } summary)
            {
                entry += $"\n  Summary: {summary}";
            }

            parts.Add(entry);
        }

        if (response.NextCursor is { Length: > 0 })
        {
            parts.Add($"\nMore results available (cursor: {response.NextCursor})");
        }

        return string.Join("\n", parts);
    }

    private static string FormatGetAgentResponse(GetAgentResponse response)
    {
        var parts = new List<string>
        {
            $"Agent: {response.Name}",
            $"ID: {response.Id}",
            $"Status: {response.Status.ToValueString()}",
            $"Created: {response.CreatedAt:u}",
        };

        if (response.Source.Repository is { Length: > 0 } repo)
        {
            parts.Add($"Repository: {repo}");
        }

        if (response.Source.Ref is { Length: > 0 } sourceRef)
        {
            parts.Add($"Source branch: {sourceRef}");
        }

        if (response.Target.BranchName is { Length: > 0 } branch)
        {
            parts.Add($"Target branch: {branch}");
        }

        if (response.Target.Url is { Length: > 0 } url)
        {
            parts.Add($"View: {url}");
        }

        if (response.Target.PrUrl is { Length: > 0 } prUrl)
        {
            parts.Add($"PR: {prUrl}");
        }

        if (response.Summary is { Length: > 0 } summary)
        {
            parts.Add($"Summary: {summary}");
        }

        return string.Join("\n", parts);
    }
}
