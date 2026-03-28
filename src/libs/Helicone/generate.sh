#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/Helicone/helicone/main/docs/swagger.json

# Fix 1: Rename "equals" property to "eq" in operator schemas to avoid CS0108 (shadowing object.Equals())
jq '
  walk(
    if type == "object" and has("properties") and (.properties | has("equals")) then
      .properties.eq = .properties.equals |
      del(.properties.equals) |
      if has("required") then
        .required = [.required[] | if . == "equals" then "eq" else . end]
      else . end
    else . end
  )
' openapi.yaml > openapi_fixed.yaml
mv openapi_fixed.yaml openapi.yaml

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Helicone \
  --clientClassName HeliconeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# Fix 2: JsonSerializerContextTypes is generated in namespace System instead of Helicone
for f in Generated/*JsonSerializerContextTypes*; do
  [ -f "$f" ] && sed -i '' 's/^namespace System$/namespace Helicone/' "$f"
done
