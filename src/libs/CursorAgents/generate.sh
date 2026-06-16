#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://cursor.com/docs-static/cloud-agents-openapi.yaml
install_autosdk_cli
tmp_spec="$(mktemp)"
if fetch_spec \
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
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations
