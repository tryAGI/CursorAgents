#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://cursor.com/docs-static/cloud-agents-openapi.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml "https://cursor.com/docs-static/cloud-agents-openapi.yaml"
autosdk generate openapi.yaml \
  --namespace CursorAgents \
  --clientClassName CursorAgentsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
