/*
order: 50
title: As Tool Creates List Tool
slug: as-tool-creates-list-tool

Verify that AsListAgentsTool creates a valid AIFunction.
*/

using Microsoft.Extensions.AI;

namespace CursorAgents.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsTool_CreatesListTool()
    {
        //// Create a client and wrap it as an MEAI tool.
        using var client = GetAuthenticatedClient();

        var tool = client.AsListAgentsTool();

        //// The tool has a name and description for use with any IChatClient.
        tool.Should().NotBeNull();
        tool.Name.Should().Be("ListCodingAgents");
        tool.Description.Should().NotBeNullOrWhiteSpace();
    }
}
