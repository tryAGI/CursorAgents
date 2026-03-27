# Authentication

The CursorAgents SDK uses Bearer token authentication. The SDK automatically converts the Bearer token to HTTP Basic Auth (API key as username, empty password) via a `PrepareRequest` hook, matching the Cursor Cloud Agents API requirements.

## Basic Usage

```csharp
using CursorAgents;

var client = new CursorAgentsClient(apiKey: Environment.GetEnvironmentVariable("CURSORAGENTS_API_KEY")!);
```

You do not need to handle the Basic Auth conversion yourself -- the SDK does it automatically.

## Environment Variable

| Variable | Description |
|----------|-------------|
| `CURSORAGENTS_API_KEY` | Your Cursor Cloud Agents API key |
