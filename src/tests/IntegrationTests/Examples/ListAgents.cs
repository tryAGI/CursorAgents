/*
order: 20
title: List Agents
slug: list-agents

List cloud agents and check their statuses.
*/

namespace CursorAgents.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListAgents()
    {
        //// Create a client with your Cursor API key.
        using var client = GetAuthenticatedClient();

        //// List cloud agents for the authenticated user with a page limit.
        var response = await client.ListAgentsAsync(
            limit: 10);

        //// The response contains a list of agents with their status and metadata.
        response.Agents.Should().NotBeNull();

        foreach (var agent in response.Agents)
        {
            agent.Id.Should().NotBeNullOrWhiteSpace();
            agent.Name.Should().NotBeNullOrWhiteSpace();

            Console.WriteLine($"Agent {agent.Id}: {agent.Name}");
            Console.WriteLine($"  Status: {agent.Status.ToValueString()}");
            Console.WriteLine($"  Created: {agent.CreatedAt}");

            if (agent.Summary is { Length: > 0 })
            {
                Console.WriteLine($"  Summary: {agent.Summary}");
            }
        }

        //// Use the NextCursor property for pagination when there are more results.
        if (response.NextCursor is { Length: > 0 })
        {
            Console.WriteLine($"Next page cursor: {response.NextCursor}");
        }
    }
}
