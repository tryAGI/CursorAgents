#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://cursor.com/docs-static/cloud-agents-openapi.yaml

dotnet tool install --global autosdk.cli --prerelease
tmp_spec="$(mktemp)"
if curl \
  --fail \
  --silent \
  --show-error \
  --location \
  --retry 3 \
  --retry-delay 2 \
  --retry-all-errors \
  -o "$tmp_spec" \
  "https://cursor.com/docs-static/cloud-agents-openapi.yaml" && \
  grep -q '^openapi:' "$tmp_spec"; then
  mv "$tmp_spec" openapi.yaml
else
  echo "Warning: Cursor OpenAPI download is blocked; using committed openapi.yaml fallback." >&2
  rm -f "$tmp_spec"
fi

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace CursorAgents \
  --clientClassName CursorAgentsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
