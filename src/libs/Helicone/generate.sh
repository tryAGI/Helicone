#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/Helicone/helicone/main/docs/swagger.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/Helicone/helicone/main/docs/swagger.json

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Helicone \
  --clientClassName HeliconeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# Fix: JsonSerializerContextTypes is generated in namespace System instead of Helicone
for f in Generated/*JsonSerializerContextTypes*; do
  [ -f "$f" ] && sed 's/^namespace System$/namespace Helicone/' "$f" > "$f.tmp" && mv "$f.tmp" "$f"
done
