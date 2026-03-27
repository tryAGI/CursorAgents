/*
order: 10
title: List Agents
slug: list-agents

Basic example showing how to create a client and list cloud agents.
*/

namespace CursorAgents.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListAgents()
    {
        //// Create a client with your Cursor API key.
        using var client = GetAuthenticatedClient();

        //// List cloud agents for the authenticated user.
        var response = await client.ListAgentsAsync(
            limit: 10);

        //// Access the returned agents.
        foreach (var agent in response.Agents)
        {
            Console.WriteLine($"Agent {agent.Id}: {agent.Name} ({agent.Status})");
        }
    }
}
