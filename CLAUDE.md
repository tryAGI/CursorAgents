# CLAUDE.md -- CursorAgents SDK

## Overview

Auto-generated C# SDK for [Cursor Cloud Agents](https://cursor.com/) -- API for launching autonomous AI coding agents on GitHub repositories that read codebases, make changes, and optionally create pull requests.
OpenAPI spec downloaded from `https://cursor.com/docs-static/cloud-agents-openapi.yaml`.

## Build & Test

```bash
dotnet build CursorAgents.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (converted to Basic auth at request time):

```csharp
var client = new CursorAgentsClient(apiKey); // CURSORAGENTS_API_KEY env var
```

**Important:** The Cursor Cloud Agents API uses HTTP Basic Authentication with the API key as the username and an empty password. The SDK accepts the key as a Bearer token and `PrepareRequest` converts it to Basic auth automatically.

## Key Files

- `src/libs/CursorAgents/openapi.yaml` -- OpenAPI spec (downloaded from Cursor docs)
- `src/libs/CursorAgents/generate.sh` -- Downloads spec, runs autosdk
- `src/libs/CursorAgents/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/CursorAgents/CursorAgentsClient.Auth.cs` -- Converts Bearer to Basic auth (`apiKey:` base64-encoded)
- `src/libs/CursorAgents/Extensions/CursorAgentsClient.Tools.cs` -- MEAI `AIFunction` tools (CreateAgent, ListAgents, GetAgent)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- Spec is a simple OpenAPI from Cursor with 3 endpoints (create, list, get agents)
- No spec fixes needed -- downloaded and used as-is
- No sub-client pattern -- all operations are on the flat `CursorAgentsClient`
- Uses `--exclude-deprecated-operations` flag

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsCreateAgentTool(autoCreatePr)` -- Launch an AI coding agent on a GitHub repository
- `AsListAgentsTool(limit)` -- List all cloud coding agents with status, repository, and summary
- `AsGetAgentTool()` -- Get status and details of a specific agent by ID (including PR URL)

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented -- Cursor Agents is an AI agent platform with no matching MEAI interface.
