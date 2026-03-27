/*
order: 40
title: As Tool Creates Agent Tool
slug: as-tool-creates-agent-tool

Verify that AsCreateAgentTool creates a valid AIFunction.
*/

using Microsoft.Extensions.AI;

namespace CursorAgents.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsTool_CreatesAgentTool()
    {
        //// Create a client and wrap it as an MEAI tool.
        using var client = GetAuthenticatedClient();

        var tool = client.AsCreateAgentTool();

        //// The tool has a name and description for use with any IChatClient.
        tool.Should().NotBeNull();
        tool.Name.Should().Be("CreateCodingAgent");
        tool.Description.Should().NotBeNullOrWhiteSpace();
    }
}
