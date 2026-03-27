/*
order: 10
title: Create Agent
slug: create-agent

Launch a cloud agent to work autonomously on a GitHub repository.
*/

namespace CursorAgents.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_CreateAgent()
    {
        //// Create a client with your Cursor API key.
        using var client = GetAuthenticatedClient();

        var repositoryUrl =
            Environment.GetEnvironmentVariable("CURSORAGENTS_TEST_REPO") is { Length: > 0 } repoValue
                ? repoValue
                : throw new AssertInconclusiveException(
                    "CURSORAGENTS_TEST_REPO environment variable is not found.");

        //// Launch a coding agent with a prompt, source repository, and target branch settings.
        var response = await client.CreateAgentAsync(
            prompt: new CreateAgentRequestPrompt
            {
                Text = "Add a CONTRIBUTING.md file with guidelines for submitting pull requests",
            },
            source: new CreateAgentRequestSource
            {
                Repository = repositoryUrl,
                Ref = "main",
            },
            target: new CreateAgentRequestTarget
            {
                AutoCreatePr = true,
                BranchName = "cursor/add-contributing",
            });

        //// The response contains the agent ID, name, and initial status.
        response.Id.Should().NotBeNullOrWhiteSpace();
        response.Name.Should().NotBeNullOrWhiteSpace();
        response.CreatedAt.Should().BeOnOrBefore(DateTime.UtcNow);

        Console.WriteLine($"Agent created: {response.Id} ({response.Name})");
        Console.WriteLine($"Status: {response.Status}");
    }
}
