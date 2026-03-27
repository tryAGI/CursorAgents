# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The CursorAgents SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models the ability to create and manage autonomous coding agents on GitHub repositories.

## Installation

```bash
dotnet add package CursorAgents
```

## Create Agent Tool

Use `AsCreateAgentTool()` to create an `AIFunction` that launches a cloud coding agent. Pass it to any `IChatClient` via `ChatOptions.Tools`.

```csharp
using Microsoft.Extensions.AI;
using CursorAgents;

// Create the CursorAgents tool
var cursorClient = new CursorAgentsClient(
    apiKey: Environment.GetEnvironmentVariable("CURSORAGENTS_API_KEY")!);

AIFunction createAgentTool = cursorClient.AsCreateAgentTool(
    autoCreatePr: true);

// Use with any IChatClient (OpenAI, Anthropic, Ollama, etc.)
IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [createAgentTool],
};

var messages = new List<ChatMessage>
{
    new(ChatRole.User,
        "Create a coding agent to add unit tests to the UserService class " +
        "in https://github.com/my-org/my-repo"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## List Agents Tool

Use `AsListAgentsTool()` to create an `AIFunction` that lists all cloud agents.

```csharp
using Microsoft.Extensions.AI;
using CursorAgents;

var cursorClient = new CursorAgentsClient(
    apiKey: Environment.GetEnvironmentVariable("CURSORAGENTS_API_KEY")!);

AIFunction listAgentsTool = cursorClient.AsListAgentsTool(limit: 10);

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [listAgentsTool],
};

var response = await chatClient.GetResponseAsync(
    "What coding agents are currently running?",
    options);

Console.WriteLine(response.Text);
```

## Get Agent Status Tool

Use `AsGetAgentTool()` to create an `AIFunction` that retrieves the status of a specific agent.

```csharp
using Microsoft.Extensions.AI;
using CursorAgents;

var cursorClient = new CursorAgentsClient(
    apiKey: Environment.GetEnvironmentVariable("CURSORAGENTS_API_KEY")!);

AIFunction getAgentTool = cursorClient.AsGetAgentTool();

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [getAgentTool],
};

var response = await chatClient.GetResponseAsync(
    "What is the status of agent bc_abc123?",
    options);

Console.WriteLine(response.Text);
```

## Combining All Tools

You can provide all three tools simultaneously, letting the model decide which to use.

```csharp
using Microsoft.Extensions.AI;
using CursorAgents;

var cursorClient = new CursorAgentsClient(
    apiKey: Environment.GetEnvironmentVariable("CURSORAGENTS_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        cursorClient.AsCreateAgentTool(),
        cursorClient.AsListAgentsTool(),
        cursorClient.AsGetAgentTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User,
        "Check if there are any running agents. If not, create one to " +
        "add a CI workflow to https://github.com/my-org/my-repo."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Tool Details

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsCreateAgentTool()` | `CreateCodingAgent` | Launches an AI coding agent on a GitHub repository |
| `AsListAgentsTool()` | `ListCodingAgents` | Lists all cloud coding agents with status |
| `AsGetAgentTool()` | `GetCodingAgentStatus` | Gets status and details of a specific agent |

### AsCreateAgentTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `autoCreatePr` | `bool` | `true` | Auto-create a PR when the agent completes |

### AsListAgentsTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `limit` | `int` | `20` | Maximum number of agents to return |
