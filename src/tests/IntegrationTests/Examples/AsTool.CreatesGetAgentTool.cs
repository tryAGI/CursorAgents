/*
order: 60
title: As Tool Creates Get Agent Tool
slug: as-tool-creates-get-agent-tool

Verify that AsGetAgentTool creates a valid AIFunction.
*/

using Microsoft.Extensions.AI;

namespace CursorAgents.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsTool_CreatesGetAgentTool()
    {
        //// Create a client and wrap it as an MEAI tool.
        using var client = GetAuthenticatedClient();

        var tool = client.AsGetAgentTool();

        //// The tool has a name and description for use with any IChatClient.
        tool.Should().NotBeNull();
        tool.Name.Should().Be("GetCodingAgentStatus");
        tool.Description.Should().NotBeNullOrWhiteSpace();
    }
}
