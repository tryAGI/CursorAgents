/*
order: 30
title: Get Conversation
slug: get-conversation

Retrieve the conversation history of a cloud agent, including user prompts and assistant responses.
*/

namespace CursorAgents.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetConversation()
    {
        //// Create a client with your Cursor API key.
        using var client = GetAuthenticatedClient();

        var agentId =
            Environment.GetEnvironmentVariable("CURSORAGENTS_TEST_AGENT_ID") is { Length: > 0 } idValue
                ? idValue
                : throw new AssertInconclusiveException(
                    "CURSORAGENTS_TEST_AGENT_ID environment variable is not found.");

        //// Retrieve the full conversation history for a specific agent.
        var response = await client.GetAgentConversationAsync(
            id: agentId);

        //// The response contains the agent ID and all messages in chronological order.
        response.Id.Should().NotBeNullOrWhiteSpace();
        response.Messages.Should().NotBeNull();

        foreach (var message in response.Messages)
        {
            var role = message.Type == GetAgentConversationResponseMessageType.UserMessage
                ? "User"
                : "Assistant";

            Console.WriteLine($"[{role}] {message.Text}");
        }
    }
}
